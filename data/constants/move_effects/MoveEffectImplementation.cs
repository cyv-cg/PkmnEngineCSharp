using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

using static PkmnEngine.Global;
using static PkmnEngine.Strings.Lang;
using static PkmnEngine.StatusEffects;
using static PkmnEngine.DamageCalc;

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
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<u32> Effect_Hit(MoveEffectParams p) {
			return await Attack(p);
		}
		#region non_volatile_effects
		public static async Task<u32> Effect_Burn(MoveEffectParams p) {
			return await GiveMonNonVolatileStatus(p.state, p.attacker, Status.BURN, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static async Task<u32> Effect_BurnHit(MoveEffectParams p) {
			return await GiveMonNonVolatileStatus(p.state, p.target, Status.BURN, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static async Task<u32> Effect_CureBurn(MoveEffectParams p) {
			return await CureBurn(p.attacker);
		}
		public static async Task<u32> Effect_CureBurnHit(MoveEffectParams p) {
			return await CureBurn(p.target);
		}
		public static async Task<u32> Effect_Freeze(MoveEffectParams p) {
			return await GiveMonNonVolatileStatus(p.state, p.attacker, Status.FREEZE, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static async Task<u32> Effect_FreezeHit(MoveEffectParams p) {
			return await GiveMonNonVolatileStatus(p.state, p.target, Status.FREEZE, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));	
		}
		public static async Task<u32> Effect_Thaw(MoveEffectParams p) {
			return await ThawMon(p.attacker);
		}
		public static async Task<u32> Effect_ThawHit(MoveEffectParams p) {
			return await ThawMon(p.target);
		}
		public static async Task<u32> Effect_Paralyze(MoveEffectParams p) {
			return await GiveMonNonVolatileStatus(p.state, p.attacker, Status.PARALYSIS, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static async Task<u32> Effect_ParalyzeHit(MoveEffectParams p) {
			return await GiveMonNonVolatileStatus(p.state, p.target, Status.PARALYSIS, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static async Task<u32> Effect_CureParalysis(MoveEffectParams p) {
			return await CureParalysis(p.attacker);
		}
		public static async Task<u32> Effect_CureParalysisHit(MoveEffectParams p) {
			return await CureParalysis(p.target);
		}
		public static async Task<u32> Effect_Poison(MoveEffectParams p) {
			return await GiveMonNonVolatileStatus(p.state, p.attacker, Status.POISON, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static async Task<u32> Effect_PoisonHit(MoveEffectParams p) {
			return await GiveMonNonVolatileStatus(p.state, p.target, Status.POISON, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static async Task<u32> Effect_Toxic(MoveEffectParams p) {
			return await GiveMonNonVolatileStatus(p.state, p.attacker, Status.TOXIC, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static async Task<u32> Effect_ToxicHit(MoveEffectParams p) {
			return await GiveMonNonVolatileStatus(p.state, p.target, Status.TOXIC, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? u8.MaxValue : p.i_flags & 0xFF));
		}
		public static async Task<u32> Effect_CurePoison(MoveEffectParams p) {
			return await CurePoison(p.attacker);
		}
		public static async Task<u32> Effect_CurePoisonHit(MoveEffectParams p) {
			return await CurePoison(p.target);
		}
		public static async Task<u32> Effect_Sleep(MoveEffectParams p) {
			return await GiveMonNonVolatileStatus(p.state, p.attacker, Status.SLEEP, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? GetRandSleepTurns() : p.i_flags & 0xFF));
		}
		public static async Task<u32> Effect_SleepHit(MoveEffectParams p) {
			return await GiveMonNonVolatileStatus(p.state, p.target, Status.SLEEP, p.isPrimaryEffect, (u8)(p.i_flags == 0 ? GetRandSleepTurns() : p.i_flags & 0xFF));
		}
		public static async Task<u32> Effect_WakeUp(MoveEffectParams p) {
			return await WakeUpMon(p.attacker);
		}
		public static async Task<u32> Effect_WakeUpHit(MoveEffectParams p) {
			return await WakeUpMon(p.target);
		}
		public static async Task<u32> Effect_Confuse(MoveEffectParams p) {
			if (p.attacker.HasStatus(Status.CONFUSION)) {
				await MessageBox(GetBattleMessage(BattleMessage.MON_ALREADY_CONFUSED, p.attacker.GetName()));
				return FLAG_MOVE_FAILED;
			}
			else {
				p.attacker.GiveStatus(Status.CONFUSION);
				await MessageBox(GetBattleMessage(BattleMessage.MON_WAS_CONFUSED, p.attacker.GetName()));
			}
			return 0;
		}
		public static async Task<u32> Effect_ConfuseHit(MoveEffectParams p) {
			if (p.target.HasStatus(Status.CONFUSION)) {
				await MessageBox(GetBattleMessage(BattleMessage.MON_ALREADY_CONFUSED, p.target.GetName()));
				return FLAG_MOVE_FAILED;
			}
			else {
				p.target.GiveStatus(Status.CONFUSION);
				await MessageBox(GetBattleMessage(BattleMessage.MON_WAS_CONFUSED, p.target.GetName()));
			}
			return 0;
		}
		public static async Task<u32> Effect_CureNonVolatileStatusHit(MoveEffectParams p) {
			return 
				await Effect_CureBurnHit(p) | 
				await Effect_ThawHit(p) |
				await Effect_CureParalysisHit(p) |
				await Effect_CurePoisonHit(p) |
				await Effect_WakeUpHit(p);
		}
		#endregion
		#region stat_changes
		public static async Task<u32> Effect_AttackUp(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, 1, Stat.ATTACK);
		}
		public static async Task<u32> Effect_AttackUp2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, 2, Stat.ATTACK);
		}
		public static async Task<u32> Effect_AttackDown(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, -1, Stat.ATTACK);
		}
		public static async Task<u32> Effect_AttackDown2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, -2, Stat.ATTACK);
		}
		public static async Task<u32> Effect_AttackUpHit(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, 1, Stat.ATTACK);
		}
		public static async Task<u32> Effect_AttackUpHit2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, 2, Stat.ATTACK);
		}
		public static async Task<u32> Effect_AttackDownHit(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, -1, Stat.ATTACK);
		}
		public static async Task<u32> Effect_AttackDownHit2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, -2, Stat.ATTACK);
		}
		public static async Task<u32> Effect_DefenseUp(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, 1, Stat.DEFENSE);
		}
		public static async Task<u32> Effect_DefenseUp2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, 2, Stat.DEFENSE);
		}
		public static async Task<u32> Effect_DefenseUp3(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, 3, Stat.DEFENSE);
		}
		public static async Task<u32> Effect_DefenseDown(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, -1, Stat.DEFENSE);
		}
		public static async Task<u32> Effect_DefenseDown2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, -2, Stat.DEFENSE);
		}
		public static async Task<u32> Effect_DefenseUpHit(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, 1, Stat.DEFENSE);
		}
		public static async Task<u32> Effect_DefenseUpHit2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, 2, Stat.DEFENSE);
		}
		public static async Task<u32> Effect_DefenseDownHit(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, -1, Stat.DEFENSE);
		}
		public static async Task<u32> Effect_DefenseDownHit2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, -2, Stat.DEFENSE);
		}
		public static async Task<u32> Effect_SpecialAttackUp(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, 1, Stat.SPECIAL_ATTACK);
		}
		public static async Task<u32> Effect_SpecialAttackUp2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, 2, Stat.SPECIAL_ATTACK);
		}
		public static async Task<u32> Effect_SpecialAttackDown(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, -1, Stat.SPECIAL_ATTACK);
		}
		public static async Task<u32> Effect_SpecialAttackDown2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, -2, Stat.SPECIAL_ATTACK);
		}
		public static async Task<u32> Effect_SpecialAttackUpHit(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, 1, Stat.SPECIAL_ATTACK);
		}
		public static async Task<u32> Effect_SpecialAttackUpHit2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, 2, Stat.SPECIAL_ATTACK);
		}
		public static async Task<u32> Effect_SpecialAttackDownHit(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, -1, Stat.SPECIAL_ATTACK);
		}
		public static async Task<u32> Effect_SpecialAttackDownHit2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, -2, Stat.SPECIAL_ATTACK);
		}
		public static async Task<u32> Effect_SpecialDefenseUp(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, 1, Stat.SPECIAL_DEFENSE);
		}
		public static async Task<u32> Effect_SpecialDefenseUp2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, 2, Stat.SPECIAL_DEFENSE);
		}
		public static async Task<u32> Effect_SpecialDefenseDown(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, -1, Stat.SPECIAL_DEFENSE);
		}
		public static async Task<u32> Effect_SpecialDefenseDown2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, -2, Stat.SPECIAL_DEFENSE);
		}
		public static async Task<u32> Effect_SpecialDefenseUpHit(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, 1, Stat.SPECIAL_DEFENSE);
		}
		public static async Task<u32> Effect_SpecialDefenseUpHit2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, 2, Stat.SPECIAL_DEFENSE);
		}
		public static async Task<u32> Effect_SpecialDefenseDownHit(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, -1, Stat.SPECIAL_DEFENSE);
		}
		public static async Task<u32> Effect_SpecialDefenseDownHit2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, -2, Stat.SPECIAL_DEFENSE);
		}
		public static async Task<u32> Effect_SpeedUp(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, 1, Stat.SPEED);
		}
		public static async Task<u32> Effect_SpeedUp2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, 2, Stat.SPEED);
		}
		public static async Task<u32> Effect_SpeedDown(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, -1, Stat.SPEED);
		}
		public static async Task<u32> Effect_SpeedDown2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, -2, Stat.SPEED);
		}
		public static async Task<u32> Effect_SpeedUpHit(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, 1, Stat.SPEED);
		}
		public static async Task<u32> Effect_SpeedUpHit2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, 2, Stat.SPEED);
		}
		public static async Task<u32> Effect_SpeedDownHit(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, -1, Stat.SPEED);
		}
		public static async Task<u32> Effect_SpeedDownHit2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, -2, Stat.SPEED);
		}
		public static async Task<u32> Effect_AccuracyUp(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, 1, Stat.ACCURACY);
		}
		public static async Task<u32> Effect_AccuracyUp2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, 2, Stat.ACCURACY);
		}
		public static async Task<u32> Effect_AccuracyDown(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, -1, Stat.ACCURACY);
		}
		public static async Task<u32> Effect_AccuracyDown2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, -2, Stat.ACCURACY);
		}
		public static async Task<u32> Effect_AccuracyUpHit(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, 1, Stat.ACCURACY);
		}
		public static async Task<u32> Effect_AccuracyUpHit2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, 2, Stat.ACCURACY);
		}
		public static async Task<u32> Effect_AccuracyDownHit(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, -1, Stat.ACCURACY);
		}
		public static async Task<u32> Effect_AccuracyDownHit2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, -2, Stat.ACCURACY);
		}
		public static async Task<u32> Effect_EvasionUp(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, 1, Stat.EVASION);
		}
		public static async Task<u32> Effect_EvasionUp2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, 2, Stat.EVASION);
		}
		public static async Task<u32> Effect_EvasionDown(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, -1, Stat.EVASION);
		}
		public static async Task<u32> Effect_EvasionDown2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.attacker, -2, Stat.EVASION);
		}
		public static async Task<u32> Effect_EvasionUpHit(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, 1, Stat.EVASION);
		}
		public static async Task<u32> Effect_EvasionUpHit2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, 2, Stat.EVASION);
		}
		public static async Task<u32> Effect_EvasionDownHit(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, -1, Stat.EVASION);
		}
		public static async Task<u32> Effect_EvasionDownHit2(MoveEffectParams p) {
			return await ChangeStat(p.state, p.target, -2, Stat.EVASION);
		}
		public static async Task<u32> Effect_AllStatsUp(MoveEffectParams p) {
			return 
				await Effect_AttackUp(p) |
				await Effect_DefenseUp(p) | 
				await Effect_SpecialAttackUp(p) | 
				await Effect_SpecialDefenseUp(p) | 
				await Effect_SpeedUp(p);
		}
		public static async Task<u32> Effect_AtkDefDown(MoveEffectParams p) {
			return await Effect_AttackDown(p) | await Effect_DefenseDown(p);
		}
		public static async Task<u32> Effect_RandomUp2(MoveEffectParams p) {
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
						case 0: await Effect_AttackUp2(p); break;
						case 1: await Effect_DefenseUp2(p); break;
						case 2: await Effect_SpecialAttackUp2(p); break;
						case 3: await Effect_SpecialDefenseUp2(p); break;
						case 4: await Effect_SpeedUp2(p); break;
						case 5: await Effect_AccuracyUp2(p); break;
						case 6: await Effect_EvasionUp2(p); break;
					}
				}
			}
			return 0;
		}
		public static async Task<u32> Effect_DefAndSpdefDown(MoveEffectParams p) {
			return await Effect_DefenseDown(p) | await Effect_SpecialDefenseDown(p);
		}
		public static async Task<u32> Effect_DefAndSpdefUp(MoveEffectParams p) {
			return await Effect_DefenseUp(p) | await Effect_SpecialDefenseUp(p);
		}
		public static async Task<u32> Effect_BellyDrum(MoveEffectParams p) {
			if (p.target.EffHp(p.state) <= p.target.EffMaxHp(p.state) / 2 || p.target.AttackStages == MAX_STAT_STAGE) {
				return FLAG_MOVE_FAILED;
			}

			U16 damage = new((u16)(p.target.EffMaxHp(p.state) / 2));
			await p.target.DamageMon(damage, true, false);

			p.target.SetStatStage(Stat.ATTACK, MAX_STAT_STAGE);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.BELLY_DRUM, p.target.GetName()));
			return 0;
		}
		public static async Task<u32> Effect_AtkAndDefUp(MoveEffectParams p) {
			return await Effect_AttackUp(p) | await Effect_DefenseUp(p);
		}
		public static async Task<u32> Effect_AtkDefAccUp(MoveEffectParams p) {
			return await Effect_AttackUp(p) | await Effect_DefenseUp(p) | await Effect_AccuracyUp(p);
		}
		public static async Task<u32> Effect_AtkAndSpatkUp(MoveEffectParams p) {
			return await Effect_AttackUp(p) | await Effect_SpecialAttackUp(p);
		}
		public static async Task<u32> Effect_AtkSpdUp(MoveEffectParams p) {
			return await Effect_AttackUp(p) | await Effect_SpeedUp(p);
		}
		public static async Task<u32> Effect_AtkAccUp(MoveEffectParams p) {
			return await Effect_AttackUp(p) | await Effect_AccuracyUp(p);
		}
		public static async Task<u32> Effect_SpatkSpdefSpdUp(MoveEffectParams p) {
			return await Effect_SpecialAttackUp(p) | await Effect_SpecialDefenseUp(p) | await Effect_SpeedUp(p);
		}
		public static async Task<u32> Effect_AtkDefSpdUp(MoveEffectParams p) {
			return await Effect_AttackUp(p) | await Effect_DefenseUp(p) | await Effect_SpeedUp(p);
		}
		#endregion
		#region recoil
		public static async Task<u32> Effect_RecoilHalfMaxHp(MoveEffectParams p) {
			U16 recoil = new((u16)(p.attacker.EffMaxHp(p.state) / 2));
			return await DoRecoilDamage(p, recoil);
		}
		public static async Task<u32> Effect_RecoilThirdMaxHp(MoveEffectParams p) {
			U16 recoil = new((u16)(p.attacker.EffMaxHp(p.state) / 3));
			return await DoRecoilDamage(p, recoil);
		}
		public static async Task<u32> Effect_RecoilQuarterMaxHp(MoveEffectParams p) {
			U16 recoil = new((u16)(p.attacker.EffMaxHp(p.state) / 4));
			return await DoRecoilDamage(p, recoil);
		}
		public static async Task<u32> Effect_RecoilHalfDealt(MoveEffectParams p) {
			U16 recoil = new((u16)((await Attack(p) & 0xFFFF) / 2));
			return await DoRecoilDamage(p, recoil);
		}
		public static async Task<u32> Effect_RecoilThirdDealt(MoveEffectParams p) {
			U16 recoil = new((u16)((await Attack(p) & 0xFFFF) / 3));
			return await DoRecoilDamage(p, recoil);
		}
		public static async Task<u32> Effect_RecoilQuarterDealt(MoveEffectParams p) {
			U16 recoil = new((u16)((await Attack(p) & 0xFFFF) / 4));
			return await DoRecoilDamage(p, recoil);
		}
		#endregion
		#region healing
		public static async Task<u32> Effect_Absorb75Percent(MoveEffectParams p) {
			u32 flags = await Attack(p);
			U16 healAmount = new((u16)((flags & FLAG_DAMAGE & 0xFFFF) * 0.75f));
			await p.attacker.HealMon(healAmount, false);
			return flags;
		}
		public static async Task<u32> Effect_Absorb50Percent(MoveEffectParams p) {
			u32 flags = await Attack(p);
			U16 healAmount = new((u16)((flags & FLAG_DAMAGE & 0xFFFF) * 0.5f));
			await p.attacker.HealMon(healAmount, false);
			return flags;
		}
		public static async Task<u32> Effect_Abosrb25Percent(MoveEffectParams p) {
			u32 flags = await Attack(p);
			U16 healAmount = new((u16)((flags & FLAG_DAMAGE & 0xFFFF) * 0.25f));
			await p.attacker.HealMon(healAmount, false);
			return flags;
		}
		public static async Task<u32> Effect_HealHalfHit(MoveEffectParams p) {
			U16 healAmount = new((u16)(p.target.EffMaxHp(p.state) / 2));
			await p.target.HealMon(healAmount, false);
			return 0;
		}
		public static async Task<u32> Effect_HealQuarterHit(MoveEffectParams p) {
			U16 healAmount = new((u16)(p.target.EffMaxHp(p.state) / 4));
			await p.target.HealMon(healAmount, false);
			return 0;
		}
		public static async Task<u32> Effect_HealQuarter(MoveEffectParams p) {
			U16 healAmount = new((u16)(p.attacker.EffMaxHp(p.state) / 4));
			await p.attacker.HealMon(healAmount, false);
			return 0;
		}
		public static async Task<u32> Effect_HealHalf(MoveEffectParams p) {
			U16 healAmount = new((u16)(p.attacker.EffMaxHp(p.state) / 2));
			await p.attacker.HealMon(healAmount, false);
			return 0;
		}
		public static async Task<u32> Effect_HealingWish(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_JungleHealing(MoveEffectParams p) {
			U16 healAmount = new(p.target.GetPercentOfMaxHp(0.25f));
			await p.target.HealMon(healAmount, false);
			return await Effect_CureNonVolatileStatusHit(p);
		}
		public static async Task<u32> Effect_DreamEater(MoveEffectParams p) {
			if (p.target.IsAsleep()) {
				return await Effect_Absorb50Percent(p);
			}
			else {
				return FLAG_MOVE_FAILED;
			}
		}
		public static async Task<u32> Effect_StrengthSap(MoveEffectParams p) {
			if (p.target.AttackStages == MIN_STAT_STAGE) {
				return FLAG_MOVE_FAILED;
			}

			U16 healAmount = new(p.target.EffAtk(p.state));
			await Effect_AttackDownHit(p);
			await p.attacker.HealMon(healAmount, false);

			return 0;
		}
		public static async Task<u32> Effect_Purify(MoveEffectParams p) {
			if (p.target.HasStatus(STATUS_MASK_NON_VOLATILE)) {
				return FLAG_MOVE_FAILED;
			}

			await Effect_CureNonVolatileStatusHit(p);

			U16 healAmount = new((u16)(p.attacker.EffMaxHp(p.state) / 2));
			await p.target.HealMon(healAmount, false);

			return 0;
		}
		public static async Task<u32> Effect_Rest(MoveEffectParams p) {
			// "Rest will now fail if it is used by a Pokémon with Leaf Guard during harsh sunlight".
			if (
				p.target.AbilityProc(Ability.LEAF_GUARD, true) && 
				(p.state.Weather.Condition == Condition.WEATHER_HARSH_SUNLIGHT || p.state.Weather.Condition == Condition.WEATHER_EXTREME_SUNLIGHT)
			) {
				return FLAG_MOVE_FAILED;
			}

			// Rest fails if used by a mon already at max HP.
			if (p.target.EffHp(p.state) == p.target.EffMaxHp(p.state)) {
				return FLAG_MOVE_FAILED;
			}

			// Rest overrides all other non-volatile conditions.
			await Effect_CureNonVolatileStatusHit(p);
			// Rest causes the user to sleep for 2 turns.
			p.i_flags = 2;
			await Effect_Sleep(p);

			// Rest heals to full HP.
			U16 healAmount = new(p.target.EffMaxHp(p.state));
			await p.target.HealMon(healAmount, false);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.REST, p.target.GetName()));

			return 0;
		}
		public static async Task<u32> Effect_Present(MoveEffectParams p) {
			// https://bulbapedia.bulbagarden.net/wiki/Present_(p.move)

			float prob = (float)p.battle.rand.NextDouble();

			if (prob < 0.1) {
				// 120 base power attack
				await OverridePower(p, 120);
			}
			else if (0.1 <= prob && prob < 0.3) {
				// Heal 1/4 p.target's max HP
				U16 healAmount = new((u16)(p.target.EffMaxHp(p.state) * 0.25f));
				await p.target.HealMon(healAmount, false);
			}
			else if (0.3 <= prob && prob < 0.6) {
				// 80 base power attack
				await OverridePower(p, 80);
			}
			else if (0.6 <= prob) {
				// 40 base power attack
				await OverridePower(p, 40);
			}

			return 0;
		}
		#endregion
		#region weather_and_terrain
		public static async Task<u32> Effect_Defog(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_RainDance(MoveEffectParams p) {
			if (p.state.Weather.Condition == Condition.WEATHER_RAIN) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetWeather(Condition.WEATHER_RAIN, p.attacker);
			return 0;
		}
		public static async Task<u32> Effect_SunnyDay(MoveEffectParams p) {
			if (p.state.Weather.Condition == Condition.WEATHER_HARSH_SUNLIGHT) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetWeather(Condition.WEATHER_HARSH_SUNLIGHT, p.attacker);
			return 0;
		}
		public static async Task<u32> Effect_Hail(MoveEffectParams p) {
			if (p.state.Weather.Condition == Condition.WEATHER_HAIL) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetWeather(Condition.WEATHER_HAIL, p.attacker);
			return 0;
		}
		public static async Task<u32> Effect_Sandstorm(MoveEffectParams p) {
			if (p.state.Weather.Condition == Condition.WEATHER_SANDSTORM) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetWeather(Condition.WEATHER_SANDSTORM, p.attacker);
			return 0;
		}
		public static async Task<u32> Effect_Snowscape(MoveEffectParams p) {
			if (p.state.Weather.Condition == Condition.WEATHER_SNOW) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetWeather(Condition.WEATHER_SNOW, p.attacker);
			return 0;
		}
		public static async Task<u32> Effect_ChillyReception(MoveEffectParams p) {
			return await Effect_Snowscape(p) | await Effect_UTurn(p);
		}
		public static async Task<u32> Effect_ClearTerrain(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_ElectricTerrain(MoveEffectParams p) {
			if (p.state.Terrain.Condition == Condition.TERRAIN_ELECTRIC) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetTerrain(Condition.TERRAIN_ELECTRIC, p.attacker);
			return 0;
		}
		public static async Task<u32> Effect_GrassyTerrain(MoveEffectParams p) {
			if (p.state.Terrain.Condition == Condition.TERRAIN_GRASSY) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetTerrain(Condition.TERRAIN_GRASSY, p.attacker);
			return 0;
		}
		public static async Task<u32> Effect_MistyTerrain(MoveEffectParams p) {
			if (p.state.Terrain.Condition == Condition.TERRAIN_MISTY) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetTerrain(Condition.TERRAIN_MISTY, p.attacker);
			return 0;
		}
		public static async Task<u32> Effect_PsychicTerrain(MoveEffectParams p) {
			if (p.state.Terrain.Condition == Condition.TERRAIN_PSYCHIC) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetTerrain(Condition.TERRAIN_PSYCHIC, p.attacker);
			return 0;
		}
		#endregion
		#region semi_invulnerable_moves
		public static async Task<u32> Effect_SemiInvulnerable(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_Dig(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_Fly(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_Bounce(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_SkyDrop(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_Dive(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_PhantomForce(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_ShadowForce(MoveEffectParams p) {
			return 0;
		}
		#endregion
		#region charging_moves
		public static async Task<u32> Effect_FreezeShock(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_IceBurn(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_Geomancy(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_MeteorBeam(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_RazorWind(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_SkullBash(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_SkyAttack(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_SolarBeam(MoveEffectParams p) {
			return 0;
		}
		#endregion
		#region entry_hazards
		public static async Task<u32> Effect_StealthRock(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_ToxicSpikes(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_Spikes(MoveEffectParams p) {
			return 0;
		}
		public static async Task<u32> Effect_StickyWeb(MoveEffectParams p) {
			return 0;
		}
		#endregion
		
		public static async Task<u32> Effect_JumpKick(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Explosion(MoveEffectParams p) {
			// Check for the Damp ability.
			if (p.battle.FieldMonAbilityProc(Ability.DAMP, true)) {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_USE_MOVE, p.attacker.GetName(), Lang.GetMoveName(p.moveID)));
				return 0;
			}

			// Attacker faints first.
			U16 damage = new(p.attacker.EffHp(p.state));
			await p.attacker.DamageMon(damage, true, false);
			// Attack.
			u32 flags = await Attack(p);

			return flags;
		}
		public static async Task<u32> Effect_MindBlown(MoveEffectParams p) {
			// Check for the Damp ability.
			if (p.battle.FieldMonAbilityProc(Ability.DAMP, true)) {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_USE_MOVE, p.attacker.GetName(), Lang.GetMoveName(p.moveID)));
				return 0;
			}

			// Mon loses 50% of its HP.
			U16 damage = new(p.attacker.GetPercentOfMaxHp(0.5f));
			await p.attacker.DamageMon(damage, true, false);
			// Attack.
			u32 flags = await Attack(p);

			return flags;
		}
		public static async Task<u32> Effect_MistyExplosion(MoveEffectParams p) {
			if (p.battle.FieldMonAbilityProc(Ability.DAMP, true)) {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_USE_MOVE, p.attacker.GetName(), Lang.GetMoveName(p.moveID)));
				return 0;
			}

			if (p.attacker.IsGrounded(p.state) && (p.state.Terrain.Condition == Condition.TERRAIN_MISTY)) {
				return await OverridePower(p, (u16)(p.move.power * 1.5f));
			}
			return await Attack(p);
		}
		public static async Task<u32> Effect_MirrorMove(MoveEffectParams p) {
			u8 moveSlot = (u8)p.target.GetStatusParam(StatusParam.LAST_USED_MOVE);
			// GET_LAST_USED_MOVE will return 7 if the mon has not used a move yet.
			// Mirror Move fails if the target has not used a move yet.
			if (moveSlot > 3) {
				return FLAG_MOVE_FAILED;
			}

			// Get the ID of the p.target's last used p.move.
			BattleMoveID targetMoveID = p.target.moves[moveSlot];
			// Mirror p.move fails if the p.target's last used p.move was also Mirror p.move.
			if (targetMoveID == BattleMoveID.MIRROR_MOVE) {
				return FLAG_MOVE_FAILED;
			}

			u64 action = BattleActionCodes.BATTLE_ACTION_DO_MOVE(p.slotAttacker, 0, targetMoveID, p.slotTarget);
			p.state.InsertAction(action, p.actionIndex);
			return 0;
		}
		public static async Task<u32> Effect_Haze(MoveEffectParams p) {
			// Reset all stat modifiers to zero.
			p.target.SetStatStage(Stat.ATTACK, 0);
			p.target.SetStatStage(Stat.DEFENSE, 0);
			p.target.SetStatStage(Stat.SPECIAL_ATTACK, 0);
			p.target.SetStatStage(Stat.SPECIAL_DEFENSE, 0);
			p.target.SetStatStage(Stat.SPEED, 0);
			p.target.SetStatStage(Stat.ACCURACY, 0);
			p.target.SetStatStage(Stat.EVASION, 0);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.STAT_CHANGES_ELIMINATED));
			return 0;
		}
		public static async Task<u32> Effect_Bide(MoveEffectParams p) {
			if (p.attacker.HasStatus(Status.CHARGING_TURN) && p.attacker.HasStatus(Status.BIDE)) {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_UNLEASHED_ITS_ENERGY, p.attacker.GetName()));
				u16 damage = (u16)System.MathF.Max(0, p.attacker.GetStatusParam(StatusParam.BIDE_STARTING_HP) - p.attacker.EffHp(p.state));
				damage *= 2;
				p.attacker.RemoveStatus(Status.CHARGING_TURN);
				p.attacker.RemoveStatus(Status.BIDE);
				return await Attack(p, damage);
			}
			else if (p.attacker.HasStatus(Status.CHARGING_TURN)) {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_IS_STORING_ENERGY, p.attacker.GetName()));
				p.attacker.GiveStatus(Status.BIDE);
				return FLAG_DO_NOT_DO_SECONDARY_EFFECT;
			}
			else {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_IS_STORING_ENERGY, p.attacker.GetName()));
				p.attacker.SetStatusParam(StatusParam.BIDE_STARTING_HP, p.attacker.EffHp(p.state));
				p.attacker.GiveStatus(Status.CHARGING_TURN);
				return FLAG_DO_NOT_DO_SECONDARY_EFFECT;
			}
		}
		public static async Task<u32> Effect_Roar(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_MultiHit(MoveEffectParams p) {
			u8 numHits = 2;
			if (p.attacker.AbilityProc(Ability.SKILL_LINK, false)) {
				numHits = 5;
			}
			else {
				if (p.battle.rand.NextDouble() <= 0.65){
					numHits++;
					if (p.battle.rand.NextDouble() <= 0.3) {
						numHits++;
						if (p.battle.rand.NextDouble() <= 0.15) {
							numHits++;
						}
					}
				}
			}

			for (u8 i = 0; i < numHits; i++) {
				await Effect_Hit(p);
				if (p.target.EffHp(p.state) == 0) {
					numHits = (u8)(i + 1);
					break;
				}
			}
			await MessageBox(Lang.GetBattleMessage(BattleMessage.HIT_N_TIMES, numHits.ToString()));
			return 0;
		}
		public static async Task<u32> Effect_Conversion(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Conversion2(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_FlinchHit(MoveEffectParams p) {
			p.target.GiveStatus(Status.FLINCH);
			return 0;
		}
		public static async Task<u32> Effect_PayDay(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_TriAttack(MoveEffectParams p) {
			float roll = (float)p.battle.rand.NextDouble();

			if (0 <= roll && roll < 0.2) {
				await Effect_ParalyzeHit(p);
			}
			else if (0.2 <= roll && roll < 0.4) {
				await Effect_BurnHit(p);
			}
			else if (0.4 <= roll && roll < 0.6) {
				await Effect_FreezeHit(p);
			}

			return 0;
		}
		public static async Task<u32> Effect_OHKO(MoveEffectParams p) {
			u32 flags = await Attack(p, p.target.EffMaxHp(p.state));
			await MessageBox(Lang.GetBattleMessage(BattleMessage.OHKO));
			return flags;
		}
		public static async Task<u32> Effect_SuperFang(MoveEffectParams p) {
			return await Attack(p, p.target.GetPercentOfCurrHp(0.5f));
		}
		public static async Task<u32> Effect_DragonRage(MoveEffectParams p) {
			return await Attack(p, 40);
		}
		public static async Task<u32> Effect_Trap(MoveEffectParams p) {
			p.target.GiveStatus(Status.CANT_ESCAPE);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_TRAPPED_MON, p.attacker.GetName(), p.target.GetName()));
			return 0;
		}
		public static async Task<u32> Effect_DoubleHit(MoveEffectParams p) {
			u8 numHits = 2;
			for (u8 i = 0; i < numHits; i++) {
				await Effect_Hit(p);
				if (p.target.EffHp(p.state) == 0) {
					numHits = (u8)(i + 1);
					break;
				}
			}
			await MessageBox(Lang.GetBattleMessage(BattleMessage.HIT_N_TIMES, numHits.ToString()));
			return 0;
		}
		public static async Task<u32> Effect_Mist(MoveEffectParams p) {
			if (p.state.SideHasCondition(p.attacker.Side, Condition.MIST)) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetSideCondition(p.attacker.Side, Condition.MIST, p.attacker);

			if (p.attacker.Side == Battle.SIDE_CLIENT){
				await MessageBox(Lang.GetBattleMessage(BattleMessage.YOUR_TEAM_BECAME_SHROUDED_IN_MIST));
			}
			else {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.OPPOSING_TEAM_BECAME_SHROUDED_IN_MIST));
			}

			return 0;
		}
		public static async Task<u32> Effect_FocusEnergy(MoveEffectParams p) {
			if (p.target.HasStatus(Status.GETTING_PUMPED)) {
				return FLAG_MOVE_FAILED;
			}

			p.target.GiveStatus(Status.GETTING_PUMPED);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_GETTING_PUMPED, p.target.GetName()));
			return 0;
		}
		public static async Task<u32> Effect_Substitute(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Recharge(MoveEffectParams p) {
			p.attacker.GiveStatus(Status.RECHARGING);
			return 0;
		}
		public static async Task<u32> Effect_Metronome(MoveEffectParams p) {
			BattleMoveID moveToUse = (BattleMoveID)((p.battle.Random16() % ((u16)BattleMoveID.MOVES_NR_ITEMS - 1)) + 1);
			u32 targetSlot = BattleUtils.GetDefaultMoveTarget(moveToUse, p.attacker);
			u64 action = BattleActionCodes.BATTLE_ACTION_DO_MOVE(p.slotAttacker, 0, moveToUse, targetSlot);
			p.state.InsertAction(action, p.actionIndex);
			return 0;
		}
		public static async Task<u32> Effect_LeechSeed(MoveEffectParams p) {
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_WAS_SEEDED, p.target.GetName()));

			p.target.GiveStatus(Status.SEEDED);
			p.target.SetStatusParam(StatusParam.SLOT_SEEDED_BY, p.slotAttacker);

			return 0;
		}
		public static async Task<u32> Effect_Splash(MoveEffectParams p) {
			await MessageBox(Lang.GetBattleMessage(BattleMessage.NOTHING_HAPPENED));
			return 0;
		}
		public static async Task<u32> Effect_Disable(MoveEffectParams p) {
			if (p.target.HasStatus(Status.DISABLE)) {
				return FLAG_MOVE_FAILED;
			}

			u8 slot = (u8)p.target.GetStatusParam(StatusParam.LAST_USED_MOVE);

			if (slot > (Pokemon.MAX_MOVES - 1)) {
				return FLAG_MOVE_FAILED;
			}

			await MessageBox(Lang.GetBattleMessage(BattleMessage.MONS_MOVE_WAS_DISABLED, p.target.GetName(), Lang.GetMoveName(p.target.moves[slot])));

			p.target.GiveStatus(Status.DISABLE);
			p.target.SetStatusParam(StatusParam.DISABLE, BattleEvents.EventDuration(p.attacker, Status.DISABLE).Result);
			p.target.SetStatusParam(StatusParam.DISABLED_SLOT, slot);

			return 0;
		}
		public static async Task<u32> Effect_LevelDamage(MoveEffectParams p) {
			return await Attack(p, p.attacker.Mon.level);
		}
		public static async Task<u32> Effect_Psywave(MoveEffectParams p) {
			// https://bulbapedia.bulbagarden.net/wiki/Psywave_(p.move)#Generation_V
			u16 damage = (u16)(p.attacker.Mon.level * (p.battle.Random16() % 101 + 50) / 100);
			return await Attack(p, damage);
		}
		public static async Task<u32> Effect_Counter(MoveEffectParams p) {
			u16 damage = (u16)(p.attacker.GetStatusParam(StatusParam.PHYS_DAMAGE_THIS_TURN) * 2);

			if (damage == 0) {
				return FLAG_MOVE_FAILED;
			}

			return await Attack(
				new MoveEffectParams(
					p.battle,
					p.state,
					p.attacker,
					p.battle.GetMonInSlot(p.state, (u8)p.attacker.GetStatusParam(StatusParam.LAST_MON_HIT_BY)),
					p.move,
					p.moveID,
					p.slotAttacker,
					p.slotTarget,
					p.numTargets,
					p.actionIndex,
					p.isPrimaryEffect,
					p.i_flags 
				)
			);
		}
		public static async Task<u32> Effect_Encore(MoveEffectParams p) {
			if (p.target.HasStatus(Status.ENCORE)) {
				return FLAG_MOVE_FAILED;
			}

			u8 lastUsedMoveSlot = (u8)p.target.GetStatusParam(StatusParam.LAST_USED_MOVE);

			if (lastUsedMoveSlot > Pokemon.MAX_MOVES - 1) {
				return FLAG_MOVE_FAILED;
			}

			BattleMoveID lastUsedMoveId = p.target.moves[lastUsedMoveSlot];

			if (
				lastUsedMoveId == BattleMoveID.TRANSFORM ||
				lastUsedMoveId == BattleMoveID.MIMIC ||
				lastUsedMoveId == BattleMoveID.SKETCH ||
				lastUsedMoveId == BattleMoveID.MIRROR_MOVE ||
				lastUsedMoveId == BattleMoveID.SLEEP_TALK ||
				lastUsedMoveId == BattleMoveID.ENCORE ||
				lastUsedMoveId == BattleMoveID.STRUGGLE
			) {
				return FLAG_MOVE_FAILED;
			}

			if (p.target.pp[lastUsedMoveSlot] == 0) {
				return FLAG_MOVE_FAILED;
			}

			p.target.GiveStatus(Status.ENCORE);
			p.target.SetStatusParam(StatusParam.ENCORE_TURNS, 3);
			p.target.SetStatusParam(StatusParam.ENCORE, lastUsedMoveSlot);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_MUST_DO_AN_ENCORE, p.target.GetName()));

			return 0;
		}
		public static async Task<u32> Effect_PainSplit(MoveEffectParams p) {
			u16 avgHp = (u16)((p.attacker.EffHp(p.state) + p.target.EffHp(p.state)) * 0.5f);
			U16 diff;
			
			if (p.attacker.EffHp(p.state) > avgHp) {
				diff = new((u16)(p.attacker.EffHp(p.state) - avgHp));
				await p.attacker.DamageMon(diff, true, false);
			}
			else {
				diff = new((u16)(avgHp - p.attacker.EffHp(p.state)));
				await p.attacker.HealMon(diff, true);
			}

			if (p.target.EffHp(p.state) > avgHp) {
				diff = new((u16)(p.target.EffHp(p.state) - avgHp));
				await p.target.DamageMon(diff, true, false);
			}
			else {
				diff = new((u16)(avgHp - p.target.EffHp(p.state)));
				await p.target.HealMon(diff, true);
			}

			await MessageBox(Lang.GetBattleMessage(BattleMessage.PAIN_SPLIT));

			return 0;
		}
		public static async Task<u32> Effect_Snore(MoveEffectParams p) {
			if (p.attacker.IsAsleep()) {
				await Effect_Hit(p);
			}
			else {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.MOVE_FAILED));
				return FLAG_MOVE_FAILED;
			}
			return 0;
		}
		public static async Task<u32> Effect_LockOn(MoveEffectParams p) {
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_TOOK_AIM_AT_MON, p.attacker.GetName(), p.target.GetName()));

			p.attacker.GiveStatus(Status.TAKING_AIM);
			p.attacker.SetStatusParam(StatusParam.TAKING_AIM, 1);

			return 0;
		}
		public static async Task<u32> Effect_Sketch(MoveEffectParams p) {
			// Fail if the p.target has not yer used a p.move.
			if (p.target.GetStatusParam(StatusParam.LAST_USED_MOVE) > (Pokemon.MAX_MOVES - 1)) {
				return FLAG_MOVE_FAILED;
			}

			BattleMoveID idOfMoveToSketch = p.target.moves[p.target.GetStatusParam(StatusParam.LAST_USED_MOVE)];
			BattleMove moveToSketch = BattleMoves.gBattleMoves(idOfMoveToSketch);
			u8 sketchSlot = 7;

			// Fails if the move cannot be sketched.
			if ((moveToSketch.flags & BattleMoves.Flag.CANNOT_BE_SKETCHED) != 0) {
				return FLAG_MOVE_FAILED;
			}

			// Fails if the mon already knows the p.move being sketched.
			for (u8 i = 0; i < Pokemon.MAX_MOVES; i++) {
				if (p.attacker.moves[i] == idOfMoveToSketch) {
					return FLAG_MOVE_FAILED;
				}
				// Also get the slot to overwrite.
				if (p.attacker.moves[i] == BattleMoveID.SKETCH) {
					sketchSlot = i;
				}
			}

			// In the event sketch is somehow not known by the user, don't do the thing.
			if (sketchSlot > (Pokemon.MAX_MOVES - 1)) {
				return FLAG_MOVE_FAILED;
			}

			// Give the attacker the target's move.
			p.attacker.Mon.ReplaceMove(sketchSlot, idOfMoveToSketch);
			p.attacker.ReplaceMove(sketchSlot, idOfMoveToSketch);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_SKETCHED_MOVE, p.attacker.GetName(), Lang.GetMoveName(idOfMoveToSketch)));

			return 0;
		}
		public static async Task<u32> Effect_SleepTalk(MoveEffectParams p) {
			// Fails if the mon is not asleep.
			if (!p.attacker.IsAsleep()) {
				return FLAG_MOVE_FAILED;
			}

			// Fails if all other moves cannot be called by Sleep Talk.
			bool fail = true;
			for (u8 i = 0; i < Pokemon.MAX_MOVES; i++) {
				if ((BattleMoves.gBattleMoves(p.attacker.moves[i]).flags & BattleMoves.Flag.UNUSABLE_BY_SLEEP_TALK) == 0) {
					fail = false;
					break;
				}
			}
			if (fail) {
				return FLAG_MOVE_FAILED;
			}

			// Randomly select a move.
			u8 moveSlot = 0;
			BattleMove moveToUse = null;
			while (moveToUse == null || (moveToUse.flags & BattleMoves.Flag.UNUSABLE_BY_SLEEP_TALK) != 0) {
				moveSlot = (u8)(p.battle.Random16() % Pokemon.MAX_MOVES);
				moveToUse = BattleMoves.gBattleMoves(p.attacker.moves[moveSlot]);
			}

			u64 action = BattleActionCodes.BATTLE_ACTION_DO_MOVE(p.slotAttacker, moveSlot, p.attacker.moves[moveSlot], BattleUtils.GetDefaultMoveTarget(p.moveID, p.attacker));
			p.state.InsertAction(action, p.actionIndex);

			return 0;
		}
		public static async Task<u32> Effect_DestinyBond(MoveEffectParams p) {
			p.attacker.GiveStatus(Status.DESTINY_BOND);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_USED_DESTINY_BOND, p.attacker.GetName()));
			return 0;
		}
		public static async Task<u32> Effect_Flail(MoveEffectParams p) {
			// https://bulbapedia.bulbagarden.net/wiki/Flail_(p.move)
			u8 power = 0;
			float hpPercent = (float)(p.attacker.EffHp(p.state)) / p.attacker.EffMaxHp(p.state) * 100;

			if (68.75f <= hpPercent) {
				power = 20;
			}
			else if (35.42f <= hpPercent && hpPercent < 68.75f) {
				power = 40;
			}
			else if (20.83f <= hpPercent && hpPercent < 35.42f) {
				power = 80;
			}
			else if (10.42f <= hpPercent && hpPercent < 20.83f) {
				power = 100;
			}
			else if (4.17f <= hpPercent && hpPercent < 10.42f) {
				power = 150;
			}
			else if (hpPercent < 4.17f) {
				power = 200;
			}

			return await OverridePower(p, power);
		}
		public static async Task<u32> Effect_Spite(MoveEffectParams p) {
			u8 moveSlot = (u8)p.target.GetStatusParam(StatusParam.LAST_USED_MOVE);

			if (p.target.Mon.PP[moveSlot] == 0) {
				return FLAG_MOVE_FAILED;
			}

			// Reduce the PP of the p.target's last-used p.move by 4.
			p.target.Mon.PP[moveSlot] -= 4;

			await MessageBox(Lang.GetBattleMessage(BattleMessage.MONS_PP_WAS_REDUCED, p.target.GetName()));

			return 0;
		}
		public static async Task<u32> Effect_FalseSwipe(MoveEffectParams p) {
			u16 damage = CalcDamage(p, new Mods(p, CritRate(p)));
			damage = (u16)System.MathF.Min(damage, p.target.EffHp(p.state) - 1);
			await DoSetDamage(p, damage);
			if (damage == 0) {
				return 0;
			}
			return await Attack(p, damage);
		}
		public static async Task<u32> Effect_HealBell(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_TripleKick(MoveEffectParams p) {
			u8 numHits = 0;
			for (u8 i = 0; i < 3; i++) {
				if (i > 1) {
					// Subsequent attacks can miss and end the p.move.
					if (!BattleUtils.MoveHit(p.battle, p.state, p.attacker, p.target, p.moveID)) {
						break;
					}
				}
				u16 damage = CalcDamage(p, new Mods(p, CritRate(p)), new Overrides(0, 0, (u16)(p.move.power + (10 * i)), 0));
				await DoSetDamage(p, damage);
				numHits++;
			}
			await MessageBox(Lang.GetBattleMessage(BattleMessage.HIT_N_TIMES, numHits.ToString()));
			return 0;
		}
		public static async Task<u32> Effect_Thief(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_MeanLook(MoveEffectParams p) {
			p.target.GiveStatus(Status.CANT_ESCAPE);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CAN_NO_LONGER_ESCAPE, p.target.GetName()));
			return 0;
		}
		public static async Task<u32> Effect_Nightmare(MoveEffectParams p) {
			if (p.target.IsAsleep()) {
				return FLAG_MOVE_FAILED;
			}
			p.target.GiveStatus(Status.NIGHTMARE);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_HAVING_NIGHTMARE, p.target.GetName()));
			return 0;
		}
		public static async Task<u32> Effect_Minimize(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Curse(MoveEffectParams p) {
			// Do this for non-ghost-type pokemon.
			if (!p.attacker.HasType(Type.GHOST)) {
				return await Effect_SpeedDown(p) | await Effect_AttackUp(p) | await Effect_DefenseUp(p);
			}

			// Otherwise, cut HP in half and curse the p.target.
			U16 selfDamage = new(p.attacker.GetPercentOfMaxHp(0.5f));
			p.target.GiveStatus(Status.CURSE);
			await p.attacker.DamageMon(selfDamage, true, false, Lang.GetBattleMessage(BattleMessage.MON_PUT_A_CURSE_ON_MON, p.attacker.GetName(), p.target.GetName()));

			return 0;
		}
		public static async Task<u32> Effect_Protect(MoveEffectParams p) {
			u8 successiveUses = (u8)p.target.GetStatusParam(StatusParam.SUCCESSIVE_PROTECTS);
			float successRate = System.MathF.Pow(0.33f, successiveUses);

			if (p.battle.Random01() >= successRate) {
				p.target.SetStatusParam(StatusParam.SUCCESSIVE_PROTECTS, 0);
				return FLAG_MOVE_FAILED;
			}

			p.target.GiveStatus(Status.PROTECTION);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_PROTECTED_ITSELF, p.target.GetName()));
			
			// Increment successive uses.
			if (successiveUses < 3) {
				p.target.IncrementStatusParam(StatusParam.SUCCESSIVE_PROTECTS);
			}

			return 0;
		}
		public static async Task<u32> Effect_Foresight(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_PerishSong(MoveEffectParams p) {
			p.target.GiveStatus(Status.PERISH_SONG);
			p.target.SetStatusParam(StatusParam.PERISH_COUNT, 3);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.PERISH_SONG));
			return 0;
		}
		public static async Task<u32> Effect_Endure(MoveEffectParams p) {
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_BRACED_ITSELF, p.target.GetName()));
			p.target.GiveStatus(Status.BRACING);
			return 0;
		}
		public static async Task<u32> Effect_Rollout(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Swagger(MoveEffectParams p) {
			// Swagger only inflicts confuse if the p.target's attack is raised successfully.
			if ((await Effect_AttackUpHit2(p) & FLAG_STAT_DID_NOT_CHANGE) == 0) {
				await Effect_ConfuseHit(p);
			}
			return 0;
		}
		public static async Task<u32> Effect_FuryCutter(MoveEffectParams p) {
			// Double power for each successive use.
			u8 power = (u8)(p.move.power * System.MathF.Pow(2, System.MathF.Min(p.attacker.GetStatusParam(StatusParam.SUCCESSIVE_MOVE_USES) - 1, 2)));
			power = (u8)System.Math.Clamp((int)power, (int)p.move.power, 160);
			return await OverridePower(p, power);
		}
		public static async Task<u32> Effect_Attract(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Return(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Frustration(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Safeguard(MoveEffectParams p) {
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_PROTECTED_BY_SAFEGUARD, p.attacker.GetName()));
			p.state.SetSideCondition(p.attacker.Side, Condition.SAFEGUARD, p.attacker);
			return 0;
		}
		public static async Task<u32> Effect_Magnitude(MoveEffectParams p) {
			u8 power = 0;
			string scale = "0";
			float roll = p.battle.Random01();

			if (0 <= roll && roll < 0.05) {
				scale = "4";
				power = 10;
			}
			else if (0.05 <= roll && roll < 0.15) {
				scale = "5";
				power = 30;
			}
			else if (0.15 <= roll && roll < 0.35) {
				scale = "6";
				power = 50;
			}
			else if (0.35 <= roll && roll < 0.65) {
				scale = "7";
				power = 70;
			}
			else if (0.65 <= roll && roll < 0.85) {
				scale = "8";
				power = 90;
			}
			else if (0.85 <= roll && roll < 0.95) {
				scale = "9";
				power = 110;
			}
			else if (0.95 <= roll && roll < 1) {
				scale = "10";
				power = 150;
			}

			await MessageBox(Lang.GetBattleMessage(BattleMessage.MAGNITUDE_N, scale));

			if (p.target.HasStatus(Status.SEMI_INVULNERABLE_TURN) && p.target.GetStatusParam(StatusParam.SEMI_INVULNERABLE) == SEMI_INVULNERABLE_GROUND) {
				power *= 2;
			}
			if (p.state.Terrain.Condition == Condition.TERRAIN_GRASSY) {
				power /= 2;
			}

			return await OverridePower(p, power);
		}
		public static async Task<u32> Effect_BatonPass(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Pursuit(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_RapidSpin(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Sonicboom(MoveEffectParams p) {
			return await Attack(p, 20);
		}
		public static async Task<u32> Effect_Synthesis(MoveEffectParams p) {
			U16 healAmount = new(p.target.GetPercentOfMaxHp(0.25f));

			if ((p.state.Weather.Condition == Condition.WEATHER_HARSH_SUNLIGHT) || (p.state.Weather.Condition == Condition.WEATHER_EXTREME_SUNLIGHT)) {
				healAmount = new(p.target.GetPercentOfMaxHp(0.67f));
			}
			else if (p.state.Weather.Condition == Condition.WEATHER_NONE || (p.state.Weather.Condition == Condition.WEATHER_STRONG_WIND)) {
				healAmount = new(p.target.GetPercentOfMaxHp(0.5f));
			}

			await p.target.HealMon(healAmount, false);
			return 0;
		}
		public static async Task<u32> Effect_HiddenPower(MoveEffectParams p) {
			return await OverrideType(p, p.attacker.Mon.HiddenPowerType);
		}
		public static async Task<u32> Effect_PsychUp(MoveEffectParams p) {
			p.attacker.SetStatStage(Stat.ATTACK, p.target.AttackStages);
			p.attacker.SetStatStage(Stat.DEFENSE, p.target.DefenseStages);
			p.attacker.SetStatStage(Stat.SPECIAL_ATTACK, p.target.SpecialAttackStages);
			p.attacker.SetStatStage(Stat.SPECIAL_DEFENSE, p.target.SpecialDefenseStages);
			p.attacker.SetStatStage(Stat.SPEED, p.target.SpeedStages);
			p.attacker.SetStatStage(Stat.ACCURACY, p.target.AccuracyStages);
			p.attacker.SetStatStage(Stat.EVASION, p.target.EvasivenessStages);
			
			if (p.target.HasStatus(Status.GETTING_PUMPED)) {
				p.attacker.GiveStatus(Status.GETTING_PUMPED);
			}

			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_COPIED_MONS_STAT_CHANGES, p.attacker.GetName(), p.target.GetName()));

			return 0;
		}
		public static async Task<u32> Effect_MirrorCoat(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Earthquake(MoveEffectParams p) {
			u8 power = p.move.power;

			if (p.target.HasStatus(Status.SEMI_INVULNERABLE_TURN) || p.target.GetStatusParam(StatusParam.SEMI_INVULNERABLE) == SEMI_INVULNERABLE_GROUND) {
				power *= 2;
			}
			if (p.state.Terrain.Condition == Condition.TERRAIN_GRASSY) {
				power /= 2;
			}

			return await OverridePower(p, power);
		}
		public static async Task<u32> Effect_FutureSight(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Gust(MoveEffectParams p) {
			return await DoublePowerIf(p, p.target.HasStatus(Status.SEMI_INVULNERABLE_TURN));
		}
		public static async Task<u32> Effect_FlinchMinimizeHit(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Teleport(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_BeatUp(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_DefenseCurl(MoveEffectParams p) {
			p.target.GiveStatus(Status.DEFENSE_CURL);
			return await Effect_DefenseUp(p);
		}
		public static async Task<u32> Effect_FakeOut(MoveEffectParams p) {
			if (!(p.attacker.HasFlag(BattleMon.Flag.JUST_SWITCHED_IN))) {
				return FLAG_MOVE_FAILED;
			}

			return await Attack(p);
		}
		public static async Task<u32> Effect_Uproar(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Stockpile(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_SpitUp(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Swallow(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Torment(MoveEffectParams p) {
			p.target.GiveStatus(Status.TORMENT);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_IS_TORMENTED, p.target.GetName()));
			return 0;
		}
		public static async Task<u32> Effect_Flatter(MoveEffectParams p) {
			// Only inflict confuse if the p.target's attack is raised successfully.
			// Technically, that's not how this p.move works, but I would rather
			// keep it consistent with swagger.
			if ((await Effect_SpecialAttackUpHit(p) & FLAG_STAT_DID_NOT_CHANGE) == 0) {
				await Effect_ConfuseHit(p);
			}
			return 0;
		}
		public static async Task<u32> Effect_Memento(MoveEffectParams p) {
			U16 damage = new(p.attacker.EffMaxHp(p.state));
			await p.attacker.DamageMon(damage, true, false);
			await Effect_AttackDownHit2(p);
			await Effect_SpecialAttackDownHit2(p);
			return 0;
		}
		public static async Task<u32> Effect_Facade(MoveEffectParams p) {
			return await DoublePowerIf(p, (p.attacker.HasStatus(Status.BURN, Status.PARALYSIS, Status.POISON, Status.TOXIC)));
		}
		public static async Task<u32> Effect_FocusPunch(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_SmellingSalts(MoveEffectParams p) {
			bool doublePower = p.target.HasStatus(Status.PARALYSIS);
			u32 retVal = await DoublePowerIf(p, doublePower);
			if (doublePower) {
				await CureParalysis(p.target);
			}
			return retVal;
		}
		public static async Task<u32> Effect_FollowMe(MoveEffectParams p) {
			p.target.GiveStatus(Status.CENTER_OF_ATTENTION);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_BECAME_CENTER_OF_ATTENTION, p.target.GetName()));
			return 0;
		}
		public static async Task<u32> Effect_NaturePower(MoveEffectParams p) {
			Type type = Type.NORMAL;
			type = p.state.Terrain.Condition switch {
				Condition.TERRAIN_ELECTRIC => Type.ELECTRIC,
				Condition.TERRAIN_GRASSY => Type.GRASS,
				Condition.TERRAIN_MISTY => Type.FAIRY,
				Condition.TERRAIN_PSYCHIC => Type.PSYCHIC,
				_ => Type.NORMAL,
			};
			type = p.state.Weather.Condition switch {
				Condition.WEATHER_HARSH_SUNLIGHT or Condition.WEATHER_EXTREME_SUNLIGHT => Type.FIRE,
				Condition.WEATHER_RAIN or Condition.WEATHER_HEAVY_RAIN => Type.GRASS,
				Condition.WEATHER_HAIL or Condition.WEATHER_SNOW => Type.ICE,
				Condition.WEATHER_SANDSTORM => Type.GROUND,
				Condition.WEATHER_STRONG_WIND => Type.FLYING,
				Condition.WEATHER_FOG => Type.GHOST,// ???? idk i'm just throwing stuff at the wall here
				_ => Type.NORMAL,
			};
			return await OverrideType(p, type);
		}
		public static async Task<u32> Effect_Charge(MoveEffectParams p) {
			p.target.GiveStatus(Status.CHARGED);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CHARGING_POWER, p.target.GetName()));
			return 0;
		}
		public static async Task<u32> Effect_Taunt(MoveEffectParams p) {
			p.target.GiveStatus(Status.TAUNT);
			p.target.SetStatusParam(StatusParam.TAUNT, 3);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_FELL_FOR_THE_TAUNT, p.target.GetName()));
			return 0;
		}
		public static async Task<u32> Effect_HelpingHand(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Trick(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_RolePlay(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Wish(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Assist(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Ingrain(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_MagicCoat(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Recycle(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Revenge(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Yawn(MoveEffectParams p) {
			if (p.target.HasStatus(STATUS_MASK_NON_VOLATILE) || p.target.HasStatus(Status.DROWSY)) {
				return FLAG_MOVE_FAILED;
			}
			if (!p.target.CanFallAsleep(p.state)) {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_FALL_ASLEEP, p.target.GetName()));
				return 0;
			}

			p.target.GiveStatus(Status.DROWSY);
			p.target.SetStatusParam(StatusParam.DROWSING, 1);
			
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_IS_DROWSING, p.target.GetName()));
			return 0;
		}
		public static async Task<u32> Effect_KnockOff(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Endeavor(MoveEffectParams p) {
			if (p.attacker.EffHp(p.state) >= p.target.EffHp(p.state)) {
				return FLAG_MOVE_FAILED;
			}
			u16 damage = (u16)(p.target.EffHp(p.state) - p.attacker.EffHp(p.state));
			return await Attack(p, damage);
		}
		public static async Task<u32> Effect_Eruption(MoveEffectParams p) {
			// https://bulbapedia.bulbagarden.net/wiki/Eruption_(p.move)
			u8 power = (u8)System.Math.Clamp((150.0f * p.attacker.EffHp(p.state)) / p.attacker.EffMaxHp(p.state), 1, 150);
			return await OverridePower(p, power);
		}
		public static async Task<u32> Effect_SkillSwap(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Imprison(MoveEffectParams p) {
			p.target.GiveStatus(Status.IMPRISON);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_SEALED_SHARED_MOVES, p.target.GetName()));
			return 0;
		}
		public static async Task<u32> Effect_Refresh(MoveEffectParams p) {
			if (p.target.HasStatus(Status.BURN)) {
				await CureBurn(p.target);
				return 0;
			}
			else if (p.target.HasStatus(Status.PARALYSIS)) {
				await CureParalysis(p.target);
				return 0;
			}
			else if (p.target.IsPoisoned()) {
				await CurePoison(p.target);
				return 0;
			}
			else {
				return FLAG_MOVE_FAILED;
			}
		}
		public static async Task<u32> Effect_Grudge(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Snatch(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_LowKick(MoveEffectParams p) {
			u8 power = 0;

			if (0 <= p.target.weight && p.target.weight < 10) {
				power = 20;
			}
			else if (10 <= p.target.weight && p.target.weight < 25) {
				power = 40;
			}
			else if (25 <= p.target.weight && p.target.weight < 50) {
				power = 60;
			}
			else if (50 <= p.target.weight && p.target.weight < 100) {
				power = 80;
			}
			else if (100 <= p.target.weight && p.target.weight < 200) {
				power = 100;
			}
			else if (200 <= p.target.weight) {
				power = 120;
			}

			return await OverridePower(p, power);
		}
		public static async Task<u32> Effect_SecretPower(MoveEffectParams p) {
			// I mostly just made stuff up for this since I don't have the infrastructure to do
			// the stuff that's actually described on Bulbapedia.
			// https://bulbapedia.bulbagarden.net/wiki/Secret_Power_(p.move)
			switch (p.state.Weather.Condition) {
				case Condition.WEATHER_HARSH_SUNLIGHT:		return await Effect_DefenseDownHit(p);
				case Condition.WEATHER_EXTREME_SUNLIGHT:	return await Effect_DefenseDownHit2(p);
				case Condition.WEATHER_RAIN:				return await Effect_AttackDownHit(p);
				case Condition.WEATHER_HEAVY_RAIN:			return await Effect_AttackDownHit2(p);
				case Condition.WEATHER_SNOW:				return await Effect_SpecialAttackDownHit(p);
				case Condition.WEATHER_HAIL:				return await Effect_EvasionDownHit(p);
				case Condition.WEATHER_SANDSTORM:			return await Effect_AccuracyDownHit(p);
				case Condition.WEATHER_STRONG_WIND:			return await Effect_FlinchHit(p);
			}
			switch (p.state.Terrain.Condition) {
				case Condition.TERRAIN_ELECTRIC:			return await Effect_ParalyzeHit(p);
				case Condition.TERRAIN_GRASSY:				return await Effect_SleepHit(p);
				case Condition.TERRAIN_PSYCHIC:				return await Effect_ConfuseHit(p);
				case Condition.TERRAIN_MISTY:				return await Effect_PoisonHit(p);
				default: return 0;
			}
		}
		public static async Task<u32> Effect_WeatherBall(MoveEffectParams p) {
			Type type = p.move.moveType;

			switch (p.state.Weather.Condition) {
				// Normal-type if there is no weather, it is foggy, or there are strong winds.
				case Condition.WEATHER_FOG or Condition.WEATHER_STRONG_WIND:
					type = Type.NORMAL;
					break;
				// Fire-type if it is sunny.
				case Condition.WEATHER_HARSH_SUNLIGHT or Condition.WEATHER_EXTREME_SUNLIGHT:
					type = Type.FIRE;
					break;
				// Water-type if it is raining.
				case Condition.WEATHER_RAIN or Condition.WEATHER_HEAVY_RAIN:
					type = Type.WATER;
					break;
				// Ice-type if it is hailing or snowing.
				case Condition.WEATHER_SNOW or Condition.WEATHER_HAIL:
					type = Type.ICE;
					break;
				// Rock-type if there is a sandstorm.
				case Condition.WEATHER_SANDSTORM:
					type = Type.ICE;
					break;
				case Condition.WEATHER_SHADOWY_AURA:
					type = Type.GHOST;
					break;
				default:
					type = Type.NORMAL;
					break;
			}

			return await OverrideType(p, type);
		}
		public static async Task<u32> Effect_Tickle(MoveEffectParams p) {
			await Effect_AttackDownHit(p);
			await Effect_DefenseDownHit(p);
			return 0;
		}
		public static async Task<u32> Effect_CosmicPower(MoveEffectParams p) {
			await Effect_DefenseUp(p);
			await Effect_SpecialDefenseUp(p);
			return 0;
		}
		public static async Task<u32> Effect_SmackDown(MoveEffectParams p) {
			u32 flags = await Effect_Gust(p);
			// If the mon is not grounded, display that it now is.
			if (!p.target.IsGrounded(p.state)) {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_FELL_STRAIGHT_DOWN, p.target.GetName()));
			}
			return flags;
		}
		public static async Task<u32> Effect_BulkUp(MoveEffectParams p) {
			await Effect_AttackUp(p);
			await Effect_DefenseUp(p);
			return 0;
		}
		public static async Task<u32> Effect_WaterSport(MoveEffectParams p) {
			p.state.SetFieldCondition(Condition.WATER_SPORT, p.attacker);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.WATER_SPORT_START));
			return 0;
		}
		public static async Task<u32> Effect_MudSport(MoveEffectParams p) {
			p.state.SetFieldCondition(Condition.MUD_SPORT, p.attacker);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MUD_SPORT_START));
			return 0;
		}
		public static async Task<u32> Effect_CalmMind(MoveEffectParams p) {
			await Effect_SpecialAttackUp(p);
			await Effect_SpecialDefenseUp(p);
			return 0;
		}
		public static async Task<u32> Effect_DragonDance(MoveEffectParams p) {
			await Effect_AttackUp(p);
			await Effect_SpeedUp(p);
			return 0;
		}
		public static async Task<u32> Effect_Camouflage(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Acrobatics(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_AquaRing(MoveEffectParams p) {
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_SURROUNDED_ITSELF_WITH_A_VEIL_OF_WATER, p.target.GetName()));
			p.target.GiveStatus(Status.AQUA_RING);
			return 0;
		}
		public static async Task<u32> Effect_Assurance(MoveEffectParams p) {
			return await DoublePowerIf(p, p.target.HasFlag(BattleMon.Flag.RECEIVED_DAMAGE_THIS_TURN));
		}
		public static async Task<u32> Effect_Autotomize(MoveEffectParams p) {
			if (await Effect_SpeedUp2(p) != 0) {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_BECAME_NIMBLE, p.target.GetName()));

				p.target.weight = System.MathF.Max(0.1f, (float)(p.target.weight - 100));
			}
			return 0;
		}
		public static async Task<u32> Effect_Avalanche(MoveEffectParams p) {
			// Technically, this should only double power if the user has been damaged specifically by the p.target this turn.
			return await DoublePowerIf(p, p.attacker.HasFlag(BattleMon.Flag.RECEIVED_DAMAGE_THIS_TURN));
		}
		public static async Task<u32> Effect_BanefulBunker(MoveEffectParams p) {
			if (await Effect_Protect(p) == FLAG_MOVE_FAILED) {
				return FLAG_MOVE_FAILED;
			}

			p.target.GiveStatus(Status.BANEFUL_BUNKER);

			return 0;
		}
		public static async Task<u32> Effect_BarbBarrage(MoveEffectParams p) {
			return await DoublePowerIf(p, p.target.HasStatus(STATUS_MASK_NON_VOLATILE));
		}
		public static async Task<u32> Effect_BeakBlast(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Belch(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Bestow(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Bind(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Roost(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_FloralHealing(MoveEffectParams p) {
			U16 healAmount = new(0);
			if (p.target.IsGrounded(p.state) && (p.state.Terrain.Condition == Condition.TERRAIN_GRASSY)) {
				healAmount = new(p.target.GetPercentOfMaxHp(0.67f));
			}
			else {
				healAmount = new(p.target.GetPercentOfMaxHp(0.5f));
			}
			await p.target.HealMon(healAmount, false);
			return 0;
		}
		public static async Task<u32> Effect_BodyPress(MoveEffectParams p) {
			u16 def = p.attacker.EffDef(p.state);
			u16 damage = CalcDamage(p, new Mods(p, CritRate(p)), new Overrides(def, 0, 0, 0));
			return await DoSetDamage(p, damage);
		}
		public static async Task<u32> Effect_BoltBeak(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Brine(MoveEffectParams p) {
			return await DoublePowerIf(p, p.target.EffHp(p.state) <= (p.target.EffMaxHp(p.state) / 2));
		}
		public static async Task<u32> Effect_BugBite(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_BurnUp(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_BurningJealousy(MoveEffectParams p) {
			if (p.target.HasFlag(BattleMon.Flag.STAT_INCREASED_THIS_TURN)) {
				return await Effect_BurnHit(p);
			}
			return 0;
		}
		public static async Task<u32> Effect_Captivate(MoveEffectParams p) {
			u8 attackerGender = p.attacker.Mon.Gender;
			u8 targetGender = p.target.Mon.Gender;

			if (attackerGender == MON_GENDERLESS) {
				return FLAG_MOVE_FAILED;
			}

			if (targetGender == attackerGender || targetGender == MON_GENDERLESS) {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.IMMUNE, p.target.GetName()));
				return 0;
			}

			if (p.target.AbilityProc(Ability.OBLIVIOUS, true)) {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.IMMUNE, p.target.GetName()));
				return 0;
			}

			return await ChangeStat(p.state, p.target, -2, Stat.SPECIAL_ATTACK);
		}
		public static async Task<u32> Effect_ChipAway(MoveEffectParams p) {
			u16 damage = CalcDamage(p, new Mods(p, CritRate(p)), new Overrides(0, p.target.Def, 0, 0));
			return await DoSetDamage(p, damage);
		}
		public static async Task<u32> Effect_SwitchToNextHit(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_ClangorousSoul(MoveEffectParams p) {
			if (
				p.target.AttackStages == Global.MAX_STAT_STAGE &&
				p.target.DefenseStages == Global.MAX_STAT_STAGE &&
				p.target.SpecialAttackStages == Global.MAX_STAT_STAGE &&
				p.target.SpecialDefenseStages == Global.MAX_STAT_STAGE &&
				p.target.SpeedStages == Global.MAX_STAT_STAGE
			) {
				return FLAG_MOVE_FAILED;
			}

			if (p.target.EffHp(p.state) <= (p.target.EffMaxHp(p.state) / 3)) {
				return FLAG_MOVE_FAILED;
			}

			await Effect_RecoilThirdMaxHp(p);

			await ChangeStat(p.state, p.target, 1, Stat.ATTACK);
			await ChangeStat(p.state, p.target, 1, Stat.DEFENSE);
			await ChangeStat(p.state, p.target, 1, Stat.SPECIAL_ATTACK);
			await ChangeStat(p.state, p.target, 1, Stat.SPECIAL_DEFENSE);
			await ChangeStat(p.state, p.target, 1, Stat.SPEED);
			await ChangeStat(p.state, p.target, 1, Stat.ACCURACY);
			await ChangeStat(p.state, p.target, 1, Stat.EVASION);

			return 0;
		}
		public static async Task<u32> Effect_CollisionCourse(MoveEffectParams p) {
			Mods damageMods = new Mods(p, CritRate(p));
			u16 damage = CalcDamage(p, damageMods);

			// If the move is super effective, increase damage by 33%.
			if (damageMods.typeEff > 1) {
				damage = (u16)(damage * 1.33f);
			}

			return await Attack(p, damage);
		}
		public static async Task<u32> Effect_Comeuppance(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Copycat(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_CoreEnforcer(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_CorrosiveGas(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_CrushGrip(MoveEffectParams p) {
			// https://bulbapedia.bulbagarden.net/wiki/Crush_Grip_(p.move)
			u16 power = (u16)System.Math.Clamp(120.0f * p.target.EffHp(p.state) / p.target.EffMaxHp(p.state), 1, 120);
			Mods damageMods = new Mods(p, CritRate(p));
			Overrides damageOverrides = new Overrides(0, 0, power, 0);
			u16 damage = CalcDamage(p, damageMods, damageOverrides);
			return await Attack(p, damage);
		}
		public static async Task<u32> Effect_DireClaw(MoveEffectParams p) {
			float prob = p.battle.Random01();

			if (0 <= prob && prob < 0.1666) {
				await Effect_ParalyzeHit(p);
			}
			else if (0.1666 <= prob && prob < 0.3333) {
				await Effect_PoisonHit(p);
			}
			else if (0.3333 <= prob && prob < 0.5) {
				await Effect_SleepHit(p);
			}

			return 0;
		}
		public static async Task<u32> Effect_Doodle(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_DoubleShock(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_EchoedVoice(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_EerieSpell(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Electrify(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_ElectroBall(MoveEffectParams p) {
			// https://bulbapedia.bulbagarden.net/wiki/Electro_Ball_(move)
			float speedRatio = (float)p.target.GetEffectiveSpd(p.state) / p.attacker.GetEffectiveSpd(p.state);
			u16 power = 0;

			if (1f <= speedRatio) {
				power = 40;
			}
			else if (0.5f <= speedRatio && speedRatio < 1) {
				power = 60;
			}
			else if (0.3334f <= speedRatio && speedRatio < 0.5f) {
				power = 80;
			}
			else if (0.25f <= speedRatio && speedRatio < 0.3334f) {
				power = 120;
			}
			else if (0f <= speedRatio && speedRatio < 0.25f) {
				power = 150;
			}

			return await OverridePower(p, power);
		}
		public static async Task<u32> Effect_Embargo(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_ExpandingForce(MoveEffectParams p) {
			if (p.attacker.IsGrounded(p.state)) {
				return await OverridePower(p, (u16)(p.move.power * 1.5f));
			}
			return await Attack(p);
		}
		public static async Task<u32> Effect_FairyLock(MoveEffectParams p) {
			// TODO:
			//p.target.GiveStatus(Status.CANT_ESCAPE;
			//await MessageBox(Lang.GetBattleMessage(BattleMessage.NO_ONE_CAN_ESCAPE));
			return 0;
		}
		public static async Task<u32> Effect_Feint(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_FellStinger(MoveEffectParams p) {
			u32 flags = await Attack(p);
			if ((flags & FLAG_TARGET_FAINTED) != 0) {
				flags |= await ChangeStat(p.state, p.attacker, 3, Stat.ATTACK);
			}
			return flags;
		}
		public static async Task<u32> Effect_FilletAway(MoveEffectParams p) {
			if (p.target.EffHp(p.state) <= (p.target.EffMaxHp(p.state) / 2)) {
				return FLAG_MOVE_FAILED;
			}

			U16 damage = new((u16)(p.target.EffMaxHp(p.state) / 2));
			await p.target.DamageMon(damage, true, false);
			await ChangeStat(p.state, p.target, 2, Stat.ATTACK);
			await ChangeStat(p.state, p.target, 2, Stat.SPECIAL_ATTACK);
			await ChangeStat(p.state, p.target, 2, Stat.SPEED);

			return 0;
		}
		public static async Task<u32> Effect_FinalGambit(MoveEffectParams p) {
			U16 damage = new(p.attacker.EffHp(p.state));
			await p.attacker.DamageMon(damage, true, false);
			await p.target.DamageMon(damage, false, true);
			return 0;
		}
		public static async Task<u32> Effect_Bite(MoveEffectParams p) {
			u32 flags = await Attack(p);
			if (p.battle.Random01() < 0.1) {
				flags |= await Effect_FlinchHit(p);
			}
			return flags;
		}
		public static async Task<u32> Effect_FirePledge(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_WaterPledge(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_GrassPledge(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_FireSpin(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_FishiousRend(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_FlameBurst(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Fling(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_FlowerShield(MoveEffectParams p) {
			if (p.target.HasType(Type.GRASS)) {
				return await Effect_DefenseUpHit(p);
			}
			return 0;
		}
		public static async Task<u32> Effect_ForestsCurse(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_FoulPlay(MoveEffectParams p) {
			return await Attack(p, 0, -1, 1, p.target.EffAtk(p.state));
		}
		public static async Task<u32> Effect_FusionBolt(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_FusionFlare(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_GastroAcid(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_GearUp(MoveEffectParams p) {
			if (p.target.ability == Ability.PLUS || p.target.ability == Ability.MINUS) {
				await Effect_AttackUpHit(p);
				await Effect_SpecialAttackUpHit(p);
			}
			return 0;
		}
		public static async Task<u32> Effect_GlaiveRush(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_GrassKnot(MoveEffectParams p) {
			u8 power = 0;
			if (0 <= p.target.weight && p.target.weight < 10) {
				power = 20;
			}
			else if (10 <= p.target.weight && p.target.weight < 25) {
				power = 40;
			}
			else if (25 <= p.target.weight && p.target.weight < 50) {
				power = 60;
			}
			else if (50 <= p.target.weight && p.target.weight < 100) {
				power = 80;	
			}
			else if (100 <= p.target.weight && p.target.weight < 20) {
				power = 100;
			}
			else if (200 <= p.target.weight) {
				power = 120;
			}

			return await OverridePower(p, power);
		}
		public static async Task<u32> Effect_GravApple(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Gravity(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Growth(MoveEffectParams p) {
			if (p.state.Weather.Condition == Condition.WEATHER_HARSH_SUNLIGHT || p.state.Weather.Condition == Condition.WEATHER_EXTREME_SUNLIGHT) {
				await Effect_AttackUp2(p);
				await Effect_SpecialAttackUp2(p);
			}
			else {
				await Effect_AttackUp(p);
				await Effect_SpecialAttackUp(p);
			}
			return 0;
		}
		public static async Task<u32> Effect_GuardSplit(MoveEffectParams p) {
			u16 avgDef = (u16)((p.attacker.Def + p.target.Def) / 2);
			u16 avgSpDef = (u16)((p.attacker.SpDef + p.target.SpDef) / 2);
			p.attacker.Def = avgDef;
			p.target.Def = avgDef;
			p.attacker.SpDef = avgSpDef;
			p.target.SpDef = avgSpDef;

			await MessageBox(Lang.GetBattleMessage(BattleMessage.GUARD_SPLIT, p.attacker.GetName()));

			return 0;
		}
		public static async Task<u32> Effect_GuardSwap(MoveEffectParams p) {
			u16 targetDef = p.target.Def;
			u16 targetSpDef = p.target.SpDef;
			p.target.Def = p.attacker.Def;
			p.target.SpDef = p.attacker.SpDef;
			p.attacker.Def = targetDef;
			p.attacker.SpDef = targetSpDef;

			await MessageBox(Lang.GetBattleMessage(BattleMessage.GUARD_SWAP, p.attacker.GetName()));

			return 0;
		}
		public static async Task<u32> Effect_GyroBall(MoveEffectParams p) {
			// https://bulbapedia.bulbagarden.net/wiki/Gyro_Ball_(p.move)
			u16 power = 0;
			if (p.attacker.GetEffectiveSpd(p.state) == 0) {
				power = 1;
			}
			else {
				power = (u16)System.MathF.Min(150.0f, 25.0f * p.target.GetEffectiveSpd(p.state) / p.attacker.GetEffectiveSpd(p.state) + 1);
			}
			return await OverridePower(p, power);
		}
		public static async Task<u32> Effect_HappyHour(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_HealBlock(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_HeartSwap(MoveEffectParams p) {
			sbyte atk = p.target.AttackStages;
			sbyte def = p.target.DefenseStages;
			sbyte spAtk = p.target.SpecialAttackStages;
			sbyte spDef = p.target.SpecialDefenseStages;
			sbyte spd = p.target.SpeedStages;
			sbyte acc = p.target.AccuracyStages;
			sbyte eva = p.target.EvasivenessStages;

			p.target.SetStatStage(Stat.ATTACK, p.attacker.AttackStages);
			p.target.SetStatStage(Stat.DEFENSE, p.attacker.DefenseStages);
			p.target.SetStatStage(Stat.SPECIAL_ATTACK, p.attacker.SpecialAttackStages);
			p.target.SetStatStage(Stat.SPECIAL_DEFENSE, p.attacker.SpecialDefenseStages);
			p.target.SetStatStage(Stat.SPEED, p.attacker.SpeedStages);
			p.target.SetStatStage(Stat.ACCURACY, p.attacker.AccuracyStages);
			p.target.SetStatStage(Stat.EVASION, p.attacker.EvasivenessStages);

			p.attacker.SetStatStage(Stat.ATTACK, atk);
			p.attacker.SetStatStage(Stat.DEFENSE, def);
			p.attacker.SetStatStage(Stat.SPECIAL_ATTACK, spAtk);
			p.attacker.SetStatStage(Stat.SPECIAL_DEFENSE, spDef);
			p.attacker.SetStatStage(Stat.SPEED, spd);
			p.attacker.SetStatStage(Stat.ACCURACY, acc);
			p.attacker.SetStatStage(Stat.EVASION, eva);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_SWITCHED_STAT_CHANGES_WITH_TARGET, p.attacker.GetName()));
			
			return 0;
		}
		public static async Task<u32> Effect_HeavySlam(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Hex(MoveEffectParams p) {
			return await DoublePowerIf(p, p.target.HasStatus(STATUS_MASK_NON_VOLATILE));
		}
		public static async Task<u32> Effect_HydroSteam(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_HyperspaceFury(MoveEffectParams p) {
			if (p.attacker.Species != Species.HOOPA_HOOPA_CONFINED && p.attacker.Species != Species.HOOPA_HOOPA_UNBOUND) {
				return FLAG_MOVE_FAILED;
			}

			await Effect_DefenseDownHit(p);
			p.target.RemoveStatus(Status.PROTECTION);

			return await Attack(p);
		}
		public static async Task<u32> Effect_Incinerate(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_InfernalParade(MoveEffectParams p) {
			// According to Bulbapedia, power doubles if the p.target has a status condition;
			return await DoublePowerIf(p, 
				p.target.HasStatus(Status.BURN) ||
				p.target.HasStatus(Status.FREEZE) ||
				p.target.HasStatus(Status.PARALYSIS) ||
				p.target.IsPoisoned() ||
				p.target.IsAsleep()
			);
		}
		public static async Task<u32> Effect_Infestation(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Instruct(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_IonDeluge(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Judgment(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_KingsShield(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_LaserFocus(MoveEffectParams p) {
			p.target.GiveStatus(Status.LASER_FOCUS);
			p.target.SetStatusParam(StatusParam.LASER_FOCUS, 1);
			return 0;
		}
		public static async Task<u32> Effect_LashOut(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_LastResort(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_LastRespects(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_LuckyChant(MoveEffectParams p) {
			p.target.GiveStatus(Status.LUCKY_CHANT);
			return 0;
		}
		public static async Task<u32> Effect_LunarBlessing(MoveEffectParams p) {
			return await Effect_HealQuarterHit(p) | await Effect_CureNonVolatileStatusHit(p);
		}
		public static async Task<u32> Effect_LunarDance(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_MagicPowder(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_MagicRoom(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_MagnetRise(MoveEffectParams p) {
			// TODO:
			//p.target.GiveStatus(Status.MAGNETIC_LEVITATION;
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_BEGAN_LEVITATING, p.target.GetName()));
			return 0;
		}
		public static async Task<u32> Effect_MakeItRain(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_MatBlock(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_MeFirst(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_MetalBurst(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_MiracleEye(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_MoongeistBeam(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_MultiAttack(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_MysticalPower(MoveEffectParams p) {
			u32 flags = await Attack(p);

			u16 atk = (u16)(p.attacker.EffAtk(p.state) + p.attacker.EffSpAtk(p.state));
			u16 def = (u16)(p.attacker.EffDef(p.state) + p.attacker.EffSpDef(p.state));

			if (atk >= def) {
				flags |= await Effect_AttackUp(p);
				flags |= await Effect_SpecialAttackUp(p);
			}
			else {
				flags |= await Effect_DefenseUp(p);
				flags |= await Effect_SpecialDefenseUp(p);
			}

			return flags;
		}
		public static async Task<u32> Effect_NaturalGift(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_NaturesMadness(MoveEffectParams p) {
			u16 damage = (u16)System.MathF.Max(1, p.target.EffHp(p.state) / 2);
			return await DoSetDamage(p, damage);
		}
		public static async Task<u32> Effect_NoRetreat(MoveEffectParams p) {
			if (p.attacker.HasStatus(Status.NO_RETREAT)) {
				return FLAG_MOVE_FAILED;
			}

			await Effect_AllStatsUp(p);

			p.attacker.GiveStatus(Status.NO_RETREAT);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CAN_NO_LONGER_ESCAPE, p.attacker.GetName()));

			return 0;
		}
		public static async Task<u32> Effect_AtkAndSpatkDownHit(MoveEffectParams p) {
			await Effect_AttackDownHit(p);
			await Effect_SpecialAttackDownHit(p);
			return 0;
		}
		public static async Task<u32> Effect_Obstruct(MoveEffectParams p) {
			if (await Effect_Protect(p) == FLAG_MOVE_FAILED) {
				return FLAG_MOVE_FAILED;
			}

			p.target.GiveStatus(Status.OBSTRUCT);

			return 0;
		}
		public static async Task<u32> Effect_Octolock(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_OdorSleuth(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_OrderUp(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Outrage(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_PartingShot(MoveEffectParams p) {
			await Effect_AttackDownHit(p);
			await Effect_SpecialAttackDownHit(p);
			await Effect_UTurn(p);
			return 0;
		}
		public static async Task<u32> Effect_Payback(MoveEffectParams p) {
			// Find where in the turn order the attacker and target first act.
			u8 orderTarget = 255, orderAttacker = 255;
			for (u8 i = 0; i < p.state.ActionCount; i++) {
				// Get the slot of the user of the action.
				u8 actionSlot = BattleActionCodes.GetBattleActionSlot(p.state.Actions[i]);
				// Look for target's action.
				if (actionSlot == p.slotTarget && orderTarget < 255) {
					orderTarget = i;
				}
				// Look for attacker's action.
				else if (actionSlot == p.slotAttacker && orderAttacker < 255) {
					orderAttacker = i;
				}
			}
			// Double move power if the target moves before the attacker.
			return await DoublePowerIf(p, orderTarget < orderAttacker);
		}
		public static async Task<u32> Effect_PhotonGeyser(MoveEffectParams p) {
			// Ignore abilities for the duration of the move.
			bool abilityAlreadySuppressed = p.target.HasStatus(Status.ABILITY_SUPPRESSION);
			p.target.GiveStatus(Status.ABILITY_SUPPRESSION);
			// Photon Geyser can be either physical or special depending on which of the user's stats is higher.
			BattleMove photonGeyser = new BattleMove(
				MoveEffectID.NONE, 
				MoveEffectID.NONE,
				p.move.moveType,
				p.move.power,
				p.move.accuracy,
				p.move.pp,
				p.move.secondaryEffectChance,
				p.move.target,
				p.move.priority,
				p.attacker.EffAtk(p.state) >= p.attacker.EffSpAtk(p.state) ? MoveCategory.PHYSICAL : MoveCategory.SPECIAL,
				p.move.flags
			);
			u32 flags = await Attack(
				new MoveEffectParams(
					p.battle,
					p.state,
					p.attacker,
					p.target,
					photonGeyser,
					p.moveID,
					p.slotAttacker,
					p.slotTarget,
					p.numTargets,
					p.actionIndex,
					p.isPrimaryEffect,
					p.i_flags 
				)
			);
			// Remove ability suppression.
			if (!abilityAlreadySuppressed) {
				p.target.RemoveStatus(Status.ABILITY_SUPPRESSION);
			}
			return flags;
		}
		public static async Task<u32> Effect_PlasmaFists(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Pluck(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_PollenPuff(MoveEffectParams p) {
			if (p.target.Side == p.attacker.Side) {
				U16 healAmount = new(p.target.GetPercentOfMaxHp(0.5f));
				await p.target.HealMon(healAmount, false);
				return 0;
			}
			else {
				return await Attack(p);
			}
		}
		public static async Task<u32> Effect_Poltergeist(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_PopulationBomb(MoveEffectParams p) {
			u8 numHits = (u8)(p.battle.Random16() % 10);
			bool skillLink = p.attacker.AbilityProc(Ability.SKILL_LINK, false);
			if (skillLink) {
				numHits = 10;
			}
			u8 actualHits = 0;

			for (u8 i = 0; i <= numHits; i++) {
				if (!skillLink && i != 0 && !BattleUtils.MoveHit(p.battle, p.state, p.attacker, p.target, p.moveID)) {
					break;
				}

				actualHits++;
				await Attack(p);
			}

			await MessageBox(Lang.GetBattleMessage(BattleMessage.HIT_N_TIMES, actualHits.ToString()));

			return 0;
		}
		public static async Task<u32> Effect_Powder(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_PowerShift(MoveEffectParams p) {
			u16 temp = p.attacker.Atk;
			p.attacker.Atk = p.attacker.Def;
			p.attacker.Def = temp;

			temp = p.attacker.SpAtk;
			p.attacker.SpAtk = p.attacker.SpDef;
			p.attacker.SpDef = temp;

			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_SWITCHED_ITS_ATTACK_AND_DEFENSE, p.attacker.GetName()));

			return 0;
		}
		public static async Task<u32> Effect_PowerSplit(MoveEffectParams p) {
			u16 avgAtk = (u16)((p.attacker.Atk + p.target.Atk) / 2);
			u16 avgSpAtk = (u16)((p.attacker.SpAtk + p.target.SpAtk) / 2);
			p.attacker.Atk = avgAtk;
			p.target.Atk = avgAtk;
			p.attacker.SpAtk = avgSpAtk;
			p.target.SpAtk = avgSpAtk;

			await MessageBox(Lang.GetBattleMessage(BattleMessage.POWER_SPLIT, p.attacker.GetName()));

			return 0;
		}
		public static async Task<u32> Effect_PowerSwap(MoveEffectParams p) {
			u16 targetAtk = p.target.Atk;
			u16 targetSpAtk = p.target.SpAtk;
			p.target.Atk = p.attacker.Atk;
			p.target.SpAtk = p.attacker.SpAtk;
			p.attacker.Atk = targetAtk;
			p.attacker.SpAtk = targetSpAtk;

			await MessageBox(Lang.GetBattleMessage(BattleMessage.POWER_SWAP, p.attacker.GetName()));

			return 0;
		}
		public static async Task<u32> Effect_PowerTrick(MoveEffectParams p) {
			u16 temp = p.attacker.Atk;
			p.attacker.Atk = p.attacker.Def;
			p.attacker.Def = temp;

			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_SWITCHED_ITS_ATTACK_AND_DEFENSE, p.attacker.GetName()));

			return 0;
		}
		public static async Task<u32> Effect_Psyblade(MoveEffectParams p) {
			if (p.attacker.IsGrounded(p.state) && (p.state.Terrain.Condition == Condition.TERRAIN_ELECTRIC)) {
				return await OverridePower(p, 120);
			}
			return await Attack(p);
		}
		public static async Task<u32> Effect_PsychicFangs(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_PsychoShift(MoveEffectParams p) {
			if (p.attacker.HasStatus(Status.BURN)) {
				await Effect_CureBurn(p);
				await Effect_BurnHit(p);
			}
			else if (p.attacker.HasStatus(Status.PARALYSIS)) {
				await Effect_CureParalysis(p);
				await Effect_ParalyzeHit(p);
			}
			else if (p.attacker.HasStatus(Status.FREEZE)) {
				await Effect_Thaw(p);
				await Effect_FreezeHit(p);
			}
			else if (p.attacker.HasStatus(Status.POISON)) {
				await Effect_CurePoison(p);
				await Effect_PoisonHit(p);
			}
			else if (p.attacker.HasStatus(Status.TOXIC)) {
				await Effect_CurePoison(p);
				await Effect_ToxicHit(p);
			}
			else if (p.attacker.HasStatus(Status.SLEEP)) {
				await Effect_WakeUp(p);
				await Effect_SleepHit(p);
			}
			return 0;
		}
		public static async Task<u32> Effect_Psyshock(MoveEffectParams p) {
			return await Attack(p, 0, -1, 0, p.target.EffDef(p.state));
		}
		public static async Task<u32> Effect_Punishment(MoveEffectParams p) {
			u16 stages = 0;

			stages += (u16)System.MathF.Max(0, p.target.AttackStages);
			stages += (u16)System.MathF.Max(0, p.target.DefenseStages);
			stages += (u16)System.MathF.Max(0, p.target.SpecialAttackStages);
			stages += (u16)System.MathF.Max(0, p.target.SpecialDefenseStages);
			stages += (u16)System.MathF.Max(0, p.target.SpeedStages);
			stages += (u16)System.MathF.Max(0, p.target.AccuracyStages);
			stages += (u16)System.MathF.Max(0, p.target.EvasivenessStages);

			u16 power = (u16)(p.move.power + 20 * stages);
			return await OverridePower(p, power);
		}
		public static async Task<u32> Effect_Quash(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_QuickGuard(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Rage(MoveEffectParams p) {
			p.attacker.GiveStatus(Status.RAGE);
			return 0;
		}
		public static async Task<u32> Effect_RageFist(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_ReflectType(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Retaliate(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_RevelationDance(MoveEffectParams p) {
			return await OverrideType(p, p.attacker.types[0]);
		}
		public static async Task<u32> Effect_RevivalBlessing(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_RisingVoltage(MoveEffectParams p) {
			return await DoublePowerIf(p, p.attacker.IsGrounded(p.state) && (p.state.Terrain.Condition == Condition.TERRAIN_ELECTRIC));
		}
		public static async Task<u32> Effect_Rototiller(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Round(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_AttackAndThawHit(MoveEffectParams p) {
			u32 flags = await Attack(p);
			flags |= await Effect_ThawHit(p);
			return flags;
		}
		public static async Task<u32> Effect_SaltCure(MoveEffectParams p) {
			p.target.GiveStatus(Status.SALT_CURE);
			return 0;
		}
		public static async Task<u32> Effect_ScaleShot(MoveEffectParams p) {
			u32 flags = await Effect_MultiHit(p);
			flags |= await Effect_SpeedUp(p);
			flags |= await Effect_DefenseDown(p);
			return flags;
		}
		public static async Task<u32> Effect_ScorchingSands(MoveEffectParams p) {
			u32 flags = await Attack(p);
			flags |= await Effect_ThawHit(p);
			return flags;
		}
		public static async Task<u32> Effect_SecretSword(MoveEffectParams p) {
			return await Attack(p, 0, -1, 0, p.target.EffDef(p.state));
		}
		public static async Task<u32> Effect_ShellSideArm(MoveEffectParams p) {
			Mods damageMods = new Mods(p, CritRate(p));
			u16 physDamage = CalcDamage(p, damageMods, new Overrides(p.attacker.EffAtk(p.state), p.target.EffDef(p.state), 0, 0));
			u16 specDamage = CalcDamage(p, damageMods, new Overrides(p.attacker.EffSpAtk(p.state), p.target.EffSpDef(p.state), 0, 0));

			return await DoSetDamage(p, (u16)System.MathF.Max(physDamage, specDamage));
		}
		public static async Task<u32> Effect_ShellSmash(MoveEffectParams p) {
			return 
				await Effect_DefenseDown(p) |
				await Effect_SpecialDefenseDown(p) |
				await Effect_AttackUp2(p) |
				await Effect_SpecialAttackUp2(p);
		}
		public static async Task<u32> Effect_ShellTrap(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_ShiftGear(MoveEffectParams p) {
			return 
				await Effect_SpeedUp2(p) |
				await Effect_AttackUp(p);
		}
		public static async Task<u32> Effect_ShoreUp(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_SilkTrap(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_SimpleBeam(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_GroundHit(MoveEffectParams p) {
			p.target.GiveStatus(Status.GROUNDED);
			p.target.RemoveStatus(Status.MAGNETIC_LEVITATION);
			p.target.RemoveStatus(Status.TELEKINESIS);
			return 0;
		}
		public static async Task<u32> Effect_SnipeShot(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Soak(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_SpectralThief(MoveEffectParams p) {
			sbyte atk = p.target.AttackStages;
			sbyte def = p.target.DefenseStages;
			sbyte spAtk = p.target.SpecialAttackStages;
			sbyte spDef = p.target.SpecialDefenseStages;
			sbyte spd = p.target.SpeedStages;
			sbyte acc = p.target.AccuracyStages;
			sbyte eva = p.target.EvasivenessStages;

			await MessageBox(Lang.GetBattleMessage(BattleMessage.STAT_CHANGES_REMOVED, p.attacker.GetName()));

			if (atk > 0) {
				await ChangeStat(p.state, p.target, (sbyte)(-atk), Stat.ATTACK);
				await ChangeStat(p.state, p.attacker, atk, Stat.ATTACK);
			}
			if (def > 0) {
				await ChangeStat(p.state, p.target, (sbyte)(-def), Stat.DEFENSE);
				await ChangeStat(p.state, p.attacker, def, Stat.DEFENSE);
			}
			if (spAtk > 0) {
				await ChangeStat(p.state, p.target, (sbyte)(-spAtk), Stat.SPECIAL_ATTACK);
				await ChangeStat(p.state, p.attacker, spAtk, Stat.SPECIAL_ATTACK);
			}
			if (spDef > 0) {
				await ChangeStat(p.state, p.target, (sbyte)(-spDef), Stat.SPECIAL_DEFENSE);
				await ChangeStat(p.state, p.attacker, spDef, Stat.SPECIAL_DEFENSE);
			}
			if (spd > 0) {
				await ChangeStat(p.state, p.target, (sbyte)(-spd), Stat.SPEED);
				await ChangeStat(p.state, p.attacker, spd, Stat.SPEED);
			}
			if (acc > 0) {
				await ChangeStat(p.state, p.target, (sbyte)(-acc), Stat.ACCURACY);
				await ChangeStat(p.state, p.attacker, acc, Stat.ACCURACY);
			}
			if (eva > 0) {
				await ChangeStat(p.state, p.target, (sbyte)(-eva), Stat.EVASION);
				await ChangeStat(p.state, p.attacker, eva, Stat.EVASION);
			}

			return 0;
		}
		public static async Task<u32> Effect_SpeedSwap(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_SpicyExtract(MoveEffectParams p) {
			return await Effect_AttackUpHit2(p) | await Effect_DefenseDownHit2(p);
		}
		public static async Task<u32> Effect_SpiderWeb(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_SpikyShield(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_SteamEruption(MoveEffectParams p) {
			return await Attack(p) | await Effect_ThawHit(p);
		}
		public static async Task<u32> Effect_Steamroller(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_StompingTantrum(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_StoredPower(MoveEffectParams p) {
			u8 atk = (u8)System.MathF.Max(0, p.target.AttackStages);
			u8 def = (u8)System.MathF.Max(0, p.target.DefenseStages);
			u8 spAtk = (u8)System.MathF.Max(0, p.target.SpecialAttackStages);
			u8 spDef = (u8)System.MathF.Max(0, p.target.SpecialDefenseStages);
			u8 spd = (u8)System.MathF.Max(0, p.target.SpeedStages);
			u8 acc = (u8)System.MathF.Max(0, p.target.AccuracyStages);
			u8 eva = (u8)System.MathF.Max(0, p.target.EvasivenessStages);

			u16 power = (u16)(20 + 20 * (atk + def + spAtk + spDef + spd + acc + eva));
			return await OverridePower(p, power);
		}
		public static async Task<u32> Effect_Struggle(MoveEffectParams p) {
			// TODO: struggle's recoil damages through wonder guard.
			return await Attack(p) |
				await Effect_RecoilQuarterMaxHp(p);
		}
		public static async Task<u32> Effect_StuffCheeks(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_SuckerPunch(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_SunsteelStrike(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Surf(MoveEffectParams p) {
			return await DoublePowerIf(p, p.target.HasStatus(Status.SEMI_INVULNERABLE_TURN));
		}
		public static async Task<u32> Effect_SurgingStrikes(MoveEffectParams p) {
			u8 numHits = 3;
			for (u8 i = 0; i < numHits; i++) {
				await Effect_Hit(p);
				if (p.target.EffHp(p.state) == 0) {
					numHits = (u8)(i + 1);
					break;
				}
			}
			await MessageBox(Lang.GetBattleMessage(BattleMessage.HIT_N_TIMES, numHits.ToString()));
			return 0;
		}
		public static async Task<u32> Effect_Switcheroo(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Synchronoise(MoveEffectParams p) {
			// Only damage targets that share a type with the user.
			bool targetSharesType = false;
			for (u8 i = 0; i < p.attacker.types.Count; i++) {
				if (p.target.HasType(p.attacker.types[i])) {
					targetSharesType = true;
					break;
				}
			}
			if (targetSharesType) {
				return await Attack(p);
			}
			return 0;
		}
		public static async Task<u32> Effect_Tailwind(MoveEffectParams p) {
			p.state.SetSideCondition(p.attacker.Side, Condition.TAILWIND, p.attacker);
			if (p.attacker.Side == Battle.SIDE_CLIENT) {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.ALLY_TAILWIND_START));
			}
			else {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.ENEMY_TAILWIND_START));
			}
			return 0;
		}
		public static async Task<u32> Effect_TakeHeart(MoveEffectParams p) {
			await Effect_CureNonVolatileStatusHit(p);
			await Effect_SpecialAttackUpHit(p);
			await Effect_SpecialDefenseUpHit(p);
			return 0;
		}
		public static async Task<u32> Effect_TarShot(MoveEffectParams p) {
			await Effect_SpeedDownHit(p);
			p.target.GiveStatus(Status.TAR_SHOT);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_BECAME_WEAKER_TO_FIRE, p.target.GetName()));
			return 0;
		}
		public static async Task<u32> Effect_TearfulLook(MoveEffectParams p) {
			return await Effect_AttackDownHit(p) | await Effect_SpecialAttackDownHit(p);
		}
		public static async Task<u32> Effect_Teatime(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_TechnoBlast(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Telekinesis(MoveEffectParams p) {
			// TODO:
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_HURLED_INTO_AIR, p.target.GetName()));
			return 0;
		}
		public static async Task<u32> Effect_TerrainPulse(MoveEffectParams p) {
			Type type = Type.NORMAL;
			switch (p.state.Terrain.Condition) {
				case Condition.TERRAIN_ELECTRIC:
					type = Type.ELECTRIC;
					break;
				case Condition.TERRAIN_GRASSY:
					type = Type.GRASS;
					break;
				case Condition.TERRAIN_MISTY:
					type = Type.FAIRY;
					break;
				case Condition.TERRAIN_PSYCHIC:
					type = Type.PSYCHIC;
					break;
				default:
					type = Type.NORMAL;
					break;
			}
			BattleMove terrainPulse = new BattleMove(
				MoveEffectID.NONE, 
				MoveEffectID.NONE,
				type,
				p.move.power,
				p.move.accuracy,
				p.move.pp,
				p.move.secondaryEffectChance,
				p.move.target,
				p.move.priority,
				p.move.moveCat,
				p.move.flags
			);
			p = new MoveEffectParams(
				p.battle,
				p.state,
				p.attacker,
				p.target,
				terrainPulse,
				p.moveID,
				p.slotAttacker,
				p.slotTarget,
				p.numTargets,
				p.actionIndex,
				p.isPrimaryEffect,
				p.i_flags 
			);
			return await DoublePowerIf(p, p.state.Terrain.Condition != Condition.TERRAIN_NONE);
			
		}
		public static async Task<u32> Effect_ThousandArrows(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_ThousandWaves(MoveEffectParams p) {
			u32 flags = await Attack(p);
			p.target.GiveStatus(Status.CANT_ESCAPE);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_TRAPPED_MON, p.attacker.GetName(), p.target.GetName()));
			return flags;
		}
		public static async Task<u32> Effect_ThroatChop(MoveEffectParams p) {
			p.target.GiveStatus(Status.THROAT_CHOP);
			p.target.SetStatusParam(StatusParam.THROAT_CHOP, 2);
			//BM_PARAMS[0] = GetMonName(p.target.mon);
			//await MessageBox(Lang.GetBattleMessage(BattleMessage.THROAT_CHOP_PREVENTS_MON_FROM_USING_CERTAIN_MOVES));
			return 0;
		}
		public static async Task<u32> Effect_TidyUp(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_TopsyTurvy(MoveEffectParams p) {
			sbyte atk = p.target.AttackStages;
			sbyte def = p.target.DefenseStages;
			sbyte spAtk = p.target.SpecialAttackStages;
			sbyte spDef = p.target.SpecialDefenseStages;
			sbyte spd = p.target.SpeedStages;
			sbyte acc = p.target.AccuracyStages;
			sbyte eva = p.target.EvasivenessStages;

			if (atk == 0 &&
				def == 0 &&
				spAtk == 0 &&
				spDef == 0 &&
				spd == 0 &&
				acc == 0 &&
				eva == 0
			) {
				return FLAG_MOVE_FAILED;
			}

			p.target.SetStatStage(Stat.ATTACK, (sbyte)-atk);
			p.target.SetStatStage(Stat.DEFENSE, (sbyte)-def);
			p.target.SetStatStage(Stat.SPECIAL_ATTACK, (sbyte)-spAtk);
			p.target.SetStatStage(Stat.SPECIAL_DEFENSE, (sbyte)-spDef);
			p.target.SetStatStage(Stat.SPEED, (sbyte)-spd);
			p.target.SetStatStage(Stat.ACCURACY, (sbyte)-acc);
			p.target.SetStatStage(Stat.EVASION, (sbyte)-eva);

			await MessageBox(Lang.GetBattleMessage(BattleMessage.STAT_CHANGES_INVERTED, p.target.GetName()));

			return 0;
		}
		public static async Task<u32> Effect_TrickRoom(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_TrickOrTreat(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_TripleArrows(MoveEffectParams p) {
			if (p.battle.Random01() < 0.5f) {
				await Effect_DefenseDownHit(p);
			}
			if (p.battle.Random01() < 0.3f) {
				await Effect_FlinchHit(p);
			}
			return 0;
		}
		public static async Task<u32> Effect_TripleAxel(MoveEffectParams p) {
			// Hit between 2 and 5 times.
			u8 numHits = (u8)(p.battle.Random16() % 4 + 2);
			u8 actualHits = 0;

			if (p.attacker.AbilityProc(Ability.SKILL_LINK, false)) {
				numHits = 5;
			}

			for (u8 i = 0; i < numHits; i++) {
				if (!(i == 0) && !BattleUtils.MoveHit(p.battle, p.state, p.attacker, p.target, p.moveID)) {
					break;
				}

				actualHits++;
				await OverridePower(p, (u16)(p.move.power + (20 * i)));
			}

			await MessageBox(Lang.GetBattleMessage(BattleMessage.HIT_N_TIMES, actualHits.ToString()));

			return 0;
		}
		public static async Task<u32> Effect_TripleDive(MoveEffectParams p) {
			for (u8 i = 0; i < 3; i++) {
				await Attack(p);
			}

			await MessageBox(Lang.GetBattleMessage(BattleMessage.HIT_N_TIMES, "3"));

			return 0;
		}
		public static async Task<u32> Effect_TrumpCard(MoveEffectParams p) {
			u8 power = 0;
			// https://bulbapedia.bulbagarden.net/wiki/Trump_Card_(p.move)

			u8 pp = p.attacker.Mon.PP[p.attacker.GetStatusParam(StatusParam.LAST_USED_MOVE)];
			if (pp > 4) {
				power = 40;
			}
			else if (pp == 4) {
				power = 50;
			}
			else if (pp == 3) {
				power = 60;
			}
			else if (pp == 2) {
				power = 80;
			}
			else if (pp <= 1) {
				power = 200;
			}

			return await OverridePower(p, power);
		}
		public static async Task<u32> Effect_UTurn(MoveEffectParams p) {
			if (p.battle.isReplay) {
				return 0;
			}

			// Do nothing if a wild mon uses this.
			if (p.attacker.Mon.Box.IsWild) {
				return 0;
			}

			TrainerBattleContext context = p.battle.PlayerControllingSlot(p.slotAttacker);

			// Do nothing if the user's team only has 1 available mon.
			if (context.NumAvailableMons() <= 1) {
				return 0;
			}

			u64 action = await context.controller.MenuSelectSwitchToMon(p.battle, p.state, p.slotAttacker);
			p.state.InsertAction(action, p.actionIndex);

			return 0;
		}
		public static async Task<u32> Effect_VCreate(MoveEffectParams p) {
			return 
				await Effect_DefenseDown(p) |
				await Effect_SpecialDefenseDown(p) |
				await Effect_SpeedDown(p);
		}
		public static async Task<u32> Effect_VenomDrench(MoveEffectParams p) {
			if (p.target.IsPoisoned()) {
				await Effect_AttackDownHit(p);
				await Effect_SpecialAttackDownHit(p);
				await Effect_SpeedDownHit(p);
			}
			else {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.IMMUNE, p.target.GetName()));
			}

			return 0;
		}
		public static async Task<u32> Effect_Venoshock(MoveEffectParams p) {
			return await DoublePowerIf(p, p.target.IsPoisoned());
		}
		public static async Task<u32> Effect_WakeUpSlap(MoveEffectParams p) {
			return await DoublePowerIf(p, p.target.IsAsleep());
		}
		public static async Task<u32> Effect_WideGuard(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_WonderRoom(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_WorrySeed(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_WringOut(MoveEffectParams p) {
			// https://bulbapedia.bulbagarden.net/wiki/Wring_Out_(p.move)
			// *Slightly* different from Eruption.
			u16 power = (u16)System.Math.Clamp(120.0f * p.attacker.EffHp(p.state) / p.attacker.EffMaxHp(p.state), 1, 120);
			return await OverridePower(p, power);
		}
		public static async Task<u32> Effect_AllySwitch(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_AfterYou(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Transform(MoveEffectParams p) {
			if (p.target.HasStatus(Status.TRANSFORMED | Status.ILLUSION)) {
				return FLAG_MOVE_FAILED;
			}
			if (p.target.AbilityProc(Ability.GOOD_AS_GOLD, true)) {
				return FLAG_MOVE_FAILED;
			}

			p.attacker.ChangeSpecies(p.target.Species);
			p.attacker.ability	= p.target.ability;

			p.attacker.Atk		= p.target.Atk;
			p.attacker.Def		= p.target.Def;
			p.attacker.SpAtk	= p.target.SpAtk;
			p.attacker.SpDef	= p.target.SpDef;
			p.attacker.Spd		= p.target.Spd;

			p.attacker.types = new System.Collections.Generic.List<Type>();
			for (u8 i = 0; i < p.target.types.Count; i++) {
				p.attacker.types.Add(p.target.types[i]);
			}
			for (u8 i = 0; i < Pokemon.MAX_MOVES; i++) {
				p.attacker.moves[i] = p.target.moves[i];
				p.attacker.pp[i] = p.target.pp[i];
				p.attacker.maxPP[i] = p.target.maxPP[i];
			}

			p.attacker.GiveStatus(Status.TRANSFORMED);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_TRANSFORMED_INTO_MON, p.attacker.GetName(), p.target.GetName()));
			return 0;
		}
		public static async Task<u32> Effect_CourtChange(MoveEffectParams p) {
			// TODO:
			return 0;
		}
		public static async Task<u32> Effect_Reflect(MoveEffectParams p) {
			if (p.state.SideHasCondition(p.attacker.Side, Condition.REFLECT)) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetSideCondition(p.attacker.Side, Condition.REFLECT, p.attacker);
			if (p.attacker.Side == Battle.SIDE_CLIENT) {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.ALLY_REFLECT));
			}
			else {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.OPPONENT_REFLECT));
			}
			return 0;
		}
		public static async Task<u32> Effect_LightScreen(MoveEffectParams p) {
			if (p.state.SideHasCondition(p.attacker.Side, Condition.LIGHT_SCREEN)) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetSideCondition(p.attacker.Side, Condition.LIGHT_SCREEN, p.attacker);
			if (p.attacker.Side == Battle.SIDE_CLIENT) {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.ALLY_LIGHT_SCREEN));
			}
			else {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.OPPONENT_LIGHT_SCREEN));
			}
			return 0;
		}
		public static async Task<u32> Effect_AuroraVeil(MoveEffectParams p) {
			if (p.state.SideHasCondition(p.attacker.Side, Condition.AURORA_VEIL)) {
				return FLAG_MOVE_FAILED;
			}
			p.state.SetSideCondition(p.attacker.Side, Condition.AURORA_VEIL, p.attacker);
			if (p.attacker.Side == Battle.SIDE_CLIENT) {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.ALLY_AURORA_VEIL));
			}
			else {
				await MessageBox(Lang.GetBattleMessage(BattleMessage.OPPONENT_AURORA_VEIL));
			}
			return 0;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
		#endregion
	}
}