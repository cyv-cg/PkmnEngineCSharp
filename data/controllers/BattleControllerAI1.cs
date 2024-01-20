using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

using static PkmnEngine.Global;
using PkmnEngine.EnvInterface;
using System;

namespace PkmnEngine.BattleControllers {
	public class BattleControllerAI1 : IBattleController {
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

			await Task.Delay(0);

			return 1;
		}

		public Task<ulong> MenuSelectSwitchToMon(Battle battle, BattleState state, byte slot) {
			throw new NotImplementedException();
		}

		public Task<ulong> MenuSelectUseMove(Battle battle, BattleState state, byte slot) {
			throw new NotImplementedException();
		}
	}
}