using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System;

namespace PkmnEngine {
	public class BattleFormat {
		public static BattleFormat Format_Single 
			= new BattleFormat(
				"single",
				2, // 2 players.
				2, // 2 slots.
				new u8[][] {
					new u8[] { 0 }, // Player 0 controls slot 0.
					new u8[] { 1 }  // Player 1 controls slot 1.
				},
				new u8[][] {
					new u8[] { 0 }, // Slot 0 in on SIDE_CLIENT.
					new u8[] { 1 }  // Slot 1 is on SIDE_OPP.
				}
			);
		public static BattleFormat Format_Double
			= new BattleFormat(
				"double",
				2, // 2 players.
				4, // 4 slots.
				new u8[][] {
					new u8[] { 0, 2 }, // Player 0 controls slots 0 and 2.
					new u8[] { 1, 3 }, // Player 1 controls slots 1 and 3.
				},
				new u8[][] {
					new u8[] { 0, 2 }, // Slots 0 and 2 are on SIDE_CLIENT.
					new u8[] { 1, 3 }  // Slots 1 and 3 are on SIDE_OPP.
				}
			);
		public static BattleFormat Format_Multi_Double
			= new BattleFormat(
				"multi double",
				4,
				4,
				new u8[][] {
					new u8[] { 0 },
					new u8[] { 1 },
					new u8[] { 2 },
					new u8[] { 3 }
				},
				new u8[][] {
					new u8[] { 0, 2 }, // Slots 0 and 2 are on SIDE_CLIENT.
					new u8[] { 1, 3 }  // Slots 1 and 3 are on SIDE_OPP.
				}
			);
		public static BattleFormat Format_Triple
			= new BattleFormat(
				"triple",
				2,
				6,
				new u8[][] {
					new u8[] { 0, 2, 4 },
					new u8[] { 1, 3, 5 }
				},
				new u8[][] {
					new u8[] { 0, 2, 4 },
					new u8[] { 1, 3, 5 }
				}
			);
		public static BattleFormat Format_Multi_Triple
			= new BattleFormat(
				"multi triple",
				6,
				6,
				new u8[][] {
					new u8[] { 0 },
					new u8[] { 1 },
					new u8[] { 2 },
					new u8[] { 3 },
					new u8[] { 4 },
					new u8[] { 5 }
				},
				new u8[][] {
					new u8[] { 0, 2, 4 },
					new u8[] { 1, 3, 5 }
				}
			);
		public static BattleFormat Format_1v4
			= new BattleFormat(
				"1v4",
				2,
				5,
				new u8[][] {
					new u8[] { 0, 1, 2, 3 },
					new u8[] { 4 }
				},
				new u8[][] {
					new u8[] { 0, 1, 2, 3 },
					new u8[] { 4 }
				}
			);

		public BattleFormat(string name, u8 numPlayers, u8 numSlots, u8[][] slotsControlledByPlayerIndex, u8[][] slotsOnSide) {
			this.name = name;
			this.numPlayers = numPlayers;
			this.numSlots = numSlots;
			this.slotsControlledByPlayerIndex = slotsControlledByPlayerIndex;
			this.slotsOnSide = slotsOnSide;

			if (slotsControlledByPlayerIndex.Length != numPlayers) {
				throw new ArgumentException($"Format has {numPlayers} players, slotsControlledByPlayerIndex must contain slots for all players.");
			}
			if (slotsOnSide.Length != numSides) {
				throw new ArgumentException($"slotsOnSide must store slots for {numSides} sides.");
			}

			for (u8 i = 0; i < numPlayers; i++) {
				if (slotsControlledByPlayerIndex[i] == null || slotsControlledByPlayerIndex[i].Length == 0) {
					throw new Exception($"Each player must control at least 1 slot");
				}
			}
			for (u8 i = 0; i < numSides; i++) {
				if (slotsOnSide[i] == null || slotsOnSide[i].Length == 0) {
					throw new Exception($"Each side must have at least 1 slot.");
				}
			}

			// This should probably also check that all slots are assigned to a player and a side.
		}

		/// <summary>
		/// Looks up the slot(s) controlled by a player based on the battle format.
		/// </summary>
		/// <param name="index">Index of the player, 0-5.</param>
		/// <returns>An array of the slots that player controls.</returns>
		public u8[] SlotsControlledByPlayerIndex(u8 index) {
			return slotsControlledByPlayerIndex[index];
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="side"></param>
		/// <returns></returns>
		public u8[] SlotsOnSide(u8 side) {
			return slotsOnSide[side];
		}


		// Leaving as const, but storing separately in the unlikely event
		// that I decide to have more than 2 sides in the battle.
		public readonly u8 numSides = 2;

		public const u8 SIDE_CLIENT = 0;
		public const u8 SIDE_OPP = 1;

		public readonly u8 numPlayers;
		public readonly u8 numSlots;
		private readonly u8[][] slotsControlledByPlayerIndex;
		private readonly u8[][] slotsOnSide;

		private readonly string name;

		public override string ToString() {
			return name.ToLower();
		}
	}
}