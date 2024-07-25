using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System;

using static PkmnEngine.Global;
using PkmnEngine.Strings;
using System.Threading.Tasks;
using System.Linq;

namespace PkmnEngine {
	public static partial class MoveEffects {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<u32> ChangeStat(BattleState state, BattleMon bm, sbyte n, Stat effID) {
			if (bm.HasStatus(Status.FAINTED)) {
				return 0;
			}

			if (!Battle.RunEventCheck(Callback.OnTryChangeStat, state, new OnTryChangeStatParams(state, bm, n)).Result) {
				return 0;
			}

			string atLimitMsg = "";
			string changeMsg = "";


			sbyte stages = effID switch {
				Stat.ATTACK => bm.AttackStages,
				Stat.DEFENSE => bm.DefenseStages,
				Stat.SPECIAL_ATTACK => bm.SpecialAttackStages,
				Stat.SPECIAL_DEFENSE => bm.SpecialDefenseStages,
				Stat.SPEED => bm.SpeedStages,
				Stat.ACCURACY => bm.AccuracyStages,
				Stat.EVASION => bm.EvasivenessStages,
				_ => throw new ArgumentException()
			};
			StringResource statString = effID switch {
				Stat.ATTACK => STAT_NAMES.ATTACK,
				Stat.DEFENSE => STAT_NAMES.DEFENSE,
				Stat.SPECIAL_ATTACK => STAT_NAMES.SPECIAL_ATTACK,
				Stat.SPECIAL_DEFENSE => STAT_NAMES.SPECIAL_DEFENSE,
				Stat.SPEED => STAT_NAMES.SPEED,
				Stat.ACCURACY => STAT_NAMES.ACCURACY,
				Stat.EVASION => STAT_NAMES.EVASION,
				_ => throw new ArgumentException()
			};

			switch (n) {
				case -6:
				case -5:
				case -4:
				case -3: changeMsg = Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MONS_STAT_DECREASED_DRASTICALLY,	bm), bm.GetName(), Lang.GetString(StringResource.Namespace.STAT, statString)); break;
				case -2: changeMsg = Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MONS_STAT_DECREASED_SHARPLY, 		bm), bm.GetName(), Lang.GetString(StringResource.Namespace.STAT, statString)); break;
				case -1: changeMsg = Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MONS_STAT_DECREASED,				bm), bm.GetName(), Lang.GetString(StringResource.Namespace.STAT, statString)); break;
				case 1:  changeMsg = Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MONS_STAT_INCREASED,				bm), bm.GetName(), Lang.GetString(StringResource.Namespace.STAT, statString)); break;
				case 2:  changeMsg = Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MONS_STAT_INCREASED_SHARPLY,		bm), bm.GetName(), Lang.GetString(StringResource.Namespace.STAT, statString)); break;
				case 3:
				case 4:
				case 5:
				case 6:  changeMsg = Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MONS_STAT_INCREASED_DRASTICALLY,	bm), bm.GetName(), Lang.GetString(StringResource.Namespace.STAT, statString)); break;
				default:
					changeMsg = Lang.GetString(STRINGS, BATTLE_COMMON.NOTHING_HAPPENED); // this should never happen
					break;
			}

			if (stages <= MIN_STAT_STAGE && n < 0) {
				atLimitMsg = Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MONS_STAT_WONT_GO_LOWER, bm), bm.GetName(), Lang.GetString(StringResource.Namespace.STAT, statString));
			}
			else if (stages >= MAX_STAT_STAGE && n > 0) {
				atLimitMsg = Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MONS_STAT_WONT_GO_HIGHER, bm), bm.GetName(), Lang.GetString(StringResource.Namespace.STAT, statString));
			}

			if (atLimitMsg != "") {
				await MessageBox(atLimitMsg);
				return FLAG_STAT_DID_NOT_CHANGE;
			}
			else {
				// Add n stages to the current stage and clamp the new value between the extremes.
				bm.SetStatStage(effID, (sbyte)(stages + n));
				
				// Mark that the mon had a stat increase this turn.
				if (n > 0) {
					bm.SetFlag(BattleMon.Flag.STAT_INCREASED_THIS_TURN);
				}

				await MessageBox(changeMsg);
				return 0;
			}
		}
	
		public static async Task<u32> BurnMon(BattleState state, BattleMon bm) {
			return await GiveMonNonVolatileStatus(state, bm, Status.BURN, true, u8.MaxValue);
		}
		public static async Task<u32> SleepMon(BattleState state, BattleMon bm, u8 duration) {
			bm.SetStatusParam(StatusParam.SLEEPING_TURNS, 0);
			return await GiveMonNonVolatileStatus(state, bm, Status.SLEEP, true, duration);
		}
		public static async Task<u32> PoisonMon(BattleState state, BattleMon bm) {
			return await GiveMonNonVolatileStatus(state, bm, Status.POISON, true, u8.MaxValue);
		}
		public static async Task<u32> ToxicMon(BattleState state, BattleMon bm) {
			return await GiveMonNonVolatileStatus(state, bm, Status.TOXIC, true, u8.MaxValue);
		}
		public static async Task<u32> CureBurn(BattleMon bm) {
			if (!bm.HasStatus(Status.BURN)) {
				return 0;
			}

			bm.RemoveStatus(Status.BURN);
			await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_CURED_OF_BURN, bm), bm.GetName()));

			return 0;
		}
		static async Task<u32> CureParalysis(BattleMon bm) {
			if (!bm.HasStatus(Status.PARALYSIS)) {
				return 0;
			}

			bm.RemoveStatus(Status.PARALYSIS);
			await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_CURED_OF_PARALYSIS, bm), bm.GetName()));

			return 0;
		}
		public static async Task<u32> CurePoison(BattleMon bm) {
			if (!bm.HasStatus(Status.POISON) && !bm.HasStatus(Status.TOXIC)) {
				return 0;
			}

			bm.RemoveStatus(Status.POISON);
			bm.RemoveStatus(Status.TOXIC);
			await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_CURED_OF_POISON, bm), bm.GetName()));

			return 0;
		}
		public static async Task<u32> ThawMon(BattleMon bm) {
			if (!bm.HasStatus(Status.FREEZE)) {
				return 0;
			}

			bm.RemoveStatus(Status.FREEZE);
			await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_THAWED_OUT, bm), bm.GetName()));

			return 0;
		}
		public static async Task<u32> WakeUpMon(BattleMon bm) {
			if (!bm.HasStatus(Status.SLEEP)) {
				return 0;
			}

			bm.RemoveStatus(Status.SLEEP);
			await MessageBox(Lang.GetString(STRINGS, BattleUtils.GetContextString(BATTLE_COMMON.MON_WOKE_UP, bm), bm.GetName()));

			return 0;
		}

		public static async Task<u32> CheckPursuit(Battle battle, BattleState state, u8 slot) {
			for (u8 i = state.ActionIndex; i < state.ActionCount; i++) {
				u64 action = state.Actions[i];

				ActionCode code = BattleActionCodes.GetBattleActionCode(action);
				// Quit early if the code isn't right.
				if (code != ActionCode.USE_MOVE) {
					return 0;
				}

				u32 moveData = BattleActionCodes.GetBattleActionArgs(action);
				BattleMoveID move = (BattleMoveID)(moveData & 0xFFFF);
				// Quit early if the move isn't Pursuit.
				if (move != BattleMoveID.PURSUIT) {
					return 0;
				}

				u8 userSlot			= BattleActionCodes.GetBattleActionSlot(action);
				u32 targetsCombined	= BattleActionCodes.GetBattleActionFlags(action);
				u8[] targets		= Battle.SplitTargets(targetsCombined);

				// Check for anyone using Pursuit on this mon.
				if (targets.Contains(slot)) {
					// Do its action now instead of whenever it's enqueued.
					state.MarkActionComplete(i);
					await BattleUtils.UseMove(battle, state, userSlot, move, (u8)((moveData & 0x00030000) >> 16), BattleActionCodes.GetBattleActionFlags(action), state.ActionIndex, I_FLAG_PURSUIT_DOUBLE);
					await Task.Delay(500);
					return (u32)(battle.GetMonInSlot(state, slot).HasStatus(Status.FAINTED) ? 1 : 0);
				}
			}
			return 0;
		}
	}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
}