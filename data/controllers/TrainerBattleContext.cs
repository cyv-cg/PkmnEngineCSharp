using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

using static PkmnEngine.Global;
using PkmnEngine.BattleControllers;
using System;

namespace PkmnEngine {
	public class TrainerBattleContext {
		public TrainerBattleContext(TrainerProfile profile, u8 side, params u8[] slots) {
			this.profile = profile;
			this.slots = slots;
			this.team = new BattleMon[PARTY_SIZE];

			// Convert Pokemon objects into BattleMon objects.
			for (u8 i = 0; i < PARTY_SIZE; i++) {
				if (profile.Team[i] == null) {
					break;
				}
				this.team[i] = new BattleMon(profile.Team[i], side);
			}

			// TODO: Assign the controller.
			controller = profile.model switch {
				TrainerModel.PLAYER => new BattleControllerClient(),
				_ => new BattleControllerAI1()
			};
		}

		public readonly TrainerProfile profile;
		public readonly IBattleController controller;

		public readonly BattleMon[] team;
		public readonly u8[] slots;

		public bool ControllsSlot(u8 slot) {
			bool val = false;
			for (u8 i = 0; i < slots.Length; i++) {
				if (slots[i] == slot) {
					val = true;
					break;
				}
			}
			return val;
		}

		/// <summary>
		/// Gets the index in the team of the first non-null mon that can be sent into battle.
		/// </summary>
		/// <returns>The index in the team of the first available mon, or -1 if none are found.</returns>
		public sbyte GetFirstAvailableMonIndex() {
			for (u8 i = 0; i < PARTY_SIZE; i++) {
				if (team[i] != null && team[i].IsAvailable()) {
					return (sbyte)i;
				}
			}
			return -1;
		}

		public u8 NumAvailableMons() {
			u8 count = 0;
			for (u8 i = 0; i < PARTY_SIZE; i++) {
				if (team[i] != null && team[i].IsAvailable()) {
					count++;
				}
			}
			return count;
		}
	}
}