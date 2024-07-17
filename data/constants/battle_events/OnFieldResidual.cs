using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

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
		public static async Task<object> Condition_WaterSport_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			await ResolveCondition(args.state, Condition.WATER_SPORT, BATTLE_COMMON.WATER_SPORT_END);
			return null;
		}
		public static async Task<object> Condition_MudSport_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			await ResolveCondition(args.state, Condition.MUD_SPORT, BATTLE_COMMON.WATER_SPORT_END);
			return null;
		}

		public static async Task<object> Weather_HarshSunlight_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();

			if (args.state.Weather.DurationRemaining == 0) {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.SUNLIGHT_FADED));
				args.state.Weather.ClearWeatherTerrain();
			}
			else {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.SUNLIGHT_IS_HARSH));
			}

			return null;
		}
		public static async Task<object> Weather_ExtremeSunlight_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.EXTREME_SUNLIGHT_FADED));
				args.state.Weather.ClearWeatherTerrain();
			}
			else {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.SUNLIGHT_IS_EXTREMELY_HARSH));
			}

			return null;
		}
		public static async Task<object> Weather_Rain_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.RAIN_STOPPED));
				args.state.Weather.ClearWeatherTerrain();
			}
			else {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.ITS_RAINING));
			}

			return null;
		}
		public static async Task<object> Weather_HeavyRain_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.HEAVY_RAIN_STOPPED));
				args.state.Weather.ClearWeatherTerrain();
			}
			else {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.RAIN_IS_POURING_DOWN));
			}

			return null;
		}
		public static async Task<object> Weather_Sandstorm_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.SANDSTORM_SUBSIDED));
				args.state.Weather.ClearWeatherTerrain();
				return null;
			}
			else {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.SANDSTORM_IS_RAGING));
			}

			// Damage mons.
			foreach (BattleMon bm in args.battle.GetAllActiveMons()) {
				if (bm.DamagedBySandstorm()) {
					U16 damage = new(bm.GetPercentOfMaxHp(FieldConditions.SANDSTORM_CHIP_DAMAGE));
					await bm.DamageMon(damage, true, false, Lang.GetString(STRINGS, BATTLE_COMMON.MON_HURT_BY_SANDSTORM, bm.GetName()));
				}
			}

			return null;
		}
		public static async Task<object> Weather_Hail_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.HAIL_STOPPED));
				args.state.Weather.ClearWeatherTerrain();
				return null;
			}
			else {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.ITS_HAILING));
			}

			// Damage mons.
			foreach (BattleMon bm in args.battle.GetAllActiveMons()) {
				if (bm.DamagedByHail()) {
					U16 damage = new(bm.GetPercentOfMaxHp(FieldConditions.HAIL_CHIP_DAMAGE));
					await bm.DamageMon(damage, true, false, Lang.GetString(STRINGS, BATTLE_COMMON.MON_HURT_BY_HAIL, bm.GetName()));
				}
			}

			return null;
		}
		public static async Task<object> Weather_Snow_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.SNOW_STOPPED));
				args.state.Weather.ClearWeatherTerrain();
			}
			else {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.ITS_SNOWING));
			}

			return null;
		}
		public static async Task<object> Weather_Fog_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.FOG_LIFTED));
				args.state.Weather.ClearWeatherTerrain();
			}
			else {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.FOG_CREPT_UP));
			}

			return null;
		}
		public static async Task<object> Weather_StrongWind_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.MYSTERIOUS_WINDS_STOPPED));
				args.state.Weather.ClearWeatherTerrain();
			}
			else {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.MYSTERIOUS_WIND_BLOWS_ON));
			}

			return null;
		}
		public static async Task<object> Weather_ShadowyAura_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Weather.DecrementDuration();
			
			if (args.state.Weather.DurationRemaining == 0) {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.SHADOWY_AURA_FADED));
				args.state.Weather.ClearWeatherTerrain();
			}
			else {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.LIGHT_SHOWERED_FROM_SHADOWY_AURA));
			}

			/*
			In battle:
				Increases the power of Shadow moves by 50% (although this is not mentioned ingame)
				At the end of each turn, damages each Pokémon for 1/16 of its maximum HP, unless it is a Shadow Pokémon.
				Changes Weather Ball to a typeless move and doubles its power. (If a Pokémon with Color Change is hit by typeless Weather Ball, it becomes a Normal-type.)
			*/

			return null;
		}

		public static async Task<object> Terrain_Electric_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Terrain.DecrementDuration();

			if (args.state.Terrain.DurationRemaining == 0) {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.ELECTRIC_TERRAIN_END));
				args.state.Terrain.ClearWeatherTerrain();
			}
			else {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.ELECTRIC_TERRAIN_ACTIVE));
			}

			return null;
		}
		public static async Task<object> Terrain_Grassy_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Terrain.DecrementDuration();

			if (args.state.Terrain.DurationRemaining == 0) {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.GRASSY_TERRAIN_END));
				args.state.Terrain.ClearWeatherTerrain();
			}
			else {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.GRASSY_TERRAIN_ACTIVE));
			}

			// Heal mons.
			foreach (BattleMon bm in args.battle.GetAllActiveMons()) {
				if (bm == null || !bm.IsGrounded(args.state)) {
					continue;
				}
			
				if (args.state.Terrain.Condition == Condition.TERRAIN_GRASSY) {
					U16 healAmount = new(bm.GetPercentOfMaxHp(FieldConditions.GRASSY_TERRAIN_HEAL_AMOUNT));
					await bm.HealMon(healAmount, false);
				}
			}

			return null;
		}
		public static async Task<object> Terrain_Misty_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Terrain.DecrementDuration();

			if (args.state.Terrain.DurationRemaining == 0) {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.MISTY_TERRAIN_END));
				args.state.Terrain.ClearWeatherTerrain();
			}
			else {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.MISTY_TERRAIN_ACTIVE));
			}

			return null;
		}
		public static async Task<object> Terrain_Psychic_OnFieldResidual(object p) {
			OnFieldResidualParams args = ValidateParams<OnFieldResidualParams>(p);

			args.state.Terrain.DecrementDuration();

			if (args.state.Terrain.DurationRemaining == 0) {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.PSYCHIC_TERRAIN_END));
				args.state.Terrain.ClearWeatherTerrain();
			}
			else {
				await MessageBox(Lang.GetString(STRINGS, BATTLE_COMMON.PSYCHIC_TERRAIN_ACTIVE));
			}

			return null;
		}
	}
}