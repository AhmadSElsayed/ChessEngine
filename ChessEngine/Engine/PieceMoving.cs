// Decompiled with JetBrains decompiler
// Type: ChessEngine.Engine.PieceMoving
// Assembly: ChessEngine, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AD2B565-9B75-423F-BD9A-4B0A934C5249
// Assembly location: C:\Users\Ahmad Elsayed\1\ChessBinNoSetup\ChessBinNoSetup\ChessEngine.dll

namespace ChessEngine.Engine
{
  public struct PieceMoving
  {
    public byte DstPosition;
    public bool Moved;
    public ChessPieceColor PieceColor;
    public ChessPieceType PieceType;
    public byte SrcPosition;

    public PieceMoving(ChessPieceColor pieceColor, ChessPieceType pieceType, bool moved, byte srcPosition, byte dstPosition)
    {
      this.PieceColor = pieceColor;
      this.PieceType = pieceType;
      this.SrcPosition = srcPosition;
      this.DstPosition = dstPosition;
      this.Moved = moved;
    }

    public PieceMoving(PieceMoving pieceMoving)
    {
      this.PieceColor = pieceMoving.PieceColor;
      this.PieceType = pieceMoving.PieceType;
      this.SrcPosition = pieceMoving.SrcPosition;
      this.DstPosition = pieceMoving.DstPosition;
      this.Moved = pieceMoving.Moved;
    }

    public PieceMoving(ChessPieceType pieceType)
    {
      this.PieceType = pieceType;
      this.PieceColor = ChessPieceColor.White;
      this.SrcPosition = (byte) 0;
      this.DstPosition = (byte) 0;
      this.Moved = false;
    }
  }
}
