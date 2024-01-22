using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System;

using static PkmnEngine.Global;
using PkmnEngine.EnvInterface;

using System.Threading.Tasks;

namespace PkmnEngine {
	public static class Main {
		private static void Setup() {
			Inputs.gInputFunc = Test;

			Inputs.gMenuFuncs[MenuCode.SHOW_ACTIONS]	= BattleActionSelectionMenu.Select;
			Inputs.gMenuFuncs[MenuCode.SWITCH_TO_MON]	= MonSwitchMenu.Select;
			Inputs.gMenuFuncs[MenuCode.USE_MOVE]		= MoveSelectMenu.Select;

			Global.MessageBox = GodotV.MessageBox.Push;
			// TODO: this kinda temporary.
			Global.AbilityPopup = (BattleMon bm, Ability a) => { MessageBox($"{bm.GetName()} | {Strings.Lang.GetAbilityName(a)}"); };
		}

		public static void Start() {
			Setup();
			//Console.WriteLine("Hi mom!");
			MessageBox("Hi mom!");

			gSaveBlock = new SaveBlock {
				trainerID = Random32(),
				language = Language.ENG,
				JPN_USE_FURIGANA = true,
			};

			StartBattle();
		}

		private static async void StartBattle() {
			await Task.Delay(50);

			Pokemon snom = new Pokemon(Species.SNOM, 100, false, new u8[] {}, false, 0, OtIdType.PLAYER, 0);
			Pokemon shaymin = new Pokemon(Species.SHAYMIN_LAND_FORME, 100, false, new u8[] {}, false, 0, OtIdType.PLAYER, 0);
			Pokemon munna = new Pokemon(Species.MUNNA, 69, false, new u8[] {}, false, 0, OtIdType.RANDOM_NO_SHINY, 0);
			munna.SetNickname("丸子");

			gSaveBlock.profile = new TrainerProfile("Chris", TrainerModel.PLAYER, snom, shaymin);
			TrainerProfile ayla = new TrainerProfile("Ayla", TrainerModel.AI_LVL_1, munna);

			snom.GiveMove(BattleMoveID.TACKLE);
			snom.GiveMove(BattleMoveID.WILL_O_WISP);

			Battle battle = new Battle(BattleFormat.Format_Single, gSaveBlock.profile, ayla);
		}
	
		private static void Test() {
			throw new System.NotImplementedException();
		}
	}
}