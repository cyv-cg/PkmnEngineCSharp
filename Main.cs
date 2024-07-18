using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using System;

using static PkmnEngine.Global;
using PkmnEngine.EnvInterface;

using System.Threading.Tasks;
using PkmnEngine.Strings;

namespace PkmnEngine {
	public static class Main {
		private static async void AbilityPopup(BattleMon bm, Ability a) {
			await MessageBox($"{bm.GetName()} | {Strings.Lang.GetAbilityName(a)}");	
		}

		private static void Setup() {
			Inputs.gInputFunc = Test;

			Inputs.gMenuFuncs[MenuCode.SHOW_ACTIONS]	= BattleActionSelectionMenu.Select;
			Inputs.gMenuFuncs[MenuCode.SWITCH_TO_MON]	= MonSwitchMenu.Select;
			Inputs.gMenuFuncs[MenuCode.USE_MOVE]		= MoveSelectMenu.Select;

			Global.MessageBox = GodotV.MessageBox.Display;
			// TODO: this kinda temporary.
			Global.AbilityPopup = AbilityPopup;

			Global.BattleSceneSetup = GodotV.BattleSceneDrawer.SetupScene;
		}

		public static void Start() {
			Setup();
			
			gSaveBlock = new SaveBlock {
				trainerID = Random32(),
				language = Language.ENG,
				JPN_USE_FURIGANA = true,
			};

			StartBattle();
		}

		private static async void StartBattle() {
			await Task.Delay(50);

			Pokemon snom		= new Pokemon(Species.SNOM, 100, false, new u8[] {}, false, 0, OtIdType.PLAYER, 0);
			Pokemon shaymin		= new Pokemon(Species.SHAYMIN_LAND_FORME, 20, false, new u8[] {}, false, 0, OtIdType.PLAYER, 0);

			Pokemon munna		= new Pokemon(Species.MUNNA, 55, false, new u8[] {}, false, 0, OtIdType.RANDOM_NO_SHINY, 0);
			Pokemon spoink		= new Pokemon(Species.SPOINK, 50, false, new u8[] {}, false, 0, OtIdType.RANDOM_NO_SHINY, 0);
			Pokemon alcremie	= new Pokemon(Species.ALCREMIE, 10, false, new u8[] {}, false, 0, OtIdType.RANDOM_NO_SHINY, 0);
			Pokemon vulpix		= new Pokemon(Species.VULPIX, 10, false, new u8[] {}, false, 0, OtIdType.RANDOM_NO_SHINY, 0);
			Pokemon sandshrew	= new Pokemon(Species.SANDSHREW, 10, false, new u8[] {}, false, 0, OtIdType.RANDOM_NO_SHINY, 0);
			Pokemon chikorita	= new Pokemon(Species.CHIKORITA, 10, false, new u8[] {}, false, 0, OtIdType.RANDOM_NO_SHINY, 0);
			
			munna.SetNickname("丸子");
			munna.ReplaceMove(0, BattleMoveID.SYNTHESIS);
			munna.ReplaceMove(3, BattleMoveID.CALM_MIND);

			snom.GiveMove(BattleMoveID.DIG);
			snom.GiveMove(BattleMoveID.TRANSFORM);
			shaymin.GiveMove(BattleMoveID.EXPLOSION);
			snom.hp = 6;

			gSaveBlock.profile = new TrainerProfile("Chris", TrainerModel.PLAYER, snom, shaymin);
			TrainerProfile ayla = new TrainerProfile("Ayla", TrainerModel.AI_LVL_1, munna, spoink, alcremie, vulpix, sandshrew, chikorita);

			Battle battle = new Battle(BattleFormat.Format_Single, gSaveBlock.profile, ayla);
			await battle.Start();
		}
	
		private static void Test() {
			throw new System.NotImplementedException();
		}
	}
}