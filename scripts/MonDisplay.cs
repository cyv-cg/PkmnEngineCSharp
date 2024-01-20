using u8  = System.Byte;
using u16 = System.UInt16;
using u32 = System.UInt32;
using u64 = System.UInt64;

using Godot;
using System;

namespace PkmnEngine.GodotV {
	public partial class MonDisplay : Control {
		private const float HP_YELLOW_THRESHOLD = 0.5f;
		private const float HP_RED_THRESHOLD = 0.33f;

		public Battle battle;
		public u8 slot;

		public TextureRect monSprite;

		private RichTextLabel monNameLabel;
		private RichTextLabel monLevelLabel;

		private RichTextLabel monCurrHPLabel;
		private RichTextLabel monMaxHPLabel;

		private TextureProgressBar healthBarGreen;
		private TextureProgressBar healthBarYellow;
		private TextureProgressBar healthBarRed;

		private TextureProgressBar expBar;

		// Called when the node enters the scene tree for the first time.
		public override void _Ready() {
			monNameLabel = GetNode<RichTextLabel>("HealthBar/TextContainer/MonNameLabel");
			monLevelLabel = GetNode<RichTextLabel>("HealthBar/TextContainer/MonLevelLabel");

			healthBarGreen = GetNode<TextureProgressBar>("HealthBar/BarGreen");
			healthBarYellow = GetNode<TextureProgressBar>("HealthBar/BarYellow");
			healthBarRed = GetNode<TextureProgressBar>("HealthBar/BarRed");

			if (GetParent().Name == "ContainerClient") {
				monCurrHPLabel = GetNode<RichTextLabel>("HealthBar/TextContainer/MonCurrHPLabel");
				monMaxHPLabel = GetNode<RichTextLabel>("HealthBar/TextContainer/MonMaxHPLabel");
				expBar = GetNode<TextureProgressBar>("HealthBar/ExpBar");
			}
		}

		// Called every frame. 'delta' is the elapsed time since the previous frame.
		public override void _Process(double delta) {
			if (battle == null) {
				return;
			}
			BattleMon target = battle.GetMonInSlot(battle.CurrentState, slot);

			monNameLabel.Text = target.GetName();
			monLevelLabel.Text = target.Mon.level.ToString();

			float healthPercent = target.GetHpPercent();
			if (healthPercent >= HP_YELLOW_THRESHOLD) {
				healthBarGreen.Visible = true;
				healthBarYellow.Visible = false;
				healthBarRed.Visible = false;

				healthBarGreen.Value = target.HP;
				healthBarGreen.MaxValue = target.MaxHP;
			}
			else if (healthPercent >= HP_RED_THRESHOLD && healthPercent < HP_YELLOW_THRESHOLD) {
				healthBarGreen.Visible = false;
				healthBarYellow.Visible = true;
				healthBarRed.Visible = false;

				healthBarYellow.Value = target.HP;
				healthBarYellow.MaxValue = target.MaxHP;
			}
			else {
				healthBarGreen.Visible = false;
				healthBarYellow.Visible = false;
				healthBarRed.Visible = true;

				healthBarRed.Value = target.HP;
				healthBarRed.MaxValue = target.MaxHP;
			}

			if (GetParent().Name == "ContainerClient") {
				monCurrHPLabel.Text = $"[right]{target.HP}[/right]";
				monMaxHPLabel.Text = target.MaxHP.ToString();

				expBar.Value = target.Mon.exp - ExpGroups.gExperienceTables(BaseStats.gBaseStats(target.Mon.Box.Species).growth, target.Mon.level);
				expBar.MaxValue = target.Mon.ExpToNextLevel;
			}

			monSprite.Texture = Sprites.MonSprites.GetSprite(target.Species);
		}
	}
}