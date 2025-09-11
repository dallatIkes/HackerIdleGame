using Godot;
using System;

public partial class MainMenu : Control
{
	public override void _Ready()
	{
		/* DEBUG */
		GD.Print("=== Project Start ===");
		var startButton = GetNode<Button>("StartButton");
		startButton.Pressed += OnStartButtonPressed;
	}
	
	private void OnStartButtonPressed()
	{
		GD.Print("Start Button pressed!");
	}
}
