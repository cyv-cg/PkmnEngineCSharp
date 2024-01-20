using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System;
using System.Threading.Tasks;

using static PkmnEngine.Global;
using static PkmnEngine.BattleActionCodes;

namespace PkmnEngine.BattleControllers {
	public class BattleControllerClient : IBattleController {
		private static MenuArg option = new MenuArg();

		public async Task<u64> HandleInputChooseAction(Battle battle, BattleState state, u8 slot) {
			u64 action = 0;

			do {
				option = await Inputs.gMenuFuncs[MenuCode.SHOW_ACTIONS]();
				Console.WriteLine(option);

				action = option.code switch
				{
					MenuCode.USE_MOVE		=> await MenuSelectUseMove(battle, state, slot),
					MenuCode.SWITCH_TO_MON	=> await MenuSelectSwitchToMon(battle, state, slot),
					_ => throw new ArgumentException(),
				};
			} while (option.code != MenuCode.BREAK);

			return action;
		}

		/// <summary>
		/// Lets the player choose a mon in their party to send out.
		/// </summary>
		/// <param name="battle"><Battle struct./param>
		/// <param name="state">The current BattleState.</param>
		/// <param name="slot">Slot of the mon acting.</param>
		/// <returns>Action code for switching mons.</returns>
		public async Task<u64> MenuSelectSwitchToMon(Battle battle, BattleState state, u8 slot) {			
			// Get the option selected in the mon selection menu.
			option = await Inputs.gMenuFuncs[MenuCode.SWITCH_TO_MON](battle.PlayerControllingSlot(slot).team);
			
			// Convert result into an action code.
			u64 action = BATTLE_ACTION_SWITCH(slot, (u8)option.args);
			return action;
		}

		/// <summary>
		/// Handles letting the player choose a move.
		/// </summary>
		/// <param name="battle">Battle struct.</param>
		/// <param name="state">Current BattleState.</param>
		/// <param name="slot">Slot of the acting mon.</param>
		/// <returns>Action code for the chosen move.</returns>
		public async Task<u64>  MenuSelectUseMove(Battle battle, BattleState state, u8 slot) {
			// TODO: move availability.
			BattleMon bm = battle.GetMonInSlot(state, slot);

			// Determine if the user has any usable moves left.
			bool isUserStruggling = true;
			for (u8 i = 0; i < Pokemon.MAX_MOVES; i++) {
				if (bm.CanUseMove(battle, state, i, false)) {
					isUserStruggling = false;
					break;
				}
			}
			// If the user has no available moves left, use Struggle.
			if (isUserStruggling) {
				option = new MenuArg(MenuCode.BREAK, 0);
				return BATTLE_ACTION_USE_MOVE(slot, 0, BattleMoveID.STRUGGLE, 1); // TODO: select target
			}

			// Get the user's decision.
			option = await Inputs.gMenuFuncs[MenuCode.USE_MOVE](bm.moves, bm.pp, bm.maxPP);
			// Convert to action.
			u64 action = BATTLE_ACTION_USE_MOVE(slot, (u8)option.args, bm.moves[option.args], 1); // TODO: select target(s)
			return action;
		}
	}
}