// Decompiled with JetBrains decompiler
// Type: ChessEngine.Engine.Square
// Assembly: ChessEngine, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AD2B565-9B75-423F-BD9A-4B0A934C5249
// Assembly location: C:\Users\Ahmad Elsayed\1\ChessBinNoSetup\ChessBinNoSetup\ChessEngine.dll

namespace ChessEngine.Engine
{
  internal struct Square
  {
    internal Piece Piece;

    internal Square(Piece piece)
    {
      this.Piece = new Piece(piece);
    }
  }
}
