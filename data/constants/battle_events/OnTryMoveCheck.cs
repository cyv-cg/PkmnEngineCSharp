using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.BattleMoves;

using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnTryMoveCheckParams {
		public OnTryMoveCheckParams(BattleState state, BattleMon bm, BattleMoveID moveID) {
			this.state = state;
			this.bm = bm;
			this.moveID = moveID;
		}
		public BattleState state;
		public BattleMon bm;
		public BattleMoveID moveID;
	}
	
	internal static partial class BattleEvents {
		public static object Weather_ExtremeSunlight_OnTryMoveCheck(object p) {
			OnTryMoveCheckParams cbParams = ValidateParams<OnTryMoveCheckParams>(p);

			BattleMove move = gBattleMoves(cbParams.moveID);

			if (move.moveType == Type.WATER && move.moveCat != MoveCategory.STATUS) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.WATER_ATTACK_EVAPORATED));
				return false;
			}

			return true;
		}
		public static object Weather_HeavyRain_OnTryMoveCheck(object p) {
			OnTryMoveCheckParams cbParams = ValidateParams<OnTryMoveCheckParams>(p);

			BattleMove move = gBattleMoves(cbParams.moveID);

			if (move.moveType == Type.FIRE && move.moveCat != MoveCategory.STATUS) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.FIRE_ATTACK_FIZZLED_OUT));
				return false;
			}

			return true;
		}
	}
}