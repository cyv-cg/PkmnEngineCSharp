using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

using static PkmnEngine.Global;
using static PkmnEngine.BattleMoves;

using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnTryMoveParams {
		public OnTryMoveParams(Battle battle, BattleState state, BattleMon bm, BattleMoveID moveID) {
			this.battle = battle;
			this.state = state;
			this.bm = bm;
			this.moveID = moveID;
		}
		public Battle battle;
		public BattleState state;
		public BattleMon bm;
		public BattleMoveID moveID;
	}
	
	internal static partial class BattleEvents {
		public static async Task<object> Status_Paralysis_OnTryMove(object p) {
			OnTryMoveParams args = ValidateParams<OnTryMoveParams>(p);

			// Paralyzed mons have a chance to not be able to move.
			if (args.battle.rand.NextDouble() < StatusEffects.PARALYSIS_PROC_CHANCE) {
				StringResource contextString = BattleUtils.GetContextString(BATTLE_COMMON.MON_IS_PARALYZED_AND_CANT_MOVE, args.bm);
				await MessageBox(Lang.GetString(STRINGS, contextString, args.bm.GetName()));
				return false;
			}

			return true;
		}
		public static async Task<object> Status_Freeze_OnTryMove(object p) {
			OnTryMoveParams args = ValidateParams<OnTryMoveParams>(p);

			// Frozen mons cannot move.
			if ((gBattleMoves(args.moveID).flags & Flag.THAWS_USER) == 0) {
				// A frozen mon has a set chance of thawing out every turn.
				if (args.battle.Random01() < StatusEffects.FREEZE_THAW_CHANCE) {
					await MoveEffects.ThawMon(args.bm);
				}
				else {
					StringResource contextString = BattleUtils.GetContextString(BATTLE_COMMON.MON_IS_FROZEN_SOLID, args.bm);
					await MessageBox(Lang.GetString(STRINGS, contextString, args.bm.GetName()));
					return false;
				}
			}

			return true;
		}
		public static async Task<object> Status_Sleep_OnTryMove(object p) {
			OnTryMoveParams args = ValidateParams<OnTryMoveParams>(p);

			// Sleeping mons can only use certain moves.
			u8 sleepingTurns = (u8)args.bm.GetStatusParam(StatusParam.SLEEPING_TURNS);
			args.bm.IncrementStatusParam(StatusParam.SLEEPING_TURNS);
			// Sleeping mons will wake up after a certain number of turns.
			if (sleepingTurns >= args.bm.GetStatusParam(StatusParam.NV_STATUS_DURATION)) {
				await MoveEffects.WakeUpMon(args.bm);
			}
			else {
				StringResource contextString = BattleUtils.GetContextString(BATTLE_COMMON.MON_IS_FAST_ASLEEP, args.bm);
				// Display that the mon is sleeping.
				await MessageBox(Lang.GetString(STRINGS, contextString, args.bm.GetName()));
				// If the mon cannot use this move while asleep, exit.
				if ((gBattleMoves(args.moveID).flags & Flag.USABLE_WHILE_ASLEEP) == 0) {
					return false;
				}
			}

			return true;
		}
		public static async Task<object> Status_Confusion_OnTryMove(object p) {
			OnTryMoveParams args = ValidateParams<OnTryMoveParams>(p);

			// Confused mons have a chance to hurt themselves instead of acting
			StringResource contextString = BattleUtils.GetContextString(BATTLE_COMMON.MON_IS_CONFUSED, args.bm);
			await MessageBox(Lang.GetString(STRINGS, contextString, args.bm.GetName()));
			u8 confusedTurns = (u8)args.bm.GetStatusParam(StatusParam.CONFUSED_TURNS);
			args.bm.IncrementStatusParam(StatusParam.CONFUSED_TURNS);
			// Mons will remain confused for up to 4 turns and have a 25% chance to snap out every turn.
			if ((confusedTurns >= 4) || (args.battle.rand.NextDouble() < 0.25)) {
				contextString = BattleUtils.GetContextString(BATTLE_COMMON.MON_SNAPPED_OUT_OF_CONFUSION, args.bm);
				await MessageBox(Lang.GetString(STRINGS, contextString, args.bm.GetName()));
				args.bm.SetStatusParam(StatusParam.CONFUSED_TURNS, 0);
				args.bm.RemoveStatus(Status.CONFUSION);
			}
			// Confused mons have a 33% chance to hurt themselves instead of using their move.
			else if (args.battle.Random01() < 0.33f) {
				// Confusion acts as a physical move with 40 power and no type.
				// This same effect can be achieved by using tackle and overriding the type effectiveness and power :p
				U16 damage = new(DamageCalc.CalcDamage(args.battle, args.state, args.bm, args.bm, BattleMoveID.TACKLE, 1, new DamageCalc.Mods(), new DamageCalc.Overrides(0, 0, 40, 0)));
				await args.bm.DamageMon(damage, false, true, Lang.GetString(STRINGS, BATTLE_COMMON.IT_HURT_ITSELF_IN_CONFUSION));
				return false;
			}

			return true;
		}

		public static async Task<object> Weather_ExtremeSunlight_OnTryMove(object p) {
			OnTryMoveParams args = ValidateParams<OnTryMoveParams>(p);

			BattleMove move = gBattleMoves(args.moveID);

			if (move.moveType == Type.WATER && move.moveCat != MoveCategory.STATUS) {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.WATER_ATTACK_EVAPORATED));
				return false;
			}

			return true;
		}
		public static async Task<object> Weather_HeavyRain_OnTryMove(object p) {
			OnTryMoveParams args = ValidateParams<OnTryMoveParams>(p);

			BattleMove move = gBattleMoves(args.moveID);

			if (move.moveType == Type.FIRE && move.moveCat != MoveCategory.STATUS) {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.FIRE_ATTACK_FIZZLED_OUT));
				return false;
			}

			return true;
		}
	}
}