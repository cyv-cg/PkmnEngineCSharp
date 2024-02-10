using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;

namespace PkmnEngine {
	public struct OnModifyCritRatioParams {
		public OnModifyCritRatioParams(BattleMon bm) {
		}
	}
	
	internal static partial class BattleEvents {
		public static object Ability_SuperLuck_OnModifyCritRatio(object p) {
			OnModifyCritRatioParams cbParams = ValidateParams<OnModifyCritRatioParams>(p);

			return 1;
		}

		public static object Status_LaserFocus_OnModifyCritRatio(object p) {
			OnModifyCritRatioParams cbParams = ValidateParams<OnModifyCritRatioParams>(p);

			return MAX_STAT_STAGE;
		}
		public static object Status_GettingPumped_OnModifyCritRatio(object p) {
			OnModifyCritRatioParams cbParams = ValidateParams<OnModifyCritRatioParams>(p);

			return 1;
		}
	}
}