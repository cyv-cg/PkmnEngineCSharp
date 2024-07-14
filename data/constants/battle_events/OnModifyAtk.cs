using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;
using System.Threading.Tasks;

namespace PkmnEngine {
	public struct OnModifyAtkParams {
		public OnModifyAtkParams(BattleMon bm) {
			this.bm = bm;
		}
		public BattleMon bm;
	}
	
	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Ability_Guts_OnModifyAtk(object p) {
			OnModifyAtkParams args = ValidateParams<OnModifyAtkParams>(p);

			if (args.bm.HasStatus(StatusEffects.STATUS_MASK_NON_VOLATILE)) {
				return 1.5f;
			}
			return 1.0f;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}