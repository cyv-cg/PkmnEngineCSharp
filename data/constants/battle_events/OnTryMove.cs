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
		public OnTryMoveParams(BattleState state, BattleMon bm, BattleMoveID moveID) {
			this.state = state;
			this.bm = bm;
			this.moveID = moveID;
		}
		public BattleState state;
		public BattleMon bm;
		public BattleMoveID moveID;
	}
	
	internal static partial class BattleEvents {
		public static async Task<object> Weather_ExtremeSunlight_OnTryMove(object p) {
			OnTryMoveParams args = ValidateParams<OnTryMoveParams>(p);

			BattleMove move = gBattleMoves(args.moveID);

			if (move.moveType == Type.WATER && move.moveCat != MoveCategory.STATUS) {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.WATER_ATTACK_EVAPORATED));
				return false;
			}

			return true;
		}
		public static async Task<object> Weather_HeavyRain_OnTryMove(object p) {
			OnTryMoveParams args = ValidateParams<OnTryMoveParams>(p);

			BattleMove move = gBattleMoves(args.moveID);

			if (move.moveType == Type.FIRE && move.moveCat != MoveCategory.STATUS) {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.FIRE_ATTACK_FIZZLED_OUT));
				return false;
			}

			return true;
		}
	}
}