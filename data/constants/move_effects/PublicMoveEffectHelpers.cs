using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using PkmnEngine.Strings;
using System.Threading.Tasks;

namespace PkmnEngine {
	public static partial class MoveEffects {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public static async Task<u32> ChangeStat(BattleState state, BattleMon bm, sbyte n, Stat effID) {
			if (!Battle.RunEventCheck(Callback.OnTryChangeStat, state, new OnTryChangeStatParams(state, bm, n)).Result) {
				return 0;
			}

			sbyte newStage = 0;
			string atLimitMsg = "";
			string changeMsg = "";
			
			switch (effID) {
				case Stat.ATTACK: {
					newStage = bm.AttackStages;
					if (newStage <= MIN_STAT_STAGE && n < 0) {
						atLimitMsg = Lang.GetBattleMessage(BattleMessage.ATTACK_AT_MIN, bm.GetName());
					}
					else if (newStage >= MAX_STAT_STAGE && n > 0) {
						atLimitMsg = Lang.GetBattleMessage(BattleMessage.ATTACK_AT_MAX, bm.GetName());
					}
					else {
						switch (n) {
							case -6:
							case -5:
							case -4:
							case -3: changeMsg = Lang.GetBattleMessage(BattleMessage.ATTACK_DECREASED_DRASTICALLY, bm.GetName()); break;
							case -2: changeMsg = Lang.GetBattleMessage(BattleMessage.ATTACK_DECREASED_SHARPLY, bm.GetName()); break;
							case -1: changeMsg = Lang.GetBattleMessage(BattleMessage.ATTACK_DECREASED, bm.GetName()); break;
							case 1:  changeMsg = Lang.GetBattleMessage(BattleMessage.ATTACK_INCREASED, bm.GetName()); break;
							case 2:  changeMsg = Lang.GetBattleMessage(BattleMessage.ATTACK_INCREASED_SHARPLY, bm.GetName()); break;
							case 3:
							case 4:
							case 5:
							case 6:  changeMsg = Lang.GetBattleMessage(BattleMessage.ATTACK_INCREASED_DRASTICALLY, bm.GetName()); break;
							default:
								changeMsg = Lang.GetBattleMessage(BattleMessage.NOTHING_HAPPENED); // this should never happen
								break;
						}
					}
					break;
				}
				case Stat.DEFENSE: {
					newStage = bm.DefenseStages;
					if (newStage <= MIN_STAT_STAGE && n < 0) {
						atLimitMsg = Lang.GetBattleMessage(BattleMessage.DEFENSE_AT_MIN, bm.GetName());
					}
					else if (newStage >= MAX_STAT_STAGE && n > 0) {
						atLimitMsg = Lang.GetBattleMessage(BattleMessage.DEFENSE_AT_MAX, bm.GetName());
					}
					else {
						switch (n) {
							case -6:
							case -5:
							case -4:
							case -3: changeMsg = Lang.GetBattleMessage(BattleMessage.DEFENSE_DECREASED_DRASTICALLY, bm.GetName()); break;
							case -2: changeMsg = Lang.GetBattleMessage(BattleMessage.DEFENSE_DECREASED_SHARPLY, bm.GetName()); break;
							case -1: changeMsg = Lang.GetBattleMessage(BattleMessage.DEFENSE_DECREASED, bm.GetName()); break;
							case 1:  changeMsg = Lang.GetBattleMessage(BattleMessage.DEFENSE_INCREASED, bm.GetName()); break;
							case 2:  changeMsg = Lang.GetBattleMessage(BattleMessage.DEFENSE_INCREASED_SHARPLY, bm.GetName()); break;
							case 3:
							case 4:
							case 5:
							case 6:  changeMsg = Lang.GetBattleMessage(BattleMessage.DEFENSE_INCREASED_DRASTICALLY, bm.GetName()); break;
							default:
								changeMsg = Lang.GetBattleMessage(BattleMessage.NOTHING_HAPPENED); // this should never happen
								break;
						}
					}
					break;
				}
				case Stat.SPECIAL_ATTACK: {
					newStage = bm.SpecialAttackStages;
					if (newStage <= MIN_STAT_STAGE && n < 0) {
						atLimitMsg = Lang.GetBattleMessage(BattleMessage.SPECIAL_ATTACK_AT_MIN, bm.GetName());
					}
					else if (newStage >= MAX_STAT_STAGE && n > 0) {
						atLimitMsg = Lang.GetBattleMessage(BattleMessage.SPECIAL_ATTACK_AT_MAX, bm.GetName());
					}
					else {
						switch (n) {
							case -6:
							case -5:
							case -4:
							case -3: changeMsg = Lang.GetBattleMessage(BattleMessage.SPECIAL_ATTACK_DECREASED_DRASTICALLY, bm.GetName()); break;
							case -2: changeMsg = Lang.GetBattleMessage(BattleMessage.SPECIAL_ATTACK_DECREASED_SHARPLY, bm.GetName()); break;
							case -1: changeMsg = Lang.GetBattleMessage(BattleMessage.SPECIAL_ATTACK_DECREASED, bm.GetName()); break;
							case 1:  changeMsg = Lang.GetBattleMessage(BattleMessage.SPECIAL_ATTACK_INCREASED, bm.GetName()); break;
							case 2:  changeMsg = Lang.GetBattleMessage(BattleMessage.SPECIAL_ATTACK_INCREASED_SHARPLY, bm.GetName()); break;
							case 3:
							case 4:
							case 5:
							case 6:  changeMsg = Lang.GetBattleMessage(BattleMessage.SPECIAL_ATTACK_INCREASED_DRASTICALLY); break;
							default:
								changeMsg = Lang.GetBattleMessage(BattleMessage.NOTHING_HAPPENED); // this should never happen
								break;
						}
					}
					break;
				}
				case Stat.SPECIAL_DEFENSE: {
					newStage = bm.SpecialDefenseStages;
					if (newStage <= MIN_STAT_STAGE && n < 0) {
						atLimitMsg = Lang.GetBattleMessage(BattleMessage.SPECIAL_DEFENSE_AT_MIN, bm.GetName());
					}
					else if (newStage >= MAX_STAT_STAGE && n > 0) {
						atLimitMsg = Lang.GetBattleMessage(BattleMessage.SPECIAL_DEFENSE_AT_MAX, bm.GetName());
					}
					else {
						switch (n) {
							case -6:
							case -5:
							case -4:
							case -3: changeMsg = Lang.GetBattleMessage(BattleMessage.SPECIAL_DEFENSE_DECREASED_DRASTICALLY, bm.GetName()); break;
							case -2: changeMsg = Lang.GetBattleMessage(BattleMessage.SPECIAL_DEFENSE_DECREASED_SHARPLY, bm.GetName()); break;
							case -1: changeMsg = Lang.GetBattleMessage(BattleMessage.SPECIAL_DEFENSE_DECREASED, bm.GetName()); break;
							case 1:  changeMsg = Lang.GetBattleMessage(BattleMessage.SPECIAL_DEFENSE_INCREASED, bm.GetName()); break;
							case 2:  changeMsg = Lang.GetBattleMessage(BattleMessage.SPECIAL_DEFENSE_INCREASED_SHARPLY, bm.GetName()); break;
							case 3:
							case 4:
							case 5:
							case 6:  changeMsg = Lang.GetBattleMessage(BattleMessage.SPECIAL_DEFENSE_INCREASED_DRASTICALLY, bm.GetName()); break;
							default:
								changeMsg = Lang.GetBattleMessage(BattleMessage.NOTHING_HAPPENED); // this should never happen
								break;
						}
					}
					break;
				}
				case Stat.SPEED: {
					newStage = bm.SpeedStages;
					if (newStage <= MIN_STAT_STAGE && n < 0) {
						atLimitMsg = Lang.GetBattleMessage(BattleMessage.SPEED_AT_MIN, bm.GetName());
					}
					else if (newStage >= MAX_STAT_STAGE && n > 0) {
						atLimitMsg = Lang.GetBattleMessage(BattleMessage.SPEED_AT_MAX, bm.GetName());
					}
					else {
						switch (n) {
							case -6:
							case -5:
							case -4:
							case -3: changeMsg = Lang.GetBattleMessage(BattleMessage.SPEED_DECREASED_DRASTICALLY, bm.GetName()); break;
							case -2: changeMsg = Lang.GetBattleMessage(BattleMessage.SPEED_DECREASED_SHARPLY, bm.GetName()); break;
							case -1: changeMsg = Lang.GetBattleMessage(BattleMessage.SPEED_DECREASED, bm.GetName()); break;
							case 1:  changeMsg = Lang.GetBattleMessage(BattleMessage.SPEED_INCREASED, bm.GetName()); break;
							case 2:  changeMsg = Lang.GetBattleMessage(BattleMessage.SPEED_INCREASED_SHARPLY, bm.GetName()); break;
							case 3:
							case 4:
							case 5:
							case 6:  changeMsg = Lang.GetBattleMessage(BattleMessage.SPEED_INCREASED_DRASTICALLY, bm.GetName()); break;
							default:
								changeMsg = Lang.GetBattleMessage(BattleMessage.NOTHING_HAPPENED); // this should never happen
								break;
						}
					}
					break;
				}
				case Stat.ACCURACY: {
					newStage = bm.AccuracyStages;
					if (newStage <= MIN_STAT_STAGE && n < 0) {
						atLimitMsg = Lang.GetBattleMessage(BattleMessage.ACCURACY_AT_MIN, bm.GetName());
					}
					else if (newStage >= MAX_STAT_STAGE && n > 0) {
						atLimitMsg = Lang.GetBattleMessage(BattleMessage.ACCURACY_AT_MAX, bm.GetName());
					}
					else {
						switch (n) {
							case -6:
							case -5:
							case -4:
							case -3: changeMsg = Lang.GetBattleMessage(BattleMessage.ACCURACY_DECREASED_DRASTICALLY, bm.GetName()); break;
							case -2: changeMsg = Lang.GetBattleMessage(BattleMessage.ACCURACY_DECREASED_SHARPLY, bm.GetName()); break;
							case -1: changeMsg = Lang.GetBattleMessage(BattleMessage.ACCURACY_DECREASED, bm.GetName()); break;
							case 1:  changeMsg = Lang.GetBattleMessage(BattleMessage.ACCURACY_INCREASED, bm.GetName()); break;
							case 2:  changeMsg = Lang.GetBattleMessage(BattleMessage.ACCURACY_INCREASED_SHARPLY, bm.GetName()); break;
							case 3:
							case 4:
							case 5:
							case 6:  changeMsg = Lang.GetBattleMessage(BattleMessage.ACCURACY_INCREASED_DRASTICALLY, bm.GetName()); break;
							default:
								changeMsg = Lang.GetBattleMessage(BattleMessage.NOTHING_HAPPENED); // this should never happen
								break;
						}
					}
					break;
				}
				case Stat.EVASION: {
					newStage = bm.EvasivenessStages;
					if (newStage <= MIN_STAT_STAGE && n < 0) {
						atLimitMsg = Lang.GetBattleMessage(BattleMessage.EVASION_AT_MIN, bm.GetName());
					}
					else if (newStage >= MAX_STAT_STAGE && n > 0) {
						atLimitMsg = Lang.GetBattleMessage(BattleMessage.EVASION_AT_MAX, bm.GetName());
					}
					else {
						switch (n) {
							case -6:
							case -5:
							case -4:
							case -3: changeMsg = Lang.GetBattleMessage(BattleMessage.EVASION_DECREASED_DRASTICALLY, bm.GetName()); break;
							case -2: changeMsg = Lang.GetBattleMessage(BattleMessage.EVASION_DECREASED_SHARPLY, bm.GetName()); break;
							case -1: changeMsg = Lang.GetBattleMessage(BattleMessage.EVASION_DECREASED, bm.GetName()); break;
							case 1:  changeMsg = Lang.GetBattleMessage(BattleMessage.EVASION_INCREASED, bm.GetName()); break;
							case 2:  changeMsg = Lang.GetBattleMessage(BattleMessage.EVASION_INCREASED_SHARPLY, bm.GetName()); break;
							case 3:
							case 4:
							case 5:
							case 6:  changeMsg = Lang.GetBattleMessage(BattleMessage.EVASION_INCREASED_DRASTICALLY, bm.GetName()); break;
							default:
								changeMsg = Lang.GetBattleMessage(BattleMessage.NOTHING_HAPPENED); // this should never happen
								break;
						}
					}
					break;
				}
			}

			if (atLimitMsg != "") {
				await MessageBox(atLimitMsg);
				return FLAG_STAT_DID_NOT_CHANGE;
			}
			else {
				// Add n stages to the current stage and clamp the new value between the extremes.
				bm.SetStatStage(effID, (sbyte)(newStage + n));
				
				// Mark that the mon had a stat increase this turn.
				if (n > 0) {
					bm.SetFlag(BattleMon.Flag.STAT_INCREASED_THIS_TURN);
				}

				await MessageBox(changeMsg);
				return 0;
			}
		}
	
		public static async Task<u32> BurnMon(BattleState state, BattleMon bm, u8 duration) {
			return await GiveMonNonVolatileStatus(state, bm, Status.BURN, true, duration);
		}
		public static async Task<u32> SleepMon(BattleState state, BattleMon bm, u8 duration) {
			bm.SetStatusParam(StatusParam.SLEEPING_TURNS, 0);
			return await GiveMonNonVolatileStatus(state, bm, Status.SLEEP, true, duration);
		}
		public static async Task<u32> PoisonMon(BattleState state, BattleMon bm, u8 duration) {
			return await GiveMonNonVolatileStatus(state, bm, Status.POISON, true, duration);
		}
		public static async Task<u32> ToxicMon(BattleState state, BattleMon bm, u8 duration) {
			return await GiveMonNonVolatileStatus(state, bm, Status.TOXIC, true, duration);
		}
		public static async Task<u32> CureBurn(BattleMon bm) {
			if (!bm.HasStatus(Status.BURN)) {
				return 0;
			}

			bm.RemoveStatus(Status.BURN);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CURED_OF_BURN, bm.GetName()));

			return 0;
		}
		static async Task<u32> CureParalysis(BattleMon bm) {
			if (!bm.HasStatus(Status.PARALYSIS)) {
				return 0;
			}

			bm.RemoveStatus(Status.PARALYSIS);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CURED_OF_PARALYSIS, bm.GetName()));

			return 0;
		}
		public static async Task<u32> CurePoison(BattleMon bm) {
			if (!bm.HasStatus(Status.POISON) && !bm.HasStatus(Status.TOXIC)) {
				return 0;
			}

			bm.RemoveStatus(Status.POISON);
			bm.RemoveStatus(Status.TOXIC);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_CURED_OF_POISON, bm.GetName()));

			return 0;
		}
		public static async Task<u32> ThawMon(BattleMon bm) {
			if (!bm.HasStatus(Status.FREEZE)) {
				return 0;
			}

			bm.RemoveStatus(Status.FREEZE);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_THAWED_OUT, bm.GetName()));

			return 0;
		}
		public static async Task<u32> WakeUpMon(BattleMon bm) {
			if (!bm.HasStatus(Status.SLEEP)) {
				return 0;
			}

			bm.RemoveStatus(Status.SLEEP);
			await MessageBox(Lang.GetBattleMessage(BattleMessage.MON_WOKE_UP, bm.GetName()));

			return 0;
		}
	}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
}