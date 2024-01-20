using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

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

		public bool Equals(FieldCondition obj) {
			return this.Condition == obj.Condition;
		}
		public bool Equals(Condition obj) {
			return this.Condition == obj;
		}
	}

	//// Weather effects. All mutually exclusive and timed.
	//public enum Weather {
	//	NONE,
	//	HARSH_SUNLIGHT,
	//	RAIN,
	//	SANDSTORM,
	//	HAIL,
	//	SNOW,
	//	FOG,
	//	EXTREME_SUNLIGHT,
	//	HEAVY_RAIN,
	//	STRONG_WIND,
	//	SHADOWY_AURA // unused
	//}

	//// Terrain effects. All mutually exclusive and also timed.
	//public enum Terrain {
	//	NONE,
	//	ELECTRIC,
	//	GRASSY,
	//	MISTY,
	//	PSYCHIC
	//}

	//public enum FieldModifier {
	//	GRAVITY				= 1 << 0,
	//	WATER_SPORT			= 1 << 1,
	//	MUD_SPORT			= 1 << 2,
	//}

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

	//public enum ConditionTurns {
	//	WEATHER,
	//	TERRAIN,
	//	WATER_SPORT,
	//	MUD_SPORT,
	//	TAILWIND,
	//	REFLECT,
	//	LIGHT_SCREEN,
	//	AURORA_VEIL,
	//	SAFEGUARD,
	//	MIST
	//};
}