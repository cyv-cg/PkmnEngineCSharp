using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;

using Godot;

namespace PkmnEngine.EnvInterface {
	public static class MenuFuncs {
		public static void InputFunc() {
			//raw = tolower(std::cin.get());
			//switch (raw) {
			//	case 'w': 		gInBuffer = BUTTON_DPAD_UP; break;
			//	case 'a':		gInBuffer = BUTTON_DPAD_LEFT; break;
			//	case 's':		gInBuffer = BUTTON_DPAD_DOWN; break;
			//	case 'd':		gInBuffer = BUTTON_DPAD_RIGHT; break;

			//	case '\n':		gInBuffer = BUTTON_A; break;
			//	case '\033':	gInBuffer = BUTTON_B; break;
			//	case 'x':		gInBuffer = BUTTON_X; break;
			//	case 'y':		gInBuffer = BUTTON_Y; break;

			//	default:		gInBuffer = (Button)raw; break;
			//}
			//std::system("clear");
		}

		//public static Inputs.MenuFunc DrawMonSelectMenu(BattleMon[] team)
		//{
		//	for (u8 i = 0; i < PARTY_SIZE; i++) {
		//		if (gHoverTarget == i) {
		//			std::cout << "*";
		//		}
		//		struct Pokemon *mon = gSaveBlock->party[i];
		//		if (mon->box->species == SPECIES_NONE) {
		//			std::cout << "-------";
		//		}
		//		else {
		//			std::cout << GetMonName(mon);
		//		}
		//		if (gHoverTarget == i) {
		//			std::cout << "*";
		//		}
		//		std::cout << std::endl;
		//	}
		//	gInputFunc();

		//	if (gInBuffer == BUTTON_DPAD_UP) {
		//		do {
		//			gHoverTarget = (u8)(gHoverTarget - 1) % PARTY_SIZE;
		//		} while (gSaveBlock->party[gHoverTarget]->box->species == SPECIES_NONE);
		//	}
		//	else if (gInBuffer == BUTTON_DPAD_DOWN) {
		//		do {
		//			gHoverTarget = (u8)(gHoverTarget + 1) % PARTY_SIZE;
		//		} while (gSaveBlock->party[gHoverTarget]->box->species == SPECIES_NONE);
		//	}
		//	else if (gInBuffer == BUTTON_A) {
		//		return MENU_FLAG(MFC_SWITCH_TO_MON, gHoverTarget);
		//	}
		//	else if (gInBuffer == BUTTON_B) {
		//		return MENU_FLAG(MFC_SHOW_ACTIONS, 0);
		//	}

		//	return MENU_FLAG_CONTINUE;
		//}
	}
}