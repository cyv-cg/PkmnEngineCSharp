using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.BattleMoves;
using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnTrySelectMoveParams {
		public OnTrySelectMoveParams(BattleState state, BattleMon bm, BattleMoveID moveID, bool print) {
			this.state = state;
			this.bm = bm;
			this.MoveID = moveID;
			this.print = print;
		}
		public BattleState state;
		public BattleMon bm;
		public BattleMoveID MoveID;
		public bool print;
	}
	
	internal static partial class BattleEvents {
		public static object Status_ThroatChop_OnTryUseMove(object p) {
			OnTrySelectMoveParams cbParams = ValidateParams<OnTrySelectMoveParams>(p);

			BattleMove move = gBattleMoves(cbParams.MoveID);
			if ((move.flags & Flag.SOUND_MOVE) != 0) {
				if (cbParams.print) {
					MessageBox(Lang.GetBattleMessage(BattleMessage.THROAT_CHOP_PREVENTS_MON_FROM_USING_CERTAIN_MOVES, cbParams.bm.GetName()));
				}
				return false;
			}

			return true;
		}
		public static object Status_Taunt_OnTryUseMove(object p) {
			OnTrySelectMoveParams cbParams = ValidateParams<OnTrySelectMoveParams>(p);

			BattleMove move = gBattleMoves(cbParams.MoveID);
			if (move.moveCat == MoveCategory.STATUS) {
				if (cbParams.print) {
					MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_USE_MOVE_AFTER_THE_TAUNT, cbParams.bm.GetName(), Lang.GetMoveName(cbParams.MoveID)));
				}
				return false;
			}

			return true;
		}
		public static object Status_Encore_OnTryUseMove(object p) {
			OnTrySelectMoveParams cbParams = ValidateParams<OnTrySelectMoveParams>(p);

			BattleMove move = gBattleMoves(cbParams.MoveID);
			if (cbParams.MoveID != cbParams.bm.moves[cbParams.bm.GetStatusParam(StatusParam.ENCORE)]) {
				if (cbParams.print) {
					MessageBox(Lang.GetBattleMessage(BattleMessage.MON_MUST_DO_AN_ENCORE, cbParams.bm.GetName()));
				}
				return false;
			}

			return true;
		}
	}
}