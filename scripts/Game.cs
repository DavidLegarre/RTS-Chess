using Godot;
using System;

public partial class Game : Control
{
	private GridContainer _board;
	private const int tileSize = 80;

	public override void _Ready()
	{
		_board = GetNodeOrNull<GridContainer>("CenterContainer/Board");

		if (_board == null)
		{
			GD.PrintErr("Board node not found! Make sure the path is correct.");
			return;
		}


		_board.Columns = ChessTypes.boardCols;

		for (int row = 0; row < ChessTypes.boardRows; row++)
		{
			for (int col = 0; col < ChessTypes.boardCols; col++)
			{
				ColorRect tile = new ColorRect();
				tile.CustomMinimumSize = new Vector2(tileSize, tileSize);

				tile.Color = ((row + col) % 2 == 0) ? new Color(0.9f, 0.9f, 0.9f) : new Color(0.2f, 0.2f, 0.2f);

				_board.AddChild(tile);
			}
		}
	}
}
