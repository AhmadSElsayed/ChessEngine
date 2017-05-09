// Decompiled with JetBrains decompiler
// Type: ChessEngine.Engine.Piece
// Assembly: ChessEngine, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AD2B565-9B75-423F-BD9A-4B0A934C5249
// Assembly location: C:\Users\Ahmad Elsayed\1\ChessBinNoSetup\ChessBinNoSetup\ChessEngine.dll

using System.Collections.Generic;

namespace ChessEngine.Engine
{
  internal sealed class Piece
  {
    internal ChessPieceColor PieceColor;
    internal ChessPieceType PieceType;
    internal short PieceValue;
    internal short PieceActionValue;
    internal short AttackedValue;
    internal short DefendedValue;
    internal int LastValidMoveCount;
    internal bool Moved;
    internal bool Selected;
    internal Stack<byte> ValidMoves;

    internal Piece(Piece piece)
    {
      this.PieceColor = piece.PieceColor;
      this.PieceType = piece.PieceType;
      this.Moved = piece.Moved;
      this.PieceValue = piece.PieceValue;
      this.PieceActionValue = piece.PieceActionValue;
      if (piece.ValidMoves == null)
        return;
      this.LastValidMoveCount = piece.ValidMoves.Count;
    }

    internal Piece(ChessPieceType chessPiece, ChessPieceColor chessPieceColor)
    {
      this.PieceType = chessPiece;
      this.PieceColor = chessPieceColor;
      this.LastValidMoveCount = this.PieceType == ChessPieceType.Pawn || this.PieceType == ChessPieceType.Knight ? 2 : 0;
      this.ValidMoves = new Stack<byte>(this.LastValidMoveCount);
      this.PieceValue = Piece.CalculatePieceValue(this.PieceType);
      this.PieceActionValue = Piece.CalculatePieceActionValue(this.PieceType);
    }

    internal static string GetPieceTypeShort(ChessPieceType pieceType)
    {
      switch (pieceType)
      {
        case ChessPieceType.King:
          return "K";
        case ChessPieceType.Queen:
          return "Q";
        case ChessPieceType.Rook:
          return "R";
        case ChessPieceType.Bishop:
          return "B";
        case ChessPieceType.Knight:
          return "N";
        case ChessPieceType.Pawn:
          return "P";
        default:
          return "P";
      }
    }

    internal static short CalculatePieceValue(ChessPieceType pieceType)
    {
      switch (pieceType)
      {
        case ChessPieceType.King:
          return short.MaxValue;
        case ChessPieceType.Queen:
          return 975;
        case ChessPieceType.Rook:
          return 500;
        case ChessPieceType.Bishop:
          return 325;
        case ChessPieceType.Knight:
          return 320;
        case ChessPieceType.Pawn:
          return 100;
        default:
          return 0;
      }
    }

    internal static short CalculatePieceActionValue(ChessPieceType pieceType)
    {
      switch (pieceType)
      {
        case ChessPieceType.King:
          return 1;
        case ChessPieceType.Queen:
          return 1;
        case ChessPieceType.Rook:
          return 2;
        case ChessPieceType.Bishop:
          return 3;
        case ChessPieceType.Knight:
          return 3;
        case ChessPieceType.Pawn:
          return 6;
        default:
          return 0;
      }
    }

    public new string ToString()
    {
      return ((int) this.PieceType).ToString() + " " + (object) this.PieceColor + " " + (object) this.PieceValue + " " + (object) this.PieceActionValue + " " + (object) this.ValidMoves.Count + " " + (object) this.AttackedValue + " " + (object) this.DefendedValue;
    }
  }
}
