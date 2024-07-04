using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

using static PkmnEngine.Global;
using static PkmnEngine.BattleMoves;
using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnTrySetWeatherParams {
		public OnTrySetWeatherParams() {

		}
	}
	
	internal static partial class BattleEvents {
		public static async Task<object> Weather_ExtremeSunlight_OnTrySetWeather(object p) {
			OnTrySetWeatherParams args = ValidateParams<OnTrySetWeatherParams>(p);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.EXTREME_SUNLIGHT_NOT_LESSENED));
			return false;
		}
		public static async Task<object> Weather_HeavyRain_OnTrySetWeather(object p) {
			OnTrySetWeatherParams args = ValidateParams<OnTrySetWeatherParams>(p);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.HEAVY_RAIN_NOT_LESSENED));
			return false;
		}
		public static async Task<object> Weather_StrongWind_OnTrySetWeather(object p) {
			OnTrySetWeatherParams args = ValidateParams<OnTrySetWeatherParams>(p);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.STRONG_WINDS_NOT_LESSENED));
			return false;
		}
	}
}