// Decompiled with JetBrains decompiler
// Type: ChessEngine.Engine.Evaluation
// Assembly: ChessEngine, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AD2B565-9B75-423F-BD9A-4B0A934C5249
// Assembly location: C:\Users\Ahmad Elsayed\1\ChessBinNoSetup\ChessBinNoSetup\ChessEngine.dll

namespace ChessEngine.Engine
{
  internal static class Evaluation
  {
    private static readonly short[] PawnTable = new short[64]
    {
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 50,
      (short) 50,
      (short) 50,
      (short) 50,
      (short) 50,
      (short) 50,
      (short) 50,
      (short) 50,
      (short) 20,
      (short) 20,
      (short) 30,
      (short) 40,
      (short) 40,
      (short) 30,
      (short) 20,
      (short) 20,
      (short) 5,
      (short) 5,
      (short) 10,
      (short) 30,
      (short) 30,
      (short) 10,
      (short) 5,
      (short) 5,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 25,
      (short) 25,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 5,
      (short) -5,
      (short) -10,
      (short) 0,
      (short) 0,
      (short) -10,
      (short) -5,
      (short) 5,
      (short) 5,
      (short) 10,
      (short) 10,
      (short) -30,
      (short) -30,
      (short) 10,
      (short) 10,
      (short) 5,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0
    };
    private static readonly short[] KnightTable = new short[64]
    {
      (short) -50,
      (short) -40,
      (short) -30,
      (short) -30,
      (short) -30,
      (short) -30,
      (short) -40,
      (short) -50,
      (short) -40,
      (short) -20,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) -20,
      (short) -40,
      (short) -30,
      (short) 0,
      (short) 10,
      (short) 15,
      (short) 15,
      (short) 10,
      (short) 0,
      (short) -30,
      (short) -30,
      (short) 5,
      (short) 15,
      (short) 20,
      (short) 20,
      (short) 15,
      (short) 5,
      (short) -30,
      (short) -30,
      (short) 0,
      (short) 15,
      (short) 20,
      (short) 20,
      (short) 15,
      (short) 0,
      (short) -30,
      (short) -30,
      (short) 5,
      (short) 10,
      (short) 15,
      (short) 15,
      (short) 10,
      (short) 5,
      (short) -30,
      (short) -40,
      (short) -20,
      (short) 0,
      (short) 5,
      (short) 5,
      (short) 0,
      (short) -20,
      (short) -40,
      (short) -50,
      (short) -30,
      (short) -20,
      (short) -30,
      (short) -30,
      (short) -20,
      (short) -30,
      (short) -50
    };
    private static readonly short[] BishopTable = new short[64]
    {
      (short) -20,
      (short) -10,
      (short) -10,
      (short) -10,
      (short) -10,
      (short) -10,
      (short) -10,
      (short) -20,
      (short) -10,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) -10,
      (short) -10,
      (short) 0,
      (short) 5,
      (short) 10,
      (short) 10,
      (short) 5,
      (short) 0,
      (short) -10,
      (short) -10,
      (short) 5,
      (short) 5,
      (short) 10,
      (short) 10,
      (short) 5,
      (short) 5,
      (short) -10,
      (short) -10,
      (short) 0,
      (short) 10,
      (short) 10,
      (short) 10,
      (short) 10,
      (short) 0,
      (short) -10,
      (short) -10,
      (short) 10,
      (short) 10,
      (short) 10,
      (short) 10,
      (short) 10,
      (short) 10,
      (short) -10,
      (short) -10,
      (short) 5,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 5,
      (short) -10,
      (short) -20,
      (short) -10,
      (short) -40,
      (short) -10,
      (short) -10,
      (short) -40,
      (short) -10,
      (short) -20
    };
    private static readonly short[] KingTable = new short[64]
    {
      (short) -30,
      (short) -40,
      (short) -40,
      (short) -50,
      (short) -50,
      (short) -40,
      (short) -40,
      (short) -30,
      (short) -30,
      (short) -40,
      (short) -40,
      (short) -50,
      (short) -50,
      (short) -40,
      (short) -40,
      (short) -30,
      (short) -30,
      (short) -40,
      (short) -40,
      (short) -50,
      (short) -50,
      (short) -40,
      (short) -40,
      (short) -30,
      (short) -30,
      (short) -40,
      (short) -40,
      (short) -50,
      (short) -50,
      (short) -40,
      (short) -40,
      (short) -30,
      (short) -20,
      (short) -30,
      (short) -30,
      (short) -40,
      (short) -40,
      (short) -30,
      (short) -30,
      (short) -20,
      (short) -10,
      (short) -20,
      (short) -20,
      (short) -20,
      (short) -20,
      (short) -20,
      (short) -20,
      (short) -10,
      (short) 20,
      (short) 20,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 20,
      (short) 20,
      (short) 20,
      (short) 30,
      (short) 10,
      (short) 0,
      (short) 0,
      (short) 10,
      (short) 30,
      (short) 20
    };
    private static readonly short[] KingTableEndGame = new short[64]
    {
      (short) -50,
      (short) -40,
      (short) -30,
      (short) -20,
      (short) -20,
      (short) -30,
      (short) -40,
      (short) -50,
      (short) -30,
      (short) -20,
      (short) -10,
      (short) 0,
      (short) 0,
      (short) -10,
      (short) -20,
      (short) -30,
      (short) -30,
      (short) -10,
      (short) 20,
      (short) 30,
      (short) 30,
      (short) 20,
      (short) -10,
      (short) -30,
      (short) -30,
      (short) -10,
      (short) 30,
      (short) 40,
      (short) 40,
      (short) 30,
      (short) -10,
      (short) -30,
      (short) -30,
      (short) -10,
      (short) 30,
      (short) 40,
      (short) 40,
      (short) 30,
      (short) -10,
      (short) -30,
      (short) -30,
      (short) -10,
      (short) 20,
      (short) 30,
      (short) 30,
      (short) 20,
      (short) -10,
      (short) -30,
      (short) -30,
      (short) -30,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) 0,
      (short) -30,
      (short) -30,
      (short) -50,
      (short) -30,
      (short) -30,
      (short) -30,
      (short) -30,
      (short) -30,
      (short) -30,
      (short) -50
    };
    private static short[] blackPawnCount;
    private static short[] whitePawnCount;

    private static int EvaluatePieceScore(Square square, byte position, bool endGamePhase, ref byte knightCount, ref byte bishopCount, ref bool insufficientMaterial)
    {
      int num1 = 0;
      byte num2 = position;
      if (square.Piece.PieceColor == ChessPieceColor.Black)
        num2 = (byte) (63U - (uint) position);
      int num3 = num1 + (int) square.Piece.PieceValue + (int) square.Piece.DefendedValue - (int) square.Piece.AttackedValue;
      if ((int) square.Piece.DefendedValue < (int) square.Piece.AttackedValue)
        num3 -= ((int) square.Piece.AttackedValue - (int) square.Piece.DefendedValue) * 10;
      if (square.Piece.ValidMoves != null)
        num3 += square.Piece.ValidMoves.Count;
      if (square.Piece.PieceType == ChessPieceType.Pawn)
      {
        insufficientMaterial = false;
        if ((int) position % 8 == 0 || (int) position % 8 == 7)
          num3 -= 15;
        num3 += (int) Evaluation.PawnTable[(int) num2];
        if (square.Piece.PieceColor == ChessPieceColor.White)
        {
          if ((int) Evaluation.whitePawnCount[(int) position % 8] > 0)
            num3 -= 15;
          if ((int) position >= 8 && (int) position <= 15)
          {
            if ((int) square.Piece.AttackedValue == 0)
            {
              Evaluation.whitePawnCount[(int) position % 8] += (short) 50;
              if ((int) square.Piece.DefendedValue != 0)
                Evaluation.whitePawnCount[(int) position % 8] += (short) 50;
            }
          }
          else if ((int) position >= 16 && (int) position <= 23 && (int) square.Piece.AttackedValue == 0)
          {
            Evaluation.whitePawnCount[(int) position % 8] += (short) 25;
            if ((int) square.Piece.DefendedValue != 0)
              Evaluation.whitePawnCount[(int) position % 8] += (short) 25;
          }
          Evaluation.whitePawnCount[(int) position % 8] += (short) 10;
        }
        else
        {
          if ((int) Evaluation.blackPawnCount[(int) position % 8] > 0)
            num3 -= 15;
          if ((int) position >= 48 && (int) position <= 55)
          {
            if ((int) square.Piece.AttackedValue == 0)
            {
              Evaluation.blackPawnCount[(int) position % 8] += (short) 200;
              if ((int) square.Piece.DefendedValue != 0)
                Evaluation.blackPawnCount[(int) position % 8] += (short) 50;
            }
          }
          else if ((int) position >= 40 && (int) position <= 47 && (int) square.Piece.AttackedValue == 0)
          {
            Evaluation.blackPawnCount[(int) position % 8] += (short) 100;
            if ((int) square.Piece.DefendedValue != 0)
              Evaluation.blackPawnCount[(int) position % 8] += (short) 25;
          }
          Evaluation.blackPawnCount[(int) position % 8] += (short) 10;
        }
      }
      else if (square.Piece.PieceType == ChessPieceType.Knight)
      {
        knightCount = (byte) ((uint) knightCount + 1U);
        num3 += (int) Evaluation.KnightTable[(int) num2];
        if (endGamePhase)
          num3 -= 10;
      }
      else if (square.Piece.PieceType == ChessPieceType.Bishop)
      {
        bishopCount = (byte) ((uint) bishopCount + 1U);
        if ((int) bishopCount >= 2)
          num3 += 10;
        if (endGamePhase)
          num3 += 10;
        num3 += (int) Evaluation.BishopTable[(int) num2];
      }
      else if (square.Piece.PieceType == ChessPieceType.Rook)
        insufficientMaterial = false;
      else if (square.Piece.PieceType == ChessPieceType.Queen)
      {
        insufficientMaterial = false;
        if (square.Piece.Moved && !endGamePhase)
          num3 -= 10;
      }
      else if (square.Piece.PieceType == ChessPieceType.King)
      {
        if (square.Piece.ValidMoves != null && square.Piece.ValidMoves.Count < 2)
          num3 -= 5;
        if (endGamePhase)
          num3 += (int) Evaluation.KingTableEndGame[(int) num2];
        else
          num3 += (int) Evaluation.KingTable[(int) num2];
      }
      return num3;
    }

    internal static void EvaluateBoardScore(Board board)
    {
      if ((int) board.EnPassantPosition == 0 && !board.EndGamePhase)
      {
        int? nullable1 = Zobrist.SearchEval(board.ZobristHash);
        if (nullable1.HasValue)
        {
          int? nullable2 = nullable1;
          int num = 0;
          if ((nullable2.GetValueOrDefault() == num ? (!nullable2.HasValue ? 1 : 0) : 1) != 0)
          {
            board.Score = nullable1.Value;
            return;
          }
        }
      }
      board.Score = 0;
      bool insufficientMaterial = true;
      if (board.StaleMate || (int) board.FiftyMove >= 50 || (int) board.RepeatedMove >= 3)
        return;
      if (board.BlackMate)
        board.Score = (int) short.MaxValue;
      else if (board.WhiteMate)
      {
        board.Score = -32767;
      }
      else
      {
        if (board.BlackCheck)
        {
          board.Score += 70;
          if (board.EndGamePhase)
            board.Score += 10;
        }
        else if (board.WhiteCheck)
        {
          board.Score -= 70;
          if (board.EndGamePhase)
            board.Score -= 10;
        }
        if (board.BlackCastled)
          board.Score -= 50;
        if (board.WhiteCastled)
          board.Score += 50;
        if (board.WhoseMove == ChessPieceColor.White)
          board.Score += 10;
        else
          board.Score -= 10;
        byte bishopCount1 = 0;
        byte bishopCount2 = 0;
        byte knightCount1 = 0;
        byte knightCount2 = 0;
        byte num = 0;
        Evaluation.blackPawnCount = new short[8];
        Evaluation.whitePawnCount = new short[8];
        for (byte position = 0; (int) position < 64; ++position)
        {
          Square square = board.Squares[(int) position];
          if (square.Piece != null)
          {
            if (square.Piece.PieceColor == ChessPieceColor.White)
            {
              board.Score += Evaluation.EvaluatePieceScore(square, position, board.EndGamePhase, ref knightCount2, ref bishopCount2, ref insufficientMaterial);
              if (square.Piece.PieceType == ChessPieceType.King && (int) position != 59 && (int) position != 60)
              {
                int pawnPos1 = (int) position - 8;
                board.Score += Evaluation.CheckPawnWall(board, pawnPos1, (int) position);
                int pawnPos2 = (int) position - 7;
                board.Score += Evaluation.CheckPawnWall(board, pawnPos2, (int) position);
                int pawnPos3 = (int) position - 9;
                board.Score += Evaluation.CheckPawnWall(board, pawnPos3, (int) position);
              }
            }
            else if (square.Piece.PieceColor == ChessPieceColor.Black)
            {
              board.Score -= Evaluation.EvaluatePieceScore(square, position, board.EndGamePhase, ref knightCount1, ref bishopCount1, ref insufficientMaterial);
              if (square.Piece.PieceType == ChessPieceType.King && (int) position != 3 && (int) position != 4)
              {
                int pawnPos1 = (int) position + 8;
                board.Score -= Evaluation.CheckPawnWall(board, pawnPos1, (int) position);
                int pawnPos2 = (int) position + 7;
                board.Score -= Evaluation.CheckPawnWall(board, pawnPos2, (int) position);
                int pawnPos3 = (int) position + 9;
                board.Score -= Evaluation.CheckPawnWall(board, pawnPos3, (int) position);
              }
            }
            if (square.Piece.PieceType == ChessPieceType.Knight)
            {
              ++num;
              if ((int) num > 1)
                insufficientMaterial = false;
            }
            if ((int) bishopCount1 + (int) bishopCount2 > 1)
              insufficientMaterial = false;
            else if ((int) bishopCount1 + (int) knightCount1 > 1)
              insufficientMaterial = false;
            else if ((int) bishopCount2 + (int) knightCount2 > 1)
              insufficientMaterial = false;
          }
        }
        if (insufficientMaterial)
        {
          board.Score = 0;
          board.StaleMate = true;
          board.InsufficientMaterial = true;
        }
        else
        {
          if (board.EndGamePhase)
          {
            if (board.BlackCheck)
              board.Score += 10;
            else if (board.WhiteCheck)
              board.Score -= 10;
          }
          else
          {
            if (!board.WhiteCanCastle && !board.WhiteCastled)
              board.Score -= 50;
            if (!board.BlackCanCastle && !board.BlackCastled)
              board.Score += 50;
          }
          if ((int) Evaluation.blackPawnCount[0] >= 1 && (int) Evaluation.blackPawnCount[1] == 0)
            board.Score += 12;
          if ((int) Evaluation.blackPawnCount[1] >= 1 && (int) Evaluation.blackPawnCount[0] == 0 && (int) Evaluation.blackPawnCount[2] == 0)
            board.Score += 14;
          if ((int) Evaluation.blackPawnCount[2] >= 1 && (int) Evaluation.blackPawnCount[1] == 0 && (int) Evaluation.blackPawnCount[3] == 0)
            board.Score += 16;
          if ((int) Evaluation.blackPawnCount[3] >= 1 && (int) Evaluation.blackPawnCount[2] == 0 && (int) Evaluation.blackPawnCount[4] == 0)
            board.Score += 20;
          if ((int) Evaluation.blackPawnCount[4] >= 1 && (int) Evaluation.blackPawnCount[3] == 0 && (int) Evaluation.blackPawnCount[5] == 0)
            board.Score += 20;
          if ((int) Evaluation.blackPawnCount[5] >= 1 && (int) Evaluation.blackPawnCount[4] == 0 && (int) Evaluation.blackPawnCount[6] == 0)
            board.Score += 16;
          if ((int) Evaluation.blackPawnCount[6] >= 1 && (int) Evaluation.blackPawnCount[5] == 0 && (int) Evaluation.blackPawnCount[7] == 0)
            board.Score += 14;
          if ((int) Evaluation.blackPawnCount[7] >= 1 && (int) Evaluation.blackPawnCount[6] == 0)
            board.Score += 12;
          if ((int) Evaluation.whitePawnCount[0] >= 1 && (int) Evaluation.whitePawnCount[1] == 0)
            board.Score -= 12;
          if ((int) Evaluation.whitePawnCount[1] >= 1 && (int) Evaluation.whitePawnCount[0] == 0 && (int) Evaluation.whitePawnCount[2] == 0)
            board.Score -= 14;
          if ((int) Evaluation.whitePawnCount[2] >= 1 && (int) Evaluation.whitePawnCount[1] == 0 && (int) Evaluation.whitePawnCount[3] == 0)
            board.Score -= 16;
          if ((int) Evaluation.whitePawnCount[3] >= 1 && (int) Evaluation.whitePawnCount[2] == 0 && (int) Evaluation.whitePawnCount[4] == 0)
            board.Score -= 20;
          if ((int) Evaluation.whitePawnCount[4] >= 1 && (int) Evaluation.whitePawnCount[3] == 0 && (int) Evaluation.whitePawnCount[5] == 0)
            board.Score -= 20;
          if ((int) Evaluation.whitePawnCount[5] >= 1 && (int) Evaluation.whitePawnCount[4] == 0 && (int) Evaluation.whitePawnCount[6] == 0)
            board.Score -= 16;
          if ((int) Evaluation.whitePawnCount[6] >= 1 && (int) Evaluation.whitePawnCount[5] == 0 && (int) Evaluation.whitePawnCount[7] == 0)
            board.Score -= 14;
          if ((int) Evaluation.whitePawnCount[7] >= 1 && (int) Evaluation.whitePawnCount[6] == 0)
            board.Score -= 12;
          if ((int) Evaluation.blackPawnCount[0] >= 1 && (int) Evaluation.whitePawnCount[0] == 0)
            board.Score -= (int) Evaluation.blackPawnCount[0];
          if ((int) Evaluation.blackPawnCount[1] >= 1 && (int) Evaluation.whitePawnCount[1] == 0)
            board.Score -= (int) Evaluation.blackPawnCount[1];
          if ((int) Evaluation.blackPawnCount[2] >= 1 && (int) Evaluation.whitePawnCount[2] == 0)
            board.Score -= (int) Evaluation.blackPawnCount[2];
          if ((int) Evaluation.blackPawnCount[3] >= 1 && (int) Evaluation.whitePawnCount[3] == 0)
            board.Score -= (int) Evaluation.blackPawnCount[3];
          if ((int) Evaluation.blackPawnCount[4] >= 1 && (int) Evaluation.whitePawnCount[4] == 0)
            board.Score -= (int) Evaluation.blackPawnCount[4];
          if ((int) Evaluation.blackPawnCount[5] >= 1 && (int) Evaluation.whitePawnCount[5] == 0)
            board.Score -= (int) Evaluation.blackPawnCount[5];
          if ((int) Evaluation.blackPawnCount[6] >= 1 && (int) Evaluation.whitePawnCount[6] == 0)
            board.Score -= (int) Evaluation.blackPawnCount[6];
          if ((int) Evaluation.blackPawnCount[7] >= 1 && (int) Evaluation.whitePawnCount[7] == 0)
            board.Score -= (int) Evaluation.blackPawnCount[7];
          if ((int) Evaluation.whitePawnCount[0] >= 1 && (int) Evaluation.blackPawnCount[1] == 0)
            board.Score += (int) Evaluation.whitePawnCount[0];
          if ((int) Evaluation.whitePawnCount[1] >= 1 && (int) Evaluation.blackPawnCount[1] == 0)
            board.Score += (int) Evaluation.whitePawnCount[1];
          if ((int) Evaluation.whitePawnCount[2] >= 1 && (int) Evaluation.blackPawnCount[2] == 0)
            board.Score += (int) Evaluation.whitePawnCount[2];
          if ((int) Evaluation.whitePawnCount[3] >= 1 && (int) Evaluation.blackPawnCount[3] == 0)
            board.Score += (int) Evaluation.whitePawnCount[3];
          if ((int) Evaluation.whitePawnCount[4] >= 1 && (int) Evaluation.blackPawnCount[4] == 0)
            board.Score += (int) Evaluation.whitePawnCount[4];
          if ((int) Evaluation.whitePawnCount[5] >= 1 && (int) Evaluation.blackPawnCount[5] == 0)
            board.Score += (int) Evaluation.whitePawnCount[5];
          if ((int) Evaluation.whitePawnCount[6] >= 1 && (int) Evaluation.blackPawnCount[6] == 0)
            board.Score += (int) Evaluation.whitePawnCount[6];
          if ((int) Evaluation.whitePawnCount[7] >= 1 && (int) Evaluation.blackPawnCount[7] == 0)
            board.Score += (int) Evaluation.whitePawnCount[7];
          if ((int) board.EnPassantPosition != 0 || board.EndGamePhase || board.Score == 0)
            return;
          Zobrist.AddEntryEval(board.ZobristHash, board.Score);
        }
      }
    }

    private static int CheckPawnWall(Board board, int pawnPos, int kingPos)
    {
      return kingPos % 8 == 7 && pawnPos % 8 == 0 || kingPos % 8 == 0 && pawnPos % 8 == 7 || (pawnPos > 63 || pawnPos < 0 || (board.Squares[pawnPos].Piece == null || board.Squares[pawnPos].Piece.PieceColor != board.Squares[kingPos].Piece.PieceColor)) || board.Squares[pawnPos].Piece.PieceType != ChessPieceType.Pawn ? 0 : 10;
    }
  }
}
