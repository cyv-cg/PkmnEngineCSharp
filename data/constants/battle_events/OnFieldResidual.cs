using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using PkmnEngine.Strings;

namespace PkmnEngine {
	public struct OnFieldResidualParams {
		public OnFieldResidualParams(Battle battle, BattleState state) {
			this.battle = battle;
			this.state = state;
		}
		public Battle battle;
		public BattleState state;
	}
	
	internal static partial class BattleEvents {
		public static object Weather_HarshSunlight_OnFieldResidual(object p) {
			OnFieldResidualParams cbParams = ValidateParams<OnFieldResidualParams>(p);

			cbParams.state.Weather.DecrementDuration();

			if (cbParams.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.SUNLIGHT_FADED));
				cbParams.state.Weather.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.SUNLIGHT_IS_HARSH));
			}

			return null;
		}
		public static object Weather_ExtremeSunlight_OnFieldResidual(object p) {
			OnFieldResidualParams cbParams = ValidateParams<OnFieldResidualParams>(p);

			cbParams.state.Weather.DecrementDuration();
			
			if (cbParams.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.EXTREME_SUNLIGHT_FADED));
				cbParams.state.Weather.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.SUNLIGHT_IS_HARSH));
			}

			return null;
		}
		public static object Weather_Rain_OnFieldResidual(object p) {
			OnFieldResidualParams cbParams = ValidateParams<OnFieldResidualParams>(p);

			cbParams.state.Weather.DecrementDuration();
			
			if (cbParams.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.RAIN_STOPPED));
				cbParams.state.Weather.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.ITS_RAINING));
			}

			return null;
		}
		public static object Weather_HeavyRain_OnFieldResidual(object p) {
			OnFieldResidualParams cbParams = ValidateParams<OnFieldResidualParams>(p);

			cbParams.state.Weather.DecrementDuration();
			
			if (cbParams.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.HEAVY_RAIN_STOPPED));
				cbParams.state.Weather.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.ITS_RAINING));
			}

			return null;
		}
		public static object Weather_Sandstorm_OnFieldResidual(object p) {
			OnFieldResidualParams cbParams = ValidateParams<OnFieldResidualParams>(p);

			cbParams.state.Weather.DecrementDuration();
			
			if (cbParams.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.SANDSTORM_SUBSIDED));
				cbParams.state.Weather.ClearWeatherTerrain();
				return null;
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.SANDSTORM_IS_RAGING));
			}

			// Damage mons.
			foreach (BattleMon bm in cbParams.battle.GetAllActiveMons()) {
				if (bm.DamagedBySandstorm()) {
					u16 damage = bm.GetPercentOfMaxHp(FieldConditions.SANDSTORM_CHIP_DAMAGE);
					bm.DamageMon(ref damage, true, false);
					MessageBox(Lang.GetBattleMessage(BattleMessage.MON_HURT_BY_SANDSTORM, bm.GetName()));
				}
			}

			return null;
		}
		public static object Weather_Hail_OnFieldResidual(object p) {
			OnFieldResidualParams cbParams = ValidateParams<OnFieldResidualParams>(p);

			cbParams.state.Weather.DecrementDuration();
			
			if (cbParams.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.HAIL_STOPPED));
				cbParams.state.Weather.ClearWeatherTerrain();
				return null;
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.ITS_HAILING));
			}

			// Damage mons.
			foreach (BattleMon bm in cbParams.battle.GetAllActiveMons()) {
				if (bm.DamagedByHail()) {
					u16 damage = bm.GetPercentOfMaxHp(FieldConditions.HAIL_CHIP_DAMAGE);
					bm.DamageMon(ref damage, true, false);
					MessageBox(Lang.GetBattleMessage(BattleMessage.MON_HURT_BY_HAIL, bm.GetName()));
				}
			}

			return null;
		}
		public static object Weather_Snow_OnFieldResidual(object p) {
			OnFieldResidualParams cbParams = ValidateParams<OnFieldResidualParams>(p);

			cbParams.state.Weather.DecrementDuration();
			
			if (cbParams.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.SNOW_STOPPED));
				cbParams.state.Weather.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.ITS_SNOWING));
			}

			return null;
		}
		public static object Weather_Fog_OnFieldResidual(object p) {
			OnFieldResidualParams cbParams = ValidateParams<OnFieldResidualParams>(p);

			cbParams.state.Weather.DecrementDuration();
			
			if (cbParams.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.FOG_LIFTED));
				cbParams.state.Weather.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.FOG_CREPT_UP));
			}

			return null;
		}
		public static object Weather_StrongWind_OnFieldResidual(object p) {
			OnFieldResidualParams cbParams = ValidateParams<OnFieldResidualParams>(p);

			cbParams.state.Weather.DecrementDuration();
			
			if (cbParams.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.MYSTERIOUS_WIND_DISAPPEARED));
				cbParams.state.Weather.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.MYSTERIOUS_WIND_BLOWS_ON));
			}

			return null;
		}
		public static object Weather_ShadowyAura_OnFieldResidual(object p) {
			OnFieldResidualParams cbParams = ValidateParams<OnFieldResidualParams>(p);

			cbParams.state.Weather.DecrementDuration();
			
			if (cbParams.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.SHADOWY_AURA_DISAPPEARED));
				cbParams.state.Weather.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.LIGHT_SHOWERED_FROM_SHADOWY_AURA));
			}

			/*
			In battle:
				Increases the power of Shadow moves by 50% (although this is not mentioned ingame)
				At the end of each turn, damages each Pokémon for 1/16 of its maximum HP, unless it is a Shadow Pokémon.
				Changes Weather Ball to a typeless move and doubles its power. (If a Pokémon with Color Change is hit by typeless Weather Ball, it becomes a Normal-type.)
			*/

			return null;
		}
	}
}