using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;
using System;

namespace PkmnEngine {
	public struct OnCheckAsleepParams {
		public OnCheckAsleepParams(BattleMon bm) {
			this.bm = bm;
		}
		public BattleMon bm;
	}
	
	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Ability_Comatose_OnCheckAsleep(object p) {
			OnCheckAsleepParams args = ValidateParams<OnCheckAsleepParams>(p);
			return args.bm.ability == Ability.COMATOSE;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}