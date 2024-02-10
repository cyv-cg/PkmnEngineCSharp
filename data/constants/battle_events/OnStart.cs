using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace PkmnEngine {
	public struct OnStartParams {
		public OnStartParams(BattleState state, BattleMon bm) {
			this.state = state;
			this.bm = bm;
		}
		public BattleState state;
		public BattleMon bm;
	}
	
	internal static partial class BattleEvents {
	}
}