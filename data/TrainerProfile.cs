using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using static PkmnEngine.Global;

namespace PkmnEngine {
	public class TrainerProfile {
		public TrainerProfile(string name, TrainerModel model, params Pokemon[] team) {
			if (team.Length == 0) {
				throw new System.ArgumentNullException($"Team must include at least 1 Pokemon.");
			}

			this.Name = name;
			this.model = model;

			this.Team = new Pokemon[PARTY_SIZE];
			for (u8 i = 0; i < team.Length; i++) {
				AddToParty(team[i]);
			}
		}

		public string Name { get; private set; }
		public Pokemon[] Team { get; private set; }

		public readonly TrainerModel model;

		/// <summary>
		/// Attempts to add a Pokemon to the party. 
		/// </summary>
		/// <param name="mon">Pokemon to add.</param>
		/// <returns>True if the Pokemon was added successfully and false if not.</returns>
		public bool AddToParty(Pokemon mon) {
			for (u8 i = 0; i < PARTY_SIZE; i++) {
				if (Team[i] == null) {
					Team[i] = mon;
					return true;
				}
			}
			return false;
		}
	}

	public enum TrainerModel {
		PLAYER,
		AI_LVL_1,
	}
}