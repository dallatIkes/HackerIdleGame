using Godot;
using System;

public partial class MainMenu : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("=== C# project init ===");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	private void _on_start_button_pressed()
	{
		GD.Print("=== Start button pressed ===");
	}
	
	private void _on_settings_button_pressed()
	{
		GD.Print("=== Settings button pressed ===");
	}
	
	private void _on_quit_button_pressed()
	{
		GD.Print("=== Quit button pressed ===");
	}
}
