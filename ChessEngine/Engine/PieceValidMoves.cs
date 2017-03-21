// Decompiled with JetBrains decompiler
// Type: ChessEngine.Engine.PieceValidMoves
// Assembly: ChessEngine, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AD2B565-9B75-423F-BD9A-4B0A934C5249
// Assembly location: C:\Users\Ahmad Elsayed\1\ChessBinNoSetup\ChessBinNoSetup\ChessEngine.dll

using System.Collections.Generic;

namespace ChessEngine.Engine
{
  internal static class PieceValidMoves
  {
    private static void AnalyzeMovePawn(Board board, byte dstPos, Piece pcMoving)
    {
      if ((int) board.EnPassantPosition > 0 && pcMoving.PieceColor != board.EnPassantColor && (int) board.EnPassantPosition == (int) dstPos)
      {
        pcMoving.ValidMoves.Push(dstPos);
        if (pcMoving.PieceColor == ChessPieceColor.White)
          board.WhiteAttackBoard[(int) dstPos] = true;
        else
          board.BlackAttackBoard[(int) dstPos] = true;
      }
      Piece piece = board.Squares[(int) dstPos].Piece;
      if (piece == null)
        return;
      if (pcMoving.PieceColor == ChessPieceColor.White)
      {
        board.WhiteAttackBoard[(int) dstPos] = true;
        if (piece.PieceColor == pcMoving.PieceColor)
        {
          piece.DefendedValue += pcMoving.PieceActionValue;
        }
        else
        {
          piece.AttackedValue += pcMoving.PieceActionValue;
          if (piece.PieceType == ChessPieceType.King)
            board.BlackCheck = true;
          else
            pcMoving.ValidMoves.Push(dstPos);
        }
      }
      else
      {
        board.BlackAttackBoard[(int) dstPos] = true;
        if (piece.PieceColor == pcMoving.PieceColor)
        {
          piece.DefendedValue += pcMoving.PieceActionValue;
        }
        else
        {
          piece.AttackedValue += pcMoving.PieceActionValue;
          if (piece.PieceType == ChessPieceType.King)
            board.WhiteCheck = true;
          else
            pcMoving.ValidMoves.Push(dstPos);
        }
      }
    }

    private static bool AnalyzeMove(Board board, byte dstPos, Piece pcMoving)
    {
      if (pcMoving.PieceColor == ChessPieceColor.White)
        board.WhiteAttackBoard[(int) dstPos] = true;
      else
        board.BlackAttackBoard[(int) dstPos] = true;
      if (board.Squares[(int) dstPos].Piece == null)
      {
        pcMoving.ValidMoves.Push(dstPos);
        return true;
      }
      Piece piece = board.Squares[(int) dstPos].Piece;
      if (piece.PieceColor != pcMoving.PieceColor)
      {
        piece.AttackedValue += pcMoving.PieceActionValue;
        if (piece.PieceType == ChessPieceType.King)
        {
          if (piece.PieceColor == ChessPieceColor.Black)
            board.BlackCheck = true;
          else
            board.WhiteCheck = true;
        }
        else
          pcMoving.ValidMoves.Push(dstPos);
        return false;
      }
      piece.DefendedValue += pcMoving.PieceActionValue;
      return false;
    }

    private static void CheckValidMovesPawn(List<byte> moves, Piece pcMoving, byte srcPosition, Board board, byte count)
    {
      for (byte index = 0; (int) index < (int) count; ++index)
      {
        byte move = moves[(int) index];
        if ((int) move % 8 != (int) srcPosition % 8)
        {
          PieceValidMoves.AnalyzeMovePawn(board, move, pcMoving);
          if (pcMoving.PieceColor == ChessPieceColor.White)
            board.WhiteAttackBoard[(int) move] = true;
          else
            board.BlackAttackBoard[(int) move] = true;
        }
        else
        {
          if (board.Squares[(int) move].Piece != null)
            break;
          pcMoving.ValidMoves.Push(move);
        }
      }
    }

    private static void GenerateValidMovesKing(Piece piece, Board board, byte srcPosition)
    {
      if (piece == null)
        return;
      for (byte index = 0; (int) index < (int) MoveArrays.KingTotalMoves[(int) srcPosition]; ++index)
      {
        byte move = MoveArrays.KingMoves[(int) srcPosition].Moves[(int) index];
        if (piece.PieceColor == ChessPieceColor.White)
        {
          if (board.BlackAttackBoard[(int) move])
          {
            board.WhiteAttackBoard[(int) move] = true;
            continue;
          }
        }
        else if (board.WhiteAttackBoard[(int) move])
        {
          board.BlackAttackBoard[(int) move] = true;
          continue;
        }
        PieceValidMoves.AnalyzeMove(board, move, piece);
      }
    }

    private static void GenerateValidMovesKingCastle(Board board, Piece king)
    {
      if (king.PieceColor == ChessPieceColor.White)
      {
        if (board.Squares[63].Piece != null && board.Squares[63].Piece.PieceType == ChessPieceType.Rook && (board.Squares[63].Piece.PieceColor == king.PieceColor && board.Squares[62].Piece == null) && (board.Squares[61].Piece == null && !board.BlackAttackBoard[61] && !board.BlackAttackBoard[62]))
        {
          king.ValidMoves.Push((byte) 62);
          board.WhiteAttackBoard[62] = true;
        }
        if (board.Squares[56].Piece == null || board.Squares[56].Piece.PieceType != ChessPieceType.Rook || (board.Squares[56].Piece.PieceColor != king.PieceColor || board.Squares[57].Piece != null) || (board.Squares[58].Piece != null || board.Squares[59].Piece != null || (board.BlackAttackBoard[58] || board.BlackAttackBoard[59])))
          return;
        king.ValidMoves.Push((byte) 58);
        board.WhiteAttackBoard[58] = true;
      }
      else
      {
        if (king.PieceColor != ChessPieceColor.Black)
          return;
        if (board.Squares[7].Piece != null && board.Squares[7].Piece.PieceType == ChessPieceType.Rook && (!board.Squares[7].Piece.Moved && board.Squares[7].Piece.PieceColor == king.PieceColor) && (board.Squares[6].Piece == null && board.Squares[5].Piece == null && (!board.WhiteAttackBoard[5] && !board.WhiteAttackBoard[6])))
        {
          king.ValidMoves.Push((byte) 6);
          board.BlackAttackBoard[6] = true;
        }
        if (board.Squares[0].Piece == null || board.Squares[0].Piece.PieceType != ChessPieceType.Rook || (board.Squares[0].Piece.Moved || board.Squares[0].Piece.PieceColor != king.PieceColor) || (board.Squares[1].Piece != null || board.Squares[2].Piece != null || (board.Squares[3].Piece != null || board.WhiteAttackBoard[2])) || board.WhiteAttackBoard[3])
          return;
        king.ValidMoves.Push((byte) 2);
        board.BlackAttackBoard[2] = true;
      }
    }

    internal static void GenerateValidMoves(Board board)
    {
      board.BlackCheck = false;
      board.WhiteCheck = false;
      byte num1 = 0;
      byte num2 = 0;
      int num3 = 0;
      for (byte srcPosition = 0; (int) srcPosition < 64; ++srcPosition)
      {
        Square square = board.Squares[(int) srcPosition];
        if (square.Piece != null)
        {
          square.Piece.ValidMoves = new Stack<byte>(square.Piece.LastValidMoveCount);
          ++num3;
          switch (square.Piece.PieceType)
          {
            case ChessPieceType.King:
              if (square.Piece.PieceColor == ChessPieceColor.White)
              {
                if (square.Piece.Moved)
                  board.WhiteCanCastle = false;
                board.WhiteKingPosition = srcPosition;
                continue;
              }
              if (square.Piece.Moved)
                board.BlackCanCastle = false;
              board.BlackKingPosition = srcPosition;
              continue;
            case ChessPieceType.Queen:
              byte num4 = 0;
              while ((int) num4 < (int) MoveArrays.QueenTotalMoves1[(int) srcPosition] && PieceValidMoves.AnalyzeMove(board, MoveArrays.QueenMoves1[(int) srcPosition].Moves[(int) num4], square.Piece))
                ++num4;
              byte num5 = 0;
              while ((int) num5 < (int) MoveArrays.QueenTotalMoves2[(int) srcPosition] && PieceValidMoves.AnalyzeMove(board, MoveArrays.QueenMoves2[(int) srcPosition].Moves[(int) num5], square.Piece))
                ++num5;
              byte num6 = 0;
              while ((int) num6 < (int) MoveArrays.QueenTotalMoves3[(int) srcPosition] && PieceValidMoves.AnalyzeMove(board, MoveArrays.QueenMoves3[(int) srcPosition].Moves[(int) num6], square.Piece))
                ++num6;
              byte num7 = 0;
              while ((int) num7 < (int) MoveArrays.QueenTotalMoves4[(int) srcPosition] && PieceValidMoves.AnalyzeMove(board, MoveArrays.QueenMoves4[(int) srcPosition].Moves[(int) num7], square.Piece))
                ++num7;
              byte num8 = 0;
              while ((int) num8 < (int) MoveArrays.QueenTotalMoves5[(int) srcPosition] && PieceValidMoves.AnalyzeMove(board, MoveArrays.QueenMoves5[(int) srcPosition].Moves[(int) num8], square.Piece))
                ++num8;
              byte num9 = 0;
              while ((int) num9 < (int) MoveArrays.QueenTotalMoves6[(int) srcPosition] && PieceValidMoves.AnalyzeMove(board, MoveArrays.QueenMoves6[(int) srcPosition].Moves[(int) num9], square.Piece))
                ++num9;
              byte num10 = 0;
              while ((int) num10 < (int) MoveArrays.QueenTotalMoves7[(int) srcPosition] && PieceValidMoves.AnalyzeMove(board, MoveArrays.QueenMoves7[(int) srcPosition].Moves[(int) num10], square.Piece))
                ++num10;
              byte num11 = 0;
              while ((int) num11 < (int) MoveArrays.QueenTotalMoves8[(int) srcPosition] && PieceValidMoves.AnalyzeMove(board, MoveArrays.QueenMoves8[(int) srcPosition].Moves[(int) num11], square.Piece))
                ++num11;
              continue;
            case ChessPieceType.Rook:
              if (square.Piece.Moved)
              {
                if (square.Piece.PieceColor == ChessPieceColor.Black)
                  ++num1;
                else
                  ++num2;
              }
              byte num12 = 0;
              while ((int) num12 < (int) MoveArrays.RookTotalMoves1[(int) srcPosition] && PieceValidMoves.AnalyzeMove(board, MoveArrays.RookMoves1[(int) srcPosition].Moves[(int) num12], square.Piece))
                ++num12;
              byte num13 = 0;
              while ((int) num13 < (int) MoveArrays.RookTotalMoves2[(int) srcPosition] && PieceValidMoves.AnalyzeMove(board, MoveArrays.RookMoves2[(int) srcPosition].Moves[(int) num13], square.Piece))
                ++num13;
              byte num14 = 0;
              while ((int) num14 < (int) MoveArrays.RookTotalMoves3[(int) srcPosition] && PieceValidMoves.AnalyzeMove(board, MoveArrays.RookMoves3[(int) srcPosition].Moves[(int) num14], square.Piece))
                ++num14;
              byte num15 = 0;
              while ((int) num15 < (int) MoveArrays.RookTotalMoves4[(int) srcPosition] && PieceValidMoves.AnalyzeMove(board, MoveArrays.RookMoves4[(int) srcPosition].Moves[(int) num15], square.Piece))
                ++num15;
              continue;
            case ChessPieceType.Bishop:
              byte num16 = 0;
              while ((int) num16 < (int) MoveArrays.BishopTotalMoves1[(int) srcPosition] && PieceValidMoves.AnalyzeMove(board, MoveArrays.BishopMoves1[(int) srcPosition].Moves[(int) num16], square.Piece))
                ++num16;
              byte num17 = 0;
              while ((int) num17 < (int) MoveArrays.BishopTotalMoves2[(int) srcPosition] && PieceValidMoves.AnalyzeMove(board, MoveArrays.BishopMoves2[(int) srcPosition].Moves[(int) num17], square.Piece))
                ++num17;
              byte num18 = 0;
              while ((int) num18 < (int) MoveArrays.BishopTotalMoves3[(int) srcPosition] && PieceValidMoves.AnalyzeMove(board, MoveArrays.BishopMoves3[(int) srcPosition].Moves[(int) num18], square.Piece))
                ++num18;
              byte num19 = 0;
              while ((int) num19 < (int) MoveArrays.BishopTotalMoves4[(int) srcPosition] && PieceValidMoves.AnalyzeMove(board, MoveArrays.BishopMoves4[(int) srcPosition].Moves[(int) num19], square.Piece))
                ++num19;
              continue;
            case ChessPieceType.Knight:
              for (byte index = 0; (int) index < (int) MoveArrays.KnightTotalMoves[(int) srcPosition]; ++index)
                PieceValidMoves.AnalyzeMove(board, MoveArrays.KnightMoves[(int) srcPosition].Moves[(int) index], square.Piece);
              continue;
            case ChessPieceType.Pawn:
              if (square.Piece.PieceColor == ChessPieceColor.White)
              {
                PieceValidMoves.CheckValidMovesPawn(MoveArrays.WhitePawnMoves[(int) srcPosition].Moves, square.Piece, srcPosition, board, MoveArrays.WhitePawnTotalMoves[(int) srcPosition]);
                continue;
              }
              if (square.Piece.PieceColor == ChessPieceColor.Black)
              {
                PieceValidMoves.CheckValidMovesPawn(MoveArrays.BlackPawnMoves[(int) srcPosition].Moves, square.Piece, srcPosition, board, MoveArrays.BlackPawnTotalMoves[(int) srcPosition]);
                continue;
              }
              continue;
            default:
              continue;
          }
        }
      }
      if ((int) num1 > 1)
        board.BlackCanCastle = false;
      if ((int) num2 > 1)
        board.WhiteCanCastle = false;
      if (num3 < 10)
        board.EndGamePhase = true;
      if (board.WhoseMove == ChessPieceColor.White)
      {
        PieceValidMoves.GenerateValidMovesKing(board.Squares[(int) board.BlackKingPosition].Piece, board, board.BlackKingPosition);
        PieceValidMoves.GenerateValidMovesKing(board.Squares[(int) board.WhiteKingPosition].Piece, board, board.WhiteKingPosition);
      }
      else
      {
        PieceValidMoves.GenerateValidMovesKing(board.Squares[(int) board.WhiteKingPosition].Piece, board, board.WhiteKingPosition);
        PieceValidMoves.GenerateValidMovesKing(board.Squares[(int) board.BlackKingPosition].Piece, board, board.BlackKingPosition);
      }
      if (!board.WhiteCastled && board.WhiteCanCastle && !board.WhiteCheck)
        PieceValidMoves.GenerateValidMovesKingCastle(board, board.Squares[(int) board.WhiteKingPosition].Piece);
      if (board.BlackCastled || !board.BlackCanCastle || board.BlackCheck)
        return;
      PieceValidMoves.GenerateValidMovesKingCastle(board, board.Squares[(int) board.BlackKingPosition].Piece);
    }
  }
}
