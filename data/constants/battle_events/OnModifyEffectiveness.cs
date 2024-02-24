using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

namespace PkmnEngine {
	public struct OnModifyEffectivenessParams {
		public OnModifyEffectivenessParams(BattleState state, BattleMon defender, BattleMoveID moveID, float typeEff) {
			this.state = state;
			this.defender = defender;
			this.moveID = moveID;
			this.typeEff = typeEff;
		}
		public BattleState state;
		public BattleMon defender;
		public BattleMoveID moveID;
		public float typeEff;
	}
	
	internal static partial class BattleEvents {
		public static object Weather_StrongWind_OnModifyEffectiveness(object p) {
			OnModifyEffectivenessParams args = ValidateParams<OnModifyEffectivenessParams>(p);

			if ((args.state.Weather.Condition == Condition.WEATHER_STRONG_WIND) && args.typeEff >= Types.EFF_NORMAL && args.defender.HasType(Type.FLYING)) {
				//MessageBox(lang::GetBattleMessage(BATTLE_MESSAGE_WIND_WEAKENED_ATTACK));
				return Types.EFF_NORMAL / args.typeEff;
			}

			return 1f;
		}
	}
}