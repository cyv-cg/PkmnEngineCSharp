using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace PkmnEngine {
	public struct OnModifySpDefParams {
		public OnModifySpDefParams(BattleMon bm) {
			this.bm = bm;
		}
		public BattleMon bm;
	}

	internal static partial class BattleEvents {
		public static object Weather_Sandstorm_OnModifySpDef(object p) {
			OnModifySpDefParams cbParams = ValidateParams<OnModifySpDefParams>(p);

			if (cbParams.bm.HasType(Type.ROCK)) {
				return 1.5f;
			}

			return 1f;
		}
	}
}