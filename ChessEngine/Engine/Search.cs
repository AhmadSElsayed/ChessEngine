// Decompiled with JetBrains decompiler
// Type: ChessEngine.Engine.Search
// Assembly: ChessEngine, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AD2B565-9B75-423F-BD9A-4B0A934C5249
// Assembly location: C:\Users\Ahmad Elsayed\1\ChessBinNoSetup\ChessBinNoSetup\ChessEngine.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ChessEngine.Engine
{
  internal static class Search
  {
    private static readonly Search.Position[,] KillerMove = new Search.Position[3, 20];
    private static int piecesRemaining;
    private static int kIndex;

    private static int Sort(Search.Position s2, Search.Position s1)
    {
      return s1.Score.CompareTo(s2.Score);
    }

    private static int Sort(Board s2, Board s1)
    {
      return s1.Score.CompareTo(s2.Score);
    }

    private static int SideToMoveScore(int score, ChessPieceColor color)
    {
      if (color == ChessPieceColor.Black)
        return -score;
      return score;
    }

    internal static MoveContent IterativeSearchOld(Board examineBoard, ChessEngine.Engine.Engine.TimeSettings gameTimeSettings, ref int nodesSearched, ref int nodesQuiessence, ref string pvLine, BackgroundWorker worker, ref byte plyDepthReached, ref byte rootMovesSearched, List<OpeningMove> currentGameBook)
    {
      Zobrist.MarkAncient();
      MoveContent moveContent1 = new MoveContent();
      MoveContent moveContent2 = new MoveContent();
      string str1 = "";
      List<Search.Position> positionList1 = new List<Search.Position>();
      ResultBoards sortValidMoves = Search.GetSortValidMoves(examineBoard);
      rootMovesSearched = (byte) sortValidMoves.Positions.Count;
      int num1 = 30;
      int num2 = 40;
      byte depth = 1;
      if (gameTimeSettings == ChessEngine.Engine.Engine.TimeSettings.Moves40In10Minutes)
        num1 = 15;
      else if (gameTimeSettings == ChessEngine.Engine.Engine.TimeSettings.Moves40In20Minutes)
        num1 = 30;
      else if (gameTimeSettings == ChessEngine.Engine.Engine.TimeSettings.Moves40In30Minutes)
        num1 = 45;
      else if (gameTimeSettings == ChessEngine.Engine.Engine.TimeSettings.Moves40In40Minutes)
        num1 = 60;
      else if (gameTimeSettings == ChessEngine.Engine.Engine.TimeSettings.Moves40In60Minutes)
        num1 = 90;
      else if (gameTimeSettings == ChessEngine.Engine.Engine.TimeSettings.Moves40In90Minutes)
        num1 = 135;
      DateTime now = DateTime.Now;
      do
      {
        pvLine = "";
        int num3 = -400000000;
        sortValidMoves.Positions.Sort(new Comparison<Board>(Search.Sort));
        foreach (Board position1 in sortValidMoves.Positions)
        {
          if (DateTime.Now - now > TimeSpan.FromSeconds((double) num1))
          {
            pvLine = str1;
            return moveContent2;
          }
          if (worker != null)
            worker.ReportProgress((int) ((DateTime.Now - now).TotalSeconds / (double) num1 * 100.0));
          List<Search.Position> pvLine1 = new List<Search.Position>();
          int num4 = -Search.AlphaBeta(position1, depth, -400000000, -num3, ref nodesSearched, ref nodesQuiessence, ref pvLine1, true);
          if (num4 >= (int) short.MaxValue)
          {
            pvLine = str1;
            return position1.LastMove;
          }
          if ((int) examineBoard.RepeatedMove == 2)
          {
            string str2 = Board.Fen(true, position1);
            foreach (OpeningMove openingMove in currentGameBook)
            {
              if (openingMove.EndingFEN == str2)
              {
                num4 = 0;
                break;
              }
            }
          }
          position1.Score = num4;
          if (num4 > num3)
          {
            List<Search.Position> positionList2 = new List<Search.Position>();
            pvLine = position1.LastMove.ToString();
            foreach (Search.Position position2 in pvLine1)
            {
              pvLine = pvLine + " " + position2.ToString();
              positionList2.Add(position2);
            }
            positionList2.Reverse();
            num3 = num4;
            moveContent1 = position1.LastMove;
          }
        }
        moveContent2 = moveContent1;
        str1 = pvLine;
        plyDepthReached = depth;
        ++depth;
      }
      while (DateTime.Now - now < TimeSpan.FromSeconds((double) num1) && (int) plyDepthReached < 19);
      plyDepthReached = (byte) ((uint) plyDepthReached + 1U);
      int num5 = num2 != 1 ? num2 - 1 : 40;
      return moveContent2;
    }

    internal static MoveContent IterativeSearch(Board examineBoard, byte depth, ref int nodesSearched, ref int nodesQuiessence, ref string pvLine, BackgroundWorker worker, ref byte plyDepthReached, ref byte rootMovesSearched, List<OpeningMove> currentGameBook)
    {
      List<Search.Position> pvLine1 = new List<Search.Position>();
      int num1 = -400000000;
      Zobrist.MarkAncient();
      MoveContent moveContent = new MoveContent();
      ResultBoards sortValidMoves = Search.GetSortValidMoves(examineBoard);
      rootMovesSearched = (byte) sortValidMoves.Positions.Count;
      if ((int) rootMovesSearched == 1)
        return sortValidMoves.Positions[0].LastMove;
      foreach (Board position in sortValidMoves.Positions)
      {
        if (-Search.AlphaBeta(position, (byte) 1, -400000000, -num1, ref nodesSearched, ref nodesQuiessence, ref pvLine1, true) >= (int) short.MaxValue)
          return position.LastMove;
      }
      int num2 = 0;
      int num3 = -400000000;
      sortValidMoves.Positions.Sort(new Comparison<Board>(Search.Sort));
      --depth;
      plyDepthReached = Search.ModifyDepth(depth, sortValidMoves.Positions.Count);
      foreach (Board position1 in sortValidMoves.Positions)
      {
        ++num2;
        if (worker != null)
          worker.ReportProgress((int) ((Decimal) num2 / (Decimal) sortValidMoves.Positions.Count * new Decimal(100)));
        List<Search.Position> pvLine2 = new List<Search.Position>();
        int num4 = -Search.AlphaBeta(position1, depth, -400000000, -num3, ref nodesSearched, ref nodesQuiessence, ref pvLine2, false);
        if (num4 >= (int) short.MaxValue)
          return position1.LastMove;
        if ((int) examineBoard.RepeatedMove == 2)
        {
          string str = Board.Fen(true, position1);
          foreach (OpeningMove openingMove in currentGameBook)
          {
            if (openingMove.EndingFEN == str)
            {
              num4 = 0;
              break;
            }
          }
        }
        position1.Score = num4;
        if (num4 > num3 || num3 == -400000000)
        {
          pvLine = position1.LastMove.ToString();
          foreach (Search.Position position2 in pvLine2)
            pvLine = pvLine + " " + position2.ToString();
          num3 = num4;
          moveContent = position1.LastMove;
        }
      }
      plyDepthReached = (byte) ((uint) plyDepthReached + 1U);
      return moveContent;
    }

    private static ResultBoards GetSortValidMoves(Board examineBoard)
    {
      ResultBoards resultBoards = new ResultBoards()
      {
        Positions = new List<Board>(30)
      };
      Search.piecesRemaining = 0;
      for (byte srcPosition = 0; (int) srcPosition < 64; ++srcPosition)
      {
        Square square = examineBoard.Squares[(int) srcPosition];
        if (square.Piece != null)
        {
          ++Search.piecesRemaining;
          if (square.Piece.PieceColor == examineBoard.WhoseMove)
          {
            foreach (byte validMove in square.Piece.ValidMoves)
            {
              Board board = examineBoard.FastCopy();
              Board.MovePiece(board, srcPosition, validMove, ChessPieceType.Queen);
              PieceValidMoves.GenerateValidMoves(board);
              if ((!board.WhiteCheck || examineBoard.WhoseMove != ChessPieceColor.White) && (!board.BlackCheck || examineBoard.WhoseMove != ChessPieceColor.Black))
              {
                Evaluation.EvaluateBoardScore(board);
                board.Score = Search.SideToMoveScore(board.Score, board.WhoseMove);
                resultBoards.Positions.Add(board);
              }
            }
          }
        }
      }
      resultBoards.Positions.Sort(new Comparison<Board>(Search.Sort));
      return resultBoards;
    }

    private static int AlphaBeta(Board examineBoard, byte depth, int alpha, int beta, ref int nodesSearched, ref int nodesQuiessence, ref List<Search.Position> pvLine, bool extended)
    {
      nodesSearched = nodesSearched + 1;
      if ((int) examineBoard.FiftyMove >= 50 || (int) examineBoard.RepeatedMove >= 3)
        return 0;
      int? nullable1 = Zobrist.Search(examineBoard.ZobristHash, depth, alpha, beta);
      if (nullable1.HasValue)
        return nullable1.Value;
      if ((int) depth == 0)
      {
        if (!extended && examineBoard.BlackCheck || examineBoard.WhiteCheck)
        {
          ++depth;
          extended = true;
        }
        else
        {
          int score = Search.Quiescence(examineBoard, alpha, beta, ref nodesQuiessence);
          if (score >= beta)
            Zobrist.AddEntry(examineBoard.ZobristHash, depth, score, Zobrist.NodeType.Beta);
          else if (score <= alpha)
            Zobrist.AddEntry(examineBoard.ZobristHash, depth, score, Zobrist.NodeType.Alpha);
          else
            Zobrist.AddEntry(examineBoard.ZobristHash, depth, score, Zobrist.NodeType.Exact);
          return score;
        }
      }
      Zobrist.NodeType nodeType = Zobrist.NodeType.Alpha;
      List<Search.Position> moves = Search.EvaluateMoves(examineBoard, depth);
      if ((examineBoard.WhiteCheck || examineBoard.BlackCheck || moves.Count == 0) && Search.SearchForMate(examineBoard.WhoseMove, examineBoard, ref examineBoard.BlackMate, ref examineBoard.WhiteMate, ref examineBoard.StaleMate))
      {
        if (examineBoard.BlackMate)
        {
          if (examineBoard.WhoseMove == ChessPieceColor.Black)
            return -32767 - (int) depth;
          return (int) short.MaxValue + (int) depth;
        }
        if (!examineBoard.WhiteMate)
          return 0;
        if (examineBoard.WhoseMove == ChessPieceColor.Black)
          return (int) short.MaxValue + (int) depth;
        return -32767 - (int) depth;
      }
      moves.Sort(new Comparison<Search.Position>(Search.Sort));
      foreach (Search.Position position in moves)
      {
        List<Search.Position> pvLine1 = new List<Search.Position>();
        Board board = examineBoard.FastCopy();
        Board.MovePiece(board, position.SrcPosition, position.DstPosition, ChessPieceType.Queen);
        PieceValidMoves.GenerateValidMoves(board);
        if ((!board.BlackCheck || examineBoard.WhoseMove != ChessPieceColor.Black) && (!board.WhiteCheck || examineBoard.WhoseMove != ChessPieceColor.White))
        {
          int? nullable2 = new int?(-Search.AlphaBeta(board, (byte) ((uint) depth - 1U), -beta, -alpha, ref nodesSearched, ref nodesQuiessence, ref pvLine1, extended));
          int? nullable3 = nullable2;
          int num1 = beta;
          if ((nullable3.GetValueOrDefault() >= num1 ? (nullable3.HasValue ? 1 : 0) : 0) != 0)
          {
            Search.KillerMove[Search.kIndex, (int) depth].SrcPosition = position.SrcPosition;
            Search.KillerMove[Search.kIndex, (int) depth].DstPosition = position.DstPosition;
            Search.kIndex = (Search.kIndex + 1) % 2;
            Zobrist.AddEntry(examineBoard.ZobristHash, depth, nullable2.Value, Zobrist.NodeType.Beta);
            return beta;
          }
          nullable3 = nullable2;
          int num2 = alpha;
          if ((nullable3.GetValueOrDefault() > num2 ? (nullable3.HasValue ? 1 : 0) : 0) != 0)
          {
            pvLine1.Insert(0, new Search.Position()
            {
              SrcPosition = board.LastMove.MovingPiecePrimary.SrcPosition,
              DstPosition = board.LastMove.MovingPiecePrimary.DstPosition,
              Move = board.LastMove.ToString()
            });
            pvLine = pvLine1;
            alpha = nullable2.Value;
            nodeType = Zobrist.NodeType.Exact;
          }
        }
      }
      Zobrist.AddEntry(examineBoard.ZobristHash, depth, alpha, nodeType);
      return alpha;
    }

    private static int Quiescence(Board examineBoard, int alpha, int beta, ref int nodesSearched)
    {
      nodesSearched = nodesSearched + 1;
      Evaluation.EvaluateBoardScore(examineBoard);
      examineBoard.Score = Search.SideToMoveScore(examineBoard.Score, examineBoard.WhoseMove);
      if (examineBoard.Score >= beta)
        return beta;
      if (examineBoard.Score > alpha)
        alpha = examineBoard.Score;
      List<Search.Position> positionList = examineBoard.WhiteCheck || examineBoard.BlackCheck ? Search.EvaluateMoves(examineBoard, (byte) 0) : Search.EvaluateMovesQ(examineBoard);
      if (positionList.Count == 0)
        return examineBoard.Score;
      positionList.Sort(new Comparison<Search.Position>(Search.Sort));
      foreach (Search.Position position in positionList)
      {
        if (Search.StaticExchangeEvaluation(examineBoard.Squares[(int) position.DstPosition]) < 0)
        {
          Board board = examineBoard.FastCopy();
          Board.MovePiece(board, position.SrcPosition, position.DstPosition, ChessPieceType.Queen);
          PieceValidMoves.GenerateValidMoves(board);
          if ((!board.BlackCheck || examineBoard.WhoseMove != ChessPieceColor.Black) && (!board.WhiteCheck || examineBoard.WhoseMove != ChessPieceColor.White))
          {
            int num = -Search.Quiescence(board, -beta, -alpha, ref nodesSearched);
            if (num >= beta)
            {
              Search.KillerMove[2, 0].SrcPosition = position.SrcPosition;
              Search.KillerMove[2, 0].DstPosition = position.DstPosition;
              return beta;
            }
            if (num > alpha)
              alpha = num;
          }
        }
      }
      return alpha;
    }

    private static List<Search.Position> EvaluateMoves(Board examineBoard, byte depth)
    {
      List<Search.Position> positionList = new List<Search.Position>();
      for (byte index = 0; (int) index < 64; ++index)
      {
        Piece piece1 = examineBoard.Squares[(int) index].Piece;
        if (piece1 != null && piece1.PieceColor == examineBoard.WhoseMove)
        {
          foreach (byte validMove in piece1.ValidMoves)
          {
            Search.Position position = new Search.Position();
            position.SrcPosition = index;
            position.DstPosition = validMove;
            if ((int) position.SrcPosition == (int) Search.KillerMove[0, (int) depth].SrcPosition && (int) position.DstPosition == (int) Search.KillerMove[0, (int) depth].DstPosition)
            {
              position.Score += 5000;
              positionList.Add(position);
            }
            else if ((int) position.SrcPosition == (int) Search.KillerMove[1, (int) depth].SrcPosition && (int) position.DstPosition == (int) Search.KillerMove[1, (int) depth].DstPosition)
            {
              position.Score += 5000;
              positionList.Add(position);
            }
            else
            {
              Piece piece2 = examineBoard.Squares[(int) position.DstPosition].Piece;
              if (piece2 != null)
              {
                position.Score += (int) piece2.PieceValue;
                if ((int) piece1.PieceValue < (int) piece2.PieceValue)
                  position.Score += (int) piece2.PieceValue - (int) piece1.PieceValue;
              }
              if (!piece1.Moved)
                position.Score += 10;
              position.Score += (int) piece1.PieceActionValue;
              if (!examineBoard.WhiteCastled && examineBoard.WhoseMove == ChessPieceColor.White)
              {
                if (piece1.PieceType == ChessPieceType.King)
                {
                  if ((int) position.DstPosition != 62 && (int) position.DstPosition != 58)
                    position.Score -= 40;
                  else
                    position.Score += 40;
                }
                if (piece1.PieceType == ChessPieceType.Rook)
                  position.Score -= 40;
              }
              if (!examineBoard.BlackCastled && examineBoard.WhoseMove == ChessPieceColor.Black)
              {
                if (piece1.PieceType == ChessPieceType.King)
                {
                  if ((int) position.DstPosition != 6 && (int) position.DstPosition != 2)
                    position.Score -= 40;
                  else
                    position.Score += 40;
                }
                if (piece1.PieceType == ChessPieceType.Rook)
                  position.Score -= 40;
              }
              positionList.Add(position);
            }
          }
        }
      }
      return positionList;
    }

    private static List<Search.Position> EvaluateMovesQ(Board examineBoard)
    {
      List<Search.Position> positionList = new List<Search.Position>();
      for (byte index = 0; (int) index < 64; ++index)
      {
        Piece piece1 = examineBoard.Squares[(int) index].Piece;
        if (piece1 != null && piece1.PieceColor == examineBoard.WhoseMove)
        {
          foreach (byte validMove in piece1.ValidMoves)
          {
            if (examineBoard.Squares[(int) validMove].Piece != null)
            {
              Search.Position position = new Search.Position();
              position.SrcPosition = index;
              position.DstPosition = validMove;
              if ((int) position.SrcPosition == (int) Search.KillerMove[2, 0].SrcPosition && (int) position.DstPosition == (int) Search.KillerMove[2, 0].DstPosition)
              {
                position.Score += 5000;
                positionList.Add(position);
              }
              else
              {
                Piece piece2 = examineBoard.Squares[(int) position.DstPosition].Piece;
                position.Score += (int) piece2.PieceValue;
                if ((int) piece1.PieceValue < (int) piece2.PieceValue)
                  position.Score += (int) piece2.PieceValue - (int) piece1.PieceValue;
                position.Score += (int) piece1.PieceActionValue;
                positionList.Add(position);
              }
            }
          }
        }
      }
      return positionList;
    }

    internal static bool SearchForMate(ChessPieceColor movingSide, Board examineBoard, ref bool blackMate, ref bool whiteMate, ref bool staleMate)
    {
      bool flag1 = false;
      bool flag2 = false;
      for (byte srcPosition = 0; (int) srcPosition < 64; ++srcPosition)
      {
        Square square = examineBoard.Squares[(int) srcPosition];
        if (square.Piece != null && square.Piece.PieceColor == movingSide)
        {
          foreach (byte validMove in square.Piece.ValidMoves)
          {
            Board board = examineBoard.FastCopy();
            Board.MovePiece(board, srcPosition, validMove, ChessPieceType.Queen);
            PieceValidMoves.GenerateValidMoves(board);
            if (!board.BlackCheck)
              flag1 = true;
            else if (movingSide == ChessPieceColor.Black)
              continue;
            if (!board.WhiteCheck)
              flag2 = true;
          }
        }
      }
      if (!flag1)
      {
        if (examineBoard.BlackCheck)
        {
          blackMate = true;
          return true;
        }
        if (!examineBoard.WhiteMate && movingSide != ChessPieceColor.White)
        {
          staleMate = true;
          return true;
        }
      }
      if (!flag2)
      {
        if (examineBoard.WhiteCheck)
        {
          whiteMate = true;
          return true;
        }
        if (!examineBoard.BlackMate && movingSide != ChessPieceColor.Black)
        {
          staleMate = true;
          return true;
        }
      }
      return false;
    }

    private static byte ModifyDepth(byte depth, int possibleMoves)
    {
      if (possibleMoves <= 20 || Search.piecesRemaining < 14)
      {
        if (possibleMoves <= 10 || Search.piecesRemaining < 6)
          ++depth;
        ++depth;
      }
      return depth;
    }

    private static int StaticExchangeEvaluation(Square examineSquare)
    {
      if (examineSquare.Piece == null || (int) examineSquare.Piece.AttackedValue == 0)
        return 0;
      return (int) examineSquare.Piece.PieceActionValue - (int) examineSquare.Piece.AttackedValue + (int) examineSquare.Piece.DefendedValue;
    }

    private struct Position
    {
      internal byte SrcPosition;
      internal byte DstPosition;
      internal int Score;
      internal string Move;

      public new string ToString()
      {
        return this.Move;
      }
    }
  }
}
