using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;
using System;

namespace PkmnEngine {
	public struct OnCheckIsGroundedParams {
		public OnCheckIsGroundedParams(BattleMon bm) {
			this.bm = bm;
		}
		public BattleMon bm;
	}
	
	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Condition_Gravity_OnCheckIsGrounded(object p) {
			OnCheckIsGroundedParams args = ValidateParams<OnCheckIsGroundedParams>(p);
			return true;
		}

		public static async Task<object> Item_IronBall_OnCheckIsGrounded(object p) {
			OnCheckIsGroundedParams args = ValidateParams<OnCheckIsGroundedParams>(p);
			return true;
		}

		public static async Task<object> Status_Rooting_OnCheckIsGrounded(object p) {
			OnCheckIsGroundedParams args = ValidateParams<OnCheckIsGroundedParams>(p);
			return true;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}