using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace PkmnEngine {
	public struct OnModifyAtkParams {
		public OnModifyAtkParams(BattleMon bm) {
			this.bm = bm;
		}
		public BattleMon bm;
	}
	
	internal static partial class BattleEvents {
		public static object Ability_Guts_OnModifyAtk(object p) {
			OnModifyAtkParams cbParams = ValidateParams<OnModifyAtkParams>(p);

			if (cbParams.bm.HasStatus(StatusEffects.STATUS_MASK_NON_VOLATILE)) {
				return 1.5f;
			}
			return 1.0f;
		}
	}
}