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

namespace PkmnEngine {
	public class Battle {
		public const u8 SIDE_CLIENT = 0;
		public const u8 SIDE_REMOTE = 1;

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

			foreach (TrainerBattleContext player in this.players) {
				foreach (u8 slot in player.slots) {
					sbyte index = player.GetFirstAvailableMonIndex();
					if (index >= 0) {
						SendOutMon(initialState, player, slot, (u8)index);
					}
				}
			}

			Start(initialState);
		}

		public readonly int seed;
		public readonly System.Random rand;
		public readonly bool isReplay;

		private readonly TrainerBattleContext[] players;
		public readonly BattleFormat format;

		private BattleState[] History { get; set; }
		public BattleState CurrentState { get; private set; }
		public u8 TurnCount { get { return (u8)History.Length; } }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="players"></param>
		/// <returns></returns>
		private BattleState CreateInitialState(TrainerProfile[] players) {
			for (u8 i = 0; i < format.numPlayers; i++) {
				this.players[i] = new TrainerBattleContext(players[i], format.SlotsControlledByPlayerIndex(i));
			}

			BattleState state = new BattleState(this, this.players);
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
		public BattleMon GetMonInSlot(BattleState state, u8 slot)
		{
			// Get the index of the mon in the desired slot.
			int index = (int)((state.FieldMons >> (BattleState.BITS_PER_MON_INDEX * slot)) & ((1 << BattleState.BITS_PER_MON_INDEX) - 1)) - 1;
			if (index < 0) {
				return null;
			}
			return PlayerControllingSlot(slot).team[index];
		}
		/// <summary>
		/// Gets every mon on the field in the current BattleState.
		/// </summary>
		/// <returns>Array of all active BattleMons</returns>
		public BattleMon[] GetAllActiveMons()
		{
			List<BattleMon> mons = new List<BattleMon>();
			for (u8 i = 0; i < format.numSlots; i++) {
				mons.Add(GetMonInSlot(CurrentState, i));
			}
			return mons.ToArray();
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
				u32 mask = (u32)((1 << BattleState.BITS_PER_MON_INDEX) - 1) << i;
				u8 slot = (u8)((slotsTarget & mask) >> (i * BattleState.BITS_PER_MON_INDEX));
				if (slot == 0) {
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
		public void SendOutMon(BattleState state, TrainerBattleContext player, u8 slot, u8 monIndex) {
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
			u32 mask = u32.MaxValue - (u32)(((1 << BattleState.BITS_PER_MON_INDEX) - 1) << shift);
			// Bitwise and will zero out the segment in which this index will be stored.
			state.FieldMons &= mask;
			// Finally, we store this index in the appropriate slot.
			state.FieldMons |= (u32)((monIndex + 1) << shift);

			if (monIndex < 0) {
				return;
			}

			// TODO: :)
			BattleMon bm = player.team[monIndex];

			// Mark the the mon has just switched in.
			bm.SetFlag(BattleMon.BM_FLAG_JUST_SWITCHED_IN);

			// Entry hazards.
			//DoEntryHazards(state, mon, GetSideFromSlot(teamIndex));

			// If the mon has an ability that activates upon taking the field, do that here.
			//switch (mon->ability) {
			//	case ABILITY_COMATOSE:
			//		AbilityPopup(GetMonName(mon->mon), mon->ability);
			//		BM_PARAMS[0] = GetMonName(mon->mon);
			//		MessageBox(Lang.GetBattleMessage(BattleMessage.MON_IS_DROWSING));
			//		break;
			//}
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
		/// 
		/// </summary>
		/// <param name="state"></param>
		private async void Start(BattleState state)
		{
			// BUG: Why did I use this here??? Do not use this namespace here!
			BattleSceneDrawer.SetupScene(this, this.players);
			while (!IsOver()) {
				// Get the new state.
				CurrentState = state.Next();

				await ChooseActions(state);
				DoBattleActions(state);
			}
		}

		private void DoBattleActions(BattleState state) {
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

				// Destiny Bond effect ends when a mon takes an action,
				// even if it is blocked due to sleep, paralysis, etc.
				actor.RemoveStatus(Status.DESTINY_BOND);

				// Fainted mons tell no tales.
				// TODO: is this the most elegant way to approach this?
				if (actor.HasStatus(Status.FAINTED)) {
					continue;
				}

				// If the mon has flinched, it cannot take its turn.
				if (actor.HasStatus(Status.FLINCH)) {
					continue;
				}
				// If the mon is in a semi-invulnerable state but did not induce it itself, skip its action.
				if (actor.HasStatus(Status.SEMI_INVULNERABLE_TURN) && !actor.HasFlag(BattleMon.BM_FLAG_MON_INDUCED_SEMI_INVUL)) {
					continue;
				}

				switch (code) {
					case ActionCode.USE_MOVE: 
					case ActionCode.DO_MOVE: {
						if (!UseOrDoMove(state, slot, code, args, flags, actor, i)) {
							return;
						}
						break;
					}
					case ActionCode.SWITCH:
						SendOutMon(CurrentState, user, slot, (u8)args);
						System.Console.WriteLine($"{user.profile.Name} sent out {GetMonInSlot(CurrentState, slot).GetName()}");
						break;
					default:
						break;
				}

				// Now that the mon has had an opportunity to move, mark that it has not just switched in.
				actor.RemoveFlag(BattleMon.BM_FLAG_JUST_SWITCHED_IN);
			}

			DoEventsAfterTurn();
		}

		private void DoEventsAfterTurn() {
			// TODO: maybe move all this into BattleState.Next()?

			bool fainted = false;

			// Do status effect stuff.
			DoAfterTurnStatusEvents(CurrentState);
			// Do weather stuff.
			DoAfterTurnWeatherEvents(CurrentState, ref fainted);
			// Do terrain stuff.
			DoAfterTurnTerrainEvents(CurrentState);


			for (u8 i = 0; i < format.numSlots; i++) {
				BattleMon bm = GetMonInSlot(CurrentState, i);
				if (bm == null) {
					continue;
				}

				// Remove transient conditions.
				foreach (Status s in StatusEffects.STATUS_MASK_TRANSIENT) {
					bm.RemoveStatus(s);
				}

				bm.RemoveFlag(BattleMon.BM_FLAG_JUST_SWITCHED_IN);
				bm.RemoveFlag(BattleMon.BM_FLAG_STAT_INCREASED_THIS_TURN);

				bm.SetStatusParam(StatusParam.PHYS_DAMAGE_THIS_TURN, 0);
				bm.SetStatusParam(StatusParam.SPEC_DAMAGE_THIS_TURN, 0);
			}

			// TODO_: determine battle winner.
			//if (b_IsBattleOver(battle, state)) {
			//	return;
			//}


			////DrawField();


			//state->turnNo = battle->turnCount;

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
		/// <returns>True if the battle is not over.</returns>
		private bool UseOrDoMove(BattleState state, u8 slot, ActionCode code, u32 move, u32 targets, BattleMon actor, u8 index) {
			u8 moveSlot = (u8)((move & 0x00030000) >> 16);

			// Store the last targeted mon.
			u8[] targetsArr = SplitTargets(targets);

			switch (code) {
				case ActionCode.USE_MOVE:
					BattleUtils.UseMove(this, state, slot, (BattleMoveID)(move & 0xFFFF), moveSlot, targets, index);
					break;
				case ActionCode.DO_MOVE: {
					for (u8 i = 0; i < targetsArr.Length; i++) {
						BattleMon target = GetMonInSlot(state, targetsArr[i]);
						BattleUtils.DoMove(this, state, actor, target, (BattleMoveID)(move & 0xFFFF), slot, targetsArr[i], (u8)targetsArr.Length, index, true);
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
			
			if (IsOver()) {
				// TODO: Enter some battle end routine.
				return false;
			}

			return true;
		}

		/// <summary>
		/// Determines if one side is out of useable mons.
		/// TODO: differentiate between player win/loss.
		/// </summary>
		/// <returns>True if all Pokemon on one side are fainted.</returns>
		private bool IsOver()
		{
			// Check if all opposing Pokemon are fainted or if all player/ally Pokemon are fainted.
			
			bool battleOver = true;

			// Check player/ally Pokemon.
			foreach (u8 slot in format.SlotsOnSide(SIDE_CLIENT)) {
				foreach (BattleMon bm in PlayerControllingSlot(slot).team) {
					if (bm.IsAvailable()) {
						battleOver = false;
						break;
					}
				}
			}
			// Player lost
			if (battleOver) {
				return true;
			}

			// Check opponent Pokemon.
			battleOver = true;
			foreach (u8 slot in format.SlotsOnSide(SIDE_REMOTE)) {
				foreach (BattleMon bm in PlayerControllingSlot(slot).team) {
					if (bm.IsAvailable()) {
						battleOver = false;
						break;
					}
				}
			}
			// Player won
			if (battleOver) {
				return true;
			}

			// If we get here, the battle is not over.
			return false;
		}
	
		/// <summary>
		/// Performs actions for certain status effects.
		/// </summary>
		/// <param name="state"></param>
		private void DoAfterTurnStatusEvents(BattleState state) {
			for (u8 i = 0; i < format.numSlots; i++) {
				BattleMon bm = GetMonInSlot(state, i);
				if (bm == null) {
					continue;
				}
				bool fainted = false;

				HandleNonVolatileStatuses(state, bm, ref fainted);
				if (fainted) {
					return;
				}
				HandleNextTurnStatuses(state, bm, ref fainted);
				if (fainted) {
					return;
				}

				// Aqua Ring
				if (bm.HasStatus(Status.AQUA_RING)) {
					MessageBox(Lang.GetBattleMessage(BattleMessage.A_VEIL_OF_WATER_RESTORED_MONS_HP, bm.GetName()));
					u16 healAmount = bm.GetPercentOfMaxHp(StatusEffects.AQUA_RING_HEAL_AMOUNT);
					// TODO: b_HealMon(state, bm, &healAmount, false);
				}
				// Leech Seed
				if (bm.HasStatus(Status.SEEDED)) {
					u16 healAmount = bm.GetPercentOfMaxHp(StatusEffects.LEECH_SEED_DRAIN_AMOUNT);
					//TODO: b_DamageMon(state, bm, &healAmount, true, false);
					//TODO: b_HealMon(state, GetMonInSlot(state, GetStatusParam(StatusParam.SLOT_SEEDED_BY)), &healAmount);
					MessageBox(Lang.GetBattleMessage(BattleMessage.MONS_HP_WAS_SAPPED_BY_LEECH_SEED, bm.GetName()));
				}
				// Perish Song
				if (bm.HasStatus(Status.PERISH_SONG)) {
					u8 count = (u8)bm.GetStatusParam(StatusParam.PERISH_COUNT);
					MessageBox(Lang.GetBattleMessage(BattleMessage.MONS_PERISH_COUNT_FELL_TO_N, bm.GetName(), count.ToString()));
					if (count == 0) {
						u16 damage = bm.EffMaxHp(state);
						fainted = false; //TODO: !b_DamageMon(state, bm, &damage, true, false);
						return;
					}
					bm.DecrementStatusParam(StatusParam.PERISH_COUNT);
				}
				// Throat Chop
				if (bm.HasStatus(Status.THROAT_CHOP)) {
					u8 count = (u8)bm.GetStatusParam(StatusParam.THROAT_CHOP);
					if (count == 0) {
						bm.RemoveStatus(Status.THROAT_CHOP);
					}
					bm.DecrementStatusParam(StatusParam.THROAT_CHOP);
				}
				// Taunt
				if (bm.HasStatus(Status.TAUNT)) {
					u8 count = (u8)bm.GetStatusParam(StatusParam.TAUNT);
					if (count == 0) {
						bm.RemoveStatus(Status.THROAT_CHOP);
						MessageBox(Lang.GetBattleMessage(BattleMessage.MON_SHOOK_OFF_THE_TAUNT, bm.GetName()));
					}
					bm.DecrementStatusParam(StatusParam.TAUNT);
				}
				// Curse
				if (bm.HasStatus(Status.CURSE)) {
					u16 damage = bm.GetPercentOfMaxHp(0.25f);
					//TODO: b_DamageMon(state, bm, &damage, true, false);
					MessageBox(Lang.GetBattleMessage(BattleMessage.MON_AFFLICTED_BY_CURSE, bm.GetName()));
				}
				// Encore
				if (bm.HasStatus(Status.ENCORE)) {
					if (bm.GetStatusParam(StatusParam.ENCORE_TURNS) == 0) {
						bm.RemoveStatus(Status.ENCORE);
						MessageBox(Lang.GetBattleMessage(BattleMessage.MONS_ENCORE_ENDED, bm.GetName()));
					}
					bm.DecrementStatusParam(StatusParam.ENCORE_TURNS);
				}
			}
		}
		private void HandleNonVolatileStatuses(BattleState state, BattleMon bm, ref bool fainted) {
			if (bm.HasStatus(Status.BURN)) {
				u16 damage = bm.GetPercentOfMaxHp(StatusEffects.BURN_CHIP_DAMAGE);
				// https://bulbapedia.bulbagarden.net/wiki/Heatproof_(Ability)
				//TODO: if (b_AbilityProc(state, bm, ABILITY_HEATPROOF, false)) {
				//	damage /= 2;
				//}
				fainted = false; //TODO: !b_DamageMon(state, bm, &damage, true, false);
				MessageBox(Lang.GetBattleMessage(BattleMessage.MON_HURT_BY_ITS_BURN, bm.GetName()));
				if (fainted) {
					return;
				}
			}
			else if (bm.HasStatus(Status.POISON)) {
				u16 damage = bm.GetPercentOfMaxHp(StatusEffects.POISON_CHIP_DAMAGE);
				// If the mon has Poison Heal, it heals instead of taking damage.
				//if (b_AbilityProc(state, bm, ABILITY_POISON_HEAL, false)) {
					//TODO: b_HealMon(state, bm, &damage, false);
				//}
				//else {
					fainted = false;//TODO: !b_DamageMon(state, bm, &damage, true, false);
					MessageBox(Lang.GetBattleMessage(BattleMessage.MON_HURT_BY_POISON, bm.GetName()));
				//}
				if (fainted) {
					return;
				}
			}
			else if (bm.HasStatus(Status.TOXIC)) {
				// Toxic deals damage starting at a set percentage, and grows by that percentage every turn.
				// Bulbapedia does not say there is a limit on this accumulation.
				u16 baseDamage = bm.GetPercentOfMaxHp(StatusEffects.TOXIC_CHIP_DAMAGE);
				bm.IncrementStatusParam(StatusParam.TOXIC_BUILDUP);
				//TODO: if (b_AbilityProc(state, bm, ABILITY_POISON_HEAL, false)) {
				//	// Poison Heal does not heal extra from toxic stacks.
				//	b_HealMon(state, bm, &baseDamage, false);
				//}
				//else {
					// Stack additional damage by number of turns afflicted.
					// TODO: technically, toxic has a separate counter that resets when switching out.
					u16 totalDamage = (u16)(baseDamage * bm.GetStatusParam(StatusParam.TOXIC_BUILDUP));
					fainted = false; //TODO: !b_DamageMon(state, bm, &totalDamage, true, false);
					MessageBox(Lang.GetBattleMessage(BattleMessage.MON_HURT_BY_POISON));
				//}
				if (fainted) {
					return;
				}
			}
		}
		private void HandleNextTurnStatuses(BattleState state, BattleMon bm, ref bool fainted) {
			// The turn after a mon is inflicted with drowsy, it falls asleep.
			if (bm.HasStatus(Status.DROWSY)) {
				if (bm.GetStatusParam(StatusParam.DROWSING) == 0) {
					bm.RemoveStatus(Status.DROWSY);
					//TODO: BattleMoveEffects::sSleepMon(state, bm, GetRandSleepTurns());
				}
				bm.DecrementStatusParam(StatusParam.DROWSING);
			}
			// Taking Aim
			if (bm.HasStatus(Status.TAKING_AIM)) {
				bm.DecrementStatusParam(StatusParam.TAKING_AIM);
			}
			// Laser Focus
			if (bm.HasStatus(Status.LASER_FOCUS)) {
				if (bm.GetStatusParam(StatusParam.LASER_FOCUS) == 0) {
					bm.RemoveStatus(Status.LASER_FOCUS);
				}
				bm.DecrementStatusParam(StatusParam.LASER_FOCUS);
			}
		}

		/// <summary>
		/// Performs actions for certain weather.
		/// </summary>
		/// <param name="state"></param>
		/// <param name="fainted"></param>
		private void DoAfterTurnWeatherEvents(BattleState state, ref bool fainted) {
			// If there is active weather, decrement the counter.
			if (!state.Weather.Equals(Condition.WEATHER_NONE) && state.Weather.DurationRemaining > 0) {
				state.Weather.DecrementDuration();
				// If the weather count hits zero, remove the flag and display the change.
				if (state.Weather.DurationRemaining == 0) {
					string message = "";
					switch (state.Weather.Condition) {
						case Condition.WEATHER_HARSH_SUNLIGHT:
							message = Lang.GetBattleMessage(BattleMessage.SUNLIGHT_FADED);
							break;
						case Condition.WEATHER_RAIN:
							message = Lang.GetBattleMessage(BattleMessage.RAIN_STOPPED);
							break;
						case Condition.WEATHER_SANDSTORM:
							message = Lang.GetBattleMessage(BattleMessage.SANDSTORM_SUBSIDED);
							break;
						case Condition.WEATHER_HAIL:
							message = Lang.GetBattleMessage(BattleMessage.HAIL_STOPPED);
							break;
						case Condition.WEATHER_SNOW:
							message = Lang.GetBattleMessage(BattleMessage.SNOW_STOPPED);
							break;
						case Condition.WEATHER_FOG:
							message = Lang.GetBattleMessage(BattleMessage.FOG_LIFTED);
							break;
						case Condition.WEATHER_EXTREME_SUNLIGHT:
							message = Lang.GetBattleMessage(BattleMessage.EXTREME_SUNLIGHT_FADED);
							break;
						case Condition.WEATHER_HEAVY_RAIN:
							message = Lang.GetBattleMessage(BattleMessage.HEAVY_RAIN_STOPPED);
							break;
						case Condition.WEATHER_STRONG_WIND:
							message = Lang.GetBattleMessage(BattleMessage.MYSTERIOUS_WIND_DISAPPEARED);
							break;
						case Condition.WEATHER_SHADOWY_AURA:
						default:
							message = "";
							break;
					}
					MessageBox(message);
					state.Weather.ClearWeatherTerrain();
				}
				else {
					string message = "";
					switch (state.Weather.Condition) {
						case Condition.WEATHER_HARSH_SUNLIGHT:
						case Condition.WEATHER_EXTREME_SUNLIGHT:
							message = Lang.GetBattleMessage(BattleMessage.SUNLIGHT_IS_HARSH);
							break;
						case Condition.WEATHER_RAIN:
						case Condition.WEATHER_HEAVY_RAIN:
							message = Lang.GetBattleMessage(BattleMessage.ITS_RAINING);
							break;
						case Condition.WEATHER_SANDSTORM:
							message = Lang.GetBattleMessage(BattleMessage.SANDSTORM_IS_RAGING);
							break;
						case Condition.WEATHER_HAIL:
							message = Lang.GetBattleMessage(BattleMessage.ITS_HAILING);
							break;
						case Condition.WEATHER_SNOW:
							message = Lang.GetBattleMessage(BattleMessage.ITS_SNOWING);
							break;
						case Condition.WEATHER_STRONG_WIND:
						case Condition.WEATHER_FOG:
						case Condition.WEATHER_SHADOWY_AURA:
						default:
							message = "";
							break;
					}
					MessageBox(message);
				}
			}

			// Water and Mud Sports
			ResolveCondition(state, Condition.WATER_SPORT, BattleMessage.WATER_SPORT_END);
			ResolveCondition(state, Condition.MUD_SPORT, BattleMessage.MUD_SPORT_END);
			
			// Side-specific conditions.
			for (u8 side = 0; side < format.numSides; side++) {
				// Tailwind.
				ResolveCondition(state, side, Condition.TAILWIND,
					BattleMessage.ALLY_TAILWIND_END,
					BattleMessage.ENEMY_TAILWIND_END
				);

				// Reflect, Light Screen, Aurora Veil
				ResolveCondition(state, side, Condition.REFLECT,
					BattleMessage.ALLY_REFLECT_WORE_OFF,
					BattleMessage.OPPONENT_REFLECT_WORE_OFF
				);
				ResolveCondition(state, side, Condition.LIGHT_SCREEN,
					BattleMessage.ALLY_LIGHT_SCREEN_WORE_OFF,
					BattleMessage.OPPONENT_LIGHT_SCREEN_WORE_OFF
				);
				ResolveCondition(state, side, Condition.AURORA_VEIL,
					BattleMessage.ALLY_AURORA_VEIL_WORE_OFF,
					BattleMessage.OPPONENT_AURORA_VEIL_WORE_OFF	
				);

				// Safeguard
				ResolveCondition(state, side, Condition.SAFEGUARD,
					BattleMessage.PLAYER_NO_LONGER_PROTECTED_BY_SAFEGUARD,
					BattleMessage.OPPONENT_NO_LONGER_PROTECTED_BY_SAFEGUARD
				);

				// Mist
				ResolveCondition(state, side, Condition.MIST, 
					BattleMessage.YOUR_TEAM_NO_LONGER_PROTECTED_BY_MIST, 
					BattleMessage.OPPOSING_TEAM_NO_LONGER_PROTECTED_BY_MIST
				);
			}

			// In-battle effects are handled after counting down.
			for (u8 i = 0; i < format.numSlots; i++) {
				BattleMon bm = GetMonInSlot(state, i);
				if (bm == null) {
					continue;
				}

				if (state.Weather.Equals(Condition.WEATHER_HAIL)) {
					if (bm.DamagedByHail(state)) {
						MessageBox(Lang.GetBattleMessage(BattleMessage.MON_HURT_BY_HAIL, bm.GetName()));
						u16 damage = bm.GetPercentOfMaxHp(FieldConditions.HAIL_CHIP_DAMAGE);
						//TODO: b_DamageMon(state, bm, &damage, true, false);
					}
				}
				if (state.Weather.Equals(Condition.WEATHER_SANDSTORM)) {
					if (bm.DamagedBySandstorm(state)) {
						MessageBox(Lang.GetBattleMessage(BattleMessage.MON_HURT_BY_SANDSTORM, bm.GetName()));
						u16 damage = bm.GetPercentOfMaxHp(FieldConditions.SANDSTORM_CHIP_DAMAGE);
						//TODO: b_DamageMon(state, bm, &damage, true, false);
					}
				}
			}
		}
		private void ResolveCondition(BattleState state, Condition condition, BattleMessage message) {
			if (state.FieldHasCondition(condition, out FieldCondition c)) {
				if (c.DurationRemaining == 0) {
					state.RemoveCondition(c);
					MessageBox(Lang.GetBattleMessage(message));
				}
				c.DecrementDuration();
			}
		}
		private void ResolveCondition(BattleState state, u8 side, Condition condition, BattleMessage clientMessage, BattleMessage remoteMessage) {
			if (state.SideHasCondition(side, condition, out FieldCondition c)) {
				if (c.DurationRemaining == 0) {
					state.RemoveCondition(c);
					if (side == SIDE_CLIENT) {
						MessageBox(Lang.GetBattleMessage(clientMessage));
					}
					else {
						MessageBox(Lang.GetBattleMessage(remoteMessage));
					}
				}
				c.DecrementDuration();
			}
		}

		/// <summary>
		/// Performs actions for certain terrain.
		/// </summary>
		/// <param name="state"></param>
		private void DoAfterTurnTerrainEvents(BattleState state) {
			// If there is active terrain, decrement the counter.
			if (!state.Terrain.Equals(Condition.TERRAIN_NONE) && state.Terrain.DurationRemaining > 0) {
				state.Terrain.DecrementDuration();
				// If the terrain count hits zero, remove the flag and display the change.
				if (state.Terrain.DurationRemaining == 0) {
					string message = "";
					switch (state.Terrain.Condition) {
						case Condition.TERRAIN_ELECTRIC:
							message = Lang.GetBattleMessage(BattleMessage.ELECTRIC_TERRAIN_END);
							break;
						case Condition.TERRAIN_GRASSY:
							message = Lang.GetBattleMessage(BattleMessage.GRASSY_TERRAIN_END);
							break;
						case Condition.TERRAIN_MISTY:
							message = Lang.GetBattleMessage(BattleMessage.MISTY_TERRAIN_END);
							break;
						case Condition.TERRAIN_PSYCHIC:
							message = Lang.GetBattleMessage(BattleMessage.PSYCHIC_TERRAIN_END);
							break;
						default:
							message = "";
							break;
					}
					MessageBox(message);
					state.Terrain.ClearWeatherTerrain();
				}
				else {
					string message = "";
					switch (state.Terrain.Condition) {
						case Condition.TERRAIN_ELECTRIC:
							message = Lang.GetBattleMessage(BattleMessage.ELECTRIC_TERRAIN_ACTIVE);
							break;
						case Condition.TERRAIN_GRASSY:
							message = Lang.GetBattleMessage(BattleMessage.GRASSY_TERRAIN_ACTIVE);
							break;
						case Condition.TERRAIN_MISTY:
							message = Lang.GetBattleMessage(BattleMessage.MISTY_TERRAIN_ACTIVE);
							break;
						case Condition.TERRAIN_PSYCHIC:
							message = Lang.GetBattleMessage(BattleMessage.PSYCHIC_TERRAIN_ACTIVE);
							break;
						default:
							message = "";
							break;
					}
					MessageBox(message);
				}
			}

			// In-battle effects are handled after counting down.
			for (u8 i = 0; i < format.numSlots; i++) {
				BattleMon bm = GetMonInSlot(state, i);
				if (bm == null || !bm.IsGrounded(state)) {
					continue;
				}
			
				if (state.Terrain.Condition == Condition.TERRAIN_GRASSY) {
					u16 healAmount = bm.GetPercentOfMaxHp(FieldConditions.GRASSY_TERRAIN_HEAL_AMOUNT);
					//TODO: b_HealMon(state, bm, &healAmount, false);
				}
			}
		}
	}

	public class BattleState : ISerializable<BattleState> {
		public Buffer Write() {
			Buffer data = new Buffer();

			data.AddValue(FieldMons);

			data.AddValue((u8)Teams.Length);
			foreach (BattleMon[] team in Teams) {
				for (u8 i = 0; i < PARTY_SIZE; i++) {
					BattleMon bm = team[i];
					if (bm != null) {
						data.AddValue(bm);
					}
					else {
						data.AddValue(new Buffer());
					}
				}
			}

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

			u8 numTeams = data.Read8();
			state.Teams = new BattleMon[numTeams][];
			for (u8 i = 0; i < numTeams; i++) {
				state.Teams[i] = new BattleMon[PARTY_SIZE];
				for (u8 j = 0; j < PARTY_SIZE; j++) {
					Buffer bmData = data.ReadBuffer();
					if (bmData.Size > 0) {
						state.Teams[i][j] = BattleMon.Load(bmData);
					}
					else {
						state.Teams[i][j] = null;
					}
				}
			}

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
		public BattleState(Battle target, TrainerBattleContext[] players) {
			this.FieldMons = u32.MaxValue;
			this.NumSlots = target.format.numSlots;
			this.Teams = new BattleMon[players.Length][];
			for (u8 i = 0; i < NumSlots; i++) {
				this.Teams[i] = new BattleMon[PARTY_SIZE];
				for (u8 j = 0; j < PARTY_SIZE; j++) {
					this.Teams[i][j] = players[i].team[j];
				}
			}
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

		public BattleMon[][] Teams { get; private set; }
		private u8 NumSlots { get; set; }

		public const u8 BITS_PER_MON_INDEX = 4;
		public const u8 SLOT_EMPTY = 1 << BITS_PER_MON_INDEX - 1;
		public u32 FieldMons { get; set; }

		private List<FieldCondition> Conditions { get; set; }
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
		/// Inserts a new action into the given state's action array.
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
			for (u8 j = (u8)(i + 1); j < Actions.Length + 1; j++) {
				newActions[j + 1] = Actions[j];
			}
			// Update the state's array.
			Actions = newActions;
		}
	
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