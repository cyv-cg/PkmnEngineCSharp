using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnEndParams {
		public OnEndParams(BattleState state, BattleMon bm) {
			this.state = state;
			this.bm = bm;
		}
		public BattleState state;
		public BattleMon bm;
	}
	
	internal static partial class BattleEvents {
		public static object Status_PerishSong_OnEnd(object p) {
			OnEndParams cbParams = ValidateParams<OnEndParams>(p);

			u8 count = (u8)cbParams.bm.GetStatusParam(StatusParam.PERISH_COUNT);
			MessageBox(Lang.GetBattleMessage(BattleMessage.MONS_PERISH_COUNT_FELL_TO_N, cbParams.bm.GetName(), count.ToString()));
			if (count == 0) {
				u16 damage = cbParams.bm.EffMaxHp(cbParams.state);
				cbParams.bm.DamageMon(ref damage, true, false);
				return null;
			}
			cbParams.bm.DecrementStatusParam(StatusParam.PERISH_COUNT);
			return null;
		}
		public static object Status_LaserFocus_OnEnd(object p) {
			OnEndParams cbParams = ValidateParams<OnEndParams>(p);

			if (cbParams.bm.GetStatusParam(StatusParam.LASER_FOCUS) == 0) {
				cbParams.bm.RemoveStatus(Status.LASER_FOCUS);
			}
			cbParams.bm.DecrementStatusParam(StatusParam.LASER_FOCUS);

			return null;
		}
	}
}