using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;
using System.Threading.Tasks;

namespace PkmnEngine {
	public struct OnModifySpDefParams {
		public OnModifySpDefParams(BattleMon bm) {
			this.bm = bm;
		}
		public BattleMon bm;
	}

	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Weather_Sandstorm_OnModifySpDef(object p) {
			OnModifySpDefParams args = ValidateParams<OnModifySpDefParams>(p);

			if (args.bm.HasType(Type.ROCK)) {
				return 1.5f;
			}

			return 1f;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}