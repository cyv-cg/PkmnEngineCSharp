using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;
using System.Collections.Generic;

using static PkmnEngine.Global;
using static PkmnEngine.BattleActionCodes;
using PkmnEngine.Strings;

// TODO: Get this shit out of here!
using PkmnEngine.GodotV;
using System;

namespace PkmnEngine {
	public class BattleOverException : Exception {
		public BattleOverException() {}
	}

	public class Battle {
		public const u8 SIDE_CLIENT = 0;
		public const u8 SIDE_REMOTE = 1;

		private static List<NextTurnEvent> OnNextTurn = new List<NextTurnEvent>();

		public Battle() {
			this.seed = (int)System.DateTimeOffset.Now.ToUnixTimeMilliseconds();
		}
		public Battle(BattleFormat format, params TrainerProfile[] players)
		{
			this.format = format;
			if (players.Length > format.numPlayers) {
				throw new System.ArgumentOutOfRangeException($"{format} battles do not support {players.Length} players. (Maximum of {format.numPlayers})");
			}

			// Configure the battle's random number generator.
			this.seed = (int)System.DateTimeOffset.Now.ToUnixTimeMilliseconds();
			this.rand = new System.Random(seed);

			this.players = new TrainerBattleContext[format.numPlayers];
			BattleState initialState = CreateInitialState(players);
			this.CurrentState = initialState;
			this.History = new BattleState[0];
		}

		public readonly int seed;
		public readonly System.Random rand;
		public readonly bool isReplay;

		private readonly TrainerBattleContext[] players;
		public readonly BattleFormat format;

		private BattleState[] History { get; set; }
		public BattleState CurrentState { get; private set; }
		public u8 TurnCount { get { return (u8)History.Length; } }

		private u8 WinningSide { get; set; }

		public float Random01() {
			return (float)rand.NextDouble();
		}
		public u16 Random16() {
			return (u16)(rand.Next() & 0xFFFF);
		}
		public u32 Random32() {
			return ((u32)Random16() << 16) | Random16();
		}
		public u64 Random64() {
			return ((u64)Random32() << 32) | Random32();
		}

		public static async Task<float> RunEventChain(Callback cb, BattleMon target, object args) {
			float chain = 1;
			foreach (float x in await RunEvent<float>(cb, target, args)) {
				chain *= x;
			}
			return chain;
		}
		public static async Task<bool> RunEventCheck(Callback cb, BattleMon target, object args) {
			foreach (bool x in await RunEvent<bool>(cb, target, args)) {
				if (!x) {
					return false;
				}
			}
			return true;
		}
		public static async Task RunEvent(Callback cb, BattleMon target, object args) {
			await RunEvent<object>(cb, target, args);
		}
		public static async Task<T[]> RunEvent<T>(Callback cb, BattleMon target, object args) {
			EventHandler[] handlers = FindEventHandler(cb, target);
			List<T> retVal = new List<T>();

			// TODO: sort handlers by priority.

			foreach (EventHandler handler in handlers) {
				// Ability Suppression
				if (handler.effect == EffectType.ABILITY && target.HasStatus(Status.ABILITY_SUPPRESSION) && Abilities.CanBeSuppressed(target.ability)) {
					continue;
				}

				if (cb != Callback.OnNextTurn) {
					retVal.Add((T)await handler.callback.Invoke(args));
				}
				else {
					// First, act on all existing next-turn events.
					for (u8 i = 0; i < OnNextTurn.Count;) {
						NextTurnEvent @event = OnNextTurn[i];
						// But only act if the target is the same.
						if (@event.args.bm != target) {
							// Only iterate if the event is *not* performed.
							// This is because performed events are removed, so the list is shortened.
							i++;
							continue;
						}
						// Add it to the return list.
						retVal.Add((T)await @event.battleEvent.Invoke(@event.args));
						// Remove this event from the list.
						OnNextTurn.RemoveAt(i);
					}
					// If there is another next-turn event for this target, then queue it up.
					OnNextTurn.Add(new NextTurnEvent(handler.callback, new OnNextTurnParams((BattleState)args, target)));
				}
			}

			return retVal.ToArray();
		}

		public static async void RunEvent(Callback cb, Battle target, object args) {
			await RunEvent<object>(cb, target.CurrentState, args);
		}
		public static async Task<float> RunEventChain(Callback cb, Battle target, object args) {
			float chain = 1;
			foreach (float x in await RunEvent<float>(cb, target.CurrentState, args)) {
				chain *= x;
			}
			return chain;
		}
		public static async Task<bool> RunEventCheck(Callback cb, Battle target, object args) {
			foreach (bool x in await RunEvent<bool>(cb, target.CurrentState, args)) {
				if (!x) {
					return false;
				}
			}
			return true;
		}
		public static async Task<float> RunEventChain(Callback cb, BattleState target, object args, u8 side = u8.MaxValue) {
			float chain = 1;
			foreach (float x in await RunEvent<float>(cb, target, args, side)) {
				chain *= x;
			}
			return chain;
		}
		public static async Task<bool> RunEventCheck(Callback cb, BattleState target, object args, u8 side = u8.MaxValue) {
			foreach (bool x in await RunEvent<bool>(cb, target, args, side)) {
				if (!x) {
					return false;
				}
			}
			return true;
		}
		public static async void RunEvent(Callback cb, BattleState target, object args, u8 side = u8.MaxValue) {
			await RunEvent<object>(cb, target, args, side);
		}
		public static async Task<T[]> RunEvent<T>(Callback cb, BattleState target, object args, u8 side = u8.MaxValue) {
			EventHandler[] handlers = FindEventHandler(cb, target, side);
			List<T> retVal = new List<T>();

			// TODO: sort handlers by priority.

			foreach (EventHandler handler in handlers) {
				retVal.Add((T)await handler.callback.Invoke(args));
			}

			return retVal.ToArray();
		}

		private static EventHandler[] FindEventHandler(Callback cb, BattleMon target) {
			List<EventHandler> handlers = new List<EventHandler>();
			BattleEvent callback;
			sbyte priority;

			// Status
			foreach (Status s in target.Statuses) {
				(callback, priority) = StatusEffects.gStatusEvents(s, cb);
				if (callback != null) {
					handlers.Add(new EventHandler(callback, EffectType.STATUS, priority));
				}
			}
			// Ability
			Ability ability = target.ability;
			(callback, priority) = AbilityEffects.gAbilityEvents(ability, cb);
			if (callback != null) {
				handlers.Add(new EventHandler(callback, EffectType.ABILITY, priority));
			}
			// TODO: Item
			// Species
			Species species = target.Species;
			(callback, priority) = SpeciesEffects.gSpeciesEvents(species, cb);
			if (callback != null) {
				handlers.Add(new EventHandler(callback, EffectType.SPECIES, priority));
			}

			return handlers.ToArray();
		}
		private static EventHandler[] FindEventHandler(Callback cb, BattleState target, u8 side = u8.MaxValue) {
			List<EventHandler> handlers = new List<EventHandler>();
			BattleEvent callback;
			sbyte priority;

			// Weather
			FieldCondition weather = target.Weather;
			(callback, priority) = FieldConditions.gConditionEvents(weather.Condition, cb);
			if (callback != null) {
				handlers.Add(new EventHandler(callback, EffectType.WEATHER, priority));
			}
			// Terrain
			FieldCondition terrain = target.Terrain;
			(callback, priority) = FieldConditions.gConditionEvents(terrain.Condition, cb);
			if (callback != null) {
				handlers.Add(new EventHandler(callback, EffectType.TERRAIN, priority));
			}
			// Conditions
			foreach (FieldCondition condition in target.FieldConditions) {
				if (condition.AffectsWholeField || (side != u8.MaxValue && condition.AffectedSide == side)) {
					(callback, priority) = FieldConditions.gConditionEvents(condition.Condition, cb);
					if (callback != null) {
						handlers.Add(new EventHandler(callback, EffectType.CONDITION, priority));
					}
				}
			}

			return handlers.ToArray();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="players"></param>
		/// <returns></returns>
		private BattleState CreateInitialState(TrainerProfile[] players) {
			for (u8 i = 0; i < format.numPlayers; i++) {
				u8[] slots = format.SlotsControlledByPlayerIndex(i);
				this.players[i] = new TrainerBattleContext(players[i], format.SideControllingSlot(slots[0]), slots);
			}

			BattleState state = new BattleState(this);
			return state;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="state"></param>
		private void AddToHistory(BattleState state) {
			BattleState[] newHistory = new BattleState[History.Length + 1];
			for (u8 i = 0; i < History.Length; i++) {
				newHistory[i] = History[i];
			}
			// Create a copy of the state to add.
			Buffer buffer = state.Write();
			buffer.SetCursor(0);
			newHistory[newHistory.Length - 1] = BattleState.Load(buffer);
			History = newHistory;
		}

		/// <summary>
		/// Gets the BattleMon in a given slot.
		/// </summary>
		/// <param name="slot">Slot to look in.</param>
		/// <returns>BattleMon in the given slot. Returns null if empty.</returns>
		public BattleMon GetMonInSlot(BattleState state, u8 slot) {
			// Get the index of the mon in the desired slot.
			int index = (int)((state.FieldMons >> (BattleState.BITS_PER_MON_INDEX * slot)) & ((1 << BattleState.BITS_PER_MON_INDEX) - 1));
			if (index == BattleState.SLOT_EMPTY) {
				return null;
			}
			return PlayerControllingSlot(slot).team[index];
		}
		/// <summary>
		/// Gets every mon on the field in the current BattleState.
		/// </summary>
		/// <returns>Array of all active BattleMons</returns>
		public BattleMon[] GetAllActiveMons() {
			List<BattleMon> mons = new List<BattleMon>();
			for (u8 i = 0; i < format.numSlots; i++) {
				mons.Add(GetMonInSlot(CurrentState, i));
			}
			return mons.ToArray();
		}

		/// <summary>
		/// Determines if any mon on the field activates its ability.
		/// </summary>
		/// <param name="ability">The ability to look for.</param>
		/// <param name="popup">If true, displays the ability activation.</param>
		/// <returns>True if any active mon ssuccessfully activates the ability.</returns>
		public bool FieldMonAbilityProc(Ability ability, bool popup) {
			BattleMon[] fieldMons = GetAllActiveMons();
			for (u8 i = 0; i < fieldMons.Length; i++) {
				if (fieldMons[i].AbilityProc(ability, popup)) {
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Converts the encoded int of all targets into a readable vector of slots.
		/// </summary>
		/// <param name="slotsTarget">The encoded indices.</param>
		/// <returns>Array of individual slots.</returns>
		public static u8[] SplitTargets(u32 slotsTarget) {
			// Targets are stored in a 32-bit integer where 4 bits are used
			// to store the slot of a target.
			List<u8> targets = new List<u8>();
			for (u8 i = 0; i < 32 / BattleState.BITS_PER_MON_INDEX; i++) {
				u32 mask = (u32)((1 << BattleState.BITS_PER_MON_INDEX) - 1) << (i * BattleState.BITS_PER_MON_INDEX);
				u8 slot = (u8)((slotsTarget & mask) >> (i * BattleState.BITS_PER_MON_INDEX));
				if (slot == BattleState.SLOT_EMPTY) {
					break;
				}
				targets.Add(slot);
			}
			return targets.ToArray();
		}

		/// <summary>
		/// Replaces the mon on in a slot.
		/// </summary>
		/// <param name="player">Player whose mon to send out.</param>
		/// <param name="slot">Slot in which to replace the mon.</param>
		/// <param name="monIndex">Index of the mon in the player's team.</param>
		public async Task SendOutMon(BattleState state, TrainerBattleContext player, u8 slot, u8 monIndex) {
			if (monIndex > PARTY_SIZE) {
				throw new System.ArgumentOutOfRangeException();
			}
			if (!player.ControllsSlot(slot)) {
				throw new System.ArgumentException($"{player} does not have access to slot {slot}.");
			}

			// Perform a left shift by this value to get the correct segment for this team index.
			int shift = BattleState.BITS_PER_MON_INDEX * slot;
			// This gives us a number in the form 1111....0000....1111
			// where the 0's are in the segment corresponding to this team index.
			u32 mask = u32.MaxValue - (u32)(BattleState.SLOT_EMPTY << shift);
			// Bitwise and will zero out the segment in which this index will be stored.
			state.FieldMons &= mask;
			// Finally, we store this index in the appropriate slot.
			state.FieldMons |= (u32)(monIndex << shift);

			if (monIndex < 0) {
				return;
			}

			// TODO: :)
			BattleMon bm = player.team[monIndex];
			// Subscribe our OnMonFainted event to the new mon's listener. When it faints, we go through relevant processing.
			bm.OnMonFainted += OnMonFainted;

			// Mark the the mon has just switched in.
			bm.SetFlag(BattleMon.Flag.JUST_SWITCHED_IN);
			bm.SetStatusParam(StatusParam.TOXIC_BUILDUP, 0);

			// TODO: actual message
			await MessageBox($"{player.profile.Name} sent out {bm.GetName()}!");
	
			// Entry hazards.
			//DoEntryHazards(state, mon, GetSideFromSlot(teamIndex));

			// If the mon has an ability that activates upon taking the field, do that here.
			//switch (mon->ability) {
			//	case ABILITY_COMATOSE:
			//		AbilityPopup(GetMonName(mon->mon), mon->ability);
			//		BM_PARAMS[0] = GetMonName(mon->mon);
			//		await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_IS_DROWSING));
			//		break;
			//}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="state"></param>
		/// <param name="slot"></param>
		/// <returns></returns>
		public async Task TakeOutMon(BattleState state, u8 slot) {
			// Perform a left shift by this value to get the correct segment for this slot's index.
			int shift = BattleState.BITS_PER_MON_INDEX * slot;
			// This gives us a number in the form 1111....0000....1111
			// where the 0's are in the segment corresponding to this slot's index.
			u32 mask = u32.MaxValue - (u32)(BattleState.SLOT_EMPTY << shift);
			// Bitwise and will zero out the segment which will be cleared.
			state.FieldMons &= mask;
			// Finally, we store empty slot constant in the appropriate slot.
			state.FieldMons |= (u32)(BattleState.SLOT_EMPTY << shift);

			// TODO: idk
			await Task.Delay(Global.WAIT_DELAY);
		}

		/// <summary>
		/// Handles letting all mons on the field choose their actions for the turn. 
		/// </summary>
		private async Task ChooseActions(BattleState state)
		{
			// Get tasks for each slot for each player.
			Task<u64>[] tasks = new Task<u64>[format.numPlayers]; 
			for (u8 i = 0; i < format.numPlayers; i++) {
				foreach (u8 slot in players[i].slots) {
					tasks[i] = players[i].controller.HandleInputChooseAction(this, state, slot);
				}
			}

			// Wait for all actions to be chosen before continuing.
			u64[] vals = await Task.WhenAll(tasks);
			state.AddAction(vals);
		}

		/// <summary>
		/// Finds the BattleController in charge of the given slot.
		/// </summary>
		/// <param name="slot">Slot to look for.</param>
		/// <returns>BattleController that controls the slot.</returns>
		public TrainerBattleContext PlayerControllingSlot(u8 slot) {
			foreach (TrainerBattleContext player in players) {
				foreach (u8 s in player.slots) {
					if (s == slot) {
						return player;
					}
				}
			}
			throw new System.Exception();
		}

		/// <summary>
		/// Tasks to run when a mon faints.
		/// Interrupts to end the battle if needed.
		/// </summary>
		/// <param name="bm">The mon that fainted</param>
		private async Task OnMonFainted(BattleMon bm) {
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_FAINTED, bm.GetName()));
			await TakeOutMon(CurrentState, bm.Side);
			// If this mon was the last one on a side, then interrupt flow to go to the battle end routine.
			if (IsOver()) {
				throw new BattleOverException();
			}
		}
	
		/// <summary>
		/// 
		/// </summary>
		public async Task Start() {
			Global.BattleSceneSetup(this, this.players);

			// Send out initial mons.
			foreach (TrainerBattleContext player in this.players) {
				foreach (u8 slot in player.slots) {
					sbyte index = player.GetFirstAvailableMonIndex();
					if (index >= 0) {
						await SendOutMon(CurrentState, player, slot, (u8)index);
					}
				}
			}

			while (!IsOver()) {
				try {
					// Get the new state.
					CurrentState = CurrentState.Next();

					// Check for players that need to send out a new mon.
					foreach (TrainerBattleContext context in players) {
						foreach (u8 s in context.slots) {
							BattleMon monInSlot = GetMonInSlot(CurrentState, s);
							// Check if the mon in this slot exists or is fainted AND the player controlling
							// the slot has another mon to send out.
							if ((monInSlot == null || monInSlot.HasStatus(Status.FAINTED)) && PlayerControllingSlot(s).NumAvailableMons() > 0) {
								// Check if there is another available mon.
								sbyte firstIndex = context.GetFirstAvailableMonIndex();
								// If the index is positive, then there are more available mons.
								if (firstIndex > 0) {
									// Have the player/AI choose which mon to send out next
									u64 selection = await context.controller.MenuSelectSwitchToMon(this, CurrentState, s);
									await SendOutMon(CurrentState, context, s, (u8)GetBattleActionArgs(selection));
								}
								// If we get here, then a player is out of usable mons.
								else {
									// Check for other players.
									continue;
								}
							}
						}
					}

					for (u8 i = 0; i < format.numSlots; i++) {
						BattleMon bm = GetMonInSlot(CurrentState, i);
						if (bm == null) {
							continue;
						}
						await Battle.RunEvent(Callback.OnStart, bm, new OnStartParams(CurrentState, bm));
					}

					await ChooseActions(CurrentState);
					await DoBattleActions(CurrentState);
				}
				catch (BattleOverException) {
					await BattleEnd();
				}
			}
		}

		private async Task BattleEnd() {
			// TODO: do some actual battle-end routine.
			Console.WriteLine("battle end");
			await MessageBox($"{players[WinningSide].profile.Name} won!");
		}

		private async Task DoBattleActions(BattleState state) {
			// TODO: sort actions by move order.
			for (u8 i = 0; i < state.ActionCount; i++) {
				u64 action	= state.Actions[i];
				ActionCode code	= GetBattleActionCode(action);
				u8 slot			= GetBattleActionSlot(action);
				u32 args		= GetBattleActionArgs(action);
				u32 flags		= GetBattleActionFlags(action);
				
				if (code == ActionCode.NONE) {
					break;
				}

				TrainerBattleContext user = PlayerControllingSlot(slot);
				BattleMon actor = GetMonInSlot(state, slot);

				if (actor == null) {
					continue;
				}

				// Destiny Bond effect ends when a mon takes an action,
				// even if it is blocked due to sleep, paralysis, etc.
				actor.RemoveStatus(Status.DESTINY_BOND);

				// Fainted mons tell no tales.
				if (actor.HasStatus(Status.FAINTED)) {
					continue;
				}

				// If the mon has flinched, it cannot take its turn.
				if (actor.HasStatus(Status.FLINCH)) {
					continue;
				}
				// If the mon is in a semi-invulnerable state but did not induce it itself, skip its action.
				if (actor.HasStatus(Status.SEMI_INVULNERABLE_TURN) && !actor.HasFlag(BattleMon.Flag.MON_INDUCED_SEMI_INVUL)) {
					continue;
				}

				switch (code) {
					case ActionCode.USE_MOVE: 
					case ActionCode.DO_MOVE: {
						await UseOrDoMove(state, slot, code, args, flags, actor, i);
						break;
					}
					case ActionCode.SWITCH:
						await SendOutMon(CurrentState, user, slot, (u8)args);
						System.Console.WriteLine($"{user.profile.Name} sent out {GetMonInSlot(CurrentState, slot).GetName()}");
						break;
					default:
						break;
				}

				// Now that the mon has had an opportunity to move, mark that it has not just switched in.
				actor.RemoveFlag(BattleMon.Flag.JUST_SWITCHED_IN);
			}

			await DoEventsAfterTurn();
		}

		private async Task DoEventsAfterTurn() {
			// TODO: maybe move all this into BattleState.Next()?

			RunEvent(Callback.OnFieldResidual, CurrentState, new OnFieldResidualParams(this, CurrentState));
			for (u8 side = 0; side < format.numSides; side++) {
				RunEvent(Callback.OnSideResidual, CurrentState, new OnSideResidualParams(this, CurrentState, side), side);
			}

			for (u8 i = 0; i < format.numSlots; i++) {
				BattleMon bm = GetMonInSlot(CurrentState, i);
				if (bm == null) {
					continue;
				}

				await Battle.RunEvent(Callback.OnResidual, bm, new OnResidualParams(this, CurrentState, bm));
				await Battle.RunEvent(Callback.OnNextTurn, bm, CurrentState);
				await Battle.RunEvent(Callback.OnEnd, bm, new OnEndParams(CurrentState, bm));
				
				// Remove transient conditions.
				foreach (Status s in StatusEffects.STATUS_MASK_TRANSIENT) {
					bm.RemoveStatus(s);
				}

				bm.RemoveFlag(BattleMon.Flag.JUST_SWITCHED_IN);
				bm.RemoveFlag(BattleMon.Flag.STAT_INCREASED_THIS_TURN);

				bm.SetStatusParam(StatusParam.PHYS_DAMAGE_THIS_TURN, 0);
				bm.SetStatusParam(StatusParam.SPEC_DAMAGE_THIS_TURN, 0);
			}

			// Cache the state.
			AddToHistory(CurrentState);
		}

		/// <summary>
		/// Performs a move.
		/// </summary>
		/// <param name="state">Current BattleState.</param>
		/// <param name="slot">Slot of the user</param>
		/// <param name="code">BATTLE_ACTION_CODE. Either BATTLE_ACTION_CODE_USE_MOVE or BATTLE_ACTION_CODE_DO_MOVE.</param>
		/// <param name="move">Args retrieved from GetBattleActionArgs().</param>
		/// <param name="targets">Flags retrieved from GetBattleActionFlags().</param>
		/// <param name="actor">BattleMon using the move.</param>
		/// <param name="index">The index of the action in the state's action array.</param>
		private async Task UseOrDoMove(BattleState state, u8 slot, ActionCode code, u32 move, u32 targets, BattleMon actor, u8 index) {
			u8 moveSlot = (u8)((move & 0x00030000) >> 16);

			// Store the last targeted mon.
			u8[] targetsArr = SplitTargets(targets);

			switch (code) {
				case ActionCode.USE_MOVE:
					await BattleUtils.UseMove(this, state, slot, (BattleMoveID)(move & 0xFFFF), moveSlot, targets, index);
					break;
				case ActionCode.DO_MOVE: {
					for (u8 i = 0; i < targetsArr.Length; i++) {
						BattleMon target = GetMonInSlot(state, targetsArr[i]);
						await BattleUtils.DoMove(this, state, actor, target, (BattleMoveID)(move & 0xFFFF), slot, targetsArr[i], (u8)targetsArr.Length, index, true);
					}
					break;
				}
			}

			// If the mon used the same move that it did last turn.
			if (moveSlot == actor.GetStatusParam(StatusParam.LAST_USED_MOVE)) {
				// Increment the counter.
				actor.IncrementStatusParam(StatusParam.SUCCESSIVE_MOVE_USES);
			}
			// Otherwise, reset the counter.
			else {
				// Set the new last-used move.
				actor.SetStatusParam(StatusParam.LAST_USED_MOVE, moveSlot);
				// Set the counter to 1.
				actor.SetStatusParam(StatusParam.SUCCESSIVE_MOVE_USES, 1);
			}
			actor.SetStatusParam(StatusParam.LAST_TARGETED_MON, targetsArr[0]);
		}

		/// <summary>
		/// Determines if one side is out of useable mons.
		/// TODO: differentiate between player win/loss.
		/// </summary>
		/// <returns>True if all Pokemon on one side are fainted.</returns>
		private bool IsOver() {
			// Check if all opposing Pokemon are fainted or if all player/ally Pokemon are fainted.
			
			List<u8> availableSides = new List<u8>();

			// Check all sides for any available mons.
			for (u8 side = 0; side < format.numSides; side++) {
				foreach (u8 slot in format.SlotsOnSide(side)) {
					// Check if the player controlling this slot has any mons available.
					foreach (BattleMon bm in PlayerControllingSlot(slot).team) {
						// Do not check null mons on this slot's team.
						if (bm == null) {
							continue;
						}
						if (bm.IsAvailable()) {
							// If this slot's team has any available mons,
							// add this slot to the list of available slots.
							availableSides.Add(slot);
							break;
						}
					}
					// If we already know that this side is available, then
					// we don't need to check the other slots on this side.
					if (availableSides.Contains(side)) {
						break;
					}
				}
			}

			// If there is only 1 side that can still fight, then that side is the winner.
			if (availableSides.Count == 1) {
				WinningSide = availableSides[0];
				return true;
			}

			// If there is more than 1 side that can still fight, then the battle is not over yet.
			WinningSide = 0;
			return false;
		}
	}

	public class BattleState : ISerializable<BattleState> {
		public Buffer Write() {
			Buffer data = new Buffer();

			data.AddValue(FieldMons);
			data.AddValue(NumSlots);

			data.AddValue(Weather);
			data.AddValue(Terrain);

			data.AddValue((u8)Conditions.Count);
			for (u8 i = 0; i < Conditions.Count; i++) {
				data.AddValue(Conditions[i]);
			}
			
			data.AddValue(ActionCount);
			for (u8 i = 0; i < ActionCount; i++) {
				data.AddValue(Actions[i]);
			}

			data.AddValue(TurnNum);

			return data;
		}
		public static BattleState Load(Buffer data) {
			BattleState state = new BattleState();

			state.FieldMons = data.Read32();
			state.NumSlots = data.Read8();

			state.Weather = FieldCondition.Load(data.ReadBuffer());
			state.Terrain = FieldCondition.Load(data.ReadBuffer());

			u8 numConditions = data.Read8();
			state.Conditions = new List<FieldCondition>();
			for (u8 i = 0; i < numConditions; i++) {
				state.Conditions.Add(FieldCondition.Load(data.ReadBuffer()));
			}
			
			u8 actionCount = data.Read8();
			state.Actions = new u64[0];
			for (u8 i = 0; i < actionCount; i++) {
				state.AddAction(data.Read64());
			}

			state.TurnNum = data.Read8();

			return state;
		}

		public BattleState() { }
		public BattleState(Battle target) {
			this.FieldMons = u32.MaxValue;
			this.NumSlots = target.format.numSlots;
			this.Actions = new u64[0];
			this.Weather = new FieldCondition(Condition.WEATHER_NONE, true, 0, false, 0);
			this.Terrain = new FieldCondition(Condition.TERRAIN_NONE, true, 0, false, 0);
			this.Conditions = new List<FieldCondition>();
		}

		public BattleState Next() {
			Buffer data = this.Write();
			data.SetCursor(0);
			BattleState state = Load(data);

			state.Actions = new u64[0];
			state.TurnNum++;
			
			return state;
		}

		private u8 NumSlots { get; set; }

		public const u8 BITS_PER_MON_INDEX = 4;
		public const u8 SLOT_EMPTY = (1 << BITS_PER_MON_INDEX) - 1;
		/*
			This needs to keep track of the index of the mon in the party.
			It does not need to store which team the mon is in because that can be inferred from where in the number the
			mon index appears.
			If we allot 3 bits per mon, we can store indices up to 7, so as long as PARTY_SIZE stays at or below 7,
			we can guarantee enough space to store the index of each mon in its given segment.
			Although unlikely, it can technically change, so I will allot 4 bits per mon index to store the value.
			A value of 15 in a segment will correspond to the NULL_BATTLE_MON.
			This will allow up to 15 mons per team, which is far more than enough.
			Then all this information can be fit into a single 32 bit int 8 bits of wasted space,
			technically allowing for up to 8 mons on field.
			**********************************************************
			00000000 | 0000 | 0000 | 0000 | 0000 | 0000 | 0000
			unused   | t5   | t4   | t3   | t2   | t1   | t0  
			********************************************************** 
		*/
		public u32 FieldMons { get; set; }

		private List<FieldCondition> Conditions { get; set; }
		public FieldCondition[] FieldConditions { 
			get {
				List<FieldCondition> activeConditions = new List<FieldCondition>();
				foreach (FieldCondition c in Conditions) {
					if (c.IsActive()) {
						activeConditions.Add(c);
					}
				}
				return activeConditions.ToArray();
			}
		}
		public FieldCondition Weather { get; private set; }
		public FieldCondition Terrain { get; private set; }

		public u64[] Actions { get; private set; }
		public u8 ActionCount { get { return (u8)Actions.Length; } }

		public u8 TurnNum { get; private set; }

		/// <summary>
		/// Adds a new action into the given state's action array.
		/// </summary>
		/// <param name="action">The action to add.</param>
		public void AddAction(params u64[] action) {
			u64[] newActions = new u64[ActionCount + action.Length];
			for (u8 i = 0; i < ActionCount; i++) {
				newActions[i] = Actions[i];
			}
			for (u8 i = 0; i < action.Length; i++) {
				newActions[ActionCount + i] = action[i];
			}
			Actions = newActions;
		}
		/// <summary>
		/// Inserts a new action into the state's action array at a given position.
		/// </summary>
		/// <param name="action">The action to insert.</param>
		/// <param name="i">The index in the state's actions array after which to insert the action.</param>
		public void InsertAction(u64 action, u8 i) {
			// Create a new empty array.
			u64[] newActions = new u64[Actions.Length + 1];
			// Copy over all the existing actions up to the given index.
			for (u8 j = 0; j <= i; j++) {
				newActions[j] = Actions[j];
			}
			// Add the new action into the array at the given index.
			newActions[i + 1] = action;
			// Loop through the rest of the actions, adding them to the new array.
			for (u8 j = (u8)(i + 1); j < Actions.Length; j++) {
				newActions[j + 1] = Actions[j];
			}
			// Update the state's array.
			Actions = newActions;
		}
	
		/// <summary>
		/// Replaces active weather with new weather.
		/// </summary>
		/// <param name="weather">Weather condition to set.</param>
		/// <param name="duration">Duration of the weather effect in turns. Set to 255 (UINT8_MAX) for (effectively) infinite duration.</param>
		public async void SetWeather(Condition weather, BattleMon source) {
			if (!(weather >= Condition.WEATHER_HARSH_SUNLIGHT && weather <= Condition.WEATHER_SHADOWY_AURA)) {
				throw new System.ArgumentException();
			}
			if (!await Battle.RunEventCheck(Callback.OnTrySetWeather, this, null)) {
				return;
			}
			u8 duration = await BattleEvents.EventDuration(source, weather);
			Weather.SetWeatherTerrain(weather, duration);
			Battle.RunEvent(Callback.OnWeatherSet, this, new OnWeatherSetParams(this, source));
		}
		/// <summary>
		/// Replaces active terrain with new terrain.
		/// </summary>
		/// <param name="terrain">Terrain condition to set.</param>
		/// <param name="duration">Duration of the terrain effect in turns. Set to 255 (UINT8_MAX) for (effectively) infinite duration.</param>
		public void SetTerrain(Condition terrain, BattleMon source) {
			if (!(terrain >= Condition.TERRAIN_ELECTRIC && terrain <= Condition.TERRAIN_PSYCHIC)) {
				throw new System.ArgumentException();
			}
			// TODO: This *may* need a future OnTrySetTerrain callback.
			//if (!Battle.RunEventCheck(Callback.OnTrySetWeather, this, null)) {
			//	return;
			//}

			u8 duration = BattleEvents.EventDuration(source, terrain).Result;
			Terrain.SetWeatherTerrain(terrain, duration);
			Battle.RunEvent(Callback.OnWeatherSet, this, new OnWeatherSetParams(this, source));
		}

		public async void SetFieldCondition(Condition condition, BattleMon source) {
			u8 duration = (u8)await PkmnEngine.FieldConditions.gConditionEvents(condition, Callback.DurationCallback).callback.Invoke(new DurationCallbackParams(source));
			SetFieldCondition(condition, duration);
		}
		private void SetFieldCondition(Condition condition, u8 duration = u8.MaxValue) {
			Conditions.Add(new FieldCondition(condition, true, 0, false, duration));
		}
		public async void SetSideCondition(u8 side, Condition condition, BattleMon source) {
			u8 duration = (u8)await PkmnEngine.FieldConditions.gConditionEvents(condition, Callback.DurationCallback).callback.Invoke(new DurationCallbackParams(source));
			SetSideCondition(side, condition, duration);
		}
		private void SetSideCondition(u8 side, Condition condition, u8 duration = u8.MaxValue) {
			Conditions.Add(new FieldCondition(condition, side, duration));
		}

		/// <summary>
		/// Determines if the given side has one or more of the given conditions.
		/// </summary>
		/// <param name="side"></param>
		/// <param name="condition"></param>
		/// <returns></returns>
		public bool SideHasCondition(u8 side, params Condition[] condition) {
			for (u8 i = 0; i < condition.Length; i++) {
				for (u8 j = 0; j < this.Conditions.Count; j++) {
					FieldCondition c = this.Conditions[j];
					if (c.Condition == condition[i] && !c.AffectsWholeField && c.AffectedSide == side) {
						return true;
					}
				}
			}
			return false;
		}
		public bool SideHasCondition(u8 side, Condition condition, out FieldCondition output) {
			for (u8 i = 0; i < this.Conditions.Count; i++) {
				FieldCondition c = this.Conditions[i];
				if (c.Condition == condition && !c.AffectsWholeField && c.AffectedSide == side) {
					output = c;
					return true;
				}
			}
			output = null;
			return false;
		}
		public bool FieldHasCondition(params Condition[] condition) {
			for (u8 i = 0; i < condition.Length; i++) {
				for (u8 j = 0; j < this.Conditions.Count; j++) {
					FieldCondition c = this.Conditions[j];
					if (c.Condition == condition[i] && c.AffectsWholeField) {
						return true;
					}
				}
			}
			return false;
		}
		public bool FieldHasCondition(Condition condition, out FieldCondition output) {
			for (u8 i = 0; i < this.Conditions.Count; i++) {
				if (condition == this.Conditions[i].Condition && this.Conditions[i].AffectsWholeField) {
					output = this.Conditions[i];
					return true;
				}
			}
			output = null;
			return false;
		}

		public void RemoveCondition(Condition condition, u8 side = u8.MaxValue) {
			if (side == u8.MaxValue && FieldHasCondition(condition, out FieldCondition c)) {
				this.Conditions.Remove(c);
			}
			else if (SideHasCondition(side, condition, out c)) {
				this.Conditions.Remove(c);
			}
		}
		public void RemoveCondition(FieldCondition condition) {
			if (this.Conditions.Contains(condition)) {
				this.Conditions.Remove(condition);
			}
		}
	}
}