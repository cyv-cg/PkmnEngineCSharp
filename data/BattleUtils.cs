using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.Strings.Lang;
using static PkmnEngine.BattleMoves;
using static PkmnEngine.Types;
using static PkmnEngine.DamageCalc;
using static PkmnEngine.MoveEffects;

using PkmnEngine.Strings;

using static System.MathF;
using System.Threading.Tasks;

namespace PkmnEngine {
	public static class BattleUtils {
		private const StringResource.Namespace STRINGS = StringResource.Namespace.BATTLE_COMMON;

		/// <summary>
		/// Mutates given resource depending on a few factors.
		/// Instead of saying "[Mon] did x!", we will conditionally get
		/// "The wild/opposing mon did x!" or "[Name]'s mon did x!"
		/// </summary>
		/// <param name="resource">Default string resource for "[Mon] did x!"</param>
		/// <param name="bm">The BattleMon doing the thing</param>
		/// <param name="name">Name of the trainer of bm. Optional.</param>
		/// <returns>Appropriate StringResource for the actor.</returns>
		public static StringResource GetContextString(StringResource resource, BattleMon bm, string name = null) {
			string key = resource.Key;

			if (name != null) {
				return GetStringResourceWithKey(STRINGS, "PLAYER_" + key);
			}
			if (bm.Mon.Box.IsWild) {
				return GetStringResourceWithKey(STRINGS, "WILD_" + key);
			}
			if (bm.Side == Battle.SIDE_REMOTE) {
				return GetStringResourceWithKey(STRINGS, "OPPOSING_" + key);
			}

			return resource;
		}

		/// <summary>
		/// Call this when a battle action uses a move. 
		/// Performs checks for statuses and weather before entering other routines to use the move, and reduces PP by 1.
		/// Also calculates hit chance before doing the move.
		/// </summary>
		/// <param name="battle">The current Battle.</param>
		/// <param name="state">The current BattleState.</param>
		/// <param name="slotUser">The slot on the field of the mon using the move.</param>
		/// <param name="moveID">The ID of the move being used.</param>
		/// <param name="moveSlot">The slot of the move being used in the mon's moves array.</param>
		/// <param name="slotsTarget">The encoded slot(s) of the target mon(s).</param>
		/// <param name="index">The index of the action in the state's action array.</param>
		/// <param name="i_flags">Optional parameters to pass through to the effects.</param>
		/// <returns></returns>
		public static async Task UseMove(Battle battle, BattleState state, u8 slotUser, BattleMoveID moveID, u8 moveSlot, u32 slotsTarget, u8 index, u16 i_flags = 0) {
			BattleMon attacker = battle.GetMonInSlot(state, slotUser), defender;
			u8[] targets = Battle.SplitTargets(slotsTarget);

			if (
				// Check if the move can be used.
				moveID != BattleMoveID.STRUGGLE && !await attacker.CanUseMove(battle, state, moveSlot, true) ||
				// Other potential blockers.
				!await Battle.RunEventCheck(Callback.OnTryMove, battle, new OnTryMoveParams(battle, state, attacker, moveID)) ||
				!await Battle.RunEventCheck(Callback.OnTryMove, attacker, new OnTryMoveParams(battle, state, attacker, moveID))
			) {
				return;
			}

			u32 flags = 0;
			for (u8 i = 0; i < targets.Length; i++) {
				defender = battle.GetMonInSlot(state, targets[i]);

				if (!MoveHit(battle, state, attacker, defender, moveID)) {
					await MessageBox(GetString(STRINGS, BATTLE_COMMON.MON_USED_MOVE, attacker.GetName(), GetMoveName(moveID)));
					await MessageBox(GetString(STRINGS, BATTLE_COMMON.MON_AVOIDED_ATTACK, defender.GetName()));
					DecreaseMovePP(attacker, moveSlot);
					continue;
				}

				flags = await DoMove(battle, state, attacker, defender, moveID, slotUser, targets[i], (u8)targets.Length, index, true, i_flags);
				if ((flags & FLAG_DO_NOT_CONSUME_PP) == 0) {
					DecreaseMovePP(attacker, moveSlot);
				}
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
		/// <param name="i_flags">Optional parameters to pass through to the effects.</param>
		/// <returns>Move effect flags.</returns>
		public static async Task<u32> DoMove(Battle battle, BattleState state, BattleMon attacker, BattleMon defender, BattleMoveID moveID, u8 slotUser, u8 slotTarget, u8 numTargets, u8 index, bool print = true, u16 i_flags = 0) {
			if (print) {
				await MessageBox(GetString(STRINGS, GetContextString(BATTLE_COMMON.MON_USED_MOVE, attacker), attacker.GetName(), GetMoveName(moveID)));
			}

			// If the move is ineffective and the move does not ignore the type chart, then stop here.
			if (MonIsImmune(state, defender, moveID)) {
				await MessageBox(GetString(STRINGS, BATTLE_COMMON.MON_IS_NOT_AFFECTED, defender.GetName()));
				// Do Contact events.
				if ((gBattleMoves(moveID).flags & BattleMoves.Flag.MAKES_CONTACT) != 0) {
					//TODO: OnContactMade(state, attacker, defender);
				}
				return FLAG_MOVE_FAILED;
			}

			// Check for protect.
			if ((gBattleMoves(moveID).flags & BattleMoves.Flag.PROTECT_AFFECTED) != 0 && defender.HasStatus(Status.PROTECTION)) {
				await MessageBox(GetString(STRINGS, BATTLE_COMMON.MON_PROTECTED_ITSELF, defender.GetName()));
				// Do contact events.
				if ((gBattleMoves(moveID).flags & BattleMoves.Flag.MAKES_CONTACT) != 0) {
			//		// TODO: OnContactMade(state, attacker, defender);
				}
				return FLAG_MOVE_FAILED;
			}

			// Mons with Good as Gold as their ability are not affected by status moves
			if (gBattleMoves(moveID).moveCat == MoveCategory.STATUS && defender.AbilityProc(Ability.GOOD_AS_GOLD, true)) {
				return FLAG_MOVE_FAILED;
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
				i_flags
			);
			u32 flags = await gMoveEffectMap(gBattleMoves(moveID).primaryEffect)(data);

			// Record the slot of the user as the last mon that attacked the target.
			defender.SetStatusParam(StatusParam.LAST_MON_HIT_BY, slotUser);
			defender.SetStatusParam(StatusParam.LAST_MOVE_HIT_BY, (u16)moveID);
			
			if ((flags & FLAG_MOVE_FAILED) != 0) {
				await MessageBox(GetString(STRINGS, BATTLE_COMMON.MOVE_FAILED));
				attacker.SetStatusParam(StatusParam.SUCCESSIVE_MOVE_USES, 0);
				return flags;
			}

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
		/// Determines if a mon is immune to a given move.
		/// </summary>
		/// <param name="defender">Mon being attacked.</param>
		/// <param name="moveID">ID of the move being used.</param>
		/// <returns>True if the defender is immune to the move.</returns>
		private static bool MonIsImmune(BattleState state, BattleMon defender, BattleMoveID moveID) {
			// All mons are vulnerable to status moves.
			if (gBattleMoves(moveID).moveCat == MoveCategory.STATUS) {
				return false;
			}

			// This is really only used for Thousand Arrows.
			if ((gBattleMoves(moveID).flags & BattleMoves.Flag.HITS_UNGROUNDED) != 0 && !defender.IsGrounded(state)) {
				return false;
			}

			// Type effectiveness check
			if (Abs(TypeEffectiveness(defender, moveID) - EFF_IMMUNE) < 1e-10 && (gBattleMoves(moveID).flags & BattleMoves.Flag.IGNORE_TYPE_EFF) == 0) {
				return true;
			}

			return false;
		}

		/// <summary>
		/// Reduces the PP of a mon's move by 1.
		/// </summary>
		/// <param name="user">The BattleMon whose PP to decrease.</param>
		/// <param name="moveSlot">The slot of the move to decrease.</param>
		private static void DecreaseMovePP(BattleMon user, u8 moveSlot) {
			user.pp[moveSlot] -= 1;
		}

		/// <summary>
		/// Determines if a mon's move hits its target.
		/// </summary>
		/// <param name="battle">The current Battle.</param>
		/// <param name="state">The current BattleState.</param>
		/// <param name="attacker">Attacking BattleMon.</param>
		/// <param name="defender">Defending BattleMon.</param>
		/// <param name="moveID">ID of the move being used.</param>
		/// <returns>True if the move hits.</returns>
		public static bool MoveHit(Battle battle, BattleState state, BattleMon attacker, BattleMon defender, BattleMoveID moveID) {
			BattleMove move = gBattleMoves(moveID);

			// The startup of 2-turn moves like Fly or Solar Beam cannot miss, so deal with that here.
			if ((move.flags & Flag.SEMI_INVUL_TURN) != 0 && !attacker.HasStatus(Status.SEMI_INVULNERABLE_TURN)) {
				return true;
			}
			if ((move.flags & Flag.CHARGING_TURN) != 0 && !attacker.HasStatus(Status.CHARGING_TURN)) {
				return true;
			}

			// Psychic terrain prevents Pokémon on the ground from being hit by moves with increased priority.
			if (defender.IsGrounded(state) && (state.Terrain.Condition == Condition.TERRAIN_PSYCHIC) && move.priority > 0) {
				return false;
			}

			if (defender.HasStatus(Status.SEMI_INVULNERABLE_TURN)) {
				switch (defender.GetStatusParam(StatusParam.SEMI_INVULNERABLE)) {
					case StatusEffects.SEMI_INVULNERABLE_AIR:		if ((move.flags & Flag.HITS_SEMI_INVUL_AIR) == 0)		{return false;} break;
					case StatusEffects.SEMI_INVULNERABLE_GROUND:	if ((move.flags & Flag.HITS_SEMI_INVUL_GROUND) == 0)	{return false;} break;
					case StatusEffects.SEMI_INVULNERABLE_WATER:		if ((move.flags & Flag.HITS_SEMI_INVUL_WATER) == 0)		{return false;} break;
					case StatusEffects.SEMI_INVULNERABLE_PHANTOM:	if ((move.flags & Flag.HITS_SEMI_INVUL_PHANTOM) == 0)	{return false;} break;
					default:
						break;
				}
			}

			if ((move.flags & Flag.ALWAYS_HIT) != 0) {
				return true;
			}
			if ((move.flags & Flag.ALWAYS_HIT_RAIN) != 0 && 
				(state.Weather.Condition == Condition.WEATHER_RAIN)
			) {
				return true;
			}
			if ((move.flags & Flag.ALWAYS_HIT_HAIL) != 0 && 
				(state.Weather.Condition == Condition.WEATHER_HAIL || state.Weather.Condition == Condition.WEATHER_SNOW)
			) {
				return true;
			}

			if (attacker.HasStatus(Status.TAKING_AIM)) {
				return true;
			}


			float roll = battle.Random01();
			roll *= Battle.RunEventChain(Callback.OnFieldModifyAcc, battle, null).Result;

			float hitChance = DamageCalc.CalculateHitChance(state, attacker, defender, moveID);
			bool hit = roll <= hitChance;

			return hit;
		}
		/// <summary>
		/// Determines if a move's secondary effect will hit.
		/// </summary>
		/// <param name="battle"></param>
		/// <param name="hitChance">The chance for the effect to hit.</param>
		/// <returns>True if the effect hits, false if it doesn't.</returns>
		private static bool EffectHit(Battle battle, u8 hitChance) {
			return (battle.Random01() * 100) <= hitChance;
		}

		/// @brief Gets the default target(s) for a given move.
		/// @param moveID ID of the move.
		/// @param side Side of the mon using the move. SIDE_PLAYER or SIDE_OPPONENT.
		/// @return The encoded slot(s) of the default target(s).
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
						case MOVE_TARGET_USER_FIELD_AND_PARTY:
							targetSlots = 0b_1111_1111_1111_1111_1111_1111_1111_0000;
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
							targetSlots = 0b_1111_1111_1111_1111_1111_1111_1111_0001;
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
						case MOVE_TARGET_USER_FIELD_AND_PARTY:
							targetSlots = 0b_1111_1111_1111_1111_1111_1111_1111_0001;
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
							targetSlots = 0b_1111_1111_1111_1111_1111_1111_1111_0000;
							break;
					}
					break;
				}
			}
			
			return targetSlots;
		}

		/// <summary>
		/// Determines if a mon can choose its own action.
		/// </summary>
		/// <param name="bm">The BattleMon to check.</param>
		/// <param name="slot">The slot on the field that it's in.</param>
		/// <returns>Either the code that states it can choose its action, or a forced action if not.</returns>
		public static u64 MonCanAct(BattleMon bm, u8 slot) {
			// Recharging mons do not get to act.
			if (bm.HasStatus(Status.RECHARGING)) {
				bm.RemoveStatus(Status.RECHARGING);
				return BattleActionCodes.BATTLE_ACTION(ActionCode.RECHARGING, slot, 0, 0);
			}

			// Mons in a semi-invunerable or charging turn do not get to choose an action.
			if (
				bm.HasStatus(Status.SEMI_INVULNERABLE_TURN, Status.CHARGING_TURN) && 
				((gBattleMoves(bm.moves[bm.GetStatusParam(StatusParam.LAST_USED_MOVE)]).flags & (BattleMoves.Flag.SEMI_INVUL_TURN | BattleMoves.Flag.CHARGING_TURN)) != 0)
			) {
				return BattleActionCodes.BATTLE_ACTION_USE_MOVE(slot, (u8)bm.GetStatusParam(StatusParam.LAST_USED_MOVE), bm.moves[bm.GetStatusParam(StatusParam.LAST_USED_MOVE)], (u32)bm.GetStatusParam(StatusParam.LAST_TARGETED_MON));
			}

			return BattleActionCodes.ACTION_CHOOSE;
		}
	}
}