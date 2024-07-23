using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

using static PkmnEngine.Global;
using static PkmnEngine.BattleMoves;
using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnTrySwitchOutParams {
		public OnTrySwitchOutParams(Battle battle, BattleState state, BattleMon bm, bool print) {
			this.battle = battle;
			this.state = state;
			this.bm = bm;
			this.print = print;
		}
		public Battle battle;
		public BattleState state;
		public BattleMon bm;
		public bool print;
	}
	
	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Status_Bound_OnTrySwitchOut(object p) {
			OnTrySwitchOutParams args = ValidateParams<OnTrySwitchOutParams>(p);

			// Ghost type pokemon can still switch out with the bounded status.
			if (args.bm.HasType(Type.GHOST)) {
				return true;
			}

			if (args.print) {
				await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_CANT_ESCAPE, args.bm), args.bm.GetName()));
			}
			return false;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}