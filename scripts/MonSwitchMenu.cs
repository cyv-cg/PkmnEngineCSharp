using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using Godot;
using System;
using System.Threading.Tasks;
using PkmnEngine.Strings;

namespace PkmnEngine.EnvInterface {
	public partial class MonSwitchMenu : Node2D {
		private static MonSwitchMenu menu;

		private static Godot.Button[] monButtons;
		private static Godot.Button btnBack;

		private static MenuArg option;

		// Called when the node enters the scene tree for the first time.
		public override void _Ready() {
			menu = this;
			monButtons = new Godot.Button[Global.PARTY_SIZE];
			option = new MenuArg(MenuCode.CONTINUE, 0);

			for (u8 i = 0; i < Global.PARTY_SIZE; i++) {
				u32 key = i;
				monButtons[i] = GetChild(0).GetChild<Godot.Button>(i);
				monButtons[i].Pressed += () => { option = new MenuArg(MenuCode.BREAK, key); };
			}
			btnBack = GetNode<Godot.Button>("btnBack");
			btnBack.Pressed += () => { option = new MenuArg(MenuCode.SHOW_ACTIONS, 0); };
		}

		public static async Task<MenuArg> Select(params object[] param) {
			// Set the text on the buttons to the mon names.
			// This will definitely need to be changed later when the UI is better.
			for (u8 i = 0; i < Global.PARTY_SIZE; i++) {
				string label = "---";
				if (param[i] != null) {
					BattleMon bm = (BattleMon)param[i];
					label = bm.GetName();
					monButtons[i].Disabled = false;
					if (!bm.IsAvailable()) {
						monButtons[i].Disabled = true;
					}
				}
				else {
					monButtons[i].Disabled = true;
				}
				monButtons[i].Text = label;
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