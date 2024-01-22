using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.Strings.Lang;
using static PkmnEngine.StatusEffects;

using PkmnEngine.Strings;

namespace PkmnEngine {
	public static partial class MoveEffects {
		// The 16 right-most bits are reserved for other values.
		public const u32 FLAG_DAMAGE						= 1 << 16;
		public const u32 FLAG_CRIT_DAMAGE					= 1 << 17;
		public const u32 FLAG_SPE_DAMAGE					= 1 << 18;
		public const u32 FLAG_NVE_DAMAGE					= 1 << 19;
		public const u32 FLAG_TARGET_FAINTED				= 1 << 20;
		public const u32 FLAG_DO_NOT_DO_SECONDARY_EFFECT	= 1 << 21;
		public const u32 FLAG_SWITCH_TO_MON					= 1 << 22;
		public const u32 FLAG_STAT_DID_NOT_CHANGE			= 1 << 29;
		public const u32 FLAG_MOVE_FAILED					= 1 << 30;

		#region effects
		public static u32 Effect_Hit(MoveEffectParams p) {
			return Attack(p);
		}
		#region non_volatile_effects
		public static u32 Effect_Burn(MoveEffectParams p) {
			return GiveMonNonVolatileStatus(p.state, p.attacker, Status.BURN, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static u32 Effect_BurnHit(MoveEffectParams p) {
			return GiveMonNonVolatileStatus(p.state, p.target, Status.BURN, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static u32 Effect_CureBurn(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_CureBurnHit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Freeze(MoveEffectParams p) {
			return GiveMonNonVolatileStatus(p.state, p.attacker, Status.FREEZE, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static u32 Effect_FreezeHit(MoveEffectParams p) {
			return GiveMonNonVolatileStatus(p.state, p.target, Status.FREEZE, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));	
		}
		public static u32 Effect_Thaw(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ThawHit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Paralyze(MoveEffectParams p) {
			return GiveMonNonVolatileStatus(p.state, p.attacker, Status.PARALYSIS, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static u32 Effect_ParalyzeHit(MoveEffectParams p) {
			return GiveMonNonVolatileStatus(p.state, p.target, Status.PARALYSIS, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static u32 Effect_CureParalysis(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_CureParalysisHit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Poison(MoveEffectParams p) {
			return GiveMonNonVolatileStatus(p.state, p.attacker, Status.POISON, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static u32 Effect_PoisonHit(MoveEffectParams p) {
			return GiveMonNonVolatileStatus(p.state, p.target, Status.POISON, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static u32 Effect_Toxic(MoveEffectParams p) {
			return GiveMonNonVolatileStatus(p.state, p.attacker, Status.TOXIC, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static u32 Effect_ToxicHit(MoveEffectParams p) {
			return GiveMonNonVolatileStatus(p.state, p.target, Status.TOXIC, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static u32 Effect_CurePoison(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_CurePoisonHit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Sleep(MoveEffectParams p) {
			return GiveMonNonVolatileStatus(p.state, p.attacker, Status.SLEEP, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? GetRandSleepTurns() : p.i_flags & 0xFF));
		}
		public static u32 Effect_SleepHit(MoveEffectParams p) {
			return GiveMonNonVolatileStatus(p.state, p.target, Status.SLEEP, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? GetRandSleepTurns() : p.i_flags & 0xFF));
		}
		public static u32 Effect_WakeUp(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_WakeUpHit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Confuse(MoveEffectParams p) {
			if (p.attacker.HasStatus(Status.CONFUSION)) {
				MessageBox(GetBattleMessage(BattleMessage.MON_ALREADY_CONFUSED, p.attacker.GetName()));
				return FLAG_MOVE_FAILED;
			}
			else {
				p.attacker.GiveStatus(Status.CONFUSION);
				MessageBox(GetBattleMessage(BattleMessage.MON_WAS_CONFUSED, p.attacker.GetName()));
			}
			return 0;
		}
		public static u32 Effect_ConfuseHit(MoveEffectParams p) {
			if (p.target.HasStatus(Status.CONFUSION)) {
				MessageBox(GetBattleMessage(BattleMessage.MON_ALREADY_CONFUSED, p.target.GetName()));
				return FLAG_MOVE_FAILED;
			}
			else {
				p.target.GiveStatus(Status.CONFUSION);
				MessageBox(GetBattleMessage(BattleMessage.MON_WAS_CONFUSED, p.target.GetName()));
			}
			return 0;
		}
		public static u32 Effect_CureNonVolatileStatusHit(MoveEffectParams p) {
			return 0;
		}
		#endregion
		#region stat_changes
		public static u32 Effect_AttackUp(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, 1, Stat.ATTACK);
		}
		public static u32 Effect_AttackUp2(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, 2, Stat.ATTACK);
		}
		public static u32 Effect_AttackDown(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, -1, Stat.ATTACK);
		}
		public static u32 Effect_AttackDown2(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, -2, Stat.ATTACK);
		}
		public static u32 Effect_AttackUpHit(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, 1, Stat.ATTACK);
		}
		public static u32 Effect_AttackUpHit2(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, 2, Stat.ATTACK);
		}
		public static u32 Effect_AttackDownHit(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, -1, Stat.ATTACK);
		}
		public static u32 Effect_AttackDownHit2(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, -2, Stat.ATTACK);
		}
		public static u32 Effect_DefenseUp(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, 1, Stat.DEFENSE);
		}
		public static u32 Effect_DefenseUp2(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, 2, Stat.DEFENSE);
		}
		public static u32 Effect_DefenseUp3(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, 3, Stat.DEFENSE);
		}
		public static u32 Effect_DefenseDown(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, -1, Stat.DEFENSE);
		}
		public static u32 Effect_DefenseDown2(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, -2, Stat.DEFENSE);
		}
		public static u32 Effect_DefenseUpHit(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, 1, Stat.DEFENSE);
		}
		public static u32 Effect_DefenseUpHit2(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, 2, Stat.DEFENSE);
		}
		public static u32 Effect_DefenseDownHit(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, -1, Stat.DEFENSE);
		}
		public static u32 Effect_DefenseDownHit2(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, -2, Stat.DEFENSE);
		}
		public static u32 Effect_SpecialAttackUp(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, 1, Stat.SPECIAL_ATTACK);
		}
		public static u32 Effect_SpecialAttackUp2(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, 2, Stat.SPECIAL_ATTACK);
		}
		public static u32 Effect_SpecialAttackDown(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, -1, Stat.SPECIAL_ATTACK);
		}
		public static u32 Effect_SpecialAttackDown2(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, -2, Stat.SPECIAL_ATTACK);
		}
		public static u32 Effect_SpecialAttackUpHit(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, 1, Stat.SPECIAL_ATTACK);
		}
		public static u32 Effect_SpecialAttackUpHit2(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, 2, Stat.SPECIAL_ATTACK);
		}
		public static u32 Effect_SpecialAttackDownHit(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, -1, Stat.SPECIAL_ATTACK);
		}
		public static u32 Effect_SpecialAttackDownHit2(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, -2, Stat.SPECIAL_ATTACK);
		}
		public static u32 Effect_SpecialDefenseUp(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, 1, Stat.SPECIAL_DEFENSE);
		}
		public static u32 Effect_SpecialDefenseUp2(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, 2, Stat.SPECIAL_DEFENSE);
		}
		public static u32 Effect_SpecialDefenseDown(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, -1, Stat.SPECIAL_DEFENSE);
		}
		public static u32 Effect_SpecialDefenseDown2(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, -2, Stat.SPECIAL_DEFENSE);
		}
		public static u32 Effect_SpecialDefenseUpHit(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, 1, Stat.SPECIAL_DEFENSE);
		}
		public static u32 Effect_SpecialDefenseUpHit2(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, 2, Stat.SPECIAL_DEFENSE);
		}
		public static u32 Effect_SpecialDefenseDownHit(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, -1, Stat.SPECIAL_DEFENSE);
		}
		public static u32 Effect_SpecialDefenseDownHit2(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, -2, Stat.SPECIAL_DEFENSE);
		}
		public static u32 Effect_SpeedUp(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, 1, Stat.SPEED);
		}
		public static u32 Effect_SpeedUp2(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, 2, Stat.SPEED);
		}
		public static u32 Effect_SpeedDown(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, -1, Stat.SPEED);
		}
		public static u32 Effect_SpeedDown2(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, -2, Stat.SPEED);
		}
		public static u32 Effect_SpeedUpHit(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, 1, Stat.SPEED);
		}
		public static u32 Effect_SpeedUpHit2(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, 2, Stat.SPEED);
		}
		public static u32 Effect_SpeedDownHit(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, -1, Stat.SPEED);
		}
		public static u32 Effect_SpeedDownHit2(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, -2, Stat.SPEED);
		}
		public static u32 Effect_AccuracyUp(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, 1, Stat.ACCURACY);
		}
		public static u32 Effect_AccuracyUp2(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, 2, Stat.ACCURACY);
		}
		public static u32 Effect_AccuracyDown(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, -1, Stat.ACCURACY);
		}
		public static u32 Effect_AccuracyDown2(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, -2, Stat.ACCURACY);
		}
		public static u32 Effect_AccuracyUpHit(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, 1, Stat.ACCURACY);
		}
		public static u32 Effect_AccuracyUpHit2(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, 2, Stat.ACCURACY);
		}
		public static u32 Effect_AccuracyDownHit(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, -1, Stat.ACCURACY);
		}
		public static u32 Effect_AccuracyDownHit2(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, -2, Stat.ACCURACY);
		}
		public static u32 Effect_EvasionUp(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, 1, Stat.EVASION);
		}
		public static u32 Effect_EvasionUp2(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, 2, Stat.EVASION);
		}
		public static u32 Effect_EvasionDown(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, -1, Stat.EVASION);
		}
		public static u32 Effect_EvasionDown2(MoveEffectParams p) {
			return ChangeStat(p.state, p.attacker, -2, Stat.EVASION);
		}
		public static u32 Effect_EvasionUpHit(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, 1, Stat.EVASION);
		}
		public static u32 Effect_EvasionUpHit2(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, 2, Stat.EVASION);
		}
		public static u32 Effect_EvasionDownHit(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, -1, Stat.EVASION);
		}
		public static u32 Effect_EvasionDownHit2(MoveEffectParams p) {
			return ChangeStat(p.state, p.target, -2, Stat.EVASION);
		}
		public static u32 Effect_AllStatsUp(MoveEffectParams p) {
			return Effect_AttackUp(p) | Effect_DefenseUp(p) | Effect_SpecialAttackUp(p) | Effect_SpecialDefenseUp(p) | Effect_SpeedUp(p);
		}
		public static u32 Effect_AtkDefDown(MoveEffectParams p) {
			return Effect_AttackDown(p) | Effect_DefenseDown(p);
		}
		public static u32 Effect_RandomUp2(MoveEffectParams p) {
			// Cache stat modifier stages.
			sbyte[] statValues =  new sbyte[] {
				p.target.AttackStages,
				p.target.DefenseStages,
				p.target.SpecialAttackStages,
				p.target.SpecialDefenseStages,
				p.target.SpeedStages,
				p.target.AccuracyStages,
				p.target.EvasivenessStages
			};
			// Count stats at max value.
			u8 statsAtMax = 0;
			for (u8 i = 0; i < statValues.Length; i++) {
				if (statValues[i] == MAX_STAT_STAGE) {
					statsAtMax++;
				}
			}

			// Fails if all stats are at max.
			if (statsAtMax >= 6) {
				return FLAG_MOVE_FAILED;
			}
			else {
				// Choose random stats to upgrade.
				sbyte[] stats = new sbyte[2] { -1, -1 };
				for (u8 i = 0; i < stats.Length; i++) {
					do {
						stats[i] = (sbyte)(p.battle.rand.Next() % statValues.Length);
					} while ((statValues[stats[i]] == MAX_STAT_STAGE) || (stats[0] == stats[1]));
				}
				// Upgrade the stats.
				for (u8 i = 0; i < 2; i++) {
					switch (stats[i]) {
						case 0: Effect_AttackUp2(p); break;
						case 1: Effect_DefenseUp2(p); break;
						case 2: Effect_SpecialAttackUp2(p); break;
						case 3: Effect_SpecialDefenseUp2(p); break;
						case 4: Effect_SpeedUp2(p); break;
						case 5: Effect_AccuracyUp2(p); break;
						case 6: Effect_EvasionUp2(p); break;
					}
				}
			}
			return 0;
		}
		public static u32 Effect_DefAndSpdefDown(MoveEffectParams p) {
			return Effect_DefenseDown(p) | Effect_SpecialDefenseDown(p);
		}
		public static u32 Effect_DefAndSpdefUp(MoveEffectParams p) {
			return Effect_DefenseUp(p) | Effect_SpecialDefenseUp(p);
		}
		public static u32 Effect_BellyDrum(MoveEffectParams p) {
			if (p.target.EffHp(p.state) <= p.target.EffMaxHp(p.state) / 2 || p.target.AttackStages == MAX_STAT_STAGE) {
				return FLAG_MOVE_FAILED;
			}

			u16 damage = (u16)(p.target.EffMaxHp(p.state) / 2);
			p.target.DamageMon(p.state, ref damage, true, false);

			p.target.SetStatStage(Stat.ATTACK, MAX_STAT_STAGE);
			MessageBox(Lang.GetBattleMessage(BattleMessage.BELLY_DRUM, p.target.GetName()));
			return 0;
		}
		public static u32 Effect_AtkAndDefUp(MoveEffectParams p) {
			return Effect_AttackUp(p) | Effect_DefenseUp(p);
		}
		public static u32 Effect_AtkDefAccUp(MoveEffectParams p) {
			return Effect_AttackUp(p) | Effect_DefenseUp(p) | Effect_AccuracyUp(p);
		}
		public static u32 Effect_AtkAndSpatkUp(MoveEffectParams p) {
			return Effect_AttackUp(p) | Effect_SpecialAttackUp(p);
		}
		public static u32 Effect_AtkSpdUp(MoveEffectParams p) {
			return Effect_AttackUp(p) | Effect_SpeedUp(p);
		}
		public static u32 Effect_AtkAccUp(MoveEffectParams p) {
			return Effect_AttackUp(p) | Effect_AccuracyUp(p);
		}
		public static u32 Effect_SpatkSpdefSpdUp(MoveEffectParams p) {
			return Effect_SpecialAttackUp(p) | Effect_SpecialDefenseUp(p) | Effect_SpeedUp(p);
		}
		public static u32 Effect_AtkDefSpdUp(MoveEffectParams p) {
			return Effect_AttackUp(p) | Effect_DefenseUp(p) | Effect_SpeedUp(p);
		}
		#endregion
		#region recoil
		public static u32 Effect_RecoilHalfMaxHp(MoveEffectParams p) {
			u16 recoil = (u16)(p.attacker.EffMaxHp(p.state) / 2);
			return DoRecoilDamage(p, ref recoil);
		}
		public static u32 Effect_RecoilThirdMaxHp(MoveEffectParams p) {
			u16 recoil = (u16)(p.attacker.EffMaxHp(p.state) / 3);
			return DoRecoilDamage(p, ref recoil);
		}
		public static u32 Effect_RecoilQuarterMaxHp(MoveEffectParams p) {
			u16 recoil = (u16)(p.attacker.EffMaxHp(p.state) / 4);
			return DoRecoilDamage(p, ref recoil);
		}
		public static u32 Effect_RecoilHalfDealt(MoveEffectParams p) {
			u16 recoil = (u16)((Attack(p) & 0xFFFF) / 2);
			return DoRecoilDamage(p, ref recoil);
		}
		public static u32 Effect_RecoilThirdDealt(MoveEffectParams p) {
			u16 recoil = (u16)((Attack(p) & 0xFFFF) / 3);
			return DoRecoilDamage(p, ref recoil);
		}
		public static u32 Effect_RecoilQuarterDealt(MoveEffectParams p) {
			u16 recoil = (u16)((Attack(p) & 0xFFFF) / 4);
			return DoRecoilDamage(p, ref recoil);
		}
		#endregion
		#region healing
		public static u32 Effect_Absorb75Percent(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Absorb50Percent(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Abosrb25Percent(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_HealHalfHit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_HealQuarterHit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_HealQuarter(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_HealingWish(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_JungleHealing(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_DreamEater(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_StrengthSap(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_HealHalf(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Purify(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Rest(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Present(MoveEffectParams p) {
			return 0;
		}
		#endregion
		#region weather_and_terrain
		public static u32 Effect_Defog(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static u32 Effect_RainDance(MoveEffectParams p) {
			if (p.state.Weather.Condition == Condition.WEATHER_RAIN) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetWeather(Condition.WEATHER_RAIN, p.attacker.HeldItem == Item.DAMP_ROCK ? (u8)8 : (u8)5);
			return 0;
		}
		public static u32 Effect_SunnyDay(MoveEffectParams p) {
			if (p.state.Weather.Condition == Condition.WEATHER_HARSH_SUNLIGHT) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetWeather(Condition.WEATHER_HARSH_SUNLIGHT, p.attacker.HeldItem == Item.HEAT_ROCK ? (u8)8 : (u8)5);
			return 0;
		}
		public static u32 Effect_Hail(MoveEffectParams p) {
			if (p.state.Weather.Condition == Condition.WEATHER_HAIL) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetWeather(Condition.WEATHER_HAIL, p.attacker.HeldItem == Item.ICY_ROCK ? (u8)8 : (u8)5);
			return 0;
		}
		public static u32 Effect_Sandstorm(MoveEffectParams p) {
			if (p.state.Weather.Condition == Condition.WEATHER_SANDSTORM) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetWeather(Condition.WEATHER_SANDSTORM, p.attacker.HeldItem == Item.SMOOTH_ROCK ? (u8)8 : (u8)5);
			return 0;
		}
		public static u32 Effect_Snowscape(MoveEffectParams p) {
			if (p.state.Weather.Condition == Condition.WEATHER_SNOW) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetWeather(Condition.WEATHER_SNOW, p.attacker.HeldItem == Item.ICY_ROCK ? (u8)8 : (u8)5);
			return 0;
		}
		public static u32 Effect_ChillyReception(MoveEffectParams p) {
			return Effect_Snowscape(p) | Effect_UTurn(p);
		}
		public static u32 Effect_ClearTerrain(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static u32 Effect_ElectricTerrain(MoveEffectParams p) {
			if (p.state.Terrain.Condition == Condition.TERRAIN_ELECTRIC) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetTerrain(Condition.TERRAIN_ELECTRIC, p.attacker.HeldItem == Item.TERRAIN_EXTENDER ? (u8)8 : (u8)5);
			return 0;
		}
		public static u32 Effect_GrassyTerrain(MoveEffectParams p) {
			if (p.state.Terrain.Condition == Condition.TERRAIN_GRASSY) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetTerrain(Condition.TERRAIN_GRASSY, p.attacker.HeldItem == Item.TERRAIN_EXTENDER ? (u8)8 : (u8)5);
			return 0;
		}
		public static u32 Effect_MistyTerrain(MoveEffectParams p) {
			if (p.state.Terrain.Condition == Condition.TERRAIN_MISTY) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetTerrain(Condition.TERRAIN_MISTY, p.attacker.HeldItem == Item.TERRAIN_EXTENDER ? (u8)8 : (u8)5);
			return 0;
		}
		public static u32 Effect_PsychicTerrain(MoveEffectParams p) {
			if (p.state.Terrain.Condition == Condition.TERRAIN_PSYCHIC) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetTerrain(Condition.TERRAIN_PSYCHIC, p.attacker.HeldItem == Item.TERRAIN_EXTENDER ? (u8)8 : (u8)5);
			return 0;
		}
		#endregion
		#region semi_invulnerable_moves
		public static u32 Effect_SemiInvulnerable(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Dig(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Fly(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Bounce(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SkyDrop(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Dive(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_PhantomForce(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ShadowForce(MoveEffectParams p) {
			return 0;
		}
		#endregion
		#region charging_moves
		public static u32 Effect_FreezeShock(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_IceBurn(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Geomancy(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MeteorBeam(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_RazorWind(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SkullBash(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SkyAttack(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SolarBeam(MoveEffectParams p) {
			return 0;
		}
		#endregion
		#region entry_hazards
		public static u32 Effect_StealthRock(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ToxicSpikes(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Spikes(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_StickyWeb(MoveEffectParams p) {
			return 0;
		}
		#endregion
		
		public static u32 Effect_JumpKick(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Explosion(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MindBlown(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MistyExplosion(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MirrorMove(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Haze(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Bide(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Roar(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MultiHit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Conversion(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Conversion2(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FlinchHit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_PayDay(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_TriAttack(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_OHKO(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SuperFang(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_DragonRage(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Trap(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_DoubleHit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Mist(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FocusEnergy(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Substitute(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Recharge(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Metronome(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_LeechSeed(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Splash(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Disable(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_LevelDamage(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Psywave(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Counter(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Encore(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_PainSplit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Snore(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_LockOn(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Sketch(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SleepTalk(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_DestinyBond(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Flail(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Spite(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FalseSwipe(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_HealBell(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_TripleKick(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Thief(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MeanLook(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Nightmare(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Minimize(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Curse(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Protect(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Foresight(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_PerishSong(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Endure(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Rollout(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Swagger(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FuryCutter(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Attract(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Return(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Frustration(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Safeguard(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Magnitude(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_BatonPass(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Pursuit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_RapidSpin(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Sonicboom(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Synthesis(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_HiddenPower(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_PsychUp(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MirrorCoat(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Earthquake(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FutureSight(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Gust(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FlinchMinimizeHit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Teleport(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_BeatUp(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_DefenseCurl(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FakeOut(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Uproar(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Stockpile(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SpitUp(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Swallow(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Torment(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Flatter(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Memento(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Facade(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FocusPunch(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SmellingSalts(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FollowMe(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_NaturePower(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Charge(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Taunt(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_HelpingHand(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Trick(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_RolePlay(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Wish(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Assist(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Ingrain(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MagicCoat(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Recycle(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Revenge(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Yawn(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_KnockOff(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Endeavor(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Eruption(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SkillSwap(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Imprison(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Refresh(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Grudge(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Snatch(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_LowKick(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SecretPower(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_WeatherBall(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Tickle(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_CosmicPower(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SmackDown(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_BulkUp(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_WaterSport(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MudSport(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_CalmMind(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_DragonDance(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Camouflage(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Acrobatics(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_AquaRing(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Assurance(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Autotomize(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Avalanche(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_BanefulBunker(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_BarbBarrage(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_BeakBlast(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Belch(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Bestow(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Bind(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Roost(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FloralHealing(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_BodyPress(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_BoltBeak(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Brine(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_BugBite(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_BurnUp(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_BurningJealousy(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Captivate(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ChipAway(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SwitchToNextHit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ClangorousSoul(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_CollisionCourse(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Comeuppance(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Copycat(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_CoreEnforcer(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_CorrosiveGas(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_CrushGrip(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_DireClaw(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Doodle(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_DoubleShock(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_EchoedVoice(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_EerieSpell(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Electrify(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ElectroBall(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Embargo(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ExpandingForce(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FairyLock(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Feint(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FellStinger(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FilletAway(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FinalGambit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Bite(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FirePledge(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_WaterPledge(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_GrassPledge(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FireSpin(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FishiousRend(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FlameBurst(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Fling(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FlowerShield(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ForestsCurse(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FoulPlay(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FusionBolt(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_FusionFlare(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_GastroAcid(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_GearUp(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_GlaiveRush(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_GrassKnot(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_GravApple(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Gravity(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Growth(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_GuardSplit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_GuardSwap(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_GyroBall(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_HappyHour(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_HealBlock(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_HeartSwap(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_HeavySlam(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Hex(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_HydroSteam(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_HyperspaceFury(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Incinerate(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_InfernalParade(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Infestation(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Instruct(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_IonDeluge(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Judgment(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_KingsShield(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_LaserFocus(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_LashOut(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_LastResort(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_LastRespects(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_LuckyChant(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_LunarBlessing(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_LunarDance(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MagicPowder(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MagicRoom(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MagnetRise(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MakeItRain(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MatBlock(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MeFirst(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MetalBurst(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MiracleEye(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MoongeistBeam(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MultiAttack(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_MysticalPower(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_NaturalGift(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_NaturesMadness(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_NoRetreat(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_AtkAndSpatkDownHit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Obstruct(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Octolock(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_OdorSleuth(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_OrderUp(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Outrage(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_PartingShot(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Payback(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_PhotonGeyser(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_PlasmaFists(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Pluck(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_PollenPuff(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Poltergeist(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_PopulationBomb(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Powder(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_PowerShift(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_PowerSplit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_PowerSwap(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_PowerTrick(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Psyblade(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_PsychicFangs(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_PsychoShift(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Psyshock(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Punishment(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Quash(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_QuickGuard(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_RageFist(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ReflectType(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Retaliate(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_RevelationDance(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_RevivalBlessing(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_RisingVoltage(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Rototiller(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Round(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_AttackAndThawHit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SaltCure(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ScaleShot(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ScorchingSands(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SecretSword(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ShellSideArm(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ShellSmash(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ShellTrap(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ShiftGear(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ShoreUp(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SilkTrap(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SimpleBeam(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_GroundHit(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SnipeShot(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Soak(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SpectralThief(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SpeedSwap(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SpicyExtract(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SpiderWeb(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SpikyShield(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SteamEruption(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Steamroller(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_StompingTantrum(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_StoredPower(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Struggle(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_StuffCheeks(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SuckerPunch(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SunsteelStrike(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Surf(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_SurgingStrikes(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Switcheroo(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Synchronoise(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Tailwind(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_TakeHeart(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_TarShot(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_TearfulLook(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Teatime(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_TechnoBlast(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Telekinesis(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_TerrainPulse(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ThousandArrows(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ThousandWaves(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_ThroatChop(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_TidyUp(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_TopsyTurvy(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_TrickRoom(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_TrickOrTreat(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_TripleArrows(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_TripleAxel(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_TripleDive(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_TrumpCard(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_UTurn(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_VCreate(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_VenomDrench(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Venoshock(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_WakeUpSlap(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_WideGuard(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_WonderRoom(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_WorrySeed(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_WringOut(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_AllySwitch(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_AfterYou(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Transform(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_CourtChange(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_Reflect(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_LightScreen(MoveEffectParams p) {
			return 0;
		}
		public static u32 Effect_AuroraVeil(MoveEffectParams p) {
			return 0;
		}
		#endregion
	}
}