using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

using static PkmnEngine.Global;
using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnNextTurnParams {
		public OnNextTurnParams(BattleState state, BattleMon bm) {
			this.state = state;
			this.bm = bm;
		}
		public BattleState state;
		public BattleMon bm;
	}
	
	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Status_Drowsy_OnNextTurn(object p) {
			OnNextTurnParams args = ValidateParams<OnNextTurnParams>(p);
			// The turn after a mon is inflicted with drowsy, it falls asleep.
			args.bm.RemoveStatus(Status.DROWSY);
			await MoveEffects.SleepMon(args.state, args.bm, StatusEffects.GetRandSleepTurns());
			return null;
		}
		public static async Task<object> Status_TakingAim_OnNextTurn(object p) {
			OnNextTurnParams args = ValidateParams<OnNextTurnParams>(p);
			args.bm.RemoveStatus(Status.TAKING_AIM);
			return null;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}