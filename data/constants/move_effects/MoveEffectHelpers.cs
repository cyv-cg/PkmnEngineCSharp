using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.StatusEffects;
using static PkmnEngine.Global;

using PkmnEngine.Strings;

namespace PkmnEngine {
	public static partial class MoveEffects {
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
	}
}