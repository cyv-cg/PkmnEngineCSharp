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

using static System.MathF;
using PkmnEngine.Strings;

namespace PkmnEngine {
	public static class BattleUtils {
		/// @brief Determines if a mon can successfully act through paralysis, freeze, and sleep.
		/// @param state The current BattleState.
		/// @param attacker The attacking BattleMon.
		/// @param moveID ID of the move being used.
		/// @return True if the mon can act, false otherwise.
		private static bool MoveStatusBlockers(BattleState state, BattleMon attacker, BattleMoveID moveID) {
			//BM_PARAMS[0] = GetMonName(attacker->mon);

			//// Paralyzed mons have a chance to not be able to move.
			//if (b_MonHasStatus(attacker, STATUS_PARALYSIS) && Random01() < PARALYSIS_PROC_CHANCE) {
			//	// No need to set BM_PARAMS[0] since it's already set above.
			//	MessageBox(lang::GetBattleMessage(BATTLE_MESSAGE_MON_IS_PARALYZED_AND_CANT_MOVE));
			//	return false;
			//}
			//// Frozen mons cannot move.
			//else if (b_MonHasStatus(attacker, STATUS_FREEZE) && !(gBattleMoves[moveID].flags & FLAG_THAWS_USER)) {
			//	// A frozen mon has a set chance of thawing out every turn.
			//	if (Random01() < FREEZE_THAW_CHANCE) {
			//		BattleMoveEffects::sThawMon(attacker);
			//	}
			//	else {
			//		MessageBox(lang::GetBattleMessage(BATTLE_MESSAGE_MON_IS_FROZEN_SOLID));
			//		return false;
			//	}
			//}
			//// Sleeping mons can only use certain moves.
			//else if (b_MonHasStatus(attacker, STATUS_SLEEP)) {
			//	u8 sleepingTurns = GetStatusParam(attacker, STATUS_PARAM_SLEEPING_TURNS);
			//	IncrementStatusParam(attacker, STATUS_PARAM_SLEEPING_TURNS);
			//	// Sleeping mons will wake up after a certain number of turns.
			//	if (sleepingTurns >= attacker->NVStatusDuration) {
			//		BattleMoveEffects::sWakeUpMon(attacker);
			//	}
			//	else {
			//		// Display that the mon is sleeping.
			//		MessageBox(lang::GetBattleMessage(BATTLE_MESSAGE_MON_IS_FAST_ASLEEP));
			//		// If the mon cannot use this move while asleep, exit.
			//		if (!(gBattleMoves[moveID].flags & FLAG_USABLE_WHILE_ASLEEP)) {
			//			return false;
			//		}
			//	}
			//}
			//// Confused mons have a chance to hurt themselves instead of acting.
			//if (b_MonHasStatus(attacker, STATUS_CONFUSION)) {
			//	MessageBox(lang::GetBattleMessage(BATTLE_MESSAGE_MON_IS_CONFUSED));
			//	u8 confusedTurns = GetStatusParam(attacker, STATUS_PARAM_CONFUSED_TURNS);
			//	IncrementStatusParam(attacker, STATUS_PARAM_CONFUSED_TURNS);
			//	// Mons will remain confused for up to 4 turns and have a 25% chance to snap out every turn.
			//	if ((confusedTurns >= 4) || (Random01() < 0.25)) {
			//		MessageBox(lang::GetBattleMessage(BATTLE_MESSAGE_MON_SNAPPED_OUT_OF_CONFUSION));
			//		SetStatusParam(attacker, STATUS_PARAM_CONFUSED_TURNS, 0);
			//		attacker->status &= ~STATUS_CONFUSION;
			//	}
			//	// Confused mons have a 33% chance to hurt themselves instead of using their move.
			//	else if (Random01() < 0.33) {
			//		// Confusion acts as a physical move with 40 power and no type.
			//		const struct BattleMove move = {
			//			.moveType = TYPE_NONE,
			//			.power = 40,
			//			.moveCat = CAT_PHYSICAL,
			//		};
			//		u16 damage = CalcDamage(attacker, attacker, SIDE_BOTH, SIDE_BOTH, &move, 1, state, false, 1, 1);
			//		b_DamageMon(state, attacker, &damage, false, true);
			//		MessageBox(lang::GetBattleMessage(BATTLE_MESSAGE_IT_HURT_ITSELF_IN_ITS_CONFUSION));
			//		return false;
			//	}
			//}

			return true;
		}
		/// @brief Determines if a given move can be used during the current weather conditions and prints message if not.
		/// @param state Current BattleState.
		/// @param moveID ID of the move being used.
		/// @return True if the move can be used, false if not.
		private static bool MoveWeatherBlockers(BattleState state, BattleMoveID moveID) {
			//// Water type moves cannot be used during extreme sunlight.
			//if ((state->fieldCondition & WEATHER_EXTREME_SUNLIGHT) && gBattleMoves[moveID].moveType == TYPE_WATER) {
			//	MessageBox(lang::GetBattleMessage(BATTLE_MESSAGE_WATER_ATTACK_EVAPORATED));
			//	return false;
			//}
			//// Fire type moves cannot be used during heavy rain.
			//else if ((state->fieldCondition & WEATHER_HEAVY_RAIN) && gBattleMoves[moveID].moveType == TYPE_FIRE) {
			//	MessageBox(lang::GetBattleMessage(BATTLE_MESSAGE_FIRE_ATTACK_FIZZLED_OUT));
			//	return false;
			//}

			return true;
		}
		
		/// @brief Sets a mon's successive protect counter to zero if it uses a non-protecting move.
		/// @param attacker Attacking BattleMon.
		/// @param moveID ID of the move being used.
		private static void CheckSuccessiveProtects(BattleMon attacker, BattleMoveID moveID) {
			//// Clears successive protect count when not using a protecting move.
			//if (!(gBattleMoves[moveID].flags & FLAG_PROTECTS)) {
			//	SetStatusParam(attacker, STATUS_PARAM_SUCCESSIVE_PROTECTS, 0);
			//}
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
		public static void UseMove(Battle battle, BattleState state, u8 slotUser, BattleMoveID moveID, u8 moveSlot, u32 slotsTarget, u8 index) {
			BattleMon attacker = battle.GetMonInSlot(state, slotUser), defender;
			u8[] targets = Battle.SplitTargets(slotsTarget);

			//BM_PARAMS[0] = GetMonName(attacker->mon);
			//BM_PARAMS[1] = lang::GetMoveName(moveID);

			// Check for statuses.
			if (!MoveStatusBlockers(state, attacker, moveID)) {
				return;
			}
			// Clear successive protect counter if applicable.
			CheckSuccessiveProtects(attacker, moveID);

			//// Only display the move being used if the mon can actually use it.
			//MessageBox(lang::GetBattleMessage(BATTLE_MESSAGE_MON_USED_MOVE));

			// Weird weather conditions:
			if (!MoveWeatherBlockers(state, moveID)) {
				return;
			}

			if (moveID != BattleMoveID.STRUGGLE) {
				if (!attacker.CanUseMove(battle, state, moveSlot, true)) {
					return;
				}
				DecreaseMovePP(attacker, moveSlot, 1);
			}

			u32 flags = 0;
			for (u8 i = 0; i < targets.Length; i++) {
				defender = battle.GetMonInSlot(state, targets[i]);

				if (!MoveHit(state, attacker, defender, gBattleMoves(moveID))) {
					MessageBox(GetBattleMessage(BattleMessage.MON_AVOIDED_ATTACK, defender.GetName()));
					continue;
				}

				flags = DoMove(battle, state, attacker, defender, moveID, slotUser, targets[i], (u8)targets.Length, index, true);

				//if (flags & FLAG_SWITCH_TO_MON) {
				//	state.InsertAction(BATTLE_ACTION_SWITCH(slotUser, (u8)(flags & 0xFFFF)), index);
				//}
			}
		}
		/// @brief Call this when using a move without performing checks for weather, statuses, or accuracy and does not reduce PP.
		/// DO NOT CALL THIS DIRECTLY UNLESS YOU WANT TO BYPASS THESE CHECKS.
		/// Still checks for type immunity, protection, and secondary effect chance. Also runs OnContactMade callback. 
		/// @param battle The Battle.
		/// @param state The current BattleState.
		/// @param attacker The attacking BattleMon.
		/// @param defender The defending / targeted BattleMon.
		/// @param moveID The ID of the move being used
		/// @param slotUser
		/// @param slotTarget
		/// @param numTargets The number of mons being targeted.
		/// @param index The index of the action in the state's action array.
		/// @param b_print If true, prints "[mon] used [move]!". Default: true.
		/// @return flags. See move_effects.hpp for flag description.
		public static u32 DoMove(Battle battle, BattleState state, BattleMon attacker, BattleMon defender, BattleMoveID moveID, u8 slotUser, u8 slotTarget, u8 numTargets, u8 index, bool print) {
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
			u32 flags = gMoveEffectMap(gBattleMoves(moveID).primaryEffect)(data);
			
			if ((flags & FLAG_MOVE_FAILED) != 0) {
				//MessageBox(lang::GetBattleMessage(BATTLE_MESSAGE_MOVE_FAILED));
				return flags;
			}

			//// Determine if the target has fainted.
			//// TODO: this should kinda be done in the DamageMon function.
			//if (GetEffectiveHP(state, defender) == 0) {
			//	flags |= FLAG_TARGET_FAINTED;
			//	//BM_PARAMS[0] = GetMonName(defender->mon);
			//	//MessageBox(lang::GetBattleMessage(BATTLE_MESSAGE_MON_FAINTED));
			//	// TODO: remove all the target's actions from the action list, among other things.
			//	return flags;
			//}

			// Do the secondary effect, if there is one and the primary effect does not prefent it.
			if (EffectHit(gBattleMoves(moveID).secondaryEffectChance)) {
				if ((flags & FLAG_DO_NOT_DO_SECONDARY_EFFECT) == 0 && gBattleMoves(moveID).secondaryEffect != MoveEffectID.NONE) {
					data.isPrimaryEffect = false;
					flags = gMoveEffectMap(gBattleMoves(moveID).secondaryEffect)(data);
				}
			}

			// Do contact events.
			if ((gBattleMoves(moveID).flags & BattleMoves.Flag.MAKES_CONTACT) != 0) {
				//OnContactMade(state, attacker, defender);
			}

			return flags;
		}

		/// @brief Reduces the PP of a mon's move by n. Default: 1.
		/// @param user The BattleMon whose PP to decrease.
		/// @param moveSlot The slot of the move to decrease.
		/// @param n The amount of PP to reduce by.
		private static void DecreaseMovePP(BattleMon user, u8 moveSlot, u8 n) {
			//user.PP[moveSlot] -= n;
		}

		// TODO:
		/// @brief Determines if a mon's move hits its target.
		/// @param state The current BattleState.
		/// @param attacker Attacking BattleMon.
		/// @param defender Defending BattleMon.
		/// @param move A pointer to the BattleMove in gBattleMoves that is being used.
		/// @return True if the move hits.
		private static bool MoveHit(BattleState state, BattleMon attacker, BattleMon defender, BattleMove move) {
			// The startup of 2-turn moves like Fly or Solar Beam cannot miss, so deal with that here.
			if ((move.flags & BattleMoves.Flag.SEMI_INVUL_TURN) != 0 && !attacker.HasStatus(Status.SEMI_INVULNERABLE_TURN)) {
				return true;
			}
			if ((move.flags & BattleMoves.Flag.CHARGING_TURN) != 0 && !attacker.HasStatus(Status.CHARGING_TURN)) {
				return true;
			}

			//// Psychic terrain prevents Pokémon on the ground from being hit by moves with increased priority.
			//if (b_MonIsGrounded(state, defender) && (state->fieldCondition & TERRAIN_PSYCHIC) && move->priority > 0) {
			//	return false;
			//}

			//if (b_MonHasStatus(defender, STATUS_SEMI_INVULNERABLE_TURN)) {
			//	switch (GetStatusParam(defender, STATUS_PARAM_SEMI_INVULNERABLE))
			//	{
			//		case SEMI_INVULNERABLE_AIR:		if (!(move->flags & FLAG_HITS_SEMI_INVUL_AIR))		return false;
			//		case SEMI_INVULNERABLE_GROUND:	if (!(move->flags & FLAG_HITS_SEMI_INVUL_GROUND))	return false;
			//		case SEMI_INVULNERABLE_WATER:	if (!(move->flags & FLAG_HITS_SEMI_INVUL_WATER))	return false;
			//		case SEMI_INVULNERABLE_PHANTOM:	return false;
			//		default:
			//			break;
			//	}
			//}

			if ((move.flags & BattleMoves.Flag.ALWAYS_HIT) != 0) {
				return true;
			}
			//if ((move->flags & FLAG_ALWAYS_HIT_RAIN) && (state->fieldCondition & WEATHER_RAIN)) {
			//	return true;
			//}
			//if ((move->flags & FLAG_ALWAYS_HIT_HAIL) && (state->fieldCondition & (WEATHER_HAIL | WEATHER_SNOW))) {
			//	return true;
			//}

			if (attacker.HasStatus(Status.TAKING_AIM)) {
				return true;
			}


			//float roll = Random01();

			//if (state->fieldCondition & WEATHER_FOG) {
			//	roll *= FOG_ACCURACY_REDUCTION;
			//}

			//float hitChance = CalculateHitChance(state, attacker, defender, move->accuracy, move->flags);
			//bool b_hit = roll <= hitChance;

			return true;
		}
		/// @brief Determines if a move's secondary effect will hit.
		/// @param hitChance The chance for the effect to hit.
		/// @return True if the effect hits, false if it doesn't.
		private static bool EffectHit(u8 hitChance) {
			// BUG: I think something isn't working right here.
			return (Random01() * 100) <= hitChance;
		}
	}
}