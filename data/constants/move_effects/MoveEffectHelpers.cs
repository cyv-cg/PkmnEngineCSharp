using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.StatusEffects;
using static PkmnEngine.DamageCalc;

using PkmnEngine.Strings;

namespace PkmnEngine {
	public static partial class MoveEffects {
		private static u32 Attack(MoveEffectParams p, u16 setDamage = 0, float critChance = -1, u16 atkOverride = 0, u16 defOverride = 0, u16 powerOverride = 0) {
			if (critChance < 0) {
				critChance = CritRate(p);
			}
			DamageCalc.Mods mods = new Mods(p, critChance);

			float type = 1;
			if (p.moveID == BattleMoveID.FLYING_PRESS) {
				type *= TypeEffectiveness(p.target, Type.FLYING) * TypeEffectiveness(p.target, Type.FIGHTING);
			}
			else {
				type *= TypeEffectiveness(p.target, p.move.moveType);
			}
			if (p.moveID == BattleMoveID.FREEZE_DRY) {
				if (p.target.HasType(Type.WATER)) {
					type *= 2;
				}
			}

			DamageCalc.Overrides overrides = new Overrides(atkOverride, defOverride, powerOverride, setDamage);
			u16 damage = setDamage == 0 ? CalcDamage(p.battle, p.state, p.attacker, p.target, p.moveID, p.numTargets, mods, overrides) : setDamage;

			if (p.move.moveCat == MoveCategory.PHYSICAL) {
				p.target.SetStatusParam(StatusParam.PHYS_DAMAGE_THIS_TURN, damage);
			}
			else if (p.move.moveCat == MoveCategory.SPECIAL) {
				p.target.SetStatusParam(StatusParam.SPEC_DAMAGE_THIS_TURN, damage);
			}

			// Deal damage to mon.
			bool fainted = !p.target.DamageMon(p.state, ref damage, false, true);

			if (mods.isCrit) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.CRITICAL_HIT));
			}
			if (type > 1) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.SUPER_EFFECTIVE));
			}
			else if (type > 0 && type < 1) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.NOT_VERY_EFFECTIVE));
			}
			else if (type == 0) {
				MessageBox(Lang.GetBattleMessage(BattleMessage.IMMUNE));
			}

			// Check for Destiny Bond.
			// If the target has the Destiny Bond status, and fainted when attacked...
			if (p.target.HasStatus(Status.DESTINY_BOND) && fainted) {
				// ...cause the attacker to faint.
				MessageBox(Lang.GetBattleMessage(BattleMessage.MON_TOOK_ITS_ATTACKER_DOWN_WITH_IT, p.target.GetName())); 
				u16 DBdamage = p.target.EffMaxHp(p.state);
				p.attacker.DamageMon(p.state, ref damage, true, false);
			}

			return damage 
					| FLAG_DAMAGE
					| (FLAG_SPE_DAMAGE * (u32)((mods.typeEff > 1) ? 1 : 0))
					| (FLAG_NVE_DAMAGE * (u32)((mods.typeEff < 1) ? 1 : 0))
					| (FLAG_TARGET_FAINTED * (u32)(fainted ? 1 : 0))
					| (FLAG_CRIT_DAMAGE * (u32)(mods.isCrit ? 1 : 0));
		}
		private static u32 DoSetDamage(MoveEffectParams p, u16 damage) {
			return Attack(p, damage, 0);
		}
		private static u32 OverridePower(MoveEffectParams p, u16 power) {
			return Attack(p, 0, -1, 0, 0, power);
		}

		private static float CritRate(MoveEffectParams p, sbyte bias = 0) {
			sbyte stages = bias;

			if (p.attacker.HasStatus(Status.GETTING_PUMPED)) {
				stages++;
			}

			//TODO: if (b_AbilityProc(p.state, p.attacker, ABILITY_SUPER_LUCK, false)) {
			//	stages++;
			//}

			if ((p.move.flags & BattleMoves.Flag.HIGH_CRITICAL) != 0) {
				stages++;
			}
			if ((p.move.flags & BattleMoves.Flag.HIGH_CRITICAL2) != 0) {
				stages += 2;
			}
			if ((p.move.flags & BattleMoves.Flag.ALWAYS_CRITICAL) != 0) {
				stages += 6;
			}

			//TODO: if (b_AbilityProc(p.state, p.target, ABILITY_BATTLE_ARMOR, false) || b_AbilityProc(p.state, p.target, ABILITY_SHELL_ARMOR, false)) {
				//stages = MIN_STAT_STAGE;
			//}

			return GetEffectiveCritRate(stages);
		}

		private static u32 GiveMonNonVolatileStatus(BattleState state, BattleMon bm, Status effID, bool isPrimaryEffect, u8 duration) {
			// Mon already has a non-volatile status and we cannot add another.
			if (bm.HasStatus(STATUS_MASK_NON_VOLATILE)) {
				// We only send the message if the move being used is a status move.
				// This way, we avoid sending the message for secondary effects.
				if (isPrimaryEffect) {
					if (bm.HasStatus(Status.BURN)) {
						MessageBox(Lang.GetBattleMessage(BattleMessage.MON_ALREADY_BURNED, bm.GetName()));
					}
					else if (bm.HasStatus(Status.FREEZE)) {
						MessageBox(Lang.GetBattleMessage(BattleMessage.MON_ALREADY_FROZEN, bm.GetName()));
					}
					else if (bm.HasStatus(Status.PARALYSIS)) {
						MessageBox(Lang.GetBattleMessage(BattleMessage.MON_ALREADY_PARALYZED, bm.GetName()));
					}
					else if (bm.HasStatus(Status.POISON, Status.TOXIC)) {
						MessageBox(Lang.GetBattleMessage(BattleMessage.MON_ALREADY_POISONED, bm.GetName()));
					}
					else if (bm.HasStatus(Status.SLEEP, Status.DROWSY)) {
						MessageBox(Lang.GetBattleMessage(BattleMessage.MON_ALREADY_ASLEEP, bm.GetName()));
					}
				}
				return 1;
			}
			else {
				Status status;
				string msg;
				switch (effID) {
					case Status.BURN:
						if (!bm.CanBeBurned(state)) {
							MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_BE_BURNED, bm.GetName()));
							return 1;
						}
						status = Status.BURN;
						msg = Lang.GetBattleMessage(BattleMessage.MON_WAS_BURNED, bm.GetName());
						break;
					case Status.FREEZE:
						if (!bm.CanBeFrozen(state)) {
							MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_BE_FROZEN, bm.GetName()));
							return 1;
						}
						status = Status.FREEZE;
						msg = Lang.GetBattleMessage(BattleMessage.MON_WAS_FROZEN, bm.GetName());
						break;
					case Status.PARALYSIS:
						if (!bm.CanBeParalyzed(state)) {
							MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_BE_PARALYZED, bm.GetName()));
							return 1;
						}
						status = Status.PARALYSIS;
						msg = Lang.GetBattleMessage(BattleMessage.MON_WAS_PARALYZED, bm.GetName());
						break;
					case Status.POISON:
						if (!bm.CanBePoisoned(state)) {
							MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_BE_POISONED, bm.GetName()));
							return 1;
						}
						status = Status.POISON;
						msg = Lang.GetBattleMessage(BattleMessage.MON_WAS_POISONED, bm.GetName());
						break;
					case Status.TOXIC:
						if (!bm.CanBePoisoned(state)) {
							MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_BE_POISONED, bm.GetName()));
							return 1;
						}
						status = Status.TOXIC;
						msg = Lang.GetBattleMessage(BattleMessage.MON_WAS_BADLY_POISONED, bm.GetName());
						break;
					case Status.SLEEP:
						if (!bm.CanFallAsleep(state)) {
							MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_FALL_ASLEEP, bm.GetName()));
							return 1;
						}
						status = Status.SLEEP;
						msg = Lang.GetBattleMessage(BattleMessage.MON_FELL_ASLEEP, bm.GetName());
						break;
					default:
						return 1;
				}
				bm.GiveStatus(status);
				bm.SetStatusParam(StatusParam.NV_STATUS_DURATION, duration);
				MessageBox(msg);
				return 0;
			}
		}
	
		private static u32 DoRecoilDamage(MoveEffectParams p, ref u16 recoil) {
			p.attacker.DamageMon(p.state, ref recoil, true, false);
			MessageBox(Lang.GetBattleMessage(BattleMessage.MON_DAMAGED_BY_RECOIL, p.attacker.GetName()));
			return recoil;
		}
	}
}