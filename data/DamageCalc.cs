using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.Types;
using static PkmnEngine.BattleMoves;

namespace PkmnEngine {
	public static class DamageCalc {
		public readonly struct Mods {
			public Mods(MoveEffectParams p, float critChance) {
				isCrit = p.battle.rand.NextDouble() < critChance;
				typeEff = TypeEffectiveness(p.target, p.move.moveType);
				if ((p.state.Weather.Condition == Condition.WEATHER_STRONG_WIND) && typeEff >= EFF_NORMAL && p.target.HasType(Type.FLYING)) {
					//MessageBox(lang::GetBattleMessage(BATTLE_MESSAGE_WIND_WEAKENED_ATTACK));
					typeEff = EFF_NORMAL;
				}
				stab = STAB(p.attacker, p.move.moveType);
			}
			public Mods() {
				isCrit = false;
				typeEff = 1;
				stab = 1;
			}

			public readonly bool isCrit;
			public readonly float typeEff;
			public readonly float stab;
		}
		public class Overrides {
			public Overrides(u16 atk, u16 def, u16 power, u16 damage) {
				this.atk = atk;
				this.def = def;
				this.power = power;
				this.damage = damage;
			}

			public u16 atk;
			public u16 def;
			public u16 power;
			public u16 damage;
		}

		public const float SAME_TYPE_ATTACK_BONUS = 1.5f;

		public static u16 CalcDamage(MoveEffectParams p, Mods mods, Overrides overrides = null) {
			return CalcDamage(p.battle, p.state, p.attacker, p.target, p.moveID, p.numTargets, mods, overrides);
		}
		/// <summary>
		/// Calculates damage taken.
		/// https://bulbapedia.bulbagarden.net/wiki/Damage#Generation_V_onward
		/// </summary>
		/// <param name="battle">Battle object.</param>
		/// <param name="state">The current BattleState.</param>
		/// <param name="attacker">Attacking mon.</param>
		/// <param name="defender">Defending mon.</param>
		/// <param name="moveID">ID of the move being used.</param>
		/// <param name="numTargets">The number of targets being hit by the move.</param>
		/// <param name="crit">If the move lands a critical hit.</param>
		/// <param name="overrides">Contains values to use instead of the default attack, defense, and power. Leave as null or 0's to use defaults.</param>
		/// <returns>Damage the defending mon would take.</returns>
		public static u16 CalcDamage(
			Battle battle,
			BattleState state, 
			BattleMon attacker, 
			BattleMon defender,
			BattleMoveID moveID,
			u8 numTargets,
			Mods mods,
			Overrides overrides = null
		) {
			if (overrides != null && overrides.damage > 0) {
				return overrides.damage;
			}

			BattleMove move = gBattleMoves(moveID);

			// TODO: https://bulbapedia.bulbagarden.net/wiki/Power#Generation_IX
			u16 effPower = (overrides == null || overrides.power == 0) ? move.power : overrides.power;

			u16 statAtk = move.moveCat == MoveCategory.PHYSICAL ? attacker.EffAtk(state) : attacker.EffSpAtk(state);
			u16 statDef = move.moveCat == MoveCategory.PHYSICAL ? defender.EffDef(state) : defender.EffSpDef(state);
			if (overrides != null && overrides.atk > 0) {
				statAtk = overrides.atk;
			}
			if (overrides != null && overrides.def > 0) {
				statDef = overrides.def;
			}

			// Calculate unmodified damage.
			u16 damage = (u16)((2 * attacker.Mon.level / 5.0f + 2) * effPower * ((float)statAtk / statDef) / 50.0f + 2);
			// Factor in number of targets.
			damage = (u16)(damage * (numTargets > 1 ? 0.75f : 1));
			// TODO: PB
			// TODO: GlaiveRush
			// Critical hits are determined in the move_effects.hpp function.
			// TODO: crits ignore certain stat changes
			damage =  (u16)(damage * (mods.isCrit ? 1.5f : 1));
			// STAB is determined in move_effects.hpp.
			damage = (u16)(damage * mods.stab);
			// Type effectiveness
			damage = (u16)(damage * mods.typeEff);

			// Random.
			damage = (u16)(damage * (battle.rand.NextDouble() * 0.15f + 0.85f));

			// Other
			damage = (u16)(damage * Other(state, attacker, defender, moveID, mods.isCrit, mods.typeEff > EFF_NORMAL));

			// Offset burn atk loss for Facade.
			if (moveID == BattleMoveID.FACADE && attacker.HasStatus(Status.BURN)) {
				damage = (u16)(damage / StatusEffects.BURN_ATTACK_MULTIPLIER);
			}

			if (move.moveCat == MoveCategory.PHYSICAL) {
				foreach (float f in Battle.RunEvent<float>(Callback.OnModifyAtk, attacker, new OnModifyAtkParams(attacker))) {
					damage = (u16)(damage * f);
				}
				foreach (float f in Battle.RunEvent<float>(Callback.OnSourceModifyAtk, defender, new OnSourceModifyAtkParams(move))) {
					damage = (u16)(damage * f);
				}
			}
			if (move.moveCat == MoveCategory.SPECIAL) {
				foreach (float f in Battle.RunEvent<float>(Callback.OnModifySpAtk, attacker, new OnModifySpAtkParams(attacker))) {
					damage = (u16)(damage * f);
				}
				foreach (float f in Battle.RunEvent<float>(Callback.OnSourceModifySpAtk, defender, new OnSourceModifySpAtkParams(move))) {
					damage = (u16)(damage * f);
				}
			}

			// Charge
			if (move.moveType == Type.ELECTRIC && attacker.HasStatus(Status.CHARGED)) {
				damage *= 2;
				attacker.RemoveStatus(Status.CHARGED);
			}

			// Tar Shot
			if (defender.HasStatus(Status.TAR_SHOT)) {
				damage *= 2;
			}

			// Weather
			if (state.Weather.Condition == Condition.WEATHER_HARSH_SUNLIGHT) {
				if (move.moveType == Type.FIRE || moveID == BattleMoveID.HYDRO_STEAM) {
					damage = (u16)(damage * FieldConditions.WEATHER_DAMAGE_BOOST);
				}
				else if (move.moveType == Type.WATER) {
					damage = (u16)(damage * FieldConditions.WEATHER_DAMAGE_REDUCTION);
				}
			}
			else if (state.Weather.Condition == Condition.WEATHER_RAIN) {
				if (move.moveType == Type.FIRE) {
					damage = (u16)(damage * FieldConditions.WEATHER_DAMAGE_REDUCTION);
				}
				else if (move.moveType == Type.WATER) {
					damage = (u16)(damage * FieldConditions.WEATHER_DAMAGE_BOOST);
				}
			}

			// Water Sport
			if (state.FieldHasCondition(Condition.WATER_SPORT) && (move.moveType == Type.FIRE)) {
				damage = (u16)(damage * FieldConditions.WATER_SPORT_MULTIPLIER);
			}
			// Mud Sport
			if (state.FieldHasCondition(Condition.MUD_SPORT) && (move.moveType == Type.ELECTRIC)) {
				damage = (u16)(damage * FieldConditions.MUD_SPORT_MULTIPLIER);
			}

			// Terrain
			if (attacker.IsGrounded(state)) {
				// Increases the power of Electric-type moves used by Pokémon on the ground by 30%.
				if ((state.Terrain.Condition == Condition.TERRAIN_ELECTRIC) && move.moveType == Type.ELECTRIC) {
					damage = (u16)(damage * FieldConditions.TERRAIN_DAMAGE_BOOST);
				}
				else if (state.Terrain.Condition == Condition.TERRAIN_GRASSY) {
					// Increases the power of Grass-type moves used by Pokémon on the ground by 30%.
					if (move.moveType == Type.GRASS) {
						damage = (u16)(damage * FieldConditions.TERRAIN_DAMAGE_BOOST);
					}
				}
				// Increases the power of Psychic-type moves used by Pokémon on the ground by 30%.
				else if (state.Terrain.Condition == Condition.TERRAIN_PSYCHIC && move.moveType == Type.PSYCHIC) {
					damage = (u16)(damage * FieldConditions.TERRAIN_DAMAGE_BOOST);
				}
			}
			if (defender.IsGrounded(state)) {
				// Halves the damage taken by Pokémon on the ground from Dragon-type moves.
				if ((state.Terrain.Condition == Condition.TERRAIN_MISTY) && move.moveType == Type.DRAGON) {
					damage = (u16)(damage * FieldConditions.TERRAIN_DAMAGE_REDUCTION);
				}
				// Halves the power of Bulldoze, Earthquake, and Magnitude.
				if (moveID == BattleMoveID.BULLDOZE || moveID == BattleMoveID.EARTHQUAKE || moveID == BattleMoveID.MAGNITUDE) {
					damage = (u16)(damage * FieldConditions.TERRAIN_DAMAGE_REDUCTION);
				}
			}

			return damage;
		}

		// TODO: These multipliers are listed under the damage calc formula linked above.
		private static float Other(
			BattleState state,
			BattleMon attacker,
			BattleMon target,
			BattleMoveID moveID,
			bool isCrit,
			bool isSuperEffective
		) {
			float mult = 1;

			// TODO: Minimize

			// Earthquake and Magnitude
			if (
				(moveID == BattleMoveID.EARTHQUAKE || moveID == BattleMoveID.MAGNITUDE) &&
				target.HasStatus(Status.SEMI_INVULNERABLE_TURN) && 
				target.GetStatusParam(StatusParam.SEMI_INVULNERABLE) == StatusEffects.SEMI_INVULNERABLE_GROUND
			) {
				mult *= 2;
			}
			// Whirlpool and Surf
			if (
				(moveID == BattleMoveID.WHIRLPOOL || moveID == BattleMoveID.SURF) &&
				target.HasStatus(Status.SEMI_INVULNERABLE_TURN) &&
				target.GetStatusParam(StatusParam.SEMI_INVULNERABLE) == StatusEffects.SEMI_INVULNERABLE_WATER
			) {
				mult *= 2;
			}

			// Reflect, Light Screen, and Aurora Veil
			if (
				((gBattleMoves(moveID).moveCat == MoveCategory.PHYSICAL && state.SideHasCondition(target.Side, Condition.REFLECT)) ||
				(gBattleMoves(moveID).moveCat == MoveCategory.SPECIAL && state.SideHasCondition(target.Side, Condition.LIGHT_SCREEN)) ||
				state.SideHasCondition(target.Side, Condition.AURORA_VEIL)) &&
				!isCrit
			) {
				mult *= 0.5f;
			}

			// Collision Course and Electro Drift
			if (
				(moveID == BattleMoveID.COLLISION_COURSE || moveID == BattleMoveID.ELECTRO_DRIFT) &&
				isSuperEffective
			) {
				mult *= 1.33f;
			}

			// TODO: Multiscale and Shadow Shield
			// TODO: Fluffy
			// TODO: Punk Rock
			// TODO: Ice Scales
			// TODO: Friend Guard
			// TODO: Filter, Prism Armor, and Solid Rock
			// TODO: Neuroforce
			// TODO: Sniper
			// TODO: Tinted Lens
			
			// TODO: Type-resist Berries

			// Expert Belt
			if (isSuperEffective && attacker.HeldItem == Item.EXPERT_BELT) {
				mult *= 1.2f;
			}
			// Life Orb
			if (attacker.HeldItem == Item.LIFE_ORB) {
				mult *= 1.3f;
			}

			// TODO: Metronome???

			return mult;
		} 

		// Same Type Attack Bonus
		public static float STAB(BattleMon attacker, Type moveType) {
			float stab = 1;
			if (attacker.HasType(moveType)) {
				stab = SAME_TYPE_ATTACK_BONUS;
			}
			float[] mods = Battle.RunEvent<float>(Callback.OnModifyStab, attacker, new OnModifyStabParams(attacker, moveType));
			if (mods.Length != 0) {
				stab = 1;
				foreach (float mod in mods) {
					stab *= mod;
				}
			}
			return stab;
		}
		/// <summary>
		/// Calculates raw type chart.
		/// </summary>
		/// <param name="defender">Mon being attacked.</param>
		/// <param name="moveType">The type of the move being used.</param>
		/// <returns></returns>
		public static float TypeEffectiveness(BattleMon defender, Type moveType) {
			float multiplier = EFF_NORMAL;
			for (u8 i = 0; i < defender.types.Count; i++) {
				multiplier *= gTypeEffectivenessMult(moveType, defender.types[i]);
			}
			return multiplier;
		}
		/// <summary>
		/// Calculates type effectiveness, including exceptions for: Struggle, Future Sight, Beat Up, and Doom Desire.
		/// </summary>
		/// <param name="defender">Mon being attacked.</param>
		/// <param name="moveID">ID of the move being used.</param>
		/// <returns></returns>
		public static float TypeEffectiveness(BattleMon defender, BattleMoveID moveID) {
			// If the used move is Struggle, Future Sight, Beat Up, or Doom Desire, type is always 1.
			if (
				moveID == BattleMoveID.STRUGGLE || 
				moveID == BattleMoveID.FUTURE_SIGHT || 
				moveID == BattleMoveID.BEAT_UP || 
				moveID == BattleMoveID.DOOM_DESIRE
			) {
				return EFF_NORMAL;
			}
			// Otherwise, compute the multiplier.
			float multiplier = EFF_NORMAL;
			for (u8 i = 0; i < defender.types.Count; i++) {
				multiplier *= gTypeEffectivenessMult(gBattleMoves(moveID).moveType, defender.types[i]);
			}
			return multiplier;
		}

		//TODO: https://bulbapedia.bulbagarden.net/wiki/Accuracy#Generation_V_onward
		public static float CalculateHitChance(BattleState state, BattleMon attacker, BattleMon defender, BattleMoveID moveID) {
			// An accuracy of 0 kinda unofficially means the move will always hit.
			// It's only used for self-targeting status moves, really, and those don't miss.
			if (gBattleMoves(moveID).accuracy == 0) {
				return 1;
			}

			// TODO: modifiers not considered
			float modifier = 1;
			sbyte accuracy = attacker.AccuracyStages;
			sbyte evasion = defender.EvasivenessStages;

			if ((gBattleMoves(moveID).flags & BattleMoves.Flag.CHIP_AWAY) != 0) {
				evasion = 0;
			}

			u8 stage = (u8)System.Math.Clamp(accuracy - evasion, MIN_STAT_STAGE, MAX_STAT_STAGE);
			float stageMultiplier = stage >= 0 ? (3.0f + stage) / 3.0f : 3.0f / (3.0f - stage);
			// TODO: Micle berry??
			float micleBerry = 1;

			return (gBattleMoves(moveID).accuracy / 100.0f) * stageMultiplier * modifier * micleBerry;
		}

		public static float GetEffectiveStatMultiplier(sbyte stage, Stat status_stat) {
			u8 baseMult = 0;

			switch (status_stat) {
				case Stat.ATTACK:
				case Stat.DEFENSE:
				case Stat.SPECIAL_ATTACK:
				case Stat.SPECIAL_DEFENSE:
				case Stat.SPEED:
					baseMult = 2;
					break;
				case Stat.ACCURACY:
				case Stat.EVASION:
					baseMult = 3;
					break;
			}

			stage = System.Math.Clamp(stage, MIN_STAT_STAGE, MAX_STAT_STAGE);

			u8 num = (u8)(baseMult + stage * (stage >= 0 ? 1 : 0));
			u8 den = (u8)(baseMult - stage * (stage <= 0 ? 1 : 0));

			return (float)num / den;
		}

		public static float GetEffectiveCritRate(sbyte stages) {
			return System.Math.Clamp(stages, MIN_STAT_STAGE, MAX_STAT_STAGE) switch
			{
				-6 or -5 or -4 or -3 or -2 or -1 => 0,
				1 => 0.125f,
				2 => 0.5f,
				3 => 1,
				_ => 0.0417f,
			};
		}
	}
}