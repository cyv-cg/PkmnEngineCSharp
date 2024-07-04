using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.BattleEvents;
using PkmnEngine.Strings;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace PkmnEngine {
	public static class FieldConditions {
		public const float HAIL_CHIP_DAMAGE				= 1.0f / 16;
		public const float SANDSTORM_CHIP_DAMAGE		= 1.0f / 16;
		public const float WEATHER_DAMAGE_BOOST			= 1.5f;
		public const float WEATHER_DAMAGE_REDUCTION		= 0.5f;
		public const float SNOW_DEF_BOOST				= 1.5f;
		public const float FOG_ACCURACY_REDUCTION		= 0.9f;

		public const float TERRAIN_DAMAGE_BOOST			= 1.3f;
		public const float TERRAIN_DAMAGE_REDUCTION		= 0.5f;
		public const float GRASSY_TERRAIN_HEAL_AMOUNT	= 1.0f / 16;

		//#define TAILWIND_TURNS				4
		public const float TAILWIND_SPEED_BOOST			= 2;

		public const float WATER_SPORT_MULTIPLIER		= 0.33f;
		public const float MUD_SPORT_MULTIPLIER			= 0.33f;

		public static u16 StealthRockDamage(BattleMon bm) {
			float eff = DamageCalc.TypeEffectiveness(bm, Type.ROCK);
			if (eff == Types.EFF_NVE / 2) {
				return bm.GetPercentOfMaxHp(0.03125f);
			}
			else if (eff == Types.EFF_NVE) {
				return bm.GetPercentOfMaxHp(0.0625f);
			}
			else if (eff == Types.EFF_NORMAL) {
				return bm.GetPercentOfMaxHp(0.125f);
			}
			else if (eff == Types.EFF_SPE) {
				return bm.GetPercentOfMaxHp(0.25f);
			}
			else if (eff == Types.EFF_SPE * 2) {
				return bm.GetPercentOfMaxHp(0.5f);
			}
			else {
				// We should never get floating point errors here since it's just multiplying and dividing by 2.
				throw new System.Exception($"Floating point error: {eff}");
			}
		}

		public static (BattleEvent callback, sbyte priority) gConditionEvents(Condition condition, Callback cb) {
			if (ConditionEvents.ContainsKey(condition) && ConditionEvents[condition].ContainsKey(cb)) {
				return ConditionEvents[condition][cb];
			}
			else {
				return (null, 0);
			}
		}

		private static async Task ResolveCondition(BattleState state, Condition condition, BattleMessage message) {
			if (state.FieldHasCondition(condition, out FieldCondition c)) {
				if (c.DurationRemaining == 0) {
					state.RemoveCondition(c);
					await MessageBox(Lang.GetBattleMessage(message));
				}
				c.DecrementDuration();
			}
		}

		private static readonly Dictionary<Condition, Dictionary<Callback, (BattleEvent callback, sbyte priority)>> ConditionEvents = new() { {
		
			Condition.WEATHER_HARSH_SUNLIGHT,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						if (((DurationCallbackParams)p).source.HeldItem == Item.HEAT_ROCK) {
							return (u8)8;
						}
						return (u8)5;
					}, 0)
				},
				{
					Callback.OnWeatherModifyDamage,
					(Weather_HarshSunlight_OnWeatherModifyDamage, 0)
				},
				{
					Callback.OnFieldResidual,
					(Weather_HarshSunlight_OnFieldResidual, 1)
				},
				{
					Callback.OnStatusImmunityCheck,
					(Weather_HarshSunlight_OnStatusImmunityCheck, 0)
				},
				{
					Callback.OnWeatherSet,
					(Weather_HarshSunlight_OnWeatherSet, 0)
				}
			}
		},
		{
			Condition.WEATHER_EXTREME_SUNLIGHT,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						return u8.MaxValue;
					}, 0)
				},
				{
					Callback.OnTrySetWeather,
					(Weather_ExtremeSunlight_OnTrySetWeather, 0)
				},
				{
					Callback.OnWeatherModifyDamage,
					(Weather_HarshSunlight_OnWeatherModifyDamage, 0)
				},
				{
					Callback.OnFieldResidual,
					(Weather_ExtremeSunlight_OnFieldResidual, 1)
				},
				{
					Callback.OnStatusImmunityCheck,
					(Weather_HarshSunlight_OnStatusImmunityCheck, 0)
				},
				{
					Callback.OnTryMove,
					(Weather_ExtremeSunlight_OnTryMove, 0)
				},
				{
					Callback.OnWeatherSet,
					(Weather_ExtremeSunlight_OnWeatherSet, 0)
				}
			}
		},
		{
			Condition.WEATHER_RAIN,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						if (((DurationCallbackParams)p).source.HeldItem == Item.DAMP_ROCK) {
							return (u8)8;
						}
						return (u8)5;
					}, 0)
				},
				{
					Callback.OnWeatherModifyDamage,
					(Weather_Rain_OnWeatherModifyDamage, 0)
				},
				{
					Callback.OnFieldResidual,
					(Weather_Rain_OnFieldResidual, 1)
				},
				{
					Callback.OnWeatherSet,
					(Weather_Rain_OnWeatherSet, 0)
				}
			}
		},
		{
			Condition.WEATHER_HEAVY_RAIN,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						return u8.MaxValue;
					}, 0)
				},
				{
					Callback.OnTrySetWeather,
					(Weather_HeavyRain_OnTrySetWeather, 0)
				},
				{
					Callback.OnWeatherModifyDamage,
					(Weather_Rain_OnWeatherModifyDamage, 0)
				},
				{
					Callback.OnFieldResidual,
					(Weather_HeavyRain_OnFieldResidual, 1)
				},
				{
					Callback.OnTryMove,
					(Weather_HeavyRain_OnTryMove, 0)
				},
				{
					Callback.OnWeatherSet,
					(Weather_HeavyRain_OnWeatherSet, 0)
				}
			}
		},
		{
			Condition.WEATHER_SANDSTORM,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						if (((DurationCallbackParams)p).source.HeldItem == Item.SMOOTH_ROCK) {
							return (u8)8;
						}
						return (u8)5;
					}, 0)
				},
				{
					Callback.OnModifySpDef,
					(Weather_Sandstorm_OnModifySpDef, 10)
				},
				{
					Callback.OnFieldResidual,
					(Weather_Sandstorm_OnFieldResidual, 1)
				},
				{
					Callback.OnWeatherSet,
					(Weather_Sandstorm_OnWeatherSet, 0)
				}
			}
		},
		{
			Condition.WEATHER_HAIL,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						if (((DurationCallbackParams)p).source.HeldItem == Item.ICY_ROCK) {
							return (u8)8;
						}
						return (u8)5;
					}, 0)
				},
				{
					Callback.OnFieldResidual,
					(Weather_Hail_OnFieldResidual, 1)
				},
				{
					Callback.OnWeatherSet,
					(Weather_Hail_OnWeatherSet, 0)
				}
			}
		},
		{
			Condition.WEATHER_SNOW,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						if (((DurationCallbackParams)p).source.HeldItem == Item.ICY_ROCK) {
							return (u8)8;
						}
						return (u8)5;
					}, 0)
				},
				{
					Callback.OnFieldResidual,
					(Terrain_Grassy_OnFieldResidual, 5)
				},
				{
					Callback.OnWeatherSet,
					(Terrain_Grassy_OnWeatherSet, 0)
				}
			}
		},
		{
			Condition.WEATHER_FOG,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						return u8.MaxValue;
					}, 0)
				},
				{
					Callback.OnFieldResidual,
					(Weather_Fog_OnFieldResidual, 1)
				},
				{
					Callback.OnFieldModifyAcc,
					((object p) => {
						return FieldConditions.FOG_ACCURACY_REDUCTION;
					}, 0)
				},
				{
					Callback.OnWeatherSet,
					(Weather_Fog_OnWeatherSet, 0)
				}
			}
		},
		{
			Condition.WEATHER_STRONG_WIND,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						return u8.MaxValue;
					}, 0)
				},
				{
					Callback.OnTrySetWeather,
					(Weather_StrongWind_OnTrySetWeather, 0)
				},
				{
					Callback.OnFieldResidual,
					(Weather_StrongWind_OnFieldResidual, 1)
				},
				{
					Callback.OnModifyEffectiveness,
					(Weather_StrongWind_OnModifyEffectiveness, -1)
				},
				{
					Callback.OnWeatherSet,
					(Weather_StrongWind_OnWeatherSet, 0)
				}
			}
		},
		{
			Condition.WEATHER_SHADOWY_AURA,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						return (u8)5;
					}, 0)
				},
				{
					Callback.OnFieldResidual,
					(Weather_ShadowyAura_OnFieldResidual, 1)
				},
				{
					Callback.OnWeatherSet,
					(Weather_ShadowyAura_OnWeatherSet, 0)
				}
			}
		},

		{
			Condition.TERRAIN_ELECTRIC,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						if (((DurationCallbackParams)p).source.HeldItem == Item.TERRAIN_EXTENDER) {
							return (u8)8;
						}
						return (u8)5;
					}, 0)
				},
				{
					Callback.OnFieldResidual,
					(Terrain_Electric_OnFieldResidual, 2)
				},
				{
					Callback.OnWeatherSet,
					(Terrain_Electric_OnWeatherSet, 0)
				},
				{
					Callback.OnWeatherModifyDamage,
					(Terrain_Electric_OnWeatherModifyDamage, 0)
				},
				{
					Callback.OnTryAddNonVolatile,
					(Terrain_Electric_OnTryAddNonVolatile, 0)
				}
			}
		},
		{
			Condition.TERRAIN_GRASSY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						if (((DurationCallbackParams)p).source.HeldItem == Item.TERRAIN_EXTENDER) {
							return (u8)8;
						}
						return (u8)5;
					}, 0)
				},
				{
					Callback.OnFieldResidual,
					(Terrain_Grassy_OnFieldResidual, 2)
				},
				{
					Callback.OnWeatherSet,
					(Terrain_Grassy_OnWeatherSet, 0)
				},
				{
					Callback.OnWeatherModifyDamage,
					(Terrain_Grassy_OnWeatherModifyDamage, 0)
				}
			}
		},
		{
			Condition.TERRAIN_MISTY,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						if (((DurationCallbackParams)p).source.HeldItem == Item.TERRAIN_EXTENDER) {
							return (u8)8;
						}
						return (u8)5;
					}, 0)
				},
				{
					Callback.OnFieldResidual,
					(Terrain_Misty_OnFieldResidual, 2)
				},
				{
					Callback.OnWeatherSet,
					(Terrain_Misty_OnWeatherSet, 0)
				},
				{
					Callback.OnWeatherModifyDamage,
					(Terrain_Misty_OnWeatherModifyDamage, 0)
				},
				{
					Callback.OnTryAddNonVolatile,
					(Terrain_Misty_OnTryAddNonVolatile, 0)
				}
			}
		},
		{
			Condition.TERRAIN_PSYCHIC,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						if (((DurationCallbackParams)p).source.HeldItem == Item.TERRAIN_EXTENDER) {
							return (u8)8;
						}
						return (u8)5;
					}, 0)
				},
				{
					Callback.OnFieldResidual,
					(Terrain_Psychic_OnFieldResidual, 2)
				},
				{
					Callback.OnWeatherSet,
					(Terrain_Psychic_OnWeatherSet, 0)
				},
				{
					Callback.OnWeatherModifyDamage,
					(Terrain_Psychic_OnWeatherModifyDamage, 0)
				}
			}
		},

		{
			Condition.WATER_SPORT,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => { return (u8)5; }, 0)
				},
				{
					Callback.OnWeatherModifyDamage,
					(Condition_WaterSport_OnWeatherModifyDamage, 0)
				},
				{
					Callback.OnFieldResidual,
					(Condition_WaterSport_OnFieldResidual, 27)
				}
			}
		},
		{
			Condition.MUD_SPORT,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => { return (u8)5; }, 0)
				},
				{
					Callback.OnWeatherModifyDamage,
					(Condition_MudSport_OnWeatherModifyDamage, 0)
				},
				{
					Callback.OnFieldResidual,
					(Condition_MudSport_OnFieldResidual, 27)
				}
			}
		},

		{
			Condition.REFLECT,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						if (((DurationCallbackParams)p).source.HeldItem == Item.LIGHT_CLAY) {
							return (u8)8;
						}
						return (u8)5;
					}, 0)
				},
				{
					Callback.OnModifyDamage,
					(Condition_Reflect_OnModifyDamage, 0)
				},
				{
					Callback.OnSideResidual,
					(Condition_Reflect_OnSideResidual, 26)
				}
			}
		},
		{
			Condition.LIGHT_SCREEN,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						if (((DurationCallbackParams)p).source.HeldItem == Item.LIGHT_CLAY) {
							return (u8)8;
						}
						return (u8)5;
					}, 0)
				},
				{
					Callback.OnModifyDamage,
					(Condition_LightScreen_OnModifyDamage, 0)
				},
				{
					Callback.OnSideResidual,
					(Condition_LightScreen_OnSideResidual, 26)
				}
			}
		},
		{
			Condition.AURORA_VEIL,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => {
						if (((DurationCallbackParams)p).source.HeldItem == Item.LIGHT_CLAY) {
							return (u8)8;
						}
						return (u8)5;
					}, 0)
				},
				{
					Callback.OnModifyDamage,
					(Condition_AuroraVeil_OnModifyDamage, 0)
				},
				{
					Callback.OnSideResidual,
					(Condition_AuroraVeil_OnSideResidual, 26)
				}
			}
		},

		{
			Condition.TAILWIND,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => { return (u8)5; }, 0)
				},
				{
					Callback.OnModifySpd,
					(Condition_Tailwind_OnModifySpd, 0)
				},
				{
					Callback.OnSideResidual,
					(Condition_Tailwind_OnSideResidual, 26)
				}
			}
		},
		{
			Condition.SAFEGUARD,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => { return (u8)5; }, 0)
				},
				{
					Callback.OnTryAddNonVolatile,
					(Condition_Safeguard_OnTryAddNonVolatile, 0)
				},
				{
					Callback.OnSideResidual,
					(Condition_SafeGuard_OnSideResidual, 25)
				}
			}
		},
		{
			Condition.MIST,
			new Dictionary<Callback, (BattleEvent callback, sbyte priority)>() {
				{
					Callback.DurationCallback,
					((object p) => { return (u8)5; }, 0)
				},
				{
					Callback.OnTryChangeStat,
					(Condition_Mist_OnTryChangeStat, 0)
				},
				{
					Callback.OnSideResidual,
					(Condition_Mist_OnSideResidual, 26)
				}
			}
		}
		
		};
	}

	public class FieldCondition : ISerializable<FieldCondition> {
		public Buffer Write() {
			Buffer buffer = new Buffer();

			buffer.AddValue((u16)Condition);
			buffer.AddValue(AffectsWholeField);
			buffer.AddValue(AffectedSide);
			buffer.AddValue(Infinite);
			buffer.AddValue(DurationRemaining);

			return buffer;
		}
		public static FieldCondition Load(Buffer data) {
			return new FieldCondition(
				(Condition)data.Read16(),
				data.ReadBool(),
				data.Read8(),
				data.ReadBool(),
				data.Read8()
			);
		}

		public FieldCondition(Condition condition, bool affectsWholeField, u8 affectedSide, bool infinite, u8 durationRemaining) {
			this.Condition = condition;
			this.AffectsWholeField = affectsWholeField;
			this.AffectedSide = affectsWholeField ? u8.MaxValue : affectedSide;
			this.Infinite = infinite;
			this.DurationRemaining = infinite ? u8.MaxValue : durationRemaining;
		}
		public FieldCondition(Condition condition, u8 affectedSide, u8 durationRemaining) {
			this.Condition = condition;
			this.AffectsWholeField = false;
			this.AffectedSide = affectedSide;
			this.Infinite = false;
			this.DurationRemaining = durationRemaining;
		}
		public FieldCondition(Condition condition) {
			this.Condition = condition;
			this.AffectsWholeField = true;
			this.AffectedSide = u8.MaxValue;
			this.Infinite = true;
			this.DurationRemaining = u8.MaxValue;
		}

		public Condition Condition { get; private set; }

		public bool AffectsWholeField { get; private set; }
		public u8 AffectedSide { get; private set; }

		public bool Infinite { get; private set; }
		public u8 DurationRemaining { get; private set; }

		public void DecrementDuration() {
			if (!Infinite && DurationRemaining > 0) {
				DurationRemaining--;
			}
		}

		public void ClearWeatherTerrain() {
			if (Condition >= Condition.WEATHER_NONE && Condition <= Condition.WEATHER_SHADOWY_AURA) {
				Condition = Condition.WEATHER_NONE;
			}
			else if (Condition >= Condition.TERRAIN_NONE && Condition <= Condition.TERRAIN_PSYCHIC) {
				Condition = Condition.TERRAIN_NONE;
			}
			else {
				throw new System.Exception();
			}
		}
		public void SetWeatherTerrain(Condition wt, u8 duration) {
			if (
				(wt >= Condition.WEATHER_HARSH_SUNLIGHT && wt <= Condition.WEATHER_SHADOWY_AURA) ||
				(wt >= Condition.TERRAIN_ELECTRIC && wt <= Condition.TERRAIN_PSYCHIC)
			) {
				Condition = wt;
				DurationRemaining = duration;
			}
			else {
				throw new System.ArgumentException();
			}
		}

		public bool IsActive() {
			return Infinite || DurationRemaining > 0;
		}

		public bool Equals(FieldCondition obj) {
			return this.Condition == obj.Condition;
		}
		public bool Equals(Condition obj) {
			return this.Condition == obj;
		}
	}

	public enum Condition {
		// Weather
		WEATHER_NONE,
		WEATHER_HARSH_SUNLIGHT,
		WEATHER_RAIN,
		WEATHER_SANDSTORM,
		WEATHER_HAIL,
		WEATHER_SNOW,
		WEATHER_FOG,
		WEATHER_EXTREME_SUNLIGHT,
		WEATHER_HEAVY_RAIN,
		WEATHER_STRONG_WIND,
		WEATHER_SHADOWY_AURA, // unused

		// Terrain
		TERRAIN_NONE,
		TERRAIN_ELECTRIC,
		TERRAIN_GRASSY,
		TERRAIN_MISTY,
		TERRAIN_PSYCHIC,

		// Field Modifiers
		GRAVITY,
		WATER_SPORT,
		MUD_SPORT,

		// Hazards
		SPIKES1,
		SPIKES2,
		SPIKES3,
		POISON_SPIKES,
		TOXIC_SPIKES,
		STICKY_WEB,
		SHARP_STEEL,
		POINTED_STONES,

		// Buffs
		TAILWIND,
		REFLECT,
		LIGHT_SCREEN,
		AURORA_VEIL,
		SAFEGUARD,
		MIST,
	}
}