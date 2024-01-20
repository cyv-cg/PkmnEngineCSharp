using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.Types;
using System;

namespace PkmnEngine {
	public static class DamageCalc {
		//u8 STAB(struct BattleMon *attacker, u8 moveType);
		//float TypeEffectiveness(struct BattleMon *defender, u8 moveType);
		//float CalculateHitChance(struct BattleState *state, struct BattleMon *attacker, struct BattleMon *defender, u8 attackerMoveAccuracy, u32 flags);

		//float GetEffectiveStatMultiplier(struct BattleMon *bm, u16 status_stat);
		//u16 GetEffectiveMaxHP(struct BattleState *state, struct BattleMon *bm);
		//u16 GetEffectiveHP(struct BattleState *state, struct BattleMon *bm);
		//u16 GetEffectiveAtk(struct BattleState *state, struct BattleMon *bm);
		//u16 GetEffectiveDef(struct BattleState *state, struct BattleMon *bm, u8 side);
		//u16 GetEffectiveSpAtk(struct BattleState *state, struct BattleMon *bm);
		//u16 GetEffectiveSpDef(struct BattleState *state, struct BattleMon *bm, u8 side);
		//u16 GetEffectiveSpd(struct BattleState *state, struct BattleMon *bm, u8 side);
		//float GetEffectiveCritRate(struct BattleMon *bm, int8_t stages = 0);
		//int8_t GetAttackStage(struct BattleMon *bm);
		//int8_t GetDefenseStage(struct BattleMon *bm);
		//int8_t GetSpecialAttackStage(struct BattleMon *bm);
		//int8_t GetSpecialDefenseStage(struct BattleMon *bm);
		//int8_t GetSpeedStage(struct BattleMon *bm);
		//int8_t GetAccuracyStage(struct BattleMon *bm);
		//int8_t GetEvasionStage(struct BattleMon *bm);
		//int8_t GetCritRateStage(struct BattleMon *bm, int8_t stages = 0);

		//// attacker - Attacking pokemon.
		//// defender - Defending pokemon.
		//// move - The move being used.
		//// targets - The number of pokemon being targeted by the move.
		//// state - The current battle state.
		//// other - An additional multiplier.
		//// statAtk - Attacker's effective attack stat value. Leave as 0 to use move default.
		//// statDef - Defender's effective defense stat value. Leave as 0 to use move default.
		//// powerOverride - Use this to set a power. Leave at 0 to use the move's default.
		//// https://bulbapedia.bulbagarden.net/wiki/Damage#Generation_V_onward
		//u16 CalcDamage(
		//	struct BattleMon *attacker, 
		//	struct BattleMon *defender,
		//	u8 sideAttacker,
		//	u8 sideDefender,
		//	const struct BattleMove *move, 
		//	u8 targets, 
		//	struct BattleState *state, 
		//	bool b_crit,
		//	u8 stab,
		//	float typeEff,
		//	float other = 1, 
		//	u16 statAtk = 0, 
		//	u16 statDef = 0,
		//	u16 powerOverride = 0,
		//	bool b_facade = false
		//) {
		//	// TODO: https://bulbapedia.bulbagarden.net/wiki/Power#Generation_IX
		//	u16 effPower = powerOverride == 0 ? move->power : powerOverride;

		//	if (statAtk == 0) {
		//		statAtk = move->moveCat == CAT_PHYSICAL ? GetEffectiveAtk(state, attacker) : GetEffectiveSpAtk(state, attacker);
		//	}
		//	if (statDef == 0) {
		//		statDef = move->moveCat == CAT_PHYSICAL ? GetEffectiveDef(state, defender, sideDefender) : GetEffectiveSpDef(state, defender, sideDefender);
		//	}

		//	// Calculate unmodified damage.
		//	u16 damage = (((2 * attacker->mon->level) / 5.0 + 2) * effPower * ((float)statAtk / statDef)) / 50.0 + 2;
		//	// Factor in number of targets.
		//	damage *= targets > 1 ? 0.75 : 1;
		//	// TODO: PB
		//	// TODO: Weather
		//	// TODO: GlaiveRush
		//	// Critical hits are determined in the move_effects.hpp function.
		//	// TODO: crits ignore certain stat changes
		//	damage *= b_crit ? 1.5 : 1;
		//	// STAB is determined in move_effects.hpp.
		//	damage *= stab;

		//	if ((state->fieldCondition & WEATHER_STRONG_WIND) && (typeEff >= EFF_NORMAL && b_BattleMonHasType(defender, TYPE_FLYING))) {
		//		//MessageBox(lang::GetBattleMessage(BATTLE_MESSAGE_WIND_WEAKENED_ATTACK));
		//		typeEff = EFF_NORMAL;
		//	}
		//	// Type is determined in move_effects.hpp.
		//	damage *= typeEff;

		//	// Random.
		//	damage *= Random01() * 0.15 + 0.85;

		//	// Other
		//	damage *= other;


		//	// Offset burn atk loss for Facade.
		//	if (b_facade && (attacker->status & STATUS_BURN) != 0) {
		//		damage /= BURN_ATTACK_MULTIPLIER;
		//	}
		//	// Guts ability
		//	else if (b_AbilityProc(state, attacker, ABILITY_GUTS, false) && (attacker->status & STATUS_MASK_NON_VOLATILE) != 0) {
		//		damage *= 1.5;
		//		// Offset the atk loss from burn for physical moves.
		//		if (move->moveCat == CAT_PHYSICAL && (attacker->status & STATUS_BURN) != 0) {
		//			damage /= BURN_ATTACK_MULTIPLIER;
		//		}
		//	}

		//	// Charge
		//	if (move->moveType == TYPE_ELECTRIC && (attacker->status & STATUS_CHARGED) != 0) {
		//		damage *= 2;
		//		attacker->status &= ~STATUS_CHARGED;
		//	}

		//	// Heatproof (https://bulbapedia.bulbagarden.net/wiki/Heatproof_(Ability))
		//	if (move->moveType == TYPE_FIRE && b_AbilityProc(state, defender, ABILITY_HEATPROOF, false)) {
		//		damage /= 2;
		//	}

		//	// Tar Shot
		//	if ((defender->status & STATUS_TAR_SHOT) != 0) {
		//		damage *= 2;
		//	}

		//	// Weather
		//	if (state->fieldCondition & WEATHER_HARSH_SUNLIGHT) {
		//		if (move->moveType == TYPE_FIRE) {
		//			damage *= WEATHER_DAMAGE_BOOST;
		//		}
		//		else if (move->moveType == TYPE_WATER) {
		//			damage *= WEATHER_DAMAGE_REDUCTION;
		//		}
		//	}
		//	else if (state->fieldCondition & WEATHER_RAIN) {
		//		if (move->moveType == TYPE_FIRE) {
		//			damage *= WEATHER_DAMAGE_REDUCTION;
		//		}
		//		else if (move->moveType == TYPE_WATER) {
		//			damage *= WEATHER_DAMAGE_BOOST;
		//		}
		//	}

		//	// Water Sport
		//	if ((state->fieldCondition & CONDITION_WATER_SPORT) && (move->moveType == TYPE_FIRE)) {
		//		damage *= WATER_SPORT_REDUCTION;
		//	}
		//	// Mud Sport
		//	if ((state->fieldCondition & CONDITION_MUD_SPORT) && (move->moveType == TYPE_ELECTRIC)) {
		//		damage *= WATER_SPORT_REDUCTION;
		//	}

		//	// Terrain
		//	if (b_MonIsGrounded(state, attacker)) {
		//		// Increases the power of Electric-type moves used by Pokémon on the ground by 30%.
		//		if ((state->fieldCondition & TERRAIN_ELECTRIC) && move->moveType == TYPE_ELECTRIC) {
		//			damage *= TERRAIN_DAMAGE_BOOST;
		//		}
		//		else if (state->fieldCondition & TERRAIN_GRASSY) {
		//			// Increases the power of Grass-type moves used by Pokémon on the ground by 30%.
		//			if (move->moveType == TYPE_GRASS) {
		//				damage *= TERRAIN_DAMAGE_BOOST;
		//			}
		//			// Halves the power of Bulldoze, Earthquake, and Magnitude.
		//			if (move->flags & FLAG_HITS_SEMI_INVUL_GROUND) {
		//				damage *= TERRAIN_DAMAGE_REDUCTION;
		//			}
		//		}
		//		// Increases the power of Psychic-type moves used by Pokémon on the ground by 30%.
		//		else if ((state->fieldCondition & TERRAIN_PSYCHIC) && move->moveType == TYPE_PSYCHIC) {
		//			damage *= TERRAIN_DAMAGE_BOOST;
		//		}
		//	}
		//	if (b_MonIsGrounded(state, defender)) {
		//		// Halves the damage taken by Pokémon on the ground from Dragon-type moves.
		//		if ((state->fieldCondition & TERRAIN_MISTY) && move->moveType == TYPE_DRAGON) {
		//			damage *= TERRAIN_DAMAGE_REDUCTION;
		//		}
		//	}

		//	return damage;
		//}

		//// Same Type Attack Bonus
		//public static u8 STAB(BattleMon attacker, u8 moveType) {
		//	return (attacker.HasType b_BattleMonHasType(attacker, moveType)) ? 2 : 1;
		//}
		/// <summary>
		/// Calculates type chart.
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

		// https://bulbapedia.bulbagarden.net/wiki/Accuracy#Generation_V_onward
		public static float CalculateHitChance(BattleState state, BattleMon attacker, BattleMon defender, u8 attackerMoveAccuracy, u32 flags) {
			// An accuracy of 0 kinda unofficially means the move will always hit.
			// It's only used for self-targeting status moves, really, and those don't miss.
			if (attackerMoveAccuracy == 0) {
				return 1;
			}

			// TODO: modifiers not considered
			float modifier = 1;
			sbyte accuracy = attacker.AccuracyStages;
			sbyte evasion = defender.EvasivenessStages;

			if ((flags & BattleMoves.FLAG_CHIP_AWAY) != 0) {
				evasion = 0;
			}

			u8 stage = (u8)Math.Clamp(accuracy - evasion, MIN_STAT_STAGE, MAX_STAT_STAGE);
			float stageMultiplier = stage >= 0 ? (3.0f + stage) / 3.0f : 3.0f / (3.0f - stage);
			// TODO: Micle berry??
			float micleBerry = 1;

			return (attackerMoveAccuracy / 100.0f) * stageMultiplier * modifier * micleBerry;
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

			stage = Math.Clamp(stage, MIN_STAT_STAGE, MAX_STAT_STAGE);

			u8 num = (u8)(baseMult + stage * (stage >= 0 ? 1 : 0));
			u8 den = (u8)(baseMult - stage * (stage <= 0 ? 1 : 0));

			return (float)num / den;
		}

		//u16 GetEffectiveMaxHP(struct BattleState *state, struct BattleMon *bm)
		//{
		//	return bm->maxHp;
		//}
		//u16 GetEffectiveHP(struct BattleState *state, struct BattleMon *bm)
		//{
		//	return bm->hp;
		//}
		//u16 GetEffectiveAtk(struct BattleState *state, struct BattleMon *bm)
		//{
		//	u16 atk = bm->atk * GetEffectiveStatMultiplier(bm, DEF_STATUS_EFF_IDS::STATUS_ATTACK);

		//	if ((bm->status & STATUS_BURN) != 0) {
		//		atk *= BURN_ATTACK_MULTIPLIER;
		//	}

		//	return atk;
		//}
		//u16 GetEffectiveDef(struct BattleState *state, struct BattleMon *bm, u8 side)
		//{
		//	u16 def = bm->def * GetEffectiveStatMultiplier(bm, DEF_STATUS_EFF_IDS::STATUS_DEFENSE);

		//	if ((state->fieldCondition & WEATHER_SNOW) && b_BattleMonHasType(bm, TYPE_ICE)) {
		//		def *= SNOW_DEF_BOOST;
		//	}

		//	if (side == SIDE_PLAYER && (state->fieldCondition & (CONDITION_1_REFLECT | CONDITION_1_AURORA_VEIL))) {
		//		def *= 2;
		//	}
		//	else if (side == SIDE_OPPONENT && (state->fieldCondition & (CONDITION_2_REFLECT | CONDITION_2_AURORA_VEIL))) {
		//		def *= 2;
		//	}

		//	return def;
		//}
		//u16 GetEffectiveSpAtk(struct BattleState *state, struct BattleMon *bm)
		//{
		//	return bm->spAtk * GetEffectiveStatMultiplier(bm, DEF_STATUS_EFF_IDS::STATUS_SPECIAL_ATTACK);
		//}
		//u16 GetEffectiveSpDef(struct BattleState *state, struct BattleMon *bm, u8 side)
		//{
		//	u16 spDef = bm->spDef * GetEffectiveStatMultiplier(bm, DEF_STATUS_EFF_IDS::STATUS_SPECIAL_DEFENSE);

		//	if (side == SIDE_PLAYER && (state->fieldCondition & (CONDITION_1_LIGHT_SCREEN | CONDITION_1_AURORA_VEIL))) {
		//		spDef *= 2;
		//	}
		//	else if (side == SIDE_OPPONENT && (state->fieldCondition & (CONDITION_2_LIGHT_SCREEN | CONDITION_2_AURORA_VEIL))) {
		//		spDef *= 2;
		//	}

		//	return spDef;
		//}
		//u16 GetEffectiveSpd(struct BattleState *state, struct BattleMon *bm, u8 side)
		//{
		//	u16 spd = bm->spd * GetEffectiveStatMultiplier(bm, DEF_STATUS_EFF_IDS::STATUS_SPEED);

		//	bool b_quickFeet = b_AbilityProc(state, bm, ABILITY_QUICK_FEET, false) && (bm->status & STATUS_MASK_NON_VOLATILE) != 0;
		//	if ((bm->status & STATUS_PARALYSIS) != 0 && !b_quickFeet) {
		//		spd *= PARALYSIS_SPEED_MULTIPLIER;
		//	}
		//	if (b_quickFeet) {
		//		spd /= PARALYSIS_SPEED_MULTIPLIER;
		//	}

		//	if (side == SIDE_PLAYER && (state->fieldCondition * CONDITION_1_TAILWIND)) {
		//		spd *= TAILWIND_SPEED_BOOST;
		//	}
		//	if (side == SIDE_OPPONENT && (state->fieldCondition * CONDITION_2_TAILWIND)) {
		//		spd *= TAILWIND_SPEED_BOOST;
		//	}

		//	return spd;
		//}
		//float GetEffectiveCritRate(struct BattleMon *bm, int8_t stages)
		//{
		//	switch (GetCritRateStage(bm, stages)) {
		//		case -6:
		//		case -5:
		//		case -4:
		//		case -3:
		//		case -2:
		//		case -1:
		//			return 0;
		//		case 1:
		//			return 0.125;
		//		case 2:
		//			return 0.5;
		//		case 3:
		//			return 1;
		//		case 0:
		//		default:
		//			return 0.0417;
		//	}
		//}

		//int8_t GetAttackStage(struct BattleMon *bm)
		//{
		//	u8 stage = ((bm->status & STATUS_ATTACK) >> DEF_STATUS_EFF_IDS::STATUS_ATTACK).to_ulong();
		//	return (stage & 0b0111) * ((stage & 0b1000) ? 1 : -1);
		//}
		//int8_t GetDefenseStage(struct BattleMon *bm)
		//{
		//	u8 stage = ((bm->status & STATUS_DEFENSE) >> DEF_STATUS_EFF_IDS::STATUS_DEFENSE).to_ulong();
		//	return (stage & 0b0111) * ((stage & 0b1000) ? 1 : -1);
		//}
		//int8_t GetSpecialAttackStage(struct BattleMon *bm)
		//{
		//	u8 stage = ((bm->status & STATUS_SPECIAL_ATTACK) >> DEF_STATUS_EFF_IDS::STATUS_SPECIAL_ATTACK).to_ulong();
		//	return (stage & 0b0111) * ((stage & 0b1000) ? 1 : -1);
		//}
		//int8_t GetSpecialDefenseStage(struct BattleMon *bm)
		//{
		//	u8 stage = ((bm->status & STATUS_SPECIAL_DEFENSE) >> DEF_STATUS_EFF_IDS::STATUS_SPECIAL_DEFENSE).to_ulong();
		//	return (stage & 0b0111) * ((stage & 0b1000) ? 1 : -1);
		//}
		//int8_t GetSpeedStage(struct BattleMon *bm)
		//{
		//	u8 stage = ((bm->status & STATUS_SPEED) >> DEF_STATUS_EFF_IDS::STATUS_SPEED).to_ulong();
		//	return (stage & 0b0111) * ((stage & 0b1000) ? 1 : -1);
		//}
		//int8_t GetAccuracyStage(struct BattleMon *bm)
		//{
		//	u8 stage = ((bm->status & STATUS_ACCURACY) >> DEF_STATUS_EFF_IDS::STATUS_ACCURACY).to_ulong();
		//	return (stage & 0b0111) * ((stage & 0b1000) ? 1 : -1);
		//}
		//int8_t GetEvasionStage(struct BattleMon *bm)
		//{
		//	u8 stage = ((bm->status & STATUS_EVASION) >> DEF_STATUS_EFF_IDS::STATUS_EVASION).to_ulong();
		//	return (stage & 0b0111) * ((stage & 0b1000) ? 1 : -1);
		//}
		//int8_t GetCritRateStage(struct BattleMon *bm, int8_t stages)
		//{
		//	return Clamp(stages, MIN_STAT_MODIFIER, MAX_STAT_MODIFIER);
		//}
	}
}