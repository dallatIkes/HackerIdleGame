// GameScreen.cs
using Godot;
using System;

public partial class GameScreen : Control
{
	private GameManager gameManager;
	private Label cryptoLabel;

	public override void _Ready()
	{
		GD.Print("=== on arrive sur le game screen ===");
		cryptoLabel = GetNode<Label>("Panel/ColorRect/Top-Menu/HBoxContainer/Crypto-label");

		GameManager gameManager = GetNode<GameManager>("/root/Control/Game");
		// GD.Print("gameManager : " + gameManager);
		// GD.Print("Crypto amount : " + gameManager.Player.Crypto.Amount);

		// Update directement le label
		// cryptoLabel.Text = $"$ {gameManager.Player.Crypto.Amount:0.00}";
		cryptoLabel.Text = "test";
	}

	public override void _Process(double delta)
	{
		GameManager gameManager = GetNode<GameManager>("/root/Control/Game");
		// cryptoLabel.Text = $"$ {gameManager.Player.Crypto.Amount:0.00}";
	}

	private void _on_menu_button_pressed()
	{
		GD.Print("=== Menu button pressed ===");
		GetTree().ChangeSceneToFile("res://game/scenes/MainMenu.tscn");
	}
}
