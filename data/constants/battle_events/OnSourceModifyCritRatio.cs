using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using System.Threading.Tasks;

namespace PkmnEngine {
	public struct OnSourceModifyCritRatioParams {
		public OnSourceModifyCritRatioParams(BattleMon bm) {
		}
	}
	
	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Ability_BattleArmor_OnSourceModifyCritRatio(object p) {
			OnSourceModifyCritRatioParams args = ValidateParams<OnSourceModifyCritRatioParams>(p);

			return -100;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}