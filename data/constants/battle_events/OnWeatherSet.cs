using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

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
		public static async Task<object> Weather_HarshSunlight_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.SUNLIGHT_BECAME_HARSH));
			return null;
		}
		public static async Task<object> Weather_ExtremeSunlight_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.SUNLIGHT_BECAME_EXTREMELY_HARSH));
			return null;
		}
		public static async Task<object> Weather_Rain_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.STARTED_RAINING));
			return null;
		}
		public static async Task<object> Weather_HeavyRain_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.HEAVY_RAIN_STARTED));
			return null;
		}
		public static async Task<object> Weather_Sandstorm_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.SANDSTORM_KICKED_UP));
			return null;
		}
		public static async Task<object> Weather_Hail_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.STARTED_HAILING));
			return null;
		}
		public static async Task<object> Weather_Snow_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.STARTED_SNOWING));
			return null;
		}
		public static async Task<object> Weather_Fog_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.FOG_CREPT_UP));
			return null;
		}
		public static async Task<object> Weather_StrongWind_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.MYSTERIOUS_WIND_APPEARED));
			return null;
		}
		public static async Task<object> Weather_ShadowyAura_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.SHADOWY_AURA_APPEARED));
			return null;
		}

		public static async Task<object> Terrain_Electric_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.ELECTRIC_TERRAIN_START));
			return null;
		}
		public static async Task<object> Terrain_Grassy_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.GRASSY_TERRAIN_START));
			return null;
		}
		public static async Task<object> Terrain_Misty_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MISTY_TERRAIN_START));
			return null;
		}
		public static async Task<object> Terrain_Psychic_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.PSYCHIC_TERRAIN_START));
			return null;
		}
	}
}