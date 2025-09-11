using Godot;
using System;

public partial class Music : Node
{
	private AudioStreamPlayer musicPlayer;
	private float currentVolume;

	public override void _Ready()
	{
		currentVolume = 1.0F;
		musicPlayer = GetNode<AudioStreamPlayer>("AudioStreamPlayer");
		musicPlayer.Stream = GD.Load<AudioStream>("res://game/assets/background.mp3");
		musicPlayer.Play();
	}

	public void SetMusicVolume(float value)
	{
		currentVolume = value;
		musicPlayer.VolumeDb = Mathf.LinearToDb(value);
		ProjectSettings.SetSetting("audio/volume/music", value);
	}

	public float getCurrentVolume()
	{
		return currentVolume;
	}
}
