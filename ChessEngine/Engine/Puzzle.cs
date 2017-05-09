// Decompiled with JetBrains decompiler
// Type: ChessEngine.Engine.Puzzle
// Assembly: ChessEngine, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AD2B565-9B75-423F-BD9A-4B0A934C5249
// Assembly location: C:\Users\Ahmad Elsayed\1\ChessBinNoSetup\ChessBinNoSetup\ChessEngine.dll

using System;

namespace ChessEngine.Engine
{
  public static class Puzzle
  {
    public static ChessEngine.Engine.Engine NewPuzzleKnightBishopKing()
    {
      ChessEngine.Engine.Engine engine;
      do
      {
        engine = Puzzle.PuzzleKnightBishopCandidate();
      }
      while (engine.IsGameOver() || engine.GetBlackCheck() || engine.GetWhiteCheck());
      return engine;
    }

    public static ChessEngine.Engine.Engine NewPuzzleRookKing()
    {
      ChessEngine.Engine.Engine engine;
      do
      {
        engine = Puzzle.PuzzleRookCandidate();
      }
      while (engine.IsGameOver() || engine.GetBlackCheck() || engine.GetWhiteCheck());
      return engine;
    }

    public static ChessEngine.Engine.Engine NewPuzzlePawnKing()
    {
      ChessEngine.Engine.Engine engine;
      do
      {
        engine = Puzzle.PuzzleKingPawnCandidate();
      }
      while (engine.IsGameOver() || engine.GetBlackCheck() || engine.GetWhiteCheck());
      return engine;
    }

    private static ChessEngine.Engine.Engine PuzzleKnightBishopCandidate()
    {
      ChessEngine.Engine.Engine engine = new ChessEngine.Engine.Engine("");
      Random random = new Random(DateTime.Now.Second);
      byte index1;
      byte index2;
      byte index3;
      byte index4;
      do
      {
        index1 = (byte) random.Next(63);
        index2 = (byte) random.Next(63);
        index3 = (byte) random.Next(63);
        index4 = (byte) random.Next(63);
      }
      while ((int) index1 == (int) index2 || (int) index1 == (int) index4 || ((int) index1 == (int) index3 || (int) index3 == (int) index4) || ((int) index2 == (int) index4 || (int) index2 == (int) index1));
      Piece piece1 = new Piece(ChessPieceType.King, ChessPieceColor.White);
      Piece piece2 = new Piece(ChessPieceType.Bishop, ChessPieceColor.White);
      Piece piece3 = new Piece(ChessPieceType.Knight, ChessPieceColor.White);
      Piece piece4 = new Piece(ChessPieceType.King, ChessPieceColor.Black);
      engine.SetChessPiece(piece1, index1);
      engine.SetChessPiece(piece4, index2);
      engine.SetChessPiece(piece3, index3);
      engine.SetChessPiece(piece2, index4);
      engine.GenerateValidMoves();
      engine.EvaluateBoardScore();
      return engine;
    }

    private static ChessEngine.Engine.Engine PuzzleRookCandidate()
    {
      ChessEngine.Engine.Engine engine = new ChessEngine.Engine.Engine("");
      Random random = new Random(DateTime.Now.Second);
      byte index1;
      byte index2;
      byte index3;
      do
      {
        index1 = (byte) random.Next(63);
        index2 = (byte) random.Next(63);
        index3 = (byte) random.Next(63);
      }
      while ((int) index1 == (int) index2 || (int) index1 == (int) index3 || (int) index2 == (int) index1);
      Piece piece1 = new Piece(ChessPieceType.King, ChessPieceColor.White);
      Piece piece2 = new Piece(ChessPieceType.Rook, ChessPieceColor.White);
      Piece piece3 = new Piece(ChessPieceType.King, ChessPieceColor.Black);
      engine.SetChessPiece(piece1, index1);
      engine.SetChessPiece(piece3, index2);
      engine.SetChessPiece(piece2, index3);
      engine.GenerateValidMoves();
      engine.EvaluateBoardScore();
      return engine;
    }

    private static ChessEngine.Engine.Engine PuzzleKingPawnCandidate()
    {
      ChessEngine.Engine.Engine engine = new ChessEngine.Engine.Engine("");
      Random random = new Random(DateTime.Now.Second);
      byte index1;
      byte index2;
      byte index3;
      do
      {
        index1 = (byte) random.Next(63);
        index2 = (byte) random.Next(63);
        index3 = (byte) random.Next(63);
      }
      while ((int) index1 == (int) index2 || (int) index1 == (int) index3 || ((int) index2 == (int) index1 || (int) index3 <= 8) || ((int) index3 >= 56 || (int) index3 < (int) index2));
      Piece piece1 = new Piece(ChessPieceType.King, ChessPieceColor.White);
      Piece piece2 = new Piece(ChessPieceType.Pawn, ChessPieceColor.White);
      Piece piece3 = new Piece(ChessPieceType.King, ChessPieceColor.Black);
      engine.SetChessPiece(piece1, index1);
      engine.SetChessPiece(piece3, index2);
      engine.SetChessPiece(piece2, index3);
      engine.GenerateValidMoves();
      engine.EvaluateBoardScore();
      return engine;
    }
  }
}
