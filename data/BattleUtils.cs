using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.Strings.Lang;
using static PkmnEngine.BattleMoves;
using static PkmnEngine.BattleActionCodes;
using static PkmnEngine.Types;
using static PkmnEngine.DamageCalc;
using static PkmnEngine.MoveEffects;

using PkmnEngine.Strings;

using static System.MathF;
using System.Threading.Tasks;

namespace PkmnEngine {
	public static class BattleUtils {
		/// <summary>
		/// Determines if a mon can successfully act through paralysis, freeze, and sleep.
		/// </summary>
		/// <param name="battle">Battle object.</param>
		/// <param name="state">The current BattleState.</param>
		/// <param name="attacker">The attacking BattleMon.</param>
		/// <param name="moveID">ID of the move being used.</param>
		/// <returns>True if the mon can act, false otherwise.</returns>
		private static bool MoveStatusBlockers(Battle battle, BattleState state, BattleMon attacker, BattleMoveID moveID) {
			// Paralyzed mons have a chance to not be able to move.
			if (attacker.HasStatus(Status.PARALYSIS) && battle.rand.NextDouble() < StatusEffects.PARALYSIS_PROC_CHANCE) {
				// No need to set BM_PARAMS[0] since it's already set above.
				MessageBox(GetBattleMessage(BattleMessage.MON_IS_PARALYZED_AND_CANT_MOVE, attacker.GetName()));
				return false;
			}
			// Frozen mons cannot move.
			else if (attacker.HasStatus(Status.FREEZE) && (gBattleMoves(moveID).flags & Flag.THAWS_USER) == 0) {
				// A frozen mon has a set chance of thawing out every turn.
				if (battle.Random01() < StatusEffects.FREEZE_THAW_CHANCE) {
					ThawMon(attacker);
				}
				else {
					MessageBox(GetBattleMessage(BattleMessage.MON_IS_FROZEN_SOLID, attacker.GetName()));
					return false;
				}
			}
			// Sleeping mons can only use certain moves.
			else if (attacker.HasStatus(Status.SLEEP)) {
				u8 sleepingTurns = (u8)attacker.GetStatusParam(StatusParam.SLEEPING_TURNS);
				attacker.IncrementStatusParam(StatusParam.SLEEPING_TURNS);
				// Sleeping mons will wake up after a certain number of turns.
				if (sleepingTurns >= attacker.GetStatusParam(StatusParam.NV_STATUS_DURATION)) {
					WakeUpMon(attacker);
				}
				else {
					// Display that the mon is sleeping.
					MessageBox(GetBattleMessage(BattleMessage.MON_IS_FAST_ASLEEP, attacker.GetName()));
					// If the mon cannot use this move while asleep, exit.
					if ((gBattleMoves(moveID).flags & Flag.USABLE_WHILE_ASLEEP) == 0) {
						return false;
					}
				}
			}
			// Confused mons have a chance to hurt themselves instead of acting.
			if (attacker.HasStatus(Status.CONFUSION)) {
				MessageBox(GetBattleMessage(BattleMessage.MON_IS_CONFUSED, attacker.GetName()));
				u8 confusedTurns = (u8)attacker.GetStatusParam(StatusParam.CONFUSED_TURNS);
				attacker.IncrementStatusParam(StatusParam.CONFUSED_TURNS);
				// Mons will remain confused for up to 4 turns and have a 25% chance to snap out every turn.
				if ((confusedTurns >= 4) || (battle.rand.NextDouble() < 0.25)) {
					MessageBox(GetBattleMessage(BattleMessage.MON_SNAPPED_OUT_OF_CONFUSION, attacker.GetName()));
					attacker.SetStatusParam(StatusParam.CONFUSED_TURNS, 0);
					attacker.RemoveStatus(Status.CONFUSION);
				}
				// Confused mons have a 33% chance to hurt themselves instead of using their move.
				else if (battle.rand.NextDouble() < 0.33) {
					// Confusion acts as a physical move with 40 power and no type.
					// This same effect can be achieved by using tackle and overriding the type effectiveness and power :p
					u16 damage = CalcDamage(battle, state, attacker, attacker, BattleMoveID.TACKLE, 1, new Mods(), new Overrides(0, 0, 40, 0));
					attacker.DamageMon(state, ref damage, false, true);
					MessageBox(GetBattleMessage(BattleMessage.IT_HURT_ITSELF_IN_ITS_CONFUSION));
					return false;
				}
			}

			return true;
		}
		/// <summary>
		/// Determines if a given move can be used during the current weather conditions and prints message if not.
		/// </summary>
		/// <param name="state">Current BattleState.</param>
		/// <param name="moveID">ID of the move being used.</param>
		/// <returns>True if the move can be used, false if not.</returns>
		private static bool MoveWeatherBlockers(BattleState state, BattleMoveID moveID) {
			// Water type moves cannot be used during extreme sunlight.
			if ((state.Weather.Condition == Condition.WEATHER_EXTREME_SUNLIGHT) && gBattleMoves(moveID).moveType == Type.WATER) {
				MessageBox(GetBattleMessage(BattleMessage.WATER_ATTACK_EVAPORATED));
				return false;
			}
			// Fire type moves cannot be used during heavy rain.
			else if ((state.Weather.Condition == Condition.WEATHER_HEAVY_RAIN) && gBattleMoves(moveID).moveType == Type.FIRE) {
				MessageBox(GetBattleMessage(BattleMessage.FIRE_ATTACK_FIZZLED_OUT));
				return false;
			}

			return true;
		}
		
		/// <summary>
		/// Sets a mon's successive protect counter to zero if it uses a non-protecting move.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="moveID"></param>
		private static void CheckSuccessiveProtects(BattleMon attacker, BattleMoveID moveID) {
			// Clears successive protect count when not using a protecting move.
			if ((gBattleMoves(moveID).flags & BattleMoves.Flag.PROTECTS) != 0) {
				attacker.SetStatusParam(StatusParam.SUCCESSIVE_PROTECTS, 0);
			}
		}
		
		/// @brief Call this when a battle action uses a move. 
		/// Performs checks for statuses and weather before entering other routines to use the move, and reduces PP by 1.
		/// Also calculates hit chance before doing the move.
		/// @param battle The current Battle.
		/// @param state The current BattleState.
		/// @param slotUser The slot on the field of the mon using the move.
		/// @param moveID The ID of the move being used.
		/// @param moveSlot The slot of the move being used in the mon's moves array.
		/// @param slotsTarget The encoded slot(s) of the target mon(s).
		/// @param index The index of the action in the state's action array.
		public static async Task UseMove(Battle battle, BattleState state, u8 slotUser, BattleMoveID moveID, u8 moveSlot, u32 slotsTarget, u8 index) {
			BattleMon attacker = battle.GetMonInSlot(state, slotUser), defender;
			u8[] targets = Battle.SplitTargets(slotsTarget);

			//BM_PARAMS[0] = GetMonName(attacker.mon);
			//BM_PARAMS[1] = GetMoveName(moveID);

			// Check for statuses.
			if (!MoveStatusBlockers(battle, state, attacker, moveID)) {
				return;
			}
			// Clear successive protect counter if applicable.
			CheckSuccessiveProtects(attacker, moveID);

			//// Only display the move being used if the mon can actually use it.
			//MessageBox(GetBattleMessage(BattleMessage.MON_USED_MOVE));

			// Weird weather conditions:
			if (!MoveWeatherBlockers(state, moveID)) {
				return;
			}

			if (moveID != BattleMoveID.STRUGGLE) {
				if (!attacker.CanUseMove(battle, state, moveSlot, true)) {
					return;
				}
				DecreaseMovePP(attacker, moveSlot);
			}

			u32 flags = 0;
			for (u8 i = 0; i < targets.Length; i++) {
				defender = battle.GetMonInSlot(state, targets[i]);

				if (!MoveHit(battle, state, attacker, defender, moveID)) {
					MessageBox(GetBattleMessage(BattleMessage.MON_AVOIDED_ATTACK, defender.GetName()));
					continue;
				}

				flags = await DoMove(battle, state, attacker, defender, moveID, slotUser, targets[i], (u8)targets.Length, index, true);

				//if (flags & FLAG_SWITCH_TO_MON) {
				//	state.InsertAction(BATTLE_ACTION_SWITCH(slotUser, (u8)(flags & 0xFFFF)), index);
				//}
			}
		}
		/// <summary>
		/// Call this when using a move without performing checks for weather, statuses, or accuracy and does not reduce PP.
		/// DO NOT CALL THIS DIRECTLY UNLESS YOU WANT TO BYPASS THESE CHECKS.
		/// Still checks for type immunity, protection, and secondary effect chance. Also runs OnContactMade callback. 
		/// </summary>
		/// <param name="battle">Current Battle.</param>
		/// <param name="state">Current BattleState.</param>
		/// <param name="attacker">The attacking BattleMon.</param>
		/// <param name="defender">The defending / targeted BattleMon.</param>
		/// <param name="moveID">The ID of the move being used</param>
		/// <param name="slotUser"></param>
		/// <param name="slotTarget"></param>
		/// <param name="numTargets">The number of mons being targeted.</param>
		/// <param name="index">The index of the action in the state's action array.</param>
		/// <param name="print">If true, prints "[mon] used [move]!". Default: true.</param>
		/// <returns>Move effect flags.</returns>
		public static async Task<u32> DoMove(Battle battle, BattleState state, BattleMon attacker, BattleMon defender, BattleMoveID moveID, u8 slotUser, u8 slotTarget, u8 numTargets, u8 index, bool print = true) {
			if (print) {
				MessageBox(GetBattleMessage(BattleMessage.MON_USED_MOVE, attacker.GetName(), GetMoveName(moveID)));
			}

			// Record the slot of the user as the last mon that attacked the target.
			defender.SetStatusParam(StatusParam.LAST_MON_HIT_BY, slotUser);

			// If the move is ineffective and the move does not ignore the type chart, then stop here.
			if (Abs(TypeEffectiveness(defender, moveID)) < 1e-10 && (gBattleMoves(moveID).flags & BattleMoves.Flag.IGNORE_TYPE_EFF) == 0) {
				MessageBox(GetBattleMessage(BattleMessage.IMMUNE, defender.GetName()));
				// Do Contact events.
				if ((gBattleMoves(moveID).flags & BattleMoves.Flag.MAKES_CONTACT) != 0) {
			//		//TODO: OnContactMade(state, attacker, defender);
				}
			//	return FLAG_MOVE_FAILED;
			}

			// Check for protect.
			if ((gBattleMoves(moveID).flags & BattleMoves.Flag.PROTECT_AFFECTED) != 0 && defender.HasStatus(Status.PROTECTION)) {
				MessageBox(GetBattleMessage(BattleMessage.MON_PROTECTED_ITSELF, defender.GetName()));
				// Do contact events.
				if ((gBattleMoves(moveID).flags & BattleMoves.Flag.MAKES_CONTACT) != 0) {
			//		// TODO: OnContactMade(state, attacker, defender);
				}
			//	return FLAG_MOVE_FAILED;
			}

			// If the used move thaws the user, then thaw the user first.
			if ((gBattleMoves(moveID).flags & BattleMoves.Flag.THAWS_USER) != 0) {
				//TODO: //BattleMoveEffects::sThawMon(attacker);
			}

			// Do the move's primary effect.
			MoveEffectParams data = new MoveEffectParams(
				battle,
				state,
				attacker,
				defender,
				gBattleMoves(moveID),
				moveID,
				slotUser,
				slotTarget,
				numTargets,
				index,
				true,
				0
			);
			u32 flags = await gMoveEffectMap(gBattleMoves(moveID).primaryEffect)(data);
			
			if ((flags & FLAG_MOVE_FAILED) != 0) {
				//MessageBox(GetBattleMessage(BattleMessage.MOVE_FAILED));
				return flags;
			}

			//// Determine if the target has fainted.
			//// TODO: this should kinda be done in the DamageMon function.
			//if (GetEffectiveHP(state, defender) == 0) {
			//	flags |= FLAG_TARGET_FAINTED;
			//	//BM_PARAMS[0] = GetMonName(defender.mon);
			//	//MessageBox(GetBattleMessage(BattleMessage.MON_FAINTED));
			//	// TODO: remove all the target's actions from the action list, among other things.
			//	return flags;
			//}

			// Do the secondary effect, if there is one and the primary effect does not prefent it.
			if (EffectHit(battle, gBattleMoves(moveID).secondaryEffectChance)) {
				if ((flags & FLAG_DO_NOT_DO_SECONDARY_EFFECT) == 0 && gBattleMoves(moveID).secondaryEffect != MoveEffectID.NONE) {
					data.isPrimaryEffect = false;
					flags = await gMoveEffectMap(gBattleMoves(moveID).secondaryEffect)(data);
				}
			}

			// Do contact events.
			if ((gBattleMoves(moveID).flags & BattleMoves.Flag.MAKES_CONTACT) != 0) {
				//TODO: OnContactMade(state, attacker, defender);
			}

			return flags;
		}

		/// <summary>
		/// Reduces the PP of a mon's move by 1.
		/// </summary>
		/// <param name="user">The BattleMon whose PP to decrease.</param>
		/// <param name="moveSlot">The slot of the move to decrease.</param>
		private static void DecreaseMovePP(BattleMon user, u8 moveSlot) {
			user.pp[moveSlot] -= 1;
		}

		// TODO:
		/// @brief Determines if a mon's move hits its target.
		/// @param state The current BattleState.
		/// @param attacker Attacking BattleMon.
		/// @param defender Defending BattleMon.
		/// @param move A pointer to the BattleMove in gBattleMoves that is being used.
		/// @return True if the move hits.
		public static bool MoveHit(Battle battle, BattleState state, BattleMon attacker, BattleMon defender, BattleMoveID moveID) {
			BattleMove move = gBattleMoves(moveID);

			// The startup of 2-turn moves like Fly or Solar Beam cannot miss, so deal with that here.
			if ((move.flags & BattleMoves.Flag.SEMI_INVUL_TURN) != 0 && !attacker.HasStatus(Status.SEMI_INVULNERABLE_TURN)) {
				return true;
			}
			if ((move.flags & BattleMoves.Flag.CHARGING_TURN) != 0 && !attacker.HasStatus(Status.CHARGING_TURN)) {
				return true;
			}

			// Psychic terrain prevents Pokémon on the ground from being hit by moves with increased priority.
			if (defender.IsGrounded(state) && (state.Terrain.Condition == Condition.TERRAIN_PSYCHIC) && move.priority > 0) {
				return false;
			}

			if (defender.HasStatus(Status.SEMI_INVULNERABLE_TURN)) {
				switch (defender.GetStatusParam(StatusParam.SEMI_INVULNERABLE)) {
					case StatusEffects.SEMI_INVULNERABLE_AIR:		if ((move.flags & BattleMoves.Flag.HITS_SEMI_INVUL_AIR) != 0)		{return false;} break;
					case StatusEffects.SEMI_INVULNERABLE_GROUND:	if ((move.flags & BattleMoves.Flag.HITS_SEMI_INVUL_GROUND) != 0)	{return false;} break;
					case StatusEffects.SEMI_INVULNERABLE_WATER:		if ((move.flags & BattleMoves.Flag.HITS_SEMI_INVUL_WATER) != 0)		{return false;} break;
					case StatusEffects.SEMI_INVULNERABLE_PHANTOM:	return false;
					default:
						break;
				}
			}

			if ((move.flags & BattleMoves.Flag.ALWAYS_HIT) != 0) {
				return true;
			}
			if ((move.flags & BattleMoves.Flag.ALWAYS_HIT_RAIN) != 0 && 
				(state.Weather.Condition == Condition.WEATHER_RAIN)
			) {
				return true;
			}
			if ((move.flags & BattleMoves.Flag.ALWAYS_HIT_HAIL) != 0 && 
				(state.Weather.Condition == Condition.WEATHER_HAIL || state.Weather.Condition == Condition.WEATHER_SNOW)
			) {
				return true;
			}

			if (attacker.HasStatus(Status.TAKING_AIM)) {
				return true;
			}


			float roll = battle.Random01();

			if (state.Weather.Condition == Condition.WEATHER_FOG) {
				roll *= FieldConditions.FOG_ACCURACY_REDUCTION;
			}

			float hitChance = DamageCalc.CalculateHitChance(state, attacker, defender, moveID);
			bool hit = roll <= hitChance;

			return hit;
		}
		/// @brief Determines if a move's secondary effect will hit.
		/// @param hitChance The chance for the effect to hit.
		/// @return True if the effect hits, false if it doesn't.
		private static bool EffectHit(Battle battle, u8 hitChance) {
			return (battle.Random01() * 100) <= hitChance;
		}

		/// @brief Gets the default target(s) for a given move.
		/// @param moveID ID of the move.
		/// @param side Side of the mon using the move. SIDE_PLAYER or SIDE_OPPONENT.
		/// @return The encoded (+1'd) slot(s) of the default target(s).
		public static u32 GetDefaultMoveTarget(BattleMoveID moveID, BattleMon attacker) {
			// TODO: fix this whole mess.
			u32 targetSlots = 0;
			switch (attacker.Side) {
				case Battle.SIDE_CLIENT: {
					switch (gBattleMoves(moveID).target) {
						case MOVE_TARGET_USER:
						case MOVE_TARGET_USER_OR_SELECTED:
						case MOVE_TARGET_USER_OR_ALLY:
						case MOVE_TARGET_USER_FIELD:
							targetSlots = 0;
							break;
						case MOVE_TARGET_SELECTED:
						case MOVE_TARGET_DEPENDS:
						case MOVE_TARGET_RANDOM:
						case MOVE_TARGET_BOTH:
						case MOVE_TARGET_FOES_AND_ALLY:
						case MOVE_TARGET_OPPONENTS_FIELD:
						case MOVE_TARGET_SELECTED_OPPONENT:
						case MOVE_TARGET_SELECTED_ALLY:
						case MOVE_TARGET_ANY_NOT_USER:
						case MOVE_TARGET_ALL:
						case MOVE_TARGET_ANY:
						case MOVE_TARGET_ALL_OPPONENTS:
							targetSlots = 1;
							break;
					}
					break;
				}
				case Battle.SIDE_REMOTE: {
					switch (gBattleMoves(moveID).target) {
						case MOVE_TARGET_USER:
						case MOVE_TARGET_USER_OR_SELECTED:
						case MOVE_TARGET_USER_OR_ALLY:
						case MOVE_TARGET_USER_FIELD:
							targetSlots = 1;
							break;
						case MOVE_TARGET_SELECTED:
						case MOVE_TARGET_DEPENDS:
						case MOVE_TARGET_RANDOM:
						case MOVE_TARGET_BOTH:
						case MOVE_TARGET_FOES_AND_ALLY:
						case MOVE_TARGET_OPPONENTS_FIELD:
						case MOVE_TARGET_SELECTED_OPPONENT:
						case MOVE_TARGET_SELECTED_ALLY:
						case MOVE_TARGET_ANY_NOT_USER:
						case MOVE_TARGET_ALL:
						case MOVE_TARGET_ANY:
						case MOVE_TARGET_ALL_OPPONENTS:
							targetSlots = 0;
							break;
					}
					break;
				}
			}
			
			return targetSlots;
		}
	}
}