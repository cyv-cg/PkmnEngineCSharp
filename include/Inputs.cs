using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;

using System.Collections.Generic;
using System.Collections;
using System;
using System.Threading.Tasks;

namespace PkmnEngine {
	public static class Inputs {
		//// Supply a 8-bit code and 24-bit args.
		////#define MENU_FLAG(code, args) (((u8)code << 24) | args & 0x00FFFF)
		//public static u32 MENU_FLAG(u8 code, u32 args) { return (u32)(code << 24) | (args & 0x00FFFFFF); }

		//public const u32 MENU_FLAG_BREAK = (u32)((u8)MenuCode.BREAK << 24) | (0 & 0x00FFFFFF);
		////#define MENU_FLAG_BREAK MENU_FLAG(MFC_BREAK, 0)
		//public const u32 MENU_FLAG_CONTINUE = (u32)((u8)MenuCode.CONTINUE << 24) | (0 & 0x00FFFFFF);
		////#define MENU_FLAG_CONTINUE MENU_FLAG(MFC_CONTINUE, 0)

		////#define GetMenuFlagCode(flag) ((flag & 0xFF000000) >> 24)
		//public static u8 GetMenuFlagCode(u32 flag) { return (u8)(flag & 0xFF000000 >> 24); }
		////#define GetMenuFlagArgs(flag)  (flag & 0x00FFFFFF)
		//public static u32 GetMenuFlagArgs(u32 flag) { return flag & 0x00FFFFFF; }

		//#define MFC_CONTINUE 0
		//#define MFC_BREAK 0xFFFF

		//#define MFC_SHOW_ACTIONS 100
		//#define MFC_SWITCH_TO_MON 101
		//#define MFC_USE_MOVE 102
		
		//#define MFC_DRAW_FIELD 199

		// Use this to store the function that draws the appropriate menu.
		// The function must return a 32-bit integer for data flags.
		// Return MENU_FLAG_BREAK at the end of the function core loop.
		//std::map<u8, u32(*)()> gMenuFuncs;
		//u16 *gMenuInputParamBuffer0;
		//u16 *gMenuInputParamBuffer1;
		//u16 *gMenuInputParamBuffer2;
		//u16 *gMenuInputParamBuffer3;

		public delegate Task<MenuArg> MenuFunc(params object[] param);
		public static Dictionary<MenuCode, MenuFunc> gMenuFuncs = new Dictionary<MenuCode, MenuFunc>();

		// Stores the address of 'n' into params 0-3 where 'n' is a pointer.
		//#define Param64(n)													\
		//	u64 *addr = reinterpret_cast<u64 *>(n);							\
		//	gMenuInputParamBuffer0 = (u16 *)(((u64)addr >> 00) & 0xFFFF);	\
		//	gMenuInputParamBuffer1 = (u16 *)(((u64)addr >> 16) & 0xFFFF);	\
		//	gMenuInputParamBuffer2 = (u16 *)(((u64)addr >> 32) & 0xFFFF);	\
		//	gMenuInputParamBuffer3 = (u16 *)(((u64)addr >> 48) & 0xFFFF);
		//// Breaks params 0-3 into a new u64 'n'.
		//// Can then be read by:
		//// --	BreakParam64(n);
		//// --	[type] obj = ([type])n;
		//#define BreakParam64(n) 						\
		//	u64 *n = (u64 *)(							\
		//		((u64)gMenuInputParamBuffer0 << 00)		\
		//		| ((u64)gMenuInputParamBuffer1 << 16)	\
		//		| ((u64)gMenuInputParamBuffer2 << 32)	\
		//		| ((u64)gMenuInputParamBuffer3 << 48)	\
		//	);

		//struct MenuArg gMenuFlagData(u32 menuFlagCode)
		//{
		//	u32 flag = gMenuFuncs[menuFlagCode]();
		//	return {(u8)GetMenuFlagCode(flag), (u32)GetMenuFlagArgs(flag)};
		//}

		//u8 gHoverTarget = 0;

		//void (*gInputFunc)();
		public static Button gInBuffer;

		public static Action gInputFunc;
	}

	public readonly struct MenuArg {
		public MenuArg(MenuCode code, u32 args) {
            this.code = code;
            this.args = args;
        }
		public readonly MenuCode code;
		public readonly u32 args;

		public override string ToString() {
			return $"{code} | {args}";
		}
	};

	public enum MenuCode {
		CONTINUE,
		BREAK,
		SHOW_ACTIONS,
		SWITCH_TO_MON,
		USE_MOVE,
		BAG,
		RUN,
	}

	// Button IDs here will be mapped in accordance to a Nintendo Switch Pro Controller.
	// In input read functions, raw inputs will be converted to these standard outputs.
	public enum Button {
		NONE,

		A,
		B,
		X,
		Y,

		DPAD_UP,
		DPAD_DOWN,
		DPAD_LEFT,
		DPAD_RIGHT,

		TRIGGER_L,
		BUMPER_L,
		TRIGGER_R,
		BUMPER_R,

		START,
		SELECT
	};

	// Axes (joysticks) will need to be handled separately.
}