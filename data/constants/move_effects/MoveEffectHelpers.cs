using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

using static PkmnEngine.Global;
using static PkmnEngine.StatusEffects;
using static PkmnEngine.DamageCalc;

using PkmnEngine.Strings;

namespace PkmnEngine {
	public static partial class MoveEffects {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		private static async Task<u32> Attack(MoveEffectParams p, u16 setDamage = 0, float critChance = -1, u16 atkOverride = 0, u16 defOverride = 0, u16 powerOverride = 0) {
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
			U16 damage = new(setDamage == 0 ? CalcDamage(p.battle, p.state, p.attacker, p.target, p.moveID, p.numTargets, mods, overrides) : setDamage);

			if (p.move.moveCat == MoveCategory.PHYSICAL) {
				p.target.SetStatusParam(StatusParam.PHYS_DAMAGE_THIS_TURN, damage.Value);
			}
			else if (p.move.moveCat == MoveCategory.SPECIAL) {
				p.target.SetStatusParam(StatusParam.SPEC_DAMAGE_THIS_TURN, damage.Value);
			}

			string[] damageDetails = {
				mods.isCrit				? Lang.GetBattleMessage(BattleMessage.CRITICAL_HIT)			: null,
				type > 1				? Lang.GetBattleMessage(BattleMessage.SUPER_EFFECTIVE)		: null,
				type > 0 && type < 1	? Lang.GetBattleMessage(BattleMessage.NOT_VERY_EFFECTIVE)	: null,
				type == 0				? Lang.GetBattleMessage(BattleMessage.IMMUNE)				: null
			};

			// Deal damage to mon.
			bool fainted = !await p.target.DamageMon(damage, false, true, damageDetails);

			// Check for Destiny Bond.
			// If the target has the Destiny Bond status, and fainted when attacked...
			if (p.target.HasStatus(Status.DESTINY_BOND) && fainted) {
				// ...cause the attacker to faint.
				await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_TOOK_ITS_ATTACKER_DOWN_WITH_IT, p.target.GetName())); 
				U16 DBdamage = new(p.attacker.EffMaxHp(p.state));
				await p.attacker.DamageMon(DBdamage, true, false);
			}

			return damage.Value 
					| FLAG_DAMAGE
					| (FLAG_SPE_DAMAGE * (u32)((mods.typeEff > 1) ? 1 : 0))
					| (FLAG_NVE_DAMAGE * (u32)((mods.typeEff < 1) ? 1 : 0))
					| (FLAG_TARGET_FAINTED * (u32)(fainted ? 1 : 0))
					| (FLAG_CRIT_DAMAGE * (u32)(mods.isCrit ? 1 : 0));
		}
		private static async Task<u32> DoSetDamage(MoveEffectParams p, u16 damage) {
			return await Attack(p, damage, 0);
		}
		private static async Task<u32> OverridePower(MoveEffectParams p, u16 power) {
			return await Attack(p, 0, -1, 0, 0, power);
		}
		private static async Task<u32> DoublePowerIf(MoveEffectParams p, bool condition) {
			return await OverridePower(p, (u16)(p.move.power * 2));
		}
		private static async Task<u32> OverrideType(MoveEffectParams p, Type type) {
			BattleMove newMove = new BattleMove(
				p.move.primaryEffect,
				p.move.secondaryEffect,
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
			return await Attack(
				new MoveEffectParams(
					p.battle,
					p.state,
					p.attacker,
					p.target,
					newMove,
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

		private static float CritRate(MoveEffectParams p, sbyte bias = 0) {
			sbyte stages = bias;

			if ((p.move.flags & BattleMoves.Flag.HIGH_CRITICAL) != 0) {
				stages += 1;
			}
			if ((p.move.flags & BattleMoves.Flag.HIGH_CRITICAL2) != 0) {
				stages += 2;
			}
			if ((p.move.flags & BattleMoves.Flag.ALWAYS_CRITICAL) != 0) {
				stages += 6;
			}

			foreach (sbyte v in Battle.RunEvent<sbyte>(Callback.OnModifyCritRatio, p.attacker, new OnModifyCritRatioParams()).Result) {
				stages += v;
			}
			foreach (sbyte v in Battle.RunEvent<sbyte>(Callback.OnSourceModifyCritRatio, p.target, new OnSourceModifyCritRatioParams()).Result) {
				stages += v;
			}

			return GetEffectiveCritRate(stages);
		}

		private static async Task<u32> GiveMonNonVolatileStatus(BattleState state, BattleMon bm, Status effID, bool isPrimaryEffect, u8 duration) {
			// Mon already has a non-volatile status and we cannot add another.
			if (bm.HasStatus(STATUS_MASK_NON_VOLATILE)) {
				// We only send the message if the move being used is a status move.
				// This way, we avoid sending the message for secondary effects.
				if (isPrimaryEffect) {
					if (bm.HasStatus(Status.BURN)) {
						await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_ALREADY_BURNED, bm.GetName()));
					}
					else if (bm.HasStatus(Status.FREEZE)) {
						await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_ALREADY_FROZEN, bm.GetName()));
					}
					else if (bm.HasStatus(Status.PARALYSIS)) {
						await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_ALREADY_PARALYZED, bm.GetName()));
					}
					else if (bm.HasStatus(Status.POISON, Status.TOXIC)) {
						await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_ALREADY_POISONED, bm.GetName()));
					}
					else if (bm.HasStatus(Status.SLEEP, Status.DROWSY)) {
						await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_ALREADY_ASLEEP, bm.GetName()));
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
							await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_BE_BURNED, bm.GetName()));
							return 1;
						}
						status = Status.BURN;
						msg = Lang.GetBattleMessage(BattleMessage.MON_WAS_BURNED, bm.GetName());
						break;
					case Status.FREEZE:
						if (!bm.CanBeFrozen(state)) {
							await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_BE_FROZEN, bm.GetName()));
							return 1;
						}
						status = Status.FREEZE;
						msg = Lang.GetBattleMessage(BattleMessage.MON_WAS_FROZEN, bm.GetName());
						break;
					case Status.PARALYSIS:
						if (!bm.CanBeParalyzed(state)) {
							await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_BE_PARALYZED, bm.GetName()));
							return 1;
						}
						status = Status.PARALYSIS;
						msg = Lang.GetBattleMessage(BattleMessage.MON_WAS_PARALYZED, bm.GetName());
						break;
					case Status.POISON:
						if (!bm.CanBePoisoned(state)) {
							await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_BE_POISONED, bm.GetName()));
							return 1;
						}
						status = Status.POISON;
						msg = Lang.GetBattleMessage(BattleMessage.MON_WAS_POISONED, bm.GetName());
						break;
					case Status.TOXIC:
						if (!bm.CanBePoisoned(state)) {
							await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_BE_POISONED, bm.GetName()));
							return 1;
						}
						status = Status.TOXIC;
						msg = Lang.GetBattleMessage(BattleMessage.MON_WAS_BADLY_POISONED, bm.GetName());
						break;
					case Status.SLEEP:
						if (!bm.CanFallAsleep(state)) {
							await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CANNOT_FALL_ASLEEP, bm.GetName()));
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
				await MessageBox(msg);
				return 0;
			}
		}
	
		private static async Task<u32> DoRecoilDamage(MoveEffectParams p, U16 recoil) {
			await p.attacker.DamageMon(recoil, true, false, Lang.GetBattleMessage(BattleMessage.MON_DAMAGED_BY_RECOIL, p.attacker.GetName()));
			return recoil.Value;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}