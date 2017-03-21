// Decompiled with JetBrains decompiler
// Type: ChessEngine.Engine.PieceMoveSet
// Assembly: ChessEngine, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AD2B565-9B75-423F-BD9A-4B0A934C5249
// Assembly location: C:\Users\Ahmad Elsayed\1\ChessBinNoSetup\ChessBinNoSetup\ChessEngine.dll

using System.Collections.Generic;

namespace ChessEngine.Engine
{
  internal struct PieceMoveSet
  {
    internal readonly List<byte> Moves;

    internal PieceMoveSet(List<byte> moves)
    {
      this.Moves = moves;
    }
  }
}
