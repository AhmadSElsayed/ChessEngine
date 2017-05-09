// Decompiled with JetBrains decompiler
// Type: ChessEngine.Engine.PieceMoves
// Assembly: ChessEngine, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AD2B565-9B75-423F-BD9A-4B0A934C5249
// Assembly location: C:\Users\Ahmad Elsayed\1\ChessBinNoSetup\ChessBinNoSetup\ChessEngine.dll

using System.Collections.Generic;

namespace ChessEngine.Engine
{
  internal static class PieceMoves
  {
    internal static bool Initiated;

    private static byte Position(byte col, byte row)
    {
      return (byte) ((uint) col + (uint) row * 8U);
    }

    internal static void InitiateChessPieceMotion()
    {
      if (PieceMoves.Initiated)
        return;
      PieceMoves.Initiated = true;
      MoveArrays.WhitePawnMoves = new PieceMoveSet[64];
      MoveArrays.WhitePawnTotalMoves = new byte[64];
      MoveArrays.BlackPawnMoves = new PieceMoveSet[64];
      MoveArrays.BlackPawnTotalMoves = new byte[64];
      MoveArrays.KnightMoves = new PieceMoveSet[64];
      MoveArrays.KnightTotalMoves = new byte[64];
      MoveArrays.BishopMoves1 = new PieceMoveSet[64];
      MoveArrays.BishopTotalMoves1 = new byte[64];
      MoveArrays.BishopMoves2 = new PieceMoveSet[64];
      MoveArrays.BishopTotalMoves2 = new byte[64];
      MoveArrays.BishopMoves3 = new PieceMoveSet[64];
      MoveArrays.BishopTotalMoves3 = new byte[64];
      MoveArrays.BishopMoves4 = new PieceMoveSet[64];
      MoveArrays.BishopTotalMoves4 = new byte[64];
      MoveArrays.RookMoves1 = new PieceMoveSet[64];
      MoveArrays.RookTotalMoves1 = new byte[64];
      MoveArrays.RookMoves2 = new PieceMoveSet[64];
      MoveArrays.RookTotalMoves2 = new byte[64];
      MoveArrays.RookMoves3 = new PieceMoveSet[64];
      MoveArrays.RookTotalMoves3 = new byte[64];
      MoveArrays.RookMoves4 = new PieceMoveSet[64];
      MoveArrays.RookTotalMoves4 = new byte[64];
      MoveArrays.QueenMoves1 = new PieceMoveSet[64];
      MoveArrays.QueenTotalMoves1 = new byte[64];
      MoveArrays.QueenMoves2 = new PieceMoveSet[64];
      MoveArrays.QueenTotalMoves2 = new byte[64];
      MoveArrays.QueenMoves3 = new PieceMoveSet[64];
      MoveArrays.QueenTotalMoves3 = new byte[64];
      MoveArrays.QueenMoves4 = new PieceMoveSet[64];
      MoveArrays.QueenTotalMoves4 = new byte[64];
      MoveArrays.QueenMoves5 = new PieceMoveSet[64];
      MoveArrays.QueenTotalMoves5 = new byte[64];
      MoveArrays.QueenMoves6 = new PieceMoveSet[64];
      MoveArrays.QueenTotalMoves6 = new byte[64];
      MoveArrays.QueenMoves7 = new PieceMoveSet[64];
      MoveArrays.QueenTotalMoves7 = new byte[64];
      MoveArrays.QueenMoves8 = new PieceMoveSet[64];
      MoveArrays.QueenTotalMoves8 = new byte[64];
      MoveArrays.KingMoves = new PieceMoveSet[64];
      MoveArrays.KingTotalMoves = new byte[64];
      PieceMoves.SetMovesWhitePawn();
      PieceMoves.SetMovesBlackPawn();
      PieceMoves.SetMovesKnight();
      PieceMoves.SetMovesBishop();
      PieceMoves.SetMovesRook();
      PieceMoves.SetMovesQueen();
      PieceMoves.SetMovesKing();
    }

    private static void SetMovesBlackPawn()
    {
      for (byte index = 8; (int) index <= 55; ++index)
      {
        PieceMoveSet pieceMoveSet = new PieceMoveSet(new List<byte>());
        byte num1 = (byte) ((uint) index % 8U);
        byte num2 = (byte) ((uint) index / 8U);
        if ((int) num2 < 7 && (int) num1 < 7)
        {
          pieceMoveSet.Moves.Add((byte) ((int) index + 8 + 1));
          ++MoveArrays.BlackPawnTotalMoves[(int) index];
        }
        if ((int) num1 > 0 && (int) num2 < 7)
        {
          pieceMoveSet.Moves.Add((byte) ((int) index + 8 - 1));
          ++MoveArrays.BlackPawnTotalMoves[(int) index];
        }
        pieceMoveSet.Moves.Add((byte) ((uint) index + 8U));
        ++MoveArrays.BlackPawnTotalMoves[(int) index];
        if ((int) num2 == 1)
        {
          pieceMoveSet.Moves.Add((byte) ((uint) index + 16U));
          ++MoveArrays.BlackPawnTotalMoves[(int) index];
        }
        MoveArrays.BlackPawnMoves[(int) index] = pieceMoveSet;
      }
    }

    private static void SetMovesWhitePawn()
    {
      for (byte index = 8; (int) index <= 55; ++index)
      {
        int num1 = (int) (byte) ((uint) index % 8U);
        byte num2 = (byte) ((uint) index / 8U);
        PieceMoveSet pieceMoveSet = new PieceMoveSet(new List<byte>());
        int num3 = 7;
        if (num1 < num3 && (int) num2 > 0)
        {
          pieceMoveSet.Moves.Add((byte) ((int) index - 8 + 1));
          ++MoveArrays.WhitePawnTotalMoves[(int) index];
        }
        int num4 = 0;
        if (num1 > num4 && (int) num2 > 0)
        {
          pieceMoveSet.Moves.Add((byte) ((int) index - 8 - 1));
          ++MoveArrays.WhitePawnTotalMoves[(int) index];
        }
        pieceMoveSet.Moves.Add((byte) ((uint) index - 8U));
        ++MoveArrays.WhitePawnTotalMoves[(int) index];
        if ((int) num2 == 6)
        {
          pieceMoveSet.Moves.Add((byte) ((uint) index - 16U));
          ++MoveArrays.WhitePawnTotalMoves[(int) index];
        }
        MoveArrays.WhitePawnMoves[(int) index] = pieceMoveSet;
      }
    }

    private static void SetMovesKnight()
    {
      for (byte index1 = 0; (int) index1 < 8; ++index1)
      {
        for (byte index2 = 0; (int) index2 < 8; ++index2)
        {
          byte num1 = (byte) ((uint) index1 + (uint) index2 * 8U);
          PieceMoveSet pieceMoveSet = new PieceMoveSet(new List<byte>());
          if ((int) index1 < 6 && (int) index2 > 0)
          {
            byte num2 = PieceMoves.Position((byte) ((uint) index1 + 2U), (byte) ((uint) index2 - 1U));
            if ((int) num2 < 64)
            {
              pieceMoveSet.Moves.Add(num2);
              ++MoveArrays.KnightTotalMoves[(int) num1];
            }
          }
          if ((int) index1 > 1 && (int) index2 < 7)
          {
            byte num2 = PieceMoves.Position((byte) ((uint) index1 - 2U), (byte) ((uint) index2 + 1U));
            if ((int) num2 < 64)
            {
              pieceMoveSet.Moves.Add(num2);
              ++MoveArrays.KnightTotalMoves[(int) num1];
            }
          }
          if ((int) index1 > 1 && (int) index2 > 0)
          {
            byte num2 = PieceMoves.Position((byte) ((uint) index1 - 2U), (byte) ((uint) index2 - 1U));
            if ((int) num2 < 64)
            {
              pieceMoveSet.Moves.Add(num2);
              ++MoveArrays.KnightTotalMoves[(int) num1];
            }
          }
          if ((int) index1 < 6 && (int) index2 < 7)
          {
            byte num2 = PieceMoves.Position((byte) ((uint) index1 + 2U), (byte) ((uint) index2 + 1U));
            if ((int) num2 < 64)
            {
              pieceMoveSet.Moves.Add(num2);
              ++MoveArrays.KnightTotalMoves[(int) num1];
            }
          }
          if ((int) index1 > 0 && (int) index2 < 6)
          {
            byte num2 = PieceMoves.Position((byte) ((uint) index1 - 1U), (byte) ((uint) index2 + 2U));
            if ((int) num2 < 64)
            {
              pieceMoveSet.Moves.Add(num2);
              ++MoveArrays.KnightTotalMoves[(int) num1];
            }
          }
          if ((int) index1 < 7 && (int) index2 > 1)
          {
            byte num2 = PieceMoves.Position((byte) ((uint) index1 + 1U), (byte) ((uint) index2 - 2U));
            if ((int) num2 < 64)
            {
              pieceMoveSet.Moves.Add(num2);
              ++MoveArrays.KnightTotalMoves[(int) num1];
            }
          }
          if ((int) index1 > 0 && (int) index2 > 1)
          {
            byte num2 = PieceMoves.Position((byte) ((uint) index1 - 1U), (byte) ((uint) index2 - 2U));
            if ((int) num2 < 64)
            {
              pieceMoveSet.Moves.Add(num2);
              ++MoveArrays.KnightTotalMoves[(int) num1];
            }
          }
          if ((int) index1 < 7 && (int) index2 < 6)
          {
            byte num2 = PieceMoves.Position((byte) ((uint) index1 + 1U), (byte) ((uint) index2 + 2U));
            if ((int) num2 < 64)
            {
              pieceMoveSet.Moves.Add(num2);
              ++MoveArrays.KnightTotalMoves[(int) num1];
            }
          }
          MoveArrays.KnightMoves[(int) num1] = pieceMoveSet;
        }
      }
    }

    private static void SetMovesBishop()
    {
      for (byte index1 = 0; (int) index1 < 8; ++index1)
      {
        for (byte index2 = 0; (int) index2 < 8; ++index2)
        {
          byte num1 = (byte) ((uint) index1 + (uint) index2 * 8U);
          PieceMoveSet pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte row1 = index2;
          byte col1 = index1;
          while ((int) row1 < 7 && (int) col1 < 7)
          {
            ++row1;
            ++col1;
            byte num2 = PieceMoves.Position(col1, row1);
            pieceMoveSet.Moves.Add(num2);
            ++MoveArrays.BishopTotalMoves1[(int) num1];
          }
          MoveArrays.BishopMoves1[(int) num1] = pieceMoveSet;
          pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte row2 = index2;
          byte col2 = index1;
          while ((int) row2 < 7 && (int) col2 > 0)
          {
            ++row2;
            --col2;
            byte num2 = PieceMoves.Position(col2, row2);
            pieceMoveSet.Moves.Add(num2);
            ++MoveArrays.BishopTotalMoves2[(int) num1];
          }
          MoveArrays.BishopMoves2[(int) num1] = pieceMoveSet;
          pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte row3 = index2;
          byte col3 = index1;
          while ((int) row3 > 0 && (int) col3 < 7)
          {
            --row3;
            ++col3;
            byte num2 = PieceMoves.Position(col3, row3);
            pieceMoveSet.Moves.Add(num2);
            ++MoveArrays.BishopTotalMoves3[(int) num1];
          }
          MoveArrays.BishopMoves3[(int) num1] = pieceMoveSet;
          pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte row4 = index2;
          byte col4 = index1;
          while ((int) row4 > 0 && (int) col4 > 0)
          {
            --row4;
            --col4;
            byte num2 = PieceMoves.Position(col4, row4);
            pieceMoveSet.Moves.Add(num2);
            ++MoveArrays.BishopTotalMoves4[(int) num1];
          }
          MoveArrays.BishopMoves4[(int) num1] = pieceMoveSet;
        }
      }
    }

    private static void SetMovesRook()
    {
      for (byte index1 = 0; (int) index1 < 8; ++index1)
      {
        for (byte index2 = 0; (int) index2 < 8; ++index2)
        {
          byte num1 = (byte) ((uint) index1 + (uint) index2 * 8U);
          PieceMoveSet pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte row1 = index2;
          byte col1 = index1;
          while ((int) row1 < 7)
          {
            ++row1;
            byte num2 = PieceMoves.Position(col1, row1);
            pieceMoveSet.Moves.Add(num2);
            ++MoveArrays.RookTotalMoves1[(int) num1];
          }
          MoveArrays.RookMoves1[(int) num1] = pieceMoveSet;
          pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte row2 = index2;
          byte col2 = index1;
          while ((int) row2 > 0)
          {
            --row2;
            byte num2 = PieceMoves.Position(col2, row2);
            pieceMoveSet.Moves.Add(num2);
            ++MoveArrays.RookTotalMoves2[(int) num1];
          }
          MoveArrays.RookMoves2[(int) num1] = pieceMoveSet;
          pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte row3 = index2;
          byte col3 = index1;
          while ((int) col3 > 0)
          {
            --col3;
            byte num2 = PieceMoves.Position(col3, row3);
            pieceMoveSet.Moves.Add(num2);
            ++MoveArrays.RookTotalMoves3[(int) num1];
          }
          MoveArrays.RookMoves3[(int) num1] = pieceMoveSet;
          pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte row4 = index2;
          byte col4 = index1;
          while ((int) col4 < 7)
          {
            ++col4;
            byte num2 = PieceMoves.Position(col4, row4);
            pieceMoveSet.Moves.Add(num2);
            ++MoveArrays.RookTotalMoves4[(int) num1];
          }
          MoveArrays.RookMoves4[(int) num1] = pieceMoveSet;
        }
      }
    }

    private static void SetMovesQueen()
    {
      for (byte index1 = 0; (int) index1 < 8; ++index1)
      {
        for (byte index2 = 0; (int) index2 < 8; ++index2)
        {
          byte num1 = (byte) ((uint) index1 + (uint) index2 * 8U);
          PieceMoveSet pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte row1 = index2;
          byte col1 = index1;
          while ((int) row1 < 7)
          {
            ++row1;
            byte num2 = PieceMoves.Position(col1, row1);
            pieceMoveSet.Moves.Add(num2);
            ++MoveArrays.QueenTotalMoves1[(int) num1];
          }
          MoveArrays.QueenMoves1[(int) num1] = pieceMoveSet;
          pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte row2 = index2;
          byte col2 = index1;
          while ((int) row2 > 0)
          {
            --row2;
            byte num2 = PieceMoves.Position(col2, row2);
            pieceMoveSet.Moves.Add(num2);
            ++MoveArrays.QueenTotalMoves2[(int) num1];
          }
          MoveArrays.QueenMoves2[(int) num1] = pieceMoveSet;
          pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte row3 = index2;
          byte col3 = index1;
          while ((int) col3 > 0)
          {
            --col3;
            byte num2 = PieceMoves.Position(col3, row3);
            pieceMoveSet.Moves.Add(num2);
            ++MoveArrays.QueenTotalMoves3[(int) num1];
          }
          MoveArrays.QueenMoves3[(int) num1] = pieceMoveSet;
          pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte row4 = index2;
          byte col4 = index1;
          while ((int) col4 < 7)
          {
            ++col4;
            byte num2 = PieceMoves.Position(col4, row4);
            pieceMoveSet.Moves.Add(num2);
            ++MoveArrays.QueenTotalMoves4[(int) num1];
          }
          MoveArrays.QueenMoves4[(int) num1] = pieceMoveSet;
          pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte row5 = index2;
          byte col5 = index1;
          while ((int) row5 < 7 && (int) col5 < 7)
          {
            ++row5;
            ++col5;
            byte num2 = PieceMoves.Position(col5, row5);
            pieceMoveSet.Moves.Add(num2);
            ++MoveArrays.QueenTotalMoves5[(int) num1];
          }
          MoveArrays.QueenMoves5[(int) num1] = pieceMoveSet;
          pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte row6 = index2;
          byte col6 = index1;
          while ((int) row6 < 7 && (int) col6 > 0)
          {
            ++row6;
            --col6;
            byte num2 = PieceMoves.Position(col6, row6);
            pieceMoveSet.Moves.Add(num2);
            ++MoveArrays.QueenTotalMoves6[(int) num1];
          }
          MoveArrays.QueenMoves6[(int) num1] = pieceMoveSet;
          pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte row7 = index2;
          byte col7 = index1;
          while ((int) row7 > 0 && (int) col7 < 7)
          {
            --row7;
            ++col7;
            byte num2 = PieceMoves.Position(col7, row7);
            pieceMoveSet.Moves.Add(num2);
            ++MoveArrays.QueenTotalMoves7[(int) num1];
          }
          MoveArrays.QueenMoves7[(int) num1] = pieceMoveSet;
          pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte row8 = index2;
          byte col8 = index1;
          while ((int) row8 > 0 && (int) col8 > 0)
          {
            --row8;
            --col8;
            byte num2 = PieceMoves.Position(col8, row8);
            pieceMoveSet.Moves.Add(num2);
            ++MoveArrays.QueenTotalMoves8[(int) num1];
          }
          MoveArrays.QueenMoves8[(int) num1] = pieceMoveSet;
        }
      }
    }

    private static void SetMovesKing()
    {
      for (byte index1 = 0; (int) index1 < 8; ++index1)
      {
        for (byte index2 = 0; (int) index2 < 8; ++index2)
        {
          byte num1 = (byte) ((uint) index1 + (uint) index2 * 8U);
          PieceMoveSet pieceMoveSet = new PieceMoveSet(new List<byte>());
          byte num2 = index2;
          byte col1 = index1;
          if ((int) num2 < 7)
          {
            byte row = (byte) ((uint) num2 + 1U);
            byte num3 = PieceMoves.Position(col1, row);
            pieceMoveSet.Moves.Add(num3);
            ++MoveArrays.KingTotalMoves[(int) num1];
          }
          byte num4 = index2;
          byte col2 = index1;
          if ((int) num4 > 0)
          {
            byte row = (byte) ((uint) num4 - 1U);
            byte num3 = PieceMoves.Position(col2, row);
            pieceMoveSet.Moves.Add(num3);
            ++MoveArrays.KingTotalMoves[(int) num1];
          }
          byte row1 = index2;
          byte num5 = index1;
          if ((int) num5 > 0)
          {
            byte num3 = PieceMoves.Position((byte) ((uint) num5 - 1U), row1);
            pieceMoveSet.Moves.Add(num3);
            ++MoveArrays.KingTotalMoves[(int) num1];
          }
          byte row2 = index2;
          byte num6 = index1;
          if ((int) num6 < 7)
          {
            byte num3 = PieceMoves.Position((byte) ((uint) num6 + 1U), row2);
            pieceMoveSet.Moves.Add(num3);
            ++MoveArrays.KingTotalMoves[(int) num1];
          }
          byte num7 = index2;
          byte num8 = index1;
          if ((int) num7 < 7 && (int) num8 < 7)
          {
            byte row3 = (byte) ((uint) num7 + 1U);
            byte num3 = PieceMoves.Position((byte) ((uint) num8 + 1U), row3);
            pieceMoveSet.Moves.Add(num3);
            ++MoveArrays.KingTotalMoves[(int) num1];
          }
          byte num9 = index2;
          byte num10 = index1;
          if ((int) num9 < 7 && (int) num10 > 0)
          {
            byte row3 = (byte) ((uint) num9 + 1U);
            byte num3 = PieceMoves.Position((byte) ((uint) num10 - 1U), row3);
            pieceMoveSet.Moves.Add(num3);
            ++MoveArrays.KingTotalMoves[(int) num1];
          }
          byte num11 = index2;
          byte num12 = index1;
          if ((int) num11 > 0 && (int) num12 < 7)
          {
            byte row3 = (byte) ((uint) num11 - 1U);
            byte num3 = PieceMoves.Position((byte) ((uint) num12 + 1U), row3);
            pieceMoveSet.Moves.Add(num3);
            ++MoveArrays.KingTotalMoves[(int) num1];
          }
          byte num13 = index2;
          byte num14 = index1;
          if ((int) num13 > 0 && (int) num14 > 0)
          {
            byte row3 = (byte) ((uint) num13 - 1U);
            byte num3 = PieceMoves.Position((byte) ((uint) num14 - 1U), row3);
            pieceMoveSet.Moves.Add(num3);
            ++MoveArrays.KingTotalMoves[(int) num1];
          }
          MoveArrays.KingMoves[(int) num1] = pieceMoveSet;
        }
      }
    }
  }
}
