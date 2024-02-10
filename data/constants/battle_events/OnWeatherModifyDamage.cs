using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.BattleMoves;

using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnWeatherModifyDamageParams {
		public OnWeatherModifyDamageParams(BattleMoveID moveID, BattleMon attacker, BattleMon defender) {
			this.moveID = moveID;
			this.attacker = attacker;
			this.defender = defender;
		}
		public BattleMoveID moveID;
		public BattleMon attacker;
		public BattleMon defender;
	}
	
	internal static partial class BattleEvents {
		public static object Weather_HarshSunlight_OnWeatherModifyDamage(object p) {
			OnWeatherModifyDamageParams cbParams = ValidateParams<OnWeatherModifyDamageParams>(p);

			BattleMove move = gBattleMoves(cbParams.moveID);

			if (cbParams.moveID == BattleMoveID.HYDRO_STEAM && cbParams.attacker.HeldItem != Item.UTILITY_UMBRELLA) {
				return 1.5f;
			}
			if (cbParams.defender.HeldItem == Item.UTILITY_UMBRELLA) {
				return 1;
			}
			if (move.moveType == Type.FIRE) {
				// Sunny Day fire boost
				return FieldConditions.WEATHER_DAMAGE_BOOST;
			}
			if (move.moveType == Type.WATER) {
				// Sunny Day water suppress
				return FieldConditions.WEATHER_DAMAGE_REDUCTION;
			}

			return 1;
		}
		public static object Weather_Rain_OnWeatherModifyDamage(object p) {
			OnWeatherModifyDamageParams cbParams = ValidateParams<OnWeatherModifyDamageParams>(p);

			BattleMove move = gBattleMoves(cbParams.moveID);

			if (cbParams.defender.HeldItem == Item.UTILITY_UMBRELLA) {
				return 1;
			}
			if (move.moveType == Type.WATER) {
				// Sunny Day fire boost
				return FieldConditions.WEATHER_DAMAGE_BOOST;
			}
			if (move.moveType == Type.FIRE) {
				// Sunny Day water suppress
				return FieldConditions.WEATHER_DAMAGE_REDUCTION;
			}

			return 1;
		}
	}
}