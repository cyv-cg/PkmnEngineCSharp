using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.BattleMoves;
using PkmnEngine.Strings;

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
		public static object Ability_LeafGuard_OnTryAddNonVolatile(object p) {
			OnTryAddNonVolatileParams cbParams = ValidateParams<OnTryAddNonVolatileParams>(p);

			if (cbParams.state.Weather.Condition == Condition.WEATHER_HARSH_SUNLIGHT || cbParams.state.Weather.Condition == Condition.WEATHER_EXTREME_SUNLIGHT) {
				return false;
			}

			return true;
		}
		public static object Ability_Immunity_OnTryAddNonVolatile(object p) {
			OnTryAddNonVolatileParams cbParams = ValidateParams<OnTryAddNonVolatileParams>(p);

			if (cbParams.status == Status.POISON || cbParams.status == Status.TOXIC) {
				return false;
			}

			return true;
		}

		public static object Terrain_Electric_OnTryAddNonVolatile(object p) {
			OnTryAddNonVolatileParams cbParams = ValidateParams<OnTryAddNonVolatileParams>(p);

			if (cbParams.status == Status.SLEEP || cbParams.status == Status.DROWSY) {
				return false;
			}

			return true;
		}
		public static object Terrain_Misty_OnTryAddNonVolatile(object p) {
			return false;
		}
		
		public static object Condition_Safeguard_OnTryAddNonVolatile(object p) {
			OnTryAddNonVolatileParams cbParams = ValidateParams<OnTryAddNonVolatileParams>(p);

			if (cbParams.state.SideHasCondition(cbParams.bm.Side, Condition.SAFEGUARD)) {
				return false;
			}

			return true;
		}
	}
}