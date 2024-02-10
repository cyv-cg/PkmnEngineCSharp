using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;

namespace PkmnEngine {
	public struct OnSourceModifyCritRatioParams {
		public OnSourceModifyCritRatioParams(BattleMon bm) {
		}
	}
	
	internal static partial class BattleEvents {
		public static object Ability_BattleArmor_OnSourceModifyCritRatio(object p) {
			OnSourceModifyCritRatioParams cbParams = ValidateParams<OnSourceModifyCritRatioParams>(p);

			return -100;
		}
	}
}