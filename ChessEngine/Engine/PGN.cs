// Decompiled with JetBrains decompiler
// Type: ChessEngine.Engine.PGN
// Assembly: ChessEngine, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AD2B565-9B75-423F-BD9A-4B0A934C5249
// Assembly location: C:\Users\Ahmad Elsayed\1\ChessBinNoSetup\ChessBinNoSetup\ChessEngine.dll

using System;
using System.Collections.Generic;

namespace ChessEngine.Engine
{
  public class PGN
  {
    public static string GeneratePGN(Stack<MoveContent> moveHistory, int round, string whitePlayer, string blackPlayer, PGN.Result result)
    {
      int num = 0;
      string str1 = "";
      string str2 = "[Event \"ChessBin.com Chess\"]\r\n" + "[Site \"ChessBin.com\"]\r\n" + "[Date \"" + (object) DateTime.Now.Year + "." + (object) DateTime.Now.Month + "." + (object) DateTime.Now.Day + "\"]\r\n" + "[Round \"" + (object) round + "\"]\r\n" + "[White \"" + whitePlayer + "\"]\r\n" + "[Black \"" + blackPlayer + "\"]\r\n";
      if (result == PGN.Result.Ongoing)
        str2 += "[Result \"*\"]\r\n";
      else if (result == PGN.Result.White)
        str2 += "[Result \"1-0\"]\r\n";
      else if (result == PGN.Result.Black)
        str2 += "[Result \"0-1\"]\r\n";
      else if (result == PGN.Result.Tie)
        str2 += "[Result \"1/2-1/2\"]\r\n";
      foreach (MoveContent moveContent in moveHistory)
      {
        string str3 = "";
        if (moveContent.MovingPiecePrimary.PieceColor == ChessPieceColor.White)
          str3 = str3 + (object) (moveHistory.Count / 2 - num + 1) + ". ";
        str1 = str3 + moveContent.ToString() + " " + str1;
        if (moveContent.MovingPiecePrimary.PieceColor == ChessPieceColor.Black)
          ++num;
      }
      if (result == PGN.Result.White)
        str1 += " 1-0";
      else if (result == PGN.Result.Black)
        str1 += " 0-1";
      else if (result == PGN.Result.Tie)
        str1 += " 1/2-1/2";
      return str2 + str1;
    }

    public enum Result
    {
      White,
      Black,
      Tie,
      Ongoing,
    }
  }
}
