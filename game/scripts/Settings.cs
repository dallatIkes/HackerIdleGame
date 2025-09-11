using Godot;
using System;

public partial class Settings : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("=== C# Settings Screen init ===");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void _on_return_pressed()
	{
		GD.Print("=== Return button pressed ===");
		GetTree().ChangeSceneToFile("res://game/scenes/MainMenu.tscn");
	}
}
