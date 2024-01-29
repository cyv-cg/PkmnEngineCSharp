using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;
using static PkmnEngine.BattleActionCodes;

using System.Threading.Tasks;
using PkmnEngine.EnvInterface;
using System;

namespace PkmnEngine.BattleControllers {
	public class BattleControllerAI1 : IBattleController {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
		public async Task<u64> HandleInputChooseAction(Battle battle, BattleState state, byte slot) {
			//u32 flag;
			//MenuArg data = await Inputs.gMenuFuncs[0](); // TODO: that '0' should be clicking the button of the action to do.
			//do {
			//	gHoverTarget = 0;
			//	do {
			//		flag = gMenuFuncs[MFC_SHOW_ACTIONS]();
			//	} while (flag == MENU_FLAG_CONTINUE);
			//	u8 code = GetMenuFlagCode(flag);
			//	u32 args = GetMenuFlagArgs(flag);

			//	gHoverTarget = 0;
			//	switch (code) {
			//		case MFC_SWITCH_TO_MON:
			//			MenuSelectSwitchToMon(state, &data, &flag, slot);
			//			break;
			//		case MFC_USE_MOVE: 
			//			MenuSelectUseMove(battle, state, &data, &flag, slot);
			//			break;
			//	}
			//} while (flag != MENU_FLAG_BREAK);

			//await Task.Delay(0);

			return await MenuSelectUseMove(battle, state, slot);
		}

		public async Task<u64> MenuSelectSwitchToMon(Battle battle, BattleState state, u8 slot) {
			throw new NotImplementedException();
		}

		// Use the first available move.
		public async Task<u64> MenuSelectUseMove(Battle battle, BattleState state, u8 slot) {
			BattleMon bm = battle.GetMonInSlot(state, slot);
			for (u8 i = 0; i < Pokemon.MAX_MOVES; i++) {
				if (bm.CanUseMove(battle, state, i, false)) {
					return BATTLE_ACTION_USE_MOVE(slot, i, bm.moves[i], BattleUtils.GetDefaultMoveTarget(bm.moves[i], bm));
				}
			}
			return BATTLE_ACTION_USE_MOVE(slot, 0, BattleMoveID.STRUGGLE, BattleUtils.GetDefaultMoveTarget(BattleMoveID.STRUGGLE, bm));
		}
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
	}
}