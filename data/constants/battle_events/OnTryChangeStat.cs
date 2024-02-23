using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.BattleMoves;
using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnTryChangeStatParams {
		public OnTryChangeStatParams(BattleState state, BattleMon bm, sbyte delta) {
			this.state = state;
			this.bm = bm;
			this.delta = delta;
		}
		public BattleState state;
		public BattleMon bm;
		public sbyte delta;
	}
	
	internal static partial class BattleEvents {
		public static object Condition_Mist_OnTryChangeStat(object p) {
			OnTryChangeStatParams cbParams = ValidateParams<OnTryChangeStatParams>(p);

			if (cbParams.state.SideHasCondition(cbParams.bm.Side, Condition.MIST) && cbParams.delta < 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.MON_IS_PROTECTED_BY_THE_MIST, cbParams.bm.GetName()));
				return false;
			}

			return true;
		}
	}
}