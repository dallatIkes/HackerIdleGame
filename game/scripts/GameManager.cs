// GameManager.cs
using Godot;
using System;

public partial class GameManager : Node
{
	public Player Player { get; private set; }

	public override void _Ready()
	{
		Player = new Player("dallatIkes");
	}

	public override void _Process(double delta)
	{
	}
}
