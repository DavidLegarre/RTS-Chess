using Godot;
using System;

public partial class Piece : Node2D
{
    [Export] public ChessTypes.PieceType Type { get; set; } = ChessTypes.PieceType.Pawn;
    [Export] public ChessTypes.PieceColor Color { get; set; } = ChessTypes.PieceColor.White;

    private Sprite2D _sprite;
    private float _cooldownTimer;

    public override void _Ready()
    {
        _cooldownTimer = ChessTypes.PieceCooldowns[Type];
        _sprite = GetNode<Sprite2D>("Sprite2D");

        GD.Print($"Piece {Type} cooldown: {_cooldownTimer}");
        UpdateSprite();
    }

    public override void _Process(double delta)
    {
        if (_cooldownTimer > 0)
        {
            _cooldownTimer -= (float)delta;
        }
    }

    public bool CanMove() => _cooldownTimer <= 0;


    public void MoveTo(Vector2 newPosition)
    {
        if (!CanMove()) return;

        Position = newPosition;
        _cooldownTimer = ChessTypes.PieceCooldowns[Type];
    }


    private void UpdateSprite() { }
}
