using Godot;
using System;
using System.Threading.Tasks;

public partial class ButtonThing : Button
{
	//public ProgressBar bar;

	//private bool pressed = false;

	private static int option = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//return;
		////bar = GetParent().GetNode<ProgressBar>("ProgressBar");
		//Button btn = this;

		//switch (this.Name) {
		//	case "btnAttack":
		//		btn.Pressed += OnAttack;
		//		break;
		//	case "btnBag":
		//		btn.Pressed += OnBag;
		//		break;
		//	case "btnRun":
		//		btn.Pressed += OnRun;
		//		break;
		//	case "btnPokemon":
		//		btn.Pressed += OnPokemon;
		//		break;
		//	default:
		//		break;
		//}

		//if (this.Name != "btnAttack") {
		//	return;
		//}


		//await WaitForOption();
		//Console.WriteLine(option + 10);



		////btn.Pressed += OnPressed;
		////Console.WriteLine(this.Name);

		////int a = await WaitForPressed();

		////Console.WriteLine("he comes!");
		////Console.WriteLine(a);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		//Console.WriteLine(option);
	}

	private static async Task WaitForOption() {
		while (option == 0) {
			await Task.Delay(10);
		}
	}

	//private void OnPressed() {
	//	pressed = true;
	//}

	//public void OnClick() {
	//	Console.WriteLine("Hi mom!!");
	//	bar.Value += 10;
	//	this.Visible = false;
	//}

	public static void OnAttack() {
		option = 1;
	}
	public void OnBag() {
		option = 2;
	}
	public void OnRun() {
		option = 3;
	}
	public void OnPokemon() {
		option = 4;
	}

	//public static async Task WaitUntil(bool condition, int frequency = 25, int timeout = -1)
	//{
	//	var waitTask = Task.Run(async () =>
	//	{
	//		while (!condition) await Task.Delay(frequency);
	//	});

	//	if (waitTask != await Task.WhenAny(waitTask, 
	//			Task.Delay(timeout))) 
	//		throw new TimeoutException();
	//}
}
