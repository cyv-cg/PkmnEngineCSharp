using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.BattleMoves;
using PkmnEngine.Strings;
using System.Threading.Tasks;

namespace PkmnEngine {
	public struct OnTryAddNonVolatileParams {
		public OnTryAddNonVolatileParams(BattleState state, BattleMon bm, Status status) {
			this.state = state;
			this.bm = bm;
			this.status = status;
		}
		public BattleState state;
		public BattleMon bm;
		public Status status;
	}
	
	internal static partial class BattleEvents {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<object> Ability_LeafGuard_OnTryAddNonVolatile(object p) {
			OnTryAddNonVolatileParams args = ValidateParams<OnTryAddNonVolatileParams>(p);

			if (args.state.Weather.Condition == Condition.WEATHER_HARSH_SUNLIGHT || args.state.Weather.Condition == Condition.WEATHER_EXTREME_SUNLIGHT) {
				return false;
			}

			return true;
		}
		public static async Task<object> Ability_Immunity_OnTryAddNonVolatile(object p) {
			OnTryAddNonVolatileParams args = ValidateParams<OnTryAddNonVolatileParams>(p);

			if (args.status == Status.POISON || args.status == Status.TOXIC) {
				return false;
			}

			return true;
		}
		public static async Task<object> Ability_Comatose_OnTryAddNonVolatile(object p) {
			OnTryAddNonVolatileParams args = ValidateParams<OnTryAddNonVolatileParams>(p);
			return false;
		}
		public static async Task<object> Ability_Insomnia_OnTryAddNonVolatile(object p) {
			OnTryAddNonVolatileParams args = ValidateParams<OnTryAddNonVolatileParams>(p);
			
			if (args.status == Status.SLEEP || args.status == Status.DROWSY) {
				return false;
			}

			return true;
		}

		public static async Task<object> Terrain_Electric_OnTryAddNonVolatile(object p) {
			OnTryAddNonVolatileParams args = ValidateParams<OnTryAddNonVolatileParams>(p);

			if (args.bm.IsGrounded(args.state) && (args.status == Status.SLEEP || args.status == Status.DROWSY)) {
				return false;
			}

			return true;
		}
		public static async Task<object> Terrain_Misty_OnTryAddNonVolatile(object p) {
			OnTryAddNonVolatileParams args = ValidateParams<OnTryAddNonVolatileParams>(p);
			return !args.bm.IsGrounded(args.state);
		}
		
		public static async Task<object> Condition_Safeguard_OnTryAddNonVolatile(object p) {
			OnTryAddNonVolatileParams args = ValidateParams<OnTryAddNonVolatileParams>(p);

			if (args.state.SideHasCondition(args.bm.Side, Condition.SAFEGUARD)) {
				return false;
			}

			return true;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}