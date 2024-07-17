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

			await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.SUNLIGHT_TURNED_HARSH));
			return null;
		}
		public static async Task<object> Weather_ExtremeSunlight_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.SUNLIGHT_TURNED_EXTREMELY_HARSH));
			return null;
		}
		public static async Task<object> Weather_Rain_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.RAIN_STARTED));
			return null;
		}
		public static async Task<object> Weather_HeavyRain_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.HEAVY_RAIN_STARTED));
			return null;
		}
		public static async Task<object> Weather_Sandstorm_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.SANDSTORM_KICKED_UP));
			return null;
		}
		public static async Task<object> Weather_Hail_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.HAIL_STARTED));
			return null;
		}
		public static async Task<object> Weather_Snow_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.SNOW_STARTED));
			return null;
		}
		public static async Task<object> Weather_Fog_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.FOG_CREPT_UP));
			return null;
		}
		public static async Task<object> Weather_StrongWind_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.MYSTERIOUS_WINDS_ARE_PROTECTING_FLYING_MONS));
			return null;
		}
		public static async Task<object> Weather_ShadowyAura_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);

			await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.SHADOWY_AURA_FILLED_THE_SKY));
			return null;
		}

		public static async Task<object> Terrain_Electric_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);
			await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.ELECTRIC_TERRAIN_START));
			return null;
		}
		public static async Task<object> Terrain_Grassy_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);
			await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.GRASSY_TERRAIN_START));
			return null;
		}
		public static async Task<object> Terrain_Misty_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);
			await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.MISTY_TERRAIN_START));
			return null;
		}
		public static async Task<object> Terrain_Psychic_OnWeatherSet(object p) {
			OnWeatherSetParams args = ValidateParams<OnWeatherSetParams>(p);
			await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.PSYCHIC_TERRAIN_START));
			return null;
		}
	}
}