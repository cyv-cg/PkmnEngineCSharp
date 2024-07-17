using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.BattleMoves;
using PkmnEngine.Strings;
using System.Threading.Tasks;

namespace PkmnEngine {
	public struct OnTryChangeStatParams {
		public OnTryChangeStatParams(BattleState state, BattleMon bm, sbyte delta) {
			this.state = state;
			this.bm = bm;
			this.delta = delta;
		}
		public BattleState state;
		public BattleMon bm;
		public sbyte delta;
	}
	
	internal static partial class BattleEvents {
		public static async Task<object> Condition_Mist_OnTryChangeStat(object p) {
			OnTryChangeStatParams args = ValidateParams<OnTryChangeStatParams>(p);

			if (args.state.SideHasCondition(args.bm.Side, Condition.MIST) && args.delta < 0) {
				await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_IS_PROTECTED_BY_THE_MIST, args.bm), args.bm.GetName()));
				return false;
			}

			return true;
		}
	}
}