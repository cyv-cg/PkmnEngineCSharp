using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

using static PkmnEngine.Global;
using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnSideResidualParams {
		public OnSideResidualParams(Battle battle, BattleState state, u8 side) {
			this.battle = battle;
			this.state = state;
			this.side = side;
		}
		public Battle battle;
		public BattleState state;
		public u8 side;
	}
	
	internal static partial class BattleEvents {
		private static async Task ResolveCondition(BattleState state, Condition condition, StringResource message) {
			if (state.FieldHasCondition(condition, out FieldCondition c)) {
				if (c.DurationRemaining == 0) {
					state.RemoveCondition(c);
					await MessageBox(Lang.GetString(STRINGS, message));
				}
				c.DecrementDuration();
			}
		}
		private static async Task ResolveCondition(BattleState state, u8 side, Condition condition, StringResource clientMessage, StringResource remoteMessage) {
			if (state.SideHasCondition(side, condition, out FieldCondition c)) {
				if (c.DurationRemaining == 0) {
					state.RemoveCondition(c);
					if (side == Battle.SIDE_CLIENT) {
						await MessageBox(Lang.GetString(STRINGS, clientMessage));
					}
					else {
						await MessageBox(Lang.GetString(STRINGS, remoteMessage));
					}
				}
				c.DecrementDuration();
			}
		}

		public static async Task<object> Condition_Reflect_OnSideResidual(object p) {
			OnSideResidualParams args = ValidateParams<OnSideResidualParams>(p);
			await ResolveCondition(args.state, args.side, Condition.REFLECT,
				BATTLE_COMMON.ALLY_REFLECT_WORE_OFF,
				BATTLE_COMMON.OPPONENT_REFLECT_WORE_OFF
			);
			return null;
		}
		public static async Task<object> Condition_LightScreen_OnSideResidual(object p) {
			OnSideResidualParams args = ValidateParams<OnSideResidualParams>(p);
			await ResolveCondition(args.state, args.side, Condition.LIGHT_SCREEN,
				BATTLE_COMMON.ALLY_LIGHT_SCREEN_WORE_OFF,
				BATTLE_COMMON.OPPONENT_LIGHT_SCREEN_WORE_OFF
			);
			return null;
		}
		public static async Task<object> Condition_AuroraVeil_OnSideResidual(object p) {
			OnSideResidualParams args = ValidateParams<OnSideResidualParams>(p);
			await ResolveCondition(args.state, args.side, Condition.AURORA_VEIL,
				BATTLE_COMMON.ALLY_AURORA_VEIL_WORE_OFF,
				BATTLE_COMMON.OPPONENT_AURORA_VEIL_WORE_OFF	
			);
			return null;
		}
		public static async Task<object> Condition_Tailwind_OnSideResidual(object p) {
			OnSideResidualParams args = ValidateParams<OnSideResidualParams>(p);
			await ResolveCondition(args.state, args.side, Condition.TAILWIND,
				BATTLE_COMMON.ALLY_TAILWIND_END,
				BATTLE_COMMON.OPPONENT_TAILWIND_END
			);
			return null;
		}

		public static async Task<object> Condition_SafeGuard_OnSideResidual(object p) {
			OnSideResidualParams args = ValidateParams<OnSideResidualParams>(p);
			await ResolveCondition(args.state, args.side, Condition.SAFEGUARD,
				BATTLE_COMMON.PLAYER_NO_LONGER_PROTECTED_BY_SAFEGUARD,
				BATTLE_COMMON.OPPONENT_NO_LONGER_PROTECTED_BY_SAFEGUARD
			);
			return null;
		}
		public static async Task<object> Condition_Mist_OnSideResidual(object p) {
			OnSideResidualParams args = ValidateParams<OnSideResidualParams>(p);
			await ResolveCondition(args.state, args.side, Condition.MIST, 
				BATTLE_COMMON.YOUR_TEAM_NO_LONGER_PROTECTED_BY_MIST, 
				BATTLE_COMMON.OPPOSING_TEAM_NO_LONGER_PROTECTED_BY_MIST
			);
			return null;
		}
	} 
}