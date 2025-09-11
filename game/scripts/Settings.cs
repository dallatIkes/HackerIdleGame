using Godot;
using System;

public partial class Settings : Control
{

	private Label soundVolumeLabel;
	private HSlider volumeSlider;
	private Music audioManager;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("=== C# Settings Screen init ===");
		audioManager = GetNode<Music>("/root/Music");
		volumeSlider = GetNode<HSlider>("Panel/ColorRect/VBoxContainer/Sound-settings/Sound");
		soundVolumeLabel = GetNode<Label>("Panel/ColorRect/VBoxContainer/Sound-settings/Sound-volume-label");

		volumeSlider.Value = audioManager.getCurrentVolume();
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

	private void _on_sound_value_changed(float value)
	{
		audioManager.SetMusicVolume((float)value);
		soundVolumeLabel.Text = "Volume : " + ((int)(value * 100)).ToString();
	}
}
