using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace PkmnEngine {
	public struct OnModifyDefParams {
		public OnModifyDefParams(BattleMon bm) {
			this.bm = bm;
		}
		public BattleMon bm;
	}

	internal static partial class BattleEvents {
		public static object Weather_Snow_OnModifyDef(object p) {
			OnModifyDefParams args = ValidateParams<OnModifyDefParams>(p);

			if (args.bm.HasType(Type.ICE)) {
				return 1.5f;
			}
			return 1f;
		}
	}
}