using Godot;
using System.Threading.Tasks;

namespace PkmnEngine.EnvInterface {
	public partial class BattleActionSelectionMenu : Node2D {
		private static BattleActionSelectionMenu menu;

		private const string BTN_ATTACK		= "btnAttack";
		private const string BTN_BAG		= "btnBag";
		private const string BTN_RUN		= "btnRun";
		private const string BTN_POKEMON	= "btnPokemon";

		private Godot.Button btnAttack, btnBag, btnRun, btnPokemon;

		private static MenuCode option;

		// Called when the node enters the scene tree for the first time.
		public override void _Ready() {
			menu		= this;
			
			btnAttack	= GetNode<Godot.Button>(BTN_ATTACK);
			btnBag		= GetNode<Godot.Button>(BTN_BAG);
			btnRun		= GetNode<Godot.Button>(BTN_RUN);
			btnPokemon	= GetNode<Godot.Button>(BTN_POKEMON);

			btnAttack.Pressed	+= OnAttack;
			btnBag.Pressed		+= OnBag;
			btnRun.Pressed		+= OnRun;
			btnPokemon.Pressed	+= OnPokemon;
		}

		public static async Task<MenuArg> Select(params object[] param) {
			option = MenuCode.CONTINUE;
			menu.Visible = true;

			while (option == MenuCode.CONTINUE) {
				await Task.Delay(Global.WAIT_DELAY);
			}

			menu.Visible = false;
			return new MenuArg(option, 0);
		}

		private static void OnAttack() {
			option = MenuCode.USE_MOVE;
		}
		private static void OnBag() {
			option = MenuCode.BAG;
		}
		private static void OnRun() {
			option = MenuCode.RUN;
		}
		private static void OnPokemon() {
			option = MenuCode.SWITCH_TO_MON;
		}
	}
}