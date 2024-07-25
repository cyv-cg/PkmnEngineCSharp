using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;
using System;

namespace PkmnEngine {
	public struct OnTryHealParams {
		public OnTryHealParams(BattleMon bm, U16 amount, bool force) {
			this.bm = bm;
			this.amount = amount;
			this.force = force;
		}
		public BattleMon bm;
		public U16 amount;
		public bool force;
	}
	
	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Status_HealBlock_OnTryHeal(object p) {
			return false;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}