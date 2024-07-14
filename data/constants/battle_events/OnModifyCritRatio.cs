using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using System.Threading.Tasks;

namespace PkmnEngine {
	public struct OnModifyCritRatioParams {
		public OnModifyCritRatioParams(BattleMon bm) {
		}
	}
	
	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Ability_SuperLuck_OnModifyCritRatio(object p) {
			OnModifyCritRatioParams args = ValidateParams<OnModifyCritRatioParams>(p);

			return 1;
		}

		public static async Task<object> Status_LaserFocus_OnModifyCritRatio(object p) {
			OnModifyCritRatioParams args = ValidateParams<OnModifyCritRatioParams>(p);

			return MAX_STAT_STAGE;
		}
		public static async Task<object> Status_GettingPumped_OnModifyCritRatio(object p) {
			OnModifyCritRatioParams args = ValidateParams<OnModifyCritRatioParams>(p);

			return 1;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}