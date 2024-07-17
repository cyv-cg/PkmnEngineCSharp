using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

using static PkmnEngine.Global;
using static PkmnEngine.BattleMoves;
using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnTrySelectMoveParams {
		public OnTrySelectMoveParams(Battle battle, BattleState state, BattleMon bm, BattleMoveID moveID, u8 moveSlot, bool print) {
			this.battle = battle;
			this.state = state;
			this.bm = bm;
			this.MoveID = moveID;
			this.moveSlot = moveSlot;
			this.print = print;
		}
		public Battle battle;
		public BattleState state;
		public BattleMon bm;
		public BattleMoveID MoveID;
		public u8 moveSlot;
		public bool print;
	}
	
	internal static partial class BattleEvents {
		public static async Task<object> Status_ThroatChop_OnTryUseMove(object p) {
			OnTrySelectMoveParams args = ValidateParams<OnTrySelectMoveParams>(p);

			BattleMove move = gBattleMoves(args.MoveID);
			if ((move.flags & Flag.SOUND_MOVE) != 0) {
				if (args.print) {
					await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.THROAT_CHOP_PREVENTS_MON_FROM_USING_CERTAIN_MOVES, args.bm.GetName()));
				}
				return false;
			}

			return true;
		}
		public static async Task<object> Status_Taunt_OnTryUseMove(object p) {
			OnTrySelectMoveParams args = ValidateParams<OnTrySelectMoveParams>(p);

			BattleMove move = gBattleMoves(args.MoveID);
			if (move.moveCat == MoveCategory.STATUS) {
				if (args.print) {
					await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.MON_CANNOT_USE_MOVE_AFTER_THE_TAUNT, args.bm.GetName(), Lang.GetMoveName(args.MoveID)));
				}
				return false;
			}

			return true;
		}
		public static async Task<object> Status_Encore_OnTryUseMove(object p) {
			OnTrySelectMoveParams args = ValidateParams<OnTrySelectMoveParams>(p);

			BattleMove move = gBattleMoves(args.MoveID);
			if (args.MoveID != args.bm.moves[args.bm.GetStatusParam(StatusParam.ENCORE)]) {
				if (args.print) {
					await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.MON_MUST_DO_AN_ENCORE, args.bm.GetName()));
				}
				return false;
			}

			return true;
		}
		public static async Task<object> Status_Disable_OnTryUseMove(object p) {
			OnTrySelectMoveParams args = ValidateParams<OnTrySelectMoveParams>(p);

			if (args.bm.HasStatus(Status.DISABLE) && args.bm.GetStatusParam(StatusParam.DISABLED_SLOT) == args.moveSlot) {
				if (args.print) {
					await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.MONS_MOVE_WAS_DISABLED, args.bm.GetName(), Lang.GetMoveName(args.MoveID)));
				}
				return false;
			}

			return true;
		}
		public static async Task<object> Status_Torment_OnTryUseMove(object p) {
			OnTrySelectMoveParams args = ValidateParams<OnTrySelectMoveParams>(p);

			// Tormented mons cannot use the same move twice in a row.
			if (args.bm.HasStatus(Status.TORMENT) && args.bm.GetStatusParam(StatusParam.LAST_USED_MOVE) == args.moveSlot) {
				if (args.print) {
					await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.MON_CANNOT_USE_THE_SAME_MOVE_TWICE_DUE_TO_TORMENT, args.bm.GetName()));
				}
				return false;
			}

			return true;
		}
		public static async Task<object> Status_Imprison_OnTryUseMove(object p) {
			OnTrySelectMoveParams args = ValidateParams<OnTrySelectMoveParams>(p);

			// Imprison
			// Technically, this should only run if the mon that inflicted the Imprisoned status is active.
			if (args.bm.HasStatus(Status.IMPRISON)) {
				foreach (BattleMon bm in args.battle.GetAllActiveMons()) {
					if (bm.Side == args.bm.Side) {
						continue;
					}

					for (u8 i = 0; i < Pokemon.MAX_MOVES; i++) {
						if (args.bm.KnowsMove(bm.moves[i])) {
							if (args.print) {
								await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.MON_CANNOT_USE_SEALED_MOVE, args.bm.GetName(), Lang.GetMoveName(args.bm.moves[args.moveSlot])));
							}
							return false;
						}
					}
				}
			}

			return true;
		}
	}
}