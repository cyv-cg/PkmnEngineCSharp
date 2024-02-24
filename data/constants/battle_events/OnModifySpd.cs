using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace PkmnEngine {
	public struct OnModifySpdParams {
		public OnModifySpdParams(BattleState state, BattleMon bm) {
			this.state = state;
			this.bm = bm;
		}
		public BattleState state;
		public BattleMon bm;
	}

	internal static partial class BattleEvents {
		public static object Ability_QuickFeet_OnModifySpd(object p) {
			OnModifySpdParams args = ValidateParams<OnModifySpdParams>(p);

			if (args.bm.HasStatus(StatusEffects.STATUS_MASK_NON_VOLATILE)) {
				return 1.5f;
			}

			return 1f;
		}

		public static object Condition_Tailwind_OnModifySpd(object p) {
			OnModifySpdParams args = ValidateParams<OnModifySpdParams>(p);

			if (args.state.SideHasCondition(args.bm.Side, Condition.TAILWIND)) {
				return FieldConditions.TAILWIND_SPEED_BOOST;
			}
			return 1f;
		}

		public static object Status_Paralysis_OnModifySpd(object p) {
			OnModifySpdParams args = ValidateParams<OnModifySpdParams>(p);

			if (args.bm.ability != Ability.QUICK_FEET) {
				return StatusEffects.PARALYSIS_SPEED_MULTIPLIER;
			}

			return 1f;
		}
	}
}