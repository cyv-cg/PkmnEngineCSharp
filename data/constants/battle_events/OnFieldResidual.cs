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
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();

			if (args.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.SUNLIGHT_FADED));
				args.state.Weather.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.SUNLIGHT_IS_HARSH));
			}

			return null;
		}
		public static object Weather_ExtremeSunlight_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.EXTREME_SUNLIGHT_FADED));
				args.state.Weather.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.SUNLIGHT_IS_HARSH));
			}

			return null;
		}
		public static object Weather_Rain_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.RAIN_STOPPED));
				args.state.Weather.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.ITS_RAINING));
			}

			return null;
		}
		public static object Weather_HeavyRain_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.HEAVY_RAIN_STOPPED));
				args.state.Weather.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.ITS_RAINING));
			}

			return null;
		}
		public static object Weather_Sandstorm_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.SANDSTORM_SUBSIDED));
				args.state.Weather.ClearWeatherTerrain();
				return null;
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.SANDSTORM_IS_RAGING));
			}

			// Damage mons.
			foreach (BattleMon bm in args.battle.GetAllActiveMons()) {
				if (bm.DamagedBySandstorm()) {
					u16 damage = bm.GetPercentOfMaxHp(FieldConditions.SANDSTORM_CHIP_DAMAGE);
					bm.DamageMon(ref damage, true, false);
					MessageBox(Lang.GetBattleMessage(BattleMessage.MON_HURT_BY_SANDSTORM, bm.GetName()));
				}
			}

			return null;
		}
		public static object Weather_Hail_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.HAIL_STOPPED));
				args.state.Weather.ClearWeatherTerrain();
				return null;
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.ITS_HAILING));
			}

			// Damage mons.
			foreach (BattleMon bm in args.battle.GetAllActiveMons()) {
				if (bm.DamagedByHail()) {
					u16 damage = bm.GetPercentOfMaxHp(FieldConditions.HAIL_CHIP_DAMAGE);
					bm.DamageMon(ref damage, true, false);
					MessageBox(Lang.GetBattleMessage(BattleMessage.MON_HURT_BY_HAIL, bm.GetName()));
				}
			}

			return null;
		}
		public static object Weather_Snow_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.SNOW_STOPPED));
				args.state.Weather.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.ITS_SNOWING));
			}

			return null;
		}
		public static object Weather_Fog_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.FOG_LIFTED));
				args.state.Weather.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.FOG_CREPT_UP));
			}

			return null;
		}
		public static object Weather_StrongWind_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.MYSTERIOUS_WIND_DISAPPEARED));
				args.state.Weather.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.MYSTERIOUS_WIND_BLOWS_ON));
			}

			return null;
		}
		public static object Weather_ShadowyAura_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.SHADOWY_AURA_DISAPPEARED));
				args.state.Weather.ClearWeatherTerrain();
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

		public static object Terrain_Electric_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Terrain.DecrementDuration();

			if (args.state.Terrain.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.ELECTRIC_TERRAIN_END));
				args.state.Terrain.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.ELECTRIC_TERRAIN_ACTIVE));
			}

			return null;
		}
		public static object Terrain_Grassy_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Terrain.DecrementDuration();

			if (args.state.Terrain.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.GRASSY_TERRAIN_END));
				args.state.Terrain.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.GRASSY_TERRAIN_ACTIVE));
			}

			// Heal mons.
			foreach (BattleMon bm in args.battle.GetAllActiveMons()) {
				if (bm == null || !bm.IsGrounded(args.state)) {
					continue;
				}
			
				if (args.state.Terrain.Condition == Condition.TERRAIN_GRASSY) {
					u16 healAmount = bm.GetPercentOfMaxHp(FieldConditions.GRASSY_TERRAIN_HEAL_AMOUNT);
					bm.HealMon(ref healAmount, false);
				}
			}

			return null;
		}
		public static object Terrain_Misty_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Terrain.DecrementDuration();

			if (args.state.Terrain.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.MISTY_TERRAIN_END));
				args.state.Terrain.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.MISTY_TERRAIN_ACTIVE));
			}

			return null;
		}
		public static object Terrain_Psychic_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Terrain.DecrementDuration();

			if (args.state.Terrain.DurationRemaining == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.PSYCHIC_TERRAIN_END));
				args.state.Terrain.ClearWeatherTerrain();
			}
			else {
				MessageBox(Lang.GetBattleMessage(BattleMessage.PSYCHIC_TERRAIN_ACTIVE));
			}

			return null;
		}
	}
}