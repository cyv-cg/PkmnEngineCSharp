using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;
using System;

namespace PkmnEngine {
	public struct OnContactMadeParams {
		public OnContactMadeParams(BattleState state, BattleMon attacker, BattleMon target) {
			this.state = state;
			this.attacker = attacker;
			this.target = target;
		}
		public BattleState state;
		public BattleMon attacker;
		public BattleMon target;
	}
	
	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}