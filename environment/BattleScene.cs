using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using Godot;

namespace PkmnEngine.GodotV {
	public static class BattleSceneDrawer {
		public static void SetupScene(Battle battle, TrainerBattleContext[] players) {
			BattleScene.Scene.Setup(battle, players);
		}
	}

	public partial class BattleScene : Control {
		private const string DISPLAY_CLIENT = "mon_display_client";
		private const string DISPLAY_REMOTE = "mon_display_opp";

		private const string SPRITE_CONTAINER = "mon_sprite_container";

		public static BattleScene Scene { get; private set; }
		
		public override void _Ready() {
			Scene?.QueueFree();
			Scene = this;
		}

		public void Setup(Battle battle, TrainerBattleContext[] players) {
			GridContainer clientContainer = Scene.GetChild<GridContainer>(0);
			GridContainer oppContainer = Scene.GetChild<GridContainer>(1);
			GridContainer clientSpriteContainer = Scene.GetChild(2).GetChild<GridContainer>(0);
			GridContainer oppSpriteContainer = Scene.GetChild(2).GetChild<GridContainer>(1);

			foreach (u8 slot in battle.format.SlotsOnSide(Battle.SIDE_CLIENT)) {
				MonDisplay display = GD.Load<PackedScene>($"res://{DISPLAY_CLIENT}.tscn").Instantiate() as MonDisplay;
				Control spriteDisplay = GD.Load<PackedScene>($"res://{SPRITE_CONTAINER}.tscn").Instantiate() as Control;
				clientContainer.AddChild(display);
				clientSpriteContainer.AddChild(spriteDisplay);
				display.battle = battle;
				display.slot = slot;
				display.monSprite = spriteDisplay.GetChild<TextureRect>(0);
			}

			foreach (u8 slot in battle.format.SlotsOnSide(Battle.SIDE_REMOTE)) {
				MonDisplay display = GD.Load<PackedScene>($"res://{DISPLAY_REMOTE}.tscn").Instantiate() as MonDisplay;
				Control spriteDisplay = GD.Load<PackedScene>($"res://{SPRITE_CONTAINER}.tscn").Instantiate() as Control;
				oppContainer.AddChild(display);
				oppSpriteContainer.AddChild(spriteDisplay);
				display.battle = battle;
				display.slot = slot;
				display.monSprite = spriteDisplay.GetChild<TextureRect>(0);
			}
		}
	}
}
