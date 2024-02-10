using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnWeatherSetParams {
		public OnWeatherSetParams(BattleState state, BattleMon source) {
			this.state = state;
			this.source = source;
		}
		public BattleState state;
		public BattleMon source;
	}
	
	internal static partial class BattleEvents {
		public static object Weather_HarshSunlight_OnWeatherSet(object p) {
			OnWeatherSetParams cbParams = ValidateParams<OnWeatherSetParams>(p);

			MessageBox(Lang.GetBattleMessage(BattleMessage.SUNLIGHT_BECAME_HARSH));
			return null;
		}
		public static object Weather_ExtremeSunlight_OnWeatherSet(object p) {
			OnWeatherSetParams cbParams = ValidateParams<OnWeatherSetParams>(p);

			MessageBox(Lang.GetBattleMessage(BattleMessage.SUNLIGHT_BECAME_EXTREMELY_HARSH));
			return null;
		}
		public static object Weather_Rain_OnWeatherSet(object p) {
			OnWeatherSetParams cbParams = ValidateParams<OnWeatherSetParams>(p);

			MessageBox(Lang.GetBattleMessage(BattleMessage.STARTED_RAINING));
			return null;
		}
		public static object Weather_HeavyRain_OnWeatherSet(object p) {
			OnWeatherSetParams cbParams = ValidateParams<OnWeatherSetParams>(p);

			MessageBox(Lang.GetBattleMessage(BattleMessage.HEAVY_RAIN_STARTED));
			return null;
		}
		public static object Weather_Sandstorm_OnWeatherSet(object p) {
			OnWeatherSetParams cbParams = ValidateParams<OnWeatherSetParams>(p);

			MessageBox(Lang.GetBattleMessage(BattleMessage.SANDSTORM_KICKED_UP));
			return null;
		}
		public static object Weather_Hail_OnWeatherSet(object p) {
			OnWeatherSetParams cbParams = ValidateParams<OnWeatherSetParams>(p);

			MessageBox(Lang.GetBattleMessage(BattleMessage.STARTED_HAILING));
			return null;
		}
		public static object Weather_Snow_OnWeatherSet(object p) {
			OnWeatherSetParams cbParams = ValidateParams<OnWeatherSetParams>(p);

			MessageBox(Lang.GetBattleMessage(BattleMessage.STARTED_SNOWING));
			return null;
		}
		public static object Weather_Fog_OnWeatherSet(object p) {
			OnWeatherSetParams cbParams = ValidateParams<OnWeatherSetParams>(p);

			MessageBox(Lang.GetBattleMessage(BattleMessage.FOG_CREPT_UP));
			return null;
		}
		public static object Weather_StrongWind_OnWeatherSet(object p) {
			OnWeatherSetParams cbParams = ValidateParams<OnWeatherSetParams>(p);

			MessageBox(Lang.GetBattleMessage(BattleMessage.MYSTERIOUS_WIND_APPEARED));
			return null;
		}
		public static object Weather_ShadowyAura_OnWeatherSet(object p) {
			OnWeatherSetParams cbParams = ValidateParams<OnWeatherSetParams>(p);

			MessageBox(Lang.GetBattleMessage(BattleMessage.SHADOWY_AURA_APPEARED));
			return null;
		}
	}
}