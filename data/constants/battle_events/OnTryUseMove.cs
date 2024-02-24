using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

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
		public static object Status_Disable_OnTryUseMove(object p) {
			OnTrySelectMoveParams cbParams = ValidateParams<OnTrySelectMoveParams>(p);

			if (cbParams.bm.HasStatus(Status.DISABLE) && cbParams.bm.GetStatusParam(StatusParam.DISABLED_SLOT) == cbParams.moveSlot) {
				if (cbParams.print) {
					MessageBox(Lang.GetBattleMessage(BattleMessage.MONS_MOVE_WAS_DISABLED, cbParams.bm.GetName(), Lang.GetMoveName(cbParams.MoveID)));
				}
				return false;
			}

			return true;
		}
		public static object Status_Torment_OnTryUseMove(object p) {
			OnTrySelectMoveParams cbParams = ValidateParams<OnTrySelectMoveParams>(p);

			// Tormented mons cannot use the same move twice in a row.
			if (cbParams.bm.HasStatus(Status.TORMENT) && cbParams.bm.GetStatusParam(StatusParam.LAST_USED_MOVE) == cbParams.moveSlot) {
				if (cbParams.print) {
					MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_USE_THE_SAME_MOVE_TWICE_DUE_TO_TORMENT, cbParams.bm.GetName()));
				}
				return false;
			}

			return true;
		}
		public static object Status_Imprison_OnTryUseMove(object p) {
			OnTrySelectMoveParams cbParams = ValidateParams<OnTrySelectMoveParams>(p);

			// Imprison
			if (cbParams.bm.HasStatus(Status.IMPRISON)) {
				foreach (BattleMon bm in cbParams.battle.GetAllActiveMons()) {
					if (bm.Side == cbParams.bm.Side) {
						continue;
					}

					for (u8 i = 0; i < Pokemon.MAX_MOVES; i++) {
						if (cbParams.bm.KnowsMove(bm.moves[i])) {
							if (cbParams.print) {
								MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANT_USE_SEALED_MOVE, cbParams.bm.GetName(), Lang.GetMoveName(cbParams.bm.moves[cbParams.moveSlot])));
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