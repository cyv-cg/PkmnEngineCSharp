using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

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
		private static void ResolveCondition(BattleState state, Condition condition, BattleMessage message) {
			if (state.FieldHasCondition(condition, out FieldCondition c)) {
				if (c.DurationRemaining == 0) {
					state.RemoveCondition(c);
					MessageBox(Lang.GetBattleMessage(message));
				}
				c.DecrementDuration();
			}
		}
		private static void ResolveCondition(BattleState state, u8 side, Condition condition, BattleMessage clientMessage, BattleMessage remoteMessage) {
			if (state.SideHasCondition(side, condition, out FieldCondition c)) {
				if (c.DurationRemaining == 0) {
					state.RemoveCondition(c);
					if (side == Battle.SIDE_CLIENT) {
						MessageBox(Lang.GetBattleMessage(clientMessage));
					}
					else {
						MessageBox(Lang.GetBattleMessage(remoteMessage));
					}
				}
				c.DecrementDuration();
			}
		}

		public static object Condition_Reflect_OnSideResidual(object p) {
			OnSideResidualParams cbParams = ValidateParams<OnSideResidualParams>(p);
			ResolveCondition(cbParams.state, cbParams.side, Condition.REFLECT,
				BattleMessage.ALLY_REFLECT_WORE_OFF,
				BattleMessage.OPPONENT_REFLECT_WORE_OFF
			);
			return null;
		}
		public static object Condition_LightScreen_OnSideResidual(object p) {
			OnSideResidualParams cbParams = ValidateParams<OnSideResidualParams>(p);
			ResolveCondition(cbParams.state, cbParams.side, Condition.LIGHT_SCREEN,
				BattleMessage.ALLY_LIGHT_SCREEN_WORE_OFF,
				BattleMessage.OPPONENT_LIGHT_SCREEN_WORE_OFF
			);
			return null;
		}
		public static object Condition_AuroraVeil_OnSideResidual(object p) {
			OnSideResidualParams cbParams = ValidateParams<OnSideResidualParams>(p);
			ResolveCondition(cbParams.state, cbParams.side, Condition.AURORA_VEIL,
				BattleMessage.ALLY_AURORA_VEIL_WORE_OFF,
				BattleMessage.OPPONENT_AURORA_VEIL_WORE_OFF	
			);
			return null;
		}
		public static object Condition_Tailwind_OnSideResidual(object p) {
			OnSideResidualParams cbParams = ValidateParams<OnSideResidualParams>(p);
			ResolveCondition(cbParams.state, cbParams.side, Condition.TAILWIND,
				BattleMessage.ALLY_TAILWIND_END,
				BattleMessage.ENEMY_TAILWIND_END
			);
			return null;
		}

		public static object Condition_SafeGuard_OnSideResidual(object p) {
			OnSideResidualParams cbParams = ValidateParams<OnSideResidualParams>(p);
			ResolveCondition(cbParams.state, cbParams.side, Condition.SAFEGUARD,
				BattleMessage.PLAYER_NO_LONGER_PROTECTED_BY_SAFEGUARD,
				BattleMessage.OPPONENT_NO_LONGER_PROTECTED_BY_SAFEGUARD
			);
			return null;
		}
		public static object Condition_Mist_OnSideResidual(object p) {
			OnSideResidualParams cbParams = ValidateParams<OnSideResidualParams>(p);
			ResolveCondition(cbParams.state, cbParams.side, Condition.MIST, 
				BattleMessage.YOUR_TEAM_NO_LONGER_PROTECTED_BY_MIST, 
				BattleMessage.OPPOSING_TEAM_NO_LONGER_PROTECTED_BY_MIST
			);
			return null;
		}
	} 
}