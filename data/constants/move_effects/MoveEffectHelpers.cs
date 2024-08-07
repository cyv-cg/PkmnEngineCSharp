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
		private const StringResource.Namespace STRINGS = StringResource.Namespace.BATTLE_COMMON;

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
				mods.isCrit				? Lang.GetString(STRINGS, BATTLE_COMMON.A_CRITICAL_HIT)			: null,
				type > 1				? Lang.GetString(STRINGS, BATTLE_COMMON.ITS_SUPER_EFFECTIVE)	: null,
				type > 0 && type < 1	? Lang.GetString(STRINGS, BATTLE_COMMON.ITS_NOT_VERY_EFFECTIVE)	: null,
				type == 0				? Lang.GetString(STRINGS, BATTLE_COMMON.MON_IS_NOT_AFFECTED, p.target.GetName()) : null
			};

			// Deal damage to mon.
			bool fainted = !await p.target.DamageMon(damage, false, true, damageDetails);

			// Check for Destiny Bond.
			// If the target has the Destiny Bond status, and fainted when attacked...
			if (p.target.HasStatus(Status.DESTINY_BOND) && fainted) {
				// ...cause the attacker to faint.
				await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_TOOK_ITS_ATTACKER_DOWN_WITH_IT, p.target), p.target.GetName())); 
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
						await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_IS_ALREADY_BURNED, bm), bm.GetName()));
					}
					else if (bm.HasStatus(Status.FREEZE)) {
						await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_IS_ALREADY_FROZEN, bm), bm.GetName()));
					}
					else if (bm.HasStatus(Status.PARALYSIS)) {
						await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_ALREADY_PARALYZED, bm), bm.GetName()));
					}
					else if (bm.HasStatus(Status.POISON, Status.TOXIC)) {
						await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_IS_ALREADY_POISONED, bm), bm.GetName()));
					}
					else if (bm.HasStatus(Status.SLEEP, Status.DROWSY)) {
						await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_IS_ALREADY_ASLEEP, bm), bm.GetName()));
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
							await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_CANNOT_BE_BURNED, bm), bm.GetName()));
							return 1;
						}
						status = Status.BURN;
						msg = Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_WAS_BURNED, bm), bm.GetName());
						break;
					case Status.FREEZE:
						if (!bm.CanBeFrozen(state)) {
							await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_CANNOT_BE_FROZEN, bm), bm.GetName()));
							return 1;
						}
						status = Status.FREEZE;
						msg = Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_BECAME_FROZEN, bm), bm.GetName());
						break;
					case Status.PARALYSIS:
						if (!bm.CanBeParalyzed(state)) {
							await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_CANNOT_BE_PARALYZED, bm), bm.GetName()));
							return 1;
						}
						status = Status.PARALYSIS;
						msg = Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_BECAME_PARALYZED, bm), bm.GetName());
						break;
					case Status.POISON:
						if (!bm.CanBePoisoned(state)) {
							await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_CANNOT_BE_POISONED, bm), bm.GetName()));
							return 1;
						}
						status = Status.POISON;
						msg = Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_WAS_POISONED, bm), bm.GetName());
						break;
					case Status.TOXIC:
						if (!bm.CanBePoisoned(state)) {
							await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_CANNOT_BE_POISONED, bm), bm.GetName()));
							return 1;
						}
						status = Status.TOXIC;
						msg = Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_WAS_BADLY_POISONED, bm), bm.GetName());
						break;
					case Status.SLEEP:
						if (!bm.CanFallAsleep(state)) {
							await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_CANNOT_FALL_ASLEEP, bm), bm.GetName()));
							return 1;
						}
						status = Status.SLEEP;
						msg = Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_FELL_ASLEEP, bm), bm.GetName());
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
			await p.attacker.DamageMon(recoil, true, false, Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_DAMAGED_BY_RECOIL, p.attacker), p.attacker.GetName()));
			return recoil.Value;
		}

		private static async Task<u32> ClearScreens(MoveEffectParams p, u8 side) {
			// Clear screens.
			if (p.state.SideHasCondition(side, Condition.LIGHT_SCREEN)) {
				p.state.RemoveCondition(Condition.LIGHT_SCREEN, side);
				await MessageBox(Lang.GetString(STRINGS, side == Battle.SIDE_CLIENT ? BATTLE_COMMON.ALLY_LIGHT_SCREEN_WORE_OFF : BATTLE_COMMON.OPPONENT_LIGHT_SCREEN_WORE_OFF));
			}
			if (p.state.SideHasCondition(side, Condition.REFLECT)) {
				p.state.RemoveCondition(Condition.REFLECT, side);
				await MessageBox(Lang.GetString(STRINGS, side == Battle.SIDE_CLIENT ? BATTLE_COMMON.ALLY_REFLECT_WORE_OFF : BATTLE_COMMON.OPPONENT_REFLECT_WORE_OFF));
			}
			if (p.state.SideHasCondition(side, Condition.AURORA_VEIL)) {
				p.state.RemoveCondition(Condition.AURORA_VEIL, side);
				await MessageBox(Lang.GetString(STRINGS, side == Battle.SIDE_CLIENT ? BATTLE_COMMON.ALLY_AURORA_VEIL_WORE_OFF : BATTLE_COMMON.OPPONENT_AURORA_VEIL_WORE_OFF));
			}
			return 0;
		}
		private static async Task<u32> ClearHazards(MoveEffectParams p, u8 side) {
			if (p.state.SideHasCondition(side, Condition.SPIKES1, Condition.SPIKES2, Condition.SPIKES3)) {
				p.state.RemoveCondition(Condition.SPIKES1);
				p.state.RemoveCondition(Condition.SPIKES2);
				p.state.RemoveCondition(Condition.SPIKES3);
				await MessageBox(Lang.GetString(STRINGS, side == Battle.SIDE_CLIENT ? BATTLE_COMMON.ALLY_SPIKES_REMOVED : BATTLE_COMMON.OPPONENT_SPIKES_REMOVED));
			}
			if (p.state.SideHasCondition(side, Condition.POISON_SPIKES, Condition.TOXIC_SPIKES)) {
				p.state.RemoveCondition(Condition.POISON_SPIKES);
				p.state.RemoveCondition(Condition.TOXIC_SPIKES);
				await MessageBox(Lang.GetString(STRINGS, side == Battle.SIDE_CLIENT ? BATTLE_COMMON.ALLY_POISON_SPIKES_REMOVED : BATTLE_COMMON.OPPONENT_POISON_SPIKES_REMOVED));
			}
			if (p.state.SideHasCondition(side, Condition.POINTED_STONES)) {
				p.state.RemoveCondition(Condition.POINTED_STONES);
				await MessageBox(Lang.GetString(STRINGS, side == Battle.SIDE_CLIENT ? BATTLE_COMMON.ALLY_POINTED_STONES_REMOVED : BATTLE_COMMON.OPPONENT_POINTED_STONES_REMOVED));
			}
			return 0;
		}

		private static async Task<u32> BindTarget(MoveEffectParams p, u16 bindType) {
			// A mon can only be bound by 1 move at a time.
			if (p.target.HasStatus(Status.BOUND)) {
				return FLAG_NO_BIND;
			}

			// Set the binding status and parameters.
			p.target.GiveStatus(Status.BOUND, BattleEvents.EventDuration(p.battle, p.attacker, Status.BOUND).Result);
			p.target.SetStatusParam(StatusParam.BIND_TYPE, BIND_BIND);
			p.target.SetStatusParam(StatusParam.MON_BOUND_BY, p.attacker.NUUID);
			p.target.SetStatusParam(StatusParam.BINDING_BAND, (u32)(p.attacker.HeldItem == Item.BINDING_BAND ? 1 : 0));
			
			// Add a listener to remove the status when the attacker leaves the field.
			p.attacker.OnSwitchOut += async () => {
				foreach (BattleMon bm in p.battle.GetAllActiveMons()) {
					if (bm.HasStatus(Status.BOUND) && bm.GetStatusParam(StatusParam.MON_BOUND_BY) == p.attacker.NUUID) {
						bm.RemoveStatus(Status.BOUND);
						await MessageBox(Lang.GetString(
							STRINGS, 
							BattleUtils.GetContextString(BATTLE_COMMON.MON_WAS_FREED_FROM_X, bm), 
							bm.GetName(), 
							Lang.GetString(StringResource.Namespace.MOVE, bm.GetStatusParam(StatusParam.BIND_TYPE) switch {
								BIND_BIND			=> MOVE_NAMES.BIND,
								BIND_CLAMP			=> MOVE_NAMES.CLAMP,
								BIND_SAND_TOMB		=> MOVE_NAMES.SAND_TOMB,
								BIND_FIRE_SPIN		=> MOVE_NAMES.FIRE_SPIN,
								BIND_INFESTATION	=> MOVE_NAMES.INFESTATION,
								BIND_MAGMA_STORM	=> MOVE_NAMES.MAGMA_STORM,
								BIND_SNAP_TRAP		=> MOVE_NAMES.SNAP_TRAP,
								BIND_THUNDER_CAGE	=> MOVE_NAMES.THUNDER_CAGE,
								BIND_WHIRLPOOL		=> MOVE_NAMES.WHIRLPOOL,
								BIND_WRAP			=> MOVE_NAMES.WRAP,
								_ => MOVE_NAMES.NONE
							})
						));
					}
				}
			};

			p.target.SetStatusParam(StatusParam.BIND_TYPE, bindType);
			return 0;
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously

		/// <summary>
		/// Similar to BattleUtil.GetContextString, but for when a string resource involves 2 different mons.
		/// </summary>
		/// <param name="baseKey">ex: "MON_ATTACKED"</param>
		/// <param name="attacker">BattleMon that is doing the thing.</param>
		/// <param name="target">BattleMon that is the target of said thing.</param>
		/// <param name="attackerPlayerName">Name of the acting BattleMon's trainer. Optional.</param>
		/// <param name="targetPlayerName">Name of the targeted BattleMon's trainer. Optional.</param>
		/// <returns>StringResource conjugated for 2 mons.</returns>
		private static StringResource GetConjugatedString(string baseKey, BattleMon attacker, BattleMon target, string attackerPlayerName = null, string targetPlayerName = null) {
			string key = baseKey;

			if (attackerPlayerName != null) {
				key = "PLAYER_" + key;
			}
			else if (attacker.Mon.Box.IsWild) {
				key = "WILD_" + key;
			}
			else if (attacker.Side == Battle.SIDE_REMOTE) {
				key = "OPPOSING_" + key;
			}

			if (targetPlayerName != null) {
				key = key + "_PLAYER_MON";
			}
			else if (target.Mon.Box.IsWild) {
				key = key + "_WILD_MON";
			}
			else if (target.Side == Battle.SIDE_REMOTE) {
				key = key + "_OPPOSING_MON";
			}
			else {
				key = key + "_MON";
			}

			return Lang.GetStringResourceWithKey(StringResource.Namespace.BATTLE_COMMON, key);
		}
	}
}