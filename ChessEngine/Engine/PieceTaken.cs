// Decompiled with JetBrains decompiler
// Type: ChessEngine.Engine.PieceTaken
// Assembly: ChessEngine, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AD2B565-9B75-423F-BD9A-4B0A934C5249
// Assembly location: C:\Users\Ahmad Elsayed\1\ChessBinNoSetup\ChessBinNoSetup\ChessEngine.dll

namespace ChessEngine.Engine
{
  public struct PieceTaken
  {
    public bool Moved;
    public ChessPieceColor PieceColor;
    public ChessPieceType PieceType;
    public byte Position;

    public PieceTaken(ChessPieceColor pieceColor, ChessPieceType pieceType, bool moved, byte position)
    {
      this.PieceColor = pieceColor;
      this.PieceType = pieceType;
      this.Position = position;
      this.Moved = moved;
    }

    public PieceTaken(ChessPieceType pieceType)
    {
      this.PieceColor = ChessPieceColor.White;
      this.PieceType = pieceType;
      this.Position = (byte) 0;
      this.Moved = false;
    }
  }
}
