using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;
using System;

namespace PkmnEngine {
	public struct OnCheckIsUngroundedParams {
		public OnCheckIsUngroundedParams(BattleMon bm) {
			this.bm = bm;
		}
		public BattleMon bm;
	}
	
	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Ability_Levitate_OnCheckIsUngrounded(object p) {
			OnCheckIsUngroundedParams args = ValidateParams<OnCheckIsUngroundedParams>(p);
			return true;
		}

		public static async Task<object> Item_AirBalloon_OnCheckIsUngrounded(object p) {
			OnCheckIsUngroundedParams args = ValidateParams<OnCheckIsUngroundedParams>(p);
			return true;
		}

		public static async Task<object> Status_MagneticLevitation_OnCheckIsUngrounded(object p) {
			OnCheckIsUngroundedParams args = ValidateParams<OnCheckIsUngroundedParams>(p);
			return true;
		}
		public static async Task<object> Status_Telekinesis_OnCheckIsUngrounded(object p) {
			OnCheckIsUngroundedParams args = ValidateParams<OnCheckIsUngroundedParams>(p);
			return true;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}