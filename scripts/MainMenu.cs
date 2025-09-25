using Godot;
using System;


public partial class MainMenu : Control
{
	string gameScenePath = "res://scenes/ChessGame.tscn";

	string newGameButtonNodePath = "Buttons/NewGame";
	string exitButtonNodePath = "Buttons/Exit";

	public override void _Ready()
	{
		GetNode<Button>(newGameButtonNodePath).Pressed += OnNewGamePressed;
		GetNode<Button>(exitButtonNodePath).Pressed += OnExitPressed;
	}

	private void OnNewGamePressed()
	{
		GD.Print("New Game pressed");
		GetTree().ChangeSceneToFile(gameScenePath);
	}

	private void OnExitPressed()
	{
		GetTree().Quit();
	}
}
