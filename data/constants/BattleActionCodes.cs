using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;
using System;

namespace PkmnEngine {
	public static class BattleActionCodes {
		public static ActionCode GetBattleActionCode(u64 action) { return (ActionCode)((action & 0xF000000000000000) >> 60); }
		public static u8 GetBattleActionSlot(u64 action) { return (u8)((action & 0x0F00000000000000) >> 56); }
		public static u32 GetBattleActionArgs(u64 action) { return (u32)((action & 0x00FFFFFF00000000) >> 32); }
		public static u32 GetBattleActionFlags(u64 action) { return (u32)((action & 0x00000000FFFFFFFF) >> 0); }

		public const u64 ACTION_CHOOSE	= 0b_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000;
		public const u64 ACTION_SKIP	= 0b_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0001;

		/* 
			Any action/event that can occur in battle will be encoded in this format.
			4 bits for the action code, 4 for the slot of the user, 24 for args, and 32 for additional flags.
			********************************************************************************************************
			0000	|	0000	|	000000000000000000000000	| 00000000000000000000000000000000
			code	|	slot	|	args						| flags
			********************************************************************************************************
		*/
		/// <summary>
		/// Encodes an action that a mon on the field can perform.
		/// </summary>
		/// <param name="code">Code of the action.</param>
		/// <param name="userSlot">Slot of the mon performing the action.</param>
		/// <param name="args">(uses vary)</param>
		/// <param name="flags">(uses vary)</param>
		/// <returns></returns>
		public static u64 BATTLE_ACTION(ActionCode code, u8 userSlot, u32 args, u32 flags) {
			 return ((u64)code << 60) | ((u64)userSlot << 56) | ((u64)(args & 0xFFFFFF) << 32) | flags;
		}

		/// <summary>
		/// Use a move, including checks.
		/// </summary>
		/// <param name="slotUser">Slot of the mon that used the move.</param>
		/// <param name="slotMove">Slot of the move in the mon's Moves array.</param>
		/// <param name="move">ID of the move being used.</param>
		/// <param name="targets">The slot(s) for the target(s) with 4 bits for each slot.</param>
		/// <returns></returns>
		public static u64 BATTLE_ACTION_USE_MOVE(u8 slotUser, u8 slotMove, BattleMoveID move, u32 targets) {
			return BATTLE_ACTION(ActionCode.USE_MOVE, slotUser, (u32)((slotMove & 0b11) << 16) | (u16)move, targets);
		}
		/// <summary>
		/// Use a move, bypassing checks.
		/// </summary>
		/// <param name="slotUser">Slot of the mon that used the move.</param>
		/// <param name="slotMove">Slot of the move in the mon's Moves array.</param>
		/// <param name="move">ID of the move being used.</param>
		/// <param name="targets">The slot(s) for the target(s) with 4 bits for each slot.</param>
		/// <returns></returns>
		public static u64 BATTLE_ACTION_DO_MOVE(u8 slotUser, u8 slotMove, BattleMoveID move, u32 targets) {
			return BATTLE_ACTION(ActionCode.DO_MOVE, slotUser, (u32)((slotMove & 0b11) << 16) | (u16)move, targets);
		}
		/// <summary>
		/// Switch to a different mon.
		/// </summary>
		/// <param name="slotUser">Slot of the mon that is being switched out.</param>
		/// <param name="partyIndex">Index in the party of the mon to switch to.</param>
		/// <returns></returns>
		public static u64 BATTLE_ACTION_SWITCH(u8 slotUser, u8 partyIndex) {
			return BATTLE_ACTION(ActionCode.SWITCH, slotUser, partyIndex, 0);
		}
	}

	public enum ActionCode {
		NONE,
		USE_MOVE,
		DO_MOVE,
		SWITCH,
		RECHARGING,
	}
}