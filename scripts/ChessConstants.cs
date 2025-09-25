using Godot;
using System;
using System.Collections.Generic;

public static class ChessTypes
{
    public enum PieceType
    {
        Pawn,
        Rook,
        Knight,
        Bishop,
        Queen,
        King
    }

    public enum PieceColor
    {
        White,
        Black
    }

    public const int boardRows = 8;
    public const int boardCols = 8;

    public static readonly Dictionary<PieceType, float> PieceCooldowns = new()
    {
        { PieceType.Pawn, 1.0f },
        { PieceType.Rook, 2.0f },
        { PieceType.Knight, 1.5f },
        { PieceType.Bishop, 2.0f },
        { PieceType.Queen, 3.0f },
        { PieceType.King, 5.0f }
    };
}
