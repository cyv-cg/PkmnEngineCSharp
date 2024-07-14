using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;
using System.Threading.Tasks;

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
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Weather_HarshSunlight_OnStatusImmunityCheck(object p) {
			OnStatusImmunityCheckParams args = ValidateParams<OnStatusImmunityCheckParams>(p);

			if (args.status == Status.FREEZE) {
				return false;
			}

			return true;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}