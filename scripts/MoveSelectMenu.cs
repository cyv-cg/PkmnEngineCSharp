using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System.Threading.Tasks;

using Godot;
using PkmnEngine.Strings;

namespace PkmnEngine.EnvInterface {
	public partial class MoveSelectMenu : Node2D {
		private static MoveSelectMenu menu;

		private static Godot.Button[] moveButtons;
		private Godot.Button btnBack;

		private static MenuArg option;

		// Called when the node enters the scene tree for the first time.
		public override void _Ready() {
			menu = this;
			moveButtons = new Godot.Button[Pokemon.MAX_MOVES];
			option = new MenuArg(MenuCode.CONTINUE, 0);

			for (u8 i = 0; i < Pokemon.MAX_MOVES; i++) {
				u32 key = i;
				moveButtons[i] = GetChild(0).GetChild<Godot.Button>(i);
				moveButtons[i].Pressed += () => { option = new MenuArg(MenuCode.BREAK, key); };
			}
			btnBack = GetChild<Godot.Button>(1);
			btnBack.Pressed += () => { option = new MenuArg(MenuCode.SHOW_ACTIONS, 0); };
		}

		public static async Task<MenuArg> Select(params object[] param) {
			BattleMoveID[] moves = (BattleMoveID[])param[0];
			u8[] pp = (u8[])param[1];
			u8[] maxPP = (u8[])param[2];
			for (u8 i = 0; i < Pokemon.MAX_MOVES; i++) {
				string label = "---";
				if (moves[i] != BattleMoveID.NONE) {
					label = $"{Lang.GetMoveName(moves[i])} {pp[i]}/{maxPP[i]}";
					moveButtons[i].Disabled = false;
				}
				else {
					moveButtons[i].Disabled = true;
				}
				moveButtons[i].Text = label;
			}

			// This is really important to reset here!
			option = new MenuArg(MenuCode.CONTINUE, 0);
			menu.Visible = true;

			while (option.code == MenuCode.CONTINUE) {
				await Task.Delay(Global.WAIT_DELAY);
			}

			menu.Visible = false;
			return option;
		}
	}
}
