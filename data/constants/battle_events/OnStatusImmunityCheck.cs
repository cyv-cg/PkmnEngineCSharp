using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace PkmnEngine {
	public struct OnStatusImmunityCheckParams {
		public OnStatusImmunityCheckParams(BattleMon bm, Status status) {
			this.bm = bm;
			this.status = status;
		}
		public BattleMon bm;
		public Status status;
	}
	
	internal static partial class BattleEvents {
		public static object Weather_HarshSunlight_OnStatusImmunityCheck(object p) {
			OnStatusImmunityCheckParams cbParams = ValidateParams<OnStatusImmunityCheckParams>(p);

			if (cbParams.status == Status.FREEZE) {
				return false;
			}

			return true;
		}
	}
}