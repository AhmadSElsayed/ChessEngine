// Decompiled with JetBrains decompiler
// Type: ChessEngine.Engine.Book
// Assembly: ChessEngine, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AD2B565-9B75-423F-BD9A-4B0A934C5249
// Assembly location: C:\Users\Ahmad Elsayed\1\ChessBinNoSetup\ChessBinNoSetup\ChessEngine.dll

using System;
using System.Collections.Generic;
using System.IO;
using Windows.Storage;
using System.Threading.Tasks;

namespace ChessEngine.Engine
{
  internal class Book
  {
    public async static Task<List<OpeningMove>> LoadOpeningBook()
    {
      List<OpeningMove> openingMoveList = new List<OpeningMove>();
      if (!File.Exists("ms-appx:///OpeningBook\\book.dat"))
        return Book.PopulateOpeningBook();
      bool flag = true;
      try
      {
        var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///OpeningBook\\book.dat"));
        using (var inputStream = await file.OpenReadAsync())
        using (var classicStream = inputStream.AsStreamForRead())
        using (StreamReader streamReader = new StreamReader(classicStream))
        {
          OpeningMove openingMove = new OpeningMove();
          string str1;
          while ((str1 = streamReader.ReadLine()) != null)
          {
            if (flag)
            {
              openingMove = new OpeningMove();
              openingMove.StartingFEN = str1;
              flag = false;
            }
            else
            {
              string str2 = str1;
              char[] chArray = new char[1]{ ' ' };
              foreach (string move in str2.Split(chArray))
                openingMove.Moves.Add(new MoveContent(move));
              openingMoveList.Add(openingMove);
              flag = true;
            }
          }
        }
      }
      catch (Exception ex)
      {
        return Book.PopulateOpeningBook();
      }
      return openingMoveList;
    }

    internal static List<OpeningMove> PopulateOpeningBook()
    {
      List<OpeningMove> openingMoveList = new List<OpeningMove>();
      OpeningMove openingMove1 = new OpeningMove();
      openingMove1.StartingFEN = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq -";
      string str1 = "e2e4{3820} b2b3{15} c2c4{540} d2d4{2619} g1f3{851} g2g3{5}";
      char[] chArray1 = new char[1]{ ' ' };
      foreach (string move in str1.Split(chArray1))
        openingMove1.Moves.Add(new MoveContent(move));
      OpeningMove openingMove2 = new OpeningMove();
      openingMove2.StartingFEN = "rnbqkbnr/ppp1pppp/8/3p4/5P2/5N2/PPPPP1PP/RNBQKB1R b KQkq -";
      string str2 = "g7g6";
      char[] chArray2 = new char[1]{ ' ' };
      foreach (string move in str2.Split(chArray2))
        openingMove2.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove2);
      OpeningMove openingMove3 = new OpeningMove();
      openingMove3.StartingFEN = "rnbqkbnr/ppp1pppp/8/3p4/8/1P6/P1PPPPPP/RNBQKBNR w KQkq d6";
      string str3 = "c1b2{5}";
      char[] chArray3 = new char[1]{ ' ' };
      foreach (string move in str3.Split(chArray3))
        openingMove3.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove3);
      OpeningMove openingMove4 = new OpeningMove();
      openingMove4.StartingFEN = "rnbqkbnr/pp1ppppp/8/2p5/4P3/8/PPPP1PPP/RNBQKBNR w KQkq c6";
      string str4 = "g1f3{1517} c2c3{25} b1c3{82} g1e2{5} d2d3{5}";
      char[] chArray4 = new char[1]{ ' ' };
      foreach (string move in str4.Split(chArray4))
        openingMove4.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove4);
      OpeningMove openingMove5 = new OpeningMove();
      openingMove5.StartingFEN = "rnbqkbnr/pppppppp/8/8/8/5N2/PPPPPPPP/RNBQKB1R b KQkq -";
      string str5 = "g8f6{310} c7c5{88} d7d5{87} d7d6{5} g7g6{21} b8c6{5}";
      char[] chArray5 = new char[1]{ ' ' };
      foreach (string move in str5.Split(chArray5))
        openingMove5.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove5);
      OpeningMove openingMove6 = new OpeningMove();
      openingMove6.StartingFEN = "rnbqkbnr/pppppppp/8/8/3P4/8/PPP1PPPP/RNBQKBNR b KQkq d3";
      string str6 = "g8f6{1544} d7d5{506} e7e6{41} f7f5{30} d7d6{10} g7g6{10}";
      char[] chArray6 = new char[1]{ ' ' };
      foreach (string move in str6.Split(chArray6))
        openingMove6.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove6);
      OpeningMove openingMove7 = new OpeningMove();
      openingMove7.StartingFEN = "rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3";
      string str7 = "c7c5{1283} g8f6{10} e7e5{690} c7c6{248} e7e6{150} d7d6{20} g7g6{15} d7d5{5}";
      char[] chArray7 = new char[1]{ ' ' };
      foreach (string move in str7.Split(chArray7))
        openingMove7.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove7);
      OpeningMove openingMove8 = new OpeningMove();
      openingMove8.StartingFEN = "rnbqkbnr/pppppppp/8/8/2P5/8/PP1PPPPP/RNBQKBNR b KQkq c3";
      string str8 = "g7g6{44} c7c5{45} g8f6{107} e7e5{121} e7e6{31} f7f5{5} c7c6{5}";
      char[] chArray8 = new char[1]{ ' ' };
      foreach (string move in str8.Split(chArray8))
        openingMove8.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove8);
      OpeningMove openingMove9 = new OpeningMove();
      openingMove9.StartingFEN = "rnbqkbnr/pppp1ppp/8/4p3/4P3/8/PPPP1PPP/RNBQKBNR w KQkq e6";
      string str9 = "g1f3{1166} f1c4{21} f2f4{10} b1c3{5}";
      char[] chArray9 = new char[1]{ ' ' };
      foreach (string move in str9.Split(chArray9))
        openingMove9.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove9);
      OpeningMove openingMove10 = new OpeningMove();
      openingMove10.StartingFEN = "rnbqkbnr/pppp1ppp/8/4p3/8/1P6/P1PPPPPP/RNBQKBNR w KQkq e6";
      string str10 = "c1b2{5}";
      char[] chArray10 = new char[1]{ ' ' };
      foreach (string move in str10.Split(chArray10))
        openingMove10.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove10);
      OpeningMove openingMove11 = new OpeningMove();
      openingMove11.StartingFEN = "rnbqkb1r/pppppppp/5n2/8/2PP4/8/PP2PPPP/RNBQKBNR b KQkq c3";
      string str11 = "g7g6{549} e7e6{657} c7c5{47} b7b6{5}";
      char[] chArray11 = new char[1]{ ' ' };
      foreach (string move in str11.Split(chArray11))
        openingMove11.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove11);
      OpeningMove openingMove12 = new OpeningMove();
      openingMove12.StartingFEN = "rnbqkbnr/pp1ppppp/2p5/8/4P3/8/PPPP1PPP/RNBQKBNR w KQkq -";
      string str12 = "d2d4{347} b1c3{5} c2c4{5} d2d3{5}";
      char[] chArray12 = new char[1]{ ' ' };
      foreach (string move in str12.Split(chArray12))
        openingMove12.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove12);
      OpeningMove openingMove13 = new OpeningMove();
      openingMove13.StartingFEN = "rnbqkbnr/pppppp1p/6p1/8/2P5/2N5/PP1PPPPP/R1BQKBNR b KQkq -";
      string str13 = "c7c5{5} f8g7{23}";
      char[] chArray13 = new char[1]{ ' ' };
      foreach (string move in str13.Split(chArray13))
        openingMove13.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove13);
      OpeningMove openingMove14 = new OpeningMove();
      openingMove14.StartingFEN = "rnbqkbnr/pp2pppp/3p4/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq -";
      string str14 = "d2d4{767} f1b5{26} f1c4{5} c2c3{10}";
      char[] chArray14 = new char[1]{ ' ' };
      foreach (string move in str14.Split(chArray14))
        openingMove14.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove14);
      OpeningMove openingMove15 = new OpeningMove();
      openingMove15.StartingFEN = "rnbqkbnr/pppp1ppp/4p3/8/4P3/8/PPPP1PPP/RNBQKBNR w KQkq -";
      string str15 = "d2d4{378} d2d3{35}";
      char[] chArray15 = new char[1]{ ' ' };
      foreach (string move in str15.Split(chArray15))
        openingMove15.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove15);
      OpeningMove openingMove16 = new OpeningMove();
      openingMove16.StartingFEN = "rnbqkbnr/pp2pppp/3p4/8/3pP3/5N2/PPP2PPP/RNBQKB1R w KQkq -";
      string str16 = "f3d4{726} d1d4{5}";
      char[] chArray16 = new char[1]{ ' ' };
      foreach (string move in str16.Split(chArray16))
        openingMove16.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove16);
      OpeningMove openingMove17 = new OpeningMove();
      openingMove17.StartingFEN = "r1bqkbnr/pp1ppppp/2n5/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq -";
      string str17 = "d2d4{325} f1b5{36} b1c3{26} c2c3{5}";
      char[] chArray17 = new char[1]{ ' ' };
      foreach (string move in str17.Split(chArray17))
        openingMove17.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove17);
      OpeningMove openingMove18 = new OpeningMove();
      openingMove18.StartingFEN = "rnbqkb1r/pppppp1p/5np1/8/2PP4/2N5/PP2PPPP/R1BQKBNR b KQkq -";
      string str18 = "d7d5{211} f8g7{227}";
      char[] chArray18 = new char[1]{ ' ' };
      foreach (string move in str18.Split(chArray18))
        openingMove18.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove18);
      OpeningMove openingMove19 = new OpeningMove();
      openingMove19.StartingFEN = "rnbqkb1r/pp2pppp/3p1n2/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
      string str19 = "b1c3{716}";
      char[] chArray19 = new char[1]{ ' ' };
      foreach (string move in str19.Split(chArray19))
        openingMove19.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove19);
      OpeningMove openingMove20 = new OpeningMove();
      openingMove20.StartingFEN = "r1bqkbnr/pp1ppppp/2n5/8/3pP3/5N2/PPP2PPP/RNBQKB1R w KQkq -";
      string str20 = "f3d4{320}";
      char[] chArray20 = new char[1]{ ' ' };
      foreach (string move in str20.Split(chArray20))
        openingMove20.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove20);
      OpeningMove openingMove21 = new OpeningMove();
      openingMove21.StartingFEN = "rnbqkbnr/pp1p1ppp/4p3/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq -";
      string str21 = "d2d4{282} b1c3{10} c2c4{5} c2c3{10}";
      char[] chArray21 = new char[1]{ ' ' };
      foreach (string move in str21.Split(chArray21))
        openingMove21.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove21);
      OpeningMove openingMove22 = new OpeningMove();
      openingMove22.StartingFEN = "rnbqkbnr/pp1p1ppp/4p3/8/3pP3/5N2/PPP2PPP/RNBQKB1R w KQkq -";
      string str22 = "f3d4{272}";
      char[] chArray22 = new char[1]{ ' ' };
      foreach (string move in str22.Split(chArray22))
        openingMove22.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove22);
      OpeningMove openingMove23 = new OpeningMove();
      openingMove23.StartingFEN = "rnbqkb1r/pp3ppp/3ppn2/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
      string str23 = "g2g4{40} f1e2{11} c1e3{17} f2f4{5}";
      char[] chArray23 = new char[1]{ ' ' };
      foreach (string move in str23.Split(chArray23))
        openingMove23.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove23);
      OpeningMove openingMove24 = new OpeningMove();
      openingMove24.StartingFEN = "rnbqkbnr/pp1ppppp/8/2p5/2P5/5N2/PP1PPPPP/RNBQKB1R b KQkq -";
      string str24 = "g8f6{20} b8c6{10} g7g6{5}";
      char[] chArray24 = new char[1]{ ' ' };
      foreach (string move in str24.Split(chArray24))
        openingMove24.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove24);
      OpeningMove openingMove25 = new OpeningMove();
      openingMove25.StartingFEN = "rnbqkb1r/pppp1ppp/5n2/4p3/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq -";
      string str25 = "f3e5{219} d2d4{67} b1c3{5}";
      char[] chArray25 = new char[1]{ ' ' };
      foreach (string move in str25.Split(chArray25))
        openingMove25.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove25);
      OpeningMove openingMove26 = new OpeningMove();
      openingMove26.StartingFEN = "rnbqkbnr/1p1p1ppp/p3p3/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
      string str26 = "f1d3{65} b1c3{22} g2g3{5}";
      char[] chArray26 = new char[1]{ ' ' };
      foreach (string move in str26.Split(chArray26))
        openingMove26.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove26);
      OpeningMove openingMove27 = new OpeningMove();
      openingMove27.StartingFEN = "rnbqkb1r/ppp1pp1p/5np1/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
      string str27 = "f8g7{78}";
      char[] chArray27 = new char[1]{ ' ' };
      foreach (string move in str27.Split(chArray27))
        openingMove27.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove27);
      OpeningMove openingMove28 = new OpeningMove();
      openingMove28.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/3p4/3PP3/8/PPP2PPP/RNBQKBNR w KQkq d6";
      string str28 = "b1d2{80} b1c3{252} e4e5{30} e4d5{11}";
      char[] chArray28 = new char[1]{ ' ' };
      foreach (string move in str28.Split(chArray28))
        openingMove28.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove28);
      OpeningMove openingMove29 = new OpeningMove();
      openingMove29.StartingFEN = "rnbqkb1r/pppppppp/5n2/8/3P4/8/PPP1PPPP/RNBQKBNR w KQkq -";
      string str29 = "c2c4{1593} g1f3{175} c1g5{10}";
      char[] chArray29 = new char[1]{ ' ' };
      foreach (string move in str29.Split(chArray29))
        openingMove29.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove29);
      OpeningMove openingMove30 = new OpeningMove();
      openingMove30.StartingFEN = "rnbqkb1r/pppp1ppp/4pn2/8/2PP4/2N5/PP2PPPP/R1BQKBNR b KQkq -";
      string str30 = "f8b4{276} c7c5{5} d7d5{5}";
      char[] chArray30 = new char[1]{ ' ' };
      foreach (string move in str30.Split(chArray30))
        openingMove30.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove30);
      OpeningMove openingMove31 = new OpeningMove();
      openingMove31.StartingFEN = "rnbqkb1r/pppppppp/5n2/8/8/5NP1/PPPPPP1P/RNBQKB1R b KQkq -";
      string str31 = "b7b5{5} d7d5{20} g7g6{10}";
      char[] chArray31 = new char[1]{ ' ' };
      foreach (string move in str31.Split(chArray31))
        openingMove31.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove31);
      OpeningMove openingMove32 = new OpeningMove();
      openingMove32.StartingFEN = "rnbqkb1r/1p2pppp/p2p1n2/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
      string str32 = "f1e2{167} c1g5{56} c1e3{276} f2f4{21} f1c4{20} g2g3{5} f2f3{20}";
      char[] chArray32 = new char[1]{ ' ' };
      foreach (string move in str32.Split(chArray32))
        openingMove32.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove32);
      OpeningMove openingMove33 = new OpeningMove();
      openingMove33.StartingFEN = "rnbqkbnr/pp1ppppp/8/2p5/2P5/8/PP1PPPPP/RNBQKBNR w KQkq c6";
      string str33 = "g1f3{77} b1c3{10} g2g3{5}";
      char[] chArray33 = new char[1]{ ' ' };
      foreach (string move in str33.Split(chArray33))
        openingMove33.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove33);
      OpeningMove openingMove34 = new OpeningMove();
      openingMove34.StartingFEN = "rnbqkbnr/ppp1pppp/3p4/8/4P3/8/PPPP1PPP/RNBQKBNR w KQkq -";
      string str34 = "d2d4{107}";
      char[] chArray34 = new char[1]{ ' ' };
      foreach (string move in str34.Split(chArray34))
        openingMove34.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove34);
      OpeningMove openingMove35 = new OpeningMove();
      openingMove35.StartingFEN = "rnbqkb1r/1p3ppp/p2p1n2/4p3/3NP3/2N5/PPP1BPPP/R1BQK2R w KQkq e6";
      string str35 = "d4b3{56}";
      char[] chArray35 = new char[1]{ ' ' };
      foreach (string move in str35.Split(chArray35))
        openingMove35.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove35);
      OpeningMove openingMove36 = new OpeningMove();
      openingMove36.StartingFEN = "rnbqkbnr/pppp1ppp/8/4p3/4P3/5N2/PPPP1PPP/RNBQKB1R b KQkq -";
      string str36 = "b8c6{480} g8f6{180}";
      char[] chArray36 = new char[1]{ ' ' };
      foreach (string move in str36.Split(chArray36))
        openingMove36.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove36);
      OpeningMove openingMove37 = new OpeningMove();
      openingMove37.StartingFEN = "r1bqkbnr/pppp1ppp/2n5/4p3/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq -";
      string str37 = "f1b5{739} f1c4{46} d2d4{70} b1c3{15}";
      char[] chArray37 = new char[1]{ ' ' };
      foreach (string move in str37.Split(chArray37))
        openingMove37.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove37);
      OpeningMove openingMove38 = new OpeningMove();
      openingMove38.StartingFEN = "rnbqkb1r/pppp1ppp/4pn2/8/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
      string str38 = "g1f3{574} b1c3{314} g2g3{61}";
      char[] chArray38 = new char[1]{ ' ' };
      foreach (string move in str38.Split(chArray38))
        openingMove38.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove38);
      OpeningMove openingMove39 = new OpeningMove();
      openingMove39.StartingFEN = "r1bqkb1r/pp1ppppp/2n2n2/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
      string str39 = "b1c3{190}";
      char[] chArray39 = new char[1]{ ' ' };
      foreach (string move in str39.Split(chArray39))
        openingMove39.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove39);
      OpeningMove openingMove40 = new OpeningMove();
      openingMove40.StartingFEN = "rnbqkbnr/pp1ppppp/8/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R b KQkq -";
      string str40 = "e7e6{142} d7d6{664} b8c6{334}";
      char[] chArray40 = new char[1]{ ' ' };
      foreach (string move in str40.Split(chArray40))
        openingMove40.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove40);
      OpeningMove openingMove41 = new OpeningMove();
      openingMove41.StartingFEN = "r1bqkbnr/1ppp1ppp/p1n5/1B2p3/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str41 = "b5a4{579} b5c6{15}";
      char[] chArray41 = new char[1]{ ' ' };
      foreach (string move in str41.Split(chArray41))
        openingMove41.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove41);
      OpeningMove openingMove42 = new OpeningMove();
      openingMove42.StartingFEN = "rnbqk2r/pp2bppp/3ppn2/8/3NP1P1/2N5/PPP2P1P/R1BQKB1R w KQkq -";
      string str42 = "g4g5{5}";
      char[] chArray42 = new char[1]{ ' ' };
      foreach (string move in str42.Split(chArray42))
        openingMove42.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove42);
      OpeningMove openingMove43 = new OpeningMove();
      openingMove43.StartingFEN = "rnbqkbnr/ppp1pppp/8/3p4/3P4/8/PPP1PPPP/RNBQKBNR w KQkq d6";
      string str43 = "c2c4{649} g1f3{63}";
      char[] chArray43 = new char[1]{ ' ' };
      foreach (string move in str43.Split(chArray43))
        openingMove43.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove43);
      OpeningMove openingMove44 = new OpeningMove();
      openingMove44.StartingFEN = "rnbqkbnr/pp3ppp/4p3/2pp4/3PP3/8/PPPN1PPP/R1BQKBNR w KQkq c6";
      string str44 = "e4d5{30} g1f3{5}";
      char[] chArray44 = new char[1]{ ' ' };
      foreach (string move in str44.Split(chArray44))
        openingMove44.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove44);
      OpeningMove openingMove45 = new OpeningMove();
      openingMove45.StartingFEN = "rnbqkbnr/pp1ppppp/8/2p5/4P3/6P1/PPPP1P1P/RNBQKBNR b KQkq -";
      string str45 = "g7g6{6}";
      char[] chArray45 = new char[1]{ ' ' };
      foreach (string move in str45.Split(chArray45))
        openingMove45.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove45);
      OpeningMove openingMove46 = new OpeningMove();
      openingMove46.StartingFEN = "rnbqkbnr/pppp1ppp/8/4p3/2P5/8/PP1PPPPP/RNBQKBNR w KQkq e6";
      string str46 = "b1c3{73} g2g3{41}";
      char[] chArray46 = new char[1]{ ' ' };
      foreach (string move in str46.Split(chArray46))
        openingMove46.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove46);
      OpeningMove openingMove47 = new OpeningMove();
      openingMove47.StartingFEN = "rnbqkbnr/pp2pppp/2p5/3p4/3PP3/8/PPP2PPP/RNBQKBNR w KQkq d6";
      string str47 = "b1c3{71} b1d2{154} e4d5{36} e4e5{76} f2f3{5}";
      char[] chArray47 = new char[1]{ ' ' };
      foreach (string move in str47.Split(chArray47))
        openingMove47.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove47);
      OpeningMove openingMove48 = new OpeningMove();
      openingMove48.StartingFEN = "rnbqkbnr/pppppppp/8/8/5P2/8/PPPPP1PP/RNBQKBNR b KQkq f3";
      string str48 = "d7d5{6}";
      char[] chArray48 = new char[1]{ ' ' };
      foreach (string move in str48.Split(chArray48))
        openingMove48.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove48);
      OpeningMove openingMove49 = new OpeningMove();
      openingMove49.StartingFEN = "r1bqkb1r/pp1p1ppp/2n2n2/4p3/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq e6";
      string str49 = "d4b5{83}";
      char[] chArray49 = new char[1]{ ' ' };
      foreach (string move in str49.Split(chArray49))
        openingMove49.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove49);
      OpeningMove openingMove50 = new OpeningMove();
      openingMove50.StartingFEN = "rnbqkbnr/pppp1ppp/4p3/8/2P5/8/PP1PPPPP/RNBQKBNR w KQkq -";
      string str50 = "g1f3{28} b1c3{72} d2d4{10} g2g3{6}";
      char[] chArray50 = new char[1]{ ' ' };
      foreach (string move in str50.Split(chArray50))
        openingMove50.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove50);
      OpeningMove openingMove51 = new OpeningMove();
      openingMove51.StartingFEN = "rnbqkb1r/pp2pp1p/3p1np1/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
      string str51 = "f1e2{5} c1e3{36}";
      char[] chArray51 = new char[1]{ ' ' };
      foreach (string move in str51.Split(chArray51))
        openingMove51.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove51);
      OpeningMove openingMove52 = new OpeningMove();
      openingMove52.StartingFEN = "r1bqkb1r/pp2pppp/2np1n2/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
      string str52 = "f1e2{5} c1g5{91} c1e3{5} g2g3{15} f2f3{20} f1c4{35}";
      char[] chArray52 = new char[1]{ ' ' };
      foreach (string move in str52.Split(chArray52))
        openingMove52.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove52);
      OpeningMove openingMove53 = new OpeningMove();
      openingMove53.StartingFEN = "rnbqkb1r/pp1ppppp/5n2/2p5/2P5/2N2N2/PP1PPPPP/R1BQKB1R b KQkq -";
      string str53 = "d7d5{11} b8c6{10} e7e6{5}";
      char[] chArray53 = new char[1]{ ' ' };
      foreach (string move in str53.Split(chArray53))
        openingMove53.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove53);
      OpeningMove openingMove54 = new OpeningMove();
      openingMove54.StartingFEN = "rnbqkb1r/pp1p1ppp/4pn2/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
      string str54 = "b1c3{69}";
      char[] chArray54 = new char[1]{ ' ' };
      foreach (string move in str54.Split(chArray54))
        openingMove54.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove54);
      OpeningMove openingMove55 = new OpeningMove();
      openingMove55.StartingFEN = "rnbqkbnr/p1pppppp/1p6/8/2P5/8/PP1PPPPP/RNBQKBNR w KQkq -";
      string str55 = "d2d4{10}";
      char[] chArray55 = new char[1]{ ' ' };
      foreach (string move in str55.Split(chArray55))
        openingMove55.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove55);
      OpeningMove openingMove56 = new OpeningMove();
      openingMove56.StartingFEN = "rnbqkb1r/pp1ppppp/5n2/2p5/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
      string str56 = "b1c3{82} d2d4{5}";
      char[] chArray56 = new char[1]{ ' ' };
      foreach (string move in str56.Split(chArray56))
        openingMove56.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove56);
      OpeningMove openingMove57 = new OpeningMove();
      openingMove57.StartingFEN = "rnbqkbnr/pppppp1p/6p1/8/4P3/8/PPPP1PPP/RNBQKBNR w KQkq -";
      string str57 = "d2d4{45}";
      char[] chArray57 = new char[1]{ ' ' };
      foreach (string move in str57.Split(chArray57))
        openingMove57.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove57);
      OpeningMove openingMove58 = new OpeningMove();
      openingMove58.StartingFEN = "rnbqkbnr/pp1p1ppp/4p3/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R b KQkq -";
      string str58 = "a7a6{6} b8c6{5}";
      char[] chArray58 = new char[1]{ ' ' };
      foreach (string move in str58.Split(chArray58))
        openingMove58.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove58);
      OpeningMove openingMove59 = new OpeningMove();
      openingMove59.StartingFEN = "rnbqkbnr/pp1ppppp/8/2p5/3PP3/8/PPP2PPP/RNBQKBNR b KQkq d3";
      string str59 = "c5d4{5}";
      char[] chArray59 = new char[1]{ ' ' };
      foreach (string move in str59.Split(chArray59))
        openingMove59.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove59);
      OpeningMove openingMove60 = new OpeningMove();
      openingMove60.StartingFEN = "rnbqkbnr/pp1ppppp/2p5/8/2P1P3/8/PP1P1PPP/RNBQKBNR b KQkq c3";
      string str60 = "d7d5{11}";
      char[] chArray60 = new char[1]{ ' ' };
      foreach (string move in str60.Split(chArray60))
        openingMove60.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove60);
      OpeningMove openingMove61 = new OpeningMove();
      openingMove61.StartingFEN = "rnbqkb1r/pp1p1ppp/4pn2/2p5/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
      string str61 = "g2g3{35}";
      char[] chArray61 = new char[1]{ ' ' };
      foreach (string move in str61.Split(chArray61))
        openingMove61.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove61);
      OpeningMove openingMove62 = new OpeningMove();
      openingMove62.StartingFEN = "rnbqkbnr/pp2pppp/2p5/8/3Pp3/8/PPPN1PPP/R1BQKBNR w KQkq -";
      string str62 = "d2e4{144}";
      char[] chArray62 = new char[1]{ ' ' };
      foreach (string move in str62.Split(chArray62))
        openingMove62.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove62);
      OpeningMove openingMove63 = new OpeningMove();
      openingMove63.StartingFEN = "rnbqkb1r/pp2pppp/3p1n2/2p5/3PP3/5N2/PPP2PPP/RNBQKB1R w KQkq -";
      string str63 = "b1c3{26}";
      char[] chArray63 = new char[1]{ ' ' };
      foreach (string move in str63.Split(chArray63))
        openingMove63.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove63);
      OpeningMove openingMove64 = new OpeningMove();
      openingMove64.StartingFEN = "rnbqkbnr/p1pp1ppp/1p2p3/8/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
      string str64 = "d4d5{5}";
      char[] chArray64 = new char[1]{ ' ' };
      foreach (string move in str64.Split(chArray64))
        openingMove64.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove64);
      OpeningMove openingMove65 = new OpeningMove();
      openingMove65.StartingFEN = "rnbqk2r/pppp1ppp/4pn2/8/1bPP4/2N1P3/PP3PPP/R1BQKBNR b KQkq -";
      string str65 = "e8g8{50} c7c5{30} b7b6{5}";
      char[] chArray65 = new char[1]{ ' ' };
      foreach (string move in str65.Split(chArray65))
        openingMove65.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove65);
      OpeningMove openingMove66 = new OpeningMove();
      openingMove66.StartingFEN = "rnbqkb1r/pppp1ppp/4pn2/8/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
      string str66 = "b1c3{123} g2g3{11} d2d4{25}";
      char[] chArray66 = new char[1]{ ' ' };
      foreach (string move in str66.Split(chArray66))
        openingMove66.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove66);
      OpeningMove openingMove67 = new OpeningMove();
      openingMove67.StartingFEN = "rnbqkbnr/pp2pppp/2p5/3p4/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
      string str67 = "c4d5{6} g1f3{151} b1c3{166}";
      char[] chArray67 = new char[1]{ ' ' };
      foreach (string move in str67.Split(chArray67))
        openingMove67.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove67);
      OpeningMove openingMove68 = new OpeningMove();
      openingMove68.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/3p4/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq d6";
      string str68 = "d2d4{11}";
      char[] chArray68 = new char[1]{ ' ' };
      foreach (string move in str68.Split(chArray68))
        openingMove68.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove68);
      OpeningMove openingMove69 = new OpeningMove();
      openingMove69.StartingFEN = "rnbqkb1r/pp2pppp/2p2n2/8/3PN3/8/PPP2PPP/R1BQKBNR w KQkq -";
      string str69 = "e4g3{5} e4f6{10}";
      char[] chArray69 = new char[1]{ ' ' };
      foreach (string move in str69.Split(chArray69))
        openingMove69.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove69);
      OpeningMove openingMove70 = new OpeningMove();
      openingMove70.StartingFEN = "r1bqkb1r/1ppp1ppp/p1n2n2/4p3/B3P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str70 = "e1g1{538} d2d3{5}";
      char[] chArray70 = new char[1]{ ' ' };
      foreach (string move in str70.Split(chArray70))
        openingMove70.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove70);
      OpeningMove openingMove71 = new OpeningMove();
      openingMove71.StartingFEN = "rnbqkb1r/pppppppp/5n2/6B1/3P4/8/PPP1PPPP/RN1QKBNR b KQkq -";
      string str71 = "d7d6{6} e7e6{21} d7d5{5}";
      char[] chArray71 = new char[1]{ ' ' };
      foreach (string move in str71.Split(chArray71))
        openingMove71.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove71);
      OpeningMove openingMove72 = new OpeningMove();
      openingMove72.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq d6";
      string str72 = "b1c3{156} c1g5{5} e2e3{5} g2g3{5}";
      char[] chArray72 = new char[1]{ ' ' };
      foreach (string move in str72.Split(chArray72))
        openingMove72.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove72);
      OpeningMove openingMove73 = new OpeningMove();
      openingMove73.StartingFEN = "rnbqkb1r/ppp1pppp/3p1n2/8/3PP3/8/PPP2PPP/RNBQKBNR w KQkq -";
      string str73 = "b1c3{71} f2f3{16} f1d3{10}";
      char[] chArray73 = new char[1]{ ' ' };
      foreach (string move in str73.Split(chArray73))
        openingMove73.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove73);
      OpeningMove openingMove74 = new OpeningMove();
      openingMove74.StartingFEN = "r1bqkbnr/pppp1ppp/2n5/4p3/3PP3/5N2/PPP2PPP/RNBQKB1R b KQkq d3";
      string str74 = "e5d4{35}";
      char[] chArray74 = new char[1]{ ' ' };
      foreach (string move in str74.Split(chArray74))
        openingMove74.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove74);
      OpeningMove openingMove75 = new OpeningMove();
      openingMove75.StartingFEN = "rnbqkb1r/pppp1ppp/4pn2/8/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq -";
      string str75 = "b7b6{216} d7d5{80} c7c5{25}";
      char[] chArray75 = new char[1]{ ' ' };
      foreach (string move in str75.Split(chArray75))
        openingMove75.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove75);
      OpeningMove openingMove76 = new OpeningMove();
      openingMove76.StartingFEN = "rnbqkb1r/pppppppp/5n2/8/2P5/2N5/PP1PPPPP/R1BQKBNR b KQkq -";
      string str76 = "e7e5{35} c7c5{17} e7e6{5} g7g6{10}";
      char[] chArray76 = new char[1]{ ' ' };
      foreach (string move in str76.Split(chArray76))
        openingMove76.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove76);
      OpeningMove openingMove77 = new OpeningMove();
      openingMove77.StartingFEN = "rnbqkb1r/pppppppp/5n2/8/2P5/8/PP1PPPPP/RNBQKBNR w KQkq -";
      string str77 = "g1f3{37} b1c3{104} d2d4{10} g2g3{5}";
      char[] chArray77 = new char[1]{ ' ' };
      foreach (string move in str77.Split(chArray77))
        openingMove77.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove77);
      OpeningMove openingMove78 = new OpeningMove();
      openingMove78.StartingFEN = "rnbqk2r/1p2bppp/p2p1n2/4p3/4P3/1NN5/PPP1BPPP/R1BQK2R w KQkq -";
      string str78 = "e1g1{46} g2g4{5}";
      char[] chArray78 = new char[1]{ ' ' };
      foreach (string move in str78.Split(chArray78))
        openingMove78.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove78);
      OpeningMove openingMove79 = new OpeningMove();
      openingMove79.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/8/3NP3/2N5/PPP1BPPP/R1BQK2R w KQkq -";
      string str79 = "e1g1{60} f2f4{26} a2a4{5}";
      char[] chArray79 = new char[1]{ ' ' };
      foreach (string move in str79.Split(chArray79))
        openingMove79.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove79);
      OpeningMove openingMove80 = new OpeningMove();
      openingMove80.StartingFEN = "rnbqkb1r/p1pp1ppp/1p2pn2/8/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
      string str80 = "e2e3{10} g2g3{262} b1c3{38} a2a3{45}";
      char[] chArray80 = new char[1]{ ' ' };
      foreach (string move in str80.Split(chArray80))
        openingMove80.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove80);
      OpeningMove openingMove81 = new OpeningMove();
      openingMove81.StartingFEN = "r1bqkbnr/pppp1ppp/2n5/1B2p3/4P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
      string str81 = "a7a6{330} f8c5{5} c6d4{5} g8f6{50}";
      char[] chArray81 = new char[1]{ ' ' };
      foreach (string move in str81.Split(chArray81))
        openingMove81.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove81);
      OpeningMove openingMove82 = new OpeningMove();
      openingMove82.StartingFEN = "rn1qkbnr/pp2pppp/2p5/5b2/3PN3/8/PPP2PPP/R1BQKBNR w KQkq -";
      string str82 = "e4g3{70} e4c5{5}";
      char[] chArray82 = new char[1]{ ' ' };
      foreach (string move in str82.Split(chArray82))
        openingMove82.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove82);
      OpeningMove openingMove83 = new OpeningMove();
      openingMove83.StartingFEN = "r1bqkb1r/pp1ppppp/2n2n2/2p5/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
      string str83 = "g2g3{46} e2e3{15} d2d4{26} e2e4{5}";
      char[] chArray83 = new char[1]{ ' ' };
      foreach (string move in str83.Split(chArray83))
        openingMove83.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove83);
      OpeningMove openingMove84 = new OpeningMove();
      openingMove84.StartingFEN = "rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/4PN2/PP3PPP/RNBQKB1R w KQkq -";
      string str84 = "f1d3{5}";
      char[] chArray84 = new char[1]{ ' ' };
      foreach (string move in str84.Split(chArray84))
        openingMove84.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove84);
      OpeningMove openingMove85 = new OpeningMove();
      openingMove85.StartingFEN = "rnbqkb1r/pppppp1p/5np1/8/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
      string str85 = "b1c3{444} g1f3{50} g2g3{71}";
      char[] chArray85 = new char[1]{ ' ' };
      foreach (string move in str85.Split(chArray85))
        openingMove85.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove85);
      OpeningMove openingMove86 = new OpeningMove();
      openingMove86.StartingFEN = "rnbqkb1r/pp3pp1/3ppn1p/8/3NP1P1/2N5/PPP2P1P/R1BQKB1R w KQkq -";
      string str86 = "h2h4{15} h1g1{5} h2h3{10}";
      char[] chArray86 = new char[1]{ ' ' };
      foreach (string move in str86.Split(chArray86))
        openingMove86.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove86);
      OpeningMove openingMove87 = new OpeningMove();
      openingMove87.StartingFEN = "rnbqk2r/pppp1ppp/4pn2/8/1bPP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
      string str87 = "b1d2{16} c1d2{37}";
      char[] chArray87 = new char[1]{ ' ' };
      foreach (string move in str87.Split(chArray87))
        openingMove87.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove87);
      OpeningMove openingMove88 = new OpeningMove();
      openingMove88.StartingFEN = "rnbqkbnr/pp1ppppp/2p5/8/4P3/2N5/PPPP1PPP/R1BQKBNR b KQkq -";
      string str88 = "d7d5{16}";
      char[] chArray88 = new char[1]{ ' ' };
      foreach (string move in str88.Split(chArray88))
        openingMove88.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove88);
      OpeningMove openingMove89 = new OpeningMove();
      openingMove89.StartingFEN = "r1bqk2r/1pppbppp/p1n2n2/4p3/B3P3/5N2/PPPP1PPP/RNBQ1RK1 w kq -";
      string str89 = "f1e1{326} d1e2{15} a4c6{5}";
      char[] chArray89 = new char[1]{ ' ' };
      foreach (string move in str89.Split(chArray89))
        openingMove89.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove89);
      OpeningMove openingMove90 = new OpeningMove();
      openingMove90.StartingFEN = "rnbqkbnr/pp1ppppp/2p5/8/3PP3/8/PPP2PPP/RNBQKBNR b KQkq d3";
      string str90 = "d7d5{206}";
      char[] chArray90 = new char[1]{ ' ' };
      foreach (string move in str90.Split(chArray90))
        openingMove90.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove90);
      OpeningMove openingMove91 = new OpeningMove();
      openingMove91.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/3p4/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
      string str91 = "g1f3{32} b1c3{136}";
      char[] chArray91 = new char[1]{ ' ' };
      foreach (string move in str91.Split(chArray91))
        openingMove91.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove91);
      OpeningMove openingMove92 = new OpeningMove();
      openingMove92.StartingFEN = "rnbqk2r/ppppppbp/5np1/8/2PPP3/2N5/PP3PPP/R1BQKBNR b KQkq e3";
      string str92 = "d7d6{221}";
      char[] chArray92 = new char[1]{ ' ' };
      foreach (string move in str92.Split(chArray92))
        openingMove92.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove92);
      OpeningMove openingMove93 = new OpeningMove();
      openingMove93.StartingFEN = "rnbqkb1r/ppp1pp1p/3p1np1/8/3PP3/2N5/PPP2PPP/R1BQKBNR w KQkq -";
      string str93 = "f2f4{5} g1f3{15} g2g3{10} c1e3{26} f1e2{5} c1g5{5}";
      char[] chArray93 = new char[1]{ ' ' };
      foreach (string move in str93.Split(chArray93))
        openingMove93.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove93);
      OpeningMove openingMove94 = new OpeningMove();
      openingMove94.StartingFEN = "rnbqkbnr/pppp1ppp/8/4p3/2P5/2N5/PP1PPPPP/R1BQKBNR b KQkq -";
      string str94 = "g8f6{55} d7d6{5} b8c6{21} f8b4{5}";
      char[] chArray94 = new char[1]{ ' ' };
      foreach (string move in str94.Split(chArray94))
        openingMove94.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove94);
      OpeningMove openingMove95 = new OpeningMove();
      openingMove95.StartingFEN = "rnbqk2r/ppp1ppbp/3p1np1/8/2PPP3/2N2P2/PP4PP/R1BQKBNR b KQkq -";
      string str95 = "e8g8{104}";
      char[] chArray95 = new char[1]{ ' ' };
      foreach (string move in str95.Split(chArray95))
        openingMove95.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove95);
      OpeningMove openingMove96 = new OpeningMove();
      openingMove96.StartingFEN = "rnbqkb1r/pppppppp/5n2/8/8/5N2/PPPPPPPP/RNBQKB1R w KQkq -";
      string str96 = "c2c4{484} g2g3{10} d2d4{21}";
      char[] chArray96 = new char[1]{ ' ' };
      foreach (string move in str96.Split(chArray96))
        openingMove96.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove96);
      OpeningMove openingMove97 = new OpeningMove();
      openingMove97.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/3p4/2P5/2N5/PP1PPPPP/R1BQKBNR w KQkq d6";
      string str97 = "d2d4{61}";
      char[] chArray97 = new char[1]{ ' ' };
      foreach (string move in str97.Split(chArray97))
        openingMove97.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove97);
      OpeningMove openingMove98 = new OpeningMove();
      openingMove98.StartingFEN = "rnbqkbnr/ppp1pppp/8/3p4/8/5N2/PPPPPPPP/RNBQKB1R w KQkq d6";
      string str98 = "c2c4{15} d2d4{200} g2g3{5}";
      char[] chArray98 = new char[1]{ ' ' };
      foreach (string move in str98.Split(chArray98))
        openingMove98.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove98);
      OpeningMove openingMove99 = new OpeningMove();
      openingMove99.StartingFEN = "r1bqkbnr/pp1ppppp/2n5/2p5/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
      string str99 = "e2e3{5} b1c3{15}";
      char[] chArray99 = new char[1]{ ' ' };
      foreach (string move in str99.Split(chArray99))
        openingMove99.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove99);
      OpeningMove openingMove100 = new OpeningMove();
      openingMove100.StartingFEN = "rnbqkb1r/pp2pppp/2p2n2/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
      string str100 = "b1c3{216} e2e3{20}";
      char[] chArray100 = new char[1]{ ' ' };
      foreach (string move in str100.Split(chArray100))
        openingMove100.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove100);
      OpeningMove openingMove101 = new OpeningMove();
      openingMove101.StartingFEN = "rnbqkb1r/pppp1ppp/5n2/4N3/4P3/8/PPPP1PPP/RNBQKB1R b KQkq -";
      string str101 = "d7d6{140}";
      char[] chArray101 = new char[1]{ ' ' };
      foreach (string move in str101.Split(chArray101))
        openingMove101.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove101);
      OpeningMove openingMove102 = new OpeningMove();
      openingMove102.StartingFEN = "r1bqkbnr/1ppp1p1p/p1n3p1/4p3/B3P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str102 = "d2d4{6}";
      char[] chArray102 = new char[1]{ ' ' };
      foreach (string move in str102.Split(chArray102))
        openingMove102.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove102);
      OpeningMove openingMove103 = new OpeningMove();
      openingMove103.StartingFEN = "rnbqkbnr/pp1ppppp/8/2p5/2P5/5N2/PP1PPPPP/RNBQKB1R b KQkq c3";
      string str103 = "g8f6{22} b8c6{36} g7g6{15}";
      char[] chArray103 = new char[1]{ ' ' };
      foreach (string move in str103.Split(chArray103))
        openingMove103.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove103);
      OpeningMove openingMove104 = new OpeningMove();
      openingMove104.StartingFEN = "r1bqkbnr/pp1p1ppp/2n1p3/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
      string str104 = "d4b5{15} b1c3{116} f1e2{5}";
      char[] chArray104 = new char[1]{ ' ' };
      foreach (string move in str104.Split(chArray104))
        openingMove104.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove104);
      OpeningMove openingMove105 = new OpeningMove();
      openingMove105.StartingFEN = "r1bqkb1r/pppp1ppp/2n2n2/1B2p3/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str105 = "e1g1{110}";
      char[] chArray105 = new char[1]{ ' ' };
      foreach (string move in str105.Split(chArray105))
        openingMove105.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove105);
      OpeningMove openingMove106 = new OpeningMove();
      openingMove106.StartingFEN = "rnbqkb1r/ppp2ppp/3p1n2/4N3/4P3/8/PPPP1PPP/RNBQKB1R w KQkq -";
      string str106 = "e5f3{204} e5f7{5}";
      char[] chArray106 = new char[1]{ ' ' };
      foreach (string move in str106.Split(chArray106))
        openingMove106.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove106);
      OpeningMove openingMove107 = new OpeningMove();
      openingMove107.StartingFEN = "rnbqkbnr/pppp1ppp/4p3/8/2P5/2N5/PP1PPPPP/R1BQKBNR b KQkq -";
      string str107 = "d7d5{21}";
      char[] chArray107 = new char[1]{ ' ' };
      foreach (string move in str107.Split(chArray107))
        openingMove107.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove107);
      OpeningMove openingMove108 = new OpeningMove();
      openingMove108.StartingFEN = "r1bqkb1r/1ppp1ppp/p1n5/4p3/B3n3/5N2/PPPP1PPP/RNBQ1RK1 w kq -";
      string str108 = "d2d4{76}";
      char[] chArray108 = new char[1]{ ' ' };
      foreach (string move in str108.Split(chArray108))
        openingMove108.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove108);
      OpeningMove openingMove109 = new OpeningMove();
      openingMove109.StartingFEN = "r1bqkb1r/2pp1ppp/p1n5/1p2p3/B2Pn3/5N2/PPP2PPP/RNBQ1RK1 w kq b6";
      string str109 = "a4b3{66}";
      char[] chArray109 = new char[1]{ ' ' };
      foreach (string move in str109.Split(chArray109))
        openingMove109.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove109);
      OpeningMove openingMove110 = new OpeningMove();
      openingMove110.StartingFEN = "rnbqk2r/ppp1ppbp/3p1np1/8/2PPPP2/2N5/PP4PP/R1BQKBNR b KQkq f3";
      string str110 = "e8g8{6}";
      char[] chArray110 = new char[1]{ ' ' };
      foreach (string move in str110.Split(chArray110))
        openingMove110.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove110);
      OpeningMove openingMove111 = new OpeningMove();
      openingMove111.StartingFEN = "rnbqkb1r/ppp1pp1p/5np1/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq d6";
      string str111 = "c4d5{146} c1f4{10} g1f3{96} c1g5{10}";
      char[] chArray111 = new char[1]{ ' ' };
      foreach (string move in str111.Split(chArray111))
        openingMove111.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove111);
      OpeningMove openingMove112 = new OpeningMove();
      openingMove112.StartingFEN = "rn1qkbnr/pp2pppp/2p3b1/8/3P4/6N1/PPP2PPP/R1BQKBNR w KQkq -";
      string str112 = "h2h4{50} g1f3{5} g1e2{5}";
      char[] chArray112 = new char[1]{ ' ' };
      foreach (string move in str112.Split(chArray112))
        openingMove112.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove112);
      OpeningMove openingMove113 = new OpeningMove();
      openingMove113.StartingFEN = "r1bqkbnr/pp1npppp/2p5/8/3PN3/8/PPP2PPP/R1BQKBNR w KQkq -";
      string str113 = "f1c4{25} e4g5{64} g1f3{10}";
      char[] chArray113 = new char[1]{ ' ' };
      foreach (string move in str113.Split(chArray113))
        openingMove113.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove113);
      OpeningMove openingMove114 = new OpeningMove();
      openingMove114.StartingFEN = "r1bqkbnr/1ppp1ppp/p1n5/4p3/B3P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
      string str114 = "g8f6{310}";
      char[] chArray114 = new char[1]{ ' ' };
      foreach (string move in str114.Split(chArray114))
        openingMove114.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove114);
      OpeningMove openingMove115 = new OpeningMove();
      openingMove115.StartingFEN = "rnbqkb1r/ppp2ppp/3p4/8/4n3/5N2/PPPP1PPP/RNBQKB1R w KQkq -";
      string str115 = "d2d4{184} b1c3{5} f1d3{10}";
      char[] chArray115 = new char[1]{ ' ' };
      foreach (string move in str115.Split(chArray115))
        openingMove115.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove115);
      OpeningMove openingMove116 = new OpeningMove();
      openingMove116.StartingFEN = "r1bqk2r/2ppbppp/p1n2n2/1p2p3/B3P3/5N2/PPPP1PPP/RNBQR1K1 w kq b6";
      string str116 = "a4b3{311}";
      char[] chArray116 = new char[1]{ ' ' };
      foreach (string move in str116.Split(chArray116))
        openingMove116.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove116);
      OpeningMove openingMove117 = new OpeningMove();
      openingMove117.StartingFEN = "rnbqkb1r/p1pp1ppp/1p2pn2/8/2PP4/5NP1/PP2PP1P/RNBQKB1R b KQkq -";
      string str117 = "c8a6{121} c8b7{20}";
      char[] chArray117 = new char[1]{ ' ' };
      foreach (string move in str117.Split(chArray117))
        openingMove117.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove117);
      OpeningMove openingMove118 = new OpeningMove();
      openingMove118.StartingFEN = "rnbqkb1r/pppppp1p/5np1/8/2PP4/6P1/PP2PP1P/RNBQKBNR b KQkq -";
      string str118 = "f8g7{26} c7c6{20} c7c5{6}";
      char[] chArray118 = new char[1]{ ' ' };
      foreach (string move in str118.Split(chArray118))
        openingMove118.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove118);
      OpeningMove openingMove119 = new OpeningMove();
      openingMove119.StartingFEN = "rnbqkbnr/ppp1pppp/8/3p4/4P3/8/PPPP1PPP/RNBQKBNR w KQkq d6";
      string str119 = "e4d5{15}";
      char[] chArray119 = new char[1]{ ' ' };
      foreach (string move in str119.Split(chArray119))
        openingMove119.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove119);
      OpeningMove openingMove120 = new OpeningMove();
      openingMove120.StartingFEN = "rnbqkb1r/pp2pppp/3p1n2/8/3pP3/2N2N2/PPP2PPP/R1BQKB1R w KQkq -";
      string str120 = "f3d4{21}";
      char[] chArray120 = new char[1]{ ' ' };
      foreach (string move in str120.Split(chArray120))
        openingMove120.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove120);
      OpeningMove openingMove121 = new OpeningMove();
      openingMove121.StartingFEN = "rnbq1rk1/1p2bppp/p2p1n2/4p3/4P3/1NN5/PPP1BPPP/R1BQ1RK1 w - -";
      string str121 = "c1e3{20} g1h1{11}";
      char[] chArray121 = new char[1]{ ' ' };
      foreach (string move in str121.Split(chArray121))
        openingMove121.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove121);
      OpeningMove openingMove122 = new OpeningMove();
      openingMove122.StartingFEN = "rnbqkb1r/ppp2ppp/8/3p4/3Pn3/5N2/PPP2PPP/RNBQKB1R w KQkq -";
      string str122 = "f1d3{174}";
      char[] chArray122 = new char[1]{ ' ' };
      foreach (string move in str122.Split(chArray122))
        openingMove122.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove122);
      OpeningMove openingMove123 = new OpeningMove();
      openingMove123.StartingFEN = "rnbqk2r/ppp1ppbp/3p1np1/8/3PP3/2N2N2/PPP2PPP/R1BQKB1R w KQkq -";
      string str123 = "f1e2{10}";
      char[] chArray123 = new char[1]{ ' ' };
      foreach (string move in str123.Split(chArray123))
        openingMove123.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove123);
      OpeningMove openingMove124 = new OpeningMove();
      openingMove124.StartingFEN = "rnbqkbnr/ppp1pp1p/3p2p1/8/3PP3/8/PPP2PPP/RNBQKBNR w KQkq -";
      string str124 = "b1c3{15}";
      char[] chArray124 = new char[1]{ ' ' };
      foreach (string move in str124.Split(chArray124))
        openingMove124.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove124);
      OpeningMove openingMove125 = new OpeningMove();
      openingMove125.StartingFEN = "r1bqkbnr/pppp1ppp/2n5/4p3/2B1P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
      string str125 = "f8c5{20} g8f6{20}";
      char[] chArray125 = new char[1]{ ' ' };
      foreach (string move in str125.Split(chArray125))
        openingMove125.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove125);
      OpeningMove openingMove126 = new OpeningMove();
      openingMove126.StartingFEN = "rnbqkbnr/pp3ppp/4p3/2pp4/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq c6";
      string str126 = "e2e3{5}";
      char[] chArray126 = new char[1]{ ' ' };
      foreach (string move in str126.Split(chArray126))
        openingMove126.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove126);
      OpeningMove openingMove127 = new OpeningMove();
      openingMove127.StartingFEN = "rnb1kbnr/ppp1pppp/8/3q4/8/8/PPPP1PPP/RNBQKBNR w KQkq -";
      string str127 = "b1c3{10}";
      char[] chArray127 = new char[1]{ ' ' };
      foreach (string move in str127.Split(chArray127))
        openingMove127.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove127);
      OpeningMove openingMove128 = new OpeningMove();
      openingMove128.StartingFEN = "rnbq1rk1/ppp1ppbp/3p1np1/8/2PPP3/2N1BP2/PP4PP/R2QKBNR b KQ -";
      string str128 = "a7a6{11} e7e5{51} c7c5{5}";
      char[] chArray128 = new char[1]{ ' ' };
      foreach (string move in str128.Split(chArray128))
        openingMove128.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove128);
      OpeningMove openingMove129 = new OpeningMove();
      openingMove129.StartingFEN = "rnbqkb1r/ppp2ppp/3p1n2/8/4P3/5N2/PPPP1PPP/RNBQKB1R b KQkq -";
      string str129 = "f6e4{125}";
      char[] chArray129 = new char[1]{ ' ' };
      foreach (string move in str129.Split(chArray129))
        openingMove129.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove129);
      OpeningMove openingMove130 = new OpeningMove();
      openingMove130.StartingFEN = "rnbqkb1r/pp1ppppp/5n2/2p5/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq c6";
      string str130 = "b1c3{70} g2g3{15}";
      char[] chArray130 = new char[1]{ ' ' };
      foreach (string move in str130.Split(chArray130))
        openingMove130.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove130);
      OpeningMove openingMove131 = new OpeningMove();
      openingMove131.StartingFEN = "rn1qkbnr/pp2ppp1/2p3bp/8/3P3P/6N1/PPP2PP1/R1BQKBNR w KQkq -";
      string str131 = "g1f3{40}";
      char[] chArray131 = new char[1]{ ' ' };
      foreach (string move in str131.Split(chArray131))
        openingMove131.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove131);
      OpeningMove openingMove132 = new OpeningMove();
      openingMove132.StartingFEN = "rnbqkbnr/pp1p1ppp/4p3/2p5/4P3/3P1N2/PPP2PPP/RNBQKB1R b KQkq -";
      string str132 = "b8c6{6}";
      char[] chArray132 = new char[1]{ ' ' };
      foreach (string move in str132.Split(chArray132))
        openingMove132.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove132);
      OpeningMove openingMove133 = new OpeningMove();
      openingMove133.StartingFEN = "r2qkbnr/pp1nppp1/2p3bp/8/3P3P/5NN1/PPP2PP1/R1BQKB1R w KQkq -";
      string str133 = "h4h5{10}";
      char[] chArray133 = new char[1]{ ' ' };
      foreach (string move in str133.Split(chArray133))
        openingMove133.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove133);
      OpeningMove openingMove134 = new OpeningMove();
      openingMove134.StartingFEN = "rnbqkb1r/pppppppp/5n2/8/2P5/5N2/PP1PPPPP/RNBQKB1R b KQkq c3";
      string str134 = "b7b6{30} c7c5{36} g7g6{119} e7e6{75} c7c6{10}";
      char[] chArray134 = new char[1]{ ' ' };
      foreach (string move in str134.Split(chArray134))
        openingMove134.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove134);
      OpeningMove openingMove135 = new OpeningMove();
      openingMove135.StartingFEN = "rn1qkb1r/p1pp1ppp/bp2pn2/8/2PP4/1P3NP1/P3PP1P/RNBQKB1R b KQkq -";
      string str135 = "f8b4{60} a6b7{20} b6b5{5} d7d5{6}";
      char[] chArray135 = new char[1]{ ' ' };
      foreach (string move in str135.Split(chArray135))
        openingMove135.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove135);
      OpeningMove openingMove136 = new OpeningMove();
      openingMove136.StartingFEN = "rnbqkbnr/pp3ppp/4p3/2pp4/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq c6";
      string str136 = "c4d5{11}";
      char[] chArray136 = new char[1]{ ' ' };
      foreach (string move in str136.Split(chArray136))
        openingMove136.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove136);
      OpeningMove openingMove137 = new OpeningMove();
      openingMove137.StartingFEN = "rnbqkb1r/pppppp1p/5np1/8/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
      string str137 = "b1c3{142} d2d4{5} g2g3{25}";
      char[] chArray137 = new char[1]{ ' ' };
      foreach (string move in str137.Split(chArray137))
        openingMove137.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove137);
      OpeningMove openingMove138 = new OpeningMove();
      openingMove138.StartingFEN = "r1bqk2r/2p1bppp/p1np1n2/1p2p3/4P3/1B3N2/PPPP1PPP/RNBQR1K1 w kq -";
      string str138 = "c2c3{168}";
      char[] chArray138 = new char[1]{ ' ' };
      foreach (string move in str138.Split(chArray138))
        openingMove138.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove138);
      OpeningMove openingMove139 = new OpeningMove();
      openingMove139.StartingFEN = "rnbqkb1r/pppppppp/5n2/8/3P4/5N2/PPP1PPPP/RNBQKB1R b KQkq -";
      string str139 = "e7e6{71} g7g6{111} c7c6{6} d7d5{31} c7c5{25}";
      char[] chArray139 = new char[1]{ ' ' };
      foreach (string move in str139.Split(chArray139))
        openingMove139.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove139);
      OpeningMove openingMove140 = new OpeningMove();
      openingMove140.StartingFEN = "r1bqkbnr/pppp1ppp/2n5/8/3NP3/8/PPP2PPP/RNBQKB1R b KQkq -";
      string str140 = "g8f6{15} f8c5{10}";
      char[] chArray140 = new char[1]{ ' ' };
      foreach (string move in str140.Split(chArray140))
        openingMove140.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove140);
      OpeningMove openingMove141 = new OpeningMove();
      openingMove141.StartingFEN = "rn1qkb1r/p1pp1ppp/bp2pn2/8/2PP4/5NP1/PP2PP1P/RNBQKB1R w KQkq -";
      string str141 = "b2b3{196} d1a4{10} b1d2{5}";
      char[] chArray141 = new char[1]{ ' ' };
      foreach (string move in str141.Split(chArray141))
        openingMove141.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove141);
      OpeningMove openingMove142 = new OpeningMove();
      openingMove142.StartingFEN = "r1bqkbnr/pppppppp/2n5/8/4P3/8/PPPP1PPP/RNBQKBNR w KQkq -";
      string str142 = "g1f3{10}";
      char[] chArray142 = new char[1]{ ' ' };
      foreach (string move in str142.Split(chArray142))
        openingMove142.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove142);
      OpeningMove openingMove143 = new OpeningMove();
      openingMove143.StartingFEN = "rnbqkb1r/pp2pp1p/2p2p2/8/3P4/8/PPP2PPP/R1BQKBNR w KQkq -";
      string str143 = "c2c3{5}";
      char[] chArray143 = new char[1]{ ' ' };
      foreach (string move in str143.Split(chArray143))
        openingMove143.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove143);
      OpeningMove openingMove144 = new OpeningMove();
      openingMove144.StartingFEN = "rnbqk2r/pppp1ppp/4pn2/8/2PP4/5N2/PP1bPPPP/RN1QKB1R w KQkq -";
      string str144 = "d1d2{16}";
      char[] chArray144 = new char[1]{ ' ' };
      foreach (string move in str144.Split(chArray144))
        openingMove144.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove144);
      OpeningMove openingMove145 = new OpeningMove();
      openingMove145.StartingFEN = "rnbqk2r/ppp1bppp/4pn2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str145 = "c1g5{138} d1c2{10} c4d5{5} c1f4{41} g2g3{5}";
      char[] chArray145 = new char[1]{ ' ' };
      foreach (string move in str145.Split(chArray145))
        openingMove145.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove145);
      OpeningMove openingMove146 = new OpeningMove();
      openingMove146.StartingFEN = "rnbqkbnr/ppp1pppp/8/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R b KQkq -";
      string str146 = "c7c5{6} g8f6{16} c7c6{5} e7e6{10}";
      char[] chArray146 = new char[1]{ ' ' };
      foreach (string move in str146.Split(chArray146))
        openingMove146.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove146);
      OpeningMove openingMove147 = new OpeningMove();
      openingMove147.StartingFEN = "rn1q1rk1/1p2bppp/p2pbn2/4p3/4P3/1NN1B3/PPP1BPPP/R2Q1RK1 w - -";
      string str147 = "d1d2{10} c3d5{5}";
      char[] chArray147 = new char[1]{ ' ' };
      foreach (string move in str147.Split(chArray147))
        openingMove147.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove147);
      OpeningMove openingMove148 = new OpeningMove();
      openingMove148.StartingFEN = "rnbqkb1r/ppp2ppp/3p4/8/3Pn3/5N2/PPP2PPP/RNBQKB1R b KQkq d3";
      string str148 = "d6d5{105}";
      char[] chArray148 = new char[1]{ ' ' };
      foreach (string move in str148.Split(chArray148))
        openingMove148.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove148);
      OpeningMove openingMove149 = new OpeningMove();
      openingMove149.StartingFEN = "rnbqkbnr/ppp1pppp/8/3p4/2PP4/8/PP2PPPP/RNBQKBNR b KQkq c3";
      string str149 = "e7e6{96} c7c6{247} d5c4{85} b8c6{20}";
      char[] chArray149 = new char[1]{ ' ' };
      foreach (string move in str149.Split(chArray149))
        openingMove149.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove149);
      OpeningMove openingMove150 = new OpeningMove();
      openingMove150.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR b KQkq -";
      string str150 = "f8e7{66} c7c5{5} c7c6{15}";
      char[] chArray150 = new char[1]{ ' ' };
      foreach (string move in str150.Split(chArray150))
        openingMove150.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove150);
      OpeningMove openingMove151 = new OpeningMove();
      openingMove151.StartingFEN = "rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/1P3NP1/P3PP1P/RNBQKB1R w KQkq -";
      string str151 = "f1g2{66}";
      char[] chArray151 = new char[1]{ ' ' };
      foreach (string move in str151.Split(chArray151))
        openingMove151.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove151);
      OpeningMove openingMove152 = new OpeningMove();
      openingMove152.StartingFEN = "rnbqk2r/p1pp1ppp/1p2pn2/8/1bPP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str152 = "c1g5{27} d1c2{5}";
      char[] chArray152 = new char[1]{ ' ' };
      foreach (string move in str152.Split(chArray152))
        openingMove152.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove152);
      OpeningMove openingMove153 = new OpeningMove();
      openingMove153.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
      string str153 = "c7c6{21} d5c4{10} b8d7{25} f8e7{42}";
      char[] chArray153 = new char[1]{ ' ' };
      foreach (string move in str153.Split(chArray153))
        openingMove153.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove153);
      OpeningMove openingMove154 = new OpeningMove();
      openingMove154.StartingFEN = "rnbqkbnr/pp3ppp/2p1p3/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
      string str154 = "e2e4{5} e2e3{5}";
      char[] chArray154 = new char[1]{ ' ' };
      foreach (string move in str154.Split(chArray154))
        openingMove154.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove154);
      OpeningMove openingMove155 = new OpeningMove();
      openingMove155.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/3p4/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq d6";
      string str155 = "d2d4{26}";
      char[] chArray155 = new char[1]{ ' ' };
      foreach (string move in str155.Split(chArray155))
        openingMove155.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove155);
      OpeningMove openingMove156 = new OpeningMove();
      openingMove156.StartingFEN = "rnbqk1nr/ppp1bppp/4p3/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
      string str156 = "g1f3{65} c4d5{40} c1f4{5}";
      char[] chArray156 = new char[1]{ ' ' };
      foreach (string move in str156.Split(chArray156))
        openingMove156.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove156);
      OpeningMove openingMove157 = new OpeningMove();
      openingMove157.StartingFEN = "r1bqkb1r/1ppp1ppp/p1n2n2/4p3/B3P3/5N2/PPPP1PPP/RNBQ1RK1 b kq -";
      string str157 = "f8e7{185} f6e4{35} b7b5{35} f8c5{40}";
      char[] chArray157 = new char[1]{ ' ' };
      foreach (string move in str157.Split(chArray157))
        openingMove157.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove157);
      OpeningMove openingMove158 = new OpeningMove();
      openingMove158.StartingFEN = "r1bqkb1r/pp3ppp/2nppn2/6B1/3NP3/2N5/PPP2PPP/R2QKB1R w KQkq -";
      string str158 = "d1d2{76}";
      char[] chArray158 = new char[1]{ ' ' };
      foreach (string move in str158.Split(chArray158))
        openingMove158.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove158);
      OpeningMove openingMove159 = new OpeningMove();
      openingMove159.StartingFEN = "rnbq1rk1/ppp1bppp/4pn2/3p2B1/2PP4/2N2N2/PP2PPPP/R2QKB1R w KQ -";
      string str159 = "e2e3{37} d1c2{5} c4d5{5}";
      char[] chArray159 = new char[1]{ ' ' };
      foreach (string move in str159.Split(chArray159))
        openingMove159.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove159);
      OpeningMove openingMove160 = new OpeningMove();
      openingMove160.StartingFEN = "rn1qk2r/pbpp1ppp/1p2pn2/8/1bPP4/1P3NP1/P3PPBP/RNBQK2R w KQkq -";
      string str160 = "c1d2{60}";
      char[] chArray160 = new char[1]{ ' ' };
      foreach (string move in str160.Split(chArray160))
        openingMove160.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove160);
      OpeningMove openingMove161 = new OpeningMove();
      openingMove161.StartingFEN = "rnbqk2r/pppp1ppp/4pn2/8/1bPP4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
      string str161 = "g1f3{47} e2e3{66} d1c2{167} c1g5{5}";
      char[] chArray161 = new char[1]{ ' ' };
      foreach (string move in str161.Split(chArray161))
        openingMove161.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove161);
      OpeningMove openingMove162 = new OpeningMove();
      openingMove162.StartingFEN = "rnbqkbnr/pp2pppp/3p4/2p5/3PP3/5N2/PPP2PPP/RNBQKB1R b KQkq d3";
      string str162 = "c5d4{605} g8f6{5}";
      char[] chArray162 = new char[1]{ ' ' };
      foreach (string move in str162.Split(chArray162))
        openingMove162.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove162);
      OpeningMove openingMove163 = new OpeningMove();
      openingMove163.StartingFEN = "rnbqk2r/ppp1bpp1/4pn1p/3p2B1/2PP4/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
      string str163 = "g5f6{30} g5h4{50}";
      char[] chArray163 = new char[1]{ ' ' };
      foreach (string move in str163.Split(chArray163))
        openingMove163.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove163);
      OpeningMove openingMove164 = new OpeningMove();
      openingMove164.StartingFEN = "r1bqk2r/1pppbppp/p1n2n2/4p3/B3P3/5N2/PPPP1PPP/RNBQR1K1 b kq -";
      string str164 = "b7b5{175}";
      char[] chArray164 = new char[1]{ ' ' };
      foreach (string move in str164.Split(chArray164))
        openingMove164.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove164);
      OpeningMove openingMove165 = new OpeningMove();
      openingMove165.StartingFEN = "rnbqk1nr/ppp1bppp/4p3/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
      string str165 = "g8f6{46}";
      char[] chArray165 = new char[1]{ ' ' };
      foreach (string move in str165.Split(chArray165))
        openingMove165.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove165);
      OpeningMove openingMove166 = new OpeningMove();
      openingMove166.StartingFEN = "rnbqk2r/pppp1ppp/4pn2/8/1bPP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
      string str166 = "e8g8{5} c7c5{25}";
      char[] chArray166 = new char[1]{ ' ' };
      foreach (string move in str166.Split(chArray166))
        openingMove166.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove166);
      OpeningMove openingMove167 = new OpeningMove();
      openingMove167.StartingFEN = "rnbqk2r/ppp1bppp/4pn2/3p2B1/2PP4/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
      string str167 = "h7h6{41} e8g8{6}";
      char[] chArray167 = new char[1]{ ' ' };
      foreach (string move in str167.Split(chArray167))
        openingMove167.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove167);
      OpeningMove openingMove168 = new OpeningMove();
      openingMove168.StartingFEN = "r1bqk2r/2ppbppp/p1n2n2/1p2p3/4P3/1B3N2/PPPP1PPP/RNBQR1K1 b kq -";
      string str168 = "d7d6{100} e8g8{70}";
      char[] chArray168 = new char[1]{ ' ' };
      foreach (string move in str168.Split(chArray168))
        openingMove168.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove168);
      OpeningMove openingMove169 = new OpeningMove();
      openingMove169.StartingFEN = "rnbqkbnr/pp2pppp/3p4/8/3NP3/8/PPP2PPP/RNBQKB1R b KQkq -";
      string str169 = "g8f6{589}";
      char[] chArray169 = new char[1]{ ' ' };
      foreach (string move in str169.Split(chArray169))
        openingMove169.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove169);
      OpeningMove openingMove170 = new OpeningMove();
      openingMove170.StartingFEN = "rnbqkbnr/pp1p1ppp/4p3/2p5/3PP3/5N2/PPP2PPP/RNBQKB1R b KQkq d3";
      string str170 = "c5d4{110}";
      char[] chArray170 = new char[1]{ ' ' };
      foreach (string move in str170.Split(chArray170))
        openingMove170.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove170);
      OpeningMove openingMove171 = new OpeningMove();
      openingMove171.StartingFEN = "rnbqkbnr/pp1p1ppp/4p3/8/3NP3/8/PPP2PPP/RNBQKB1R b KQkq -";
      string str171 = "b8c6{46} g8f6{48} a7a6{11}";
      char[] chArray171 = new char[1]{ ' ' };
      foreach (string move in str171.Split(chArray171))
        openingMove171.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove171);
      OpeningMove openingMove172 = new OpeningMove();
      openingMove172.StartingFEN = "rnbqk2r/pppp1ppp/4p3/8/1bPPn3/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str172 = "d1c2{5}";
      char[] chArray172 = new char[1]{ ' ' };
      foreach (string move in str172.Split(chArray172))
        openingMove172.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove172);
      OpeningMove openingMove173 = new OpeningMove();
      openingMove173.StartingFEN = "rnbqk1nr/ppp1bppp/8/3p4/3P4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
      string str173 = "c1f4{30}";
      char[] chArray173 = new char[1]{ ' ' };
      foreach (string move in str173.Split(chArray173))
        openingMove173.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove173);
      OpeningMove openingMove174 = new OpeningMove();
      openingMove174.StartingFEN = "rnbqk2r/ppp1bpp1/4pB1p/3p4/2PP4/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
      string str174 = "e7f6{15}";
      char[] chArray174 = new char[1]{ ' ' };
      foreach (string move in str174.Split(chArray174))
        openingMove174.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove174);
      OpeningMove openingMove175 = new OpeningMove();
      openingMove175.StartingFEN = "rnbqkb1r/pp2pppp/3p1n2/8/3NP3/2N5/PPP2PPP/R1BQKB1R b KQkq -";
      string str175 = "a7a6{464} b8c6{75} g7g6{40} e7e6{5}";
      char[] chArray175 = new char[1]{ ' ' };
      foreach (string move in str175.Split(chArray175))
        openingMove175.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove175);
      OpeningMove openingMove176 = new OpeningMove();
      openingMove176.StartingFEN = "r1bqk2r/2p1bppp/p1np1n2/1p2p3/4P3/1BP2N2/PP1P1PPP/RNBQR1K1 b kq -";
      string str176 = "e8g8{95}";
      char[] chArray176 = new char[1]{ ' ' };
      foreach (string move in str176.Split(chArray176))
        openingMove176.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove176);
      OpeningMove openingMove177 = new OpeningMove();
      openingMove177.StartingFEN = "rn1qk2r/pbpp1ppp/1p2pn2/6B1/1bPP4/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
      string str177 = "e2e3{21}";
      char[] chArray177 = new char[1]{ ' ' };
      foreach (string move in str177.Split(chArray177))
        openingMove177.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove177);
      OpeningMove openingMove178 = new OpeningMove();
      openingMove178.StartingFEN = "rnbqkb1r/pp1ppppp/5n2/2p5/2PP4/8/PP2PPPP/RNBQKBNR w KQkq c6";
      string str178 = "d4d5{36} g1f3{15}";
      char[] chArray178 = new char[1]{ ' ' };
      foreach (string move in str178.Split(chArray178))
        openingMove178.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove178);
      OpeningMove openingMove179 = new OpeningMove();
      openingMove179.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/3p4/3PP3/8/PPPN1PPP/R1BQKBNR w KQkq -";
      string str179 = "e4e5{10}";
      char[] chArray179 = new char[1]{ ' ' };
      foreach (string move in str179.Split(chArray179))
        openingMove179.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove179);
      OpeningMove openingMove180 = new OpeningMove();
      openingMove180.StartingFEN = "r1bqkbnr/pppp1ppp/2n5/4p3/2P5/2N5/PP1PPPPP/R1BQKBNR w KQkq -";
      string str180 = "g2g3{11}";
      char[] chArray180 = new char[1]{ ' ' };
      foreach (string move in str180.Split(chArray180))
        openingMove180.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove180);
      OpeningMove openingMove181 = new OpeningMove();
      openingMove181.StartingFEN = "r1bqkbnr/pppp1p1p/2n3p1/1B2p3/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str181 = "c2c3{10}";
      char[] chArray181 = new char[1]{ ' ' };
      foreach (string move in str181.Split(chArray181))
        openingMove181.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove181);
      OpeningMove openingMove182 = new OpeningMove();
      openingMove182.StartingFEN = "rn1qk2r/pbpp1pp1/1p2pn1p/6B1/1bPP4/2N1PN2/PP3PPP/R2QKB1R w KQkq -";
      string str182 = "g5h4{11}";
      char[] chArray182 = new char[1]{ ' ' };
      foreach (string move in str182.Split(chArray182))
        openingMove182.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove182);
      OpeningMove openingMove183 = new OpeningMove();
      openingMove183.StartingFEN = "rnbqkb1r/p2p1ppp/1p2pn2/2p5/2P5/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq -";
      string str183 = "f1g2{25}";
      char[] chArray183 = new char[1]{ ' ' };
      foreach (string move in str183.Split(chArray183))
        openingMove183.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove183);
      OpeningMove openingMove184 = new OpeningMove();
      openingMove184.StartingFEN = "rnbqkbnr/ppp1pppp/8/3p4/3P4/2N5/PPP1PPPP/R1BQKBNR b KQkq -";
      string str184 = "g8f6{5}";
      char[] chArray184 = new char[1]{ ' ' };
      foreach (string move in str184.Split(chArray184))
        openingMove184.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove184);
      OpeningMove openingMove185 = new OpeningMove();
      openingMove185.StartingFEN = "rn1qk2r/p1pp1ppp/bp2pn2/8/1bPP4/1P3NP1/P3PP1P/RNBQKB1R w KQkq -";
      string str185 = "c1d2{100}";
      char[] chArray185 = new char[1]{ ' ' };
      foreach (string move in str185.Split(chArray185))
        openingMove185.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove185);
      OpeningMove openingMove186 = new OpeningMove();
      openingMove186.StartingFEN = "rnbqkb1r/p1pp1ppp/1p2pn2/8/2PP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
      string str186 = "f8b4{31} c8b7{10}";
      char[] chArray186 = new char[1]{ ' ' };
      foreach (string move in str186.Split(chArray186))
        openingMove186.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove186);
      OpeningMove openingMove187 = new OpeningMove();
      openingMove187.StartingFEN = "rnbqk1nr/ppp1bppp/4p3/3P4/3P4/2N5/PP2PPPP/R1BQKBNR b KQkq -";
      string str187 = "e6d5{16}";
      char[] chArray187 = new char[1]{ ' ' };
      foreach (string move in str187.Split(chArray187))
        openingMove187.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove187);
      OpeningMove openingMove188 = new OpeningMove();
      openingMove188.StartingFEN = "rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq c6";
      string str188 = "g2g3{27}";
      char[] chArray188 = new char[1]{ ' ' };
      foreach (string move in str188.Split(chArray188))
        openingMove188.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove188);
      OpeningMove openingMove189 = new OpeningMove();
      openingMove189.StartingFEN = "rnbqkb1r/pp1p1ppp/4pn2/2p5/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq c6";
      string str189 = "d4d5{51} e2e3{5}";
      char[] chArray189 = new char[1]{ ' ' };
      foreach (string move in str189.Split(chArray189))
        openingMove189.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove189);
      OpeningMove openingMove190 = new OpeningMove();
      openingMove190.StartingFEN = "rnbqkb1r/ppp1pppp/5n2/3p4/8/5NP1/PPPPPPBP/RNBQK2R b KQkq -";
      string str190 = "c7c6{10} e7e6{5} g7g6{5}";
      char[] chArray190 = new char[1]{ ' ' };
      foreach (string move in str190.Split(chArray190))
        openingMove190.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove190);
      OpeningMove openingMove191 = new OpeningMove();
      openingMove191.StartingFEN = "rnbqk2r/ppp1ppbp/5np1/3p4/Q1PP4/2N2N2/PP2PPPP/R1B1KB1R b KQkq -";
      string str191 = "c8d7{6}";
      char[] chArray191 = new char[1]{ ' ' };
      foreach (string move in str191.Split(chArray191))
        openingMove191.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove191);
      OpeningMove openingMove192 = new OpeningMove();
      openingMove192.StartingFEN = "r1bq1rk1/pppnbppp/4pn2/3p2B1/2PP4/2N1PN2/PP3PPP/R2QKB1R w KQ -";
      string str192 = "d1c2{6} a1c1{5}";
      char[] chArray192 = new char[1]{ ' ' };
      foreach (string move in str192.Split(chArray192))
        openingMove192.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove192);
      OpeningMove openingMove193 = new OpeningMove();
      openingMove193.StartingFEN = "rnbqkbnr/pppp1ppp/4p3/8/3P4/8/PPP1PPPP/RNBQKBNR w KQkq -";
      string str193 = "g1f3{16} g2g3{11} e2e4{10} c2c4{20}";
      char[] chArray193 = new char[1]{ ' ' };
      foreach (string move in str193.Split(chArray193))
        openingMove193.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove193);
      OpeningMove openingMove194 = new OpeningMove();
      openingMove194.StartingFEN = "rnbqkb1r/1p2pppp/p2p1n2/6B1/3NP3/2N5/PPP2PPP/R2QKB1R b KQkq -";
      string str194 = "e7e6{57}";
      char[] chArray194 = new char[1]{ ' ' };
      foreach (string move in str194.Split(chArray194))
        openingMove194.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove194);
      OpeningMove openingMove195 = new OpeningMove();
      openingMove195.StartingFEN = "rnbqkbnr/pp2pppp/2p5/8/3Pp3/2N5/PPP2PPP/R1BQKBNR w KQkq -";
      string str195 = "c3e4{60}";
      char[] chArray195 = new char[1]{ ' ' };
      foreach (string move in str195.Split(chArray195))
        openingMove195.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove195);
      OpeningMove openingMove196 = new OpeningMove();
      openingMove196.StartingFEN = "rnbqkb1r/pp1ppppp/5n2/2p5/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq c6";
      string str196 = "c2c4{5} d4d5{21}";
      char[] chArray196 = new char[1]{ ' ' };
      foreach (string move in str196.Split(chArray196))
        openingMove196.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove196);
      OpeningMove openingMove197 = new OpeningMove();
      openingMove197.StartingFEN = "rnbqk2r/ppp1bppp/8/3p4/3Pn3/3B1N2/PPP2PPP/RNBQK2R w KQkq -";
      string str197 = "e1g1{26}";
      char[] chArray197 = new char[1]{ ' ' };
      foreach (string move in str197.Split(chArray197))
        openingMove197.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove197);
      OpeningMove openingMove198 = new OpeningMove();
      openingMove198.StartingFEN = "rnbqkb1r/p1pppppp/1p3n2/8/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
      string str198 = "g2g3{55} d2d4{5} b1c3{5}";
      char[] chArray198 = new char[1]{ ' ' };
      foreach (string move in str198.Split(chArray198))
        openingMove198.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove198);
      OpeningMove openingMove199 = new OpeningMove();
      openingMove199.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/6P1/PP2PP1P/RNBQKBNR w KQkq d6";
      string str199 = "f1g2{25} g1f3{10}";
      char[] chArray199 = new char[1]{ ' ' };
      foreach (string move in str199.Split(chArray199))
        openingMove199.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove199);
      OpeningMove openingMove200 = new OpeningMove();
      openingMove200.StartingFEN = "rnbqk2r/pppp1ppp/4pn2/8/1bPP4/6P1/PP2PP1P/RNBQKBNR w KQkq -";
      string str200 = "c1d2{15}";
      char[] chArray200 = new char[1]{ ' ' };
      foreach (string move in str200.Split(chArray200))
        openingMove200.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove200);
      OpeningMove openingMove201 = new OpeningMove();
      openingMove201.StartingFEN = "rnbqkb1r/ppp2ppp/3p1n2/8/4P3/3N4/PPPP1PPP/RNBQKB1R b KQkq -";
      string str201 = "f6e4{5}";
      char[] chArray201 = new char[1]{ ' ' };
      foreach (string move in str201.Split(chArray201))
        openingMove201.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove201);
      OpeningMove openingMove202 = new OpeningMove();
      openingMove202.StartingFEN = "rnbqkb1r/ppp1pppp/5n2/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
      string str202 = "c2c4{141}";
      char[] chArray202 = new char[1]{ ' ' };
      foreach (string move in str202.Split(chArray202))
        openingMove202.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove202);
      OpeningMove openingMove203 = new OpeningMove();
      openingMove203.StartingFEN = "rnbqkbnr/pp2pppp/2p5/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR b KQkq -";
      string str203 = "g8f6{95}";
      char[] chArray203 = new char[1]{ ' ' };
      foreach (string move in str203.Split(chArray203))
        openingMove203.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove203);
      OpeningMove openingMove204 = new OpeningMove();
      openingMove204.StartingFEN = "rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/2N2NP1/PP2PP1P/R1BQKB1R b KQkq -";
      string str204 = "b8c6{5} c5d4{10}";
      char[] chArray204 = new char[1]{ ' ' };
      foreach (string move in str204.Split(chArray204))
        openingMove204.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove204);
      OpeningMove openingMove205 = new OpeningMove();
      openingMove205.StartingFEN = "rnbqk2r/pp1p1ppp/4pn2/8/1bPp4/2N2NP1/PP2PP1P/R1BQKB1R w KQkq -";
      string str205 = "f3d4{10}";
      char[] chArray205 = new char[1]{ ' ' };
      foreach (string move in str205.Split(chArray205))
        openingMove205.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove205);
      OpeningMove openingMove206 = new OpeningMove();
      openingMove206.StartingFEN = "rnbqkb1r/ppp2ppp/8/3p4/3Pn3/3B1N2/PPP2PPP/RNBQK2R b KQkq -";
      string str206 = "b8c6{65} f8e7{15} f8d6{20}";
      char[] chArray206 = new char[1]{ ' ' };
      foreach (string move in str206.Split(chArray206))
        openingMove206.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove206);
      OpeningMove openingMove207 = new OpeningMove();
      openingMove207.StartingFEN = "rnbqk1nr/ppp1bppp/8/3p4/3P1B2/2N5/PP2PPPP/R2QKBNR b KQkq -";
      string str207 = "c7c6{5} g8f6{6}";
      char[] chArray207 = new char[1]{ ' ' };
      foreach (string move in str207.Split(chArray207))
        openingMove207.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove207);
      OpeningMove openingMove208 = new OpeningMove();
      openingMove208.StartingFEN = "rnbqk2r/ppp1bppp/5n2/3p4/3P1B2/2N5/PP2PPPP/R2QKBNR w KQkq -";
      string str208 = "e2e3{5}";
      char[] chArray208 = new char[1]{ ' ' };
      foreach (string move in str208.Split(chArray208))
        openingMove208.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove208);
      OpeningMove openingMove209 = new OpeningMove();
      openingMove209.StartingFEN = "rnbqk2r/ppp2pp1/4pb1p/3p4/2PP4/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
      string str209 = "e2e3{20}";
      char[] chArray209 = new char[1]{ ' ' };
      foreach (string move in str209.Split(chArray209))
        openingMove209.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove209);
      OpeningMove openingMove210 = new OpeningMove();
      openingMove210.StartingFEN = "rnbqkb1r/ppp1pp1p/5np1/3p4/2PP1B2/2N5/PP2PPPP/R2QKBNR b KQkq -";
      string str210 = "f8g7{16}";
      char[] chArray210 = new char[1]{ ' ' };
      foreach (string move in str210.Split(chArray210))
        openingMove210.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove210);
      OpeningMove openingMove211 = new OpeningMove();
      openingMove211.StartingFEN = "rnbqk2r/ppp2pp1/4pb1p/3p4/2PP4/2N1PN2/PP3PPP/R2QKB1R b KQkq -";
      string str211 = "e8g8{5}";
      char[] chArray211 = new char[1]{ ' ' };
      foreach (string move in str211.Split(chArray211))
        openingMove211.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove211);
      OpeningMove openingMove212 = new OpeningMove();
      openingMove212.StartingFEN = "rnbqkb1r/pppppp1p/5np1/8/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq -";
      string str212 = "f8g7{44}";
      char[] chArray212 = new char[1]{ ' ' };
      foreach (string move in str212.Split(chArray212))
        openingMove212.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove212);
      OpeningMove openingMove213 = new OpeningMove();
      openingMove213.StartingFEN = "r1bq1rk1/2p1bppp/p1np1n2/1p2p3/4P3/1BP2N2/PP1P1PPP/RNBQR1K1 w - -";
      string str213 = "h2h3{163}";
      char[] chArray213 = new char[1]{ ' ' };
      foreach (string move in str213.Split(chArray213))
        openingMove213.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove213);
      OpeningMove openingMove214 = new OpeningMove();
      openingMove214.StartingFEN = "r2q1rk1/1bp1bppp/p1np1n2/1p2p3/4P3/1BP2N1P/PP1P1PP1/RNBQR1K1 w - -";
      string str214 = "d2d4{72}";
      char[] chArray214 = new char[1]{ ' ' };
      foreach (string move in str214.Split(chArray214))
        openingMove214.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove214);
      OpeningMove openingMove215 = new OpeningMove();
      openingMove215.StartingFEN = "rnbqk2r/ppp1ppbp/5np1/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str215 = "d1b3{71} c4d5{10} c1f4{10}";
      char[] chArray215 = new char[1]{ ' ' };
      foreach (string move in str215.Split(chArray215))
        openingMove215.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove215);
      OpeningMove openingMove216 = new OpeningMove();
      openingMove216.StartingFEN = "rnbqk2r/p1pp1ppp/1p2pn2/6B1/1bPP4/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
      string str216 = "c8b7{10}";
      char[] chArray216 = new char[1]{ ' ' };
      foreach (string move in str216.Split(chArray216))
        openingMove216.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove216);
      OpeningMove openingMove217 = new OpeningMove();
      openingMove217.StartingFEN = "rnbqk2r/ppp1ppbp/5np1/8/2pP4/1QN2N2/PP2PPPP/R1B1KB1R w KQkq -";
      string str217 = "b3c4{61}";
      char[] chArray217 = new char[1]{ ' ' };
      foreach (string move in str217.Split(chArray217))
        openingMove217.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove217);
      OpeningMove openingMove218 = new OpeningMove();
      openingMove218.StartingFEN = "rn1qk2r/p1pp1ppp/bp2pn2/8/1bPP4/1P3NP1/P2BPP1P/RN1QKB1R b KQkq -";
      string str218 = "b4e7{50}";
      char[] chArray218 = new char[1]{ ' ' };
      foreach (string move in str218.Split(chArray218))
        openingMove218.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove218);
      OpeningMove openingMove219 = new OpeningMove();
      openingMove219.StartingFEN = "rnbq1rk1/ppp2pp1/4pb1p/3p4/2PP4/2N1PN2/PP3PPP/R2QKB1R w KQ -";
      string str219 = "a1c1{10}";
      char[] chArray219 = new char[1]{ ' ' };
      foreach (string move in str219.Split(chArray219))
        openingMove219.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove219);
      OpeningMove openingMove220 = new OpeningMove();
      openingMove220.StartingFEN = "rnbqkb1r/p1pppppp/1p3n2/8/2P5/5NP1/PP1PPP1P/RNBQKB1R b KQkq -";
      string str220 = "c7c5{15} e7e6{5} c8b7{5}";
      char[] chArray220 = new char[1]{ ' ' };
      foreach (string move in str220.Split(chArray220))
        openingMove220.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove220);
      OpeningMove openingMove221 = new OpeningMove();
      openingMove221.StartingFEN = "rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/5NP1/PP2PP1P/RNBQKB1R w KQkq -";
      string str221 = "f1g2{45}";
      char[] chArray221 = new char[1]{ ' ' };
      foreach (string move in str221.Split(chArray221))
        openingMove221.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove221);
      OpeningMove openingMove222 = new OpeningMove();
      openingMove222.StartingFEN = "rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/5N2/PP1BPPPP/RN1QKB1R w KQkq c6";
      string str222 = "d2b4{5}";
      char[] chArray222 = new char[1]{ ' ' };
      foreach (string move in str222.Split(chArray222))
        openingMove222.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove222);
      OpeningMove openingMove223 = new OpeningMove();
      openingMove223.StartingFEN = "r1bqkbnr/pppp1ppp/2n5/4p3/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq e6";
      string str223 = "f1b5{5}";
      char[] chArray223 = new char[1]{ ' ' };
      foreach (string move in str223.Split(chArray223))
        openingMove223.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove223);
      OpeningMove openingMove224 = new OpeningMove();
      openingMove224.StartingFEN = "rnbqk2r/ppppppbp/5np1/8/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
      string str224 = "e2e4{177}";
      char[] chArray224 = new char[1]{ ' ' };
      foreach (string move in str224.Split(chArray224))
        openingMove224.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove224);
      OpeningMove openingMove225 = new OpeningMove();
      openingMove225.StartingFEN = "r1bqkb1r/pp1p1ppp/2n1pn2/2p5/2P5/2N1PN2/PP1P1PPP/R1BQKB1R w KQkq -";
      string str225 = "d2d4{10}";
      char[] chArray225 = new char[1]{ ' ' };
      foreach (string move in str225.Split(chArray225))
        openingMove225.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove225);
      OpeningMove openingMove226 = new OpeningMove();
      openingMove226.StartingFEN = "rn1qk2r/p1ppbppp/bp2pn2/8/2PP4/1P3NP1/P2BPP1P/RN1QKB1R w KQkq -";
      string str226 = "b1c3{25} f1g2{65}";
      char[] chArray226 = new char[1]{ ' ' };
      foreach (string move in str226.Split(chArray226))
        openingMove226.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove226);
      OpeningMove openingMove227 = new OpeningMove();
      openingMove227.StartingFEN = "rnbqkbnr/pp2pppp/2p5/3P4/2P5/8/PP1P1PPP/RNBQKBNR b KQkq -";
      string str227 = "c6d5{5}";
      char[] chArray227 = new char[1]{ ' ' };
      foreach (string move in str227.Split(chArray227))
        openingMove227.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove227);
      OpeningMove openingMove228 = new OpeningMove();
      openingMove228.StartingFEN = "rnbqkb1r/pp1ppppp/5n2/2pP4/2P5/8/PP2PPPP/RNBQKBNR b KQkq -";
      string str228 = "e7e6{10} b7b5{31}";
      char[] chArray228 = new char[1]{ ' ' };
      foreach (string move in str228.Split(chArray228))
        openingMove228.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove228);
      OpeningMove openingMove229 = new OpeningMove();
      openingMove229.StartingFEN = "rnbqkb1r/1p1p1ppp/p3pn2/8/3NP3/3B4/PPP2PPP/RNBQK2R w KQkq -";
      string str229 = "e1g1{20}";
      char[] chArray229 = new char[1]{ ' ' };
      foreach (string move in str229.Split(chArray229))
        openingMove229.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove229);
      OpeningMove openingMove230 = new OpeningMove();
      openingMove230.StartingFEN = "rnbqkb1r/pppp1ppp/4pn2/8/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq c3";
      string str230 = "b7b6{16} c7c5{30} f8b4{5}";
      char[] chArray230 = new char[1]{ ' ' };
      foreach (string move in str230.Split(chArray230))
        openingMove230.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove230);
      OpeningMove openingMove231 = new OpeningMove();
      openingMove231.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
      string str231 = "c4d5{26} g1f3{5} c1g5{5}";
      char[] chArray231 = new char[1]{ ' ' };
      foreach (string move in str231.Split(chArray231))
        openingMove231.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove231);
      OpeningMove openingMove232 = new OpeningMove();
      openingMove232.StartingFEN = "rnbq1rk1/1pp2pp1/p3pb1p/3p4/2PP4/2N1PN2/PP3PPP/2RQKB1R w K -";
      string str232 = "a2a3{5}";
      char[] chArray232 = new char[1]{ ' ' };
      foreach (string move in str232.Split(chArray232))
        openingMove232.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove232);
      OpeningMove openingMove233 = new OpeningMove();
      openingMove233.StartingFEN = "rnbqkbnr/pppp2pp/4p3/5p2/3P4/6P1/PPP1PP1P/RNBQKBNR w KQkq f6";
      string str233 = "f1g2{6}";
      char[] chArray233 = new char[1]{ ' ' };
      foreach (string move in str233.Split(chArray233))
        openingMove233.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove233);
      OpeningMove openingMove234 = new OpeningMove();
      openingMove234.StartingFEN = "rnbqkb1r/pppp1ppp/5n2/4p3/2P5/2N2N2/PP1PPPPP/R1BQKB1R b KQkq -";
      string str234 = "b8c6{70}";
      char[] chArray234 = new char[1]{ ' ' };
      foreach (string move in str234.Split(chArray234))
        openingMove234.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove234);
      OpeningMove openingMove235 = new OpeningMove();
      openingMove235.StartingFEN = "rnbqkb1r/pppn1ppp/4p3/3pP3/3P4/8/PPPN1PPP/R1BQKBNR w KQkq -";
      string str235 = "c2c3{5}";
      char[] chArray235 = new char[1]{ ' ' };
      foreach (string move in str235.Split(chArray235))
        openingMove235.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove235);
      OpeningMove openingMove236 = new OpeningMove();
      openingMove236.StartingFEN = "rnbqkb1r/pp1ppppp/5n2/2p5/2P5/5NP1/PP1PPP1P/RNBQKB1R b KQkq -";
      string str236 = "e7e6{5} b8c6{5} d7d5{15}";
      char[] chArray236 = new char[1]{ ' ' };
      foreach (string move in str236.Split(chArray236))
        openingMove236.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove236);
      OpeningMove openingMove237 = new OpeningMove();
      openingMove237.StartingFEN = "rnbqk2r/ppp1bppp/4pn2/3p4/2PP4/6P1/PP2PPBP/RNBQK1NR w KQkq -";
      string str237 = "g1f3{15}";
      char[] chArray237 = new char[1]{ ' ' };
      foreach (string move in str237.Split(chArray237))
        openingMove237.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove237);
      OpeningMove openingMove238 = new OpeningMove();
      openingMove238.StartingFEN = "rnbqk2r/ppppbppp/4pn2/8/2PP4/6P1/PP1BPP1P/RN1QKBNR w KQkq -";
      string str238 = "f1g2{5}";
      char[] chArray238 = new char[1]{ ' ' };
      foreach (string move in str238.Split(chArray238))
        openingMove238.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove238);
      OpeningMove openingMove239 = new OpeningMove();
      openingMove239.StartingFEN = "rnbqkb1r/pppppp1p/5np1/8/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
      string str239 = "c2c4{67} c1g5{5} g2g3{15}";
      char[] chArray239 = new char[1]{ ' ' };
      foreach (string move in str239.Split(chArray239))
        openingMove239.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove239);
      OpeningMove openingMove240 = new OpeningMove();
      openingMove240.StartingFEN = "rn1qk2r/1bpp1ppp/1p2pn2/p7/1bPP4/1P3NP1/P2BPPBP/RN1QK2R w KQkq a6";
      string str240 = "e1g1{50}";
      char[] chArray240 = new char[1]{ ' ' };
      foreach (string move in str240.Split(chArray240))
        openingMove240.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove240);
      OpeningMove openingMove241 = new OpeningMove();
      openingMove241.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq -";
      string str241 = "g8f6{5}";
      char[] chArray241 = new char[1]{ ' ' };
      foreach (string move in str241.Split(chArray241))
        openingMove241.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove241);
      OpeningMove openingMove242 = new OpeningMove();
      openingMove242.StartingFEN = "rnbqkbnr/pppp2pp/4p3/5p2/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq f6";
      string str242 = "g2g3{5}";
      char[] chArray242 = new char[1]{ ' ' };
      foreach (string move in str242.Split(chArray242))
        openingMove242.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove242);
      OpeningMove openingMove243 = new OpeningMove();
      openingMove243.StartingFEN = "rnbqkb1r/1p2pppp/p2p1n2/8/3NP3/2N1B3/PPP2PPP/R2QKB1R b KQkq -";
      string str243 = "e7e6{56} e7e5{41} f6g4{79} b8d7{5}";
      char[] chArray243 = new char[1]{ ' ' };
      foreach (string move in str243.Split(chArray243))
        openingMove243.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove243);
      OpeningMove openingMove244 = new OpeningMove();
      openingMove244.StartingFEN = "rnbqkbnr/pp2pppp/3p4/1Bp5/4P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
      string str244 = "c8d7{11} b8d7{16}";
      char[] chArray244 = new char[1]{ ' ' };
      foreach (string move in str244.Split(chArray244))
        openingMove244.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove244);
      OpeningMove openingMove245 = new OpeningMove();
      openingMove245.StartingFEN = "rnbqkbnr/ppp1pppp/3p4/8/8/5N2/PPPPPPPP/RNBQKB1R w KQkq -";
      string str245 = "d2d4{5}";
      char[] chArray245 = new char[1]{ ' ' };
      foreach (string move in str245.Split(chArray245))
        openingMove245.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove245);
      OpeningMove openingMove246 = new OpeningMove();
      openingMove246.StartingFEN = "rn1qk2r/p1p1bppp/bp2pn2/3p4/2PP4/1PN2NP1/P2BPP1P/R2QKB1R w KQkq d6";
      string str246 = "c4d5{10}";
      char[] chArray246 = new char[1]{ ' ' };
      foreach (string move in str246.Split(chArray246))
        openingMove246.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove246);
      OpeningMove openingMove247 = new OpeningMove();
      openingMove247.StartingFEN = "rn1qk2r/p1p1bppp/bp2p3/3n4/3P4/1PN2NP1/P2BPP1P/R2QKB1R w KQkq -";
      string str247 = "c3d5{5}";
      char[] chArray247 = new char[1]{ ' ' };
      foreach (string move in str247.Split(chArray247))
        openingMove247.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove247);
      OpeningMove openingMove248 = new OpeningMove();
      openingMove248.StartingFEN = "rn1q1rk1/p1ppbppp/bp2pn2/8/2PP4/1PN2NP1/P2BPP1P/R2QKB1R w KQ -";
      string str248 = "e2e4{5}";
      char[] chArray248 = new char[1]{ ' ' };
      foreach (string move in str248.Split(chArray248))
        openingMove248.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove248);
      OpeningMove openingMove249 = new OpeningMove();
      openingMove249.StartingFEN = "r1bqkb1r/pppp1ppp/2n2n2/4p3/2P5/2N2NP1/PP1PPP1P/R1BQKB1R b KQkq -";
      string str249 = "f8b4{30} g7g6{5} c6d4{5} d7d5{5}";
      char[] chArray249 = new char[1]{ ' ' };
      foreach (string move in str249.Split(chArray249))
        openingMove249.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove249);
      OpeningMove openingMove250 = new OpeningMove();
      openingMove250.StartingFEN = "rnbqkb1r/pp1ppp1p/2p2np1/8/2PP4/6P1/PP2PP1P/RNBQKBNR w KQkq -";
      string str250 = "f1g2{20} b1c3{5} g1f3{5}";
      char[] chArray250 = new char[1]{ ' ' };
      foreach (string move in str250.Split(chArray250))
        openingMove250.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove250);
      OpeningMove openingMove251 = new OpeningMove();
      openingMove251.StartingFEN = "rnbqkb1r/pppp1ppp/5n2/4p3/2P5/2N5/PP1PPPPP/R1BQKBNR w KQkq e6";
      string str251 = "g1f3{26}";
      char[] chArray251 = new char[1]{ ' ' };
      foreach (string move in str251.Split(chArray251))
        openingMove251.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove251);
      OpeningMove openingMove252 = new OpeningMove();
      openingMove252.StartingFEN = "rnbqkb1r/ppp1pp1p/6p1/3n4/3P4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
      string str252 = "e2e4{135}";
      char[] chArray252 = new char[1]{ ' ' };
      foreach (string move in str252.Split(chArray252))
        openingMove252.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove252);
      OpeningMove openingMove253 = new OpeningMove();
      openingMove253.StartingFEN = "rnbqkb1r/ppp1pp1p/5np1/3P4/3P4/2N5/PP2PPPP/R1BQKBNR b KQkq -";
      string str253 = "f6d5{107}";
      char[] chArray253 = new char[1]{ ' ' };
      foreach (string move in str253.Split(chArray253))
        openingMove253.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove253);
      OpeningMove openingMove254 = new OpeningMove();
      openingMove254.StartingFEN = "rnbqkbnr/ppp2ppp/3p4/4p3/2P5/2N5/PP1PPPPP/R1BQKBNR w KQkq -";
      string str254 = "g2g3{10}";
      char[] chArray254 = new char[1]{ ' ' };
      foreach (string move in str254.Split(chArray254))
        openingMove254.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove254);
      OpeningMove openingMove255 = new OpeningMove();
      openingMove255.StartingFEN = "rnbqkb1r/ppp1pp1p/6p1/3n4/3PP3/2N5/PP3PPP/R1BQKBNR b KQkq e3";
      string str255 = "d5c3{96}";
      char[] chArray255 = new char[1]{ ' ' };
      foreach (string move in str255.Split(chArray255))
        openingMove255.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove255);
      OpeningMove openingMove256 = new OpeningMove();
      openingMove256.StartingFEN = "rnbqkb1r/ppp1pp1p/6p1/8/3PP3/2P5/P4PPP/R1BQKBNR b KQkq -";
      string str256 = "f8g7{86}";
      char[] chArray256 = new char[1]{ ' ' };
      foreach (string move in str256.Split(chArray256))
        openingMove256.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove256);
      OpeningMove openingMove257 = new OpeningMove();
      openingMove257.StartingFEN = "rnbqk2r/ppp1ppbp/5np1/3p4/2PP4/1QN2N2/PP2PPPP/R1B1KB1R b KQkq -";
      string str257 = "d5c4{62}";
      char[] chArray257 = new char[1]{ ' ' };
      foreach (string move in str257.Split(chArray257))
        openingMove257.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove257);
      OpeningMove openingMove258 = new OpeningMove();
      openingMove258.StartingFEN = "r1bqk2r/pppp1ppp/2n2n2/4p3/1bP5/2N2NP1/PP1PPPBP/R1BQK2R b KQkq -";
      string str258 = "e8g8{10}";
      char[] chArray258 = new char[1]{ ' ' };
      foreach (string move in str258.Split(chArray258))
        openingMove258.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove258);
      OpeningMove openingMove259 = new OpeningMove();
      openingMove259.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR b KQkq d3";
      string str259 = "f8e7{16}";
      char[] chArray259 = new char[1]{ ' ' };
      foreach (string move in str259.Split(chArray259))
        openingMove259.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove259);
      OpeningMove openingMove260 = new OpeningMove();
      openingMove260.StartingFEN = "rnbqk2r/ppp1ppbp/5np1/8/2QP4/2N2N2/PP2PPPP/R1B1KB1R b KQkq -";
      string str260 = "e8g8{57}";
      char[] chArray260 = new char[1]{ ' ' };
      foreach (string move in str260.Split(chArray260))
        openingMove260.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove260);
      OpeningMove openingMove261 = new OpeningMove();
      openingMove261.StartingFEN = "rnbqkb1r/pp2pppp/5n2/2pp4/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq d6";
      string str261 = "c4d5{25}";
      char[] chArray261 = new char[1]{ ' ' };
      foreach (string move in str261.Split(chArray261))
        openingMove261.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove261);
      OpeningMove openingMove262 = new OpeningMove();
      openingMove262.StartingFEN = "r1bqkb1r/1ppp1ppp/p1n2n2/4p3/B2PP3/5N2/PPP2PPP/RNBQK2R b KQkq d3";
      string str262 = "e5d4{5}";
      char[] chArray262 = new char[1]{ ' ' };
      foreach (string move in str262.Split(chArray262))
        openingMove262.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove262);
      OpeningMove openingMove263 = new OpeningMove();
      openingMove263.StartingFEN = "rnbqkb1r/pp1p1ppp/5n2/2pp4/2P5/5N2/PP2PPPP/RNBQKB1R w KQkq -";
      string str263 = "c4d5{20}";
      char[] chArray263 = new char[1]{ ' ' };
      foreach (string move in str263.Split(chArray263))
        openingMove263.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove263);
      OpeningMove openingMove264 = new OpeningMove();
      openingMove264.StartingFEN = "rnbqkb1r/pppp1ppp/4pn2/8/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
      string str264 = "c2c4{56}";
      char[] chArray264 = new char[1]{ ' ' };
      foreach (string move in str264.Split(chArray264))
        openingMove264.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove264);
      OpeningMove openingMove265 = new OpeningMove();
      openingMove265.StartingFEN = "rnbqkb1r/pp1p1ppp/4pn2/8/3NP3/2N5/PPP2PPP/R1BQKB1R b KQkq -";
      string str265 = "d7d6{33} b8c6{10}";
      char[] chArray265 = new char[1]{ ' ' };
      foreach (string move in str265.Split(chArray265))
        openingMove265.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove265);
      OpeningMove openingMove266 = new OpeningMove();
      openingMove266.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/8/3NP3/2N1BP2/PPP3PP/R2QKB1R b KQkq -";
      string str266 = "f8e7{5} b7b5{33}";
      char[] chArray266 = new char[1]{ ' ' };
      foreach (string move in str266.Split(chArray266))
        openingMove266.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove266);
      OpeningMove openingMove267 = new OpeningMove();
      openingMove267.StartingFEN = "rnbqk1nr/ppppppbp/6p1/8/3PP3/8/PPP2PPP/RNBQKBNR w KQkq -";
      string str267 = "b1c3{30} c2c4{10}";
      char[] chArray267 = new char[1]{ ' ' };
      foreach (string move in str267.Split(chArray267))
        openingMove267.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove267);
      OpeningMove openingMove268 = new OpeningMove();
      openingMove268.StartingFEN = "rnbqkbnr/pppp1ppp/8/4p3/2P5/6P1/PP1PPP1P/RNBQKBNR b KQkq -";
      string str268 = "g8f6{20} d7d6{5} b8c6{5}";
      char[] chArray268 = new char[1]{ ' ' };
      foreach (string move in str268.Split(chArray268))
        openingMove268.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove268);
      OpeningMove openingMove269 = new OpeningMove();
      openingMove269.StartingFEN = "rnbqkbnr/pppppp1p/6p1/8/2P5/8/PP1PPPPP/RNBQKBNR w KQkq -";
      string str269 = "d2d4{15} g1f3{5} e2e4{5}";
      char[] chArray269 = new char[1]{ ' ' };
      foreach (string move in str269.Split(chArray269))
        openingMove269.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove269);
      OpeningMove openingMove270 = new OpeningMove();
      openingMove270.StartingFEN = "r1b1kbnr/pp1ppppp/1qn5/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
      string str270 = "d4b3{10}";
      char[] chArray270 = new char[1]{ ' ' };
      foreach (string move in str270.Split(chArray270))
        openingMove270.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove270);
      OpeningMove openingMove271 = new OpeningMove();
      openingMove271.StartingFEN = "rnbqkb1r/pp1ppppp/2p2n2/8/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
      string str271 = "g1f3{5} b1c3{17}";
      char[] chArray271 = new char[1]{ ' ' };
      foreach (string move in str271.Split(chArray271))
        openingMove271.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove271);
      OpeningMove openingMove272 = new OpeningMove();
      openingMove272.StartingFEN = "rnbq1rk1/pppp1ppp/4pn2/8/1bPP4/2N5/PPQ1PPPP/R1B1KBNR w KQ -";
      string str272 = "a2a3{90} e2e4{10}";
      char[] chArray272 = new char[1]{ ' ' };
      foreach (string move in str272.Split(chArray272))
        openingMove272.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove272);
      OpeningMove openingMove273 = new OpeningMove();
      openingMove273.StartingFEN = "rn1q1rk1/1bpp1ppp/1p2pn2/p7/1bPP4/1P3NP1/P2BPPBP/RN1Q1RK1 w - -";
      string str273 = "d1c2{40} b1c3{5}";
      char[] chArray273 = new char[1]{ ' ' };
      foreach (string move in str273.Split(chArray273))
        openingMove273.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove273);
      OpeningMove openingMove274 = new OpeningMove();
      openingMove274.StartingFEN = "rnbqkb1r/p1pp1ppp/1p2pn2/8/2PP4/P4N2/1P2PPPP/RNBQKB1R b KQkq -";
      string str274 = "c8b7{20} c8a6{10}";
      char[] chArray274 = new char[1]{ ' ' };
      foreach (string move in str274.Split(chArray274))
        openingMove274.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove274);
      OpeningMove openingMove275 = new OpeningMove();
      openingMove275.StartingFEN = "rnbqkb1r/pp1ppppp/5n2/2p5/2P5/2N3P1/PP1PPP1P/R1BQKBNR b KQkq -";
      string str275 = "e7e6{6} g7g6{5}";
      char[] chArray275 = new char[1]{ ' ' };
      foreach (string move in str275.Split(chArray275))
        openingMove275.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove275);
      OpeningMove openingMove276 = new OpeningMove();
      openingMove276.StartingFEN = "rnbqk2r/ppppppbp/5np1/8/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
      string str276 = "b1c3{40} g2g3{62}";
      char[] chArray276 = new char[1]{ ' ' };
      foreach (string move in str276.Split(chArray276))
        openingMove276.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove276);
      OpeningMove openingMove277 = new OpeningMove();
      openingMove277.StartingFEN = "rnbq1rk1/pppp1ppp/4pn2/8/2PP4/P1b5/1PQ1PPPP/R1B1KBNR w KQ -";
      string str277 = "c2c3{85}";
      char[] chArray277 = new char[1]{ ' ' };
      foreach (string move in str277.Split(chArray277))
        openingMove277.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove277);
      OpeningMove openingMove278 = new OpeningMove();
      openingMove278.StartingFEN = "rnbqk2r/ppp1ppbp/3p1np1/8/2PPP3/2N5/PP3PPP/R1BQKBNR w KQkq -";
      string str278 = "g1f3{71} f2f3{81} h2h3{5} f1e2{15} g1e2{5}";
      char[] chArray278 = new char[1]{ ' ' };
      foreach (string move in str278.Split(chArray278))
        openingMove278.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove278);
      OpeningMove openingMove279 = new OpeningMove();
      openingMove279.StartingFEN = "r1bqkb1r/pppp1ppp/2n2n2/4p3/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
      string str279 = "g2g3{42}";
      char[] chArray279 = new char[1]{ ' ' };
      foreach (string move in str279.Split(chArray279))
        openingMove279.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove279);
      OpeningMove openingMove280 = new OpeningMove();
      openingMove280.StartingFEN = "rnbqk2r/pppp1ppp/4pn2/8/1bPP4/2N5/PPQ1PPPP/R1B1KBNR b KQkq -";
      string str280 = "e8g8{95} c7c5{15} d7d5{21}";
      char[] chArray280 = new char[1]{ ' ' };
      foreach (string move in str280.Split(chArray280))
        openingMove280.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove280);
      OpeningMove openingMove281 = new OpeningMove();
      openingMove281.StartingFEN = "rnbqkbnr/ppppp1pp/8/5p2/3P4/8/PPP1PPPP/RNBQKBNR w KQkq f6";
      string str281 = "g2g3{30} c2c4{5}";
      char[] chArray281 = new char[1]{ ' ' };
      foreach (string move in str281.Split(chArray281))
        openingMove281.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove281);
      OpeningMove openingMove282 = new OpeningMove();
      openingMove282.StartingFEN = "rn1qkb1r/pbpppppp/1p3n2/8/2P5/5NP1/PP1PPP1P/RNBQKB1R w KQkq -";
      string str282 = "f1g2{25} d2d4{5}";
      char[] chArray282 = new char[1]{ ' ' };
      foreach (string move in str282.Split(chArray282))
        openingMove282.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove282);
      OpeningMove openingMove283 = new OpeningMove();
      openingMove283.StartingFEN = "r1bqkb1r/ppp2ppp/2n2n2/3pp3/2P5/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq d6";
      string str283 = "c4d5{22}";
      char[] chArray283 = new char[1]{ ' ' };
      foreach (string move in str283.Split(chArray283))
        openingMove283.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove283);
      OpeningMove openingMove284 = new OpeningMove();
      openingMove284.StartingFEN = "rnbqk2r/ppppppbp/5np1/8/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
      string str284 = "e2e4{87} g2g3{5} d2d4{5}";
      char[] chArray284 = new char[1]{ ' ' };
      foreach (string move in str284.Split(chArray284))
        openingMove284.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove284);
      OpeningMove openingMove285 = new OpeningMove();
      openingMove285.StartingFEN = "rnbqk2r/pppp1ppp/4pn2/8/1bPP4/2N2P2/PP2P1PP/R1BQKBNR b KQkq -";
      string str285 = "d7d5{15}";
      char[] chArray285 = new char[1]{ ' ' };
      foreach (string move in str285.Split(chArray285))
        openingMove285.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove285);
      OpeningMove openingMove286 = new OpeningMove();
      openingMove286.StartingFEN = "rnbqkb1r/pp3ppp/3ppn2/8/3NPP2/2N5/PPP3PP/R1BQKB1R b KQkq f3";
      string str286 = "a7a6{6}";
      char[] chArray286 = new char[1]{ ' ' };
      foreach (string move in str286.Split(chArray286))
        openingMove286.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove286);
      OpeningMove openingMove287 = new OpeningMove();
      openingMove287.StartingFEN = "rnbqkb1r/pppp1ppp/4pn2/8/3P4/4PN2/PPP2PPP/RNBQKB1R b KQkq -";
      string str287 = "c7c5{5} b7b6{5}";
      char[] chArray287 = new char[1]{ ' ' };
      foreach (string move in str287.Split(chArray287))
        openingMove287.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove287);
      OpeningMove openingMove288 = new OpeningMove();
      openingMove288.StartingFEN = "rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/6P1/PP1BPP1P/RN1QKBNR w KQkq c6";
      string str288 = "f1g2{5}";
      char[] chArray288 = new char[1]{ ' ' };
      foreach (string move in str288.Split(chArray288))
        openingMove288.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove288);
      OpeningMove openingMove289 = new OpeningMove();
      openingMove289.StartingFEN = "rnbq1rk1/ppp1bppp/4pn2/3p4/2PP4/5NP1/PP2PPBP/RNBQK2R w KQ -";
      string str289 = "b1c3{5}";
      char[] chArray289 = new char[1]{ ' ' };
      foreach (string move in str289.Split(chArray289))
        openingMove289.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove289);
      OpeningMove openingMove290 = new OpeningMove();
      openingMove290.StartingFEN = "r1bqkb1r/2p2ppp/p1n5/1p1pp3/3Pn3/1B3N2/PPP2PPP/RNBQ1RK1 w kq d6";
      string str290 = "d4e5{56}";
      char[] chArray290 = new char[1]{ ' ' };
      foreach (string move in str290.Split(chArray290))
        openingMove290.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove290);
      OpeningMove openingMove291 = new OpeningMove();
      openingMove291.StartingFEN = "rnbqkb1r/pp2pppp/2p2n2/3p4/8/5NP1/PPPPPPBP/RNBQ1RK1 b kq -";
      string str291 = "c8f5{5}";
      char[] chArray291 = new char[1]{ ' ' };
      foreach (string move in str291.Split(chArray291))
        openingMove291.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove291);
      OpeningMove openingMove292 = new OpeningMove();
      openingMove292.StartingFEN = "rnbqkb1r/pp2pppp/2p2n2/8/2pP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str292 = "a2a4{106}";
      char[] chArray292 = new char[1]{ ' ' };
      foreach (string move in str292.Split(chArray292))
        openingMove292.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove292);
      OpeningMove openingMove293 = new OpeningMove();
      openingMove293.StartingFEN = "rnbqkb1r/ppp1pp1p/6p1/8/3PP3/2n5/PP3PPP/R1BQKBNR w KQkq -";
      string str293 = "b2c3{125}";
      char[] chArray293 = new char[1]{ ' ' };
      foreach (string move in str293.Split(chArray293))
        openingMove293.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove293);
      OpeningMove openingMove294 = new OpeningMove();
      openingMove294.StartingFEN = "rnbqkb1r/pp3ppp/2p1pn2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str294 = "c1g5{91} e2e3{70}";
      char[] chArray294 = new char[1]{ ' ' };
      foreach (string move in str294.Split(chArray294))
        openingMove294.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove294);
      OpeningMove openingMove295 = new OpeningMove();
      openingMove295.StartingFEN = "rnbq1rk1/ppp2ppp/3ppn2/8/2PP4/P1Q5/1P2PPPP/R1B1KBNR w KQ -";
      string str295 = "f2f3{5}";
      char[] chArray295 = new char[1]{ ' ' };
      foreach (string move in str295.Split(chArray295))
        openingMove295.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove295);
      OpeningMove openingMove296 = new OpeningMove();
      openingMove296.StartingFEN = "rnbqkb1r/pppp1ppp/4pn2/8/2PP4/6P1/PP2PP1P/RNBQKBNR b KQkq -";
      string str296 = "d7d5{45} c7c5{5}";
      char[] chArray296 = new char[1]{ ' ' };
      foreach (string move in str296.Split(chArray296))
        openingMove296.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove296);
      OpeningMove openingMove297 = new OpeningMove();
      openingMove297.StartingFEN = "rnbq1rk1/pppp1ppp/4pn2/8/2PP4/5N2/PP1QPPPP/RN2KB1R w KQ -";
      string str297 = "g2g3{11}";
      char[] chArray297 = new char[1]{ ' ' };
      foreach (string move in str297.Split(chArray297))
        openingMove297.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove297);
      OpeningMove openingMove298 = new OpeningMove();
      openingMove298.StartingFEN = "rn1qkb1r/pb1p1ppp/1p2pn2/2p5/2P5/2N2NP1/PP1PPPBP/R1BQK2R w KQkq -";
      string str298 = "e1g1{20}";
      char[] chArray298 = new char[1]{ ' ' };
      foreach (string move in str298.Split(chArray298))
        openingMove298.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove298);
      OpeningMove openingMove299 = new OpeningMove();
      openingMove299.StartingFEN = "rnbqk2r/ppp2ppp/4pn2/3p4/1bPP4/2N5/PPQ1PPPP/R1B1KBNR w KQkq d6";
      string str299 = "a2a3{6} c4d5{21}";
      char[] chArray299 = new char[1]{ ' ' };
      foreach (string move in str299.Split(chArray299))
        openingMove299.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove299);
      OpeningMove openingMove300 = new OpeningMove();
      openingMove300.StartingFEN = "rnbqkbnr/pp2pppp/8/2pp4/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq c6";
      string str300 = "c2c4{6}";
      char[] chArray300 = new char[1]{ ' ' };
      foreach (string move in str300.Split(chArray300))
        openingMove300.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove300);
      OpeningMove openingMove301 = new OpeningMove();
      openingMove301.StartingFEN = "rn1qkb1r/pp2pppp/2p2n2/5b2/P1pP4/2N2N2/1P2PPPP/R1BQKB1R w KQkq -";
      string str301 = "f3e5{72} e2e3{28}";
      char[] chArray301 = new char[1]{ ' ' };
      foreach (string move in str301.Split(chArray301))
        openingMove301.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove301);
      OpeningMove openingMove302 = new OpeningMove();
      openingMove302.StartingFEN = "rn1qk2r/pbppbppp/1p2pn2/8/2PP4/5NP1/PP2PPBP/RNBQK2R w KQkq -";
      string str302 = "b1c3{35} e1g1{5}";
      char[] chArray302 = new char[1]{ ' ' };
      foreach (string move in str302.Split(chArray302))
        openingMove302.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove302);
      OpeningMove openingMove303 = new OpeningMove();
      openingMove303.StartingFEN = "rn1qkb1r/pp3ppp/2p1pn2/4Nb2/P1pP4/2N5/1P2PPPP/R1BQKB1R w KQkq -";
      string str303 = "f2f3{46}";
      char[] chArray303 = new char[1]{ ' ' };
      foreach (string move in str303.Split(chArray303))
        openingMove303.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove303);
      OpeningMove openingMove304 = new OpeningMove();
      openingMove304.StartingFEN = "rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/P1N2N2/1P2PPPP/R1BQKB1R b KQkq -";
      string str304 = "d7d5{20}";
      char[] chArray304 = new char[1]{ ' ' };
      foreach (string move in str304.Split(chArray304))
        openingMove304.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove304);
      OpeningMove openingMove305 = new OpeningMove();
      openingMove305.StartingFEN = "rnbqkb1r/ppp2ppp/5n2/3p4/3P4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
      string str305 = "c1g5{37}";
      char[] chArray305 = new char[1]{ ' ' };
      foreach (string move in str305.Split(chArray305))
        openingMove305.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove305);
      OpeningMove openingMove306 = new OpeningMove();
      openingMove306.StartingFEN = "rnbqkbnr/ppp1pppp/8/8/2pP4/8/PP2PPPP/RNBQKBNR w KQkq -";
      string str306 = "e2e4{65} g1f3{46} e2e3{11}";
      char[] chArray306 = new char[1]{ ' ' };
      foreach (string move in str306.Split(chArray306))
        openingMove306.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove306);
      OpeningMove openingMove307 = new OpeningMove();
      openingMove307.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq d6";
      string str307 = "c4d5{23}";
      char[] chArray307 = new char[1]{ ' ' };
      foreach (string move in str307.Split(chArray307))
        openingMove307.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove307);
      OpeningMove openingMove308 = new OpeningMove();
      openingMove308.StartingFEN = "rnbqkb1r/pppp1ppp/4pn2/8/2P5/2N5/PP1PPPPP/R1BQKBNR w KQkq -";
      string str308 = "e2e4{12} g1f3{15}";
      char[] chArray308 = new char[1]{ ' ' };
      foreach (string move in str308.Split(chArray308))
        openingMove308.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove308);
      OpeningMove openingMove309 = new OpeningMove();
      openingMove309.StartingFEN = "rnbqkbnr/pp2pppp/2p5/3pP3/3P4/8/PPP2PPP/RNBQKBNR b KQkq -";
      string str309 = "c8f5{45} c6c5{5}";
      char[] chArray309 = new char[1]{ ' ' };
      foreach (string move in str309.Split(chArray309))
        openingMove309.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove309);
      OpeningMove openingMove310 = new OpeningMove();
      openingMove310.StartingFEN = "rnbqk2r/ppp1ppbp/5np1/3p4/2PP1B2/2N1P3/PP3PPP/R2QKBNR b KQkq -";
      string str310 = "c7c5{11}";
      char[] chArray310 = new char[1]{ ' ' };
      foreach (string move in str310.Split(chArray310))
        openingMove310.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove310);
      OpeningMove openingMove311 = new OpeningMove();
      openingMove311.StartingFEN = "rnbqkb1r/pppppp1p/5np1/8/3P4/2N2N2/PPP1PPPP/R1BQKB1R b KQkq -";
      string str311 = "d7d5{6}";
      char[] chArray311 = new char[1]{ ' ' };
      foreach (string move in str311.Split(chArray311))
        openingMove311.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove311);
      OpeningMove openingMove312 = new OpeningMove();
      openingMove312.StartingFEN = "rnbqkb1r/ppp1pppp/5n2/8/2pPP3/8/PP3PPP/RNBQKBNR w KQkq -";
      string str312 = "e4e5{10}";
      char[] chArray312 = new char[1]{ ' ' };
      foreach (string move in str312.Split(chArray312))
        openingMove312.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove312);
      OpeningMove openingMove313 = new OpeningMove();
      openingMove313.StartingFEN = "rnbqkb1r/ppp1pppp/8/3nP3/2pP4/8/PP3PPP/RNBQKBNR w KQkq -";
      string str313 = "f1c4{5}";
      char[] chArray313 = new char[1]{ ' ' };
      foreach (string move in str313.Split(chArray313))
        openingMove313.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove313);
      OpeningMove openingMove314 = new OpeningMove();
      openingMove314.StartingFEN = "rnbqkbnr/pp1ppppp/2p5/8/4P3/3P4/PPP2PPP/RNBQKBNR b KQkq -";
      string str314 = "e7e5{5} d7d5{5}";
      char[] chArray314 = new char[1]{ ' ' };
      foreach (string move in str314.Split(chArray314))
        openingMove314.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove314);
      OpeningMove openingMove315 = new OpeningMove();
      openingMove315.StartingFEN = "rnbqkb1r/pp3ppp/2p2n2/3p2B1/3P4/2N5/PP2PPPP/R2QKBNR w KQkq -";
      string str315 = "d1c2{6} e2e3{11}";
      char[] chArray315 = new char[1]{ ' ' };
      foreach (string move in str315.Split(chArray315))
        openingMove315.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove315);
      OpeningMove openingMove316 = new OpeningMove();
      openingMove316.StartingFEN = "rnbq1rk1/p1pp1ppp/1p2pn2/8/2PP4/P1Q5/1P2PPPP/R1B1KBNR w KQ -";
      string str316 = "c1g5{69} g1f3{5}";
      char[] chArray316 = new char[1]{ ' ' };
      foreach (string move in str316.Split(chArray316))
        openingMove316.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove316);
      OpeningMove openingMove317 = new OpeningMove();
      openingMove317.StartingFEN = "rnbqk2r/ppp1ppbp/6p1/8/2BPP3/2P5/P4PPP/R1BQK1NR b KQkq -";
      string str317 = "c7c5{36} e8g8{5}";
      char[] chArray317 = new char[1]{ ' ' };
      foreach (string move in str317.Split(chArray317))
        openingMove317.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove317);
      OpeningMove openingMove318 = new OpeningMove();
      openingMove318.StartingFEN = "rnbq1rk1/ppp2pbp/3p1np1/3Pp3/2P1P3/2N1BP2/PP4PP/R2QKBNR b KQ -";
      string str318 = "c7c6{17} f6h5{5}";
      char[] chArray318 = new char[1]{ ' ' };
      foreach (string move in str318.Split(chArray318))
        openingMove318.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove318);
      OpeningMove openingMove319 = new OpeningMove();
      openingMove319.StartingFEN = "rnbq1rk1/ppp1ppbp/5np1/8/2QPP3/2N2N2/PP3PPP/R1B1KB1R b KQ e3";
      string str319 = "b8a6{22} a7a6{25} c8g4{5}";
      char[] chArray319 = new char[1]{ ' ' };
      foreach (string move in str319.Split(chArray319))
        openingMove319.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove319);
      OpeningMove openingMove320 = new OpeningMove();
      openingMove320.StartingFEN = "rnbqk2r/ppp1ppbp/6p1/8/3PP3/2P5/P4PPP/R1BQKBNR w KQkq -";
      string str320 = "f1c4{40} c1e3{35} f1b5{5} g1f3{40}";
      char[] chArray320 = new char[1]{ ' ' };
      foreach (string move in str320.Split(chArray320))
        openingMove320.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove320);
      OpeningMove openingMove321 = new OpeningMove();
      openingMove321.StartingFEN = "rnbq1rk1/pppp1ppp/4pn2/8/1bPP4/2NBP3/PP3PPP/R1BQK1NR b KQ -";
      string str321 = "c7c5{25} d7d5{15}";
      char[] chArray321 = new char[1]{ ' ' };
      foreach (string move in str321.Split(chArray321))
        openingMove321.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove321);
      OpeningMove openingMove322 = new OpeningMove();
      openingMove322.StartingFEN = "rnbqk2r/pp2ppbp/6p1/2p5/2BPP3/2P5/P3NPPP/R1BQK2R b KQkq -";
      string str322 = "e8g8{10} b8c6{20}";
      char[] chArray322 = new char[1]{ ' ' };
      foreach (string move in str322.Split(chArray322))
        openingMove322.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove322);
      OpeningMove openingMove323 = new OpeningMove();
      openingMove323.StartingFEN = "r1bq1rk1/2p1bppp/p1np1n2/1p2p3/4P3/1BP2N1P/PP1P1PP1/RNBQR1K1 b - -";
      string str323 = "f6d7{25} c8b7{55} f8e8{5} c6a5{5}";
      char[] chArray323 = new char[1]{ ' ' };
      foreach (string move in str323.Split(chArray323))
        openingMove323.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove323);
      OpeningMove openingMove324 = new OpeningMove();
      openingMove324.StartingFEN = "rnbq1rk1/ppp1bpp1/4pn1p/3p2B1/2PP4/2N1PN2/PP3PPP/R2QKB1R w KQ -";
      string str324 = "g5h4{21}";
      char[] chArray324 = new char[1]{ ' ' };
      foreach (string move in str324.Split(chArray324))
        openingMove324.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove324);
      OpeningMove openingMove325 = new OpeningMove();
      openingMove325.StartingFEN = "rnbqkb1r/1p2pppp/p2p1n2/8/3NPP2/2N5/PPP3PP/R1BQKB1R b KQkq f3";
      string str325 = "e7e6{34} e7e5{5} g7g6{5}";
      char[] chArray325 = new char[1]{ ' ' };
      foreach (string move in str325.Split(chArray325))
        openingMove325.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove325);
      OpeningMove openingMove326 = new OpeningMove();
      openingMove326.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/6B1/3NPP2/2N5/PPP3PP/R2QKB1R b KQkq f3";
      string str326 = "d8c7{5} d8b6{26}";
      char[] chArray326 = new char[1]{ ' ' };
      foreach (string move in str326.Split(chArray326))
        openingMove326.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove326);
      OpeningMove openingMove327 = new OpeningMove();
      openingMove327.StartingFEN = "rnbqkb1r/pp3ppp/3p1n2/2pP4/8/5N2/PP2PPPP/RNBQKB1R w KQkq -";
      string str327 = "b1c3{15}";
      char[] chArray327 = new char[1]{ ' ' };
      foreach (string move in str327.Split(chArray327))
        openingMove327.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove327);
      OpeningMove openingMove328 = new OpeningMove();
      openingMove328.StartingFEN = "rnbqkbnr/pp2pppp/2p5/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq -";
      string str328 = "g8f6{141}";
      char[] chArray328 = new char[1]{ ' ' };
      foreach (string move in str328.Split(chArray328))
        openingMove328.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove328);
      OpeningMove openingMove329 = new OpeningMove();
      openingMove329.StartingFEN = "rnbqk2r/1p2bppp/p2ppn2/8/3NP3/2N5/PPP1BPPP/R1BQ1RK1 w kq -";
      string str329 = "f2f4{20} a2a4{25}";
      char[] chArray329 = new char[1]{ ' ' };
      foreach (string move in str329.Split(chArray329))
        openingMove329.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove329);
      OpeningMove openingMove330 = new OpeningMove();
      openingMove330.StartingFEN = "rnbqkb1r/1p2pppp/p2p1n2/8/2BNP3/2N5/PPP2PPP/R1BQK2R b KQkq -";
      string str330 = "e7e6{25}";
      char[] chArray330 = new char[1]{ ' ' };
      foreach (string move in str330.Split(chArray330))
        openingMove330.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove330);
      OpeningMove openingMove331 = new OpeningMove();
      openingMove331.StartingFEN = "rnbqkbnr/pp3ppp/8/2pp4/3P4/8/PPPN1PPP/R1BQKBNR w KQkq -";
      string str331 = "f1b5{10} g1f3{10}";
      char[] chArray331 = new char[1]{ ' ' };
      foreach (string move in str331.Split(chArray331))
        openingMove331.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove331);
      OpeningMove openingMove332 = new OpeningMove();
      openingMove332.StartingFEN = "rnbq1rk1/ppp1bpp1/4p2p/3p4/2PPn2B/2N1PN2/PP3PPP/R2QKB1R w KQ -";
      string str332 = "h4e7{15}";
      char[] chArray332 = new char[1]{ ' ' };
      foreach (string move in str332.Split(chArray332))
        openingMove332.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove332);
      OpeningMove openingMove333 = new OpeningMove();
      openingMove333.StartingFEN = "rnbq1rk1/pp1p1ppp/4pn2/2p5/1bPP4/P1NBP3/1P3PPP/R1BQK1NR b KQ -";
      string str333 = "b4c3{5}";
      char[] chArray333 = new char[1]{ ' ' };
      foreach (string move in str333.Split(chArray333))
        openingMove333.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove333);
      OpeningMove openingMove334 = new OpeningMove();
      openingMove334.StartingFEN = "r1bqkb1r/pppp1ppp/2n2n2/4p3/2B1P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str334 = "d2d3{15} f3g5{5}";
      char[] chArray334 = new char[1]{ ' ' };
      foreach (string move in str334.Split(chArray334))
        openingMove334.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove334);
      OpeningMove openingMove335 = new OpeningMove();
      openingMove335.StartingFEN = "r1bqk2r/pp2bppp/2nppn2/6B1/3NP3/2N5/PPPQ1PPP/R3KB1R w KQkq -";
      string str335 = "e1c1{35}";
      char[] chArray335 = new char[1]{ ' ' };
      foreach (string move in str335.Split(chArray335))
        openingMove335.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove335);
      OpeningMove openingMove336 = new OpeningMove();
      openingMove336.StartingFEN = "rnbqkbnr/pp2pppp/8/3p4/3P4/8/PPP2PPP/RNBQKBNR w KQkq -";
      string str336 = "c2c4{26} f1d3{5}";
      char[] chArray336 = new char[1]{ ' ' };
      foreach (string move in str336.Split(chArray336))
        openingMove336.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove336);
      OpeningMove openingMove337 = new OpeningMove();
      openingMove337.StartingFEN = "r1bqkbnr/1pp2ppp/p1np4/4p3/B3P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str337 = "a4c6{5} e1g1{5} c2c3{10}";
      char[] chArray337 = new char[1]{ ' ' };
      foreach (string move in str337.Split(chArray337))
        openingMove337.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove337);
      OpeningMove openingMove338 = new OpeningMove();
      openingMove338.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/6P1/PP2PPBP/RNBQK1NR b KQkq -";
      string str338 = "d5c4{20} f8e7{10}";
      char[] chArray338 = new char[1]{ ' ' };
      foreach (string move in str338.Split(chArray338))
        openingMove338.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove338);
      OpeningMove openingMove339 = new OpeningMove();
      openingMove339.StartingFEN = "rnbqk2r/ppppppbp/5np1/8/2PP4/5NP1/PP2PP1P/RNBQKB1R b KQkq -";
      string str339 = "c7c5{11} e8g8{18} d7d5{21}";
      char[] chArray339 = new char[1]{ ' ' };
      foreach (string move in str339.Split(chArray339))
        openingMove339.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove339);
      OpeningMove openingMove340 = new OpeningMove();
      openingMove340.StartingFEN = "r2q1rk1/2p1bppp/p1npbn2/1p2p3/4P3/1BP2N1P/PP1P1PP1/RNBQR1K1 w - -";
      string str340 = "d2d4{10}";
      char[] chArray340 = new char[1]{ ' ' };
      foreach (string move in str340.Split(chArray340))
        openingMove340.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove340);
      OpeningMove openingMove341 = new OpeningMove();
      openingMove341.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/6B1/3NP3/2N5/PPP2PPP/R2QKB1R w KQkq -";
      string str341 = "f2f4{50}";
      char[] chArray341 = new char[1]{ ' ' };
      foreach (string move in str341.Split(chArray341))
        openingMove341.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove341);
      OpeningMove openingMove342 = new OpeningMove();
      openingMove342.StartingFEN = "rnbqkb1r/ppp1pppp/5n2/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq d6";
      string str342 = "c2c4{21}";
      char[] chArray342 = new char[1]{ ' ' };
      foreach (string move in str342.Split(chArray342))
        openingMove342.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove342);
      OpeningMove openingMove343 = new OpeningMove();
      openingMove343.StartingFEN = "rnbq1rk1/ppp2ppp/4pn2/3p4/2PP4/5NP1/PP1QPP1P/RN2KB1R w KQ d6";
      string str343 = "f1g2{6}";
      char[] chArray343 = new char[1]{ ' ' };
      foreach (string move in str343.Split(chArray343))
        openingMove343.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove343);
      OpeningMove openingMove344 = new OpeningMove();
      openingMove344.StartingFEN = "rnbqkb1r/pppppp1p/5np1/8/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq c3";
      string str344 = "f8g7{61}";
      char[] chArray344 = new char[1]{ ' ' };
      foreach (string move in str344.Split(chArray344))
        openingMove344.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove344);
      OpeningMove openingMove345 = new OpeningMove();
      openingMove345.StartingFEN = "rnbq1rk1/2p1bppp/p2p1n2/1p2p3/4P3/1BP2N1P/PP1P1PP1/RNBQR1K1 w - -";
      string str345 = "d2d4{10}";
      char[] chArray345 = new char[1]{ ' ' };
      foreach (string move in str345.Split(chArray345))
        openingMove345.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove345);
      OpeningMove openingMove346 = new OpeningMove();
      openingMove346.StartingFEN = "rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/5NP1/PP2PPBP/RNBQK2R b KQkq -";
      string str346 = "f8e7{10}";
      char[] chArray346 = new char[1]{ ' ' };
      foreach (string move in str346.Split(chArray346))
        openingMove346.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove346);
      OpeningMove openingMove347 = new OpeningMove();
      openingMove347.StartingFEN = "rnbq1rk1/pp1p1ppp/4pn2/2p5/1bPP4/2NBPN2/PP3PPP/R1BQK2R b KQ -";
      string str347 = "d7d5{15}";
      char[] chArray347 = new char[1]{ ' ' };
      foreach (string move in str347.Split(chArray347))
        openingMove347.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove347);
      OpeningMove openingMove348 = new OpeningMove();
      openingMove348.StartingFEN = "rnbqkb1r/pppp1ppp/5n2/4p3/2P5/2N3P1/PP1PPP1P/R1BQKBNR b KQkq -";
      string str348 = "d7d5{5} f8b4{5}";
      char[] chArray348 = new char[1]{ ' ' };
      foreach (string move in str348.Split(chArray348))
        openingMove348.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove348);
      OpeningMove openingMove349 = new OpeningMove();
      openingMove349.StartingFEN = "rnbqk1nr/pp2bppp/2p5/3p4/3P1B2/2N5/PP2PPPP/R2QKBNR w KQkq -";
      string str349 = "e2e3{10} d1c2{5}";
      char[] chArray349 = new char[1]{ ' ' };
      foreach (string move in str349.Split(chArray349))
        openingMove349.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove349);
      OpeningMove openingMove350 = new OpeningMove();
      openingMove350.StartingFEN = "rnbqkbnr/ppppp1pp/8/5p2/2P5/8/PP1PPPPP/RNBQKBNR w KQkq f6";
      string str350 = "d2d4{5} g1f3{6}";
      char[] chArray350 = new char[1]{ ' ' };
      foreach (string move in str350.Split(chArray350))
        openingMove350.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove350);
      OpeningMove openingMove351 = new OpeningMove();
      openingMove351.StartingFEN = "rnbqkb1r/pp1p1ppp/4pn2/2pP4/8/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
      string str351 = "b1c3{11}";
      char[] chArray351 = new char[1]{ ' ' };
      foreach (string move in str351.Split(chArray351))
        openingMove351.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove351);
      OpeningMove openingMove352 = new OpeningMove();
      openingMove352.StartingFEN = "rnbqkbnr/pppppp1p/6p1/8/2P1P3/8/PP1P1PPP/RNBQKBNR b KQkq e3";
      string str352 = "f8g7{6}";
      char[] chArray352 = new char[1]{ ' ' };
      foreach (string move in str352.Split(chArray352))
        openingMove352.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove352);
      OpeningMove openingMove353 = new OpeningMove();
      openingMove353.StartingFEN = "rn1qk2r/p2pbppp/bpp1pn2/8/2PP4/1P3NP1/P2BPPBP/RN1QK2R w KQkq -";
      string str353 = "d2c3{40} e1g1{15}";
      char[] chArray353 = new char[1]{ ' ' };
      foreach (string move in str353.Split(chArray353))
        openingMove353.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove353);
      OpeningMove openingMove354 = new OpeningMove();
      openingMove354.StartingFEN = "rnbqk2r/ppp2ppp/5n2/3p4/1b1P4/2N5/PPQ1PPPP/R1B1KBNR w KQkq -";
      string str354 = "c1g5{5}";
      char[] chArray354 = new char[1]{ ' ' };
      foreach (string move in str354.Split(chArray354))
        openingMove354.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove354);
      OpeningMove openingMove355 = new OpeningMove();
      openingMove355.StartingFEN = "rnbqkb1r/pp3ppp/3ppn2/8/3NP3/2N5/PPP1BPPP/R1BQK2R b KQkq -";
      string str355 = "f8e7{12}";
      char[] chArray355 = new char[1]{ ' ' };
      foreach (string move in str355.Split(chArray355))
        openingMove355.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove355);
      OpeningMove openingMove356 = new OpeningMove();
      openingMove356.StartingFEN = "rnbqk2r/pp2bppp/3ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQK2R b KQkq f3";
      string str356 = "e8g8{6}";
      char[] chArray356 = new char[1]{ ' ' };
      foreach (string move in str356.Split(chArray356))
        openingMove356.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove356);
      OpeningMove openingMove357 = new OpeningMove();
      openingMove357.StartingFEN = "rnbqkbnr/ppp2ppp/3p4/4p3/2P5/6P1/PP1PPP1P/RNBQKBNR w KQkq -";
      string str357 = "f1g2{6}";
      char[] chArray357 = new char[1]{ ' ' };
      foreach (string move in str357.Split(chArray357))
        openingMove357.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove357);
      OpeningMove openingMove358 = new OpeningMove();
      openingMove358.StartingFEN = "rnbqkb1r/pppppp1p/5np1/8/2P5/2N2N2/PP1PPPPP/R1BQKB1R b KQkq -";
      string str358 = "f8g7{67} d7d5{25}";
      char[] chArray358 = new char[1]{ ' ' };
      foreach (string move in str358.Split(chArray358))
        openingMove358.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove358);
      OpeningMove openingMove359 = new OpeningMove();
      openingMove359.StartingFEN = "rn1qkb1r/1b1p1ppp/pp2pn2/2p5/2P5/2N2NP1/PP1PPPBP/R1BQ1RK1 w kq -";
      string str359 = "b2b3{5}";
      char[] chArray359 = new char[1]{ ' ' };
      foreach (string move in str359.Split(chArray359))
        openingMove359.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove359);
      OpeningMove openingMove360 = new OpeningMove();
      openingMove360.StartingFEN = "rn1qk2r/p3bppp/bpp1pn2/3p4/2PP4/1PB2NP1/P3PPBP/RN1QK2R w KQkq d6";
      string str360 = "f3e5{25} b1d2{5}";
      char[] chArray360 = new char[1]{ ' ' };
      foreach (string move in str360.Split(chArray360))
        openingMove360.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove360);
      OpeningMove openingMove361 = new OpeningMove();
      openingMove361.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/3p4/2PP4/8/PP2PPPP/RNBQKBNR w KQkq d6";
      string str361 = "b1c3{5}";
      char[] chArray361 = new char[1]{ ' ' };
      foreach (string move in str361.Split(chArray361))
        openingMove361.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove361);
      OpeningMove openingMove362 = new OpeningMove();
      openingMove362.StartingFEN = "r1bq1rk1/2pnbppp/p1np4/1p2p3/3PP3/1BP2N1P/PP3PP1/RNBQR1K1 b - d3";
      string str362 = "e7f6{15}";
      char[] chArray362 = new char[1]{ ' ' };
      foreach (string move in str362.Split(chArray362))
        openingMove362.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove362);
      OpeningMove openingMove363 = new OpeningMove();
      openingMove363.StartingFEN = "rnbq1rk1/pppp1ppp/4pn2/8/1bPP4/P1N5/1PQ1PPPP/R1B1KBNR b KQ -";
      string str363 = "b4c3{75}";
      char[] chArray363 = new char[1]{ ' ' };
      foreach (string move in str363.Split(chArray363))
        openingMove363.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove363);
      OpeningMove openingMove364 = new OpeningMove();
      openingMove364.StartingFEN = "rnbqk2r/p1pp1ppp/1p2pn2/8/1bPP4/5N2/PP1NPPPP/R1BQKB1R w KQkq -";
      string str364 = "a2a3{5} g2g3{5}";
      char[] chArray364 = new char[1]{ ' ' };
      foreach (string move in str364.Split(chArray364))
        openingMove364.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove364);
      OpeningMove openingMove365 = new OpeningMove();
      openingMove365.StartingFEN = "rnbqk2r/ppp1ppbp/3p1np1/8/2PPP3/2N2N2/PP3PPP/R1BQKB1R b KQkq -";
      string str365 = "e8g8{56}";
      char[] chArray365 = new char[1]{ ' ' };
      foreach (string move in str365.Split(chArray365))
        openingMove365.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove365);
      OpeningMove openingMove366 = new OpeningMove();
      openingMove366.StartingFEN = "rnb1k2r/ppppqppp/4pn2/8/1bPP4/5N2/PP1BPPPP/RN1QKB1R w KQkq -";
      string str366 = "g2g3{5}";
      char[] chArray366 = new char[1]{ ' ' };
      foreach (string move in str366.Split(chArray366))
        openingMove366.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove366);
      OpeningMove openingMove367 = new OpeningMove();
      openingMove367.StartingFEN = "rnbqkbnr/ppp2ppp/8/4p3/2pPP3/8/PP3PPP/RNBQKBNR w KQkq e6";
      string str367 = "g1f3{20}";
      char[] chArray367 = new char[1]{ ' ' };
      foreach (string move in str367.Split(chArray367))
        openingMove367.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove367);
      OpeningMove openingMove368 = new OpeningMove();
      openingMove368.StartingFEN = "r1bqkb1r/pp1ppppp/2n2n2/8/2Pp4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str368 = "f3d4{21}";
      char[] chArray368 = new char[1]{ ' ' };
      foreach (string move in str368.Split(chArray368))
        openingMove368.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove368);
      OpeningMove openingMove369 = new OpeningMove();
      openingMove369.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/8/3NP3/1BN5/PPP2PPP/R1BQK2R b KQkq -";
      string str369 = "b8d7{5} b7b5{10}";
      char[] chArray369 = new char[1]{ ' ' };
      foreach (string move in str369.Split(chArray369))
        openingMove369.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove369);
      OpeningMove openingMove370 = new OpeningMove();
      openingMove370.StartingFEN = "rnbqk2r/ppp1bppp/5n2/3p2B1/3P4/2N5/PP2PPPP/R2QKBNR w KQkq -";
      string str370 = "e2e3{15}";
      char[] chArray370 = new char[1]{ ' ' };
      foreach (string move in str370.Split(chArray370))
        openingMove370.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove370);
      OpeningMove openingMove371 = new OpeningMove();
      openingMove371.StartingFEN = "rnbqkb1r/pppp1ppp/5n2/4p3/2P5/2N5/PP1PPPPP/R1BQKBNR w KQkq -";
      string str371 = "g2g3{5} g1f3{26}";
      char[] chArray371 = new char[1]{ ' ' };
      foreach (string move in str371.Split(chArray371))
        openingMove371.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove371);
      OpeningMove openingMove372 = new OpeningMove();
      openingMove372.StartingFEN = "rnbqkb1r/pp1ppppp/5n2/2p5/2P5/2N5/PP1PPPPP/R1BQKBNR w KQkq c6";
      string str372 = "g1f3{15} g2g3{12}";
      char[] chArray372 = new char[1]{ ' ' };
      foreach (string move in str372.Split(chArray372))
        openingMove372.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove372);
      OpeningMove openingMove373 = new OpeningMove();
      openingMove373.StartingFEN = "rnbq1rk1/ppp1ppbp/6p1/8/2BPP3/2P5/P4PPP/R1BQK1NR w KQ -";
      string str373 = "g1e2{5}";
      char[] chArray373 = new char[1]{ ' ' };
      foreach (string move in str373.Split(chArray373))
        openingMove373.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove373);
      OpeningMove openingMove374 = new OpeningMove();
      openingMove374.StartingFEN = "rnbqkb1r/pp3p1p/3p1np1/2pP4/8/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str374 = "h2h3{15} e2e4{5}";
      char[] chArray374 = new char[1]{ ' ' };
      foreach (string move in str374.Split(chArray374))
        openingMove374.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove374);
      OpeningMove openingMove375 = new OpeningMove();
      openingMove375.StartingFEN = "rnbqk2r/ppppppbp/5np1/8/2P5/5NP1/PP1PPP1P/RNBQKB1R w KQkq -";
      string str375 = "f1g2{20}";
      char[] chArray375 = new char[1]{ ' ' };
      foreach (string move in str375.Split(chArray375))
        openingMove375.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove375);
      OpeningMove openingMove376 = new OpeningMove();
      openingMove376.StartingFEN = "r1bqkb1r/pppp1ppp/2n5/1B2p3/4n3/5N2/PPPP1PPP/RNBQ1RK1 w kq -";
      string str376 = "d2d4{75}";
      char[] chArray376 = new char[1]{ ' ' };
      foreach (string move in str376.Split(chArray376))
        openingMove376.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove376);
      OpeningMove openingMove377 = new OpeningMove();
      openingMove377.StartingFEN = "rn1qkb1r/pbpp1ppp/1p2pn2/8/Q1PP4/5NP1/PP2PP1P/RNB1KB1R w KQkq -";
      string str377 = "f1g2{5}";
      char[] chArray377 = new char[1]{ ' ' };
      foreach (string move in str377.Split(chArray377))
        openingMove377.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove377);
      OpeningMove openingMove378 = new OpeningMove();
      openingMove378.StartingFEN = "rnbq1rk1/ppp1ppbp/3p1np1/8/2PPP3/2N2N2/PP3PPP/R1BQKB1R w KQ -";
      string str378 = "f1e2{130} h2h3{5}";
      char[] chArray378 = new char[1]{ ' ' };
      foreach (string move in str378.Split(chArray378))
        openingMove378.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove378);
      OpeningMove openingMove379 = new OpeningMove();
      openingMove379.StartingFEN = "r1bq1rk1/2pnbppp/p1np4/1p2p3/4P3/1BP2N1P/PP1P1PP1/RNBQR1K1 w - -";
      string str379 = "d2d4{26}";
      char[] chArray379 = new char[1]{ ' ' };
      foreach (string move in str379.Split(chArray379))
        openingMove379.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove379);
      OpeningMove openingMove380 = new OpeningMove();
      openingMove380.StartingFEN = "r1b1kbnr/ppqp1ppp/2n1p3/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
      string str380 = "f1e2{46} c1e3{25} g2g3{10}";
      char[] chArray380 = new char[1]{ ' ' };
      foreach (string move in str380.Split(chArray380))
        openingMove380.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove380);
      OpeningMove openingMove381 = new OpeningMove();
      openingMove381.StartingFEN = "rnbqkbnr/p1p2ppp/1p2p3/3pP3/3P4/8/PPP2PPP/RNBQKBNR w KQkq -";
      string str381 = "f1b5{5}";
      char[] chArray381 = new char[1]{ ' ' };
      foreach (string move in str381.Split(chArray381))
        openingMove381.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove381);
      OpeningMove openingMove382 = new OpeningMove();
      openingMove382.StartingFEN = "rnbqk1nr/ppp1ppbp/3p2p1/8/3PP3/2N5/PPP2PPP/R1BQKBNR w KQkq -";
      string str382 = "g1e2{5} c1e3{15} f2f4{10}";
      char[] chArray382 = new char[1]{ ' ' };
      foreach (string move in str382.Split(chArray382))
        openingMove382.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove382);
      OpeningMove openingMove383 = new OpeningMove();
      openingMove383.StartingFEN = "r1bqk2r/ppppbppp/2n2n2/1B2p3/4P3/5N2/PPPP1PPP/RNBQ1RK1 w kq -";
      string str383 = "f1e1{5}";
      char[] chArray383 = new char[1]{ ' ' };
      foreach (string move in str383.Split(chArray383))
        openingMove383.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove383);
      OpeningMove openingMove384 = new OpeningMove();
      openingMove384.StartingFEN = "rnbqk2r/ppp1ppbp/3p1np1/8/3PP3/2N3P1/PPP2P1P/R1BQKBNR w KQkq -";
      string str384 = "f1g2{5}";
      char[] chArray384 = new char[1]{ ' ' };
      foreach (string move in str384.Split(chArray384))
        openingMove384.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove384);
      OpeningMove openingMove385 = new OpeningMove();
      openingMove385.StartingFEN = "rn1q1rk1/pbpp1ppp/1p2pn2/6B1/2PP4/P1Q5/1P2PPPP/R3KBNR w KQ -";
      string str385 = "f2f3{31} g1h3{5} e2e3{11} g1f3{5}";
      char[] chArray385 = new char[1]{ ' ' };
      foreach (string move in str385.Split(chArray385))
        openingMove385.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove385);
      OpeningMove openingMove386 = new OpeningMove();
      openingMove386.StartingFEN = "rnbqkbnr/ppp1pppp/3p4/8/3P4/8/PPP1PPPP/RNBQKBNR w KQkq -";
      string str386 = "e2e4{16} g1f3{11}";
      char[] chArray386 = new char[1]{ ' ' };
      foreach (string move in str386.Split(chArray386))
        openingMove386.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove386);
      OpeningMove openingMove387 = new OpeningMove();
      openingMove387.StartingFEN = "r1bqkbnr/pp1p1ppp/2n5/4p3/3NP3/8/PPP2PPP/RNBQKB1R w KQkq e6";
      string str387 = "d4b5{20}";
      char[] chArray387 = new char[1]{ ' ' };
      foreach (string move in str387.Split(chArray387))
        openingMove387.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove387);
      OpeningMove openingMove388 = new OpeningMove();
      openingMove388.StartingFEN = "rnbqkb1r/pppp1ppp/5n2/4p3/2P5/6P1/PP1PPP1P/RNBQKBNR w KQkq -";
      string str388 = "f1g2{25}";
      char[] chArray388 = new char[1]{ ' ' };
      foreach (string move in str388.Split(chArray388))
        openingMove388.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove388);
      OpeningMove openingMove389 = new OpeningMove();
      openingMove389.StartingFEN = "rn1qkb1r/p1pp1ppp/bp2pn2/8/2PP4/5NP1/PP1NPP1P/R1BQKB1R b KQkq -";
      string str389 = "a6b7{10}";
      char[] chArray389 = new char[1]{ ' ' };
      foreach (string move in str389.Split(chArray389))
        openingMove389.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove389);
      OpeningMove openingMove390 = new OpeningMove();
      openingMove390.StartingFEN = "rnbqkbnr/ppppp1pp/8/5p2/3P4/2N5/PPP1PPPP/R1BQKBNR b KQkq -";
      string str390 = "d7d5{5} g8f6{5}";
      char[] chArray390 = new char[1]{ ' ' };
      foreach (string move in str390.Split(chArray390))
        openingMove390.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove390);
      OpeningMove openingMove391 = new OpeningMove();
      openingMove391.StartingFEN = "rnbqk2r/pp1pppbp/2p2np1/8/2PP4/5NP1/PP2PP1P/RNBQKB1R w KQkq -";
      string str391 = "f1g2{15}";
      char[] chArray391 = new char[1]{ ' ' };
      foreach (string move in str391.Split(chArray391))
        openingMove391.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove391);
      OpeningMove openingMove392 = new OpeningMove();
      openingMove392.StartingFEN = "r2qr1k1/1bp1bppp/p1np1n2/1p2p3/3PP3/1BP2N1P/PP3PP1/RNBQR1K1 w - -";
      string str392 = "b1d2{72}";
      char[] chArray392 = new char[1]{ ' ' };
      foreach (string move in str392.Split(chArray392))
        openingMove392.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove392);
      OpeningMove openingMove393 = new OpeningMove();
      openingMove393.StartingFEN = "rnbqkbnr/pp3ppp/8/2pp4/3P4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
      string str393 = "g2g3{6}";
      char[] chArray393 = new char[1]{ ' ' };
      foreach (string move in str393.Split(chArray393))
        openingMove393.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove393);
      OpeningMove openingMove394 = new OpeningMove();
      openingMove394.StartingFEN = "r1bqkbnr/pppppppp/2n5/8/2P5/8/PP1PPPPP/RNBQKBNR w KQkq -";
      string str394 = "b1c3{6}";
      char[] chArray394 = new char[1]{ ' ' };
      foreach (string move in str394.Split(chArray394))
        openingMove394.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove394);
      OpeningMove openingMove395 = new OpeningMove();
      openingMove395.StartingFEN = "rnbqkb1r/pppppp1p/5np1/8/2P5/5NP1/PP1PPP1P/RNBQKB1R b KQkq -";
      string str395 = "f8g7{22}";
      char[] chArray395 = new char[1]{ ' ' };
      foreach (string move in str395.Split(chArray395))
        openingMove395.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove395);
      OpeningMove openingMove396 = new OpeningMove();
      openingMove396.StartingFEN = "rnb1kb1r/1pqp1ppp/p3pn2/8/3NP3/3B4/PPP2PPP/RNBQ1RK1 w kq -";
      string str396 = "d1e2{5} c2c4{5}";
      char[] chArray396 = new char[1]{ ' ' };
      foreach (string move in str396.Split(chArray396))
        openingMove396.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove396);
      OpeningMove openingMove397 = new OpeningMove();
      openingMove397.StartingFEN = "r1bq1rk1/2ppbppp/p1n2n2/1p2p3/4P3/1B3N2/PPPP1PPP/RNBQR1K1 w - -";
      string str397 = "c2c3{50} a2a4{17} h2h3{51} d2d3{10} a2a3{5}";
      char[] chArray397 = new char[1]{ ' ' };
      foreach (string move in str397.Split(chArray397))
        openingMove397.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove397);
      OpeningMove openingMove398 = new OpeningMove();
      openingMove398.StartingFEN = "r1bqkbnr/pp1ppp1p/2n3p1/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
      string str398 = "c2c4{15} b1c3{5}";
      char[] chArray398 = new char[1]{ ' ' };
      foreach (string move in str398.Split(chArray398))
        openingMove398.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove398);
      OpeningMove openingMove399 = new OpeningMove();
      openingMove399.StartingFEN = "r1b1kbnr/1pqp1ppp/p1n1p3/8/3NP3/2N5/PPP1BPPP/R1BQK2R w KQkq -";
      string str399 = "e1g1{31} c1e3{5}";
      char[] chArray399 = new char[1]{ ' ' };
      foreach (string move in str399.Split(chArray399))
        openingMove399.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove399);
      OpeningMove openingMove400 = new OpeningMove();
      openingMove400.StartingFEN = "rnbqkbnr/pp3ppp/4p3/2ppP3/3P4/8/PPP2PPP/RNBQKBNR w KQkq c6";
      string str400 = "c2c3{20}";
      char[] chArray400 = new char[1]{ ' ' };
      foreach (string move in str400.Split(chArray400))
        openingMove400.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove400);
      OpeningMove openingMove401 = new OpeningMove();
      openingMove401.StartingFEN = "rnbqkb1r/pp3ppp/4pn2/2pp4/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq c6";
      string str401 = "c4d5{6}";
      char[] chArray401 = new char[1]{ ' ' };
      foreach (string move in str401.Split(chArray401))
        openingMove401.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove401);
      OpeningMove openingMove402 = new OpeningMove();
      openingMove402.StartingFEN = "r1bqkbnr/pppp1p1p/2n3p1/4p3/2P5/2N3P1/PP1PPP1P/R1BQKBNR w KQkq -";
      string str402 = "f1g2{6}";
      char[] chArray402 = new char[1]{ ' ' };
      foreach (string move in str402.Split(chArray402))
        openingMove402.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove402);
      OpeningMove openingMove403 = new OpeningMove();
      openingMove403.StartingFEN = "rnbqkb1r/pp1p1ppp/5n2/2pPp3/2P5/8/PP2PPPP/RNBQKBNR w KQkq e6";
      string str403 = "b1c3{5}";
      char[] chArray403 = new char[1]{ ' ' };
      foreach (string move in str403.Split(chArray403))
        openingMove403.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove403);
      OpeningMove openingMove404 = new OpeningMove();
      openingMove404.StartingFEN = "rnbqkbnr/pp1ppppp/8/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R b KQkq e3";
      string str404 = "e7e6{5} d7d6{5}";
      char[] chArray404 = new char[1]{ ' ' };
      foreach (string move in str404.Split(chArray404))
        openingMove404.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove404);
      OpeningMove openingMove405 = new OpeningMove();
      openingMove405.StartingFEN = "r2q1rk1/1bp1bppp/p1np1n2/1p2p3/3PP3/1BP2N1P/PP3PP1/RNBQR1K1 b - d3";
      string str405 = "f8e8{45}";
      char[] chArray405 = new char[1]{ ' ' };
      foreach (string move in str405.Split(chArray405))
        openingMove405.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove405);
      OpeningMove openingMove406 = new OpeningMove();
      openingMove406.StartingFEN = "rnbqk2r/pp2ppbp/2p2np1/3p4/2PP4/5NP1/PP2PPBP/RNBQK2R w KQkq d6";
      string str406 = "c4d5{10}";
      char[] chArray406 = new char[1]{ ' ' };
      foreach (string move in str406.Split(chArray406))
        openingMove406.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove406);
      OpeningMove openingMove407 = new OpeningMove();
      openingMove407.StartingFEN = "rn1qkb1r/p1p2ppp/bp2pn2/3p4/2PP4/1P3NP1/P3PP1P/RNBQKB1R w KQkq d6";
      string str407 = "f1g2{20}";
      char[] chArray407 = new char[1]{ ' ' };
      foreach (string move in str407.Split(chArray407))
        openingMove407.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove407);
      OpeningMove openingMove408 = new OpeningMove();
      openingMove408.StartingFEN = "r2qr1k1/1bp1bppp/p1np1n2/1p2p3/3PP3/1BP2N1P/PP1N1PP1/R1BQR1K1 b - -";
      string str408 = "e7f8{40}";
      char[] chArray408 = new char[1]{ ' ' };
      foreach (string move in str408.Split(chArray408))
        openingMove408.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove408);
      OpeningMove openingMove409 = new OpeningMove();
      openingMove409.StartingFEN = "rnbq1rk1/ppp1ppbp/3p1np1/8/2PPP3/2N2P2/PP4PP/R1BQKBNR w KQ -";
      string str409 = "c1e3{61} c1g5{15}";
      char[] chArray409 = new char[1]{ ' ' };
      foreach (string move in str409.Split(chArray409))
        openingMove409.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove409);
      OpeningMove openingMove410 = new OpeningMove();
      openingMove410.StartingFEN = "r2qrbk1/1bp2ppp/p1np1n2/1p2p3/3PP3/1BP2N1P/PP1N1PP1/R1BQR1K1 w - -";
      string str410 = "a2a4{42} d4d5{15}";
      char[] chArray410 = new char[1]{ ' ' };
      foreach (string move in str410.Split(chArray410))
        openingMove410.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove410);
      OpeningMove openingMove411 = new OpeningMove();
      openingMove411.StartingFEN = "r2qrbk1/1bp2ppp/p1np1n2/1p2p3/P2PP3/1BP2N1P/1P1N1PP1/R1BQR1K1 b - a3";
      string str411 = "h7h6{30}";
      char[] chArray411 = new char[1]{ ' ' };
      foreach (string move in str411.Split(chArray411))
        openingMove411.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove411);
      OpeningMove openingMove412 = new OpeningMove();
      openingMove412.StartingFEN = "rnbq1rk1/ppp1ppbp/3p1np1/8/2PPP3/2N2N2/PP2BPPP/R1BQK2R b KQ -";
      string str412 = "e7e5{128} b8a6{5}";
      char[] chArray412 = new char[1]{ ' ' };
      foreach (string move in str412.Split(chArray412))
        openingMove412.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove412);
      OpeningMove openingMove413 = new OpeningMove();
      openingMove413.StartingFEN = "r1bq1rk1/2pn1ppp/p1np1b2/1p2p3/3PP3/1BP2N1P/PP3PP1/RNBQR1K1 w - -";
      string str413 = "a2a4{21}";
      char[] chArray413 = new char[1]{ ' ' };
      foreach (string move in str413.Split(chArray413))
        openingMove413.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove413);
      OpeningMove openingMove414 = new OpeningMove();
      openingMove414.StartingFEN = "rnbq1rk1/ppp2pbp/3p1np1/4p3/2PPP3/2N2N2/PP2BPPP/R1BQK2R w KQ e6";
      string str414 = "c1e3{20} e1g1{90} d4d5{5}";
      char[] chArray414 = new char[1]{ ' ' };
      foreach (string move in str414.Split(chArray414))
        openingMove414.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove414);
      OpeningMove openingMove415 = new OpeningMove();
      openingMove415.StartingFEN = "rnbqk2r/ppp1ppbp/6p1/8/3PP3/2P1B3/P4PPP/R2QKBNR b KQkq -";
      string str415 = "c7c5{10}";
      char[] chArray415 = new char[1]{ ' ' };
      foreach (string move in str415.Split(chArray415))
        openingMove415.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove415);
      OpeningMove openingMove416 = new OpeningMove();
      openingMove416.StartingFEN = "r1bq1rk1/2pn1ppp/p1np1b2/1p2p3/P2PP3/1BP2N1P/1P3PP1/RNBQR1K1 b - a3";
      string str416 = "c8b7{5}";
      char[] chArray416 = new char[1]{ ' ' };
      foreach (string move in str416.Split(chArray416))
        openingMove416.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove416);
      OpeningMove openingMove417 = new OpeningMove();
      openingMove417.StartingFEN = "r1bqkbnr/pppp1ppp/2n5/8/3pP3/5N2/PPP2PPP/RNBQKB1R w KQkq -";
      string str417 = "f3d4{64}";
      char[] chArray417 = new char[1]{ ' ' };
      foreach (string move in str417.Split(chArray417))
        openingMove417.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove417);
      OpeningMove openingMove418 = new OpeningMove();
      openingMove418.StartingFEN = "rnbqk2r/pp2ppbp/6p1/2p5/3PP3/2P1B3/P4PPP/R2QKBNR w KQkq c6";
      string str418 = "d1d2{25}";
      char[] chArray418 = new char[1]{ ' ' };
      foreach (string move in str418.Split(chArray418))
        openingMove418.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove418);
      OpeningMove openingMove419 = new OpeningMove();
      openingMove419.StartingFEN = "rnbq1rk1/pp2ppbp/6p1/2p5/3PP3/2P1B3/P2Q1PPP/R3KBNR w KQ -";
      string str419 = "g1f3{10}";
      char[] chArray419 = new char[1]{ ' ' };
      foreach (string move in str419.Split(chArray419))
        openingMove419.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove419);
      OpeningMove openingMove420 = new OpeningMove();
      openingMove420.StartingFEN = "r2q1rk1/1bpn1ppp/p1np1b2/1p2p3/P2PP3/1BP2N1P/1P3PP1/RNBQR1K1 w - -";
      string str420 = "b1a3{11}";
      char[] chArray420 = new char[1]{ ' ' };
      foreach (string move in str420.Split(chArray420))
        openingMove420.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove420);
      OpeningMove openingMove421 = new OpeningMove();
      openingMove421.StartingFEN = "rnbq1rk1/ppp2pbp/3p1np1/4p3/2PPP3/2N1BN2/PP2BPPP/R2QK2R b KQ -";
      string str421 = "c7c6{31} f6g4{10} e5d4{10}";
      char[] chArray421 = new char[1]{ ' ' };
      foreach (string move in str421.Split(chArray421))
        openingMove421.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove421);
      OpeningMove openingMove422 = new OpeningMove();
      openingMove422.StartingFEN = "r2qrbk1/1bp2pp1/p1np1n1p/1p2p3/P2PP3/1BP2N1P/1P1N1PP1/R1BQR1K1 w - -";
      string str422 = "b3c2{26}";
      char[] chArray422 = new char[1]{ ' ' };
      foreach (string move in str422.Split(chArray422))
        openingMove422.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove422);
      OpeningMove openingMove423 = new OpeningMove();
      openingMove423.StartingFEN = "rnbq1rk1/ppp2pbp/3p1np1/4p3/2PPP3/2N1BP2/PP4PP/R2QKBNR w KQ e6";
      string str423 = "d4d5{15} g1e2{10}";
      char[] chArray423 = new char[1]{ ' ' };
      foreach (string move in str423.Split(chArray423))
        openingMove423.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove423);
      OpeningMove openingMove424 = new OpeningMove();
      openingMove424.StartingFEN = "r2qrbk1/1bp2pp1/p1np1n1p/1p2p3/P2PP3/2P2N1P/1PBN1PP1/R1BQR1K1 b - -";
      string str424 = "e5d4{25}";
      char[] chArray424 = new char[1]{ ' ' };
      foreach (string move in str424.Split(chArray424))
        openingMove424.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove424);
      OpeningMove openingMove425 = new OpeningMove();
      openingMove425.StartingFEN = "rnbq1rk1/1pp1ppbp/p2p1np1/8/2PPP3/2N1BP2/PP4PP/R2QKBNR w KQ -";
      string str425 = "f1d3{5} d1d2{11}";
      char[] chArray425 = new char[1]{ ' ' };
      foreach (string move in str425.Split(chArray425))
        openingMove425.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove425);
      OpeningMove openingMove426 = new OpeningMove();
      openingMove426.StartingFEN = "rnbqkb1r/p1pp1ppp/1p2pn2/8/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
      string str426 = "g2g3{5}";
      char[] chArray426 = new char[1]{ ' ' };
      foreach (string move in str426.Split(chArray426))
        openingMove426.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove426);
      OpeningMove openingMove427 = new OpeningMove();
      openingMove427.StartingFEN = "rnbqkb1r/pp2pppp/2p2n2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
      string str427 = "e7e6{120} d5c4{61}";
      char[] chArray427 = new char[1]{ ' ' };
      foreach (string move in str427.Split(chArray427))
        openingMove427.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove427);
      OpeningMove openingMove428 = new OpeningMove();
      openingMove428.StartingFEN = "rn1qkb1r/p1p2ppp/bp2pn2/8/2pP4/1P3NP1/P3PPBP/RNBQK2R w KQkq -";
      string str428 = "f3e5{5}";
      char[] chArray428 = new char[1]{ ' ' };
      foreach (string move in str428.Split(chArray428))
        openingMove428.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove428);
      OpeningMove openingMove429 = new OpeningMove();
      openingMove429.StartingFEN = "r2q1rk1/1bp1bppp/p1np1n2/1p2p3/4P3/1BPP1N1P/PP3PP1/RNBQR1K1 b - -";
      string str429 = "f8e8{5}";
      char[] chArray429 = new char[1]{ ' ' };
      foreach (string move in str429.Split(chArray429))
        openingMove429.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove429);
      OpeningMove openingMove430 = new OpeningMove();
      openingMove430.StartingFEN = "rn1qkbnr/pp2pppp/2p5/3pPb2/3P4/8/PPP2PPP/RNBQKBNR w KQkq -";
      string str430 = "g1f3{40} b1c3{26} c2c3{5}";
      char[] chArray430 = new char[1]{ ' ' };
      foreach (string move in str430.Split(chArray430))
        openingMove430.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove430);
      OpeningMove openingMove431 = new OpeningMove();
      openingMove431.StartingFEN = "rnbqkb1r/pp2pppp/2p2n2/3p4/2PP4/5N2/PPQ1PPPP/RNB1KB1R b KQkq -";
      string str431 = "d5c4{5}";
      char[] chArray431 = new char[1]{ ' ' };
      foreach (string move in str431.Split(chArray431))
        openingMove431.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove431);
      OpeningMove openingMove432 = new OpeningMove();
      openingMove432.StartingFEN = "rnbqk2r/ppp1ppbp/3p1np1/8/2PPP3/2N5/PP2BPPP/R1BQK1NR b KQkq -";
      string str432 = "e8g8{33}";
      char[] chArray432 = new char[1]{ ' ' };
      foreach (string move in str432.Split(chArray432))
        openingMove432.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove432);
      OpeningMove openingMove433 = new OpeningMove();
      openingMove433.StartingFEN = "rn1q1rk1/1bpp1pp1/1p2pn1p/p7/1bPP4/1P3NP1/P1QBPPBP/RN3RK1 w - -";
      string str433 = "b1c3{5} a2a3{5}";
      char[] chArray433 = new char[1]{ ' ' };
      foreach (string move in str433.Split(chArray433))
        openingMove433.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove433);
      OpeningMove openingMove434 = new OpeningMove();
      openingMove434.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/8/2pP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str434 = "d1a4{20} e2e4{15}";
      char[] chArray434 = new char[1]{ ' ' };
      foreach (string move in str434.Split(chArray434))
        openingMove434.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove434);
      OpeningMove openingMove435 = new OpeningMove();
      openingMove435.StartingFEN = "rnbqkb1r/pp1ppppp/2p2n2/8/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
      string str435 = "b1c3{11} d2d4{5}";
      char[] chArray435 = new char[1]{ ' ' };
      foreach (string move in str435.Split(chArray435))
        openingMove435.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove435);
      OpeningMove openingMove436 = new OpeningMove();
      openingMove436.StartingFEN = "r1bqkb1r/pppp1ppp/2n2n2/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
      string str436 = "d4c6{36}";
      char[] chArray436 = new char[1]{ ' ' };
      foreach (string move in str436.Split(chArray436))
        openingMove436.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove436);
      OpeningMove openingMove437 = new OpeningMove();
      openingMove437.StartingFEN = "rnbqkb1r/pp2pppp/2p2n2/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
      string str437 = "e2e3{78} g1f3{66}";
      char[] chArray437 = new char[1]{ ' ' };
      foreach (string move in str437.Split(chArray437))
        openingMove437.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove437);
      OpeningMove openingMove438 = new OpeningMove();
      openingMove438.StartingFEN = "r1bqk2r/pppp1ppp/2n2n2/3Np3/1bP5/5NP1/PP1PPP1P/R1BQKB1R b KQkq -";
      string str438 = "b4c5{10}";
      char[] chArray438 = new char[1]{ ' ' };
      foreach (string move in str438.Split(chArray438))
        openingMove438.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove438);
      OpeningMove openingMove439 = new OpeningMove();
      openingMove439.StartingFEN = "r1bqkbnr/pp1ppppp/2n5/2p5/3PP3/5N2/PPP2PPP/RNBQKB1R b KQkq d3";
      string str439 = "c5d4{274}";
      char[] chArray439 = new char[1]{ ' ' };
      foreach (string move in str439.Split(chArray439))
        openingMove439.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove439);
      OpeningMove openingMove440 = new OpeningMove();
      openingMove440.StartingFEN = "rnbqk2r/ppp1bppp/4pn2/3p4/2PP1B2/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
      string str440 = "e8g8{26}";
      char[] chArray440 = new char[1]{ ' ' };
      foreach (string move in str440.Split(chArray440))
        openingMove440.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove440);
      OpeningMove openingMove441 = new OpeningMove();
      openingMove441.StartingFEN = "r2qr1k1/1bp1bpp1/p1np1n1p/1p2p3/3PP3/1BP2N1P/PP1N1PP1/R1BQR1K1 w - -";
      string str441 = "d2f1{5} b3c2{5}";
      char[] chArray441 = new char[1]{ ' ' };
      foreach (string move in str441.Split(chArray441))
        openingMove441.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove441);
      OpeningMove openingMove442 = new OpeningMove();
      openingMove442.StartingFEN = "r1bqkbnr/pppp1ppp/2n5/4p3/2P5/2N3P1/PP1PPP1P/R1BQKBNR b KQkq -";
      string str442 = "g7g6{5}";
      char[] chArray442 = new char[1]{ ' ' };
      foreach (string move in str442.Split(chArray442))
        openingMove442.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove442);
      OpeningMove openingMove443 = new OpeningMove();
      openingMove443.StartingFEN = "rnbqk2r/p1pp1ppp/1p2pn2/8/1bPP4/1QN2N2/PP2PPPP/R1B1KB1R b KQkq -";
      string str443 = "c7c5{16}";
      char[] chArray443 = new char[1]{ ' ' };
      foreach (string move in str443.Split(chArray443))
        openingMove443.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove443);
      OpeningMove openingMove444 = new OpeningMove();
      openingMove444.StartingFEN = "rnbq1rk1/ppp2pbp/3p2p1/3Pp2n/2P1P3/2N1BP2/PP4PP/R2QKBNR w KQ -";
      string str444 = "d1d2{5}";
      char[] chArray444 = new char[1]{ ' ' };
      foreach (string move in str444.Split(chArray444))
        openingMove444.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove444);
      OpeningMove openingMove445 = new OpeningMove();
      openingMove445.StartingFEN = "rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/2N1PN2/PP3PPP/R1BQKB1R b KQkq -";
      string str445 = "b8c6{5}";
      char[] chArray445 = new char[1]{ ' ' };
      foreach (string move in str445.Split(chArray445))
        openingMove445.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove445);
      OpeningMove openingMove446 = new OpeningMove();
      openingMove446.StartingFEN = "rnbqk2r/pp2bppp/2p2n2/3p2B1/3P4/2N1P3/PP3PPP/R2QKBNR w KQkq -";
      string str446 = "f1d3{5}";
      char[] chArray446 = new char[1]{ ' ' };
      foreach (string move in str446.Split(chArray446))
        openingMove446.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove446);
      OpeningMove openingMove447 = new OpeningMove();
      openingMove447.StartingFEN = "rnbq1rk1/ppppppbp/5np1/8/2PP4/5NP1/PP2PP1P/RNBQKB1R w KQ -";
      string str447 = "f1g2{26}";
      char[] chArray447 = new char[1]{ ' ' };
      foreach (string move in str447.Split(chArray447))
        openingMove447.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove447);
      OpeningMove openingMove448 = new OpeningMove();
      openingMove448.StartingFEN = "rnbqkb1r/pp1p1ppp/4pn2/2p5/2P1P3/2N5/PP1P1PPP/R1BQKBNR w KQkq c6";
      string str448 = "e4e5{6}";
      char[] chArray448 = new char[1]{ ' ' };
      foreach (string move in str448.Split(chArray448))
        openingMove448.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove448);
      OpeningMove openingMove449 = new OpeningMove();
      openingMove449.StartingFEN = "rnbqkb1r/pp3ppp/2p1pn2/3p4/2PP4/2N1P3/PP3PPP/R1BQKBNR w KQkq -";
      string str449 = "g1f3{61}";
      char[] chArray449 = new char[1]{ ' ' };
      foreach (string move in str449.Split(chArray449))
        openingMove449.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove449);
      OpeningMove openingMove450 = new OpeningMove();
      openingMove450.StartingFEN = "rnbqkbnr/pp1ppppp/8/2p5/4P3/2N5/PPPP1PPP/R1BQKBNR b KQkq -";
      string str450 = "d7d6{32} e7e6{20} b8c6{30} g7g6{15}";
      char[] chArray450 = new char[1]{ ' ' };
      foreach (string move in str450.Split(chArray450))
        openingMove450.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove450);
      OpeningMove openingMove451 = new OpeningMove();
      openingMove451.StartingFEN = "rnbqkbnr/ppp1pppp/3p4/8/3PP3/8/PPP2PPP/RNBQKBNR b KQkq e3";
      string str451 = "g8f6{5}";
      char[] chArray451 = new char[1]{ ' ' };
      foreach (string move in str451.Split(chArray451))
        openingMove451.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove451);
      OpeningMove openingMove452 = new OpeningMove();
      openingMove452.StartingFEN = "rnbqkb1r/pp2pppp/8/2pn4/8/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
      string str452 = "d2d4{20}";
      char[] chArray452 = new char[1]{ ' ' };
      foreach (string move in str452.Split(chArray452))
        openingMove452.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove452);
      OpeningMove openingMove453 = new OpeningMove();
      openingMove453.StartingFEN = "rnbqkbnr/pp1ppppp/8/2p5/4P3/2P5/PP1P1PPP/RNBQKBNR b KQkq -";
      string str453 = "e7e6{10} d7d5{5}";
      char[] chArray453 = new char[1]{ ' ' };
      foreach (string move in str453.Split(chArray453))
        openingMove453.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove453);
      OpeningMove openingMove454 = new OpeningMove();
      openingMove454.StartingFEN = "r1b1kbnr/ppqppppp/2n5/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
      string str454 = "b1c3{5} c2c4{5} d4b5{5} f1e2{5}";
      char[] chArray454 = new char[1]{ ' ' };
      foreach (string move in str454.Split(chArray454))
        openingMove454.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove454);
      OpeningMove openingMove455 = new OpeningMove();
      openingMove455.StartingFEN = "rnbqkb1r/pp3ppp/2p1pn2/8/Q1pP4/2N2N2/PP2PPPP/R1B1KB1R w KQkq -";
      string str455 = "a4c4{15}";
      char[] chArray455 = new char[1]{ ' ' };
      foreach (string move in str455.Split(chArray455))
        openingMove455.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove455);
      OpeningMove openingMove456 = new OpeningMove();
      openingMove456.StartingFEN = "rnbqkb1r/ppppp1pp/5n2/5p2/3P4/6P1/PPP1PP1P/RNBQKBNR w KQkq -";
      string str456 = "f1g2{25}";
      char[] chArray456 = new char[1]{ ' ' };
      foreach (string move in str456.Split(chArray456))
        openingMove456.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove456);
      OpeningMove openingMove457 = new OpeningMove();
      openingMove457.StartingFEN = "rnbqk2r/ppppppbp/5np1/8/2P1P3/2N2N2/PP1P1PPP/R1BQKB1R b KQkq e3";
      string str457 = "d7d6{56}";
      char[] chArray457 = new char[1]{ ' ' };
      foreach (string move in str457.Split(chArray457))
        openingMove457.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove457);
      OpeningMove openingMove458 = new OpeningMove();
      openingMove458.StartingFEN = "rnbqkbnr/ppp1pppp/3p4/8/3PP3/8/PPP2PPP/RNBQKBNR b KQkq d3";
      string str458 = "g8f6{10} g7g6{5}";
      char[] chArray458 = new char[1]{ ' ' };
      foreach (string move in str458.Split(chArray458))
        openingMove458.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove458);
      OpeningMove openingMove459 = new OpeningMove();
      openingMove459.StartingFEN = "r1bqkb1r/pppp1ppp/2n2n2/4p3/2P1P3/2N2N2/PP1P1PPP/R1BQKB1R b KQkq e3";
      string str459 = "f8b4{5}";
      char[] chArray459 = new char[1]{ ' ' };
      foreach (string move in str459.Split(chArray459))
        openingMove459.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove459);
      OpeningMove openingMove460 = new OpeningMove();
      openingMove460.StartingFEN = "rnbqkb1r/pp1ppppp/5n2/2p5/8/5NP1/PPPPPP1P/RNBQKB1R w KQkq c6";
      string str460 = "f1g2{5}";
      char[] chArray460 = new char[1]{ ' ' };
      foreach (string move in str460.Split(chArray460))
        openingMove460.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove460);
      OpeningMove openingMove461 = new OpeningMove();
      openingMove461.StartingFEN = "rnbqkbnr/pp2pppp/2p5/3p4/3PP3/2N5/PPP2PPP/R1BQKBNR b KQkq -";
      string str461 = "d5e4{60}";
      char[] chArray461 = new char[1]{ ' ' };
      foreach (string move in str461.Split(chArray461))
        openingMove461.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove461);
      OpeningMove openingMove462 = new OpeningMove();
      openingMove462.StartingFEN = "r2qkb1r/pp1bpppp/2np1n2/6B1/3NP3/2N5/PPP2PPP/R2QKB1R w KQkq -";
      string str462 = "d1d2{5}";
      char[] chArray462 = new char[1]{ ' ' };
      foreach (string move in str462.Split(chArray462))
        openingMove462.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove462);
      OpeningMove openingMove463 = new OpeningMove();
      openingMove463.StartingFEN = "r1bq1rk1/pp1nppbp/6p1/2p5/3PP3/2P1BN2/P2Q1PPP/R3KB1R w KQ -";
      string str463 = "f1d3{5}";
      char[] chArray463 = new char[1]{ ' ' };
      foreach (string move in str463.Split(chArray463))
        openingMove463.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove463);
      OpeningMove openingMove464 = new OpeningMove();
      openingMove464.StartingFEN = "rnbqk2r/ppp2ppp/4pn2/3p4/1bPP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str464 = "c4d5{5} c1g5{5}";
      char[] chArray464 = new char[1]{ ' ' };
      foreach (string move in str464.Split(chArray464))
        openingMove464.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove464);
      OpeningMove openingMove465 = new OpeningMove();
      openingMove465.StartingFEN = "rn1qk2r/pbppbppp/1p2p3/8/2PPn3/2N2NP1/PP2PPBP/R1BQK2R w KQkq -";
      string str465 = "c1d2{25}";
      char[] chArray465 = new char[1]{ ' ' };
      foreach (string move in str465.Split(chArray465))
        openingMove465.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove465);
      OpeningMove openingMove466 = new OpeningMove();
      openingMove466.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/8/3Pp3/8/PPPN1PPP/R1BQKBNR w KQkq -";
      string str466 = "d2e4{5}";
      char[] chArray466 = new char[1]{ ' ' };
      foreach (string move in str466.Split(chArray466))
        openingMove466.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove466);
      OpeningMove openingMove467 = new OpeningMove();
      openingMove467.StartingFEN = "rn1qkb1r/pbp2ppp/1p2pn2/3p4/Q1PP4/P1N2N2/1P2PPPP/R1B1KB1R b KQkq -";
      string str467 = "d8d7{5}";
      char[] chArray467 = new char[1]{ ' ' };
      foreach (string move in str467.Split(chArray467))
        openingMove467.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove467);
      OpeningMove openingMove468 = new OpeningMove();
      openingMove468.StartingFEN = "rnbq1rk1/pp3pbp/2pp1np1/4P3/2P1P3/2N1BN2/PP2BPPP/R2QK2R b KQ -";
      string str468 = "d6e5{5}";
      char[] chArray468 = new char[1]{ ' ' };
      foreach (string move in str468.Split(chArray468))
        openingMove468.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove468);
      OpeningMove openingMove469 = new OpeningMove();
      openingMove469.StartingFEN = "r2qrbk1/1bp2pp1/p1np1n1p/1p6/P2pP3/2P2N1P/1PBN1PP1/R1BQR1K1 w - -";
      string str469 = "c3d4{15}";
      char[] chArray469 = new char[1]{ ' ' };
      foreach (string move in str469.Split(chArray469))
        openingMove469.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove469);
      OpeningMove openingMove470 = new OpeningMove();
      openingMove470.StartingFEN = "rnbq1rk1/ppp1bppp/5n2/3p2B1/3P4/2N1P3/PP3PPP/R2QKBNR w KQ -";
      string str470 = "f1d3{10}";
      char[] chArray470 = new char[1]{ ' ' };
      foreach (string move in str470.Split(chArray470))
        openingMove470.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove470);
      OpeningMove openingMove471 = new OpeningMove();
      openingMove471.StartingFEN = "rnbqkbnr/ppp2p1p/3p2p1/4p3/2P5/2N3P1/PP1PPP1P/R1BQKBNR w KQkq -";
      string str471 = "d2d4{5}";
      char[] chArray471 = new char[1]{ ' ' };
      foreach (string move in str471.Split(chArray471))
        openingMove471.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove471);
      OpeningMove openingMove472 = new OpeningMove();
      openingMove472.StartingFEN = "r1bqkb1r/pp1n1ppp/2p1pn2/3p4/2PP4/2N1PN2/PP3PPP/R1BQKB1R w KQkq -";
      string str472 = "d1c2{75} f1d3{45}";
      char[] chArray472 = new char[1]{ ' ' };
      foreach (string move in str472.Split(chArray472))
        openingMove472.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove472);
      OpeningMove openingMove473 = new OpeningMove();
      openingMove473.StartingFEN = "r1bqk2r/pp1n1ppp/2pbpn2/3p4/2PP4/2N1PN2/PPQ2PPP/R1B1KB1R w KQkq -";
      string str473 = "f1e2{25} b2b3{5} f1d3{40}";
      char[] chArray473 = new char[1]{ ' ' };
      foreach (string move in str473.Split(chArray473))
        openingMove473.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove473);
      OpeningMove openingMove474 = new OpeningMove();
      openingMove474.StartingFEN = "rnbqk2r/p1pp1ppp/1p2pn2/8/1bPP4/2N1P3/PP3PPP/R1BQKBNR w KQkq -";
      string str474 = "g1e2{10}";
      char[] chArray474 = new char[1]{ ' ' };
      foreach (string move in str474.Split(chArray474))
        openingMove474.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove474);
      OpeningMove openingMove475 = new OpeningMove();
      openingMove475.StartingFEN = "rnbqk1nr/ppp2ppp/4p3/3p4/1bPP4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
      string str475 = "g1f3{10} e2e3{6}";
      char[] chArray475 = new char[1]{ ' ' };
      foreach (string move in str475.Split(chArray475))
        openingMove475.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove475);
      OpeningMove openingMove476 = new OpeningMove();
      openingMove476.StartingFEN = "rnbqkbnr/pp2pppp/2p5/3P4/3P4/8/PPP2PPP/RNBQKBNR b KQkq -";
      string str476 = "c6d5{30}";
      char[] chArray476 = new char[1]{ ' ' };
      foreach (string move in str476.Split(chArray476))
        openingMove476.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove476);
      OpeningMove openingMove477 = new OpeningMove();
      openingMove477.StartingFEN = "rnbqk2r/ppp2ppp/4pn2/3p4/1bPP4/P1N2P2/1P2P1PP/R1BQKBNR b KQkq -";
      string str477 = "b4c3{10}";
      char[] chArray477 = new char[1]{ ' ' };
      foreach (string move in str477.Split(chArray477))
        openingMove477.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove477);
      OpeningMove openingMove478 = new OpeningMove();
      openingMove478.StartingFEN = "rnbqkbnr/1p1p1p1p/p3p1p1/8/3NP3/3B4/PPP2PPP/RNBQK2R w KQkq -";
      string str478 = "e1g1{5}";
      char[] chArray478 = new char[1]{ ' ' };
      foreach (string move in str478.Split(chArray478))
        openingMove478.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove478);
      OpeningMove openingMove479 = new OpeningMove();
      openingMove479.StartingFEN = "rnbqkbnr/pppp1ppp/4p3/8/3PP3/8/PPP2PPP/RNBQKBNR b KQkq d3";
      string str479 = "d7d5{135}";
      char[] chArray479 = new char[1]{ ' ' };
      foreach (string move in str479.Split(chArray479))
        openingMove479.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove479);
      OpeningMove openingMove480 = new OpeningMove();
      openingMove480.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/3p4/3PP3/8/PPPN1PPP/R1BQKBNR b KQkq -";
      string str480 = "c7c5{15} f8e7{15}";
      char[] chArray480 = new char[1]{ ' ' };
      foreach (string move in str480.Split(chArray480))
        openingMove480.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove480);
      OpeningMove openingMove481 = new OpeningMove();
      openingMove481.StartingFEN = "rnbqkbnr/ppp1pppp/8/8/2pP4/5N2/PP2PPPP/RNBQKB1R b KQkq -";
      string str481 = "g8f6{15} a7a6{10} e7e6{10}";
      char[] chArray481 = new char[1]{ ' ' };
      foreach (string move in str481.Split(chArray481))
        openingMove481.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove481);
      OpeningMove openingMove482 = new OpeningMove();
      openingMove482.StartingFEN = "rnbq1rk1/ppp1ppbp/3p1np1/8/3PP3/2N2N2/PPP1BPPP/R1BQK2R w KQ -";
      string str482 = "e1g1{5}";
      char[] chArray482 = new char[1]{ ' ' };
      foreach (string move in str482.Split(chArray482))
        openingMove482.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove482);
      OpeningMove openingMove483 = new OpeningMove();
      openingMove483.StartingFEN = "rn1qk2r/pb1p1ppp/1p2pn2/2p5/1bPP4/1P3NP1/P2BPPBP/RN1QK2R w KQkq c6";
      string str483 = "e1g1{5}";
      char[] chArray483 = new char[1]{ ' ' };
      foreach (string move in str483.Split(chArray483))
        openingMove483.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove483);
      OpeningMove openingMove484 = new OpeningMove();
      openingMove484.StartingFEN = "r1bq1rk1/pp1n1ppp/2pbpn2/3p4/2PP4/2N1PN2/PPQ1BPPP/R1B1K2R w KQ -";
      string str484 = "e1g1{15}";
      char[] chArray484 = new char[1]{ ' ' };
      foreach (string move in str484.Split(chArray484))
        openingMove484.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove484);
      OpeningMove openingMove485 = new OpeningMove();
      openingMove485.StartingFEN = "r1bq1rk1/pp1n1ppp/2pbpn2/8/2pP4/2N1PN2/PPQ1BPPP/R1B2RK1 w - -";
      string str485 = "e2c4{5}";
      char[] chArray485 = new char[1]{ ' ' };
      foreach (string move in str485.Split(chArray485))
        openingMove485.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove485);
      OpeningMove openingMove486 = new OpeningMove();
      openingMove486.StartingFEN = "rnbq1rk1/pppp1ppp/4pn2/8/2PP4/P1Q5/1P2PPPP/R1B1KBNR b KQ -";
      string str486 = "b7b6{70}";
      char[] chArray486 = new char[1]{ ' ' };
      foreach (string move in str486.Split(chArray486))
        openingMove486.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove486);
      OpeningMove openingMove487 = new OpeningMove();
      openingMove487.StartingFEN = "rnbqk2r/ppp2ppp/4pn2/3p4/2PP4/P1P2P2/4P1PP/R1BQKBNR b KQkq -";
      string str487 = "c7c5{5}";
      char[] chArray487 = new char[1]{ ' ' };
      foreach (string move in str487.Split(chArray487))
        openingMove487.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove487);
      OpeningMove openingMove488 = new OpeningMove();
      openingMove488.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/8/3NPP2/2N2Q2/PPP3PP/R1B1KB1R b KQkq -";
      string str488 = "d8b6{22}";
      char[] chArray488 = new char[1]{ ' ' };
      foreach (string move in str488.Split(chArray488))
        openingMove488.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove488);
      OpeningMove openingMove489 = new OpeningMove();
      openingMove489.StartingFEN = "rnbqkb1r/ppp2ppp/3p1n2/4p3/3PP3/3B4/PPP2PPP/RNBQK1NR w KQkq e6";
      string str489 = "c2c3{5}";
      char[] chArray489 = new char[1]{ ' ' };
      foreach (string move in str489.Split(chArray489))
        openingMove489.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove489);
      OpeningMove openingMove490 = new OpeningMove();
      openingMove490.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/3p4/3PP3/2N5/PPP2PPP/R1BQKBNR w KQkq -";
      string str490 = "e4e5{52} c1g5{88}";
      char[] chArray490 = new char[1]{ ' ' };
      foreach (string move in str490.Split(chArray490))
        openingMove490.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove490);
      OpeningMove openingMove491 = new OpeningMove();
      openingMove491.StartingFEN = "r1bqkb1r/p1pp1ppp/2p2n2/8/4P3/8/PPP2PPP/RNBQKB1R w KQkq -";
      string str491 = "e4e5{30}";
      char[] chArray491 = new char[1]{ ' ' };
      foreach (string move in str491.Split(chArray491))
        openingMove491.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove491);
      OpeningMove openingMove492 = new OpeningMove();
      openingMove492.StartingFEN = "rnbqkb1r/pp3ppp/2p1pn2/3p4/2PP4/2N1PN2/PP3PPP/R1BQKB1R b KQkq -";
      string str492 = "b8d7{96}";
      char[] chArray492 = new char[1]{ ' ' };
      foreach (string move in str492.Split(chArray492))
        openingMove492.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove492);
      OpeningMove openingMove493 = new OpeningMove();
      openingMove493.StartingFEN = "rnbq1rk1/ppp2pbp/3p1np1/4p3/2PPP3/2N1BP2/PP2N1PP/R2QKB1R b KQ -";
      string str493 = "c7c6{18}";
      char[] chArray493 = new char[1]{ ' ' };
      foreach (string move in str493.Split(chArray493))
        openingMove493.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove493);
      OpeningMove openingMove494 = new OpeningMove();
      openingMove494.StartingFEN = "rnbqk1nr/1p1p1ppp/p3p3/2b5/3NP3/3B4/PPP2PPP/RNBQK2R w KQkq -";
      string str494 = "d4b3{10}";
      char[] chArray494 = new char[1]{ ' ' };
      foreach (string move in str494.Split(chArray494))
        openingMove494.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove494);
      OpeningMove openingMove495 = new OpeningMove();
      openingMove495.StartingFEN = "r1bqkb1r/pppn1ppp/4pn2/3P4/3P4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
      string str495 = "e6d5{15}";
      char[] chArray495 = new char[1]{ ' ' };
      foreach (string move in str495.Split(chArray495))
        openingMove495.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove495);
      OpeningMove openingMove496 = new OpeningMove();
      openingMove496.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/8/3Pp3/2N5/PPP2PPP/R1BQKBNR w KQkq -";
      string str496 = "c3e4{20}";
      char[] chArray496 = new char[1]{ ' ' };
      foreach (string move in str496.Split(chArray496))
        openingMove496.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove496);
      OpeningMove openingMove497 = new OpeningMove();
      openingMove497.StartingFEN = "r1bqkb1r/ppp2ppp/2n5/3np3/8/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq -";
      string str497 = "f1g2{16}";
      char[] chArray497 = new char[1]{ ' ' };
      foreach (string move in str497.Split(chArray497))
        openingMove497.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove497);
      OpeningMove openingMove498 = new OpeningMove();
      openingMove498.StartingFEN = "r1bqkbnr/pp3ppp/2npp3/1N6/4P3/8/PPP2PPP/RNBQKB1R w KQkq -";
      string str498 = "c2c4{10}";
      char[] chArray498 = new char[1]{ ' ' };
      foreach (string move in str498.Split(chArray498))
        openingMove498.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove498);
      OpeningMove openingMove499 = new OpeningMove();
      openingMove499.StartingFEN = "rnbqkb1r/pppppppp/5n2/8/4P3/8/PPPP1PPP/RNBQKBNR w KQkq -";
      string str499 = "e4e5{22}";
      char[] chArray499 = new char[1]{ ' ' };
      foreach (string move in str499.Split(chArray499))
        openingMove499.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove499);
      OpeningMove openingMove500 = new OpeningMove();
      openingMove500.StartingFEN = "rnbq1rk1/pp3pbp/2pp1np1/4p3/2PPP3/2N1BN2/PP1QBPPP/R3K2R b KQ -";
      string str500 = "e5d4{6} d8e7{10}";
      char[] chArray500 = new char[1]{ ' ' };
      foreach (string move in str500.Split(chArray500))
        openingMove500.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove500);
      OpeningMove openingMove501 = new OpeningMove();
      openingMove501.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/3p4/3PP3/2N5/PPP2PPP/R1BQKBNR b KQkq -";
      string str501 = "f8b4{15} d5e4{10} g8f6{55} b8c6{5}";
      char[] chArray501 = new char[1]{ ' ' };
      foreach (string move in str501.Split(chArray501))
        openingMove501.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove501);
      OpeningMove openingMove502 = new OpeningMove();
      openingMove502.StartingFEN = "r1bqkb1r/pp1npppp/2p2n2/6N1/3P4/8/PPP2PPP/R1BQKBNR w KQkq -";
      string str502 = "f1c4{6} f1d3{42}";
      char[] chArray502 = new char[1]{ ' ' };
      foreach (string move in str502.Split(chArray502))
        openingMove502.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove502);
      OpeningMove openingMove503 = new OpeningMove();
      openingMove503.StartingFEN = "r1bqk1nr/pppp1ppp/2n5/2b5/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
      string str503 = "c1e3{6} d4c6{11}";
      char[] chArray503 = new char[1]{ ' ' };
      foreach (string move in str503.Split(chArray503))
        openingMove503.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove503);
      OpeningMove openingMove504 = new OpeningMove();
      openingMove504.StartingFEN = "rnbqk1nr/ppppppbp/6p1/8/2P5/2N3P1/PP1PPP1P/R1BQKBNR b KQkq -";
      string str504 = "e7e5{17}";
      char[] chArray504 = new char[1]{ ' ' };
      foreach (string move in str504.Split(chArray504))
        openingMove504.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove504);
      OpeningMove openingMove505 = new OpeningMove();
      openingMove505.StartingFEN = "r1bqkbnr/pp1ppppp/2n5/2p5/2P5/4PN2/PP1P1PPP/RNBQKB1R b KQkq -";
      string str505 = "e7e5{5}";
      char[] chArray505 = new char[1]{ ' ' };
      foreach (string move in str505.Split(chArray505))
        openingMove505.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove505);
      OpeningMove openingMove506 = new OpeningMove();
      openingMove506.StartingFEN = "rnbq1rk1/ppppppbp/5np1/8/2PP4/5NP1/PP2PPBP/RNBQK2R b KQ -";
      string str506 = "d7d6{12}";
      char[] chArray506 = new char[1]{ ' ' };
      foreach (string move in str506.Split(chArray506))
        openingMove506.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove506);
      OpeningMove openingMove507 = new OpeningMove();
      openingMove507.StartingFEN = "rnbq1rk1/ppp2pbp/3p1np1/4p3/2PPP3/2N2N2/PP2BPPP/R1BQ1RK1 b - -";
      string str507 = "b8c6{46} b8a6{5}";
      char[] chArray507 = new char[1]{ ' ' };
      foreach (string move in str507.Split(chArray507))
        openingMove507.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove507);
      OpeningMove openingMove508 = new OpeningMove();
      openingMove508.StartingFEN = "r1bq1rk1/ppp2pbp/2np1np1/4p3/2PPP3/2N2N2/PP2BPPP/R1BQ1RK1 w - -";
      string str508 = "d4d5{60}";
      char[] chArray508 = new char[1]{ ' ' };
      foreach (string move in str508.Split(chArray508))
        openingMove508.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove508);
      OpeningMove openingMove509 = new OpeningMove();
      openingMove509.StartingFEN = "rnbqkb1r/pppp2pp/4pn2/5p2/3P4/6P1/PPP1PPBP/RNBQK1NR w KQkq -";
      string str509 = "g1h3{5} c2c4{5}";
      char[] chArray509 = new char[1]{ ' ' };
      foreach (string move in str509.Split(chArray509))
        openingMove509.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove509);
      OpeningMove openingMove510 = new OpeningMove();
      openingMove510.StartingFEN = "rnbqkb1r/p1pp1ppp/1p2pn2/8/2PP4/4PN2/PP3PPP/RNBQKB1R b KQkq -";
      string str510 = "c8b7{10}";
      char[] chArray510 = new char[1]{ ' ' };
      foreach (string move in str510.Split(chArray510))
        openingMove510.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove510);
      OpeningMove openingMove511 = new OpeningMove();
      openingMove511.StartingFEN = "rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/1P3NP1/P3PPBP/RNBQK2R b KQkq -";
      string str511 = "f8b4{15}";
      char[] chArray511 = new char[1]{ ' ' };
      foreach (string move in str511.Split(chArray511))
        openingMove511.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove511);
      OpeningMove openingMove512 = new OpeningMove();
      openingMove512.StartingFEN = "rn1q1rk1/pbppbppp/1p2p3/8/2PPn3/2N2NP1/PP1BPPBP/R2QK2R w KQ -";
      string str512 = "d4d5{5}";
      char[] chArray512 = new char[1]{ ' ' };
      foreach (string move in str512.Split(chArray512))
        openingMove512.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove512);
      OpeningMove openingMove513 = new OpeningMove();
      openingMove513.StartingFEN = "r1bq1rk1/ppp2pbp/2np1np1/3Pp3/2P1P3/2N2N2/PP2BPPP/R1BQ1RK1 b - -";
      string str513 = "c6e7{41}";
      char[] chArray513 = new char[1]{ ' ' };
      foreach (string move in str513.Split(chArray513))
        openingMove513.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove513);
      OpeningMove openingMove514 = new OpeningMove();
      openingMove514.StartingFEN = "rnb1kbnr/pp3ppp/4p3/2pq4/3P4/8/PPPN1PPP/R1BQKBNR w KQkq -";
      string str514 = "g1f3{5}";
      char[] chArray514 = new char[1]{ ' ' };
      foreach (string move in str514.Split(chArray514))
        openingMove514.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove514);
      OpeningMove openingMove515 = new OpeningMove();
      openingMove515.StartingFEN = "rnbqkbnr/pp3ppp/2p5/3pp3/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq e6";
      string str515 = "d4e5{5}";
      char[] chArray515 = new char[1]{ ' ' };
      foreach (string move in str515.Split(chArray515))
        openingMove515.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove515);
      OpeningMove openingMove516 = new OpeningMove();
      openingMove516.StartingFEN = "rnbqkb1r/pp2pppp/5n2/3p4/2PP4/8/PP3PPP/RNBQKBNR w KQkq -";
      string str516 = "b1c3{21}";
      char[] chArray516 = new char[1]{ ' ' };
      foreach (string move in str516.Split(chArray516))
        openingMove516.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove516);
      OpeningMove openingMove517 = new OpeningMove();
      openingMove517.StartingFEN = "rnbq1rk1/pp3pbp/2pp1np1/3Pp3/2P1P3/2N1BP2/PP1Q2PP/R3KBNR b KQ -";
      string str517 = "c6d5{6}";
      char[] chArray517 = new char[1]{ ' ' };
      foreach (string move in str517.Split(chArray517))
        openingMove517.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove517);
      OpeningMove openingMove518 = new OpeningMove();
      openingMove518.StartingFEN = "rnbqk2r/pppp1ppp/4pn2/8/1bP5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
      string str518 = "d1c2{46} g2g3{20} d1b3{10}";
      char[] chArray518 = new char[1]{ ' ' };
      foreach (string move in str518.Split(chArray518))
        openingMove518.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove518);
      OpeningMove openingMove519 = new OpeningMove();
      openingMove519.StartingFEN = "rnbqkbnr/pp1ppppp/8/2p5/8/5N2/PPPPPPPP/RNBQKB1R w KQkq c6";
      string str519 = "c2c4{56} e2e4{5}";
      char[] chArray519 = new char[1]{ ' ' };
      foreach (string move in str519.Split(chArray519))
        openingMove519.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove519);
      OpeningMove openingMove520 = new OpeningMove();
      openingMove520.StartingFEN = "rnbqkbnr/pppp1ppp/4p3/8/2PP4/8/PP2PPPP/RNBQKBNR b KQkq c3";
      string str520 = "f7f5{5} g8f6{5} b7b6{5} c7c5{5}";
      char[] chArray520 = new char[1]{ ' ' };
      foreach (string move in str520.Split(chArray520))
        openingMove520.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove520);
      OpeningMove openingMove521 = new OpeningMove();
      openingMove521.StartingFEN = "rn1qkb1r/p1pp1ppp/bp2pn2/8/2PP4/P4N2/1P2PPPP/RNBQKB1R w KQkq -";
      string str521 = "d1c2{10} d1b3{5}";
      char[] chArray521 = new char[1]{ ' ' };
      foreach (string move in str521.Split(chArray521))
        openingMove521.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove521);
      OpeningMove openingMove522 = new OpeningMove();
      openingMove522.StartingFEN = "rnbqkb1r/pp2pppp/2p2n2/3p4/2PP4/4PN2/PP3PPP/RNBQKB1R b KQkq -";
      string str522 = "e7e6{10} c8f5{10}";
      char[] chArray522 = new char[1]{ ' ' };
      foreach (string move in str522.Split(chArray522))
        openingMove522.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove522);
      OpeningMove openingMove523 = new OpeningMove();
      openingMove523.StartingFEN = "rnbq1rk1/pppp1ppp/4pn2/8/1bPP4/2N2N2/PPQ1PPPP/R1B1KB1R b KQ -";
      string str523 = "c7c5{15}";
      char[] chArray523 = new char[1]{ ' ' };
      foreach (string move in str523.Split(chArray523))
        openingMove523.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove523);
      OpeningMove openingMove524 = new OpeningMove();
      openingMove524.StartingFEN = "r1bqk2r/2ppbppp/p1n2n2/1p2p3/B3P3/5N2/PPPPQPPP/RNB2RK1 w kq b6";
      string str524 = "a4b3{10}";
      char[] chArray524 = new char[1]{ ' ' };
      foreach (string move in str524.Split(chArray524))
        openingMove524.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove524);
      OpeningMove openingMove525 = new OpeningMove();
      openingMove525.StartingFEN = "r1bqkb1r/ppp2ppp/2n5/3p4/3Pn3/3B1N2/PPP2PPP/RNBQK2R w KQkq -";
      string str525 = "e1g1{106}";
      char[] chArray525 = new char[1]{ ' ' };
      foreach (string move in str525.Split(chArray525))
        openingMove525.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove525);
      OpeningMove openingMove526 = new OpeningMove();
      openingMove526.StartingFEN = "rnbqkb1r/pp2pppp/2p2n2/3p4/2PP4/2N1P3/PP3PPP/R1BQKBNR b KQkq -";
      string str526 = "e7e6{40} a7a6{5}";
      char[] chArray526 = new char[1]{ ' ' };
      foreach (string move in str526.Split(chArray526))
        openingMove526.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove526);
      OpeningMove openingMove527 = new OpeningMove();
      openingMove527.StartingFEN = "rnbqk2r/pp2ppbp/5np1/3p4/3P4/5NP1/PP2PPBP/RNBQK2R w KQkq -";
      string str527 = "b1c3{5}";
      char[] chArray527 = new char[1]{ ' ' };
      foreach (string move in str527.Split(chArray527))
        openingMove527.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove527);
      OpeningMove openingMove528 = new OpeningMove();
      openingMove528.StartingFEN = "rnb1k2r/pp2ppbp/6p1/q1p5/3PP3/2P1B3/P2Q1PPP/R3KBNR w KQkq -";
      string str528 = "a1b1{10}";
      char[] chArray528 = new char[1]{ ' ' };
      foreach (string move in str528.Split(chArray528))
        openingMove528.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove528);
      OpeningMove openingMove529 = new OpeningMove();
      openingMove529.StartingFEN = "rnbqkb1r/pppppp1p/5np1/6B1/3P4/5N2/PPP1PPPP/RN1QKB1R b KQkq -";
      string str529 = "f8g7{23}";
      char[] chArray529 = new char[1]{ ' ' };
      foreach (string move in str529.Split(chArray529))
        openingMove529.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove529);
      OpeningMove openingMove530 = new OpeningMove();
      openingMove530.StartingFEN = "rnbqkbnr/ppp1pppp/8/8/2pPP3/8/PP3PPP/RNBQKBNR b KQkq e3";
      string str530 = "c7c5{15} g8f6{10} e7e5{15}";
      char[] chArray530 = new char[1]{ ' ' };
      foreach (string move in str530.Split(chArray530))
        openingMove530.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove530);
      OpeningMove openingMove531 = new OpeningMove();
      openingMove531.StartingFEN = "r1bqkbnr/pp1p1ppp/2n1p3/1Bp5/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str531 = "e1g1{5}";
      char[] chArray531 = new char[1]{ ' ' };
      foreach (string move in str531.Split(chArray531))
        openingMove531.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove531);
      OpeningMove openingMove532 = new OpeningMove();
      openingMove532.StartingFEN = "rn1qkbnr/pp2pppp/2p5/3pPb2/3P4/5N2/PPP2PPP/RNBQKB1R b KQkq -";
      string str532 = "e7e6{30}";
      char[] chArray532 = new char[1]{ ' ' };
      foreach (string move in str532.Split(chArray532))
        openingMove532.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove532);
      OpeningMove openingMove533 = new OpeningMove();
      openingMove533.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/8/3NP3/2N1B3/PPP2PPP/R2QKB1R w KQkq -";
      string str533 = "a2a4{10} f2f3{42} f1e2{30} g2g4{25}";
      char[] chArray533 = new char[1]{ ' ' };
      foreach (string move in str533.Split(chArray533))
        openingMove533.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove533);
      OpeningMove openingMove534 = new OpeningMove();
      openingMove534.StartingFEN = "r1bqkb1r/pppp1ppp/2nn4/1B2p3/3P4/5N2/PPP2PPP/RNBQ1RK1 w kq -";
      string str534 = "b5c6{55}";
      char[] chArray534 = new char[1]{ ' ' };
      foreach (string move in str534.Split(chArray534))
        openingMove534.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove534);
      OpeningMove openingMove535 = new OpeningMove();
      openingMove535.StartingFEN = "r1bqkb1r/pp1n1ppp/2p1pn2/3p4/2PP4/2NBPN2/PP3PPP/R1BQK2R b KQkq -";
      string str535 = "d5c4{30} f8d6{10}";
      char[] chArray535 = new char[1]{ ' ' };
      foreach (string move in str535.Split(chArray535))
        openingMove535.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove535);
      OpeningMove openingMove536 = new OpeningMove();
      openingMove536.StartingFEN = "rnbqk1nr/pppp1pbp/6p1/4p3/2P5/2N3P1/PP1PPPBP/R1BQK1NR b KQkq -";
      string str536 = "d7d6{6} f7f5{5}";
      char[] chArray536 = new char[1]{ ' ' };
      foreach (string move in str536.Split(chArray536))
        openingMove536.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove536);
      OpeningMove openingMove537 = new OpeningMove();
      openingMove537.StartingFEN = "rnbqkbnr/pppp1ppp/4p3/8/3PP3/8/PPP2PPP/RNBQKBNR b KQkq e3";
      string str537 = "d7d5{5}";
      char[] chArray537 = new char[1]{ ' ' };
      foreach (string move in str537.Split(chArray537))
        openingMove537.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove537);
      OpeningMove openingMove538 = new OpeningMove();
      openingMove538.StartingFEN = "r1bqk1nr/pppp1ppp/2n5/2b1p3/2B1P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str538 = "c2c3{5} b2b4{16}";
      char[] chArray538 = new char[1]{ ' ' };
      foreach (string move in str538.Split(chArray538))
        openingMove538.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove538);
      OpeningMove openingMove539 = new OpeningMove();
      openingMove539.StartingFEN = "rnbq1rk1/p1p1bpp1/1p2pn1p/3p4/2PP3B/2N1PN2/PP3PPP/R2QKB1R w KQ -";
      string str539 = "f1e2{10} d1b3{5} f1d3{5}";
      char[] chArray539 = new char[1]{ ' ' };
      foreach (string move in str539.Split(chArray539))
        openingMove539.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove539);
      OpeningMove openingMove540 = new OpeningMove();
      openingMove540.StartingFEN = "rnbq1rk1/pp3pbp/2pp1np1/3Pp3/2P1P3/2N1BP2/PP4PP/R2QKBNR w KQ -";
      string str540 = "f1d3{5}";
      char[] chArray540 = new char[1]{ ' ' };
      foreach (string move in str540.Split(chArray540))
        openingMove540.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove540);
      OpeningMove openingMove541 = new OpeningMove();
      openingMove541.StartingFEN = "rnbqkbnr/pp3ppp/4p3/2pP4/3P4/8/PPPN1PPP/R1BQKBNR b KQkq -";
      string str541 = "d8d5{10}";
      char[] chArray541 = new char[1]{ ' ' };
      foreach (string move in str541.Split(chArray541))
        openingMove541.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove541);
      OpeningMove openingMove542 = new OpeningMove();
      openingMove542.StartingFEN = "rnbq1rk1/ppppppbp/5np1/8/2P1P3/2N2N2/PP1P1PPP/R1BQKB1R w KQ -";
      string str542 = "d2d4{6}";
      char[] chArray542 = new char[1]{ ' ' };
      foreach (string move in str542.Split(chArray542))
        openingMove542.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove542);
      OpeningMove openingMove543 = new OpeningMove();
      openingMove543.StartingFEN = "rn1qkb1r/pbp2ppp/1p2pn2/3P4/3P4/P1N2N2/1P2PPPP/R1BQKB1R b KQkq -";
      string str543 = "f6d5{10}";
      char[] chArray543 = new char[1]{ ' ' };
      foreach (string move in str543.Split(chArray543))
        openingMove543.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove543);
      OpeningMove openingMove544 = new OpeningMove();
      openingMove544.StartingFEN = "rnbqk2r/ppp1ppbp/3p1np1/8/2PPP3/2N2N2/PP3PPP/R1BQKB1R b KQkq d3";
      string str544 = "e8g8{50}";
      char[] chArray544 = new char[1]{ ' ' };
      foreach (string move in str544.Split(chArray544))
        openingMove544.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove544);
      OpeningMove openingMove545 = new OpeningMove();
      openingMove545.StartingFEN = "r1bq1rk1/2p1bppp/p1n2n2/1p1pp3/4P3/1BP2N2/PP1P1PPP/RNBQR1K1 w - d6";
      string str545 = "e4d5{35}";
      char[] chArray545 = new char[1]{ ' ' };
      foreach (string move in str545.Split(chArray545))
        openingMove545.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove545);
      OpeningMove openingMove546 = new OpeningMove();
      openingMove546.StartingFEN = "rnbqkb1r/pppp1ppp/5n2/4p3/2PP4/8/PP2PPPP/RNBQKBNR w KQkq e6";
      string str546 = "d4e5{5}";
      char[] chArray546 = new char[1]{ ' ' };
      foreach (string move in str546.Split(chArray546))
        openingMove546.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove546);
      OpeningMove openingMove547 = new OpeningMove();
      openingMove547.StartingFEN = "r1bq1rk1/pp2bppp/2nppn2/6B1/3NP3/2N5/PPPQ1PPP/2KR1B1R w - -";
      string str547 = "f2f4{25}";
      char[] chArray547 = new char[1]{ ' ' };
      foreach (string move in str547.Split(chArray547))
        openingMove547.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove547);
      OpeningMove openingMove548 = new OpeningMove();
      openingMove548.StartingFEN = "rnbqkb1r/pp3pp1/2p1pn1p/3p2B1/2PP4/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
      string str548 = "g5f6{25} g5h4{21}";
      char[] chArray548 = new char[1]{ ' ' };
      foreach (string move in str548.Split(chArray548))
        openingMove548.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove548);
      OpeningMove openingMove549 = new OpeningMove();
      openingMove549.StartingFEN = "r1bqkbnr/1p3ppp/p1npp3/1N6/2P1P3/8/PP3PPP/RNBQKB1R w KQkq -";
      string str549 = "b5c3{5}";
      char[] chArray549 = new char[1]{ ' ' };
      foreach (string move in str549.Split(chArray549))
        openingMove549.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove549);
      OpeningMove openingMove550 = new OpeningMove();
      openingMove550.StartingFEN = "rnbqkbnr/pp3ppp/2p1p3/3p4/2PP4/2N1P3/PP3PPP/R1BQKBNR b KQkq -";
      string str550 = "g8f6{5}";
      char[] chArray550 = new char[1]{ ' ' };
      foreach (string move in str550.Split(chArray550))
        openingMove550.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove550);
      OpeningMove openingMove551 = new OpeningMove();
      openingMove551.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
      string str551 = "b1c3{65}";
      char[] chArray551 = new char[1]{ ' ' };
      foreach (string move in str551.Split(chArray551))
        openingMove551.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove551);
      OpeningMove openingMove552 = new OpeningMove();
      openingMove552.StartingFEN = "rnbqkb1r/pppp1ppp/4pn2/8/2P5/2N2N2/PP1PPPPP/R1BQKB1R b KQkq -";
      string str552 = "f8b4{40} b7b6{5} d7d5{15} c7c5{5}";
      char[] chArray552 = new char[1]{ ' ' };
      foreach (string move in str552.Split(chArray552))
        openingMove552.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove552);
      OpeningMove openingMove553 = new OpeningMove();
      openingMove553.StartingFEN = "rnbqkb1r/p2ppppp/1p3n2/2p5/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
      string str553 = "d2d4{5}";
      char[] chArray553 = new char[1]{ ' ' };
      foreach (string move in str553.Split(chArray553))
        openingMove553.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove553);
      OpeningMove openingMove554 = new OpeningMove();
      openingMove554.StartingFEN = "rnbq1rk1/ppppppbp/5np1/8/2P5/5NP1/PP1PPPBP/RNBQK2R w KQ -";
      string str554 = "e1g1{10}";
      char[] chArray554 = new char[1]{ ' ' };
      foreach (string move in str554.Split(chArray554))
        openingMove554.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove554);
      OpeningMove openingMove555 = new OpeningMove();
      openingMove555.StartingFEN = "rn1qk2r/p1p2ppp/bp2pn2/3p4/1bPP4/1P3NP1/P3PPBP/RNBQK2R w KQkq -";
      string str555 = "c1d2{10}";
      char[] chArray555 = new char[1]{ ' ' };
      foreach (string move in str555.Split(chArray555))
        openingMove555.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove555);
      OpeningMove openingMove556 = new OpeningMove();
      openingMove556.StartingFEN = "rnb1k2r/p3ppbp/1p4p1/q1p5/3PP3/2P1B3/P2Q1PPP/1R2KBNR w Kkq -";
      string str556 = "f1b5{5}";
      char[] chArray556 = new char[1]{ ' ' };
      foreach (string move in str556.Split(chArray556))
        openingMove556.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove556);
      OpeningMove openingMove557 = new OpeningMove();
      openingMove557.StartingFEN = "r1bq1rk1/pppnppbp/3p1np1/8/2PPP3/2N1BP2/PP4PP/R2QKBNR w KQ -";
      string str557 = "d1d2{5}";
      char[] chArray557 = new char[1]{ ' ' };
      foreach (string move in str557.Split(chArray557))
        openingMove557.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove557);
      OpeningMove openingMove558 = new OpeningMove();
      openingMove558.StartingFEN = "r1bqkb1r/pp1npppp/2p2n2/8/2BPN3/8/PPP2PPP/R1BQK1NR w KQkq -";
      string str558 = "e4g5{20}";
      char[] chArray558 = new char[1]{ ' ' };
      foreach (string move in str558.Split(chArray558))
        openingMove558.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove558);
      OpeningMove openingMove559 = new OpeningMove();
      openingMove559.StartingFEN = "r1bq1r1k/2p1bppp/p1np1n2/1p2p3/4P3/1BP2N1P/PP1P1PP1/RNBQR1K1 w - -";
      string str559 = "d2d4{5}";
      char[] chArray559 = new char[1]{ ' ' };
      foreach (string move in str559.Split(chArray559))
        openingMove559.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove559);
      OpeningMove openingMove560 = new OpeningMove();
      openingMove560.StartingFEN = "rnbqkbnr/pp2pppp/2p5/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
      string str560 = "c2c4{25}";
      char[] chArray560 = new char[1]{ ' ' };
      foreach (string move in str560.Split(chArray560))
        openingMove560.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove560);
      OpeningMove openingMove561 = new OpeningMove();
      openingMove561.StartingFEN = "rnbqkb1r/ppp2ppp/3p1n2/4p3/3PP3/5P2/PPP3PP/RNBQKBNR w KQkq e6";
      string str561 = "d4e5{5} g1e2{5}";
      char[] chArray561 = new char[1]{ ' ' };
      foreach (string move in str561.Split(chArray561))
        openingMove561.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove561);
      OpeningMove openingMove562 = new OpeningMove();
      openingMove562.StartingFEN = "rnbqkbnr/pp2pppp/2p5/3P4/3P4/8/PP2PPPP/RNBQKBNR b KQkq -";
      string str562 = "c6d5{5}";
      char[] chArray562 = new char[1]{ ' ' };
      foreach (string move in str562.Split(chArray562))
        openingMove562.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove562);
      OpeningMove openingMove563 = new OpeningMove();
      openingMove563.StartingFEN = "rn1qkb1r/p1pp1ppp/b3pn2/1p6/2PP4/1P3NP1/P3PP1P/RNBQKB1R w KQkq -";
      string str563 = "c4b5{5}";
      char[] chArray563 = new char[1]{ ' ' };
      foreach (string move in str563.Split(chArray563))
        openingMove563.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove563);
      OpeningMove openingMove564 = new OpeningMove();
      openingMove564.StartingFEN = "rnbqkbnr/pp2pppp/2p5/8/2pP4/2N5/PP2PPPP/R1BQKBNR w KQkq -";
      string str564 = "e2e4{11}";
      char[] chArray564 = new char[1]{ ' ' };
      foreach (string move in str564.Split(chArray564))
        openingMove564.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove564);
      OpeningMove openingMove565 = new OpeningMove();
      openingMove565.StartingFEN = "rnbqkbnr/pp2pppp/2p5/8/3PN3/8/PPP2PPP/R1BQKBNR b KQkq -";
      string str565 = "b8d7{85} c8f5{20}";
      char[] chArray565 = new char[1]{ ' ' };
      foreach (string move in str565.Split(chArray565))
        openingMove565.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove565);
      OpeningMove openingMove566 = new OpeningMove();
      openingMove566.StartingFEN = "r1bqkb1r/pp1n1ppp/2p1pn2/6N1/2BP4/8/PPP2PPP/R1BQK1NR w KQkq -";
      string str566 = "d1e2{10}";
      char[] chArray566 = new char[1]{ ' ' };
      foreach (string move in str566.Split(chArray566))
        openingMove566.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove566);
      OpeningMove openingMove567 = new OpeningMove();
      openingMove567.StartingFEN = "rn1qk2r/pbpp1ppp/1p2pb2/8/2PPn3/2N2NP1/PP1BPPBP/R2QK2R w KQkq -";
      string str567 = "d1c2{5} e1g1{5}";
      char[] chArray567 = new char[1]{ ' ' };
      foreach (string move in str567.Split(chArray567))
        openingMove567.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove567);
      OpeningMove openingMove568 = new OpeningMove();
      openingMove568.StartingFEN = "r1bqkbnr/pp1ppppp/2n5/8/3NP3/8/PPP2PPP/RNBQKB1R b KQkq -";
      string str568 = "g8f6{177} e7e6{27} e7e5{15} g7g6{15} d8c7{20} d8b6{15}";
      char[] chArray568 = new char[1]{ ' ' };
      foreach (string move in str568.Split(chArray568))
        openingMove568.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove568);
      OpeningMove openingMove569 = new OpeningMove();
      openingMove569.StartingFEN = "rnbqkb1r/1p2pppp/p1p2n2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str569 = "a2a4{5} d1c2{5} c1g5{5} c4c5{5}";
      char[] chArray569 = new char[1]{ ' ' };
      foreach (string move in str569.Split(chArray569))
        openingMove569.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove569);
      OpeningMove openingMove570 = new OpeningMove();
      openingMove570.StartingFEN = "rnbqk2r/pp1p1ppp/4pn2/2p5/1bP5/2N2N2/PPQPPPPP/R1B1KB1R w KQkq c6";
      string str570 = "a2a3{5}";
      char[] chArray570 = new char[1]{ ' ' };
      foreach (string move in str570.Split(chArray570))
        openingMove570.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove570);
      OpeningMove openingMove571 = new OpeningMove();
      openingMove571.StartingFEN = "rnbq1rk1/p1pp1ppp/1p2pn2/6B1/2PP4/P1Q5/1P2PPPP/R3KBNR b KQ -";
      string str571 = "c7c5{15} h7h6{5} c8b7{35} c8a6{5}";
      char[] chArray571 = new char[1]{ ' ' };
      foreach (string move in str571.Split(chArray571))
        openingMove571.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove571);
      OpeningMove openingMove572 = new OpeningMove();
      openingMove572.StartingFEN = "rnbqk1nr/1pp1ppbp/p2p2p1/8/3PP3/2N1B3/PPP2PPP/R2QKBNR w KQkq -";
      string str572 = "d1d2{5} g1f3{5}";
      char[] chArray572 = new char[1]{ ' ' };
      foreach (string move in str572.Split(chArray572))
        openingMove572.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove572);
      OpeningMove openingMove573 = new OpeningMove();
      openingMove573.StartingFEN = "r1bqk2r/pppp1ppp/2n2n2/4p3/1bP5/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq -";
      string str573 = "c3d5{5} f1g2{10}";
      char[] chArray573 = new char[1]{ ' ' };
      foreach (string move in str573.Split(chArray573))
        openingMove573.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove573);
      OpeningMove openingMove574 = new OpeningMove();
      openingMove574.StartingFEN = "rnbqkb1r/pppppp1p/5np1/8/3P1B2/5N2/PPP1PPPP/RN1QKB1R b KQkq -";
      string str574 = "f8g7{5}";
      char[] chArray574 = new char[1]{ ' ' };
      foreach (string move in str574.Split(chArray574))
        openingMove574.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove574);
      OpeningMove openingMove575 = new OpeningMove();
      openingMove575.StartingFEN = "r1bqkb1r/pp1p1ppp/2n1pn2/2p5/2P5/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq -";
      string str575 = "f1g2{10}";
      char[] chArray575 = new char[1]{ ' ' };
      foreach (string move in str575.Split(chArray575))
        openingMove575.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove575);
      OpeningMove openingMove576 = new OpeningMove();
      openingMove576.StartingFEN = "rnbq1rk1/1pp1ppbp/p2p1np1/8/2PPP3/2N1BP2/PP1Q2PP/R3KBNR b KQ -";
      string str576 = "b8d7{5}";
      char[] chArray576 = new char[1]{ ' ' };
      foreach (string move in str576.Split(chArray576))
        openingMove576.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove576);
      OpeningMove openingMove577 = new OpeningMove();
      openingMove577.StartingFEN = "rnb1kbnr/1pqp1ppp/p3p3/8/3NP3/3B4/PPP2PPP/RNBQK2R w KQkq -";
      string str577 = "e1g1{5}";
      char[] chArray577 = new char[1]{ ' ' };
      foreach (string move in str577.Split(chArray577))
        openingMove577.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove577);
      OpeningMove openingMove578 = new OpeningMove();
      openingMove578.StartingFEN = "r1bqkb1r/pp2pppp/2np1n2/6B1/3NP3/2N5/PPP2PPP/R2QKB1R b KQkq -";
      string str578 = "e7e6{95}";
      char[] chArray578 = new char[1]{ ' ' };
      foreach (string move in str578.Split(chArray578))
        openingMove578.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove578);
      OpeningMove openingMove579 = new OpeningMove();
      openingMove579.StartingFEN = "rnbqkb1r/pp3ppp/2p1pn2/3p4/2PP4/1QN2N2/PP2PPPP/R1B1KB1R b KQkq -";
      string str579 = "d5c4{10}";
      char[] chArray579 = new char[1]{ ' ' };
      foreach (string move in str579.Split(chArray579))
        openingMove579.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove579);
      OpeningMove openingMove580 = new OpeningMove();
      openingMove580.StartingFEN = "rnbqkbnr/pp2pppp/8/2pP4/2p1P3/8/PP3PPP/RNBQKBNR b KQkq -";
      string str580 = "g8f6{10}";
      char[] chArray580 = new char[1]{ ' ' };
      foreach (string move in str580.Split(chArray580))
        openingMove580.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove580);
      OpeningMove openingMove581 = new OpeningMove();
      openingMove581.StartingFEN = "rnbqkb1r/pp2pppp/5n2/2pP4/2p1P3/2N5/PP3PPP/R1BQKBNR b KQkq -";
      string str581 = "b7b5{5}";
      char[] chArray581 = new char[1]{ ' ' };
      foreach (string move in str581.Split(chArray581))
        openingMove581.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove581);
      OpeningMove openingMove582 = new OpeningMove();
      openingMove582.StartingFEN = "r1bqkb1r/pppn1ppp/5n2/3p2B1/3P4/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
      string str582 = "f8e7{5}";
      char[] chArray582 = new char[1]{ ' ' };
      foreach (string move in str582.Split(chArray582))
        openingMove582.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove582);
      OpeningMove openingMove583 = new OpeningMove();
      openingMove583.StartingFEN = "rnbqkbnr/pppp1ppp/4p3/8/2P5/5N2/PP1PPPPP/RNBQKB1R b KQkq -";
      string str583 = "d7d5{5}";
      char[] chArray583 = new char[1]{ ' ' };
      foreach (string move in str583.Split(chArray583))
        openingMove583.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove583);
      OpeningMove openingMove584 = new OpeningMove();
      openingMove584.StartingFEN = "r1bqkb1r/pp3ppp/2nppn2/6B1/3NP3/2N5/PPPQ1PPP/R3KB1R b KQkq -";
      string str584 = "f8e7{55} a7a6{35}";
      char[] chArray584 = new char[1]{ ' ' };
      foreach (string move in str584.Split(chArray584))
        openingMove584.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove584);
      OpeningMove openingMove585 = new OpeningMove();
      openingMove585.StartingFEN = "rn1qk2r/pbpp1pp1/1p2pn1p/8/2PP3B/2b1PN2/PP3PPP/R2QKB1R w KQkq -";
      string str585 = "b2c3{5}";
      char[] chArray585 = new char[1]{ ' ' };
      foreach (string move in str585.Split(chArray585))
        openingMove585.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove585);
      OpeningMove openingMove586 = new OpeningMove();
      openingMove586.StartingFEN = "rnbqk1nr/ppp2ppp/4p3/3p4/1b1PP3/2N5/PPP2PPP/R1BQKBNR w KQkq -";
      string str586 = "e4e5{72}";
      char[] chArray586 = new char[1]{ ' ' };
      foreach (string move in str586.Split(chArray586))
        openingMove586.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove586);
      OpeningMove openingMove587 = new OpeningMove();
      openingMove587.StartingFEN = "rn1qk2r/p2nbppp/bpp1p3/3pN3/2PP4/1PB3P1/P3PPBP/RN1QK2R w KQkq -";
      string str587 = "e5d7{15}";
      char[] chArray587 = new char[1]{ ' ' };
      foreach (string move in str587.Split(chArray587))
        openingMove587.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove587);
      OpeningMove openingMove588 = new OpeningMove();
      openingMove588.StartingFEN = "rnbqkb1r/p4ppp/2p1pn2/1p6/2QP4/2N2N2/PP2PPPP/R1B1KB1R w KQkq b6";
      string str588 = "c4d3{10}";
      char[] chArray588 = new char[1]{ ' ' };
      foreach (string move in str588.Split(chArray588))
        openingMove588.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove588);
      OpeningMove openingMove589 = new OpeningMove();
      openingMove589.StartingFEN = "rn1qk2r/pbppbppp/1p2pn2/8/2PP4/2N2NP1/PP2PPBP/R1BQK2R b KQkq -";
      string str589 = "e8g8{5}";
      char[] chArray589 = new char[1]{ ' ' };
      foreach (string move in str589.Split(chArray589))
        openingMove589.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove589);
      OpeningMove openingMove590 = new OpeningMove();
      openingMove590.StartingFEN = "rnbq1rk1/pp3pbp/2pp1np1/4p3/2PPP3/2N1BP2/PP2N1PP/R2QKB1R w KQ -";
      string str590 = "d1d2{5}";
      char[] chArray590 = new char[1]{ ' ' };
      foreach (string move in str590.Split(chArray590))
        openingMove590.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove590);
      OpeningMove openingMove591 = new OpeningMove();
      openingMove591.StartingFEN = "rn1q1rk1/pbp2ppp/1p2pn2/3p2B1/2PP4/P1Q2P2/1P2P1PP/R3KBNR w KQ d6";
      string str591 = "e2e3{6}";
      char[] chArray591 = new char[1]{ ' ' };
      foreach (string move in str591.Split(chArray591))
        openingMove591.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove591);
      OpeningMove openingMove592 = new OpeningMove();
      openingMove592.StartingFEN = "r1bqkb1r/pp1n1ppp/2p1pn2/3p2B1/2PP4/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
      string str592 = "e2e3{10}";
      char[] chArray592 = new char[1]{ ' ' };
      foreach (string move in str592.Split(chArray592))
        openingMove592.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove592);
      OpeningMove openingMove593 = new OpeningMove();
      openingMove593.StartingFEN = "r1bqkb1r/pppp1ppp/2n2n2/4p3/2P5/2N1PN2/PP1P1PPP/R1BQKB1R b KQkq -";
      string str593 = "f8b4{5}";
      char[] chArray593 = new char[1]{ ' ' };
      foreach (string move in str593.Split(chArray593))
        openingMove593.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove593);
      OpeningMove openingMove594 = new OpeningMove();
      openingMove594.StartingFEN = "r1bq1rk1/ppp1npbp/3p1np1/3Pp3/2P1P3/2N5/PP1NBPPP/R1BQ1RK1 b - -";
      string str594 = "a7a5{6}";
      char[] chArray594 = new char[1]{ ' ' };
      foreach (string move in str594.Split(chArray594))
        openingMove594.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove594);
      OpeningMove openingMove595 = new OpeningMove();
      openingMove595.StartingFEN = "rnbqkbnr/pp2pppp/8/2p5/2pPP3/8/PP3PPP/RNBQKBNR w KQkq c6";
      string str595 = "d4d5{5}";
      char[] chArray595 = new char[1]{ ' ' };
      foreach (string move in str595.Split(chArray595))
        openingMove595.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove595);
      OpeningMove openingMove596 = new OpeningMove();
      openingMove596.StartingFEN = "r1bqkbnr/2pp1ppp/p1n5/1p2p3/B3P3/5N2/PPPP1PPP/RNBQK2R w KQkq b6";
      string str596 = "a4b3{5}";
      char[] chArray596 = new char[1]{ ' ' };
      foreach (string move in str596.Split(chArray596))
        openingMove596.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove596);
      OpeningMove openingMove597 = new OpeningMove();
      openingMove597.StartingFEN = "rnbqkb1r/pppp1ppp/8/4p3/3Pn3/5N2/PPP2PPP/RNBQKB1R w KQkq -";
      string str597 = "f1d3{46} f3e5{5}";
      char[] chArray597 = new char[1]{ ' ' };
      foreach (string move in str597.Split(chArray597))
        openingMove597.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove597);
      OpeningMove openingMove598 = new OpeningMove();
      openingMove598.StartingFEN = "rnbqk2r/ppp2ppp/3b4/3p4/3Pn3/3B1N2/PPP2PPP/RNBQK2R w KQkq -";
      string str598 = "e1g1{27}";
      char[] chArray598 = new char[1]{ ' ' };
      foreach (string move in str598.Split(chArray598))
        openingMove598.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove598);
      OpeningMove openingMove599 = new OpeningMove();
      openingMove599.StartingFEN = "rnbqkb1r/pp3ppp/2p1pn2/3p2B1/2PP4/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
      string str599 = "d5c4{15} h7h6{40}";
      char[] chArray599 = new char[1]{ ' ' };
      foreach (string move in str599.Split(chArray599))
        openingMove599.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove599);
      OpeningMove openingMove600 = new OpeningMove();
      openingMove600.StartingFEN = "rn1qk2r/pbppb1pp/1p2p3/5p2/2PPn3/2N2NP1/PP1BPPBP/R2QK2R w KQkq f6";
      string str600 = "d4d5{5}";
      char[] chArray600 = new char[1]{ ' ' };
      foreach (string move in str600.Split(chArray600))
        openingMove600.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove600);
      OpeningMove openingMove601 = new OpeningMove();
      openingMove601.StartingFEN = "rnbq1rk1/pp3pbp/2pp1np1/4p3/2PPP3/2N1BP2/PP1QN1PP/R3KB1R b KQ -";
      string str601 = "b8d7{12}";
      char[] chArray601 = new char[1]{ ' ' };
      foreach (string move in str601.Split(chArray601))
        openingMove601.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove601);
      OpeningMove openingMove602 = new OpeningMove();
      openingMove602.StartingFEN = "rnbqk2r/pp2ppbp/6p1/2p5/2BPP3/2P5/P4PPP/R1BQK1NR w KQkq c6";
      string str602 = "g1e2{25}";
      char[] chArray602 = new char[1]{ ' ' };
      foreach (string move in str602.Split(chArray602))
        openingMove602.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove602);
      OpeningMove openingMove603 = new OpeningMove();
      openingMove603.StartingFEN = "rn1qk2r/pbpp1ppp/1p2pn2/6B1/2PP4/2b1PN2/PP3PPP/R2QKB1R w KQkq -";
      string str603 = "b2c3{5}";
      char[] chArray603 = new char[1]{ ' ' };
      foreach (string move in str603.Split(chArray603))
        openingMove603.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove603);
      OpeningMove openingMove604 = new OpeningMove();
      openingMove604.StartingFEN = "r1bqkb1r/pp2pppp/2np1n2/8/3NP3/2N5/PPP1BPPP/R1BQK2R b KQkq -";
      string str604 = "e7e5{5} g7g6{5}";
      char[] chArray604 = new char[1]{ ' ' };
      foreach (string move in str604.Split(chArray604))
        openingMove604.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove604);
      OpeningMove openingMove605 = new OpeningMove();
      openingMove605.StartingFEN = "rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/2NBP3/PP3PPP/R1BQK1NR b KQkq -";
      string str605 = "b8c6{15} d7d5{5}";
      char[] chArray605 = new char[1]{ ' ' };
      foreach (string move in str605.Split(chArray605))
        openingMove605.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove605);
      OpeningMove openingMove606 = new OpeningMove();
      openingMove606.StartingFEN = "rnbqkb1r/pppn1ppp/4p3/3pP3/3P4/2N5/PPP2PPP/R1BQKBNR w KQkq -";
      string str606 = "f2f4{22} c3e2{20}";
      char[] chArray606 = new char[1]{ ' ' };
      foreach (string move in str606.Split(chArray606))
        openingMove606.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove606);
      OpeningMove openingMove607 = new OpeningMove();
      openingMove607.StartingFEN = "rnbq1rk1/ppp1ppbp/5np1/8/2QP4/2N2N2/PP2PPPP/R1B1KB1R w KQ -";
      string str607 = "e2e4{51}";
      char[] chArray607 = new char[1]{ ' ' };
      foreach (string move in str607.Split(chArray607))
        openingMove607.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove607);
      OpeningMove openingMove608 = new OpeningMove();
      openingMove608.StartingFEN = "rnbqk2r/ppppppbp/5np1/8/2PP4/6P1/PP2PP1P/RNBQKBNR w KQkq -";
      string str608 = "f1g2{31}";
      char[] chArray608 = new char[1]{ ' ' };
      foreach (string move in str608.Split(chArray608))
        openingMove608.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove608);
      OpeningMove openingMove609 = new OpeningMove();
      openingMove609.StartingFEN = "r1bqkb1r/1p1n1ppp/p2ppn2/8/3NP3/2N1BP2/PPP3PP/R2QKB1R w KQkq -";
      string str609 = "g2g4{11}";
      char[] chArray609 = new char[1]{ ' ' };
      foreach (string move in str609.Split(chArray609))
        openingMove609.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove609);
      OpeningMove openingMove610 = new OpeningMove();
      openingMove610.StartingFEN = "rnbq1rk1/pp2ppbp/3p1np1/2p5/2PPP3/2N1BP2/PP4PP/R2QKBNR w KQ c6";
      string str610 = "g1e2{5}";
      char[] chArray610 = new char[1]{ ' ' };
      foreach (string move in str610.Split(chArray610))
        openingMove610.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove610);
      OpeningMove openingMove611 = new OpeningMove();
      openingMove611.StartingFEN = "rnbqkb1r/1p3pp1/p2ppn1p/8/3NP1PP/2N5/PPP2P2/R1BQKB1R w KQkq -";
      string str611 = "f1g2{5}";
      char[] chArray611 = new char[1]{ ' ' };
      foreach (string move in str611.Split(chArray611))
        openingMove611.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove611);
      OpeningMove openingMove612 = new OpeningMove();
      openingMove612.StartingFEN = "r1bq1rk1/ppp1npbp/3p1np1/3Pp3/2P1P3/2N5/PP2BPPP/R1BQNRK1 b - -";
      string str612 = "f6e8{5}";
      char[] chArray612 = new char[1]{ ' ' };
      foreach (string move in str612.Split(chArray612))
        openingMove612.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove612);
      OpeningMove openingMove613 = new OpeningMove();
      openingMove613.StartingFEN = "rnbqk2r/pppp1ppp/4pn2/8/1bPP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq d3";
      string str613 = "b7b6{5}";
      char[] chArray613 = new char[1]{ ' ' };
      foreach (string move in str613.Split(chArray613))
        openingMove613.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove613);
      OpeningMove openingMove614 = new OpeningMove();
      openingMove614.StartingFEN = "rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/P4N2/1P2PPPP/RNBQKB1R w KQkq -";
      string str614 = "b1c3{25}";
      char[] chArray614 = new char[1]{ ' ' };
      foreach (string move in str614.Split(chArray614))
        openingMove614.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove614);
      OpeningMove openingMove615 = new OpeningMove();
      openingMove615.StartingFEN = "r1bqk2r/pp2bppp/2nppn2/6B1/3NP3/2N5/PPPQ1PPP/2KR1B1R b kq -";
      string str615 = "e8g8{40} c6d4{10}";
      char[] chArray615 = new char[1]{ ' ' };
      foreach (string move in str615.Split(chArray615))
        openingMove615.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove615);
      OpeningMove openingMove616 = new OpeningMove();
      openingMove616.StartingFEN = "rn1qk2r/pp3ppp/2p1pn2/4Nb2/PbpP4/2N2P2/1P2P1PP/R1BQKB1R w KQkq -";
      string str616 = "e2e4{30}";
      char[] chArray616 = new char[1]{ ' ' };
      foreach (string move in str616.Split(chArray616))
        openingMove616.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove616);
      OpeningMove openingMove617 = new OpeningMove();
      openingMove617.StartingFEN = "rnbqkb1r/pp1p1ppp/4pn2/2p5/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq c6";
      string str617 = "g2g3{10}";
      char[] chArray617 = new char[1]{ ' ' };
      foreach (string move in str617.Split(chArray617))
        openingMove617.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove617);
      OpeningMove openingMove618 = new OpeningMove();
      openingMove618.StartingFEN = "rnbqkb1r/pp3ppp/4pn2/3p4/2PP4/2N5/PP3PPP/R1BQKBNR w KQkq -";
      string str618 = "g1f3{10}";
      char[] chArray618 = new char[1]{ ' ' };
      foreach (string move in str618.Split(chArray618))
        openingMove618.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove618);
      OpeningMove openingMove619 = new OpeningMove();
      openingMove619.StartingFEN = "r1bqkb1r/pp3ppp/1np1pn2/6N1/2BP4/8/PPP1QPPP/R1B1K1NR w KQkq -";
      string str619 = "c4b3{5}";
      char[] chArray619 = new char[1]{ ' ' };
      foreach (string move in str619.Split(chArray619))
        openingMove619.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove619);
      OpeningMove openingMove620 = new OpeningMove();
      openingMove620.StartingFEN = "rn1q1rk1/1bp2ppp/1p1ppn2/p7/1bPP4/1P3NP1/P1QBPPBP/RN3RK1 w - -";
      string str620 = "b1c3{5} d2g5{5} d2c3{5}";
      char[] chArray620 = new char[1]{ ' ' };
      foreach (string move in str620.Split(chArray620))
        openingMove620.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove620);
      OpeningMove openingMove621 = new OpeningMove();
      openingMove621.StartingFEN = "r1bqkb1r/pp1ppppp/2n2n2/8/3NP3/2N5/PPP2PPP/R1BQKB1R b KQkq -";
      string str621 = "d7d6{80} e7e5{72} e7e6{20}";
      char[] chArray621 = new char[1]{ ' ' };
      foreach (string move in str621.Split(chArray621))
        openingMove621.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove621);
      OpeningMove openingMove622 = new OpeningMove();
      openingMove622.StartingFEN = "rnbqk2r/pppp1ppp/4pn2/8/1bP5/2N2NP1/PP1PPP1P/R1BQKB1R b KQkq -";
      string str622 = "e8g8{5} b7b6{5}";
      char[] chArray622 = new char[1]{ ' ' };
      foreach (string move in str622.Split(chArray622))
        openingMove622.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove622);
      OpeningMove openingMove623 = new OpeningMove();
      openingMove623.StartingFEN = "rnbqkb1r/pppppp1p/5np1/8/2P5/2N5/PP1PPPPP/R1BQKBNR w KQkq -";
      string str623 = "g2g3{10} e2e4{15}";
      char[] chArray623 = new char[1]{ ' ' };
      foreach (string move in str623.Split(chArray623))
        openingMove623.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove623);
      OpeningMove openingMove624 = new OpeningMove();
      openingMove624.StartingFEN = "rnbqkb1r/ppp1pp1p/5np1/3p4/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq d6";
      string str624 = "c4d5{20} d1a4{15}";
      char[] chArray624 = new char[1]{ ' ' };
      foreach (string move in str624.Split(chArray624))
        openingMove624.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove624);
      OpeningMove openingMove625 = new OpeningMove();
      openingMove625.StartingFEN = "rnbqkb1r/pp2pppp/2p2n2/8/P1pP4/2N2N2/1P2PPPP/R1BQKB1R b KQkq a3";
      string str625 = "c8f5{40}";
      char[] chArray625 = new char[1]{ ' ' };
      foreach (string move in str625.Split(chArray625))
        openingMove625.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove625);
      OpeningMove openingMove626 = new OpeningMove();
      openingMove626.StartingFEN = "rnbqkbnr/pp2pppp/2p5/3p4/4P3/2N2N2/PPPP1PPP/R1BQKB1R b KQkq -";
      string str626 = "c8g4{5}";
      char[] chArray626 = new char[1]{ ' ' };
      foreach (string move in str626.Split(chArray626))
        openingMove626.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove626);
      OpeningMove openingMove627 = new OpeningMove();
      openingMove627.StartingFEN = "r1bqkbnr/1p1p1ppp/p1n1p3/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
      string str627 = "g2g3{5} c1e3{5} d4c6{5}";
      char[] chArray627 = new char[1]{ ' ' };
      foreach (string move in str627.Split(chArray627))
        openingMove627.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove627);
      OpeningMove openingMove628 = new OpeningMove();
      openingMove628.StartingFEN = "rnb1kb1r/1pq1pppp/p2p1n2/8/3NPP2/2N5/PPP3PP/R1BQKB1R w KQkq -";
      string str628 = "d1f3{5}";
      char[] chArray628 = new char[1]{ ' ' };
      foreach (string move in str628.Split(chArray628))
        openingMove628.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove628);
      OpeningMove openingMove629 = new OpeningMove();
      openingMove629.StartingFEN = "r1bqk2r/ppp1bppp/2n5/3p4/3Pn3/3B1N2/PPP2PPP/RNBQ1RK1 w kq -";
      string str629 = "f1e1{36} c2c4{76}";
      char[] chArray629 = new char[1]{ ' ' };
      foreach (string move in str629.Split(chArray629))
        openingMove629.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove629);
      OpeningMove openingMove630 = new OpeningMove();
      openingMove630.StartingFEN = "rnbqkb1r/pp1n1ppp/4p3/2ppP3/3P1P2/2N5/PPP3PP/R1BQKBNR w KQkq c6";
      string str630 = "g1f3{17}";
      char[] chArray630 = new char[1]{ ' ' };
      foreach (string move in str630.Split(chArray630))
        openingMove630.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove630);
      OpeningMove openingMove631 = new OpeningMove();
      openingMove631.StartingFEN = "rnbqk2r/ppppppbp/5np1/6B1/3P4/2P2N2/PP2PPPP/RN1QKB1R b KQkq -";
      string str631 = "b7b6{6} c7c5{6} e8g8{6}";
      char[] chArray631 = new char[1]{ ' ' };
      foreach (string move in str631.Split(chArray631))
        openingMove631.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove631);
      OpeningMove openingMove632 = new OpeningMove();
      openingMove632.StartingFEN = "rnbqk1nr/ppp2ppp/8/4p3/1bpPP3/5N2/PP3PPP/RNBQKB1R w KQkq -";
      string str632 = "c1d2{5}";
      char[] chArray632 = new char[1]{ ' ' };
      foreach (string move in str632.Split(chArray632))
        openingMove632.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove632);
      OpeningMove openingMove633 = new OpeningMove();
      openingMove633.StartingFEN = "r1bqkbnr/pp1p1ppp/2n5/1N2p3/4P3/8/PPP2PPP/RNBQKB1R b KQkq -";
      string str633 = "d7d6{10}";
      char[] chArray633 = new char[1]{ ' ' };
      foreach (string move in str633.Split(chArray633))
        openingMove633.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove633);
      OpeningMove openingMove634 = new OpeningMove();
      openingMove634.StartingFEN = "r1bqkbnr/pp1p1ppp/2n1p3/8/3NP3/2N5/PPP2PPP/R1BQKB1R b KQkq -";
      string str634 = "d8c7{30} d7d6{23} a7a6{5}";
      char[] chArray634 = new char[1]{ ' ' };
      foreach (string move in str634.Split(chArray634))
        openingMove634.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove634);
      OpeningMove openingMove635 = new OpeningMove();
      openingMove635.StartingFEN = "r1b1kbnr/ppqp1ppp/2n1p3/8/3NP3/2N5/PPP1BPPP/R1BQK2R b KQkq -";
      string str635 = "a7a6{25}";
      char[] chArray635 = new char[1]{ ' ' };
      foreach (string move in str635.Split(chArray635))
        openingMove635.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove635);
      OpeningMove openingMove636 = new OpeningMove();
      openingMove636.StartingFEN = "rnbqkb1r/1p2pppp/p2p1n2/8/3NP3/2N5/PPP1BPPP/R1BQK2R b KQkq -";
      string str636 = "e7e5{27} e7e6{77}";
      char[] chArray636 = new char[1]{ ' ' };
      foreach (string move in str636.Split(chArray636))
        openingMove636.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove636);
      OpeningMove openingMove637 = new OpeningMove();
      openingMove637.StartingFEN = "r1bq1rk1/pp2bppp/2nppn2/6B1/3NPP2/2N5/PPPQ2PP/2KR1B1R b - f3";
      string str637 = "c6d4{25} h7h6{5}";
      char[] chArray637 = new char[1]{ ' ' };
      foreach (string move in str637.Split(chArray637))
        openingMove637.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove637);
      OpeningMove openingMove638 = new OpeningMove();
      openingMove638.StartingFEN = "rnb1k2r/1pq1bppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQ1RK1 w kq -";
      string str638 = "g1h1{5}";
      char[] chArray638 = new char[1]{ ' ' };
      foreach (string move in str638.Split(chArray638))
        openingMove638.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove638);
      OpeningMove openingMove639 = new OpeningMove();
      openingMove639.StartingFEN = "r1bq1rk1/pp2bppp/3ppn2/6B1/3nPP2/2N5/PPPQ2PP/2KR1B1R w - -";
      string str639 = "d2d4{15}";
      char[] chArray639 = new char[1]{ ' ' };
      foreach (string move in str639.Split(chArray639))
        openingMove639.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove639);
      OpeningMove openingMove640 = new OpeningMove();
      openingMove640.StartingFEN = "r1b1kbnr/1pqp1ppp/p1n1p3/8/3NP3/2N5/PPP1BPPP/R1BQ1RK1 b kq -";
      string str640 = "g8f6{15}";
      char[] chArray640 = new char[1]{ ' ' };
      foreach (string move in str640.Split(chArray640))
        openingMove640.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove640);
      OpeningMove openingMove641 = new OpeningMove();
      openingMove641.StartingFEN = "r1b1kb1r/1pqp1ppp/p1n1pn2/8/3NP3/2N5/PPP1BPPP/R1BQ1RK1 w kq -";
      string str641 = "g1h1{5} c1e3{11}";
      char[] chArray641 = new char[1]{ ' ' };
      foreach (string move in str641.Split(chArray641))
        openingMove641.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove641);
      OpeningMove openingMove642 = new OpeningMove();
      openingMove642.StartingFEN = "r1bqkb1r/1p1npppp/p2p1n2/8/3NPP2/2N5/PPP3PP/R1BQKB1R w KQkq -";
      string str642 = "d4f3{5} f1e2{6}";
      char[] chArray642 = new char[1]{ ' ' };
      foreach (string move in str642.Split(chArray642))
        openingMove642.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove642);
      OpeningMove openingMove643 = new OpeningMove();
      openingMove643.StartingFEN = "r1bq1rk1/pp2bppp/3ppn2/6B1/3QPP2/2N5/PPP3PP/2KR1B1R b - -";
      string str643 = "d8a5{15}";
      char[] chArray643 = new char[1]{ ' ' };
      foreach (string move in str643.Split(chArray643))
        openingMove643.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove643);
      OpeningMove openingMove644 = new OpeningMove();
      openingMove644.StartingFEN = "r1bqkb1r/1p3ppp/p1nppn2/6B1/3NP3/2N5/PPPQ1PPP/R3KB1R w KQkq -";
      string str644 = "e1c1{31}";
      char[] chArray644 = new char[1]{ ' ' };
      foreach (string move in str644.Split(chArray644))
        openingMove644.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove644);
      OpeningMove openingMove645 = new OpeningMove();
      openingMove645.StartingFEN = "rnb1kb1r/1p3ppp/pq1ppn2/6B1/3NPP2/2N5/PPP3PP/R2QKB1R w KQkq -";
      string str645 = "d4b3{15} a2a3{10}";
      char[] chArray645 = new char[1]{ ' ' };
      foreach (string move in str645.Split(chArray645))
        openingMove645.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove645);
      OpeningMove openingMove646 = new OpeningMove();
      openingMove646.StartingFEN = "r1bqkb1r/1p3ppp/p1nppn2/6B1/3NP3/2N5/PPPQ1PPP/2KR1B1R b kq -";
      string str646 = "h7h6{20} c6d4{5}";
      char[] chArray646 = new char[1]{ ' ' };
      foreach (string move in str646.Split(chArray646))
        openingMove646.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove646);
      OpeningMove openingMove647 = new OpeningMove();
      openingMove647.StartingFEN = "r1bqkb1r/pp3ppp/2n1pn2/2pp4/2PP4/2N1PN2/PP3PPP/R1BQKB1R w KQkq d6";
      string str647 = "c4d5{5}";
      char[] chArray647 = new char[1]{ ' ' };
      foreach (string move in str647.Split(chArray647))
        openingMove647.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove647);
      OpeningMove openingMove648 = new OpeningMove();
      openingMove648.StartingFEN = "rnbqk1nr/pppp1ppp/8/4p3/1bP5/2N5/PP1PPPPP/R1BQKBNR w KQkq -";
      string str648 = "c3d5{11}";
      char[] chArray648 = new char[1]{ ' ' };
      foreach (string move in str648.Split(chArray648))
        openingMove648.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove648);
      OpeningMove openingMove649 = new OpeningMove();
      openingMove649.StartingFEN = "rnbqkb1r/pp1p1ppp/4p3/2pn4/8/2N2N2/PPP1PPPP/R1BQKB1R w KQkq -";
      string str649 = "c3d5{5}";
      char[] chArray649 = new char[1]{ ' ' };
      foreach (string move in str649.Split(chArray649))
        openingMove649.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove649);
      OpeningMove openingMove650 = new OpeningMove();
      openingMove650.StartingFEN = "r1bqkb1r/pppp1ppp/2n2n2/4p3/2P5/P1N2N2/1P1PPPPP/R1BQKB1R b KQkq -";
      string str650 = "g7g6{5} d7d5{5}";
      char[] chArray650 = new char[1]{ ' ' };
      foreach (string move in str650.Split(chArray650))
        openingMove650.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove650);
      OpeningMove openingMove651 = new OpeningMove();
      openingMove651.StartingFEN = "rnbqkbnr/pp2pppp/3p4/2p5/4P3/2P5/PP1P1PPP/RNBQKBNR w KQkq -";
      string str651 = "d2d4{5}";
      char[] chArray651 = new char[1]{ ' ' };
      foreach (string move in str651.Split(chArray651))
        openingMove651.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove651);
      OpeningMove openingMove652 = new OpeningMove();
      openingMove652.StartingFEN = "rnbq1rk1/pp1p1ppp/4pn2/2P5/1bP5/2N2N2/PPQ1PPPP/R1B1KB1R b KQ -";
      string str652 = "b8a6{10}";
      char[] chArray652 = new char[1]{ ' ' };
      foreach (string move in str652.Split(chArray652))
        openingMove652.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove652);
      OpeningMove openingMove653 = new OpeningMove();
      openingMove653.StartingFEN = "r1bqkb1r/pp1p1ppp/2n2n2/2p1p3/2P5/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq e6";
      string str653 = "f1g2{5}";
      char[] chArray653 = new char[1]{ ' ' };
      foreach (string move in str653.Split(chArray653))
        openingMove653.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove653);
      OpeningMove openingMove654 = new OpeningMove();
      openingMove654.StartingFEN = "rnbqkbnr/pppppp1p/6p1/8/3P4/5N2/PPP1PPPP/RNBQKB1R b KQkq d3";
      string str654 = "f8g7{5} g8f6{5}";
      char[] chArray654 = new char[1]{ ' ' };
      foreach (string move in str654.Split(chArray654))
        openingMove654.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove654);
      OpeningMove openingMove655 = new OpeningMove();
      openingMove655.StartingFEN = "r1bqkb1r/pp2pppp/2np1n2/8/3NP3/2N2P2/PPP3PP/R1BQKB1R b KQkq -";
      string str655 = "e7e5{5} e7e6{5}";
      char[] chArray655 = new char[1]{ ' ' };
      foreach (string move in str655.Split(chArray655))
        openingMove655.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove655);
      OpeningMove openingMove656 = new OpeningMove();
      openingMove656.StartingFEN = "rnbqk2r/ppp1ppbp/3p1np1/8/2P1P3/2N2N2/PP1P1PPP/R1BQKB1R w KQkq -";
      string str656 = "d2d4{75}";
      char[] chArray656 = new char[1]{ ' ' };
      foreach (string move in str656.Split(chArray656))
        openingMove656.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove656);
      OpeningMove openingMove657 = new OpeningMove();
      openingMove657.StartingFEN = "r1bqkbnr/pp1ppppp/2n5/1Bp5/4P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
      string str657 = "g7g6{30} e7e6{5} g8f6{5}";
      char[] chArray657 = new char[1]{ ' ' };
      foreach (string move in str657.Split(chArray657))
        openingMove657.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove657);
      OpeningMove openingMove658 = new OpeningMove();
      openingMove658.StartingFEN = "r1bqkb1r/pp1ppp1p/2n2np1/2p5/2P5/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq -";
      string str658 = "f1g2{6}";
      char[] chArray658 = new char[1]{ ' ' };
      foreach (string move in str658.Split(chArray658))
        openingMove658.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove658);
      OpeningMove openingMove659 = new OpeningMove();
      openingMove659.StartingFEN = "rnbqk1nr/pp3ppp/4p3/2ppP3/1b1P4/2N5/PPP2PPP/R1BQKBNR w KQkq c6";
      string str659 = "a2a3{57}";
      char[] chArray659 = new char[1]{ ' ' };
      foreach (string move in str659.Split(chArray659))
        openingMove659.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove659);
      OpeningMove openingMove660 = new OpeningMove();
      openingMove660.StartingFEN = "rnbq1rk1/ppp1ppbp/3p1np1/6B1/2PPP3/2N2P2/PP4PP/R2QKBNR b KQ -";
      string str660 = "a7a6{11} c7c5{5}";
      char[] chArray660 = new char[1]{ ' ' };
      foreach (string move in str660.Split(chArray660))
        openingMove660.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove660);
      OpeningMove openingMove661 = new OpeningMove();
      openingMove661.StartingFEN = "rnbq1rk1/ppp1bpp1/4pn1p/3p4/2PP3B/2N2N2/PP2PPPP/R2QKB1R w KQ -";
      string str661 = "e2e3{25} a1c1{10}";
      char[] chArray661 = new char[1]{ ' ' };
      foreach (string move in str661.Split(chArray661))
        openingMove661.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove661);
      OpeningMove openingMove662 = new OpeningMove();
      openingMove662.StartingFEN = "r1bqkbnr/pp1npppp/2p5/8/2BPN3/8/PPP2PPP/R1BQK1NR b KQkq -";
      string str662 = "g8f6{15}";
      char[] chArray662 = new char[1]{ ' ' };
      foreach (string move in str662.Split(chArray662))
        openingMove662.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove662);
      OpeningMove openingMove663 = new OpeningMove();
      openingMove663.StartingFEN = "rnbqkb1r/pppp1ppp/4pn2/6B1/3PP3/8/PPP2PPP/RN1QKBNR b KQkq e3";
      string str663 = "h7h6{15}";
      char[] chArray663 = new char[1]{ ' ' };
      foreach (string move in str663.Split(chArray663))
        openingMove663.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove663);
      OpeningMove openingMove664 = new OpeningMove();
      openingMove664.StartingFEN = "rnbq1rk1/ppp1ppbp/5np1/3p4/2PP4/5NP1/PP2PPBP/RNBQK2R w KQ d6";
      string str664 = "e1g1{10}";
      char[] chArray664 = new char[1]{ ' ' };
      foreach (string move in str664.Split(chArray664))
        openingMove664.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove664);
      OpeningMove openingMove665 = new OpeningMove();
      openingMove665.StartingFEN = "rn1qkbnr/pp3ppp/2p1p3/3pPb2/3P4/5N2/PPP1BPPP/RNBQK2R b KQkq -";
      string str665 = "c6c5{20}";
      char[] chArray665 = new char[1]{ ' ' };
      foreach (string move in str665.Split(chArray665))
        openingMove665.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove665);
      OpeningMove openingMove666 = new OpeningMove();
      openingMove666.StartingFEN = "rnbqkb1r/1p1pnppp/p3p3/8/3NP3/3B4/PPP2PPP/RNBQK2R w KQkq -";
      string str666 = "e1g1{5}";
      char[] chArray666 = new char[1]{ ' ' };
      foreach (string move in str666.Split(chArray666))
        openingMove666.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove666);
      OpeningMove openingMove667 = new OpeningMove();
      openingMove667.StartingFEN = "rnbq1rk1/ppp1ppbp/3p1np1/8/2PP4/5NP1/PP2PPBP/RNBQK2R w KQ -";
      string str667 = "e1g1{5}";
      char[] chArray667 = new char[1]{ ' ' };
      foreach (string move in str667.Split(chArray667))
        openingMove667.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove667);
      OpeningMove openingMove668 = new OpeningMove();
      openingMove668.StartingFEN = "r1b2rk1/pp2bppp/3ppn2/q5B1/3QPP2/2N5/PPP3PP/2KR1B1R w - -";
      string str668 = "f1c4{5}";
      char[] chArray668 = new char[1]{ ' ' };
      foreach (string move in str668.Split(chArray668))
        openingMove668.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove668);
      OpeningMove openingMove669 = new OpeningMove();
      openingMove669.StartingFEN = "rnbqkb1r/pp2pp1p/3p1np1/8/3NP3/2N5/PPP1BPPP/R1BQK2R b KQkq -";
      string str669 = "f8g7{5}";
      char[] chArray669 = new char[1]{ ' ' };
      foreach (string move in str669.Split(chArray669))
        openingMove669.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove669);
      OpeningMove openingMove670 = new OpeningMove();
      openingMove670.StartingFEN = "r1b2rk1/pp2bppp/3ppn2/q5B1/2BQPP2/2N5/PPP3PP/2KR3R b - -";
      string str670 = "c8d7{10}";
      char[] chArray670 = new char[1]{ ' ' };
      foreach (string move in str670.Split(chArray670))
        openingMove670.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove670);
      OpeningMove openingMove671 = new OpeningMove();
      openingMove671.StartingFEN = "rnbqkbnr/pp2pppp/8/3p4/2PP4/8/PP3PPP/RNBQKBNR b KQkq c3";
      string str671 = "g8f6{20}";
      char[] chArray671 = new char[1]{ ' ' };
      foreach (string move in str671.Split(chArray671))
        openingMove671.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove671);
      OpeningMove openingMove672 = new OpeningMove();
      openingMove672.StartingFEN = "rnbqkbnr/pp2pppp/8/3p4/3P4/3B4/PPP2PPP/RNBQK1NR b KQkq -";
      string str672 = "b8c6{5}";
      char[] chArray672 = new char[1]{ ' ' };
      foreach (string move in str672.Split(chArray672))
        openingMove672.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove672);
      OpeningMove openingMove673 = new OpeningMove();
      openingMove673.StartingFEN = "r1bqkb1r/pppp1ppp/2n5/4p3/3Pn3/3B1N2/PPP2PPP/RNBQK2R w KQkq -";
      string str673 = "d4e5{5} f3e5{5}";
      char[] chArray673 = new char[1]{ ' ' };
      foreach (string move in str673.Split(chArray673))
        openingMove673.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove673);
      OpeningMove openingMove674 = new OpeningMove();
      openingMove674.StartingFEN = "rnbqkb1r/pppp1ppp/5n2/4p3/3PP3/5N2/PPP2PPP/RNBQKB1R b KQkq d3";
      string str674 = "e5d4{5} f6e4{20}";
      char[] chArray674 = new char[1]{ ' ' };
      foreach (string move in str674.Split(chArray674))
        openingMove674.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove674);
      OpeningMove openingMove675 = new OpeningMove();
      openingMove675.StartingFEN = "rnbqkb1r/pp1ppppp/5n2/8/2Pp4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
      string str675 = "f3d4{10}";
      char[] chArray675 = new char[1]{ ' ' };
      foreach (string move in str675.Split(chArray675))
        openingMove675.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove675);
      OpeningMove openingMove676 = new OpeningMove();
      openingMove676.StartingFEN = "rnbqkb1r/pp1p1ppp/4pn2/2p5/2P5/2N3P1/PP1PPP1P/R1BQKBNR w KQkq -";
      string str676 = "g1f3{6}";
      char[] chArray676 = new char[1]{ ' ' };
      foreach (string move in str676.Split(chArray676))
        openingMove676.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove676);
      OpeningMove openingMove677 = new OpeningMove();
      openingMove677.StartingFEN = "rnbqkb1r/pp2pppp/2p2n2/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR w KQkq d6";
      string str677 = "g1f3{11}";
      char[] chArray677 = new char[1]{ ' ' };
      foreach (string move in str677.Split(chArray677))
        openingMove677.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove677);
      OpeningMove openingMove678 = new OpeningMove();
      openingMove678.StartingFEN = "rnbqkbnr/pp2pppp/2p5/3p4/3PP3/8/PPPN1PPP/R1BQKBNR b KQkq -";
      string str678 = "d5e4{55}";
      char[] chArray678 = new char[1]{ ' ' };
      foreach (string move in str678.Split(chArray678))
        openingMove678.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove678);
      OpeningMove openingMove679 = new OpeningMove();
      openingMove679.StartingFEN = "rnbqkbnr/ppp1pppp/8/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R b KQkq d3";
      string str679 = "g8f6{37} c8f5{5} e7e6{5} c7c6{10}";
      char[] chArray679 = new char[1]{ ' ' };
      foreach (string move in str679.Split(chArray679))
        openingMove679.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove679);
      OpeningMove openingMove680 = new OpeningMove();
      openingMove680.StartingFEN = "rnbqk2r/ppp1ppbp/6p1/8/3PP3/2P2N2/P4PPP/R1BQKB1R b KQkq -";
      string str680 = "e8g8{5} c7c5{10}";
      char[] chArray680 = new char[1]{ ' ' };
      foreach (string move in str680.Split(chArray680))
        openingMove680.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove680);
      OpeningMove openingMove681 = new OpeningMove();
      openingMove681.StartingFEN = "r1bqk2r/pppp1ppp/2n2n2/2bNp3/2P5/5NP1/PP1PPPBP/R1BQK2R b KQkq -";
      string str681 = "d7d6{5}";
      char[] chArray681 = new char[1]{ ' ' };
      foreach (string move in str681.Split(chArray681))
        openingMove681.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove681);
      OpeningMove openingMove682 = new OpeningMove();
      openingMove682.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQK2R b KQkq -";
      string str682 = "f8e7{6}";
      char[] chArray682 = new char[1]{ ' ' };
      foreach (string move in str682.Split(chArray682))
        openingMove682.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove682);
      OpeningMove openingMove683 = new OpeningMove();
      openingMove683.StartingFEN = "r4rk1/pp1bbppp/3ppn2/q3P1B1/2BQ1P2/2N5/PPP3PP/2KR3R b - -";
      string str683 = "d6e5{5}";
      char[] chArray683 = new char[1]{ ' ' };
      foreach (string move in str683.Split(chArray683))
        openingMove683.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove683);
      OpeningMove openingMove684 = new OpeningMove();
      openingMove684.StartingFEN = "r1bqkb1r/pppp1ppp/2n2n2/4p3/4P3/2N2N2/PPPP1PPP/R1BQKB1R w KQkq -";
      string str684 = "f1b5{5}";
      char[] chArray684 = new char[1]{ ' ' };
      foreach (string move in str684.Split(chArray684))
        openingMove684.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove684);
      OpeningMove openingMove685 = new OpeningMove();
      openingMove685.StartingFEN = "rnbqkb1r/pp2pppp/8/3n4/3p4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str685 = "d1d4{5}";
      char[] chArray685 = new char[1]{ ' ' };
      foreach (string move in str685.Split(chArray685))
        openingMove685.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove685);
      OpeningMove openingMove686 = new OpeningMove();
      openingMove686.StartingFEN = "rnbqkbnr/pppppp1p/6p1/8/3PP3/8/PPP2PPP/RNBQKBNR b KQkq d3";
      string str686 = "f8g7{10}";
      char[] chArray686 = new char[1]{ ' ' };
      foreach (string move in str686.Split(chArray686))
        openingMove686.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove686);
      OpeningMove openingMove687 = new OpeningMove();
      openingMove687.StartingFEN = "rnbqkb1r/1p3ppp/p2p1n2/4p3/3NP3/2N1B3/PPP2PPP/R2QKB1R w KQkq e6";
      string str687 = "d4b3{82} d4f3{10}";
      char[] chArray687 = new char[1]{ ' ' };
      foreach (string move in str687.Split(chArray687))
        openingMove687.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove687);
      OpeningMove openingMove688 = new OpeningMove();
      openingMove688.StartingFEN = "rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/5NP1/PP1NPPBP/R1BQK2R b KQkq -";
      string str688 = "c7c5{5}";
      char[] chArray688 = new char[1]{ ' ' };
      foreach (string move in str688.Split(chArray688))
        openingMove688.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove688);
      OpeningMove openingMove689 = new OpeningMove();
      openingMove689.StartingFEN = "rnbqkbnr/pp1p1ppp/4p3/2p5/4P3/2P5/PP1P1PPP/RNBQKBNR w KQkq -";
      string str689 = "d2d4{10}";
      char[] chArray689 = new char[1]{ ' ' };
      foreach (string move in str689.Split(chArray689))
        openingMove689.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove689);
      OpeningMove openingMove690 = new OpeningMove();
      openingMove690.StartingFEN = "r1bqkb1r/1p1n1pp1/p2ppn1p/8/3NP1P1/2N1BP2/PPP4P/R2QKB1R w KQkq -";
      string str690 = "h1g1{5}";
      char[] chArray690 = new char[1]{ ' ' };
      foreach (string move in str690.Split(chArray690))
        openingMove690.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove690);
      OpeningMove openingMove691 = new OpeningMove();
      openingMove691.StartingFEN = "rn1qkb1r/pp2pppp/2p2n2/5b2/P1pP4/2N1PN2/1P3PPP/R1BQKB1R b KQkq -";
      string str691 = "e7e6{10}";
      char[] chArray691 = new char[1]{ ' ' };
      foreach (string move in str691.Split(chArray691))
        openingMove691.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove691);
      OpeningMove openingMove692 = new OpeningMove();
      openingMove692.StartingFEN = "rnbqk2r/ppp1bppp/8/3p4/3Pn3/3B1N2/PPP2PPP/RNBQ1RK1 b kq -";
      string str692 = "b8c6{10}";
      char[] chArray692 = new char[1]{ ' ' };
      foreach (string move in str692.Split(chArray692))
        openingMove692.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove692);
      OpeningMove openingMove693 = new OpeningMove();
      openingMove693.StartingFEN = "rn1qkb1r/pp3ppp/2p1pn2/5b2/P1pP4/2N1PN2/1P3PPP/R1BQKB1R w KQkq -";
      string str693 = "f1c4{22}";
      char[] chArray693 = new char[1]{ ' ' };
      foreach (string move in str693.Split(chArray693))
        openingMove693.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove693);
      OpeningMove openingMove694 = new OpeningMove();
      openingMove694.StartingFEN = "r1bqkb1r/pp1n1ppp/2p1pn2/8/2pP4/2NBPN2/PP3PPP/R1BQK2R w KQkq -";
      string str694 = "d3c4{30}";
      char[] chArray694 = new char[1]{ ' ' };
      foreach (string move in str694.Split(chArray694))
        openingMove694.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove694);
      OpeningMove openingMove695 = new OpeningMove();
      openingMove695.StartingFEN = "rnbqkbnr/1p3ppp/p2pp3/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
      string str695 = "c1e3{5}";
      char[] chArray695 = new char[1]{ ' ' };
      foreach (string move in str695.Split(chArray695))
        openingMove695.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove695);
      OpeningMove openingMove696 = new OpeningMove();
      openingMove696.StartingFEN = "r1bqkb1r/pp1npppp/2p2n2/6N1/2BP4/8/PPP2PPP/R1BQK1NR b KQkq -";
      string str696 = "e7e6{15}";
      char[] chArray696 = new char[1]{ ' ' };
      foreach (string move in str696.Split(chArray696))
        openingMove696.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove696);
      OpeningMove openingMove697 = new OpeningMove();
      openingMove697.StartingFEN = "rnbqkb1r/pp3ppp/2p1pn2/6B1/2pP4/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
      string str697 = "e2e4{30}";
      char[] chArray697 = new char[1]{ ' ' };
      foreach (string move in str697.Split(chArray697))
        openingMove697.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove697);
      OpeningMove openingMove698 = new OpeningMove();
      openingMove698.StartingFEN = "r1bqkb1r/pp1n1ppp/2p1pn2/8/2BP4/2N1PN2/PP3PPP/R1BQK2R b KQkq -";
      string str698 = "b7b5{25}";
      char[] chArray698 = new char[1]{ ' ' };
      foreach (string move in str698.Split(chArray698))
        openingMove698.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove698);
      OpeningMove openingMove699 = new OpeningMove();
      openingMove699.StartingFEN = "rnbqkb1r/pp3pp1/2p1pB1p/3p4/2PP4/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
      string str699 = "d8f6{35}";
      char[] chArray699 = new char[1]{ ' ' };
      foreach (string move in str699.Split(chArray699))
        openingMove699.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove699);
      OpeningMove openingMove700 = new OpeningMove();
      openingMove700.StartingFEN = "rnb1kb1r/1p3ppp/pq1ppn2/8/3NPP2/P1N2Q2/1PP3PP/R1B1KB1R b KQkq -";
      string str700 = "b8c6{12}";
      char[] chArray700 = new char[1]{ ' ' };
      foreach (string move in str700.Split(chArray700))
        openingMove700.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove700);
      OpeningMove openingMove701 = new OpeningMove();
      openingMove701.StartingFEN = "r1bqkb1r/pp3pp1/2nppn1p/8/3NP1PP/2N5/PPP2P2/R1BQKB1R w KQkq -";
      string str701 = "h1g1{5}";
      char[] chArray701 = new char[1]{ ' ' };
      foreach (string move in str701.Split(chArray701))
        openingMove701.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove701);
      OpeningMove openingMove702 = new OpeningMove();
      openingMove702.StartingFEN = "rn1qkb1r/pbp2ppp/1p2pn2/3p4/2PP4/P1N2N2/1P2PPPP/R1BQKB1R w KQkq d6";
      string str702 = "c4d5{10}";
      char[] chArray702 = new char[1]{ ' ' };
      foreach (string move in str702.Split(chArray702))
        openingMove702.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove702);
      OpeningMove openingMove703 = new OpeningMove();
      openingMove703.StartingFEN = "rnbqkb1r/pppp1ppp/5n2/4p3/4P3/2N2N2/PPPP1PPP/R1BQKB1R b KQkq -";
      string str703 = "f8b4{5}";
      char[] chArray703 = new char[1]{ ' ' };
      foreach (string move in str703.Split(chArray703))
        openingMove703.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove703);
      OpeningMove openingMove704 = new OpeningMove();
      openingMove704.StartingFEN = "r1bqkb1r/pp1p1ppp/2n1pn2/8/2PN4/2N5/PP2PPPP/R1BQKB1R w KQkq -";
      string str704 = "g2g3{15}";
      char[] chArray704 = new char[1]{ ' ' };
      foreach (string move in str704.Split(chArray704))
        openingMove704.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove704);
      OpeningMove openingMove705 = new OpeningMove();
      openingMove705.StartingFEN = "r1bqk1nr/pp1pppbp/2n3p1/8/2PNP3/8/PP3PPP/RNBQKB1R w KQkq -";
      string str705 = "c1e3{5}";
      char[] chArray705 = new char[1]{ ' ' };
      foreach (string move in str705.Split(chArray705))
        openingMove705.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove705);
      OpeningMove openingMove706 = new OpeningMove();
      openingMove706.StartingFEN = "rnbqkbnr/ppp1pp1p/3p2p1/8/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
      string str706 = "c2c4{6}";
      char[] chArray706 = new char[1]{ ' ' };
      foreach (string move in str706.Split(chArray706))
        openingMove706.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove706);
      OpeningMove openingMove707 = new OpeningMove();
      openingMove707.StartingFEN = "r1bqkbnr/pp1ppp1p/2n3p1/8/2PNP3/8/PP3PPP/RNBQKB1R b KQkq c3";
      string str707 = "g8f6{10}";
      char[] chArray707 = new char[1]{ ' ' };
      foreach (string move in str707.Split(chArray707))
        openingMove707.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove707);
      OpeningMove openingMove708 = new OpeningMove();
      openingMove708.StartingFEN = "rnbq1rk1/pppp1ppp/4pn2/8/1bPP4/2N1P3/PP3PPP/R1BQKBNR w KQ -";
      string str708 = "g1e2{5} f1d3{26}";
      char[] chArray708 = new char[1]{ ' ' };
      foreach (string move in str708.Split(chArray708))
        openingMove708.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove708);
      OpeningMove openingMove709 = new OpeningMove();
      openingMove709.StartingFEN = "rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/2N1P3/PP3PPP/R1BQKBNR w KQkq c6";
      string str709 = "g1e2{15} f1d3{5}";
      char[] chArray709 = new char[1]{ ' ' };
      foreach (string move in str709.Split(chArray709))
        openingMove709.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove709);
      OpeningMove openingMove710 = new OpeningMove();
      openingMove710.StartingFEN = "rn1qk2r/pp3ppp/2p1pn2/4N3/PbpPb3/2N2P2/1P4PP/R1BQKB1R w KQkq -";
      string str710 = "f3e4{20}";
      char[] chArray710 = new char[1]{ ' ' };
      foreach (string move in str710.Split(chArray710))
        openingMove710.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove710);
      OpeningMove openingMove711 = new OpeningMove();
      openingMove711.StartingFEN = "rnbqk2r/pp1p1ppp/4pn2/8/1bPp4/2N1P3/PP2NPPP/R1BQKB1R w KQkq -";
      string str711 = "e3d4{10}";
      char[] chArray711 = new char[1]{ ' ' };
      foreach (string move in str711.Split(chArray711))
        openingMove711.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove711);
      OpeningMove openingMove712 = new OpeningMove();
      openingMove712.StartingFEN = "rnbqkb1r/pp1p1ppp/4pn2/2pP4/2P5/5N2/PP2PPPP/RNBQKB1R b KQkq -";
      string str712 = "d7d6{40}";
      char[] chArray712 = new char[1]{ ' ' };
      foreach (string move in str712.Split(chArray712))
        openingMove712.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove712);
      OpeningMove openingMove713 = new OpeningMove();
      openingMove713.StartingFEN = "rnbqk2r/pp2bppp/2p2n2/3p4/3P1B2/2N1P3/PP3PPP/R2QKBNR w KQkq -";
      string str713 = "f1d3{5}";
      char[] chArray713 = new char[1]{ ' ' };
      foreach (string move in str713.Split(chArray713))
        openingMove713.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove713);
      OpeningMove openingMove714 = new OpeningMove();
      openingMove714.StartingFEN = "r1bqkb1r/pp1p1ppp/2n1pn2/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
      string str714 = "d4b5{27} d4c6{5}";
      char[] chArray714 = new char[1]{ ' ' };
      foreach (string move in str714.Split(chArray714))
        openingMove714.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove714);
      OpeningMove openingMove715 = new OpeningMove();
      openingMove715.StartingFEN = "rnbqkbnr/ppppp1pp/8/5p2/8/5N2/PPPPPPPP/RNBQKB1R w KQkq f6";
      string str715 = "g2g3{5}";
      char[] chArray715 = new char[1]{ ' ' };
      foreach (string move in str715.Split(chArray715))
        openingMove715.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove715);
      OpeningMove openingMove716 = new OpeningMove();
      openingMove716.StartingFEN = "rnbqkb1r/pp2pp1p/3p1np1/8/3NP3/2N1B3/PPP2PPP/R2QKB1R b KQkq -";
      string str716 = "f8g7{30}";
      char[] chArray716 = new char[1]{ ' ' };
      foreach (string move in str716.Split(chArray716))
        openingMove716.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove716);
      OpeningMove openingMove717 = new OpeningMove();
      openingMove717.StartingFEN = "rnbqk2r/ppp1ppbp/3p1np1/8/2PPP3/2N5/PP2NPPP/R1BQKB1R b KQkq -";
      string str717 = "a7a6{6}";
      char[] chArray717 = new char[1]{ ' ' };
      foreach (string move in str717.Split(chArray717))
        openingMove717.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove717);
      OpeningMove openingMove718 = new OpeningMove();
      openingMove718.StartingFEN = "r1bqkb1r/pppn1ppp/5n2/3p4/3P1B2/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
      string str718 = "c7c6{5}";
      char[] chArray718 = new char[1]{ ' ' };
      foreach (string move in str718.Split(chArray718))
        openingMove718.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove718);
      OpeningMove openingMove719 = new OpeningMove();
      openingMove719.StartingFEN = "rnbqk1nr/pp3ppp/4p3/2ppP3/3P4/P1b5/1PP2PPP/R1BQKBNR w KQkq -";
      string str719 = "b2c3{26}";
      char[] chArray719 = new char[1]{ ' ' };
      foreach (string move in str719.Split(chArray719))
        openingMove719.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove719);
      OpeningMove openingMove720 = new OpeningMove();
      openingMove720.StartingFEN = "rnbqkb1r/pp3ppp/3ppn2/2pP4/2P5/5N2/PP2PPPP/RNBQKB1R w KQkq -";
      string str720 = "b1c3{20}";
      char[] chArray720 = new char[1]{ ' ' };
      foreach (string move in str720.Split(chArray720))
        openingMove720.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove720);
      OpeningMove openingMove721 = new OpeningMove();
      openingMove721.StartingFEN = "rnbq1rk1/ppp2pbp/3p1np1/3Pp3/2P1P3/2N2N2/PP2BPPP/R1BQK2R b KQ -";
      string str721 = "a7a5{16}";
      char[] chArray721 = new char[1]{ ' ' };
      foreach (string move in str721.Split(chArray721))
        openingMove721.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove721);
      OpeningMove openingMove722 = new OpeningMove();
      openingMove722.StartingFEN = "rnbqkb1r/p4ppp/2p1pn2/1p4B1/2pPP3/2N2N2/PP3PPP/R2QKB1R w KQkq b6";
      string str722 = "e4e5{20}";
      char[] chArray722 = new char[1]{ ' ' };
      foreach (string move in str722.Split(chArray722))
        openingMove722.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove722);
      OpeningMove openingMove723 = new OpeningMove();
      openingMove723.StartingFEN = "rn1qk2r/pp3ppp/2p1pn2/5b2/PbBP4/2N1PN2/1P3PPP/R1BQK2R w KQkq -";
      string str723 = "e1g1{17}";
      char[] chArray723 = new char[1]{ ' ' };
      foreach (string move in str723.Split(chArray723))
        openingMove723.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove723);
      OpeningMove openingMove724 = new OpeningMove();
      openingMove724.StartingFEN = "r1bqkb1r/pp3ppp/2np1n2/1N2p3/4P3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
      string str724 = "c1g5{77}";
      char[] chArray724 = new char[1]{ ' ' };
      foreach (string move in str724.Split(chArray724))
        openingMove724.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove724);
      OpeningMove openingMove725 = new OpeningMove();
      openingMove725.StartingFEN = "rnbqk1nr/ppppbppp/8/3Np3/2P5/8/PP1PPPPP/R1BQKBNR w KQkq -";
      string str725 = "d2d4{6}";
      char[] chArray725 = new char[1]{ ' ' };
      foreach (string move in str725.Split(chArray725))
        openingMove725.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove725);
      OpeningMove openingMove726 = new OpeningMove();
      openingMove726.StartingFEN = "rnb1kb1r/pp3pp1/2p1pq1p/3p4/2PP4/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
      string str726 = "e2e3{15}";
      char[] chArray726 = new char[1]{ ' ' };
      foreach (string move in str726.Split(chArray726))
        openingMove726.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove726);
      OpeningMove openingMove727 = new OpeningMove();
      openingMove727.StartingFEN = "rnbqkbnr/pppppp1p/6p1/8/8/5N2/PPPPPPPP/RNBQKB1R w KQkq -";
      string str727 = "d2d4{20}";
      char[] chArray727 = new char[1]{ ' ' };
      foreach (string move in str727.Split(chArray727))
        openingMove727.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove727);
      OpeningMove openingMove728 = new OpeningMove();
      openingMove728.StartingFEN = "r1bqkbnr/pp1ppp1p/2B3p1/2p5/4P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
      string str728 = "d7c6{10}";
      char[] chArray728 = new char[1]{ ' ' };
      foreach (string move in str728.Split(chArray728))
        openingMove728.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove728);
      OpeningMove openingMove729 = new OpeningMove();
      openingMove729.StartingFEN = "rnbqkb1r/1p3ppp/p2p1n2/4p3/4P3/1NN5/PPP1BPPP/R1BQK2R b KQkq -";
      string str729 = "f8e7{22}";
      char[] chArray729 = new char[1]{ ' ' };
      foreach (string move in str729.Split(chArray729))
        openingMove729.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove729);
      OpeningMove openingMove730 = new OpeningMove();
      openingMove730.StartingFEN = "r1bqkb1r/p2n1ppp/2p1pn2/1p6/2BP4/2N1PN2/PP3PPP/R1BQK2R w KQkq b6";
      string str730 = "c4d3{20}";
      char[] chArray730 = new char[1]{ ' ' };
      foreach (string move in str730.Split(chArray730))
        openingMove730.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove730);
      OpeningMove openingMove731 = new OpeningMove();
      openingMove731.StartingFEN = "r1bqkb1r/3n1ppp/p1p1pn2/1p6/3P4/2NBPN2/PP3PPP/R1BQK2R w KQkq -";
      string str731 = "e3e4{5}";
      char[] chArray731 = new char[1]{ ' ' };
      foreach (string move in str731.Split(chArray731))
        openingMove731.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove731);
      OpeningMove openingMove732 = new OpeningMove();
      openingMove732.StartingFEN = "rnbqk2r/ppppppbp/5np1/8/2PP4/6P1/PP2PPBP/RNBQK1NR b KQkq -";
      string str732 = "d7d5{5} e8g8{10}";
      char[] chArray732 = new char[1]{ ' ' };
      foreach (string move in str732.Split(chArray732))
        openingMove732.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove732);
      OpeningMove openingMove733 = new OpeningMove();
      openingMove733.StartingFEN = "r1bqkbnr/pp1ppppp/2n5/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R b KQkq -";
      string str733 = "e7e5{5} d7d6{5} g7g6{5}";
      char[] chArray733 = new char[1]{ ' ' };
      foreach (string move in str733.Split(chArray733))
        openingMove733.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove733);
      OpeningMove openingMove734 = new OpeningMove();
      openingMove734.StartingFEN = "rn1qkbnr/pp1bpppp/3p4/1Bp5/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str734 = "b5d7{5}";
      char[] chArray734 = new char[1]{ ' ' };
      foreach (string move in str734.Split(chArray734))
        openingMove734.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove734);
      OpeningMove openingMove735 = new OpeningMove();
      openingMove735.StartingFEN = "r2q1rk1/1p2bppp/p1npbn2/4p3/4P3/1NN1B3/PPPQBPPP/R4RK1 w - -";
      string str735 = "f2f3{5}";
      char[] chArray735 = new char[1]{ ' ' };
      foreach (string move in str735.Split(chArray735))
        openingMove735.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove735);
      OpeningMove openingMove736 = new OpeningMove();
      openingMove736.StartingFEN = "rn1q1rk1/pbp1bpp1/1p2pn1p/3p4/2PP3B/2N1PN2/PP2BPPP/R2QK2R w KQ -";
      string str736 = "h4f6{5}";
      char[] chArray736 = new char[1]{ ' ' };
      foreach (string move in str736.Split(chArray736))
        openingMove736.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove736);
      OpeningMove openingMove737 = new OpeningMove();
      openingMove737.StartingFEN = "r1bqk2r/pp2ppbp/2n3p1/2p5/2BPP3/2P1B3/P3NPPP/R2QK2R b KQkq -";
      string str737 = "e8g8{15}";
      char[] chArray737 = new char[1]{ ' ' };
      foreach (string move in str737.Split(chArray737))
        openingMove737.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove737);
      OpeningMove openingMove738 = new OpeningMove();
      openingMove738.StartingFEN = "r1bqkb1r/pp1p1ppp/2n2n2/1N2p3/4P3/2N5/PPP2PPP/R1BQKB1R b KQkq -";
      string str738 = "d7d6{67}";
      char[] chArray738 = new char[1]{ ' ' };
      foreach (string move in str738.Split(chArray738))
        openingMove738.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove738);
      OpeningMove openingMove739 = new OpeningMove();
      openingMove739.StartingFEN = "r1bqkb1r/pp1n1ppp/2p1pn2/6N1/2BP4/8/PPP1QPPP/R1B1K1NR b KQkq -";
      string str739 = "d7b6{10}";
      char[] chArray739 = new char[1]{ ' ' };
      foreach (string move in str739.Split(chArray739))
        openingMove739.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove739);
      OpeningMove openingMove740 = new OpeningMove();
      openingMove740.StartingFEN = "r1bq1rk1/2p1bppp/p1n5/1p1np3/8/1BP2N2/PP1P1PPP/RNBQR1K1 w - -";
      string str740 = "f3e5{30}";
      char[] chArray740 = new char[1]{ ' ' };
      foreach (string move in str740.Split(chArray740))
        openingMove740.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove740);
      OpeningMove openingMove741 = new OpeningMove();
      openingMove741.StartingFEN = "rn1qkb1r/pbp2ppp/1p2p3/3n4/3P4/P1N2N2/1P1BPPPP/R2QKB1R b KQkq -";
      string str741 = "f8e7{5}";
      char[] chArray741 = new char[1]{ ' ' };
      foreach (string move in str741.Split(chArray741))
        openingMove741.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove741);
      OpeningMove openingMove742 = new OpeningMove();
      openingMove742.StartingFEN = "rnbqkb1r/ppp1pppp/5n2/4P3/2pP4/8/PP3PPP/RNBQKBNR b KQkq -";
      string str742 = "f6d5{5}";
      char[] chArray742 = new char[1]{ ' ' };
      foreach (string move in str742.Split(chArray742))
        openingMove742.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove742);
      OpeningMove openingMove743 = new OpeningMove();
      openingMove743.StartingFEN = "r1bqkb1r/pp3ppp/2nppn2/1N6/4P3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
      string str743 = "c1f4{6}";
      char[] chArray743 = new char[1]{ ' ' };
      foreach (string move in str743.Split(chArray743))
        openingMove743.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove743);
      OpeningMove openingMove744 = new OpeningMove();
      openingMove744.StartingFEN = "rnbqkb1r/pppppppp/8/3nP3/8/8/PPPP1PPP/RNBQKBNR w KQkq -";
      string str744 = "d2d4{17}";
      char[] chArray744 = new char[1]{ ' ' };
      foreach (string move in str744.Split(chArray744))
        openingMove744.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove744);
      OpeningMove openingMove745 = new OpeningMove();
      openingMove745.StartingFEN = "r2q1rk1/2p1bppp/p1np1n2/1p2p3/3PP3/1bP2N1P/PP3PP1/RNBQR1K1 w - -";
      string str745 = "a2b3{5}";
      char[] chArray745 = new char[1]{ ' ' };
      foreach (string move in str745.Split(chArray745))
        openingMove745.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove745);
      OpeningMove openingMove746 = new OpeningMove();
      openingMove746.StartingFEN = "r1bqkb1r/pp2pppp/2np1n2/8/3NP3/2N3P1/PPP2P1P/R1BQKB1R b KQkq -";
      string str746 = "e7e6{5} g7g6{5}";
      char[] chArray746 = new char[1]{ ' ' };
      foreach (string move in str746.Split(chArray746))
        openingMove746.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove746);
      OpeningMove openingMove747 = new OpeningMove();
      openingMove747.StartingFEN = "rn1qkb1r/pbpp1ppp/1p2pn2/8/2P5/5NP1/PP1PPPBP/RNBQK2R w KQkq -";
      string str747 = "e1g1{25}";
      char[] chArray747 = new char[1]{ ' ' };
      foreach (string move in str747.Split(chArray747))
        openingMove747.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove747);
      OpeningMove openingMove748 = new OpeningMove();
      openingMove748.StartingFEN = "rn1q1rk1/pp3ppp/2p1pn2/5b2/PbBP4/2N1PN2/1P3PPP/R1BQ1RK1 w - -";
      string str748 = "d1e2{6}";
      char[] chArray748 = new char[1]{ ' ' };
      foreach (string move in str748.Split(chArray748))
        openingMove748.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove748);
      OpeningMove openingMove749 = new OpeningMove();
      openingMove749.StartingFEN = "rnbqk2r/pp2nppp/4p3/2ppP3/3P4/P1P5/2P2PPP/R1BQKBNR w KQkq -";
      string str749 = "d1g4{6} g1f3{5}";
      char[] chArray749 = new char[1]{ ' ' };
      foreach (string move in str749.Split(chArray749))
        openingMove749.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove749);
      OpeningMove openingMove750 = new OpeningMove();
      openingMove750.StartingFEN = "rnbq1rk1/ppp1ppbp/3p1np1/8/2PP4/5NP1/PP2PPBP/RNBQ1RK1 b - -";
      string str750 = "c7c5{6}";
      char[] chArray750 = new char[1]{ ' ' };
      foreach (string move in str750.Split(chArray750))
        openingMove750.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove750);
      OpeningMove openingMove751 = new OpeningMove();
      openingMove751.StartingFEN = "r1bqkbnr/pppp2pp/2n5/1B2pp2/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq f6";
      string str751 = "b1c3{5}";
      char[] chArray751 = new char[1]{ ' ' };
      foreach (string move in str751.Split(chArray751))
        openingMove751.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove751);
      OpeningMove openingMove752 = new OpeningMove();
      openingMove752.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/8/2pP4/5NP1/PP2PPBP/RNBQK2R b KQkq -";
      string str752 = "b8c6{5} a7a6{5}";
      char[] chArray752 = new char[1]{ ' ' };
      foreach (string move in str752.Split(chArray752))
        openingMove752.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove752);
      OpeningMove openingMove753 = new OpeningMove();
      openingMove753.StartingFEN = "r1bqkbnr/pp3ppp/2npp3/8/3NP3/2N1B3/PPP2PPP/R2QKB1R b KQkq -";
      string str753 = "g8f6{18}";
      char[] chArray753 = new char[1]{ ' ' };
      foreach (string move in str753.Split(chArray753))
        openingMove753.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove753);
      OpeningMove openingMove754 = new OpeningMove();
      openingMove754.StartingFEN = "r1bqkb1r/pp2pppp/2n2n2/2pp4/2P5/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq d6";
      string str754 = "d2d4{25}";
      char[] chArray754 = new char[1]{ ' ' };
      foreach (string move in str754.Split(chArray754))
        openingMove754.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove754);
      OpeningMove openingMove755 = new OpeningMove();
      openingMove755.StartingFEN = "r1bqkb1r/pppn1ppp/4pn2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str755 = "c4d5{15} d1c2{6} c1g5{5}";
      char[] chArray755 = new char[1]{ ' ' };
      foreach (string move in str755.Split(chArray755))
        openingMove755.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove755);
      OpeningMove openingMove756 = new OpeningMove();
      openingMove756.StartingFEN = "r2q1rk1/1bp2ppp/pnnp1b2/1p2p3/P2PP3/NBP2N1P/1P3PP1/R1BQR1K1 w - -";
      string str756 = "d4d5{5}";
      char[] chArray756 = new char[1]{ ' ' };
      foreach (string move in str756.Split(chArray756))
        openingMove756.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove756);
      OpeningMove openingMove757 = new OpeningMove();
      openingMove757.StartingFEN = "r1bqkb1r/pp2pppp/2np1n2/8/2BNP3/2N5/PPP2PPP/R1BQK2R b KQkq -";
      string str757 = "d8b6{20}";
      char[] chArray757 = new char[1]{ ' ' };
      foreach (string move in str757.Split(chArray757))
        openingMove757.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove757);
      OpeningMove openingMove758 = new OpeningMove();
      openingMove758.StartingFEN = "r2qk2r/pp1n1ppp/2p1pn2/5b2/PbBP4/2N1PN2/1P3PPP/R1BQ1RK1 w kq -";
      string str758 = "f3h4{5}";
      char[] chArray758 = new char[1]{ ' ' };
      foreach (string move in str758.Split(chArray758))
        openingMove758.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove758);
      OpeningMove openingMove759 = new OpeningMove();
      openingMove759.StartingFEN = "r1bqr1k1/pp1n1ppp/2pbpn2/3p4/2PP4/2N1PN2/PPQ1BPPP/R1B2RK1 w - -";
      string str759 = "f1d1{5}";
      char[] chArray759 = new char[1]{ ' ' };
      foreach (string move in str759.Split(chArray759))
        openingMove759.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove759);
      OpeningMove openingMove760 = new OpeningMove();
      openingMove760.StartingFEN = "rnbq1rk1/ppp1bppp/4pn2/3p4/2PP4/2N2N2/PPQ1PPPP/R1B1KB1R w KQ -";
      string str760 = "c1g5{5}";
      char[] chArray760 = new char[1]{ ' ' };
      foreach (string move in str760.Split(chArray760))
        openingMove760.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove760);
      OpeningMove openingMove761 = new OpeningMove();
      openingMove761.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
      string str761 = "c2c4{40} g2g3{5}";
      char[] chArray761 = new char[1]{ ' ' };
      foreach (string move in str761.Split(chArray761))
        openingMove761.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove761);
      OpeningMove openingMove762 = new OpeningMove();
      openingMove762.StartingFEN = "rnbqk2r/ppp1ppbp/6p1/1B6/3PP3/2P5/P4PPP/R1BQK1NR b KQkq -";
      string str762 = "c8d7{5}";
      char[] chArray762 = new char[1]{ ' ' };
      foreach (string move in str762.Split(chArray762))
        openingMove762.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove762);
      OpeningMove openingMove763 = new OpeningMove();
      openingMove763.StartingFEN = "rn1qkbnr/pp3ppp/2p1p3/3pPb2/3P4/5N2/PPP2PPP/RNBQKB1R w KQkq -";
      string str763 = "f1e2{30}";
      char[] chArray763 = new char[1]{ ' ' };
      foreach (string move in str763.Split(chArray763))
        openingMove763.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove763);
      OpeningMove openingMove764 = new OpeningMove();
      openingMove764.StartingFEN = "r2qkb1r/2p2ppp/p1n1b3/1p1pP3/4n3/1B3N2/PPP2PPP/RNBQ1RK1 w kq -";
      string str764 = "c1e3{5} b1d2{46}";
      char[] chArray764 = new char[1]{ ' ' };
      foreach (string move in str764.Split(chArray764))
        openingMove764.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove764);
      OpeningMove openingMove765 = new OpeningMove();
      openingMove765.StartingFEN = "r1bq1rk1/ppp1npbp/3p1np1/3Pp3/2P1P3/2N2N2/PP2BPPP/R1BQ1RK1 w - -";
      string str765 = "f3d2{5} b2b4{50}";
      char[] chArray765 = new char[1]{ ' ' };
      foreach (string move in str765.Split(chArray765))
        openingMove765.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove765);
      OpeningMove openingMove766 = new OpeningMove();
      openingMove766.StartingFEN = "rn1qk2r/p3bppp/bpp1p3/3pN3/2PPn3/1PB3P1/P3PPBP/RN1QK2R w KQkq -";
      string str766 = "e1g1{5}";
      char[] chArray766 = new char[1]{ ' ' };
      foreach (string move in str766.Split(chArray766))
        openingMove766.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove766);
      OpeningMove openingMove767 = new OpeningMove();
      openingMove767.StartingFEN = "rn1qkbnr/ppp1pppp/8/3p1b2/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
      string str767 = "c2c4{15}";
      char[] chArray767 = new char[1]{ ' ' };
      foreach (string move in str767.Split(chArray767))
        openingMove767.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove767);
      OpeningMove openingMove768 = new OpeningMove();
      openingMove768.StartingFEN = "rnbqk2r/ppp1ppbp/5np1/3P4/3P4/5NP1/PP2PP1P/RNBQKB1R b KQkq -";
      string str768 = "f6d5{11}";
      char[] chArray768 = new char[1]{ ' ' };
      foreach (string move in str768.Split(chArray768))
        openingMove768.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove768);
      OpeningMove openingMove769 = new OpeningMove();
      openingMove769.StartingFEN = "rnbqkb1r/pppppppp/5n2/8/2PP4/8/PP2PPPP/RNBQKBNR b KQkq d3";
      string str769 = "e7e6{10}";
      char[] chArray769 = new char[1]{ ' ' };
      foreach (string move in str769.Split(chArray769))
        openingMove769.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove769);
      OpeningMove openingMove770 = new OpeningMove();
      openingMove770.StartingFEN = "rnbqkb1r/pp2pp1p/2p2np1/3p4/2PP4/6P1/PP2PPBP/RNBQK1NR w KQkq d6";
      string str770 = "c4d5{10}";
      char[] chArray770 = new char[1]{ ' ' };
      foreach (string move in str770.Split(chArray770))
        openingMove770.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove770);
      OpeningMove openingMove771 = new OpeningMove();
      openingMove771.StartingFEN = "rnbqk2r/pppp1ppp/4pn2/6B1/1bPP4/2N5/PP2PPPP/R2QKBNR b KQkq -";
      string str771 = "h7h6{5}";
      char[] chArray771 = new char[1]{ ' ' };
      foreach (string move in str771.Split(chArray771))
        openingMove771.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove771);
      OpeningMove openingMove772 = new OpeningMove();
      openingMove772.StartingFEN = "rnb2rk1/ppp1qpp1/4p2p/3p4/2PPn3/2N1PN2/PP3PPP/R2QKB1R w KQ -";
      string str772 = "a1c1{10}";
      char[] chArray772 = new char[1]{ ' ' };
      foreach (string move in str772.Split(chArray772))
        openingMove772.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove772);
      OpeningMove openingMove773 = new OpeningMove();
      openingMove773.StartingFEN = "rnbqkb1r/1p2pppp/p1p2n2/3p4/2PP4/2N1P3/PP3PPP/R1BQKBNR w KQkq -";
      string str773 = "g1f3{5} d1c2{6}";
      char[] chArray773 = new char[1]{ ' ' };
      foreach (string move in str773.Split(chArray773))
        openingMove773.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove773);
      OpeningMove openingMove774 = new OpeningMove();
      openingMove774.StartingFEN = "r1b1kbnr/1pqp1ppp/p1n1p3/8/3NP3/2N1B3/PPP2PPP/R2QKB1R w KQkq -";
      string str774 = "f1d3{20}";
      char[] chArray774 = new char[1]{ ' ' };
      foreach (string move in str774.Split(chArray774))
        openingMove774.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove774);
      OpeningMove openingMove775 = new OpeningMove();
      openingMove775.StartingFEN = "rnbqkb1r/ppp2ppp/8/3pp3/3Pn3/3B1N2/PPP2PPP/RNBQK2R w KQkq d6";
      string str775 = "f3e5{26}";
      char[] chArray775 = new char[1]{ ' ' };
      foreach (string move in str775.Split(chArray775))
        openingMove775.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove775);
      OpeningMove openingMove776 = new OpeningMove();
      openingMove776.StartingFEN = "rnbqk1nr/ppp2ppp/4p3/3pP3/1b1P4/2N5/PPP2PPP/R1BQKBNR b KQkq -";
      string str776 = "b7b6{5} c7c5{5}";
      char[] chArray776 = new char[1]{ ' ' };
      foreach (string move in str776.Split(chArray776))
        openingMove776.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove776);
      OpeningMove openingMove777 = new OpeningMove();
      openingMove777.StartingFEN = "rnbqk2r/p1pp1ppp/1p2pn2/8/1bP5/2N2NP1/PP1PPP1P/R1BQKB1R w KQkq -";
      string str777 = "f1g2{5}";
      char[] chArray777 = new char[1]{ ' ' };
      foreach (string move in str777.Split(chArray777))
        openingMove777.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove777);
      OpeningMove openingMove778 = new OpeningMove();
      openingMove778.StartingFEN = "r1bqkb1r/pp3ppp/2n1pn2/2pp4/2PP4/2N2NP1/PP2PP1P/R1BQKB1R w KQkq -";
      string str778 = "c4d5{10}";
      char[] chArray778 = new char[1]{ ' ' };
      foreach (string move in str778.Split(chArray778))
        openingMove778.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove778);
      OpeningMove openingMove779 = new OpeningMove();
      openingMove779.StartingFEN = "rn1qkbnr/ppp2ppp/4p3/3p1b2/2PP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
      string str779 = "b1c3{10}";
      char[] chArray779 = new char[1]{ ' ' };
      foreach (string move in str779.Split(chArray779))
        openingMove779.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove779);
      OpeningMove openingMove780 = new OpeningMove();
      openingMove780.StartingFEN = "rn1qkb1r/pbpp1ppp/1p2p3/8/2PPn3/P1N2N2/1P2PPPP/R1BQKB1R w KQkq -";
      string str780 = "c3e4{5}";
      char[] chArray780 = new char[1]{ ' ' };
      foreach (string move in str780.Split(chArray780))
        openingMove780.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove780);
      OpeningMove openingMove781 = new OpeningMove();
      openingMove781.StartingFEN = "r1bqkbnr/pp1npppp/2p5/6N1/3P4/8/PPP2PPP/R1BQKBNR b KQkq -";
      string str781 = "g8f6{40} e7e6{10} d7f6{5}";
      char[] chArray781 = new char[1]{ ' ' };
      foreach (string move in str781.Split(chArray781))
        openingMove781.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove781);
      OpeningMove openingMove782 = new OpeningMove();
      openingMove782.StartingFEN = "r1bq1rk1/ppp1ppbp/2np1np1/8/2PPP3/2N1BP2/PP4PP/R2QKBNR w KQ -";
      string str782 = "g1e2{5}";
      char[] chArray782 = new char[1]{ ' ' };
      foreach (string move in str782.Split(chArray782))
        openingMove782.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove782);
      OpeningMove openingMove783 = new OpeningMove();
      openingMove783.StartingFEN = "r1bqkbnr/ppp1pppp/2n5/8/2pPP3/8/PP3PPP/RNBQKBNR w KQkq -";
      string str783 = "c1e3{10} g1f3{5}";
      char[] chArray783 = new char[1]{ ' ' };
      foreach (string move in str783.Split(chArray783))
        openingMove783.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove783);
      OpeningMove openingMove784 = new OpeningMove();
      openingMove784.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/6B1/3NP3/2N2Q2/PPP2PPP/R3KB1R b KQkq -";
      string str784 = "b8d7{5} h7h6{5}";
      char[] chArray784 = new char[1]{ ' ' };
      foreach (string move in str784.Split(chArray784))
        openingMove784.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove784);
      OpeningMove openingMove785 = new OpeningMove();
      openingMove785.StartingFEN = "r2qrbk1/1bp2pp1/p1np1n1p/1p6/P2PP3/5N1P/1PBN1PP1/R1BQR1K1 b - -";
      string str785 = "c6b4{15}";
      char[] chArray785 = new char[1]{ ' ' };
      foreach (string move in str785.Split(chArray785))
        openingMove785.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove785);
      OpeningMove openingMove786 = new OpeningMove();
      openingMove786.StartingFEN = "rnbqk2r/p1pp1ppp/1p2p3/8/1bPPn3/2N1P3/PP2NPPP/R1BQKB1R w KQkq -";
      string str786 = "c1d2{5}";
      char[] chArray786 = new char[1]{ ' ' };
      foreach (string move in str786.Split(chArray786))
        openingMove786.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove786);
      OpeningMove openingMove787 = new OpeningMove();
      openingMove787.StartingFEN = "rnbqk2r/pp1pppbp/5np1/2p5/2PP4/5NP1/PP2PPBP/RNBQK2R b KQkq -";
      string str787 = "d8a5{5}";
      char[] chArray787 = new char[1]{ ' ' };
      foreach (string move in str787.Split(chArray787))
        openingMove787.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove787);
      OpeningMove openingMove788 = new OpeningMove();
      openingMove788.StartingFEN = "rnbqkbnr/ppppp1pp/8/5p2/3P4/6P1/PPP1PP1P/RNBQKBNR b KQkq -";
      string str788 = "g8f6{15}";
      char[] chArray788 = new char[1]{ ' ' };
      foreach (string move in str788.Split(chArray788))
        openingMove788.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove788);
      OpeningMove openingMove789 = new OpeningMove();
      openingMove789.StartingFEN = "rnbq1rk1/ppp2ppp/4pn2/3p4/1bPP4/2NBP3/PP3PPP/R1BQK1NR w KQ d6";
      string str789 = "g1f3{15}";
      char[] chArray789 = new char[1]{ ' ' };
      foreach (string move in str789.Split(chArray789))
        openingMove789.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove789);
      OpeningMove openingMove790 = new OpeningMove();
      openingMove790.StartingFEN = "rnbqkb1r/ppppp1pp/5n2/5p2/3P4/6P1/PPP1PPBP/RNBQK1NR b KQkq -";
      string str790 = "d7d6{10}";
      char[] chArray790 = new char[1]{ ' ' };
      foreach (string move in str790.Split(chArray790))
        openingMove790.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove790);
      OpeningMove openingMove791 = new OpeningMove();
      openingMove791.StartingFEN = "rnbqkbnr/1pp1pppp/p7/8/2pP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
      string str791 = "e2e3{10}";
      char[] chArray791 = new char[1]{ ' ' };
      foreach (string move in str791.Split(chArray791))
        openingMove791.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove791);
      OpeningMove openingMove792 = new OpeningMove();
      openingMove792.StartingFEN = "r1bqkbnr/pppp1ppp/2n5/4p3/2P5/2N2N2/PP1PPPPP/R1BQKB1R b KQkq -";
      string str792 = "f8b4{5}";
      char[] chArray792 = new char[1]{ ' ' };
      foreach (string move in str792.Split(chArray792))
        openingMove792.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove792);
      OpeningMove openingMove793 = new OpeningMove();
      openingMove793.StartingFEN = "rnbqk2r/pp2ppbp/3p1np1/8/3NP3/2N1BP2/PPP3PP/R2QKB1R b KQkq -";
      string str793 = "b8c6{10} e8g8{5}";
      char[] chArray793 = new char[1]{ ' ' };
      foreach (string move in str793.Split(chArray793))
        openingMove793.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove793);
      OpeningMove openingMove794 = new OpeningMove();
      openingMove794.StartingFEN = "rnbqkb1r/pppp1ppp/4pn2/6B1/3P4/5N2/PPP1PPPP/RN1QKB1R b KQkq -";
      string str794 = "h7h6{5}";
      char[] chArray794 = new char[1]{ ' ' };
      foreach (string move in str794.Split(chArray794))
        openingMove794.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove794);
      OpeningMove openingMove795 = new OpeningMove();
      openingMove795.StartingFEN = "rnbqkb1r/pp2pp1p/2pp1np1/8/3PP3/2N1B3/PPP2PPP/R2QKBNR w KQkq -";
      string str795 = "f2f3{10} h2h3{5}";
      char[] chArray795 = new char[1]{ ' ' };
      foreach (string move in str795.Split(chArray795))
        openingMove795.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove795);
      OpeningMove openingMove796 = new OpeningMove();
      openingMove796.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/6B1/3Pp3/2N5/PPP2PPP/R2QKBNR w KQkq -";
      string str796 = "c3e4{63}";
      char[] chArray796 = new char[1]{ ' ' };
      foreach (string move in str796.Split(chArray796))
        openingMove796.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove796);
      OpeningMove openingMove797 = new OpeningMove();
      openingMove797.StartingFEN = "rnbqk2r/pp1pppbp/5np1/2p5/2PP4/5NP1/PP2PP1P/RNBQKB1R w KQkq c6";
      string str797 = "f1g2{11}";
      char[] chArray797 = new char[1]{ ' ' };
      foreach (string move in str797.Split(chArray797))
        openingMove797.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove797);
      OpeningMove openingMove798 = new OpeningMove();
      openingMove798.StartingFEN = "rn1q1rk1/pbpp1ppp/1p2pn2/6B1/2PP4/P1Q1P3/1P3PPP/R3KBNR b KQ -";
      string str798 = "d7d6{15}";
      char[] chArray798 = new char[1]{ ' ' };
      foreach (string move in str798.Split(chArray798))
        openingMove798.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove798);
      OpeningMove openingMove799 = new OpeningMove();
      openingMove799.StartingFEN = "rnbqkb1r/pp2pppp/5n2/3p4/2PP4/2N5/PP3PPP/R1BQKBNR b KQkq -";
      string str799 = "e7e6{15}";
      char[] chArray799 = new char[1]{ ' ' };
      foreach (string move in str799.Split(chArray799))
        openingMove799.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove799);
      OpeningMove openingMove800 = new OpeningMove();
      openingMove800.StartingFEN = "rnbqk2r/p2p1ppp/1p2pn2/2p5/1bPP1B2/1QN2N2/PP2PPPP/R3KB1R b KQkq -";
      string str800 = "e8g8{5}";
      char[] chArray800 = new char[1]{ ' ' };
      foreach (string move in str800.Split(chArray800))
        openingMove800.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove800);
      OpeningMove openingMove801 = new OpeningMove();
      openingMove801.StartingFEN = "rnbqkb1r/p2ppppp/5n2/1ppP4/2P5/8/PP2PPPP/RNBQKBNR w KQkq b6";
      string str801 = "c4b5{10} b1d2{5} g1f3{5}";
      char[] chArray801 = new char[1]{ ' ' };
      foreach (string move in str801.Split(chArray801))
        openingMove801.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove801);
      OpeningMove openingMove802 = new OpeningMove();
      openingMove802.StartingFEN = "r1bqkbnr/pp1npppp/3p4/1Bp5/3PP3/5N2/PPP2PPP/RNBQK2R b KQkq d3";
      string str802 = "g8f6{11}";
      char[] chArray802 = new char[1]{ ' ' };
      foreach (string move in str802.Split(chArray802))
        openingMove802.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove802);
      OpeningMove openingMove803 = new OpeningMove();
      openingMove803.StartingFEN = "rnbqk2r/ppp1ppbp/5np1/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq d6";
      string str803 = "c4d5{20}";
      char[] chArray803 = new char[1]{ ' ' };
      foreach (string move in str803.Split(chArray803))
        openingMove803.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove803);
      OpeningMove openingMove804 = new OpeningMove();
      openingMove804.StartingFEN = "r1bqkb1r/pp3ppp/2nppn2/8/3NP3/2N1BP2/PPP3PP/R2QKB1R b KQkq -";
      string str804 = "f8e7{6}";
      char[] chArray804 = new char[1]{ ' ' };
      foreach (string move in str804.Split(chArray804))
        openingMove804.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove804);
      OpeningMove openingMove805 = new OpeningMove();
      openingMove805.StartingFEN = "rnbqkb1r/1p2pppp/p2p1n2/8/3NP3/2N3P1/PPP2P1P/R1BQKB1R b KQkq -";
      string str805 = "e7e6{5}";
      char[] chArray805 = new char[1]{ ' ' };
      foreach (string move in str805.Split(chArray805))
        openingMove805.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove805);
      OpeningMove openingMove806 = new OpeningMove();
      openingMove806.StartingFEN = "rnbqkb1r/pp3ppp/3ppn2/2pP4/2P5/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
      string str806 = "e6d5{35}";
      char[] chArray806 = new char[1]{ ' ' };
      foreach (string move in str806.Split(chArray806))
        openingMove806.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove806);
      OpeningMove openingMove807 = new OpeningMove();
      openingMove807.StartingFEN = "r1bqkbnr/pp3ppp/2n5/1Bpp4/3P4/8/PPPN1PPP/R1BQK1NR w KQkq -";
      string str807 = "g1f3{5}";
      char[] chArray807 = new char[1]{ ' ' };
      foreach (string move in str807.Split(chArray807))
        openingMove807.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove807);
      OpeningMove openingMove808 = new OpeningMove();
      openingMove808.StartingFEN = "r1bqkb1r/ppp2ppp/2n5/3pN3/3Pn3/3B4/PPP2PPP/RNBQK2R w KQkq -";
      string str808 = "e5c6{5}";
      char[] chArray808 = new char[1]{ ' ' };
      foreach (string move in str808.Split(chArray808))
        openingMove808.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove808);
      OpeningMove openingMove809 = new OpeningMove();
      openingMove809.StartingFEN = "r1bqkb1r/pppp1ppp/2n2n2/4p3/2B1P3/3P1N2/PPP2PPP/RNBQK2R b KQkq -";
      string str809 = "f8e7{15}";
      char[] chArray809 = new char[1]{ ' ' };
      foreach (string move in str809.Split(chArray809))
        openingMove809.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove809);
      OpeningMove openingMove810 = new OpeningMove();
      openingMove810.StartingFEN = "r1bqkbnr/pppn1ppp/4p3/8/3PN3/8/PPP2PPP/R1BQKBNR w KQkq -";
      string str810 = "g1f3{5}";
      char[] chArray810 = new char[1]{ ' ' };
      foreach (string move in str810.Split(chArray810))
        openingMove810.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove810);
      OpeningMove openingMove811 = new OpeningMove();
      openingMove811.StartingFEN = "r2qkbnr/1ppb1ppp/p1np4/4p3/B3P3/2P2N2/PP1P1PPP/RNBQK2R w KQkq -";
      string str811 = "d2d4{5}";
      char[] chArray811 = new char[1]{ ' ' };
      foreach (string move in str811.Split(chArray811))
        openingMove811.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove811);
      OpeningMove openingMove812 = new OpeningMove();
      openingMove812.StartingFEN = "rnbqkbnr/ppp1pppp/8/3p4/8/5NP1/PPPPPP1P/RNBQKB1R b KQkq -";
      string str812 = "c8g4{10} g8f6{10}";
      char[] chArray812 = new char[1]{ ' ' };
      foreach (string move in str812.Split(chArray812))
        openingMove812.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove812);
      OpeningMove openingMove813 = new OpeningMove();
      openingMove813.StartingFEN = "r1bqkb1r/2pp1ppp/p1n2n2/1p2p3/B3P3/5N2/PPPP1PPP/RNBQ1RK1 w kq b6";
      string str813 = "a4b3{55}";
      char[] chArray813 = new char[1]{ ' ' };
      foreach (string move in str813.Split(chArray813))
        openingMove813.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove813);
      OpeningMove openingMove814 = new OpeningMove();
      openingMove814.StartingFEN = "rnbqk2r/pp2ppbp/3p1np1/8/3NP3/2N1B3/PPP2PPP/R2QKB1R w KQkq -";
      string str814 = "f2f3{30}";
      char[] chArray814 = new char[1]{ ' ' };
      foreach (string move in str814.Split(chArray814))
        openingMove814.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove814);
      OpeningMove openingMove815 = new OpeningMove();
      openingMove815.StartingFEN = "r1bq1rk1/2ppbppp/p1n2n2/1p2p3/4P3/1B3N2/PPPPQPPP/RNB2RK1 w - -";
      string str815 = "c2c3{5}";
      char[] chArray815 = new char[1]{ ' ' };
      foreach (string move in str815.Split(chArray815))
        openingMove815.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove815);
      OpeningMove openingMove816 = new OpeningMove();
      openingMove816.StartingFEN = "r1bqkb1r/1ppp1ppp/p1n2n2/4p3/B3P3/5N2/PPPPQPPP/RNB1K2R b KQkq -";
      string str816 = "b7b5{5}";
      char[] chArray816 = new char[1]{ ' ' };
      foreach (string move in str816.Split(chArray816))
        openingMove816.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove816);
      OpeningMove openingMove817 = new OpeningMove();
      openingMove817.StartingFEN = "rnbqkbnr/1pp1pppp/p7/8/2pP4/4PN2/PP3PPP/RNBQKB1R b KQkq -";
      string str817 = "e7e6{5}";
      char[] chArray817 = new char[1]{ ' ' };
      foreach (string move in str817.Split(chArray817))
        openingMove817.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove817);
      OpeningMove openingMove818 = new OpeningMove();
      openingMove818.StartingFEN = "rnbqk2r/ppppppbp/5np1/8/2P5/5NP1/PP1PPPBP/RNBQK2R b KQkq -";
      string str818 = "e8g8{16}";
      char[] chArray818 = new char[1]{ ' ' };
      foreach (string move in str818.Split(chArray818))
        openingMove818.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove818);
      OpeningMove openingMove819 = new OpeningMove();
      openingMove819.StartingFEN = "rnbqkb1r/pppppppp/5n2/8/2P5/5N2/PP1PPPPP/RNBQKB1R b KQkq -";
      string str819 = "g7g6{5} e7e6{10}";
      char[] chArray819 = new char[1]{ ' ' };
      foreach (string move in str819.Split(chArray819))
        openingMove819.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove819);
      OpeningMove openingMove820 = new OpeningMove();
      openingMove820.StartingFEN = "rn1qkb1r/1p3ppp/p2pbn2/4p3/4P3/1NN1B3/PPP2PPP/R2QKB1R w KQkq -";
      string str820 = "f2f3{52} d1d2{25}";
      char[] chArray820 = new char[1]{ ' ' };
      foreach (string move in str820.Split(chArray820))
        openingMove820.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove820);
      OpeningMove openingMove821 = new OpeningMove();
      openingMove821.StartingFEN = "r1b1kbnr/2qp1ppp/p1n1p3/1p6/3NP3/2NBB3/PPP2PPP/R2QK2R w KQkq b6";
      string str821 = "e1g1{5} d4c6{5}";
      char[] chArray821 = new char[1]{ ' ' };
      foreach (string move in str821.Split(chArray821))
        openingMove821.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove821);
      OpeningMove openingMove822 = new OpeningMove();
      openingMove822.StartingFEN = "rn1qk2r/pbpp1ppp/1p2pn2/6B1/1bPP4/2N1PN2/PP3PPP/R2QKB1R b KQkq -";
      string str822 = "h7h6{5}";
      char[] chArray822 = new char[1]{ ' ' };
      foreach (string move in str822.Split(chArray822))
        openingMove822.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove822);
      OpeningMove openingMove823 = new OpeningMove();
      openingMove823.StartingFEN = "rnbqkb1r/p1pp1ppp/1p2pn2/8/2P5/5NP1/PP1PPP1P/RNBQKB1R w KQkq -";
      string str823 = "f1g2{10}";
      char[] chArray823 = new char[1]{ ' ' };
      foreach (string move in str823.Split(chArray823))
        openingMove823.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove823);
      OpeningMove openingMove824 = new OpeningMove();
      openingMove824.StartingFEN = "rnbqkb1r/ppp1pp1p/3p1np1/8/2P1P3/2N5/PP1P1PPP/R1BQKBNR w KQkq -";
      string str824 = "d2d4{10}";
      char[] chArray824 = new char[1]{ ' ' };
      foreach (string move in str824.Split(chArray824))
        openingMove824.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove824);
      OpeningMove openingMove825 = new OpeningMove();
      openingMove825.StartingFEN = "r1bqkb1r/pp3ppp/1np1pn2/6N1/3P4/3B4/PPP1QPPP/R1B1K1NR b KQkq -";
      string str825 = "h7h6{5}";
      char[] chArray825 = new char[1]{ ' ' };
      foreach (string move in str825.Split(chArray825))
        openingMove825.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove825);
      OpeningMove openingMove826 = new OpeningMove();
      openingMove826.StartingFEN = "rn1qkbnr/pp3ppp/4p3/2ppPb2/3P4/5N2/PPP1BPPP/RNBQK2R w KQkq -";
      string str826 = "c1e3{15} e1g1{5}";
      char[] chArray826 = new char[1]{ ' ' };
      foreach (string move in str826.Split(chArray826))
        openingMove826.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove826);
      OpeningMove openingMove827 = new OpeningMove();
      openingMove827.StartingFEN = "rnbqkb1r/pp1ppp1p/2p2np1/8/2PP4/6P1/PP2PPBP/RNBQK1NR b KQkq -";
      string str827 = "d7d5{5}";
      char[] chArray827 = new char[1]{ ' ' };
      foreach (string move in str827.Split(chArray827))
        openingMove827.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove827);
      OpeningMove openingMove828 = new OpeningMove();
      openingMove828.StartingFEN = "rn1qkbnr/pp3ppp/4p3/3pPb2/3p4/4BN2/PPP1BPPP/RN1QK2R w KQkq -";
      string str828 = "f3d4{5}";
      char[] chArray828 = new char[1]{ ' ' };
      foreach (string move in str828.Split(chArray828))
        openingMove828.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove828);
      OpeningMove openingMove829 = new OpeningMove();
      openingMove829.StartingFEN = "rnbqkb1r/3ppppp/p4n2/1PpP4/8/8/PP2PPPP/RNBQKBNR w KQkq -";
      string str829 = "b5a6{5}";
      char[] chArray829 = new char[1]{ ' ' };
      foreach (string move in str829.Split(chArray829))
        openingMove829.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove829);
      OpeningMove openingMove830 = new OpeningMove();
      openingMove830.StartingFEN = "rn1qkb1r/pbpp1ppp/1p2pn2/8/2PP4/2N1PN2/PP3PPP/R1BQKB1R b KQkq -";
      string str830 = "d7d5{5}";
      char[] chArray830 = new char[1]{ ' ' };
      foreach (string move in str830.Split(chArray830))
        openingMove830.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove830);
      OpeningMove openingMove831 = new OpeningMove();
      openingMove831.StartingFEN = "rnbqkb1r/pppp1ppp/5n2/4p3/2P5/6P1/PP1PPPBP/RNBQK1NR b KQkq -";
      string str831 = "b8c6{10} d7d5{5}";
      char[] chArray831 = new char[1]{ ' ' };
      foreach (string move in str831.Split(chArray831))
        openingMove831.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove831);
      OpeningMove openingMove832 = new OpeningMove();
      openingMove832.StartingFEN = "r1bqk2r/pppnbpp1/4pn1p/3p4/2PP3B/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
      string str832 = "e2e3{5}";
      char[] chArray832 = new char[1]{ ' ' };
      foreach (string move in str832.Split(chArray832))
        openingMove832.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove832);
      OpeningMove openingMove833 = new OpeningMove();
      openingMove833.StartingFEN = "rnbq1rk1/p2p1ppp/1p2pn2/2p3B1/2PP4/P1Q5/1P2PPPP/R3KBNR w KQ c6";
      string str833 = "d4c5{5} e2e3{6}";
      char[] chArray833 = new char[1]{ ' ' };
      foreach (string move in str833.Split(chArray833))
        openingMove833.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove833);
      OpeningMove openingMove834 = new OpeningMove();
      openingMove834.StartingFEN = "r1bqkb1r/ppp1pppp/2n2n2/8/2pPP3/4B3/PP3PPP/RN1QKBNR w KQkq -";
      string str834 = "b1c3{5}";
      char[] chArray834 = new char[1]{ ' ' };
      foreach (string move in str834.Split(chArray834))
        openingMove834.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove834);
      OpeningMove openingMove835 = new OpeningMove();
      openingMove835.StartingFEN = "rnbq1rk1/p2p1ppp/1p2pn2/2P3B1/2P5/P1Q5/1P2PPPP/R3KBNR b KQ -";
      string str835 = "b6c5{5}";
      char[] chArray835 = new char[1]{ ' ' };
      foreach (string move in str835.Split(chArray835))
        openingMove835.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove835);
      OpeningMove openingMove836 = new OpeningMove();
      openingMove836.StartingFEN = "rnbqkb1r/p4pp1/2p1pn1p/1p2P1B1/2pP4/2N2N2/PP3PPP/R2QKB1R w KQkq -";
      string str836 = "g5h4{10}";
      char[] chArray836 = new char[1]{ ' ' };
      foreach (string move in str836.Split(chArray836))
        openingMove836.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove836);
      OpeningMove openingMove837 = new OpeningMove();
      openingMove837.StartingFEN = "r1b1kb1r/pp1n1ppp/2p1pn2/q2p2B1/2PP4/2N1PN2/PP3PPP/R2QKB1R w KQkq -";
      string str837 = "c4d5{5}";
      char[] chArray837 = new char[1]{ ' ' };
      foreach (string move in str837.Split(chArray837))
        openingMove837.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove837);
      OpeningMove openingMove838 = new OpeningMove();
      openingMove838.StartingFEN = "r1bqkb1r/1ppp1ppp/p1n5/4p3/B2Pn3/5N2/PPP2PPP/RNBQ1RK1 b kq d3";
      string str838 = "b7b5{30}";
      char[] chArray838 = new char[1]{ ' ' };
      foreach (string move in str838.Split(chArray838))
        openingMove838.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove838);
      OpeningMove openingMove839 = new OpeningMove();
      openingMove839.StartingFEN = "r2qrbk1/1bp2pp1/p2p1n1p/1p6/Pn1PP3/5N1P/1PBN1PP1/R1BQR1K1 w - -";
      string str839 = "c2b1{10}";
      char[] chArray839 = new char[1]{ ' ' };
      foreach (string move in str839.Split(chArray839))
        openingMove839.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove839);
      OpeningMove openingMove840 = new OpeningMove();
      openingMove840.StartingFEN = "r1bqkb1r/2pp1ppp/p1n5/1p2p3/3Pn3/1B3N2/PPP2PPP/RNBQ1RK1 b kq -";
      string str840 = "d7d5{25}";
      char[] chArray840 = new char[1]{ ' ' };
      foreach (string move in str840.Split(chArray840))
        openingMove840.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove840);
      OpeningMove openingMove841 = new OpeningMove();
      openingMove841.StartingFEN = "r2qrbk1/1bp2pp1/p2p1n1p/1p6/Pn1PP3/5N1P/1P1N1PP1/RBBQR1K1 b - -";
      string str841 = "c7c5{5}";
      char[] chArray841 = new char[1]{ ' ' };
      foreach (string move in str841.Split(chArray841))
        openingMove841.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove841);
      OpeningMove openingMove842 = new OpeningMove();
      openingMove842.StartingFEN = "r1bqr1k1/2p1bppp/p1np1n2/1p2p3/4P3/1BP2N1P/PP1P1PP1/RNBQR1K1 w - -";
      string str842 = "d2d4{10}";
      char[] chArray842 = new char[1]{ ' ' };
      foreach (string move in str842.Split(chArray842))
        openingMove842.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove842);
      OpeningMove openingMove843 = new OpeningMove();
      openingMove843.StartingFEN = "rnbq1rk1/pp2ppbp/6p1/2p5/2BPP3/2P5/P3NPPP/R1BQK2R w KQ -";
      string str843 = "c1e3{5}";
      char[] chArray843 = new char[1]{ ' ' };
      foreach (string move in str843.Split(chArray843))
        openingMove843.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove843);
      OpeningMove openingMove844 = new OpeningMove();
      openingMove844.StartingFEN = "rnbqk2r/1p2bppp/p2ppn2/8/3NP3/2N1B3/PPP1BPPP/R2QK2R w KQkq -";
      string str844 = "f2f4{5}";
      char[] chArray844 = new char[1]{ ' ' };
      foreach (string move in str844.Split(chArray844))
        openingMove844.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove844);
      OpeningMove openingMove845 = new OpeningMove();
      openingMove845.StartingFEN = "r1bq1rk1/2p1bppp/p7/1p1nn3/8/1BP5/PP1P1PPP/RNBQR1K1 w - -";
      string str845 = "e1e5{25}";
      char[] chArray845 = new char[1]{ ' ' };
      foreach (string move in str845.Split(chArray845))
        openingMove845.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove845);
      OpeningMove openingMove846 = new OpeningMove();
      openingMove846.StartingFEN = "rnbqkbnr/pp2pppp/3p4/2p5/2B1P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
      string str846 = "g8f6{6}";
      char[] chArray846 = new char[1]{ ' ' };
      foreach (string move in str846.Split(chArray846))
        openingMove846.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove846);
      OpeningMove openingMove847 = new OpeningMove();
      openingMove847.StartingFEN = "rnbqkbnr/ppp1pppp/8/3p2B1/3P4/8/PPP1PPPP/RN1QKBNR b KQkq -";
      string str847 = "c7c6{5} h7h6{5}";
      char[] chArray847 = new char[1]{ ' ' };
      foreach (string move in str847.Split(chArray847))
        openingMove847.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove847);
      OpeningMove openingMove848 = new OpeningMove();
      openingMove848.StartingFEN = "rnbqkb1r/ppp1pppp/3p1n2/8/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
      string str848 = "g2g3{6}";
      char[] chArray848 = new char[1]{ ' ' };
      foreach (string move in str848.Split(chArray848))
        openingMove848.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove848);
      OpeningMove openingMove849 = new OpeningMove();
      openingMove849.StartingFEN = "r1bqkbnr/pp1ppppp/2n5/2p5/2P5/2N2N2/PP1PPPPP/R1BQKB1R b KQkq -";
      string str849 = "g8f6{10} e7e5{6} c6d4{5}";
      char[] chArray849 = new char[1]{ ' ' };
      foreach (string move in str849.Split(chArray849))
        openingMove849.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove849);
      OpeningMove openingMove850 = new OpeningMove();
      openingMove850.StartingFEN = "rnbqkb1r/ppp1pp1p/5np1/3P4/8/2N2N2/PP1PPPPP/R1BQKB1R b KQkq -";
      string str850 = "f6d5{10}";
      char[] chArray850 = new char[1]{ ' ' };
      foreach (string move in str850.Split(chArray850))
        openingMove850.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove850);
      OpeningMove openingMove851 = new OpeningMove();
      openingMove851.StartingFEN = "r1bqkbnr/ppp1pppp/2n5/3p4/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
      string str851 = "b1c3{10} c4d5{11} g1f3{5}";
      char[] chArray851 = new char[1]{ ' ' };
      foreach (string move in str851.Split(chArray851))
        openingMove851.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove851);
      OpeningMove openingMove852 = new OpeningMove();
      openingMove852.StartingFEN = "rnbqkbnr/pp1ppppp/8/2p5/2P5/2N5/PP1PPPPP/R1BQKBNR b KQkq -";
      string str852 = "g7g6{5}";
      char[] chArray852 = new char[1]{ ' ' };
      foreach (string move in str852.Split(chArray852))
        openingMove852.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove852);
      OpeningMove openingMove853 = new OpeningMove();
      openingMove853.StartingFEN = "r1bqk2r/ppppbppp/2n2n2/4p3/2B1P3/3P1N2/PPP2PPP/RNBQK2R w KQkq -";
      string str853 = "e1g1{5}";
      char[] chArray853 = new char[1]{ ' ' };
      foreach (string move in str853.Split(chArray853))
        openingMove853.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove853);
      OpeningMove openingMove854 = new OpeningMove();
      openingMove854.StartingFEN = "r1bqkb1r/2p2ppp/p1n5/1p1pP3/4n3/1B3N2/PPP2PPP/RNBQ1RK1 b kq -";
      string str854 = "c8e6{20}";
      char[] chArray854 = new char[1]{ ' ' };
      foreach (string move in str854.Split(chArray854))
        openingMove854.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove854);
      OpeningMove openingMove855 = new OpeningMove();
      openingMove855.StartingFEN = "rnbqkb1r/ppp1pppp/5n2/8/2pP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
      string str855 = "b1c3{15} e2e3{20}";
      char[] chArray855 = new char[1]{ ' ' };
      foreach (string move in str855.Split(chArray855))
        openingMove855.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove855);
      OpeningMove openingMove856 = new OpeningMove();
      openingMove856.StartingFEN = "rnbqkb1r/pppp1ppp/5n2/4p3/2B1P3/8/PPPP1PPP/RNBQK1NR w KQkq -";
      string str856 = "d2d3{10}";
      char[] chArray856 = new char[1]{ ' ' };
      foreach (string move in str856.Split(chArray856))
        openingMove856.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove856);
      OpeningMove openingMove857 = new OpeningMove();
      openingMove857.StartingFEN = "r1bqk2r/pp1p1ppp/2n1pn2/2p5/1bPP4/2NBP3/PP2NPPP/R1BQK2R b KQkq -";
      string str857 = "c5d4{10}";
      char[] chArray857 = new char[1]{ ' ' };
      foreach (string move in str857.Split(chArray857))
        openingMove857.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove857);
      OpeningMove openingMove858 = new OpeningMove();
      openingMove858.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/3p4/4P3/3P4/PPP2PPP/RNBQKBNR w KQkq d6";
      string str858 = "b1d2{10} d1e2{10}";
      char[] chArray858 = new char[1]{ ' ' };
      foreach (string move in str858.Split(chArray858))
        openingMove858.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove858);
      OpeningMove openingMove859 = new OpeningMove();
      openingMove859.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/8/3NP3/2N5/PPP1BPPP/R1BQ1RK1 b kq -";
      string str859 = "f8e7{41} b8c6{5}";
      char[] chArray859 = new char[1]{ ' ' };
      foreach (string move in str859.Split(chArray859))
        openingMove859.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove859);
      OpeningMove openingMove860 = new OpeningMove();
      openingMove860.StartingFEN = "rnbqk2r/1p2bppp/p2ppn2/8/P2NP3/2N5/1PP1BPPP/R1BQ1RK1 b kq a3";
      string str860 = "b8c6{21}";
      char[] chArray860 = new char[1]{ ' ' };
      foreach (string move in str860.Split(chArray860))
        openingMove860.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove860);
      OpeningMove openingMove861 = new OpeningMove();
      openingMove861.StartingFEN = "r1bqk2r/1p2bppp/p1nppn2/8/P2NP3/2N5/1PP1BPPP/R1BQ1RK1 w kq -";
      string str861 = "c1e3{15}";
      char[] chArray861 = new char[1]{ ' ' };
      foreach (string move in str861.Split(chArray861))
        openingMove861.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove861);
      OpeningMove openingMove862 = new OpeningMove();
      openingMove862.StartingFEN = "r2qkb1r/2p2ppp/p1n1b3/1pnpP3/8/1B3N2/PPPN1PPP/R1BQ1RK1 w kq -";
      string str862 = "c2c3{36}";
      char[] chArray862 = new char[1]{ ' ' };
      foreach (string move in str862.Split(chArray862))
        openingMove862.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove862);
      OpeningMove openingMove863 = new OpeningMove();
      openingMove863.StartingFEN = "rnbqk2r/pp2ppbp/3p1np1/8/3NP3/2N1B3/PPPQ1PPP/R3KB1R b KQkq -";
      string str863 = "b8c6{5}";
      char[] chArray863 = new char[1]{ ' ' };
      foreach (string move in str863.Split(chArray863))
        openingMove863.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove863);
      OpeningMove openingMove864 = new OpeningMove();
      openingMove864.StartingFEN = "rnb1kbnr/ppp1pppp/8/q7/8/2N5/PPPP1PPP/R1BQKBNR w KQkq -";
      string str864 = "d2d4{5}";
      char[] chArray864 = new char[1]{ ' ' };
      foreach (string move in str864.Split(chArray864))
        openingMove864.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove864);
      OpeningMove openingMove865 = new OpeningMove();
      openingMove865.StartingFEN = "rnbqkb1r/ppppp2p/5np1/5p2/3P4/6P1/PPP1PPBP/RNBQK1NR w KQkq -";
      string str865 = "c2c3{5}";
      char[] chArray865 = new char[1]{ ' ' };
      foreach (string move in str865.Split(chArray865))
        openingMove865.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove865);
      OpeningMove openingMove866 = new OpeningMove();
      openingMove866.StartingFEN = "r1bqkbnr/pppppppp/2n5/8/8/5N2/PPPPPPPP/RNBQKB1R w KQkq -";
      string str866 = "e2e4{5}";
      char[] chArray866 = new char[1]{ ' ' };
      foreach (string move in str866.Split(chArray866))
        openingMove866.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove866);
      OpeningMove openingMove867 = new OpeningMove();
      openingMove867.StartingFEN = "r1bqkbnr/pp3ppp/2np4/1N2p3/4P3/8/PPP2PPP/RNBQKB1R w KQkq -";
      string str867 = "c2c4{5} b1c3{5}";
      char[] chArray867 = new char[1]{ ' ' };
      foreach (string move in str867.Split(chArray867))
        openingMove867.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove867);
      OpeningMove openingMove868 = new OpeningMove();
      openingMove868.StartingFEN = "r1b1kb1r/pp2pppp/1qnp1n2/8/2BNP3/2N5/PPP2PPP/R1BQK2R w KQkq -";
      string str868 = "d4b5{15} d4c6{10}";
      char[] chArray868 = new char[1]{ ' ' };
      foreach (string move in str868.Split(chArray868))
        openingMove868.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove868);
      OpeningMove openingMove869 = new OpeningMove();
      openingMove869.StartingFEN = "r2qkb1r/pp1npppp/2p2n2/4Nb2/P1pP4/2N5/1P2PPPP/R1BQKB1R w KQkq -";
      string str869 = "e5c4{11}";
      char[] chArray869 = new char[1]{ ' ' };
      foreach (string move in str869.Split(chArray869))
        openingMove869.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove869);
      OpeningMove openingMove870 = new OpeningMove();
      openingMove870.StartingFEN = "rnbqkb1r/ppp1pp1p/6p1/3n4/8/2N2N2/PP1PPPPP/R1BQKB1R w KQkq -";
      string str870 = "e2e4{5} d1a4{10}";
      char[] chArray870 = new char[1]{ ' ' };
      foreach (string move in str870.Split(chArray870))
        openingMove870.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove870);
      OpeningMove openingMove871 = new OpeningMove();
      openingMove871.StartingFEN = "rnb1kb1r/pp3pp1/2p1pq1p/3p4/2PPP3/2N2N2/PP3PPP/R2QKB1R b KQkq e3";
      string str871 = "d5e4{5}";
      char[] chArray871 = new char[1]{ ' ' };
      foreach (string move in str871.Split(chArray871))
        openingMove871.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove871);
      OpeningMove openingMove872 = new OpeningMove();
      openingMove872.StartingFEN = "r1bqkbnr/pp1ppp1p/2n3p1/1Bp5/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str872 = "e1g1{10} b5c6{15}";
      char[] chArray872 = new char[1]{ ' ' };
      foreach (string move in str872.Split(chArray872))
        openingMove872.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove872);
      OpeningMove openingMove873 = new OpeningMove();
      openingMove873.StartingFEN = "rnbq1rk1/1pp2pbp/3p1np1/p2Pp1B1/2P1P3/2N2N2/PP2BPPP/R2QK2R b KQ -";
      string str873 = "h7h6{10}";
      char[] chArray873 = new char[1]{ ' ' };
      foreach (string move in str873.Split(chArray873))
        openingMove873.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove873);
      OpeningMove openingMove874 = new OpeningMove();
      openingMove874.StartingFEN = "rnbq1rk1/1pp2pb1/3p1npp/p2Pp3/2P1P2B/2N2N2/PP2BPPP/R2QK2R b KQ -";
      string str874 = "b8a6{5}";
      char[] chArray874 = new char[1]{ ' ' };
      foreach (string move in str874.Split(chArray874))
        openingMove874.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove874);
      OpeningMove openingMove875 = new OpeningMove();
      openingMove875.StartingFEN = "rnbqkb1r/1p2pp1p/p2p1np1/8/3NP3/2N5/PPP1BPPP/R1BQK2R w KQkq -";
      string str875 = "g2g4{5}";
      char[] chArray875 = new char[1]{ ' ' };
      foreach (string move in str875.Split(chArray875))
        openingMove875.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove875);
      OpeningMove openingMove876 = new OpeningMove();
      openingMove876.StartingFEN = "r2q1rk1/1bppbppp/p1n2n2/1p2p3/P3P3/1B3N2/1PPP1PPP/RNBQR1K1 w - -";
      string str876 = "d2d3{11}";
      char[] chArray876 = new char[1]{ ' ' };
      foreach (string move in str876.Split(chArray876))
        openingMove876.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove876);
      OpeningMove openingMove877 = new OpeningMove();
      openingMove877.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQK2R b KQkq f3";
      string str877 = "f8e7{15}";
      char[] chArray877 = new char[1]{ ' ' };
      foreach (string move in str877.Split(chArray877))
        openingMove877.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove877);
      OpeningMove openingMove878 = new OpeningMove();
      openingMove878.StartingFEN = "rnbqk2r/ppppppbp/5np1/8/2PP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
      string str878 = "e8g8{25} d7d5{15}";
      char[] chArray878 = new char[1]{ ' ' };
      foreach (string move in str878.Split(chArray878))
        openingMove878.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove878);
      OpeningMove openingMove879 = new OpeningMove();
      openingMove879.StartingFEN = "r1bqkb1r/pp2pppp/2n2n2/3p4/2PP4/2N5/PP3PPP/R1BQKBNR w KQkq -";
      string str879 = "c1g5{6}";
      char[] chArray879 = new char[1]{ ' ' };
      foreach (string move in str879.Split(chArray879))
        openingMove879.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove879);
      OpeningMove openingMove880 = new OpeningMove();
      openingMove880.StartingFEN = "r1bqkbnr/pp1ppppp/2n5/2p5/4P3/2N5/PPPP1PPP/R1BQKBNR w KQkq -";
      string str880 = "g1e2{16} g2g3{10} g1f3{10} f1b5{5}";
      char[] chArray880 = new char[1]{ ' ' };
      foreach (string move in str880.Split(chArray880))
        openingMove880.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove880);
      OpeningMove openingMove881 = new OpeningMove();
      openingMove881.StartingFEN = "rn1qkb1r/pb3ppp/1p1ppn2/2p5/2P5/2N2NP1/PP1PPPBP/R1BQ1RK1 w kq -";
      string str881 = "b2b3{5}";
      char[] chArray881 = new char[1]{ ' ' };
      foreach (string move in str881.Split(chArray881))
        openingMove881.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove881);
      OpeningMove openingMove882 = new OpeningMove();
      openingMove882.StartingFEN = "r1bq1rk1/pp1n1pbp/2pp1np1/3Pp3/2P1P3/2N1BP2/PP1QN1PP/R3KB1R b KQ -";
      string str882 = "c6d5{6}";
      char[] chArray882 = new char[1]{ ' ' };
      foreach (string move in str882.Split(chArray882))
        openingMove882.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove882);
      OpeningMove openingMove883 = new OpeningMove();
      openingMove883.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/8/2BNP3/2N5/PPP2PPP/R1BQK2R w KQkq -";
      string str883 = "c4b3{10} e1g1{5}";
      char[] chArray883 = new char[1]{ ' ' };
      foreach (string move in str883.Split(chArray883))
        openingMove883.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove883);
      OpeningMove openingMove884 = new OpeningMove();
      openingMove884.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/8/2pP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
      string str884 = "e2e3{41} e2e4{5}";
      char[] chArray884 = new char[1]{ ' ' };
      foreach (string move in str884.Split(chArray884))
        openingMove884.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove884);
      OpeningMove openingMove885 = new OpeningMove();
      openingMove885.StartingFEN = "r2qkbnr/pp1n1ppp/2p1p3/3pPb2/3P4/5N2/PPP1BPPP/RNBQK2R w KQkq -";
      string str885 = "e1g1{5}";
      char[] chArray885 = new char[1]{ ' ' };
      foreach (string move in str885.Split(chArray885))
        openingMove885.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove885);
      OpeningMove openingMove886 = new OpeningMove();
      openingMove886.StartingFEN = "r1bqkb1r/pp1n1ppp/2n1p3/2ppP3/3P1P2/2N2N2/PPP3PP/R1BQKB1R w KQkq -";
      string str886 = "c1e3{11}";
      char[] chArray886 = new char[1]{ ' ' };
      foreach (string move in str886.Split(chArray886))
        openingMove886.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove886);
      OpeningMove openingMove887 = new OpeningMove();
      openingMove887.StartingFEN = "r1b1kbnr/2qp1ppp/p1n1p3/1p6/3NP3/2N5/PPP1BPPP/R1BQ1RK1 w kq b6";
      string str887 = "d4c6{5}";
      char[] chArray887 = new char[1]{ ' ' };
      foreach (string move in str887.Split(chArray887))
        openingMove887.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove887);
      OpeningMove openingMove888 = new OpeningMove();
      openingMove888.StartingFEN = "rnbqkbnr/pp2pppp/3p4/2p5/4P3/2N5/PPPP1PPP/R1BQKBNR w KQkq -";
      string str888 = "g1f3{5} f2f4{5} g2g3{5}";
      char[] chArray888 = new char[1]{ ' ' };
      foreach (string move in str888.Split(chArray888))
        openingMove888.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove888);
      OpeningMove openingMove889 = new OpeningMove();
      openingMove889.StartingFEN = "rnbqkbnr/1p1p1ppp/p3p3/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R w KQkq -";
      string str889 = "d2d4{10}";
      char[] chArray889 = new char[1]{ ' ' };
      foreach (string move in str889.Split(chArray889))
        openingMove889.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove889);
      OpeningMove openingMove890 = new OpeningMove();
      openingMove890.StartingFEN = "rnbqk1nr/ppppppbp/6p1/8/3PP3/2N5/PPP2PPP/R1BQKBNR b KQkq -";
      string str890 = "c7c6{5}";
      char[] chArray890 = new char[1]{ ' ' };
      foreach (string move in str890.Split(chArray890))
        openingMove890.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove890);
      OpeningMove openingMove891 = new OpeningMove();
      openingMove891.StartingFEN = "r1b1kb1r/pp2pppp/1qnp1n2/8/2B1P3/1NN5/PPP2PPP/R1BQK2R b KQkq -";
      string str891 = "e7e6{5}";
      char[] chArray891 = new char[1]{ ' ' };
      foreach (string move in str891.Split(chArray891))
        openingMove891.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove891);
      OpeningMove openingMove892 = new OpeningMove();
      openingMove892.StartingFEN = "rn1qkbnr/pp3ppp/4p3/2ppPb2/3P4/4BN2/PPP1BPPP/RN1QK2R b KQkq -";
      string str892 = "g8e7{5}";
      char[] chArray892 = new char[1]{ ' ' };
      foreach (string move in str892.Split(chArray892))
        openingMove892.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove892);
      OpeningMove openingMove893 = new OpeningMove();
      openingMove893.StartingFEN = "rnbqkb1r/pp3ppp/2p1pn2/6B1/2pPP3/2N2N2/PP3PPP/R2QKB1R b KQkq e3";
      string str893 = "b7b5{10}";
      char[] chArray893 = new char[1]{ ' ' };
      foreach (string move in str893.Split(chArray893))
        openingMove893.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove893);
      OpeningMove openingMove894 = new OpeningMove();
      openingMove894.StartingFEN = "r1bqkb1r/pp3ppp/2nppn2/8/2BNP3/2N5/PPP2PPP/R1BQK2R w KQkq -";
      string str894 = "c1e3{5}";
      char[] chArray894 = new char[1]{ ' ' };
      foreach (string move in str894.Split(chArray894))
        openingMove894.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove894);
      OpeningMove openingMove895 = new OpeningMove();
      openingMove895.StartingFEN = "rn1qk2r/pp3ppp/2p1p3/4N3/PbpPn3/2N5/1P4PP/R1BQKB1R w KQkq -";
      string str895 = "c1d2{15}";
      char[] chArray895 = new char[1]{ ' ' };
      foreach (string move in str895.Split(chArray895))
        openingMove895.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove895);
      OpeningMove openingMove896 = new OpeningMove();
      openingMove896.StartingFEN = "rnbqk2r/1p2bppp/p2p1n2/4p3/4P3/2N1BN2/PPP2PPP/R2QKB1R w KQkq -";
      string str896 = "f1c4{5}";
      char[] chArray896 = new char[1]{ ' ' };
      foreach (string move in str896.Split(chArray896))
        openingMove896.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove896);
      OpeningMove openingMove897 = new OpeningMove();
      openingMove897.StartingFEN = "rn1qrbk1/1bp2ppp/p2p1n2/1p1Pp3/4P3/1BP2N1P/PP1N1PP1/R1BQR1K1 w - -";
      string str897 = "d2f1{5}";
      char[] chArray897 = new char[1]{ ' ' };
      foreach (string move in str897.Split(chArray897))
        openingMove897.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove897);
      OpeningMove openingMove898 = new OpeningMove();
      openingMove898.StartingFEN = "rnbqk1nr/pp1pppbp/2p3p1/8/3PP3/2N5/PPP2PPP/R1BQKBNR w KQkq -";
      string str898 = "f1c4{5}";
      char[] chArray898 = new char[1]{ ' ' };
      foreach (string move in str898.Split(chArray898))
        openingMove898.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove898);
      OpeningMove openingMove899 = new OpeningMove();
      openingMove899.StartingFEN = "r1bqkb1r/1p3pp1/p1nppn1p/8/3NP3/2N1B3/PPPQ1PPP/2KR1B1R b kq -";
      string str899 = "f8e7{10}";
      char[] chArray899 = new char[1]{ ' ' };
      foreach (string move in str899.Split(chArray899))
        openingMove899.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove899);
      OpeningMove openingMove900 = new OpeningMove();
      openingMove900.StartingFEN = "r1bqkb1r/pp1n1ppp/2p1pn2/6N1/3P4/3B4/PPP2PPP/R1BQK1NR w KQkq -";
      string str900 = "g1f3{36}";
      char[] chArray900 = new char[1]{ ' ' };
      foreach (string move in str900.Split(chArray900))
        openingMove900.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove900);
      OpeningMove openingMove901 = new OpeningMove();
      openingMove901.StartingFEN = "rnbqkb1r/p4ppp/2p1pn2/1p2P1B1/2pP4/2N2N2/PP3PPP/R2QKB1R b KQkq -";
      string str901 = "h7h6{5}";
      char[] chArray901 = new char[1]{ ' ' };
      foreach (string move in str901.Split(chArray901))
        openingMove901.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove901);
      OpeningMove openingMove902 = new OpeningMove();
      openingMove902.StartingFEN = "rnbqkb1r/pp3ppp/3p1n2/2pP4/8/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
      string str902 = "g7g6{25}";
      char[] chArray902 = new char[1]{ ' ' };
      foreach (string move in str902.Split(chArray902))
        openingMove902.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove902);
      OpeningMove openingMove903 = new OpeningMove();
      openingMove903.StartingFEN = "r1bq1rk1/2ppbppp/p1n2n2/1p2p3/4P3/1B3N1P/PPPP1PP1/RNBQR1K1 b - -";
      string str903 = "c8b7{25}";
      char[] chArray903 = new char[1]{ ' ' };
      foreach (string move in str903.Split(chArray903))
        openingMove903.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove903);
      OpeningMove openingMove904 = new OpeningMove();
      openingMove904.StartingFEN = "r1bqkb1r/p2n1ppp/2p1pn2/1p6/3P4/2NBPN2/PP3PPP/R1BQK2R b KQkq -";
      string str904 = "c8b7{10} a7a6{5}";
      char[] chArray904 = new char[1]{ ' ' };
      foreach (string move in str904.Split(chArray904))
        openingMove904.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove904);
      OpeningMove openingMove905 = new OpeningMove();
      openingMove905.StartingFEN = "rn1qkb1r/pp3ppp/4pn2/2p1Nb2/P1pP4/2N2P2/1P2P1PP/R1BQKB1R w KQkq -";
      string str905 = "e2e4{11}";
      char[] chArray905 = new char[1]{ ' ' };
      foreach (string move in str905.Split(chArray905))
        openingMove905.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove905);
      OpeningMove openingMove906 = new OpeningMove();
      openingMove906.StartingFEN = "r1bqk2r/1p2bppp/p1nppn2/8/P2NP3/2N1B3/1PP1BPPP/R2Q1RK1 b kq -";
      string str906 = "e8g8{16}";
      char[] chArray906 = new char[1]{ ' ' };
      foreach (string move in str906.Split(chArray906))
        openingMove906.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove906);
      OpeningMove openingMove907 = new OpeningMove();
      openingMove907.StartingFEN = "rnbqk2r/ppp1ppbp/6p1/3n4/3P4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str907 = "e2e4{15}";
      char[] chArray907 = new char[1]{ ' ' };
      foreach (string move in str907.Split(chArray907))
        openingMove907.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove907);
      OpeningMove openingMove908 = new OpeningMove();
      openingMove908.StartingFEN = "r1b1kb1r/1p3ppp/pqNppn2/8/4PP2/P1N2Q2/1PP3PP/R1B1KB1R b KQkq -";
      string str908 = "b7c6{6}";
      char[] chArray908 = new char[1]{ ' ' };
      foreach (string move in str908.Split(chArray908))
        openingMove908.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove908);
      OpeningMove openingMove909 = new OpeningMove();
      openingMove909.StartingFEN = "rnbqkbnr/pp2pppp/3p4/8/3QP3/5N2/PPP2PPP/RNB1KB1R b KQkq -";
      string str909 = "c8d7{5} b8c6{6}";
      char[] chArray909 = new char[1]{ ' ' };
      foreach (string move in str909.Split(chArray909))
        openingMove909.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove909);
      OpeningMove openingMove910 = new OpeningMove();
      openingMove910.StartingFEN = "rnb2rk1/1pq1bppp/p2p1n2/4p3/4P3/1NN5/PPP1BPPP/R1BQ1R1K w - -";
      string str910 = "f2f4{5}";
      char[] chArray910 = new char[1]{ ' ' };
      foreach (string move in str910.Split(chArray910))
        openingMove910.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove910);
      OpeningMove openingMove911 = new OpeningMove();
      openingMove911.StartingFEN = "r2q1rk1/1bppbppp/p1n2n2/1p2p3/4P3/1B3N1P/PPPP1PP1/RNBQR1K1 w - -";
      string str911 = "d2d3{36}";
      char[] chArray911 = new char[1]{ ' ' };
      foreach (string move in str911.Split(chArray911))
        openingMove911.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove911);
      OpeningMove openingMove912 = new OpeningMove();
      openingMove912.StartingFEN = "r1bqk2r/pp2ppbp/2np1np1/8/3NP3/2N1BP2/PPP3PP/R2QKB1R w KQkq -";
      string str912 = "d1d2{15}";
      char[] chArray912 = new char[1]{ ' ' };
      foreach (string move in str912.Split(chArray912))
        openingMove912.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove912);
      OpeningMove openingMove913 = new OpeningMove();
      openingMove913.StartingFEN = "r2qkb1r/2p2ppp/p1n1b3/1p1pP3/4n3/1B3N2/PPPN1PPP/R1BQ1RK1 b kq -";
      string str913 = "e4c5{10}";
      char[] chArray913 = new char[1]{ ' ' };
      foreach (string move in str913.Split(chArray913))
        openingMove913.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove913);
      OpeningMove openingMove914 = new OpeningMove();
      openingMove914.StartingFEN = "rn1qkb1r/pp3ppp/4pn2/4Nb2/P1ppP3/2N2P2/1P4PP/R1BQKB1R w KQkq -";
      string str914 = "e4f5{5}";
      char[] chArray914 = new char[1]{ ' ' };
      foreach (string move in str914.Split(chArray914))
        openingMove914.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove914);
      OpeningMove openingMove915 = new OpeningMove();
      openingMove915.StartingFEN = "r1b1kb1r/pp2pppp/1qnp1n2/1N6/2B1P3/2N5/PPP2PPP/R1BQK2R b KQkq -";
      string str915 = "c8g4{5} a7a6{5}";
      char[] chArray915 = new char[1]{ ' ' };
      foreach (string move in str915.Split(chArray915))
        openingMove915.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove915);
      OpeningMove openingMove916 = new OpeningMove();
      openingMove916.StartingFEN = "r1bqkb1r/pp1n1ppp/2p1pn2/3p4/2PP4/2N1PN2/PPQ2PPP/R1B1KB1R b KQkq -";
      string str916 = "f8d6{46}";
      char[] chArray916 = new char[1]{ ' ' };
      foreach (string move in str916.Split(chArray916))
        openingMove916.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove916);
      OpeningMove openingMove917 = new OpeningMove();
      openingMove917.StartingFEN = "rnbq1rk1/ppp2pbp/3p1np1/8/2PpP3/2N2N2/PP2BPPP/R1BQ1RK1 w - -";
      string str917 = "f3d4{10}";
      char[] chArray917 = new char[1]{ ' ' };
      foreach (string move in str917.Split(chArray917))
        openingMove917.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove917);
      OpeningMove openingMove918 = new OpeningMove();
      openingMove918.StartingFEN = "rnbqkb1r/1pp1pppp/p4n2/8/2pP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str918 = "e2e4{5}";
      char[] chArray918 = new char[1]{ ' ' };
      foreach (string move in str918.Split(chArray918))
        openingMove918.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove918);
      OpeningMove openingMove919 = new OpeningMove();
      openingMove919.StartingFEN = "rnbqkb1r/pp3ppp/4pn2/3p4/2PP4/2N2N2/PP3PPP/R1BQKB1R b KQkq -";
      string str919 = "f8b4{5} f8e7{5}";
      char[] chArray919 = new char[1]{ ' ' };
      foreach (string move in str919.Split(chArray919))
        openingMove919.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove919);
      OpeningMove openingMove920 = new OpeningMove();
      openingMove920.StartingFEN = "rnbq1rk1/ppp1ppbp/3p1np1/8/2PPP3/2N5/PP2BPPP/R1BQK1NR w KQ -";
      string str920 = "c1g5{10}";
      char[] chArray920 = new char[1]{ ' ' };
      foreach (string move in str920.Split(chArray920))
        openingMove920.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove920);
      OpeningMove openingMove921 = new OpeningMove();
      openingMove921.StartingFEN = "r1b1kb1r/p1ppqppp/2p2n2/4P3/8/8/PPP2PPP/RNBQKB1R w KQkq -";
      string str921 = "d1e2{24}";
      char[] chArray921 = new char[1]{ ' ' };
      foreach (string move in str921.Split(chArray921))
        openingMove921.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove921);
      OpeningMove openingMove922 = new OpeningMove();
      openingMove922.StartingFEN = "r1bqkb1r/pppppppp/2n2n2/8/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
      string str922 = "g1f3{6}";
      char[] chArray922 = new char[1]{ ' ' };
      foreach (string move in str922.Split(chArray922))
        openingMove922.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove922);
      OpeningMove openingMove923 = new OpeningMove();
      openingMove923.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/8/P2NP3/2N5/1PP1BPPP/R1BQK2R b KQkq a3";
      string str923 = "b8c6{6}";
      char[] chArray923 = new char[1]{ ' ' };
      foreach (string move in str923.Split(chArray923))
        openingMove923.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove923);
      OpeningMove openingMove924 = new OpeningMove();
      openingMove924.StartingFEN = "rn1qk2r/p1ppbppp/bp2pn2/8/2PP4/1P3NP1/P2BPPBP/RN1QK2R b KQkq -";
      string str924 = "c7c6{40}";
      char[] chArray924 = new char[1]{ ' ' };
      foreach (string move in str924.Split(chArray924))
        openingMove924.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove924);
      OpeningMove openingMove925 = new OpeningMove();
      openingMove925.StartingFEN = "r1bqkb1r/p2n1ppp/2p1pn2/1p6/3P4/2NQ1N2/PP2PPPP/R1B1KB1R w KQkq -";
      string str925 = "a2a3{5}";
      char[] chArray925 = new char[1]{ ' ' };
      foreach (string move in str925.Split(chArray925))
        openingMove925.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove925);
      OpeningMove openingMove926 = new OpeningMove();
      openingMove926.StartingFEN = "rnbq1rk1/1pp1ppbp/p4np1/8/2QPP3/2N2N2/PP3PPP/R1B1KB1R w KQ -";
      string str926 = "e4e5{36} c4b3{5}";
      char[] chArray926 = new char[1]{ ' ' };
      foreach (string move in str926.Split(chArray926))
        openingMove926.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove926);
      OpeningMove openingMove927 = new OpeningMove();
      openingMove927.StartingFEN = "rnbqkbnr/pp1p1ppp/4p3/2p5/4P3/2N5/PPPP1PPP/R1BQKBNR w KQkq -";
      string str927 = "g1f3{15}";
      char[] chArray927 = new char[1]{ ' ' };
      foreach (string move in str927.Split(chArray927))
        openingMove927.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove927);
      OpeningMove openingMove928 = new OpeningMove();
      openingMove928.StartingFEN = "r1b1kb1r/pp1p1ppp/1qn1pn2/8/2PN4/2N3P1/PP2PP1P/R1BQKB1R w KQkq -";
      string str928 = "d4b5{5} d4b3{5}";
      char[] chArray928 = new char[1]{ ' ' };
      foreach (string move in str928.Split(chArray928))
        openingMove928.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove928);
      OpeningMove openingMove929 = new OpeningMove();
      openingMove929.StartingFEN = "rn1qk2r/pbppbppp/1p2pn2/8/2P5/5NP1/PP1PPPBP/RNBQ1RK1 w kq -";
      string str929 = "b1c3{10} f1e1{5} d2d4{5}";
      char[] chArray929 = new char[1]{ ' ' };
      foreach (string move in str929.Split(chArray929))
        openingMove929.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove929);
      OpeningMove openingMove930 = new OpeningMove();
      openingMove930.StartingFEN = "rn1q1rk1/pbp2ppp/1p1ppn2/2P3B1/3P4/P1Q1P3/1P3PPP/R3KBNR b KQ -";
      string str930 = "b8c6{5}";
      char[] chArray930 = new char[1]{ ' ' };
      foreach (string move in str930.Split(chArray930))
        openingMove930.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove930);
      OpeningMove openingMove931 = new OpeningMove();
      openingMove931.StartingFEN = "r2qkb1r/pb1n1ppp/2p1pn2/1p6/3P4/2NBPN2/PP3PPP/R1BQ1RK1 b kq -";
      string str931 = "a7a6{5}";
      char[] chArray931 = new char[1]{ ' ' };
      foreach (string move in str931.Split(chArray931))
        openingMove931.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove931);
      OpeningMove openingMove932 = new OpeningMove();
      openingMove932.StartingFEN = "r1bqkb1r/1p1n1ppp/p2ppn2/8/3NP3/1BN5/PPP2PPP/R1BQK2R w KQkq -";
      string str932 = "f2f4{5}";
      char[] chArray932 = new char[1]{ ' ' };
      foreach (string move in str932.Split(chArray932))
        openingMove932.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove932);
      OpeningMove openingMove933 = new OpeningMove();
      openingMove933.StartingFEN = "r1b1kb1r/1pqp1ppp/p1n1pn2/8/3NP3/2NBB3/PPP2PPP/R2QK2R w KQkq -";
      string str933 = "e1g1{5}";
      char[] chArray933 = new char[1]{ ' ' };
      foreach (string move in str933.Split(chArray933))
        openingMove933.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove933);
      OpeningMove openingMove934 = new OpeningMove();
      openingMove934.StartingFEN = "r1bqkbnr/pp1npppp/2p5/8/3PN3/5N2/PPP2PPP/R1BQKB1R b KQkq -";
      string str934 = "g8f6{10}";
      char[] chArray934 = new char[1]{ ' ' };
      foreach (string move in str934.Split(chArray934))
        openingMove934.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove934);
      OpeningMove openingMove935 = new OpeningMove();
      openingMove935.StartingFEN = "r1bqk2r/1ppp1ppp/p1n2n2/2b1p3/B3P3/5N2/PPPP1PPP/RNBQ1RK1 w kq -";
      string str935 = "f3e5{5} c2c3{40}";
      char[] chArray935 = new char[1]{ ' ' };
      foreach (string move in str935.Split(chArray935))
        openingMove935.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove935);
      OpeningMove openingMove936 = new OpeningMove();
      openingMove936.StartingFEN = "rnbq1rk1/ppppppbp/5np1/8/2PP4/6P1/PP2PPBP/RNBQK1NR w KQ -";
      string str936 = "b1c3{15}";
      char[] chArray936 = new char[1]{ ' ' };
      foreach (string move in str936.Split(chArray936))
        openingMove936.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove936);
      OpeningMove openingMove937 = new OpeningMove();
      openingMove937.StartingFEN = "rnbqkb1r/ppp1pppp/5n2/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq c3";
      string str937 = "e7e6{33} c7c6{30}";
      char[] chArray937 = new char[1]{ ' ' };
      foreach (string move in str937.Split(chArray937))
        openingMove937.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove937);
      OpeningMove openingMove938 = new OpeningMove();
      openingMove938.StartingFEN = "rnbqkb1r/pp3ppp/3p1n2/2pp4/2P5/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str938 = "c4d5{15}";
      char[] chArray938 = new char[1]{ ' ' };
      foreach (string move in str938.Split(chArray938))
        openingMove938.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove938);
      OpeningMove openingMove939 = new OpeningMove();
      openingMove939.StartingFEN = "rnbqk2r/1p2bppp/p2p1n2/4p3/4P3/1NN5/PPP1BPPP/R1BQ1RK1 b kq -";
      string str939 = "e8g8{10} c8e6{6}";
      char[] chArray939 = new char[1]{ ' ' };
      foreach (string move in str939.Split(chArray939))
        openingMove939.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove939);
      OpeningMove openingMove940 = new OpeningMove();
      openingMove940.StartingFEN = "rnbqkb1r/ppp1pppp/3p4/3nP3/3P4/8/PPP2PPP/RNBQKBNR w KQkq -";
      string str940 = "g1f3{12}";
      char[] chArray940 = new char[1]{ ' ' };
      foreach (string move in str940.Split(chArray940))
        openingMove940.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove940);
      OpeningMove openingMove941 = new OpeningMove();
      openingMove941.StartingFEN = "r1bq1rk1/ppp1npbp/3p1np1/3Pp3/1PP1P3/2N2N2/P3BPPP/R1BQ1RK1 b - b3";
      string str941 = "a7a5{10} f6h5{10}";
      char[] chArray941 = new char[1]{ ' ' };
      foreach (string move in str941.Split(chArray941))
        openingMove941.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove941);
      OpeningMove openingMove942 = new OpeningMove();
      openingMove942.StartingFEN = "r1bqkb1r/pp1npppp/2p2n2/6N1/3P4/3B4/PPP2PPP/R1BQK1NR b KQkq -";
      string str942 = "e7e6{30}";
      char[] chArray942 = new char[1]{ ' ' };
      foreach (string move in str942.Split(chArray942))
        openingMove942.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove942);
      OpeningMove openingMove943 = new OpeningMove();
      openingMove943.StartingFEN = "rnbq1rk1/pp3pbp/2pp1np1/4p3/2PPP3/2N1BN2/PP2BPPP/R2QK2R w KQ -";
      string str943 = "d4d5{5}";
      char[] chArray943 = new char[1]{ ' ' };
      foreach (string move in str943.Split(chArray943))
        openingMove943.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove943);
      OpeningMove openingMove944 = new OpeningMove();
      openingMove944.StartingFEN = "rn1qkb1r/pppbpp1p/6p1/3n4/Q7/2N2N2/PP1PPPPP/R1B1KB1R w KQkq -";
      string str944 = "a4h4{5}";
      char[] chArray944 = new char[1]{ ' ' };
      foreach (string move in str944.Split(chArray944))
        openingMove944.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove944);
      OpeningMove openingMove945 = new OpeningMove();
      openingMove945.StartingFEN = "r1bqkb1r/1p3ppp/p1np1n2/1N2p1B1/4P3/2N5/PPP2PPP/R2QKB1R w KQkq -";
      string str945 = "b5a3{66}";
      char[] chArray945 = new char[1]{ ' ' };
      foreach (string move in str945.Split(chArray945))
        openingMove945.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove945);
      OpeningMove openingMove946 = new OpeningMove();
      openingMove946.StartingFEN = "r1bqkb1r/1p1n1ppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQK2R w KQkq -";
      string str946 = "e2f3{5}";
      char[] chArray946 = new char[1]{ ' ' };
      foreach (string move in str946.Split(chArray946))
        openingMove946.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove946);
      OpeningMove openingMove947 = new OpeningMove();
      openingMove947.StartingFEN = "rnbqkb1r/pppp1pp1/4pB1p/8/3PP3/8/PPP2PPP/RN1QKBNR b KQkq -";
      string str947 = "d8f6{10}";
      char[] chArray947 = new char[1]{ ' ' };
      foreach (string move in str947.Split(chArray947))
        openingMove947.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove947);
      OpeningMove openingMove948 = new OpeningMove();
      openingMove948.StartingFEN = "r2qkb1r/2p2ppp/p1n1b3/1pn1P3/3p4/1BP2N2/PP1N1PPP/R1BQ1RK1 w kq -";
      string str948 = "b3e6{5} f3g5{6}";
      char[] chArray948 = new char[1]{ ' ' };
      foreach (string move in str948.Split(chArray948))
        openingMove948.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove948);
      OpeningMove openingMove949 = new OpeningMove();
      openingMove949.StartingFEN = "rnb1qrk1/ppp2pbp/3p1np1/4p3/2PPP3/2N2N2/PP2BPPP/R1BQ1RK1 w - -";
      string str949 = "d4e5{5}";
      char[] chArray949 = new char[1]{ ' ' };
      foreach (string move in str949.Split(chArray949))
        openingMove949.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove949);
      OpeningMove openingMove950 = new OpeningMove();
      openingMove950.StartingFEN = "rnbq1rk1/1p2bppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQ1RK1 w - -";
      string str950 = "g1h1{5} d1e1{5}";
      char[] chArray950 = new char[1]{ ' ' };
      foreach (string move in str950.Split(chArray950))
        openingMove950.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove950);
      OpeningMove openingMove951 = new OpeningMove();
      openingMove951.StartingFEN = "rnbqkbnr/ppp2ppp/8/3p4/3P4/8/PPP2PPP/RNBQKBNR w KQkq -";
      string str951 = "g1f3{5}";
      char[] chArray951 = new char[1]{ ' ' };
      foreach (string move in str951.Split(chArray951))
        openingMove951.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove951);
      OpeningMove openingMove952 = new OpeningMove();
      openingMove952.StartingFEN = "r1b1kb1r/pp1n1pp1/2p1pq1p/3p4/2PP4/2N1PN2/PP3PPP/R2QKB1R w KQkq -";
      string str952 = "f1d3{5} a1c1{5}";
      char[] chArray952 = new char[1]{ ' ' };
      foreach (string move in str952.Split(chArray952))
        openingMove952.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove952);
      OpeningMove openingMove953 = new OpeningMove();
      openingMove953.StartingFEN = "rnbqkbnr/1pp2ppp/p3p3/8/2pP4/4PN2/PP3PPP/RNBQKB1R w KQkq -";
      string str953 = "f1c4{5}";
      char[] chArray953 = new char[1]{ ' ' };
      foreach (string move in str953.Split(chArray953))
        openingMove953.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove953);
      OpeningMove openingMove954 = new OpeningMove();
      openingMove954.StartingFEN = "rnbqk2r/ppp1bpp1/4pn1p/3p4/2PP3B/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
      string str954 = "e8g8{21}";
      char[] chArray954 = new char[1]{ ' ' };
      foreach (string move in str954.Split(chArray954))
        openingMove954.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove954);
      OpeningMove openingMove955 = new OpeningMove();
      openingMove955.StartingFEN = "rnbq1rk1/ppppppbp/5np1/8/2PPP3/2N2N2/PP3PPP/R1BQKB1R b KQ e3";
      string str955 = "d7d6{20}";
      char[] chArray955 = new char[1]{ ' ' };
      foreach (string move in str955.Split(chArray955))
        openingMove955.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove955);
      OpeningMove openingMove956 = new OpeningMove();
      openingMove956.StartingFEN = "r1bq1rk1/pp1n1ppp/2pbpn2/3p4/2PP4/2NBPN2/PPQ2PPP/R1B1K2R w KQ -";
      string str956 = "e1g1{30}";
      char[] chArray956 = new char[1]{ ' ' };
      foreach (string move in str956.Split(chArray956))
        openingMove956.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove956);
      OpeningMove openingMove957 = new OpeningMove();
      openingMove957.StartingFEN = "rnbqkbnr/ppp1pppp/8/3p4/8/1P3N2/P1PPPPPP/RNBQKB1R b KQkq -";
      string str957 = "c7c5{5}";
      char[] chArray957 = new char[1]{ ' ' };
      foreach (string move in str957.Split(chArray957))
        openingMove957.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove957);
      OpeningMove openingMove958 = new OpeningMove();
      openingMove958.StartingFEN = "r1bq1rk1/ppp1npbp/3p2p1/3Pp2n/1PP1P3/2N2N2/P3BPPP/R1BQ1RK1 w - -";
      string str958 = "f1e1{20}";
      char[] chArray958 = new char[1]{ ' ' };
      foreach (string move in str958.Split(chArray958))
        openingMove958.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove958);
      OpeningMove openingMove959 = new OpeningMove();
      openingMove959.StartingFEN = "rnb2rk1/pp2qpbp/2pp1np1/3Pp3/2P1P3/2N1BN2/PP1QBPPP/R3K2R b KQ -";
      string str959 = "c6d5{5}";
      char[] chArray959 = new char[1]{ ' ' };
      foreach (string move in str959.Split(chArray959))
        openingMove959.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove959);
      OpeningMove openingMove960 = new OpeningMove();
      openingMove960.StartingFEN = "rnbqk1nr/ppppppbp/6p1/8/2PP4/8/PP2PPPP/RNBQKBNR w KQkq -";
      string str960 = "e2e4{5}";
      char[] chArray960 = new char[1]{ ' ' };
      foreach (string move in str960.Split(chArray960))
        openingMove960.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove960);
      OpeningMove openingMove961 = new OpeningMove();
      openingMove961.StartingFEN = "r1bqk1nr/pppp1ppp/2n5/4p3/1bB1P3/5N2/P1PP1PPP/RNBQK2R w KQkq -";
      string str961 = "c2c3{5}";
      char[] chArray961 = new char[1]{ ' ' };
      foreach (string move in str961.Split(chArray961))
        openingMove961.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove961);
      OpeningMove openingMove962 = new OpeningMove();
      openingMove962.StartingFEN = "rnbqkb1r/p4p2/2p1pn1p/1p2P1p1/2pP3B/2N2N2/PP3PPP/R2QKB1R w KQkq g6";
      string str962 = "f3g5{5}";
      char[] chArray962 = new char[1]{ ' ' };
      foreach (string move in str962.Split(chArray962))
        openingMove962.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove962);
      OpeningMove openingMove963 = new OpeningMove();
      openingMove963.StartingFEN = "rnbqkbnr/pp1ppp1p/6p1/2p5/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq d3";
      string str963 = "c5d4{5} f8g7{5}";
      char[] chArray963 = new char[1]{ ' ' };
      foreach (string move in str963.Split(chArray963))
        openingMove963.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove963);
      OpeningMove openingMove964 = new OpeningMove();
      openingMove964.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq c3";
      string str964 = "d5c4{5}";
      char[] chArray964 = new char[1]{ ' ' };
      foreach (string move in str964.Split(chArray964))
        openingMove964.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove964);
      OpeningMove openingMove965 = new OpeningMove();
      openingMove965.StartingFEN = "rnbqkb1r/pppppppp/5n2/8/3P4/2P5/PP2PPPP/RNBQKBNR b KQkq -";
      string str965 = "g7g6{5}";
      char[] chArray965 = new char[1]{ ' ' };
      foreach (string move in str965.Split(chArray965))
        openingMove965.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove965);
      OpeningMove openingMove966 = new OpeningMove();
      openingMove966.StartingFEN = "rnbqk2r/1p2bppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQK2R w KQkq -";
      string str966 = "e1g1{5} c1e3{5}";
      char[] chArray966 = new char[1]{ ' ' };
      foreach (string move in str966.Split(chArray966))
        openingMove966.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove966);
      OpeningMove openingMove967 = new OpeningMove();
      openingMove967.StartingFEN = "r1bqk2r/1p2bpp1/p1nppn1p/8/3NPP2/2N1B3/PPPQ2PP/2KR1B1R b kq f3";
      string str967 = "c6d4{5}";
      char[] chArray967 = new char[1]{ ' ' };
      foreach (string move in str967.Split(chArray967))
        openingMove967.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove967);
      OpeningMove openingMove968 = new OpeningMove();
      openingMove968.StartingFEN = "r1bqkbnr/pp1ppppp/2n5/2p5/4P3/2N5/PPPPNPPP/R1BQKB1R b KQkq -";
      string str968 = "g8f6{10}";
      char[] chArray968 = new char[1]{ ' ' };
      foreach (string move in str968.Split(chArray968))
        openingMove968.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove968);
      OpeningMove openingMove969 = new OpeningMove();
      openingMove969.StartingFEN = "r1bqkbnr/pp1ppp1p/2n3p1/1Bp5/4P3/5N2/PPPP1PPP/RNBQ1RK1 b kq -";
      string str969 = "f8g7{10}";
      char[] chArray969 = new char[1]{ ' ' };
      foreach (string move in str969.Split(chArray969))
        openingMove969.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove969);
      OpeningMove openingMove970 = new OpeningMove();
      openingMove970.StartingFEN = "r1bq1rk1/ppp1ppbp/2n2np1/8/2QPP3/2N2N2/PP3PPP/R1B1KB1R w KQ -";
      string str970 = "f1e2{5}";
      char[] chArray970 = new char[1]{ ' ' };
      foreach (string move in str970.Split(chArray970))
        openingMove970.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove970);
      OpeningMove openingMove971 = new OpeningMove();
      openingMove971.StartingFEN = "rn1qk2r/p2pbppp/bpp1pn2/8/2PP4/1PB2NP1/P3PPBP/RN1QK2R b KQkq -";
      string str971 = "d7d5{20}";
      char[] chArray971 = new char[1]{ ' ' };
      foreach (string move in str971.Split(chArray971))
        openingMove971.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove971);
      OpeningMove openingMove972 = new OpeningMove();
      openingMove972.StartingFEN = "r1bqkb1r/pp1n1ppp/2p1pn2/6N1/3P4/3B1N2/PPP2PPP/R1BQK2R b KQkq -";
      string str972 = "f8d6{25}";
      char[] chArray972 = new char[1]{ ' ' };
      foreach (string move in str972.Split(chArray972))
        openingMove972.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove972);
      OpeningMove openingMove973 = new OpeningMove();
      openingMove973.StartingFEN = "rnbq1rk1/2p1ppbp/p4np1/1p2P3/2QP4/2N2N2/PP3PPP/R1B1KB1R w KQ b6";
      string str973 = "c4b3{26}";
      char[] chArray973 = new char[1]{ ' ' };
      foreach (string move in str973.Split(chArray973))
        openingMove973.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove973);
      OpeningMove openingMove974 = new OpeningMove();
      openingMove974.StartingFEN = "rn1qkb1r/pbp2ppp/1p2p3/3n4/3P4/P1N2N2/1P2PPPP/R1BQKB1R w KQkq -";
      string str974 = "c1d2{5}";
      char[] chArray974 = new char[1]{ ' ' };
      foreach (string move in str974.Split(chArray974))
        openingMove974.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove974);
      OpeningMove openingMove975 = new OpeningMove();
      openingMove975.StartingFEN = "r1bqk2r/pp1n1ppp/2pbpn2/3p4/2PP4/2N1PN2/PPQ1BPPP/R1B1K2R b KQkq -";
      string str975 = "e8g8{5}";
      char[] chArray975 = new char[1]{ ' ' };
      foreach (string move in str975.Split(chArray975))
        openingMove975.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove975);
      OpeningMove openingMove976 = new OpeningMove();
      openingMove976.StartingFEN = "r1bqk2r/pp1n1ppp/2pbpn2/6N1/3P4/3B1N2/PPP2PPP/R1BQK2R w KQkq -";
      string str976 = "d1e2{26}";
      char[] chArray976 = new char[1]{ ' ' };
      foreach (string move in str976.Split(chArray976))
        openingMove976.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove976);
      OpeningMove openingMove977 = new OpeningMove();
      openingMove977.StartingFEN = "r1bqk2r/pp1p1ppp/2n1pn2/8/1bPP4/2NB4/PP2NPPP/R1BQK2R b KQkq -";
      string str977 = "d7d5{5}";
      char[] chArray977 = new char[1]{ ' ' };
      foreach (string move in str977.Split(chArray977))
        openingMove977.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove977);
      OpeningMove openingMove978 = new OpeningMove();
      openingMove978.StartingFEN = "rnbqkb1r/pp1p1ppp/4pn2/2pP4/2P5/8/PP2PPPP/RNBQKBNR w KQkq -";
      string str978 = "b1c3{5}";
      char[] chArray978 = new char[1]{ ' ' };
      foreach (string move in str978.Split(chArray978))
        openingMove978.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove978);
      OpeningMove openingMove979 = new OpeningMove();
      openingMove979.StartingFEN = "r2qk2r/p2nbppp/bpp1p3/3p4/2PP4/1PB3P1/P3PPBP/RN1QK2R w KQkq -";
      string str979 = "b1d2{5}";
      char[] chArray979 = new char[1]{ ' ' };
      foreach (string move in str979.Split(chArray979))
        openingMove979.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove979);
      OpeningMove openingMove980 = new OpeningMove();
      openingMove980.StartingFEN = "r1bq1rk1/4bppp/p1p5/1p1nR3/8/1BP5/PP1P1PPP/RNBQ2K1 w - -";
      string str980 = "d2d3{10} e5e1{5}";
      char[] chArray980 = new char[1]{ ' ' };
      foreach (string move in str980.Split(chArray980))
        openingMove980.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove980);
      OpeningMove openingMove981 = new OpeningMove();
      openingMove981.StartingFEN = "r1b1kb1r/p3pppp/1qpp1n2/8/2B1P3/2N5/PPP2PPP/R1BQK2R w KQkq -";
      string str981 = "e1g1{5}";
      char[] chArray981 = new char[1]{ ' ' };
      foreach (string move in str981.Split(chArray981))
        openingMove981.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove981);
      OpeningMove openingMove982 = new OpeningMove();
      openingMove982.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/8/2pP4/4PN2/PP3PPP/RNBQKB1R w KQkq -";
      string str982 = "f1c4{40}";
      char[] chArray982 = new char[1]{ ' ' };
      foreach (string move in str982.Split(chArray982))
        openingMove982.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove982);
      OpeningMove openingMove983 = new OpeningMove();
      openingMove983.StartingFEN = "rnbqkb1r/1p2pppp/p2p4/6B1/3NP1n1/2N5/PPP2PPP/R2QKB1R b KQkq -";
      string str983 = "h7h6{58}";
      char[] chArray983 = new char[1]{ ' ' };
      foreach (string move in str983.Split(chArray983))
        openingMove983.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove983);
      OpeningMove openingMove984 = new OpeningMove();
      openingMove984.StartingFEN = "r1bqkb1r/1p3ppp/p1nppn2/6B1/3NPP2/2N5/PPP3PP/R2QKB1R w KQkq -";
      string str984 = "e4e5{5}";
      char[] chArray984 = new char[1]{ ' ' };
      foreach (string move in str984.Split(chArray984))
        openingMove984.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove984);
      OpeningMove openingMove985 = new OpeningMove();
      openingMove985.StartingFEN = "rnb1kb1r/1p3ppp/pq1ppn2/8/4PP2/1NN2Q2/PPP3PP/R1B1KB1R b KQkq -";
      string str985 = "b6c7{5}";
      char[] chArray985 = new char[1]{ ' ' };
      foreach (string move in str985.Split(chArray985))
        openingMove985.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove985);
      OpeningMove openingMove986 = new OpeningMove();
      openingMove986.StartingFEN = "rnbqkbnr/ppp1pppp/8/8/2Pp4/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
      string str986 = "g2g3{5}";
      char[] chArray986 = new char[1]{ ' ' };
      foreach (string move in str986.Split(chArray986))
        openingMove986.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove986);
      OpeningMove openingMove987 = new OpeningMove();
      openingMove987.StartingFEN = "rnbqkb1r/1p2ppp1/p2p3p/8/3NP1nB/2N5/PPP2PPP/R2QKB1R b KQkq -";
      string str987 = "g7g5{53}";
      char[] chArray987 = new char[1]{ ' ' };
      foreach (string move in str987.Split(chArray987))
        openingMove987.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove987);
      OpeningMove openingMove988 = new OpeningMove();
      openingMove988.StartingFEN = "rnbq1rk1/ppp2pbp/3p2p1/4p1B1/2PPP1n1/2N2N2/PP2BPPP/R2QK2R b KQ -";
      string str988 = "f7f6{5}";
      char[] chArray988 = new char[1]{ ' ' };
      foreach (string move in str988.Split(chArray988))
        openingMove988.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove988);
      OpeningMove openingMove989 = new OpeningMove();
      openingMove989.StartingFEN = "rnbqkb1r/1p2pppp/p2p4/8/3NP1n1/2N1B3/PPP2PPP/R2QKB1R w KQkq -";
      string str989 = "e3g5{62} e3c1{15}";
      char[] chArray989 = new char[1]{ ' ' };
      foreach (string move in str989.Split(chArray989))
        openingMove989.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove989);
      OpeningMove openingMove990 = new OpeningMove();
      openingMove990.StartingFEN = "rnbqkb1r/pppp1ppp/5n2/8/3pP3/5N2/PPP2PPP/RNBQKB1R w KQkq -";
      string str990 = "e4e5{5}";
      char[] chArray990 = new char[1]{ ' ' };
      foreach (string move in str990.Split(chArray990))
        openingMove990.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove990);
      OpeningMove openingMove991 = new OpeningMove();
      openingMove991.StartingFEN = "rnb1kb1r/pppp1pp1/4pq1p/8/3PP3/2N5/PPP2PPP/R2QKBNR b KQkq -";
      string str991 = "d7d6{5}";
      char[] chArray991 = new char[1]{ ' ' };
      foreach (string move in str991.Split(chArray991))
        openingMove991.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove991);
      OpeningMove openingMove992 = new OpeningMove();
      openingMove992.StartingFEN = "r2q1rk1/1bpp1ppp/np2pn2/p7/1bPP4/1P3NP1/P1QBPPBP/RN3RK1 w - -";
      string str992 = "d2g5{5}";
      char[] chArray992 = new char[1]{ ' ' };
      foreach (string move in str992.Split(chArray992))
        openingMove992.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove992);
      OpeningMove openingMove993 = new OpeningMove();
      openingMove993.StartingFEN = "rnbqkb1r/1p2pppp/p2p4/8/3NP1n1/2N5/PPP2PPP/R1BQKB1R b KQkq -";
      string str993 = "g4f6{10}";
      char[] chArray993 = new char[1]{ ' ' };
      foreach (string move in str993.Split(chArray993))
        openingMove993.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove993);
      OpeningMove openingMove994 = new OpeningMove();
      openingMove994.StartingFEN = "r1bq1rk1/pppp1ppp/2n2n2/4p3/1bP5/2N2NP1/PP1PPPBP/R1BQK2R w KQ -";
      string str994 = "c3d5{5}";
      char[] chArray994 = new char[1]{ ' ' };
      foreach (string move in str994.Split(chArray994))
        openingMove994.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove994);
      OpeningMove openingMove995 = new OpeningMove();
      openingMove995.StartingFEN = "r1bq1rk1/pppp1ppp/2n2n2/4p3/1bP5/2N2NP1/PP1PPPBP/R1BQ1RK1 b - -";
      string str995 = "b4c3{5}";
      char[] chArray995 = new char[1]{ ' ' };
      foreach (string move in str995.Split(chArray995))
        openingMove995.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove995);
      OpeningMove openingMove996 = new OpeningMove();
      openingMove996.StartingFEN = "r1bqkb1r/pp1npppp/2p2n2/8/3PN3/5N2/PPP2PPP/R1BQKB1R w KQkq -";
      string str996 = "e4f6{5}";
      char[] chArray996 = new char[1]{ ' ' };
      foreach (string move in str996.Split(chArray996))
        openingMove996.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove996);
      OpeningMove openingMove997 = new OpeningMove();
      openingMove997.StartingFEN = "rnbqkb1r/pp1p1ppp/4pn2/2p5/2PP4/6P1/PP2PP1P/RNBQKBNR w KQkq c6";
      string str997 = "d4d5{5}";
      char[] chArray997 = new char[1]{ ' ' };
      foreach (string move in str997.Split(chArray997))
        openingMove997.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove997);
      OpeningMove openingMove998 = new OpeningMove();
      openingMove998.StartingFEN = "r1bqk2r/pp1n1ppp/2pbpn2/3p4/2PP4/2NBPN2/PPQ2PPP/R1B1K2R b KQkq -";
      string str998 = "e8g8{31}";
      char[] chArray998 = new char[1]{ ' ' };
      foreach (string move in str998.Split(chArray998))
        openingMove998.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove998);
      OpeningMove openingMove999 = new OpeningMove();
      openingMove999.StartingFEN = "rnbqk2r/ppp2ppp/4pn2/8/1bpPP3/2N2N2/PP3PPP/R1BQKB1R w KQkq -";
      string str999 = "c1g5{5}";
      char[] chArray999 = new char[1]{ ' ' };
      foreach (string move in str999.Split(chArray999))
        openingMove999.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove999);
      OpeningMove openingMove1000 = new OpeningMove();
      openingMove1000.StartingFEN = "rnbqkb1r/1p2ppp1/p2p3p/6B1/3NP1n1/2N5/PPP2PPP/R2QKB1R w KQkq -";
      string str1000 = "g5h4{57}";
      char[] chArray1000 = new char[1]{ ' ' };
      foreach (string move in str1000.Split(chArray1000))
        openingMove1000.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1000);
      OpeningMove openingMove1001 = new OpeningMove();
      openingMove1001.StartingFEN = "rnbqkb1r/5ppp/p2ppn2/1p6/3NP3/1BN5/PPP2PPP/R1BQ1RK1 b kq -";
      string str1001 = "b5b4{5}";
      char[] chArray1001 = new char[1]{ ' ' };
      foreach (string move in str1001.Split(chArray1001))
        openingMove1001.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1001);
      OpeningMove openingMove1002 = new OpeningMove();
      openingMove1002.StartingFEN = "rnbq1rk1/ppp1bpp1/4pn1p/8/2pP3B/2N2N2/PP2PPPP/2RQKB1R w K -";
      string str1002 = "e2e3{5}";
      char[] chArray1002 = new char[1]{ ' ' };
      foreach (string move in str1002.Split(chArray1002))
        openingMove1002.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1002);
      OpeningMove openingMove1003 = new OpeningMove();
      openingMove1003.StartingFEN = "r1bqk2r/pp1n1ppp/2pbpn2/6N1/3P4/3B1N2/PPP1QPPP/R1B1K2R b KQkq -";
      string str1003 = "h7h6{15}";
      char[] chArray1003 = new char[1]{ ' ' };
      foreach (string move in str1003.Split(chArray1003))
        openingMove1003.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1003);
      OpeningMove openingMove1004 = new OpeningMove();
      openingMove1004.StartingFEN = "rnb2rk1/pp2qpp1/2p1p2p/3p4/2PPn3/2N1PN2/PP3PPP/2RQKB1R w K -";
      string str1004 = "f1d3{5}";
      char[] chArray1004 = new char[1]{ ' ' };
      foreach (string move in str1004.Split(chArray1004))
        openingMove1004.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1004);
      OpeningMove openingMove1005 = new OpeningMove();
      openingMove1005.StartingFEN = "rnbqk1nr/ppp2ppp/4p3/3p4/1bPP4/5N2/PP2PPPP/RNBQKB1R w KQkq -";
      string str1005 = "c1d2{5}";
      char[] chArray1005 = new char[1]{ ' ' };
      foreach (string move in str1005.Split(chArray1005))
        openingMove1005.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1005);
      OpeningMove openingMove1006 = new OpeningMove();
      openingMove1006.StartingFEN = "rnbq1rk1/ppp1bppp/4pn2/3p4/2PP1B2/2N2N2/PP2PPPP/R2QKB1R w KQ -";
      string str1006 = "e2e3{36}";
      char[] chArray1006 = new char[1]{ ' ' };
      foreach (string move in str1006.Split(chArray1006))
        openingMove1006.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1006);
      OpeningMove openingMove1007 = new OpeningMove();
      openingMove1007.StartingFEN = "rnbqk2r/ppp1nppp/4p3/3pP3/1b1P4/2N5/PPP2PPP/R1BQKBNR w KQkq -";
      string str1007 = "a2a3{10}";
      char[] chArray1007 = new char[1]{ ' ' };
      foreach (string move in str1007.Split(chArray1007))
        openingMove1007.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1007);
      OpeningMove openingMove1008 = new OpeningMove();
      openingMove1008.StartingFEN = "rnbqkbnr/ppp1pppp/8/8/2pP4/4P3/PP3PPP/RNBQKBNR b KQkq -";
      string str1008 = "g8f6{5}";
      char[] chArray1008 = new char[1]{ ' ' };
      foreach (string move in str1008.Split(chArray1008))
        openingMove1008.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1008);
      OpeningMove openingMove1009 = new OpeningMove();
      openingMove1009.StartingFEN = "rnb1kbnr/pp1p1ppp/1q2p3/8/3NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
      string str1009 = "b1c3{5}";
      char[] chArray1009 = new char[1]{ ' ' };
      foreach (string move in str1009.Split(chArray1009))
        openingMove1009.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1009);
      OpeningMove openingMove1010 = new OpeningMove();
      openingMove1010.StartingFEN = "rnb1kb1r/1pq2ppp/p2ppn2/6B1/3NPP2/2N5/PPP3PP/R2QKB1R w KQkq -";
      string str1010 = "g5f6{5}";
      char[] chArray1010 = new char[1]{ ' ' };
      foreach (string move in str1010.Split(chArray1010))
        openingMove1010.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1010);
      OpeningMove openingMove1011 = new OpeningMove();
      openingMove1011.StartingFEN = "r1bqk2r/1pp1bppp/p1np1n2/4p3/B3P3/5N2/PPPP1PPP/RNBQR1K1 w kq -";
      string str1011 = "c2c3{5} a4c6{5}";
      char[] chArray1011 = new char[1]{ ' ' };
      foreach (string move in str1011.Split(chArray1011))
        openingMove1011.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1011);
      OpeningMove openingMove1012 = new OpeningMove();
      openingMove1012.StartingFEN = "r1bq1rk1/1pp1npbp/3p1np1/p2Pp3/1PP1P3/2N2N2/P3BPPP/R1BQ1RK1 w - a6";
      string str1012 = "c1a3{15}";
      char[] chArray1012 = new char[1]{ ' ' };
      foreach (string move in str1012.Split(chArray1012))
        openingMove1012.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1012);
      OpeningMove openingMove1013 = new OpeningMove();
      openingMove1013.StartingFEN = "rnbq1rk1/pppp1ppp/4pn2/8/1bP5/2N2N2/PPQPPPPP/R1B1KB1R w KQ -";
      string str1013 = "a2a3{30}";
      char[] chArray1013 = new char[1]{ ' ' };
      foreach (string move in str1013.Split(chArray1013))
        openingMove1013.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1013);
      OpeningMove openingMove1014 = new OpeningMove();
      openingMove1014.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/2N2N2/PP2PPPP/R1BQKB1R b KQkq d3";
      string str1014 = "d5c4{5} c7c6{5}";
      char[] chArray1014 = new char[1]{ ' ' };
      foreach (string move in str1014.Split(chArray1014))
        openingMove1014.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1014);
      OpeningMove openingMove1015 = new OpeningMove();
      openingMove1015.StartingFEN = "rnbq1rk1/pppp1ppp/4pn2/8/2P5/P1b2N2/1PQPPPPP/R1B1KB1R w KQ -";
      string str1015 = "c2c3{20}";
      char[] chArray1015 = new char[1]{ ' ' };
      foreach (string move in str1015.Split(chArray1015))
        openingMove1015.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1015);
      OpeningMove openingMove1016 = new OpeningMove();
      openingMove1016.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/3P4/3P4/8/PPP2PPP/RNBQKBNR b KQkq -";
      string str1016 = "e6d5{5}";
      char[] chArray1016 = new char[1]{ ' ' };
      foreach (string move in str1016.Split(chArray1016))
        openingMove1016.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1016);
      OpeningMove openingMove1017 = new OpeningMove();
      openingMove1017.StartingFEN = "rnbqkbnr/pp1p1ppp/4p3/2p5/3PP3/2P5/PP3PPP/RNBQKBNR b KQkq d3";
      string str1017 = "d7d5{5}";
      char[] chArray1017 = new char[1]{ ' ' };
      foreach (string move in str1017.Split(chArray1017))
        openingMove1017.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1017);
      OpeningMove openingMove1018 = new OpeningMove();
      openingMove1018.StartingFEN = "rn1qkbnr/pp3ppp/2p1p3/3pPb2/3P4/P4N2/1PP2PPP/RNBQKB1R b KQkq -";
      string str1018 = "g8e7{5}";
      char[] chArray1018 = new char[1]{ ' ' };
      foreach (string move in str1018.Split(chArray1018))
        openingMove1018.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1018);
      OpeningMove openingMove1019 = new OpeningMove();
      openingMove1019.StartingFEN = "rnbqkbnr/pp1p1ppp/4p3/2p5/4PP2/2N5/PPPP2PP/R1BQKBNR b KQkq f3";
      string str1019 = "b8c6{5}";
      char[] chArray1019 = new char[1]{ ' ' };
      foreach (string move in str1019.Split(chArray1019))
        openingMove1019.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1019);
      OpeningMove openingMove1020 = new OpeningMove();
      openingMove1020.StartingFEN = "rn1qkb1r/pp2pppp/2p2n2/4Nb2/P1pP4/2N5/1P2PPPP/R1BQKB1R b KQkq -";
      string str1020 = "e7e6{15} b8d7{10}";
      char[] chArray1020 = new char[1]{ ' ' };
      foreach (string move in str1020.Split(chArray1020))
        openingMove1020.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1020);
      OpeningMove openingMove1021 = new OpeningMove();
      openingMove1021.StartingFEN = "rn1q1rk1/1bpp1ppp/1p2pn2/p7/2PP4/1P3NP1/P1QbPPBP/RN3RK1 w - -";
      string str1021 = "b1d2{5}";
      char[] chArray1021 = new char[1]{ ' ' };
      foreach (string move in str1021.Split(chArray1021))
        openingMove1021.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1021);
      OpeningMove openingMove1022 = new OpeningMove();
      openingMove1022.StartingFEN = "r1bqk2r/pp1n1pp1/2pbpn1p/6N1/3P4/3B1N2/PPP1QPPP/R1B1K2R w KQkq -";
      string str1022 = "g5e4{16}";
      char[] chArray1022 = new char[1]{ ' ' };
      foreach (string move in str1022.Split(chArray1022))
        openingMove1022.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1022);
      OpeningMove openingMove1023 = new OpeningMove();
      openingMove1023.StartingFEN = "r1bq1rk1/pp1n1ppp/2pbpn2/3p4/2PP4/2NBPN2/PPQ2PPP/R1B2RK1 b - -";
      string str1023 = "d5c4{26}";
      char[] chArray1023 = new char[1]{ ' ' };
      foreach (string move in str1023.Split(chArray1023))
        openingMove1023.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1023);
      OpeningMove openingMove1024 = new OpeningMove();
      openingMove1024.StartingFEN = "rnb1k1nr/pp3ppp/4p3/q1ppP3/3P4/P1P5/2P2PPP/R1BQKBNR w KQkq -";
      string str1024 = "c1d2{5}";
      char[] chArray1024 = new char[1]{ ' ' };
      foreach (string move in str1024.Split(chArray1024))
        openingMove1024.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1024);
      OpeningMove openingMove1025 = new OpeningMove();
      openingMove1025.StartingFEN = "rnb1kb1r/pp3pp1/2p1pq1p/3p4/2PP4/2N1PN2/PP3PPP/R2QKB1R b KQkq -";
      string str1025 = "b8d7{25}";
      char[] chArray1025 = new char[1]{ ' ' };
      foreach (string move in str1025.Split(chArray1025))
        openingMove1025.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1025);
      OpeningMove openingMove1026 = new OpeningMove();
      openingMove1026.StartingFEN = "rnbqk2r/pp2bppp/4pn2/3p4/2PP4/2N2N2/PP3PPP/R1BQKB1R w KQkq -";
      string str1026 = "c4d5{5}";
      char[] chArray1026 = new char[1]{ ' ' };
      foreach (string move in str1026.Split(chArray1026))
        openingMove1026.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1026);
      OpeningMove openingMove1027 = new OpeningMove();
      openingMove1027.StartingFEN = "rnbq1rk1/pp3pbp/2pp1np1/4p3/2PPP3/2N1BN2/PP2BPPP/R2Q1RK1 b - -";
      string str1027 = "e5d4{5}";
      char[] chArray1027 = new char[1]{ ' ' };
      foreach (string move in str1027.Split(chArray1027))
        openingMove1027.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1027);
      OpeningMove openingMove1028 = new OpeningMove();
      openingMove1028.StartingFEN = "r1bqkbnr/1ppp1ppp/p1B5/4p3/4P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
      string str1028 = "d7c6{15}";
      char[] chArray1028 = new char[1]{ ' ' };
      foreach (string move in str1028.Split(chArray1028))
        openingMove1028.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1028);
      OpeningMove openingMove1029 = new OpeningMove();
      openingMove1029.StartingFEN = "rnbqkbnr/1p1p1ppp/p3p3/8/3NP3/3B4/PPP2PPP/RNBQK2R b KQkq -";
      string str1029 = "g8f6{5}";
      char[] chArray1029 = new char[1]{ ' ' };
      foreach (string move in str1029.Split(chArray1029))
        openingMove1029.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1029);
      OpeningMove openingMove1030 = new OpeningMove();
      openingMove1030.StartingFEN = "rnbq1rk1/ppppppbp/5np1/8/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQ -";
      string str1030 = "e2e4{10}";
      char[] chArray1030 = new char[1]{ ' ' };
      foreach (string move in str1030.Split(chArray1030))
        openingMove1030.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1030);
      OpeningMove openingMove1031 = new OpeningMove();
      openingMove1031.StartingFEN = "r1bqk2r/2pp1ppp/p1n2n2/1pb1p3/4P3/1B3N2/PPPP1PPP/RNBQ1RK1 w kq -";
      string str1031 = "a2a4{40}";
      char[] chArray1031 = new char[1]{ ' ' };
      foreach (string move in str1031.Split(chArray1031))
        openingMove1031.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1031);
      OpeningMove openingMove1032 = new OpeningMove();
      openingMove1032.StartingFEN = "rnbqkb1r/pppp1ppp/8/4p3/3Pn3/3B1N2/PPP2PPP/RNBQK2R b KQkq -";
      string str1032 = "d7d5{15}";
      char[] chArray1032 = new char[1]{ ' ' };
      foreach (string move in str1032.Split(chArray1032))
        openingMove1032.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1032);
      OpeningMove openingMove1033 = new OpeningMove();
      openingMove1033.StartingFEN = "rnbq1rk1/pp3ppp/4pn2/2pp4/1bPP4/2NBPN2/PP3PPP/R1BQ1RK1 b - -";
      string str1033 = "b8c6{10}";
      char[] chArray1033 = new char[1]{ ' ' };
      foreach (string move in str1033.Split(chArray1033))
        openingMove1033.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1033);
      OpeningMove openingMove1034 = new OpeningMove();
      openingMove1034.StartingFEN = "r1bqkbnr/pppp1ppp/2n5/4p3/2P5/2N1P3/PP1P1PPP/R1BQKBNR b KQkq -";
      string str1034 = "g8f6{6}";
      char[] chArray1034 = new char[1]{ ' ' };
      foreach (string move in str1034.Split(chArray1034))
        openingMove1034.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1034);
      OpeningMove openingMove1035 = new OpeningMove();
      openingMove1035.StartingFEN = "r1bq1rk1/ppp1n1bp/3p2p1/3Ppp1n/1PP1P3/2N2N2/P3BPPP/R1BQR1K1 w - f6";
      string str1035 = "f3g5{5}";
      char[] chArray1035 = new char[1]{ ' ' };
      foreach (string move in str1035.Split(chArray1035))
        openingMove1035.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1035);
      OpeningMove openingMove1036 = new OpeningMove();
      openingMove1036.StartingFEN = "rnbqkb1r/1p3ppp/p2p1n2/4p3/4P3/1NN1B3/PPP2PPP/R2QKB1R b KQkq -";
      string str1036 = "c8e6{36}";
      char[] chArray1036 = new char[1]{ ' ' };
      foreach (string move in str1036.Split(chArray1036))
        openingMove1036.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1036);
      OpeningMove openingMove1037 = new OpeningMove();
      openingMove1037.StartingFEN = "rnbqkb1r/ppp1pppp/5n2/8/2pP4/4P3/PP3PPP/RNBQKBNR w KQkq -";
      string str1037 = "f1c4{6}";
      char[] chArray1037 = new char[1]{ ' ' };
      foreach (string move in str1037.Split(chArray1037))
        openingMove1037.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1037);
      OpeningMove openingMove1038 = new OpeningMove();
      openingMove1038.StartingFEN = "rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/2N5/PPQ1PPPP/R1B1KBNR w KQkq c6";
      string str1038 = "d4c5{15}";
      char[] chArray1038 = new char[1]{ ' ' };
      foreach (string move in str1038.Split(chArray1038))
        openingMove1038.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1038);
      OpeningMove openingMove1039 = new OpeningMove();
      openingMove1039.StartingFEN = "r1bq1rk1/pp2ppbp/2np1np1/8/3NP3/2N1BP2/PPPQ2PP/R3KB1R w KQ -";
      string str1039 = "f1c4{5} e1c1{10}";
      char[] chArray1039 = new char[1]{ ' ' };
      foreach (string move in str1039.Split(chArray1039))
        openingMove1039.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1039);
      OpeningMove openingMove1040 = new OpeningMove();
      openingMove1040.StartingFEN = "rnbqkbnr/pp1ppp1p/6p1/2p5/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
      string str1040 = "d2d4{10}";
      char[] chArray1040 = new char[1]{ ' ' };
      foreach (string move in str1040.Split(chArray1040))
        openingMove1040.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1040);
      OpeningMove openingMove1041 = new OpeningMove();
      openingMove1041.StartingFEN = "r1bqkb1r/2pp1ppp/p1n2n2/1p2p3/4P3/1B3N2/PPPP1PPP/RNBQ1RK1 b kq -";
      string str1041 = "c8b7{5} f8c5{25}";
      char[] chArray1041 = new char[1]{ ' ' };
      foreach (string move in str1041.Split(chArray1041))
        openingMove1041.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1041);
      OpeningMove openingMove1042 = new OpeningMove();
      openingMove1042.StartingFEN = "rnbqkb1r/1p3ppp/p3pn2/3p4/3NP1P1/2N1B3/PPP2P1P/R2QKB1R w KQkq -";
      string str1042 = "g4g5{5}";
      char[] chArray1042 = new char[1]{ ' ' };
      foreach (string move in str1042.Split(chArray1042))
        openingMove1042.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1042);
      OpeningMove openingMove1043 = new OpeningMove();
      openingMove1043.StartingFEN = "r1bqkbnr/1pp2ppp/p1p5/4p3/4P3/5N2/PPPP1PPP/RNBQ1RK1 b kq -";
      string str1043 = "c8g4{5} f7f6{5}";
      char[] chArray1043 = new char[1]{ ' ' };
      foreach (string move in str1043.Split(chArray1043))
        openingMove1043.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1043);
      OpeningMove openingMove1044 = new OpeningMove();
      openingMove1044.StartingFEN = "rnbqkb1r/ppp1pppp/5n2/8/2pP4/4PN2/PP3PPP/RNBQKB1R b KQkq -";
      string str1044 = "e7e6{5}";
      char[] chArray1044 = new char[1]{ ' ' };
      foreach (string move in str1044.Split(chArray1044))
        openingMove1044.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1044);
      OpeningMove openingMove1045 = new OpeningMove();
      openingMove1045.StartingFEN = "r1bq1rk1/1p2bppp/p1nppn2/8/P2NPP2/2N1B3/1PP1B1PP/R2Q1RK1 b - f3";
      string str1045 = "d8c7{6}";
      char[] chArray1045 = new char[1]{ ' ' };
      foreach (string move in str1045.Split(chArray1045))
        openingMove1045.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1045);
      OpeningMove openingMove1046 = new OpeningMove();
      openingMove1046.StartingFEN = "rnbq1rk1/1pp1ppbp/p2p1np1/6B1/2PPP3/2N2P2/PP4PP/R2QKBNR w KQ -";
      string str1046 = "d1d2{10}";
      char[] chArray1046 = new char[1]{ ' ' };
      foreach (string move in str1046.Split(chArray1046))
        openingMove1046.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1046);
      OpeningMove openingMove1047 = new OpeningMove();
      openingMove1047.StartingFEN = "r1bqk2r/pp2bppp/3ppn2/6B1/3QP3/2N5/PPP2PPP/2KR1B1R b kq -";
      string str1047 = "e8g8{5}";
      char[] chArray1047 = new char[1]{ ' ' };
      foreach (string move in str1047.Split(chArray1047))
        openingMove1047.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1047);
      OpeningMove openingMove1048 = new OpeningMove();
      openingMove1048.StartingFEN = "rnbqkb1r/ppp1pppp/8/3np3/3P4/5N2/PPP2PPP/RNBQKB1R w KQkq -";
      string str1048 = "f3e5{6}";
      char[] chArray1048 = new char[1]{ ' ' };
      foreach (string move in str1048.Split(chArray1048))
        openingMove1048.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1048);
      OpeningMove openingMove1049 = new OpeningMove();
      openingMove1049.StartingFEN = "r1b1k2r/1pqp1ppp/p1n1pn2/8/1b1NP3/2N1B3/PPP1BPPP/R2Q1RK1 w kq -";
      string str1049 = "c3a4{6}";
      char[] chArray1049 = new char[1]{ ' ' };
      foreach (string move in str1049.Split(chArray1049))
        openingMove1049.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1049);
      OpeningMove openingMove1050 = new OpeningMove();
      openingMove1050.StartingFEN = "r1b2rk1/pp1nqppp/2pbpn2/3p4/2PP4/2NBPN2/PPQ2PPP/R1B2RK1 w - -";
      string str1050 = "c4c5{5}";
      char[] chArray1050 = new char[1]{ ' ' };
      foreach (string move in str1050.Split(chArray1050))
        openingMove1050.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1050);
      OpeningMove openingMove1051 = new OpeningMove();
      openingMove1051.StartingFEN = "r1b1kb1r/pp1n1pp1/2p1pq1p/3p4/2PP4/2NBPN2/PP3PPP/R2QK2R b KQkq -";
      string str1051 = "d5c4{15}";
      char[] chArray1051 = new char[1]{ ' ' };
      foreach (string move in str1051.Split(chArray1051))
        openingMove1051.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1051);
      OpeningMove openingMove1052 = new OpeningMove();
      openingMove1052.StartingFEN = "r1bqk2r/1ppp1ppp/p1n2n2/2b1p3/B3P3/2P2N2/PP1P1PPP/RNBQ1RK1 b kq -";
      string str1052 = "b7b5{35}";
      char[] chArray1052 = new char[1]{ ' ' };
      foreach (string move in str1052.Split(chArray1052))
        openingMove1052.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1052);
      OpeningMove openingMove1053 = new OpeningMove();
      openingMove1053.StartingFEN = "r1bqkb1r/1p3pp1/p1nppn1p/6B1/3NP3/2N5/PPPQ1PPP/2KR1B1R w kq -";
      string str1053 = "g5e3{10}";
      char[] chArray1053 = new char[1]{ ' ' };
      foreach (string move in str1053.Split(chArray1053))
        openingMove1053.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1053);
      OpeningMove openingMove1054 = new OpeningMove();
      openingMove1054.StartingFEN = "r1bqkbnr/1pp2ppp/p1p5/4p3/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str1054 = "e1g1{10}";
      char[] chArray1054 = new char[1]{ ' ' };
      foreach (string move in str1054.Split(chArray1054))
        openingMove1054.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1054);
      OpeningMove openingMove1055 = new OpeningMove();
      openingMove1055.StartingFEN = "r1bqkb1r/pppn1ppp/5n2/3p4/3P4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str1055 = "c1g5{10}";
      char[] chArray1055 = new char[1]{ ' ' };
      foreach (string move in str1055.Split(chArray1055))
        openingMove1055.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1055);
      OpeningMove openingMove1056 = new OpeningMove();
      openingMove1056.StartingFEN = "rnbq1rk1/1pp1ppbp/p2p1np1/6B1/2PPP3/2N2P2/PP1Q2PP/R3KBNR b KQ -";
      string str1056 = "c7c5{5}";
      char[] chArray1056 = new char[1]{ ' ' };
      foreach (string move in str1056.Split(chArray1056))
        openingMove1056.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1056);
      OpeningMove openingMove1057 = new OpeningMove();
      openingMove1057.StartingFEN = "rnbqkb1r/1p2pp2/p2p3p/6p1/3NP1n1/2N3B1/PPP2PPP/R2QKB1R b KQkq -";
      string str1057 = "f8g7{48}";
      char[] chArray1057 = new char[1]{ ' ' };
      foreach (string move in str1057.Split(chArray1057))
        openingMove1057.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1057);
      OpeningMove openingMove1058 = new OpeningMove();
      openingMove1058.StartingFEN = "r2qkb1r/1p1b1ppp/p1nppn2/6B1/3NP3/2N5/PPPQ1PPP/2KR1B1R w kq -";
      string str1058 = "f2f3{5}";
      char[] chArray1058 = new char[1]{ ' ' };
      foreach (string move in str1058.Split(chArray1058))
        openingMove1058.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1058);
      OpeningMove openingMove1059 = new OpeningMove();
      openingMove1059.StartingFEN = "rnbq1rk1/pp1p1ppp/4pn2/2p5/1bPP4/2NBP3/PP3PPP/R1BQK1NR w KQ c6";
      string str1059 = "g1f3{6}";
      char[] chArray1059 = new char[1]{ ' ' };
      foreach (string move in str1059.Split(chArray1059))
        openingMove1059.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1059);
      OpeningMove openingMove1060 = new OpeningMove();
      openingMove1060.StartingFEN = "r1bq1rk1/2ppbppp/p1n2n2/1p2p3/4P3/1BP2N2/PP1P1PPP/RNBQR1K1 b - -";
      string str1060 = "d7d6{5} d7d5{20}";
      char[] chArray1060 = new char[1]{ ' ' };
      foreach (string move in str1060.Split(chArray1060))
        openingMove1060.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1060);
      OpeningMove openingMove1061 = new OpeningMove();
      openingMove1061.StartingFEN = "rnbq1rk1/1p2ppbp/p2p1np1/2p3B1/2PPP3/2N2P2/PP1Q2PP/R3KBNR w KQ c6";
      string str1061 = "d4d5{5}";
      char[] chArray1061 = new char[1]{ ' ' };
      foreach (string move in str1061.Split(chArray1061))
        openingMove1061.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1061);
      OpeningMove openingMove1062 = new OpeningMove();
      openingMove1062.StartingFEN = "rnbqkb1r/p2ppppp/5n2/1ppP4/2P5/5N2/PP2PPPP/RNBQKB1R b KQkq -";
      string str1062 = "g7g6{5}";
      char[] chArray1062 = new char[1]{ ' ' };
      foreach (string move in str1062.Split(chArray1062))
        openingMove1062.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1062);
      OpeningMove openingMove1063 = new OpeningMove();
      openingMove1063.StartingFEN = "rnbqkb1r/pp3p1p/3p1np1/2pP4/4P3/2N2N2/PP3PPP/R1BQKB1R b KQkq e3";
      string str1063 = "a7a6{5}";
      char[] chArray1063 = new char[1]{ ' ' };
      foreach (string move in str1063.Split(chArray1063))
        openingMove1063.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1063);
      OpeningMove openingMove1064 = new OpeningMove();
      openingMove1064.StartingFEN = "r2qk2r/2p1bppp/p1n1b3/1pnpP3/8/1BP2N2/PP1N1PPP/R1BQ1RK1 w kq -";
      string str1064 = "b3c2{10}";
      char[] chArray1064 = new char[1]{ ' ' };
      foreach (string move in str1064.Split(chArray1064))
        openingMove1064.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1064);
      OpeningMove openingMove1065 = new OpeningMove();
      openingMove1065.StartingFEN = "rnbqkb1r/p2ppppp/5n2/1PpP4/8/8/PP2PPPP/RNBQKBNR b KQkq -";
      string str1065 = "a7a6{10}";
      char[] chArray1065 = new char[1]{ ' ' };
      foreach (string move in str1065.Split(chArray1065))
        openingMove1065.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1065);
      OpeningMove openingMove1066 = new OpeningMove();
      openingMove1066.StartingFEN = "rnb1kb1r/1pq2ppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQK2R w KQkq -";
      string str1066 = "a2a4{5}";
      char[] chArray1066 = new char[1]{ ' ' };
      foreach (string move in str1066.Split(chArray1066))
        openingMove1066.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1066);
      OpeningMove openingMove1067 = new OpeningMove();
      openingMove1067.StartingFEN = "r1bqkb1r/pp1n1ppp/2n1p3/3pP3/3p1P2/2N1BN2/PPP3PP/R2QKB1R w KQkq -";
      string str1067 = "f3d4{6}";
      char[] chArray1067 = new char[1]{ ' ' };
      foreach (string move in str1067.Split(chArray1067))
        openingMove1067.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1067);
      OpeningMove openingMove1068 = new OpeningMove();
      openingMove1068.StartingFEN = "rnbqkbnr/1pp1pppp/p7/3p4/3P4/5N2/PPP1PPPP/RNBQKB1R w KQkq -";
      string str1068 = "c1g5{5}";
      char[] chArray1068 = new char[1]{ ' ' };
      foreach (string move in str1068.Split(chArray1068))
        openingMove1068.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1068);
      OpeningMove openingMove1069 = new OpeningMove();
      openingMove1069.StartingFEN = "rn1qkbnr/pp1b1ppp/4p3/2ppP3/3P4/2P5/PP3PPP/RNBQKBNR w KQkq -";
      string str1069 = "g1f3{5}";
      char[] chArray1069 = new char[1]{ ' ' };
      foreach (string move in str1069.Split(chArray1069))
        openingMove1069.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1069);
      OpeningMove openingMove1070 = new OpeningMove();
      openingMove1070.StartingFEN = "r1bqk2r/2pp1ppp/p1n2n2/1pb1p3/P3P3/1B3N2/1PPP1PPP/RNBQ1RK1 b kq a3";
      string str1070 = "a8b8{10} c8b7{10}";
      char[] chArray1070 = new char[1]{ ' ' };
      foreach (string move in str1070.Split(chArray1070))
        openingMove1070.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1070);
      OpeningMove openingMove1071 = new OpeningMove();
      openingMove1071.StartingFEN = "r1bqkb1r/pp1ppppp/2n2n2/2p5/4P3/2N5/PPPPNPPP/R1BQKB1R w KQkq -";
      string str1071 = "d2d4{5}";
      char[] chArray1071 = new char[1]{ ' ' };
      foreach (string move in str1071.Split(chArray1071))
        openingMove1071.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1071);
      OpeningMove openingMove1072 = new OpeningMove();
      openingMove1072.StartingFEN = "r1bq1rk1/ppp2pbp/n2p1np1/4p3/2PPP3/2N2N2/PP2BPPP/R1BQ1RK1 w - -";
      string str1072 = "c1e3{5}";
      char[] chArray1072 = new char[1]{ ' ' };
      foreach (string move in str1072.Split(chArray1072))
        openingMove1072.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1072);
      OpeningMove openingMove1073 = new OpeningMove();
      openingMove1073.StartingFEN = "rnb1kb1r/1p3ppp/pq1ppn2/6B1/4PP2/1NN5/PPP3PP/R2QKB1R b KQkq -";
      string str1073 = "f8e7{10}";
      char[] chArray1073 = new char[1]{ ' ' };
      foreach (string move in str1073.Split(chArray1073))
        openingMove1073.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1073);
      OpeningMove openingMove1074 = new OpeningMove();
      openingMove1074.StartingFEN = "r1bq1rk1/ppp1npbp/3p2p1/3Pp3/1PP1Pn2/2N2N2/P3BPPP/R1BQR1K1 w - -";
      string str1074 = "e2f1{5}";
      char[] chArray1074 = new char[1]{ ' ' };
      foreach (string move in str1074.Split(chArray1074))
        openingMove1074.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1074);
      OpeningMove openingMove1075 = new OpeningMove();
      openingMove1075.StartingFEN = "rnbqk2r/1p2ppb1/p2p3p/6p1/3NP1n1/2N3B1/PPP1BPPP/R2QK2R b KQkq -";
      string str1075 = "h6h5{21}";
      char[] chArray1075 = new char[1]{ ' ' };
      foreach (string move in str1075.Split(chArray1075))
        openingMove1075.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1075);
      OpeningMove openingMove1076 = new OpeningMove();
      openingMove1076.StartingFEN = "rnbqk2r/ppp2ppp/4pn2/3p2B1/1b1PP3/2N5/PPP2PPP/R2QKBNR w KQkq -";
      string str1076 = "e4e5{10}";
      char[] chArray1076 = new char[1]{ ' ' };
      foreach (string move in str1076.Split(chArray1076))
        openingMove1076.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1076);
      OpeningMove openingMove1077 = new OpeningMove();
      openingMove1077.StartingFEN = "rnbqkb1r/pp3ppp/3ppn2/8/3NP3/2N1B3/PPP2PPP/R2QKB1R b KQkq -";
      string str1077 = "a7a6{5}";
      char[] chArray1077 = new char[1]{ ' ' };
      foreach (string move in str1077.Split(chArray1077))
        openingMove1077.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1077);
      OpeningMove openingMove1078 = new OpeningMove();
      openingMove1078.StartingFEN = "r1bqk1nr/pppp1ppp/2n5/8/1b1NP3/8/PPP2PPP/RNBQKB1R w KQkq -";
      string str1078 = "c2c3{6}";
      char[] chArray1078 = new char[1]{ ' ' };
      foreach (string move in str1078.Split(chArray1078))
        openingMove1078.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1078);
      OpeningMove openingMove1079 = new OpeningMove();
      openingMove1079.StartingFEN = "rnbq1rk1/ppp1ppbp/3p1np1/8/2PP4/2N3P1/PP2PPBP/R1BQK1NR w KQ -";
      string str1079 = "g1f3{5}";
      char[] chArray1079 = new char[1]{ ' ' };
      foreach (string move in str1079.Split(chArray1079))
        openingMove1079.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1079);
      OpeningMove openingMove1080 = new OpeningMove();
      openingMove1080.StartingFEN = "r1bqkbnr/pp3ppp/2npp3/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
      string str1080 = "c1e3{5}";
      char[] chArray1080 = new char[1]{ ' ' };
      foreach (string move in str1080.Split(chArray1080))
        openingMove1080.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1080);
      OpeningMove openingMove1081 = new OpeningMove();
      openingMove1081.StartingFEN = "rnbq1rk1/ppp2pbp/3p1np1/8/2PpP3/2N1BN2/PP2BPPP/R2QK2R w KQ -";
      string str1081 = "f3d4{5}";
      char[] chArray1081 = new char[1]{ ' ' };
      foreach (string move in str1081.Split(chArray1081))
        openingMove1081.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1081);
      OpeningMove openingMove1082 = new OpeningMove();
      openingMove1082.StartingFEN = "rnbqkbnr/ppp2ppp/8/4p3/2pPP3/5N2/PP3PPP/RNBQKB1R b KQkq -";
      string str1082 = "e5d4{10}";
      char[] chArray1082 = new char[1]{ ' ' };
      foreach (string move in str1082.Split(chArray1082))
        openingMove1082.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1082);
      OpeningMove openingMove1083 = new OpeningMove();
      openingMove1083.StartingFEN = "r1bq1rk1/2p1npbp/1p1p1np1/p2Pp3/1PP1P3/B1N2N2/P3BPPP/R2Q1RK1 w - -";
      string str1083 = "b4a5{5}";
      char[] chArray1083 = new char[1]{ ' ' };
      foreach (string move in str1083.Split(chArray1083))
        openingMove1083.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1083);
      OpeningMove openingMove1084 = new OpeningMove();
      openingMove1084.StartingFEN = "rnbqr1k1/ppp2pbp/3p1np1/8/2PNP3/2N5/PP2BPPP/R1BQ1RK1 w - -";
      string str1084 = "f2f3{5}";
      char[] chArray1084 = new char[1]{ ' ' };
      foreach (string move in str1084.Split(chArray1084))
        openingMove1084.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1084);
      OpeningMove openingMove1085 = new OpeningMove();
      openingMove1085.StartingFEN = "r1bqk2r/ppppbppp/2n2n2/4p3/2B1P3/3P1N2/PPP2PPP/RNBQ1RK1 b kq -";
      string str1085 = "d7d5{5}";
      char[] chArray1085 = new char[1]{ ' ' };
      foreach (string move in str1085.Split(chArray1085))
        openingMove1085.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1085);
      OpeningMove openingMove1086 = new OpeningMove();
      openingMove1086.StartingFEN = "r1bq1rk1/pp1p1ppp/n3pn2/2P5/1bP5/P1N2N2/1PQ1PPPP/R1B1KB1R b KQ -";
      string str1086 = "b4c3{5}";
      char[] chArray1086 = new char[1]{ ' ' };
      foreach (string move in str1086.Split(chArray1086))
        openingMove1086.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1086);
      OpeningMove openingMove1087 = new OpeningMove();
      openingMove1087.StartingFEN = "rn1qkb1r/p2p1ppp/bp2pn2/2p5/2PP4/P4N2/1PQ1PPPP/RNB1KB1R w KQkq c6";
      string str1087 = "d4d5{5}";
      char[] chArray1087 = new char[1]{ ' ' };
      foreach (string move in str1087.Split(chArray1087))
        openingMove1087.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1087);
      OpeningMove openingMove1088 = new OpeningMove();
      openingMove1088.StartingFEN = "r2qkbnr/pp1npppb/2p4p/7P/3P4/5NN1/PPP2PP1/R1BQKB1R w KQkq -";
      string str1088 = "f1d3{5}";
      char[] chArray1088 = new char[1]{ ' ' };
      foreach (string move in str1088.Split(chArray1088))
        openingMove1088.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1088);
      OpeningMove openingMove1089 = new OpeningMove();
      openingMove1089.StartingFEN = "rnbqk2r/ppppppbp/5np1/8/3P4/5NP1/PPP1PP1P/RNBQKB1R w KQkq -";
      string str1089 = "f1g2{10}";
      char[] chArray1089 = new char[1]{ ' ' };
      foreach (string move in str1089.Split(chArray1089))
        openingMove1089.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1089);
      OpeningMove openingMove1090 = new OpeningMove();
      openingMove1090.StartingFEN = "rnbqkb1r/p2p1ppp/4pn2/1ppP4/2P5/5N2/PP2PPPP/RNBQKB1R w KQkq b6";
      string str1090 = "d5e6{5}";
      char[] chArray1090 = new char[1]{ ' ' };
      foreach (string move in str1090.Split(chArray1090))
        openingMove1090.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1090);
      OpeningMove openingMove1091 = new OpeningMove();
      openingMove1091.StartingFEN = "rnbqkb1r/1p2pp2/p2p3p/6p1/3NP1nB/2N5/PPP2PPP/R2QKB1R w KQkq g6";
      string str1091 = "h4g3{52}";
      char[] chArray1091 = new char[1]{ ' ' };
      foreach (string move in str1091.Split(chArray1091))
        openingMove1091.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1091);
      OpeningMove openingMove1092 = new OpeningMove();
      openingMove1092.StartingFEN = "r1bqkb1r/ppp2ppp/2n5/3p4/3Pn3/3B1N2/PPP2PPP/RNBQ1RK1 b kq -";
      string str1092 = "f8e7{60}";
      char[] chArray1092 = new char[1]{ ' ' };
      foreach (string move in str1092.Split(chArray1092))
        openingMove1092.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1092);
      OpeningMove openingMove1093 = new OpeningMove();
      openingMove1093.StartingFEN = "r1bqk2r/1p2bppp/p1nppn2/6B1/3NP3/2N5/PPPQ1PPP/2KR1B1R w kq -";
      string str1093 = "f2f4{6}";
      char[] chArray1093 = new char[1]{ ' ' };
      foreach (string move in str1093.Split(chArray1093))
        openingMove1093.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1093);
      OpeningMove openingMove1094 = new OpeningMove();
      openingMove1094.StartingFEN = "r1bqk2r/ppp1bppp/2n5/3p4/2PPn3/3B1N2/PP3PPP/RNBQ1RK1 b kq c3";
      string str1094 = "c6b4{45}";
      char[] chArray1094 = new char[1]{ ' ' };
      foreach (string move in str1094.Split(chArray1094))
        openingMove1094.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1094);
      OpeningMove openingMove1095 = new OpeningMove();
      openingMove1095.StartingFEN = "rn1q1rk1/pbpp1ppp/1p2pn2/6B1/2PP4/P1Q2P2/1P2P1PP/R3KBNR b KQ -";
      string str1095 = "h7h6{10}";
      char[] chArray1095 = new char[1]{ ' ' };
      foreach (string move in str1095.Split(chArray1095))
        openingMove1095.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1095);
      OpeningMove openingMove1096 = new OpeningMove();
      openingMove1096.StartingFEN = "rnbqk2r/pppp1ppp/4pn2/8/1bP5/2N2N2/PPQPPPPP/R1B1KB1R b KQkq -";
      string str1096 = "e8g8{20}";
      char[] chArray1096 = new char[1]{ ' ' };
      foreach (string move in str1096.Split(chArray1096))
        openingMove1096.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1096);
      OpeningMove openingMove1097 = new OpeningMove();
      openingMove1097.StartingFEN = "rnbqkbnr/pppp1ppp/8/4p3/2B1P3/8/PPPP1PPP/RNBQK1NR b KQkq -";
      string str1097 = "g8f6{10}";
      char[] chArray1097 = new char[1]{ ' ' };
      foreach (string move in str1097.Split(chArray1097))
        openingMove1097.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1097);
      OpeningMove openingMove1098 = new OpeningMove();
      openingMove1098.StartingFEN = "r2qkb1r/1p1n1ppp/p2pbn2/4p3/4P3/1NN1BP2/PPP3PP/R2QKB1R w KQkq -";
      string str1098 = "g2g4{22} d1d2{10}";
      char[] chArray1098 = new char[1]{ ' ' };
      foreach (string move in str1098.Split(chArray1098))
        openingMove1098.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1098);
      OpeningMove openingMove1099 = new OpeningMove();
      openingMove1099.StartingFEN = "rnbq1rk1/ppp1bppp/4pn2/3p4/2PP1B2/2N1PN2/PP3PPP/R2QKB1R b KQ -";
      string str1099 = "c7c5{21}";
      char[] chArray1099 = new char[1]{ ' ' };
      foreach (string move in str1099.Split(chArray1099))
        openingMove1099.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1099);
      OpeningMove openingMove1100 = new OpeningMove();
      openingMove1100.StartingFEN = "r1bqk2r/pp2ppbp/2n3p1/2p5/2BPP3/2P5/P3NPPP/R1BQK2R w KQkq -";
      string str1100 = "c1e3{15}";
      char[] chArray1100 = new char[1]{ ' ' };
      foreach (string move in str1100.Split(chArray1100))
        openingMove1100.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1100);
      OpeningMove openingMove1101 = new OpeningMove();
      openingMove1101.StartingFEN = "rnbq1rk1/pppp1ppp/4pn2/8/1bPP4/2N1P3/PP2NPPP/R1BQKB1R b KQ -";
      string str1101 = "d7d5{5}";
      char[] chArray1101 = new char[1]{ ' ' };
      foreach (string move in str1101.Split(chArray1101))
        openingMove1101.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1101);
      OpeningMove openingMove1102 = new OpeningMove();
      openingMove1102.StartingFEN = "rnbqk2r/ppp1ppbp/5np1/3p4/2PP1B2/2N2N2/PP2PPPP/R2QKB1R b KQkq -";
      string str1102 = "e8g8{5}";
      char[] chArray1102 = new char[1]{ ' ' };
      foreach (string move in str1102.Split(chArray1102))
        openingMove1102.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1102);
      OpeningMove openingMove1103 = new OpeningMove();
      openingMove1103.StartingFEN = "rnbqkb1r/3ppppp/P4n2/2pP4/8/8/PP2PPPP/RNBQKBNR b KQkq -";
      string str1103 = "g7g6{5}";
      char[] chArray1103 = new char[1]{ ' ' };
      foreach (string move in str1103.Split(chArray1103))
        openingMove1103.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1103);
      OpeningMove openingMove1104 = new OpeningMove();
      openingMove1104.StartingFEN = "rnbq1rk1/ppp1bpp1/4pn1p/3p4/2PP3B/2N1PN2/PP3PPP/R2QKB1R b KQ -";
      string str1104 = "b7b6{16}";
      char[] chArray1104 = new char[1]{ ' ' };
      foreach (string move in str1104.Split(chArray1104))
        openingMove1104.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1104);
      OpeningMove openingMove1105 = new OpeningMove();
      openingMove1105.StartingFEN = "rnbqk2r/pp1p1ppp/4pn2/2p5/1bPP4/2N1P3/PP2NPPP/R1BQKB1R b KQkq -";
      string str1105 = "c5d4{5}";
      char[] chArray1105 = new char[1]{ ' ' };
      foreach (string move in str1105.Split(chArray1105))
        openingMove1105.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1105);
      OpeningMove openingMove1106 = new OpeningMove();
      openingMove1106.StartingFEN = "r2qkb1r/pb1n1ppp/2p1pn2/1p6/3P4/2NBPN2/PP3PPP/R1BQK2R w KQkq -";
      string str1106 = "e1g1{5}";
      char[] chArray1106 = new char[1]{ ' ' };
      foreach (string move in str1106.Split(chArray1106))
        openingMove1106.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1106);
      OpeningMove openingMove1107 = new OpeningMove();
      openingMove1107.StartingFEN = "r1bq1rk1/pp1n1ppp/2pbpn2/8/2pP4/2NBPN2/PPQ2PPP/R1B2RK1 w - -";
      string str1107 = "d3c4{10}";
      char[] chArray1107 = new char[1]{ ' ' };
      foreach (string move in str1107.Split(chArray1107))
        openingMove1107.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1107);
      OpeningMove openingMove1108 = new OpeningMove();
      openingMove1108.StartingFEN = "rnbqkb1r/pppp1ppp/4pn2/8/2P5/5NP1/PP1PPP1P/RNBQKB1R b KQkq -";
      string str1108 = "d7d5{5}";
      char[] chArray1108 = new char[1]{ ' ' };
      foreach (string move in str1108.Split(chArray1108))
        openingMove1108.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1108);
      OpeningMove openingMove1109 = new OpeningMove();
      openingMove1109.StartingFEN = "rnbqkb1r/pp3ppp/2p1pn2/8/2QP4/2N2N2/PP2PPPP/R1B1KB1R b KQkq -";
      string str1109 = "b7b5{5}";
      char[] chArray1109 = new char[1]{ ' ' };
      foreach (string move in str1109.Split(chArray1109))
        openingMove1109.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1109);
      OpeningMove openingMove1110 = new OpeningMove();
      openingMove1110.StartingFEN = "r1bq1rk1/2p1bppp/p2p1n2/np2p3/4P3/1BP2N1P/PP1P1PP1/RNBQR1K1 w - -";
      string str1110 = "b3c2{15}";
      char[] chArray1110 = new char[1]{ ' ' };
      foreach (string move in str1110.Split(chArray1110))
        openingMove1110.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1110);
      OpeningMove openingMove1111 = new OpeningMove();
      openingMove1111.StartingFEN = "rnbqkb1r/5ppp/p2ppn2/1p6/3NP3/2N1BP2/PPP3PP/R2QKB1R w KQkq b6";
      string str1111 = "g2g4{26}";
      char[] chArray1111 = new char[1]{ ' ' };
      foreach (string move in str1111.Split(chArray1111))
        openingMove1111.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1111);
      OpeningMove openingMove1112 = new OpeningMove();
      openingMove1112.StartingFEN = "r2qkb1r/3n1ppp/p2pbn2/1p2p3/4P1P1/1NN1BP2/PPP4P/R2QKB1R w KQkq b6";
      string str1112 = "g4g5{10}";
      char[] chArray1112 = new char[1]{ ' ' };
      foreach (string move in str1112.Split(chArray1112))
        openingMove1112.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1112);
      OpeningMove openingMove1113 = new OpeningMove();
      openingMove1113.StartingFEN = "rnbqkbnr/1p1p1ppp/p3p3/8/3pP3/2N2N2/PPP2PPP/R1BQKB1R w KQkq -";
      string str1113 = "f3d4{5}";
      char[] chArray1113 = new char[1]{ ' ' };
      foreach (string move in str1113.Split(chArray1113))
        openingMove1113.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1113);
      OpeningMove openingMove1114 = new OpeningMove();
      openingMove1114.StartingFEN = "rnbqk1nr/pp2ppbp/2pp2p1/8/3PPP2/2N5/PPP3PP/R1BQKBNR w KQkq -";
      string str1114 = "g1f3{5}";
      char[] chArray1114 = new char[1]{ ' ' };
      foreach (string move in str1114.Split(chArray1114))
        openingMove1114.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1114);
      OpeningMove openingMove1115 = new OpeningMove();
      openingMove1115.StartingFEN = "rn1qkbnr/ppp1pppp/8/3p4/6b1/5NP1/PPPPPPBP/RNBQK2R b KQkq -";
      string str1115 = "b8d7{5}";
      char[] chArray1115 = new char[1]{ ' ' };
      foreach (string move in str1115.Split(chArray1115))
        openingMove1115.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1115);
      OpeningMove openingMove1116 = new OpeningMove();
      openingMove1116.StartingFEN = "rn1qk2r/pb1pbppp/1p2pn2/2p5/2P5/2N2NP1/PP1PPPBP/R1BQ1RK1 w kq -";
      string str1116 = "f1e1{5}";
      char[] chArray1116 = new char[1]{ ' ' };
      foreach (string move in str1116.Split(chArray1116))
        openingMove1116.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1116);
      OpeningMove openingMove1117 = new OpeningMove();
      openingMove1117.StartingFEN = "rn1qkbnr/pp3ppp/2p1p3/3p1b2/2PP4/2N2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str1117 = "d1b3{5}";
      char[] chArray1117 = new char[1]{ ' ' };
      foreach (string move in str1117.Split(chArray1117))
        openingMove1117.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1117);
      OpeningMove openingMove1118 = new OpeningMove();
      openingMove1118.StartingFEN = "r1b1kb1r/pp1n1pp1/2p1pq1p/8/2BP4/2N1PN2/PP3PPP/R2QK2R b KQkq -";
      string str1118 = "g7g6{10}";
      char[] chArray1118 = new char[1]{ ' ' };
      foreach (string move in str1118.Split(chArray1118))
        openingMove1118.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1118);
      OpeningMove openingMove1119 = new OpeningMove();
      openingMove1119.StartingFEN = "rnbqkb1r/pp3p1p/3p1np1/2pP4/8/2N2N1P/PP2PPP1/R1BQKB1R b KQkq -";
      string str1119 = "f8g7{5} a7a6{10}";
      char[] chArray1119 = new char[1]{ ' ' };
      foreach (string move in str1119.Split(chArray1119))
        openingMove1119.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1119);
      OpeningMove openingMove1120 = new OpeningMove();
      openingMove1120.StartingFEN = "rnbqkb1r/pppppp1p/5np1/8/2P5/2N3P1/PP1PPP1P/R1BQKBNR b KQkq -";
      string str1120 = "f8g7{5}";
      char[] chArray1120 = new char[1]{ ' ' };
      foreach (string move in str1120.Split(chArray1120))
        openingMove1120.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1120);
      OpeningMove openingMove1121 = new OpeningMove();
      openingMove1121.StartingFEN = "rn1qkb1r/1p1b1ppp/p2ppn2/6B1/3NPP2/2N5/PPP3PP/R2QKB1R w KQkq -";
      string str1121 = "f4f5{5}";
      char[] chArray1121 = new char[1]{ ' ' };
      foreach (string move in str1121.Split(chArray1121))
        openingMove1121.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1121);
      OpeningMove openingMove1122 = new OpeningMove();
      openingMove1122.StartingFEN = "1rbqk2r/2pp1ppp/p1n2n2/1pb1p3/P3P3/1B3N2/1PPP1PPP/RNBQ1RK1 w k -";
      string str1122 = "c2c3{15} a4b5{5}";
      char[] chArray1122 = new char[1]{ ' ' };
      foreach (string move in str1122.Split(chArray1122))
        openingMove1122.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1122);
      OpeningMove openingMove1123 = new OpeningMove();
      openingMove1123.StartingFEN = "r1bqk2r/1p2bpp1/p1nppn1p/8/3NP3/2N1B3/PPPQ1PPP/2KR1B1R w kq -";
      string str1123 = "f2f3{5}";
      char[] chArray1123 = new char[1]{ ' ' };
      foreach (string move in str1123.Split(chArray1123))
        openingMove1123.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1123);
      OpeningMove openingMove1124 = new OpeningMove();
      openingMove1124.StartingFEN = "r2q1rk1/1bp1bppp/p1np1n2/1p2p3/4P3/1B1P1N1P/PPP2PP1/RNBQR1K1 w - -";
      string str1124 = "a2a3{16}";
      char[] chArray1124 = new char[1]{ ' ' };
      foreach (string move in str1124.Split(chArray1124))
        openingMove1124.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1124);
      OpeningMove openingMove1125 = new OpeningMove();
      openingMove1125.StartingFEN = "r1bqkb1r/pp3ppp/2np1n2/1N2p1B1/4P3/2N5/PPP2PPP/R2QKB1R b KQkq -";
      string str1125 = "a7a6{62}";
      char[] chArray1125 = new char[1]{ ' ' };
      foreach (string move in str1125.Split(chArray1125))
        openingMove1125.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1125);
      OpeningMove openingMove1126 = new OpeningMove();
      openingMove1126.StartingFEN = "r1bqkb1r/1p3ppp/p1np1n2/4p1B1/4P3/N1N5/PPP2PPP/R2QKB1R b KQkq -";
      string str1126 = "b7b5{57}";
      char[] chArray1126 = new char[1]{ ' ' };
      foreach (string move in str1126.Split(chArray1126))
        openingMove1126.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1126);
      OpeningMove openingMove1127 = new OpeningMove();
      openingMove1127.StartingFEN = "1rbqk2r/2pp1ppp/p1n2n2/1pb1p3/P3P3/1BP2N2/1P1P1PPP/RNBQ1RK1 b k -";
      string str1127 = "d7d6{5}";
      char[] chArray1127 = new char[1]{ ' ' };
      foreach (string move in str1127.Split(chArray1127))
        openingMove1127.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1127);
      OpeningMove openingMove1128 = new OpeningMove();
      openingMove1128.StartingFEN = "rnbq1rk1/ppp1ppbp/5np1/8/2pP4/5NP1/PP2PPBP/RNBQ1RK1 w - -";
      string str1128 = "b1a3{5}";
      char[] chArray1128 = new char[1]{ ' ' };
      foreach (string move in str1128.Split(chArray1128))
        openingMove1128.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1128);
      OpeningMove openingMove1129 = new OpeningMove();
      openingMove1129.StartingFEN = "rnbq1rk1/pp2bppp/4pn2/2Pp4/2P2B2/2N1PN2/PP3PPP/R2QKB1R b KQ -";
      string str1129 = "e7c5{16}";
      char[] chArray1129 = new char[1]{ ' ' };
      foreach (string move in str1129.Split(chArray1129))
        openingMove1129.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1129);
      OpeningMove openingMove1130 = new OpeningMove();
      openingMove1130.StartingFEN = "r2qkb1r/1p1n1pp1/p2pbn1p/4p3/4P1P1/1NN1BP2/PPP4P/R2QKB1R w KQkq -";
      string str1130 = "d1d2{6}";
      char[] chArray1130 = new char[1]{ ' ' };
      foreach (string move in str1130.Split(chArray1130))
        openingMove1130.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1130);
      OpeningMove openingMove1131 = new OpeningMove();
      openingMove1131.StartingFEN = "r1bqkbnr/pp1npppp/3p4/1Bp5/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str1131 = "d2d4{6}";
      char[] chArray1131 = new char[1]{ ' ' };
      foreach (string move in str1131.Split(chArray1131))
        openingMove1131.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1131);
      OpeningMove openingMove1132 = new OpeningMove();
      openingMove1132.StartingFEN = "rnbqk2r/ppp1ppbp/5np1/3p4/2PP4/6P1/PP2PPBP/RNBQK1NR w KQkq d6";
      string str1132 = "g1f3{6}";
      char[] chArray1132 = new char[1]{ ' ' };
      foreach (string move in str1132.Split(chArray1132))
        openingMove1132.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1132);
      OpeningMove openingMove1133 = new OpeningMove();
      openingMove1133.StartingFEN = "r1bqkb1r/5ppp/p1np1B2/1p2p3/4P3/N1N5/PPP2PPP/R2QKB1R b KQkq -";
      string str1133 = "g7f6{36}";
      char[] chArray1133 = new char[1]{ ' ' };
      foreach (string move in str1133.Split(chArray1133))
        openingMove1133.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1133);
      OpeningMove openingMove1134 = new OpeningMove();
      openingMove1134.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/8/3NP1P1/2N1B3/PPP2P1P/R2QKB1R b KQkq g3";
      string str1134 = "h7h6{5}";
      char[] chArray1134 = new char[1]{ ' ' };
      foreach (string move in str1134.Split(chArray1134))
        openingMove1134.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1134);
      OpeningMove openingMove1135 = new OpeningMove();
      openingMove1135.StartingFEN = "r1bqk1nr/pppp1ppp/2n5/2b1p3/2B1P3/2P2N2/PP1P1PPP/RNBQK2R b KQkq -";
      string str1135 = "g8f6{5}";
      char[] chArray1135 = new char[1]{ ' ' };
      foreach (string move in str1135.Split(chArray1135))
        openingMove1135.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1135);
      OpeningMove openingMove1136 = new OpeningMove();
      openingMove1136.StartingFEN = "rnb1kbnr/1p1p1ppp/pq2p3/8/3NP3/3B4/PPP2PPP/RNBQK2R w KQkq -";
      string str1136 = "d4b3{10}";
      char[] chArray1136 = new char[1]{ ' ' };
      foreach (string move in str1136.Split(chArray1136))
        openingMove1136.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1136);
      OpeningMove openingMove1137 = new OpeningMove();
      openingMove1137.StartingFEN = "r1bq1rk1/ppp1npbp/3p2p1/3Pp2n/1PP1P3/2N2N2/P3BPPP/R1BQR1K1 b - -";
      string str1137 = "f7f5{5}";
      char[] chArray1137 = new char[1]{ ' ' };
      foreach (string move in str1137.Split(chArray1137))
        openingMove1137.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1137);
      OpeningMove openingMove1138 = new OpeningMove();
      openingMove1138.StartingFEN = "r2qkb1r/1p1n1ppp/p2pbn2/4p3/4P3/1NN1B3/PPPQ1PPP/R3KB1R w KQkq -";
      string str1138 = "f2f3{15}";
      char[] chArray1138 = new char[1]{ ' ' };
      foreach (string move in str1138.Split(chArray1138))
        openingMove1138.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1138);
      OpeningMove openingMove1139 = new OpeningMove();
      openingMove1139.StartingFEN = "r1bqkb1r/5ppp/p1np1n2/1p2p1B1/4P3/N1N5/PPP2PPP/R2QKB1R w KQkq b6";
      string str1139 = "g5f6{45} c3d5{16}";
      char[] chArray1139 = new char[1]{ ' ' };
      foreach (string move in str1139.Split(chArray1139))
        openingMove1139.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1139);
      OpeningMove openingMove1140 = new OpeningMove();
      openingMove1140.StartingFEN = "rn1qkb1r/1p3ppp/p2pbn2/4p3/4P3/1NN1BP2/PPP3PP/R2QKB1R b KQkq -";
      string str1140 = "f8e7{10} b8d7{15} h7h5{5}";
      char[] chArray1140 = new char[1]{ ' ' };
      foreach (string move in str1140.Split(chArray1140))
        openingMove1140.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1140);
      OpeningMove openingMove1141 = new OpeningMove();
      openingMove1141.StartingFEN = "rnbqk2r/pp2ppbp/6p1/2p5/3PP3/2P2N2/P4PPP/R1BQKB1R w KQkq c6";
      string str1141 = "a1b1{15} h2h3{5} c1e3{15}";
      char[] chArray1141 = new char[1]{ ' ' };
      foreach (string move in str1141.Split(chArray1141))
        openingMove1141.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1141);
      OpeningMove openingMove1142 = new OpeningMove();
      openingMove1142.StartingFEN = "r2qrbk1/1bp2ppp/p1np1n2/1p1Pp3/4P3/1BP2N1P/PP1N1PP1/R1BQR1K1 b - -";
      string str1142 = "c6b8{5}";
      char[] chArray1142 = new char[1]{ ' ' };
      foreach (string move in str1142.Split(chArray1142))
        openingMove1142.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1142);
      OpeningMove openingMove1143 = new OpeningMove();
      openingMove1143.StartingFEN = "r1bqk2r/ppppbppp/2n5/1B2p3/3Pn3/5N2/PPP2PPP/RNBQ1RK1 w kq -";
      string str1143 = "d4e5{5} d1e2{5}";
      char[] chArray1143 = new char[1]{ ' ' };
      foreach (string move in str1143.Split(chArray1143))
        openingMove1143.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1143);
      OpeningMove openingMove1144 = new OpeningMove();
      openingMove1144.StartingFEN = "r1bq1rk1/pp2bppp/2nppn2/6B1/3NP3/2N2P2/PPPQ2PP/2KR1B1R b - -";
      string str1144 = "c6d4{5}";
      char[] chArray1144 = new char[1]{ ' ' };
      foreach (string move in str1144.Split(chArray1144))
        openingMove1144.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1144);
      OpeningMove openingMove1145 = new OpeningMove();
      openingMove1145.StartingFEN = "rnbqk2r/1p2ppb1/p2p3p/6p1/3NP1n1/2N3B1/PPP2PPP/R2QKB1R w KQkq -";
      string str1145 = "f1c4{5} f1e2{16} h2h3{26}";
      char[] chArray1145 = new char[1]{ ' ' };
      foreach (string move in str1145.Split(chArray1145))
        openingMove1145.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1145);
      OpeningMove openingMove1146 = new OpeningMove();
      openingMove1146.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/8/3NP3/2N1B3/PPP1BPPP/R2QK2R b KQkq -";
      string str1146 = "d8c7{10}";
      char[] chArray1146 = new char[1]{ ' ' };
      foreach (string move in str1146.Split(chArray1146))
        openingMove1146.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1146);
      OpeningMove openingMove1147 = new OpeningMove();
      openingMove1147.StartingFEN = "rnbqk2r/ppp1ppbp/6p1/8/3PP3/2n2N2/PP3PPP/R1BQKB1R w KQkq -";
      string str1147 = "b2c3{10}";
      char[] chArray1147 = new char[1]{ ' ' };
      foreach (string move in str1147.Split(chArray1147))
        openingMove1147.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1147);
      OpeningMove openingMove1148 = new OpeningMove();
      openingMove1148.StartingFEN = "rn1qk2r/p1p2ppp/bp1bpn2/3p4/2PP4/1P3NP1/P2BPPBP/RN1QK2R w KQkq -";
      string str1148 = "b1c3{5}";
      char[] chArray1148 = new char[1]{ ' ' };
      foreach (string move in str1148.Split(chArray1148))
        openingMove1148.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1148);
      OpeningMove openingMove1149 = new OpeningMove();
      openingMove1149.StartingFEN = "rnbq1rk1/pppp1ppp/4pn2/8/1bP5/P1N2N2/1PQPPPPP/R1B1KB1R b KQ -";
      string str1149 = "b4c3{15}";
      char[] chArray1149 = new char[1]{ ' ' };
      foreach (string move in str1149.Split(chArray1149))
        openingMove1149.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1149);
      OpeningMove openingMove1150 = new OpeningMove();
      openingMove1150.StartingFEN = "r1bqk2r/pp1n1pp1/2pbp2p/8/3Pn3/3B1N2/PPP1QPPP/R1B1K2R w KQkq -";
      string str1150 = "e2e4{6}";
      char[] chArray1150 = new char[1]{ ' ' };
      foreach (string move in str1150.Split(chArray1150))
        openingMove1150.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1150);
      OpeningMove openingMove1151 = new OpeningMove();
      openingMove1151.StartingFEN = "r1bqkbnr/pp1n1ppp/2p1p3/6N1/3P4/8/PPP2PPP/R1BQKBNR w KQkq -";
      string str1151 = "f1d3{5}";
      char[] chArray1151 = new char[1]{ ' ' };
      foreach (string move in str1151.Split(chArray1151))
        openingMove1151.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1151);
      OpeningMove openingMove1152 = new OpeningMove();
      openingMove1152.StartingFEN = "rnbq1rk1/p1p1bpp1/1p2pn1p/3p4/2PP3B/2N1PN2/PP2BPPP/R2QK2R b KQ -";
      string str1152 = "c8b7{5} b8d7{6}";
      char[] chArray1152 = new char[1]{ ' ' };
      foreach (string move in str1152.Split(chArray1152))
        openingMove1152.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1152);
      OpeningMove openingMove1153 = new OpeningMove();
      openingMove1153.StartingFEN = "r1bqkb1r/pp3ppp/2n1p3/2pn4/3P4/2N2NP1/PP2PP1P/R1BQKB1R w KQkq -";
      string str1153 = "f1g2{5}";
      char[] chArray1153 = new char[1]{ ' ' };
      foreach (string move in str1153.Split(chArray1153))
        openingMove1153.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1153);
      OpeningMove openingMove1154 = new OpeningMove();
      openingMove1154.StartingFEN = "r1bqkb1r/pp3ppp/2nppn2/8/2BNP3/2N1B3/PPP2PPP/R2QK2R b KQkq -";
      string str1154 = "f8e7{6}";
      char[] chArray1154 = new char[1]{ ' ' };
      foreach (string move in str1154.Split(chArray1154))
        openingMove1154.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1154);
      OpeningMove openingMove1155 = new OpeningMove();
      openingMove1155.StartingFEN = "rnbqk2r/ppppppbp/5np1/8/2P5/2N2NP1/PP1PPP1P/R1BQKB1R b KQkq -";
      string str1155 = "d7d6{5}";
      char[] chArray1155 = new char[1]{ ' ' };
      foreach (string move in str1155.Split(chArray1155))
        openingMove1155.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1155);
      OpeningMove openingMove1156 = new OpeningMove();
      openingMove1156.StartingFEN = "rn1qkbnr/pp2pppp/2p5/5b2/3P4/6N1/PPP2PPP/R1BQKBNR b KQkq -";
      string str1156 = "f5g6{10}";
      char[] chArray1156 = new char[1]{ ' ' };
      foreach (string move in str1156.Split(chArray1156))
        openingMove1156.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1156);
      OpeningMove openingMove1157 = new OpeningMove();
      openingMove1157.StartingFEN = "rnb1k2r/pp1pppbp/5np1/q1p5/2PP4/5NP1/PP2PPBP/RNBQK2R w KQkq -";
      string str1157 = "b1c3{6}";
      char[] chArray1157 = new char[1]{ ' ' };
      foreach (string move in str1157.Split(chArray1157))
        openingMove1157.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1157);
      OpeningMove openingMove1158 = new OpeningMove();
      openingMove1158.StartingFEN = "r1bqkb1r/5ppp/p1np1n2/1p1Np1B1/4P3/N7/PPP2PPP/R2QKB1R b KQkq -";
      string str1158 = "f8e7{11}";
      char[] chArray1158 = new char[1]{ ' ' };
      foreach (string move in str1158.Split(chArray1158))
        openingMove1158.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1158);
      OpeningMove openingMove1159 = new OpeningMove();
      openingMove1159.StartingFEN = "rn1qk2r/1p2bppp/p2pbn2/4p3/4P3/1NN1BP2/PPP3PP/R2QKB1R w KQkq -";
      string str1159 = "d1d2{5}";
      char[] chArray1159 = new char[1]{ ' ' };
      foreach (string move in str1159.Split(chArray1159))
        openingMove1159.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1159);
      OpeningMove openingMove1160 = new OpeningMove();
      openingMove1160.StartingFEN = "rnbq1rk1/pp1pppbp/2p2np1/8/2PP4/5NP1/PP2PPBP/RNBQK2R w KQ -";
      string str1160 = "b1c3{6}";
      char[] chArray1160 = new char[1]{ ' ' };
      foreach (string move in str1160.Split(chArray1160))
        openingMove1160.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1160);
      OpeningMove openingMove1161 = new OpeningMove();
      openingMove1161.StartingFEN = "rnb1kbnr/1pqp1ppp/p3p3/8/3NP3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
      string str1161 = "f1e2{6} f1d3{5}";
      char[] chArray1161 = new char[1]{ ' ' };
      foreach (string move in str1161.Split(chArray1161))
        openingMove1161.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1161);
      OpeningMove openingMove1162 = new OpeningMove();
      openingMove1162.StartingFEN = "rnbqk2r/ppp2ppp/4pn2/3p4/1bPP4/P1N5/1PQ1PPPP/R1B1KBNR b KQkq -";
      string str1162 = "b4c3{6}";
      char[] chArray1162 = new char[1]{ ' ' };
      foreach (string move in str1162.Split(chArray1162))
        openingMove1162.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1162);
      OpeningMove openingMove1163 = new OpeningMove();
      openingMove1163.StartingFEN = "r1bqkb1r/pp1ppppp/2n2n2/2p5/2P5/2N2NP1/PP1PPP1P/R1BQKB1R b KQkq -";
      string str1163 = "d7d5{10}";
      char[] chArray1163 = new char[1]{ ' ' };
      foreach (string move in str1163.Split(chArray1163))
        openingMove1163.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1163);
      OpeningMove openingMove1164 = new OpeningMove();
      openingMove1164.StartingFEN = "r1bq1rk1/ppp1ppbp/n4np1/8/2QPP3/2N2N2/PP2BPPP/R1B1K2R b KQ -";
      string str1164 = "c7c5{17}";
      char[] chArray1164 = new char[1]{ ' ' };
      foreach (string move in str1164.Split(chArray1164))
        openingMove1164.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1164);
      OpeningMove openingMove1165 = new OpeningMove();
      openingMove1165.StartingFEN = "rn1qkbnr/pp3pp1/2p1p1bp/8/3P3P/5NN1/PPP2PP1/R1BQKB1R w KQkq -";
      string str1165 = "f3e5{15}";
      char[] chArray1165 = new char[1]{ ' ' };
      foreach (string move in str1165.Split(chArray1165))
        openingMove1165.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1165);
      OpeningMove openingMove1166 = new OpeningMove();
      openingMove1166.StartingFEN = "r1bqkb1r/pp1ppppp/2n2n2/8/2PN4/8/PP2PPPP/RNBQKB1R w KQkq -";
      string str1166 = "b1c3{5}";
      char[] chArray1166 = new char[1]{ ' ' };
      foreach (string move in str1166.Split(chArray1166))
        openingMove1166.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1166);
      OpeningMove openingMove1167 = new OpeningMove();
      openingMove1167.StartingFEN = "r1bqkb1r/pp3ppp/2np1n2/4p3/3NP3/2N2P2/PPP3PP/R1BQKB1R w KQkq e6";
      string str1167 = "d4b3{10}";
      char[] chArray1167 = new char[1]{ ' ' };
      foreach (string move in str1167.Split(chArray1167))
        openingMove1167.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1167);
      OpeningMove openingMove1168 = new OpeningMove();
      openingMove1168.StartingFEN = "rnbq1rk1/pp1p1ppp/4pn2/2P5/1bP5/2N5/PPQ1PPPP/R1B1KBNR w KQ -";
      string str1168 = "a2a3{10}";
      char[] chArray1168 = new char[1]{ ' ' };
      foreach (string move in str1168.Split(chArray1168))
        openingMove1168.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1168);
      OpeningMove openingMove1169 = new OpeningMove();
      openingMove1169.StartingFEN = "rnbq1rk1/pp1p1ppp/4pn2/2b5/2P5/P1N5/1PQ1PPPP/R1B1KBNR w KQ -";
      string str1169 = "g1f3{5}";
      char[] chArray1169 = new char[1]{ ' ' };
      foreach (string move in str1169.Split(chArray1169))
        openingMove1169.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1169);
      OpeningMove openingMove1170 = new OpeningMove();
      openingMove1170.StartingFEN = "rn1qkb1r/pppbpp1p/5np1/3p4/Q1P5/2N2N2/PP1PPPPP/R1B1KB1R w KQkq -";
      string str1170 = "a4b3{5}";
      char[] chArray1170 = new char[1]{ ' ' };
      foreach (string move in str1170.Split(chArray1170))
        openingMove1170.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1170);
      OpeningMove openingMove1171 = new OpeningMove();
      openingMove1171.StartingFEN = "r1bqkbnr/pp1p1ppp/2n1p3/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R w KQkq -";
      string str1171 = "d2d4{5}";
      char[] chArray1171 = new char[1]{ ' ' };
      foreach (string move in str1171.Split(chArray1171))
        openingMove1171.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1171);
      OpeningMove openingMove1172 = new OpeningMove();
      openingMove1172.StartingFEN = "r1bqkbnr/ppp2ppp/2np4/1B2p3/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str1172 = "e1g1{5}";
      char[] chArray1172 = new char[1]{ ' ' };
      foreach (string move in str1172.Split(chArray1172))
        openingMove1172.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1172);
      OpeningMove openingMove1173 = new OpeningMove();
      openingMove1173.StartingFEN = "r1bqkbnr/pp1p1ppp/2n5/2p1p3/4P3/2N2N2/PPPP1PPP/R1BQKB1R w KQkq e6";
      string str1173 = "f1c4{5}";
      char[] chArray1173 = new char[1]{ ' ' };
      foreach (string move in str1173.Split(chArray1173))
        openingMove1173.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1173);
      OpeningMove openingMove1174 = new OpeningMove();
      openingMove1174.StartingFEN = "rnbqk1nr/bp1p1ppp/p3p3/8/4P3/1N1B4/PPP2PPP/RNBQK2R w KQkq -";
      string str1174 = "c2c4{5}";
      char[] chArray1174 = new char[1]{ ' ' };
      foreach (string move in str1174.Split(chArray1174))
        openingMove1174.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1174);
      OpeningMove openingMove1175 = new OpeningMove();
      openingMove1175.StartingFEN = "rnbqkbnr/pppp1ppp/4p3/8/8/5N2/PPPPPPPP/RNBQKB1R w KQkq -";
      string str1175 = "c2c4{5}";
      char[] chArray1175 = new char[1]{ ' ' };
      foreach (string move in str1175.Split(chArray1175))
        openingMove1175.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1175);
      OpeningMove openingMove1176 = new OpeningMove();
      openingMove1176.StartingFEN = "r2qk2r/ppp1bppp/2n5/3p4/3Pn1b1/3B1N2/PPP2PPP/RNBQR1K1 w kq -";
      string str1176 = "c2c3{15}";
      char[] chArray1176 = new char[1]{ ' ' };
      foreach (string move in str1176.Split(chArray1176))
        openingMove1176.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1176);
      OpeningMove openingMove1177 = new OpeningMove();
      openingMove1177.StartingFEN = "r1bqk2r/ppp1bppp/8/3p4/1nPPn3/3B1N2/PP3PPP/RNBQ1RK1 w kq -";
      string str1177 = "d3e2{51} f1e1{5} c4d5{5}";
      char[] chArray1177 = new char[1]{ ' ' };
      foreach (string move in str1177.Split(chArray1177))
        openingMove1177.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1177);
      OpeningMove openingMove1178 = new OpeningMove();
      openingMove1178.StartingFEN = "r1bq1rk1/pp2ppbp/2n3p1/2p5/2BPP3/2P1B3/P3NPPP/R2QK2R w KQ -";
      string str1178 = "e1g1{10}";
      char[] chArray1178 = new char[1]{ ' ' };
      foreach (string move in str1178.Split(chArray1178))
        openingMove1178.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1178);
      OpeningMove openingMove1179 = new OpeningMove();
      openingMove1179.StartingFEN = "r1bq1rk1/1pp1npbp/3p1np1/3Pp3/1pP1P3/B1N2N2/P3BPPP/R2Q1RK1 w - -";
      string str1179 = "a3b4{5}";
      char[] chArray1179 = new char[1]{ ' ' };
      foreach (string move in str1179.Split(chArray1179))
        openingMove1179.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1179);
      OpeningMove openingMove1180 = new OpeningMove();
      openingMove1180.StartingFEN = "rnbqkb1r/pp2pppp/8/2p5/3P4/2n2N2/PP2PPPP/R1BQKB1R w KQkq -";
      string str1180 = "b2c3{10}";
      char[] chArray1180 = new char[1]{ ' ' };
      foreach (string move in str1180.Split(chArray1180))
        openingMove1180.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1180);
      OpeningMove openingMove1181 = new OpeningMove();
      openingMove1181.StartingFEN = "r1bq1rk1/5ppp/p1pb4/1p1nR3/8/1BPP4/PP3PPP/RNBQ2K1 w - -";
      string str1181 = "e5e1{5}";
      char[] chArray1181 = new char[1]{ ' ' };
      foreach (string move in str1181.Split(chArray1181))
        openingMove1181.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1181);
      OpeningMove openingMove1182 = new OpeningMove();
      openingMove1182.StartingFEN = "r1bqkb1r/ppp2ppp/2pn4/4p3/3P4/5N2/PPP2PPP/RNBQ1RK1 w kq -";
      string str1182 = "d4e5{45}";
      char[] chArray1182 = new char[1]{ ' ' };
      foreach (string move in str1182.Split(chArray1182))
        openingMove1182.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1182);
      OpeningMove openingMove1183 = new OpeningMove();
      openingMove1183.StartingFEN = "rnbq1rk1/ppp2ppp/4pn2/3p4/1bPPP3/2N5/PPQ2PPP/R1B1KBNR w KQ d6";
      string str1183 = "e4e5{5}";
      char[] chArray1183 = new char[1]{ ' ' };
      foreach (string move in str1183.Split(chArray1183))
        openingMove1183.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1183);
      OpeningMove openingMove1184 = new OpeningMove();
      openingMove1184.StartingFEN = "rnbqkb1r/pp2pppp/2p2n2/8/2pP4/2N1PN2/PP3PPP/R1BQKB1R b KQkq -";
      string str1184 = "b7b5{6}";
      char[] chArray1184 = new char[1]{ ' ' };
      foreach (string move in str1184.Split(chArray1184))
        openingMove1184.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1184);
      OpeningMove openingMove1185 = new OpeningMove();
      openingMove1185.StartingFEN = "rn1qk2r/p1ppbppp/bp2pn2/8/2PP4/1PN2NP1/P2BPP1P/R2QKB1R b KQkq -";
      string str1185 = "e8g8{5}";
      char[] chArray1185 = new char[1]{ ' ' };
      foreach (string move in str1185.Split(chArray1185))
        openingMove1185.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1185);
      OpeningMove openingMove1186 = new OpeningMove();
      openingMove1186.StartingFEN = "r1bqkb1r/pppn1ppp/8/3pN3/3Pn3/3B4/PPP2PPP/RNBQK2R w KQkq -";
      string str1186 = "e5d7{11}";
      char[] chArray1186 = new char[1]{ ' ' };
      foreach (string move in str1186.Split(chArray1186))
        openingMove1186.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1186);
      OpeningMove openingMove1187 = new OpeningMove();
      openingMove1187.StartingFEN = "rnbq1rk1/2pnppbp/p5p1/1p2P3/3P4/1QN2N2/PP3PPP/R1B1KB1R w KQ -";
      string str1187 = "e5e6{11} h2h4{10}";
      char[] chArray1187 = new char[1]{ ' ' };
      foreach (string move in str1187.Split(chArray1187))
        openingMove1187.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1187);
      OpeningMove openingMove1188 = new OpeningMove();
      openingMove1188.StartingFEN = "rnbqkb1r/p2ppppp/1p3n2/2p5/2P5/5NP1/PP1PPP1P/RNBQKB1R w KQkq c6";
      string str1188 = "f1g2{10}";
      char[] chArray1188 = new char[1]{ ' ' };
      foreach (string move in str1188.Split(chArray1188))
        openingMove1188.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1188);
      OpeningMove openingMove1189 = new OpeningMove();
      openingMove1189.StartingFEN = "rnbqkb1r/ppp1pp1p/5np1/3p4/Q1P5/2N2N2/PP1PPPPP/R1B1KB1R b KQkq -";
      string str1189 = "c8d7{5}";
      char[] chArray1189 = new char[1]{ ' ' };
      foreach (string move in str1189.Split(chArray1189))
        openingMove1189.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1189);
      OpeningMove openingMove1190 = new OpeningMove();
      openingMove1190.StartingFEN = "r2qkb1r/3n1ppp/p2pbn2/4p1P1/1p2P3/1NN1BP2/PPP4P/R2QKB1R w KQkq -";
      string str1190 = "c3e2{5}";
      char[] chArray1190 = new char[1]{ ' ' };
      foreach (string move in str1190.Split(chArray1190))
        openingMove1190.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1190);
      OpeningMove openingMove1191 = new OpeningMove();
      openingMove1191.StartingFEN = "r1bqkb1r/ppp2ppp/2p5/4Pn2/8/5N2/PPP2PPP/RNBQ1RK1 w kq -";
      string str1191 = "d1d8{35}";
      char[] chArray1191 = new char[1]{ ' ' };
      foreach (string move in str1191.Split(chArray1191))
        openingMove1191.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1191);
      OpeningMove openingMove1192 = new OpeningMove();
      openingMove1192.StartingFEN = "rnbqkb1r/pp3ppp/4pn2/2p5/2BP4/4PN2/PP3PPP/RNBQK2R w KQkq c6";
      string str1192 = "e1g1{35}";
      char[] chArray1192 = new char[1]{ ' ' };
      foreach (string move in str1192.Split(chArray1192))
        openingMove1192.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1192);
      OpeningMove openingMove1193 = new OpeningMove();
      openingMove1193.StartingFEN = "rnbq1rk1/1p2bppp/p2p1n2/4p3/4P3/1NN5/PPP1BPPP/R1BQ1R1K b - -";
      string str1193 = "b7b6{5}";
      char[] chArray1193 = new char[1]{ ' ' };
      foreach (string move in str1193.Split(chArray1193))
        openingMove1193.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1193);
      OpeningMove openingMove1194 = new OpeningMove();
      openingMove1194.StartingFEN = "r2qkb1r/2p2ppp/p1n1b3/1pnpP3/8/1BP2N2/PP1N1PPP/R1BQ1RK1 b kq -";
      string str1194 = "d5d4{5}";
      char[] chArray1194 = new char[1]{ ' ' };
      foreach (string move in str1194.Split(chArray1194))
        openingMove1194.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1194);
      OpeningMove openingMove1195 = new OpeningMove();
      openingMove1195.StartingFEN = "r1bq1rk1/2p1bppp/p1n2n2/1p1Pp3/8/1BP2N2/PP1P1PPP/RNBQR1K1 b - -";
      string str1195 = "f6d5{15}";
      char[] chArray1195 = new char[1]{ ' ' };
      foreach (string move in str1195.Split(chArray1195))
        openingMove1195.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1195);
      OpeningMove openingMove1196 = new OpeningMove();
      openingMove1196.StartingFEN = "r1bqk2r/2pp1ppp/p1n2n2/1pb1p3/B3P3/2P2N2/PP1P1PPP/RNBQ1RK1 w kq b6";
      string str1196 = "a4c2{25} d2d4{5} a4b3{5}";
      char[] chArray1196 = new char[1]{ ' ' };
      foreach (string move in str1196.Split(chArray1196))
        openingMove1196.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1196);
      OpeningMove openingMove1197 = new OpeningMove();
      openingMove1197.StartingFEN = "rnbqk2r/ppp1nppp/4p3/3pP3/3P4/P1b5/1PP2PPP/R1BQKBNR w KQkq -";
      string str1197 = "b2c3{5}";
      char[] chArray1197 = new char[1]{ ' ' };
      foreach (string move in str1197.Split(chArray1197))
        openingMove1197.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1197);
      OpeningMove openingMove1198 = new OpeningMove();
      openingMove1198.StartingFEN = "r2qk2r/ppp1b1pp/2n5/3p1p2/3Pn1b1/2PB1N2/PP3PPP/RNBQR1K1 w kq f6";
      string str1198 = "d1b3{5}";
      char[] chArray1198 = new char[1]{ ' ' };
      foreach (string move in str1198.Split(chArray1198))
        openingMove1198.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1198);
      OpeningMove openingMove1199 = new OpeningMove();
      openingMove1199.StartingFEN = "rnbqkb1r/p3pp1p/2pp1np1/1p6/3PP3/2N1BP2/PPP3PP/R2QKBNR w KQkq b6";
      string str1199 = "g2g4{5}";
      char[] chArray1199 = new char[1]{ ' ' };
      foreach (string move in str1199.Split(chArray1199))
        openingMove1199.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1199);
      OpeningMove openingMove1200 = new OpeningMove();
      openingMove1200.StartingFEN = "1rbqk2r/2p2ppp/p1np1n2/1pb1p3/P3P3/1BP2N2/1P1P1PPP/RNBQ1RK1 w k -";
      string str1200 = "d2d4{5}";
      char[] chArray1200 = new char[1]{ ' ' };
      foreach (string move in str1200.Split(chArray1200))
        openingMove1200.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1200);
      OpeningMove openingMove1201 = new OpeningMove();
      openingMove1201.StartingFEN = "r1bqkbnr/1ppp1p1p/p1n3p1/1B2p3/4P3/2P2N2/PP1P1PPP/RNBQK2R w KQkq -";
      string str1201 = "b5a4{5}";
      char[] chArray1201 = new char[1]{ ' ' };
      foreach (string move in str1201.Split(chArray1201))
        openingMove1201.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1201);
      OpeningMove openingMove1202 = new OpeningMove();
      openingMove1202.StartingFEN = "rnbqkb1r/ppp1pp1p/6p1/3n4/4P3/2N2N2/PP1P1PPP/R1BQKB1R b KQkq e3";
      string str1202 = "d5c3{5}";
      char[] chArray1202 = new char[1]{ ' ' };
      foreach (string move in str1202.Split(chArray1202))
        openingMove1202.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1202);
      OpeningMove openingMove1203 = new OpeningMove();
      openingMove1203.StartingFEN = "rnbq1rk1/pp2ppbp/3p1np1/8/3NP3/2N1BP2/PPP3PP/R2QKB1R w KQ -";
      string str1203 = "d1d2{10}";
      char[] chArray1203 = new char[1]{ ' ' };
      foreach (string move in str1203.Split(chArray1203))
        openingMove1203.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1203);
      OpeningMove openingMove1204 = new OpeningMove();
      openingMove1204.StartingFEN = "rnbq1rk1/ppppppbp/5np1/8/2PP4/5NP1/PP2PPBP/RNBQK2R b KQ d3";
      string str1204 = "d7d6{5}";
      char[] chArray1204 = new char[1]{ ' ' };
      foreach (string move in str1204.Split(chArray1204))
        openingMove1204.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1204);
      OpeningMove openingMove1205 = new OpeningMove();
      openingMove1205.StartingFEN = "r2qkb1r/1p1n1pp1/p2pbn2/4p2p/4P3/1NN1BP2/PPPQ2PP/R3KB1R w KQkq h6";
      string str1205 = "a2a4{5}";
      char[] chArray1205 = new char[1]{ ' ' };
      foreach (string move in str1205.Split(chArray1205))
        openingMove1205.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1205);
      OpeningMove openingMove1206 = new OpeningMove();
      openingMove1206.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/3p2B1/3PP3/2N5/PPP2PPP/R2QKBNR b KQkq -";
      string str1206 = "d5e4{30} f8b4{5} f8e7{5}";
      char[] chArray1206 = new char[1]{ ' ' };
      foreach (string move in str1206.Split(chArray1206))
        openingMove1206.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1206);
      OpeningMove openingMove1207 = new OpeningMove();
      openingMove1207.StartingFEN = "r1bqkb1r/pp3ppp/2nppn2/8/3NP3/2N5/PPP1BPPP/R1BQK2R w KQkq -";
      string str1207 = "e1g1{5}";
      char[] chArray1207 = new char[1]{ ' ' };
      foreach (string move in str1207.Split(chArray1207))
        openingMove1207.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1207);
      OpeningMove openingMove1208 = new OpeningMove();
      openingMove1208.StartingFEN = "rn1q1rk1/pbpp1pp1/1p2pn1p/6B1/2PP4/P1Q2P2/1P2P1PP/R3KBNR w KQ -";
      string str1208 = "g5h4{15}";
      char[] chArray1208 = new char[1]{ ' ' };
      foreach (string move in str1208.Split(chArray1208))
        openingMove1208.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1208);
      OpeningMove openingMove1209 = new OpeningMove();
      openingMove1209.StartingFEN = "r1bk1b1r/ppp2ppp/2p5/4Pn2/8/5N2/PPP2PPP/RNB2RK1 w - -";
      string str1209 = "b1c3{25}";
      char[] chArray1209 = new char[1]{ ' ' };
      foreach (string move in str1209.Split(chArray1209))
        openingMove1209.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1209);
      OpeningMove openingMove1210 = new OpeningMove();
      openingMove1210.StartingFEN = "r1bqkb1r/pp3ppp/2n1pn2/2p5/2BP4/4PN2/PP3PPP/RNBQ1RK1 w kq -";
      string str1210 = "d1e2{15}";
      char[] chArray1210 = new char[1]{ ' ' };
      foreach (string move in str1210.Split(chArray1210))
        openingMove1210.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1210);
      OpeningMove openingMove1211 = new OpeningMove();
      openingMove1211.StartingFEN = "rnbqk2r/pp1p1ppp/4pn2/2P5/1bP5/2N5/PPQ1PPPP/R1B1KBNR b KQkq -";
      string str1211 = "e8g8{5}";
      char[] chArray1211 = new char[1]{ ' ' };
      foreach (string move in str1211.Split(chArray1211))
        openingMove1211.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1211);
      OpeningMove openingMove1212 = new OpeningMove();
      openingMove1212.StartingFEN = "r1bqkb1r/1p3ppp/p1n1pn2/2p5/2BP4/4PN2/PP2QPPP/RNB2RK1 w kq -";
      string str1212 = "a2a3{5}";
      char[] chArray1212 = new char[1]{ ' ' };
      foreach (string move in str1212.Split(chArray1212))
        openingMove1212.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1212);
      OpeningMove openingMove1213 = new OpeningMove();
      openingMove1213.StartingFEN = "rnbqk2r/ppp1bppp/4pn2/6B1/3PN3/8/PPP2PPP/R2QKBNR w KQkq -";
      string str1213 = "g5f6{42}";
      char[] chArray1213 = new char[1]{ ' ' };
      foreach (string move in str1213.Split(chArray1213))
        openingMove1213.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1213);
      OpeningMove openingMove1214 = new OpeningMove();
      openingMove1214.StartingFEN = "rnbqk2r/ppp1ppbp/5np1/3p2B1/2PP4/2N5/PP2PPPP/R2QKBNR w KQkq -";
      string str1214 = "g1f3{5}";
      char[] chArray1214 = new char[1]{ ' ' };
      foreach (string move in str1214.Split(chArray1214))
        openingMove1214.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1214);
      OpeningMove openingMove1215 = new OpeningMove();
      openingMove1215.StartingFEN = "rnbq1rk1/pppp1ppp/4pn2/8/2P5/P1Q2N2/1P1PPPPP/R1B1KB1R b KQ -";
      string str1215 = "b7b6{10}";
      char[] chArray1215 = new char[1]{ ' ' };
      foreach (string move in str1215.Split(chArray1215))
        openingMove1215.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1215);
      OpeningMove openingMove1216 = new OpeningMove();
      openingMove1216.StartingFEN = "rnbqkb1r/ppp1pppp/3p1n2/8/3PP3/2N5/PPP2PPP/R1BQKBNR b KQkq -";
      string str1216 = "g7g6{5}";
      char[] chArray1216 = new char[1]{ ' ' };
      foreach (string move in str1216.Split(chArray1216))
        openingMove1216.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1216);
      OpeningMove openingMove1217 = new OpeningMove();
      openingMove1217.StartingFEN = "r1bqk1nr/pppp1ppp/2n5/2b1p3/1PB1P3/5N2/P1PP1PPP/RNBQK2R b KQkq b3";
      string str1217 = "c5b6{5} c5b4{5}";
      char[] chArray1217 = new char[1]{ ' ' };
      foreach (string move in str1217.Split(chArray1217))
        openingMove1217.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1217);
      OpeningMove openingMove1218 = new OpeningMove();
      openingMove1218.StartingFEN = "r1bq1rk1/2ppbppp/p1n2n2/1p2p3/P3P3/1B3N2/1PPP1PPP/RNBQR1K1 b - a3";
      string str1218 = "b5b4{5}";
      char[] chArray1218 = new char[1]{ ' ' };
      foreach (string move in str1218.Split(chArray1218))
        openingMove1218.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1218);
      OpeningMove openingMove1219 = new OpeningMove();
      openingMove1219.StartingFEN = "rnbqkb1r/1p2pppp/p2p1n2/8/3NP3/2N2P2/PPP3PP/R1BQKB1R b KQkq -";
      string str1219 = "e7e6{17} d8b6{11}";
      char[] chArray1219 = new char[1]{ ' ' };
      foreach (string move in str1219.Split(chArray1219))
        openingMove1219.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1219);
      OpeningMove openingMove1220 = new OpeningMove();
      openingMove1220.StartingFEN = "rnbqkb1r/1p2pppp/p2p1n2/8/3NP3/2N5/PPP2PPP/R1BQKBR1 b Qkq -";
      string str1220 = "b7b5{10}";
      char[] chArray1220 = new char[1]{ ' ' };
      foreach (string move in str1220.Split(chArray1220))
        openingMove1220.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1220);
      OpeningMove openingMove1221 = new OpeningMove();
      openingMove1221.StartingFEN = "rnbqkb1r/pppppppp/5n2/4P3/8/8/PPPP1PPP/RNBQKBNR b KQkq -";
      string str1221 = "f6d5{5}";
      char[] chArray1221 = new char[1]{ ' ' };
      foreach (string move in str1221.Split(chArray1221))
        openingMove1221.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1221);
      OpeningMove openingMove1222 = new OpeningMove();
      openingMove1222.StartingFEN = "rnbqkb1r/1p3pp1/p2ppn1p/8/3NP1P1/2N1B3/PPP2P1P/R2QKB1R w KQkq -";
      string str1222 = "f1g2{5}";
      char[] chArray1222 = new char[1]{ ' ' };
      foreach (string move in str1222.Split(chArray1222))
        openingMove1222.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1222);
      OpeningMove openingMove1223 = new OpeningMove();
      openingMove1223.StartingFEN = "rnbqkbnr/pp2pppp/3p4/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R b KQkq -";
      string str1223 = "g8f6{5}";
      char[] chArray1223 = new char[1]{ ' ' };
      foreach (string move in str1223.Split(chArray1223))
        openingMove1223.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1223);
      OpeningMove openingMove1224 = new OpeningMove();
      openingMove1224.StartingFEN = "r1b1kbnr/ppp1pppp/2n5/3q4/3P4/8/PP2PPPP/RNBQKBNR w KQkq -";
      string str1224 = "e2e3{5}";
      char[] chArray1224 = new char[1]{ ' ' };
      foreach (string move in str1224.Split(chArray1224))
        openingMove1224.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1224);
      OpeningMove openingMove1225 = new OpeningMove();
      openingMove1225.StartingFEN = "r1bqk2r/2pp1ppp/p1n2n2/1pb1p3/4P3/2P2N2/PPBP1PPP/RNBQ1RK1 b kq -";
      string str1225 = "d7d6{5} d7d5{5}";
      char[] chArray1225 = new char[1]{ ' ' };
      foreach (string move in str1225.Split(chArray1225))
        openingMove1225.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1225);
      OpeningMove openingMove1226 = new OpeningMove();
      openingMove1226.StartingFEN = "rnbqkb1r/4pppp/p2p1n2/1p6/3NP1P1/2N5/PPP2P1P/R1BQKBR1 b Qkq g3";
      string str1226 = "c8b7{5}";
      char[] chArray1226 = new char[1]{ ' ' };
      foreach (string move in str1226.Split(chArray1226))
        openingMove1226.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1226);
      OpeningMove openingMove1227 = new OpeningMove();
      openingMove1227.StartingFEN = "rnbq1rk1/1pp1ppbp/p4np1/8/2QPP3/2N2N2/PP2BPPP/R1B1K2R b KQ -";
      string str1227 = "b7b5{5}";
      char[] chArray1227 = new char[1]{ ' ' };
      foreach (string move in str1227.Split(chArray1227))
        openingMove1227.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1227);
      OpeningMove openingMove1228 = new OpeningMove();
      openingMove1228.StartingFEN = "r1bqk2r/ppp1bppp/2n5/3p4/3Pn3/3B1N2/PPP2PPP/RNBQR1K1 b kq -";
      string str1228 = "c8g4{10} c8f5{5}";
      char[] chArray1228 = new char[1]{ ' ' };
      foreach (string move in str1228.Split(chArray1228))
        openingMove1228.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1228);
      OpeningMove openingMove1229 = new OpeningMove();
      openingMove1229.StartingFEN = "r1bq1rk1/4bppp/p2p1n2/npp1p3/4P3/2P2N1P/PPBP1PP1/RNBQR1K1 w - c6";
      string str1229 = "d2d4{10}";
      char[] chArray1229 = new char[1]{ ' ' };
      foreach (string move in str1229.Split(chArray1229))
        openingMove1229.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1229);
      OpeningMove openingMove1230 = new OpeningMove();
      openingMove1230.StartingFEN = "r2qkb1r/pppb1ppp/8/3p4/3Pn3/3B4/PPP2PPP/RNBQK2R w KQkq -";
      string str1230 = "e1g1{6}";
      char[] chArray1230 = new char[1]{ ' ' };
      foreach (string move in str1230.Split(chArray1230))
        openingMove1230.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1230);
      OpeningMove openingMove1231 = new OpeningMove();
      openingMove1231.StartingFEN = "rnbqk2r/ppp1ppbp/3p1np1/8/3PP3/2N1B3/PPP2PPP/R2QKBNR w KQkq -";
      string str1231 = "d1d2{6}";
      char[] chArray1231 = new char[1]{ ' ' };
      foreach (string move in str1231.Split(chArray1231))
        openingMove1231.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1231);
      OpeningMove openingMove1232 = new OpeningMove();
      openingMove1232.StartingFEN = "rnbqkb1r/pp2pp1p/6p1/2p5/3P4/2P2N2/P3PPPP/R1BQKB1R w KQkq -";
      string str1232 = "e2e4{5}";
      char[] chArray1232 = new char[1]{ ' ' };
      foreach (string move in str1232.Split(chArray1232))
        openingMove1232.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1232);
      OpeningMove openingMove1233 = new OpeningMove();
      openingMove1233.StartingFEN = "rnbqk2r/ppp2ppp/3ppn2/8/1bPP4/2N5/PPQ1PPPP/R1B1KBNR w KQkq -";
      string str1233 = "c1g5{5}";
      char[] chArray1233 = new char[1]{ ' ' };
      foreach (string move in str1233.Split(chArray1233))
        openingMove1233.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1233);
      OpeningMove openingMove1234 = new OpeningMove();
      openingMove1234.StartingFEN = "rnbqk2r/pp2ppbp/5np1/2Pp4/2P2B2/2N1P3/PP3PPP/R2QKBNR b KQkq -";
      string str1234 = "d8a5{5}";
      char[] chArray1234 = new char[1]{ ' ' };
      foreach (string move in str1234.Split(chArray1234))
        openingMove1234.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1234);
      OpeningMove openingMove1235 = new OpeningMove();
      openingMove1235.StartingFEN = "rnbqkbnr/pp1ppp1p/6p1/2p5/4P3/2N5/PPPP1PPP/R1BQKBNR w KQkq -";
      string str1235 = "g1f3{5}";
      char[] chArray1235 = new char[1]{ ' ' };
      foreach (string move in str1235.Split(chArray1235))
        openingMove1235.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1235);
      OpeningMove openingMove1236 = new OpeningMove();
      openingMove1236.StartingFEN = "rnbqkb1r/ppp2ppp/5n2/3pp3/2P5/6P1/PP1PPPBP/RNBQK1NR w KQkq d6";
      string str1236 = "c4d5{10}";
      char[] chArray1236 = new char[1]{ ' ' };
      foreach (string move in str1236.Split(chArray1236))
        openingMove1236.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1236);
      OpeningMove openingMove1237 = new OpeningMove();
      openingMove1237.StartingFEN = "rnbqkb1r/pp2pppp/5n2/2pP4/8/2N2N2/PP1PPPPP/R1BQKB1R b KQkq -";
      string str1237 = "f6d5{6}";
      char[] chArray1237 = new char[1]{ ' ' };
      foreach (string move in str1237.Split(chArray1237))
        openingMove1237.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1237);
      OpeningMove openingMove1238 = new OpeningMove();
      openingMove1238.StartingFEN = "rnbq1rk1/2pnp1bp/p3p1p1/1p6/3P4/1QN2N2/PP3PPP/R1B1KB1R w KQ -";
      string str1238 = "c1e3{6}";
      char[] chArray1238 = new char[1]{ ' ' };
      foreach (string move in str1238.Split(chArray1238))
        openingMove1238.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1238);
      OpeningMove openingMove1239 = new OpeningMove();
      openingMove1239.StartingFEN = "r1bqk2r/4bppp/p1np1n2/1p1Np1B1/4P3/N7/PPP2PPP/R2QKB1R w KQkq -";
      string str1239 = "g5f6{11}";
      char[] chArray1239 = new char[1]{ ' ' };
      foreach (string move in str1239.Split(chArray1239))
        openingMove1239.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1239);
      OpeningMove openingMove1240 = new OpeningMove();
      openingMove1240.StartingFEN = "r1bqkb1r/pppp1ppp/2n2n2/1B2p3/4P3/5N2/PPPP1PPP/RNBQ1RK1 b kq -";
      string str1240 = "f6e4{35} f8c5{5}";
      char[] chArray1240 = new char[1]{ ' ' };
      foreach (string move in str1240.Split(chArray1240))
        openingMove1240.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1240);
      OpeningMove openingMove1241 = new OpeningMove();
      openingMove1241.StartingFEN = "r1bqkb1r/5p1p/p1np1p2/1p2p3/4P3/N1N5/PPP2PPP/R2QKB1R w KQkq -";
      string str1241 = "c3d5{40}";
      char[] chArray1241 = new char[1]{ ' ' };
      foreach (string move in str1241.Split(chArray1241))
        openingMove1241.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1241);
      OpeningMove openingMove1242 = new OpeningMove();
      openingMove1242.StartingFEN = "rnbqk2r/1p2ppb1/p2p4/6pp/3NP1B1/2N3B1/PPP2PPP/R2QK2R b KQkq -";
      string str1242 = "h5g4{11}";
      char[] chArray1242 = new char[1]{ ' ' };
      foreach (string move in str1242.Split(chArray1242))
        openingMove1242.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1242);
      OpeningMove openingMove1243 = new OpeningMove();
      openingMove1243.StartingFEN = "r1bqkb1r/pp2pppp/2n2n2/3p4/2Pp4/2N2NP1/PP2PP1P/R1BQKB1R w KQkq -";
      string str1243 = "f3d4{5}";
      char[] chArray1243 = new char[1]{ ' ' };
      foreach (string move in str1243.Split(chArray1243))
        openingMove1243.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1243);
      OpeningMove openingMove1244 = new OpeningMove();
      openingMove1244.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/3pP3/3P4/2N5/PPP2PPP/R1BQKBNR b KQkq -";
      string str1244 = "f6d7{10}";
      char[] chArray1244 = new char[1]{ ' ' };
      foreach (string move in str1244.Split(chArray1244))
        openingMove1244.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1244);
      OpeningMove openingMove1245 = new OpeningMove();
      openingMove1245.StartingFEN = "r1bqkbnr/pp1ppp1p/2n3p1/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R w KQkq -";
      string str1245 = "d2d4{5}";
      char[] chArray1245 = new char[1]{ ' ' };
      foreach (string move in str1245.Split(chArray1245))
        openingMove1245.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1245);
      OpeningMove openingMove1246 = new OpeningMove();
      openingMove1246.StartingFEN = "r1bqkb1r/5p1p/p1np1p2/1p1Np3/4P3/N7/PPP2PPP/R2QKB1R b KQkq -";
      string str1246 = "f6f5{15} f8g7{15}";
      char[] chArray1246 = new char[1]{ ' ' };
      foreach (string move in str1246.Split(chArray1246))
        openingMove1246.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1246);
      OpeningMove openingMove1247 = new OpeningMove();
      openingMove1247.StartingFEN = "rnbqkb1r/4pppp/p2p1n2/1p6/3NP3/2N2P2/PPP3PP/R1BQKB1R w KQkq b6";
      string str1247 = "a2a4{5}";
      char[] chArray1247 = new char[1]{ ' ' };
      foreach (string move in str1247.Split(chArray1247))
        openingMove1247.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1247);
      OpeningMove openingMove1248 = new OpeningMove();
      openingMove1248.StartingFEN = "rnbqk2r/1p2ppb1/p2p4/6pp/3NP1n1/2N3B1/PPP1BPPP/R2QK2R w KQkq -";
      string str1248 = "e2g4{10}";
      char[] chArray1248 = new char[1]{ ' ' };
      foreach (string move in str1248.Split(chArray1248))
        openingMove1248.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1248);
      OpeningMove openingMove1249 = new OpeningMove();
      openingMove1249.StartingFEN = "r1bq1rk1/ppppppbp/2n2np1/8/2PP4/2N3P1/PP2PPBP/R1BQK1NR w KQ -";
      string str1249 = "g1f3{5}";
      char[] chArray1249 = new char[1]{ ' ' };
      foreach (string move in str1249.Split(chArray1249))
        openingMove1249.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1249);
      OpeningMove openingMove1250 = new OpeningMove();
      openingMove1250.StartingFEN = "rnbqkbnr/pppppp1p/6p1/8/3P4/8/PPP1PPPP/RNBQKBNR w KQkq -";
      string str1250 = "g2g3{5}";
      char[] chArray1250 = new char[1]{ ' ' };
      foreach (string move in str1250.Split(chArray1250))
        openingMove1250.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1250);
      OpeningMove openingMove1251 = new OpeningMove();
      openingMove1251.StartingFEN = "rnbqkbnr/pp2pppp/3p4/2p5/4P3/2P2N2/PP1P1PPP/RNBQKB1R b KQkq -";
      string str1251 = "g8f6{10}";
      char[] chArray1251 = new char[1]{ ' ' };
      foreach (string move in str1251.Split(chArray1251))
        openingMove1251.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1251);
      OpeningMove openingMove1252 = new OpeningMove();
      openingMove1252.StartingFEN = "rnbqkb1r/pppp1ppp/4pn2/8/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq d3";
      string str1252 = "b7b6{5}";
      char[] chArray1252 = new char[1]{ ' ' };
      foreach (string move in str1252.Split(chArray1252))
        openingMove1252.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1252);
      OpeningMove openingMove1253 = new OpeningMove();
      openingMove1253.StartingFEN = "rnbqkb1r/ppp2ppp/8/3pN3/3Pn3/3B4/PPP2PPP/RNBQK2R b KQkq -";
      string str1253 = "b8d7{10}";
      char[] chArray1253 = new char[1]{ ' ' };
      foreach (string move in str1253.Split(chArray1253))
        openingMove1253.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1253);
      OpeningMove openingMove1254 = new OpeningMove();
      openingMove1254.StartingFEN = "rn1qk2r/p3bppp/bpp1pn2/3pN3/2PP4/1PB3P1/P3PPBP/RN1QK2R b KQkq -";
      string str1254 = "f6d7{15}";
      char[] chArray1254 = new char[1]{ ' ' };
      foreach (string move in str1254.Split(chArray1254))
        openingMove1254.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1254);
      OpeningMove openingMove1255 = new OpeningMove();
      openingMove1255.StartingFEN = "rnbqk2r/p2p1ppp/1p2pn2/2p5/1bPP4/PQN2N2/1P2PPPP/R1B1KB1R b KQkq -";
      string str1255 = "b4a5{5}";
      char[] chArray1255 = new char[1]{ ' ' };
      foreach (string move in str1255.Split(chArray1255))
        openingMove1255.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1255);
      OpeningMove openingMove1256 = new OpeningMove();
      openingMove1256.StartingFEN = "r1bqk2r/2pp1ppp/p1n2n2/1pb1p3/4P3/1BP2N2/PP1P1PPP/RNBQ1RK1 b kq -";
      string str1256 = "d7d6{5}";
      char[] chArray1256 = new char[1]{ ' ' };
      foreach (string move in str1256.Split(chArray1256))
        openingMove1256.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1256);
      OpeningMove openingMove1257 = new OpeningMove();
      openingMove1257.StartingFEN = "r1bqkb1r/pppp1ppp/2N2n2/8/4P3/8/PPP2PPP/RNBQKB1R b KQkq -";
      string str1257 = "b7c6{10}";
      char[] chArray1257 = new char[1]{ ' ' };
      foreach (string move in str1257.Split(chArray1257))
        openingMove1257.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1257);
      OpeningMove openingMove1258 = new OpeningMove();
      openingMove1258.StartingFEN = "r1bq1rk1/pp2ppbp/n4np1/2pP4/2Q1P3/2N2N2/PP2BPPP/R1B1K2R b KQ -";
      string str1258 = "e7e6{12}";
      char[] chArray1258 = new char[1]{ ' ' };
      foreach (string move in str1258.Split(chArray1258))
        openingMove1258.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1258);
      OpeningMove openingMove1259 = new OpeningMove();
      openingMove1259.StartingFEN = "rnbqkb1r/pp2pppp/2p2n2/4N3/2pP4/2N5/PP2PPPP/R1BQKB1R b KQkq -";
      string str1259 = "b8d7{10}";
      char[] chArray1259 = new char[1]{ ' ' };
      foreach (string move in str1259.Split(chArray1259))
        openingMove1259.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1259);
      OpeningMove openingMove1260 = new OpeningMove();
      openingMove1260.StartingFEN = "r1bqkb1r/pp1npppp/2p2n2/8/2NP4/2N5/PP2PPPP/R1BQKB1R b KQkq -";
      string str1260 = "b7b5{5}";
      char[] chArray1260 = new char[1]{ ' ' };
      foreach (string move in str1260.Split(chArray1260))
        openingMove1260.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1260);
      OpeningMove openingMove1261 = new OpeningMove();
      openingMove1261.StartingFEN = "rn1qk2r/p2Nbppp/bpp1p3/3p4/2PP4/1PB3P1/P3PPBP/RN1QK2R b KQkq -";
      string str1261 = "b8d7{10}";
      char[] chArray1261 = new char[1]{ ' ' };
      foreach (string move in str1261.Split(chArray1261))
        openingMove1261.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1261);
      OpeningMove openingMove1262 = new OpeningMove();
      openingMove1262.StartingFEN = "r1bq1rk1/pp3pbp/n3pnp1/2pP4/2Q1P3/2N2N2/PP2BPPP/R1B2RK1 b - -";
      string str1262 = "e6d5{6}";
      char[] chArray1262 = new char[1]{ ' ' };
      foreach (string move in str1262.Split(chArray1262))
        openingMove1262.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1262);
      OpeningMove openingMove1263 = new OpeningMove();
      openingMove1263.StartingFEN = "rnbqk2r/ppp2ppp/4pn2/3P4/1b1P4/2N5/PPQ1PPPP/R1B1KBNR b KQkq -";
      string str1263 = "d8d5{10}";
      char[] chArray1263 = new char[1]{ ' ' };
      foreach (string move in str1263.Split(chArray1263))
        openingMove1263.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1263);
      OpeningMove openingMove1264 = new OpeningMove();
      openingMove1264.StartingFEN = "r1bqk1nr/pppp1ppp/2N5/2b5/4P3/8/PPP2PPP/RNBQKB1R b KQkq -";
      string str1264 = "d8f6{5}";
      char[] chArray1264 = new char[1]{ ' ' };
      foreach (string move in str1264.Split(chArray1264))
        openingMove1264.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1264);
      OpeningMove openingMove1265 = new OpeningMove();
      openingMove1265.StartingFEN = "rn1qkb1r/pp2pppp/2p2n2/3p1b2/2PP4/4PN2/PP3PPP/RNBQKB1R w KQkq -";
      string str1265 = "f1d3{5}";
      char[] chArray1265 = new char[1]{ ' ' };
      foreach (string move in str1265.Split(chArray1265))
        openingMove1265.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1265);
      OpeningMove openingMove1266 = new OpeningMove();
      openingMove1266.StartingFEN = "r1bqkbnr/pp2pppp/2np4/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R w KQkq -";
      string str1266 = "d2d4{6}";
      char[] chArray1266 = new char[1]{ ' ' };
      foreach (string move in str1266.Split(chArray1266))
        openingMove1266.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1266);
      OpeningMove openingMove1267 = new OpeningMove();
      openingMove1267.StartingFEN = "rnbqkb1r/1p3ppp/p3pn2/2p5/2BP4/4PN2/PP3PPP/RNBQ1RK1 w kq -";
      string str1267 = "d4c5{10} c4b3{5}";
      char[] chArray1267 = new char[1]{ ' ' };
      foreach (string move in str1267.Split(chArray1267))
        openingMove1267.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1267);
      OpeningMove openingMove1268 = new OpeningMove();
      openingMove1268.StartingFEN = "r2qk2r/ppp1bppp/2n5/3p1b2/3Pn3/3B1N2/PPP2PPP/RNBQR1K1 w kq -";
      string str1268 = "c2c4{5}";
      char[] chArray1268 = new char[1]{ ' ' };
      foreach (string move in str1268.Split(chArray1268))
        openingMove1268.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1268);
      OpeningMove openingMove1269 = new OpeningMove();
      openingMove1269.StartingFEN = "r1bq1rk1/pp1n1ppp/2pbpn2/8/2BP4/2N1PN2/PPQ2PPP/R1B2RK1 b - -";
      string str1269 = "a7a6{16}";
      char[] chArray1269 = new char[1]{ ' ' };
      foreach (string move in str1269.Split(chArray1269))
        openingMove1269.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1269);
      OpeningMove openingMove1270 = new OpeningMove();
      openingMove1270.StartingFEN = "rnbqk1nr/ppp1bppp/4p3/3p4/3PP3/8/PPPN1PPP/R1BQKBNR w KQkq -";
      string str1270 = "e4e5{10} f1d3{15}";
      char[] chArray1270 = new char[1]{ ' ' };
      foreach (string move in str1270.Split(chArray1270))
        openingMove1270.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1270);
      OpeningMove openingMove1271 = new OpeningMove();
      openingMove1271.StartingFEN = "r2qkb1r/1p1n1ppp/p2pbn2/4p3/4P1P1/1NN1BP2/PPP4P/R2QKB1R b KQkq g3";
      string str1271 = "b7b5{5}";
      char[] chArray1271 = new char[1]{ ' ' };
      foreach (string move in str1271.Split(chArray1271))
        openingMove1271.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1271);
      OpeningMove openingMove1272 = new OpeningMove();
      openingMove1272.StartingFEN = "rnbqk2r/1p2ppb1/p2p4/6p1/3NP1p1/2N3B1/PPP2PPP/R2QK2R w KQkq -";
      string str1272 = "e1g1{5}";
      char[] chArray1272 = new char[1]{ ' ' };
      foreach (string move in str1272.Split(chArray1272))
        openingMove1272.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1272);
      OpeningMove openingMove1273 = new OpeningMove();
      openingMove1273.StartingFEN = "rnbq1rk1/p1pp1ppp/1p2pn2/8/2P5/P1Q2N2/1P1PPPPP/R1B1KB1R w KQ -";
      string str1273 = "g2g3{5} e2e3{5}";
      char[] chArray1273 = new char[1]{ ' ' };
      foreach (string move in str1273.Split(chArray1273))
        openingMove1273.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1273);
      OpeningMove openingMove1274 = new OpeningMove();
      openingMove1274.StartingFEN = "rnbqkb1r/1p3pp1/p2ppn1p/8/3NP1P1/2N4P/PPP2P2/R1BQKB1R w KQkq -";
      string str1274 = "f1g2{5}";
      char[] chArray1274 = new char[1]{ ' ' };
      foreach (string move in str1274.Split(chArray1274))
        openingMove1274.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1274);
      OpeningMove openingMove1275 = new OpeningMove();
      openingMove1275.StartingFEN = "rnbq1rk1/pp1p1ppp/4pn2/2p5/1bPP4/2N2NP1/PP2PP1P/R1BQKB1R w KQ -";
      string str1275 = "f1g2{6}";
      char[] chArray1275 = new char[1]{ ' ' };
      foreach (string move in str1275.Split(chArray1275))
        openingMove1275.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1275);
      OpeningMove openingMove1276 = new OpeningMove();
      openingMove1276.StartingFEN = "r1bq1rk1/ppp1bppp/8/3p4/1nPPn3/5N2/PP2BPPP/RNBQ1RK1 w - -";
      string str1276 = "b1c3{41}";
      char[] chArray1276 = new char[1]{ ' ' };
      foreach (string move in str1276.Split(chArray1276))
        openingMove1276.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1276);
      OpeningMove openingMove1277 = new OpeningMove();
      openingMove1277.StartingFEN = "rnbqk1nr/ppp1bppp/4p3/3pP3/3P4/8/PPPN1PPP/R1BQKBNR b KQkq -";
      string str1277 = "c7c5{5}";
      char[] chArray1277 = new char[1]{ ' ' };
      foreach (string move in str1277.Split(chArray1277))
        openingMove1277.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1277);
      OpeningMove openingMove1278 = new OpeningMove();
      openingMove1278.StartingFEN = "rnbqkbnr/p3pppp/2p5/1p6/2pPP3/2N5/PP3PPP/R1BQKBNR w KQkq b6";
      string str1278 = "a2a4{6}";
      char[] chArray1278 = new char[1]{ ' ' };
      foreach (string move in str1278.Split(chArray1278))
        openingMove1278.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1278);
      OpeningMove openingMove1279 = new OpeningMove();
      openingMove1279.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/8/3NP3/2N2P2/PPP3PP/R1BQKB1R w KQkq -";
      string str1279 = "c1e3{5}";
      char[] chArray1279 = new char[1]{ ' ' };
      foreach (string move in str1279.Split(chArray1279))
        openingMove1279.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1279);
      OpeningMove openingMove1280 = new OpeningMove();
      openingMove1280.StartingFEN = "r1b1kb1r/ppp2ppp/2p5/4Pn2/8/2N2N2/PPP2PPP/R1B2RK1 w - -";
      string str1280 = "h2h3{5}";
      char[] chArray1280 = new char[1]{ ' ' };
      foreach (string move in str1280.Split(chArray1280))
        openingMove1280.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1280);
      OpeningMove openingMove1281 = new OpeningMove();
      openingMove1281.StartingFEN = "r1b1kb1r/p1ppqppp/2p5/3nP3/8/8/PPP1QPPP/RNB1KB1R w KQkq -";
      string str1281 = "c2c4{18}";
      char[] chArray1281 = new char[1]{ ' ' };
      foreach (string move in str1281.Split(chArray1281))
        openingMove1281.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1281);
      OpeningMove openingMove1282 = new OpeningMove();
      openingMove1282.StartingFEN = "rnbqkb1r/pppn1ppp/4p3/3pP3/3P1P2/2N5/PPP3PP/R1BQKBNR b KQkq f3";
      string str1282 = "c7c5{5}";
      char[] chArray1282 = new char[1]{ ' ' };
      foreach (string move in str1282.Split(chArray1282))
        openingMove1282.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1282);
      OpeningMove openingMove1283 = new OpeningMove();
      openingMove1283.StartingFEN = "rn1qkb1r/pp2ppp1/2p2nbp/8/3P3P/5NN1/PPP2PP1/R1BQKB1R w KQkq -";
      string str1283 = "f3e5{10}";
      char[] chArray1283 = new char[1]{ ' ' };
      foreach (string move in str1283.Split(chArray1283))
        openingMove1283.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1283);
      OpeningMove openingMove1284 = new OpeningMove();
      openingMove1284.StartingFEN = "r1bq1rk1/2ppbppp/p1n2n2/1p2p3/4P3/1B1P1N2/PPP2PPP/RNBQR1K1 b - -";
      string str1284 = "d7d6{5}";
      char[] chArray1284 = new char[1]{ ' ' };
      foreach (string move in str1284.Split(chArray1284))
        openingMove1284.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1284);
      OpeningMove openingMove1285 = new OpeningMove();
      openingMove1285.StartingFEN = "r1bqkb1r/pp2pppp/2n2n2/2pp4/2PP4/2N2NP1/PP2PP1P/R1BQKB1R b KQkq d3";
      string str1285 = "e7e6{5}";
      char[] chArray1285 = new char[1]{ ' ' };
      foreach (string move in str1285.Split(chArray1285))
        openingMove1285.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1285);
      OpeningMove openingMove1286 = new OpeningMove();
      openingMove1286.StartingFEN = "rnbqk2r/1p2ppb1/p2p3p/6p1/3NP1n1/2N3B1/PPPQ1PPP/R3KB1R b KQkq -";
      string str1286 = "b8c6{6}";
      char[] chArray1286 = new char[1]{ ' ' };
      foreach (string move in str1286.Split(chArray1286))
        openingMove1286.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1286);
      OpeningMove openingMove1287 = new OpeningMove();
      openingMove1287.StartingFEN = "r2qk2r/ppp1bppp/2n5/3p4/3Pn1b1/2PB1N2/PP3PPP/RNBQR1K1 b kq -";
      string str1287 = "f7f5{5}";
      char[] chArray1287 = new char[1]{ ' ' };
      foreach (string move in str1287.Split(chArray1287))
        openingMove1287.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1287);
      OpeningMove openingMove1288 = new OpeningMove();
      openingMove1288.StartingFEN = "r2q1rk1/1bppbppp/p1n2n2/1p2p3/4P3/1B1P1N1P/PPP2PP1/RNBQR1K1 b - -";
      string str1288 = "h7h6{10} d7d6{5}";
      char[] chArray1288 = new char[1]{ ' ' };
      foreach (string move in str1288.Split(chArray1288))
        openingMove1288.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1288);
      OpeningMove openingMove1289 = new OpeningMove();
      openingMove1289.StartingFEN = "rnbqkbnr/ppp2ppp/8/8/2ppP3/5N2/PP3PPP/RNBQKB1R w KQkq -";
      string str1289 = "f1c4{5}";
      char[] chArray1289 = new char[1]{ ' ' };
      foreach (string move in str1289.Split(chArray1289))
        openingMove1289.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1289);
      OpeningMove openingMove1290 = new OpeningMove();
      openingMove1290.StartingFEN = "r1bq1rk1/1p2bppp/p1nppn2/8/P2NP3/2N1B3/1PP1BPPP/R2Q1RK1 w - -";
      string str1290 = "f2f4{5}";
      char[] chArray1290 = new char[1]{ ' ' };
      foreach (string move in str1290.Split(chArray1290))
        openingMove1290.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1290);
      OpeningMove openingMove1291 = new OpeningMove();
      openingMove1291.StartingFEN = "r1bqk2r/pppp1ppp/2n2n2/1Bb1p3/4P3/5N2/PPPP1PPP/RNBQ1RK1 w kq -";
      string str1291 = "c2c3{10} f3e5{5}";
      char[] chArray1291 = new char[1]{ ' ' };
      foreach (string move in str1291.Split(chArray1291))
        openingMove1291.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1291);
      OpeningMove openingMove1292 = new OpeningMove();
      openingMove1292.StartingFEN = "rnbqkbnr/pp2pppp/3p4/2p5/4P3/2N3P1/PPPP1P1P/R1BQKBNR b KQkq -";
      string str1292 = "b8c6{6}";
      char[] chArray1292 = new char[1]{ ' ' };
      foreach (string move in str1292.Split(chArray1292))
        openingMove1292.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1292);
      OpeningMove openingMove1293 = new OpeningMove();
      openingMove1293.StartingFEN = "rnbq1rk1/3nppbp/p5p1/1pp1P3/3P3P/1QN2N2/PP3PP1/R1B1KB1R w KQ c6";
      string str1293 = "e5e6{5}";
      char[] chArray1293 = new char[1]{ ' ' };
      foreach (string move in str1293.Split(chArray1293))
        openingMove1293.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1293);
      OpeningMove openingMove1294 = new OpeningMove();
      openingMove1294.StartingFEN = "rn1q1rk1/pbp2ppp/1p1ppn2/6B1/2PP4/P1Q1P3/1P3PPP/R3KBNR w KQ -";
      string str1294 = "g1e2{5}";
      char[] chArray1294 = new char[1]{ ' ' };
      foreach (string move in str1294.Split(chArray1294))
        openingMove1294.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1294);
      OpeningMove openingMove1295 = new OpeningMove();
      openingMove1295.StartingFEN = "rn1q1rk1/pbp2pp1/1p2pn1p/3p4/2PP3B/P1Q2P2/1P2P1PP/R3KBNR w KQ d6";
      string str1295 = "e2e3{5}";
      char[] chArray1295 = new char[1]{ ' ' };
      foreach (string move in str1295.Split(chArray1295))
        openingMove1295.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1295);
      OpeningMove openingMove1296 = new OpeningMove();
      openingMove1296.StartingFEN = "rnbqkb1r/5ppp/p2ppn2/1p6/3NP1P1/2N1BP2/PPP4P/R2QKB1R b KQkq g3";
      string str1296 = "h7h6{17}";
      char[] chArray1296 = new char[1]{ ' ' };
      foreach (string move in str1296.Split(chArray1296))
        openingMove1296.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1296);
      OpeningMove openingMove1297 = new OpeningMove();
      openingMove1297.StartingFEN = "rn1qkbnr/pp2pppp/2p3b1/8/3P3P/6N1/PPP2PP1/R1BQKBNR b KQkq h3";
      string str1297 = "h7h6{5}";
      char[] chArray1297 = new char[1]{ ' ' };
      foreach (string move in str1297.Split(chArray1297))
        openingMove1297.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1297);
      OpeningMove openingMove1298 = new OpeningMove();
      openingMove1298.StartingFEN = "rnbqkbnr/pp3ppp/4p3/2p5/2pP4/4PN2/PP3PPP/RNBQKB1R w KQkq c6";
      string str1298 = "f1c4{6}";
      char[] chArray1298 = new char[1]{ ' ' };
      foreach (string move in str1298.Split(chArray1298))
        openingMove1298.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1298);
      OpeningMove openingMove1299 = new OpeningMove();
      openingMove1299.StartingFEN = "rnbq1rk1/pp2ppbp/6p1/2p5/3PP3/2P2N2/P4PPP/1RBQKB1R w K -";
      string str1299 = "f1e2{10}";
      char[] chArray1299 = new char[1]{ ' ' };
      foreach (string move in str1299.Split(chArray1299))
        openingMove1299.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1299);
      OpeningMove openingMove1300 = new OpeningMove();
      openingMove1300.StartingFEN = "rnbqkb1r/5pp1/p2ppn1p/1p6/3NP1P1/2N1BP2/PPPQ3P/R3KB1R b KQkq -";
      string str1300 = "b8d7{11}";
      char[] chArray1300 = new char[1]{ ' ' };
      foreach (string move in str1300.Split(chArray1300))
        openingMove1300.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1300);
      OpeningMove openingMove1301 = new OpeningMove();
      openingMove1301.StartingFEN = "r1bq1rk1/2p1bppp/p1np1n2/1p2p3/4P3/1B3N1P/PPPP1PP1/RNBQR1K1 w - -";
      string str1301 = "c2c3{5}";
      char[] chArray1301 = new char[1]{ ' ' };
      foreach (string move in str1301.Split(chArray1301))
        openingMove1301.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1301);
      OpeningMove openingMove1302 = new OpeningMove();
      openingMove1302.StartingFEN = "r1bqkbnr/pp1ppppp/2n5/2p5/4P3/2N3P1/PPPP1P1P/R1BQKBNR b KQkq -";
      string str1302 = "g7g6{5}";
      char[] chArray1302 = new char[1]{ ' ' };
      foreach (string move in str1302.Split(chArray1302))
        openingMove1302.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1302);
      OpeningMove openingMove1303 = new OpeningMove();
      openingMove1303.StartingFEN = "r1bq1rk1/pp2ppbp/2n3p1/2p5/2BPP3/2P1B3/P3NPPP/R2Q1RK1 b - -";
      string str1303 = "c8g4{5}";
      char[] chArray1303 = new char[1]{ ' ' };
      foreach (string move in str1303.Split(chArray1303))
        openingMove1303.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1303);
      OpeningMove openingMove1304 = new OpeningMove();
      openingMove1304.StartingFEN = "rn1qkbnr/pp2pppp/2p5/3pPb2/3P4/2N5/PPP2PPP/R1BQKBNR b KQkq -";
      string str1304 = "e7e6{10}";
      char[] chArray1304 = new char[1]{ ' ' };
      foreach (string move in str1304.Split(chArray1304))
        openingMove1304.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1304);
      OpeningMove openingMove1305 = new OpeningMove();
      openingMove1305.StartingFEN = "r2q1rk1/1bp1bppp/p2p1n2/np2p3/4P3/PB1P1N1P/1PP2PP1/RNBQR1K1 w - -";
      string str1305 = "b3a2{6}";
      char[] chArray1305 = new char[1]{ ' ' };
      foreach (string move in str1305.Split(chArray1305))
        openingMove1305.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1305);
      OpeningMove openingMove1306 = new OpeningMove();
      openingMove1306.StartingFEN = "rnbqkbnr/pp1ppp1p/6p1/2p5/4P3/2N2N2/PPPP1PPP/R1BQKB1R b KQkq -";
      string str1306 = "f8g7{5}";
      char[] chArray1306 = new char[1]{ ' ' };
      foreach (string move in str1306.Split(chArray1306))
        openingMove1306.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1306);
      OpeningMove openingMove1307 = new OpeningMove();
      openingMove1307.StartingFEN = "r1bqkbnr/pp1ppppp/2n5/2p5/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq d3";
      string str1307 = "c5d4{10}";
      char[] chArray1307 = new char[1]{ ' ' };
      foreach (string move in str1307.Split(chArray1307))
        openingMove1307.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1307);
      OpeningMove openingMove1308 = new OpeningMove();
      openingMove1308.StartingFEN = "rnbqk2r/pp1p1ppp/4pn2/2p5/1bP5/1QN2N2/PP1PPPPP/R1B1KB1R w KQkq c6";
      string str1308 = "g2g3{5}";
      char[] chArray1308 = new char[1]{ ' ' };
      foreach (string move in str1308.Split(chArray1308))
        openingMove1308.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1308);
      OpeningMove openingMove1309 = new OpeningMove();
      openingMove1309.StartingFEN = "r1bqkbnr/pppp1ppp/2n5/4p3/4P3/2N2N2/PPPP1PPP/R1BQKB1R b KQkq -";
      string str1309 = "g8f6{5}";
      char[] chArray1309 = new char[1]{ ' ' };
      foreach (string move in str1309.Split(chArray1309))
        openingMove1309.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1309);
      OpeningMove openingMove1310 = new OpeningMove();
      openingMove1310.StartingFEN = "rnbq1rk1/ppppppbp/5np1/8/2P5/5NP1/PP1PPPBP/RNBQ1RK1 b - -";
      string str1310 = "d7d6{5}";
      char[] chArray1310 = new char[1]{ ' ' };
      foreach (string move in str1310.Split(chArray1310))
        openingMove1310.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1310);
      OpeningMove openingMove1311 = new OpeningMove();
      openingMove1311.StartingFEN = "rnbqkb1r/pppppp1p/5np1/8/8/5NP1/PPPPPPBP/RNBQK2R b KQkq -";
      string str1311 = "f8g7{5}";
      char[] chArray1311 = new char[1]{ ' ' };
      foreach (string move in str1311.Split(chArray1311))
        openingMove1311.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1311);
      OpeningMove openingMove1312 = new OpeningMove();
      openingMove1312.StartingFEN = "r1bq1rk1/pp1n1pp1/2pbpn1p/3p4/2PP4/2NBPN2/PPQ2PPP/R1B2RK1 w - -";
      string str1312 = "b2b3{5}";
      char[] chArray1312 = new char[1]{ ' ' };
      foreach (string move in str1312.Split(chArray1312))
        openingMove1312.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1312);
      OpeningMove openingMove1313 = new OpeningMove();
      openingMove1313.StartingFEN = "r1bqkb1r/pppN1ppp/8/3p4/3Pn3/3B4/PPP2PPP/RNBQK2R b KQkq -";
      string str1313 = "c8d7{5}";
      char[] chArray1313 = new char[1]{ ' ' };
      foreach (string move in str1313.Split(chArray1313))
        openingMove1313.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1313);
      OpeningMove openingMove1314 = new OpeningMove();
      openingMove1314.StartingFEN = "r1bqk1nr/pppp1ppp/2n5/1Bb1p3/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str1314 = "e1g1{5} c2c3{5}";
      char[] chArray1314 = new char[1]{ ' ' };
      foreach (string move in str1314.Split(chArray1314))
        openingMove1314.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1314);
      OpeningMove openingMove1315 = new OpeningMove();
      openingMove1315.StartingFEN = "rn1qkb1r/pbpp1p1p/1p2pnp1/8/2PP4/P1N2N2/1P2PPPP/R1BQKB1R w KQkq -";
      string str1315 = "d1c2{5}";
      char[] chArray1315 = new char[1]{ ' ' };
      foreach (string move in str1315.Split(chArray1315))
        openingMove1315.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1315);
      OpeningMove openingMove1316 = new OpeningMove();
      openingMove1316.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/3pP3/3P4/8/PPP2PPP/RNBQKBNR b KQkq -";
      string str1316 = "c7c5{10}";
      char[] chArray1316 = new char[1]{ ' ' };
      foreach (string move in str1316.Split(chArray1316))
        openingMove1316.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1316);
      OpeningMove openingMove1317 = new OpeningMove();
      openingMove1317.StartingFEN = "rnbqk2r/ppp1ppbp/5np1/3p4/3P4/5NP1/PPP1PPBP/RNBQK2R w KQkq d6";
      string str1317 = "e1g1{5}";
      char[] chArray1317 = new char[1]{ ' ' };
      foreach (string move in str1317.Split(chArray1317))
        openingMove1317.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1317);
      OpeningMove openingMove1318 = new OpeningMove();
      openingMove1318.StartingFEN = "rnbqkbnr/pp1ppp1p/6p1/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R w KQkq -";
      string str1318 = "d2d4{5}";
      char[] chArray1318 = new char[1]{ ' ' };
      foreach (string move in str1318.Split(chArray1318))
        openingMove1318.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1318);
      OpeningMove openingMove1319 = new OpeningMove();
      openingMove1319.StartingFEN = "rnbqk2r/ppp1ppbp/5np1/3p4/2P5/5NP1/PP1PPPBP/RNBQK2R w KQkq d6";
      string str1319 = "c4d5{5}";
      char[] chArray1319 = new char[1]{ ' ' };
      foreach (string move in str1319.Split(chArray1319))
        openingMove1319.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1319);
      OpeningMove openingMove1320 = new OpeningMove();
      openingMove1320.StartingFEN = "r1bq1rk1/pppnbppp/4pn2/3p4/2PP1B2/2N1PN2/PP3PPP/R2QKB1R w KQ -";
      string str1320 = "f1e2{6} c4c5{5}";
      char[] chArray1320 = new char[1]{ ' ' };
      foreach (string move in str1320.Split(chArray1320))
        openingMove1320.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1320);
      OpeningMove openingMove1321 = new OpeningMove();
      openingMove1321.StartingFEN = "rn1q1rk1/pbppbppp/1p2pn2/8/2P5/2N2NP1/PP1PPPBP/R1BQ1RK1 w - -";
      string str1321 = "f1e1{5}";
      char[] chArray1321 = new char[1]{ ' ' };
      foreach (string move in str1321.Split(chArray1321))
        openingMove1321.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1321);
      OpeningMove openingMove1322 = new OpeningMove();
      openingMove1322.StartingFEN = "rnbqkbnr/pp2pppp/3p4/2p5/4PP2/2N5/PPPP2PP/R1BQKBNR b KQkq f3";
      string str1322 = "g7g6{5}";
      char[] chArray1322 = new char[1]{ ' ' };
      foreach (string move in str1322.Split(chArray1322))
        openingMove1322.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1322);
      OpeningMove openingMove1323 = new OpeningMove();
      openingMove1323.StartingFEN = "rn1qkb1r/pp3ppp/2p1pn2/5b2/P1BP4/2N1PN2/1P3PPP/R1BQK2R b KQkq -";
      string str1323 = "f8b4{5}";
      char[] chArray1323 = new char[1]{ ' ' };
      foreach (string move in str1323.Split(chArray1323))
        openingMove1323.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1323);
      OpeningMove openingMove1324 = new OpeningMove();
      openingMove1324.StartingFEN = "rnbq1rk1/ppp2ppp/3b4/3p4/3Pn3/3B1N2/PPP2PPP/RNBQ1RK1 w - -";
      string str1324 = "c2c4{22}";
      char[] chArray1324 = new char[1]{ ' ' };
      foreach (string move in str1324.Split(chArray1324))
        openingMove1324.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1324);
      OpeningMove openingMove1325 = new OpeningMove();
      openingMove1325.StartingFEN = "r1bq1rk1/pp3ppp/2n1pn2/2pp4/1bPP4/P1NBPN2/1P3PPP/R1BQ1RK1 b - -";
      string str1325 = "b4c3{5}";
      char[] chArray1325 = new char[1]{ ' ' };
      foreach (string move in str1325.Split(chArray1325))
        openingMove1325.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1325);
      OpeningMove openingMove1326 = new OpeningMove();
      openingMove1326.StartingFEN = "r1bqk2r/pp1n1pp1/2pbpn1p/8/3PN3/3B1N2/PPP1QPPP/R1B1K2R b KQkq -";
      string str1326 = "f6e4{5}";
      char[] chArray1326 = new char[1]{ ' ' };
      foreach (string move in str1326.Split(chArray1326))
        openingMove1326.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1326);
      OpeningMove openingMove1327 = new OpeningMove();
      openingMove1327.StartingFEN = "rnbqk2r/ppp2ppp/3b4/3p4/3Pn3/3B1N2/PPP2PPP/RNBQ1RK1 b kq -";
      string str1327 = "e8g8{10}";
      char[] chArray1327 = new char[1]{ ' ' };
      foreach (string move in str1327.Split(chArray1327))
        openingMove1327.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1327);
      OpeningMove openingMove1328 = new OpeningMove();
      openingMove1328.StartingFEN = "rn2k2r/pp3ppp/2p1p3/4N3/Pbpqn3/2N5/1P1B2PP/R2QKB1R w KQkq -";
      string str1328 = "c3e4{10}";
      char[] chArray1328 = new char[1]{ ' ' };
      foreach (string move in str1328.Split(chArray1328))
        openingMove1328.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1328);
      OpeningMove openingMove1329 = new OpeningMove();
      openingMove1329.StartingFEN = "rnbqk2r/ppp1ppbp/5np1/3P4/3P4/2N2N2/PP2PPPP/R1BQKB1R b KQkq -";
      string str1329 = "f6d5{5}";
      char[] chArray1329 = new char[1]{ ' ' };
      foreach (string move in str1329.Split(chArray1329))
        openingMove1329.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1329);
      OpeningMove openingMove1330 = new OpeningMove();
      openingMove1330.StartingFEN = "r1bqkb1r/pppp1ppp/2n2n2/4p3/2P5/6P1/PP1PPPBP/RNBQK1NR w KQkq -";
      string str1330 = "b1c3{5}";
      char[] chArray1330 = new char[1]{ ' ' };
      foreach (string move in str1330.Split(chArray1330))
        openingMove1330.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1330);
      OpeningMove openingMove1331 = new OpeningMove();
      openingMove1331.StartingFEN = "rnbqk1nr/pp3ppp/4p3/b1ppP3/3P4/P1N5/1PP2PPP/R1BQKBNR w KQkq -";
      string str1331 = "b2b4{20} d1g4{5}";
      char[] chArray1331 = new char[1]{ ' ' };
      foreach (string move in str1331.Split(chArray1331))
        openingMove1331.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1331);
      OpeningMove openingMove1332 = new OpeningMove();
      openingMove1332.StartingFEN = "r1bqk2r/5pbp/p1np1p2/1p1Np3/4P3/N7/PPP2PPP/R2QKB1R w KQkq -";
      string str1332 = "f1d3{10} c2c3{5}";
      char[] chArray1332 = new char[1]{ ' ' };
      foreach (string move in str1332.Split(chArray1332))
        openingMove1332.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1332);
      OpeningMove openingMove1333 = new OpeningMove();
      openingMove1333.StartingFEN = "r1bqk2r/ppp1bppp/8/3p4/1nPPn3/5N2/PP2BPPP/RNBQ1RK1 b kq -";
      string str1333 = "e8g8{30}";
      char[] chArray1333 = new char[1]{ ' ' };
      foreach (string move in str1333.Split(chArray1333))
        openingMove1333.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1333);
      OpeningMove openingMove1334 = new OpeningMove();
      openingMove1334.StartingFEN = "rnbqkb1r/pp1ppppp/5n2/2pP4/8/5N2/PPP1PPPP/RNBQKB1R b KQkq -";
      string str1334 = "g7g6{5} b7b5{10}";
      char[] chArray1334 = new char[1]{ ' ' };
      foreach (string move in str1334.Split(chArray1334))
        openingMove1334.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1334);
      OpeningMove openingMove1335 = new OpeningMove();
      openingMove1335.StartingFEN = "r1bqkbnr/1p1p1ppp/p1n1p3/8/3NP3/3B4/PPP2PPP/RNBQK2R w KQkq -";
      string str1335 = "d4c6{5}";
      char[] chArray1335 = new char[1]{ ' ' };
      foreach (string move in str1335.Split(chArray1335))
        openingMove1335.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1335);
      OpeningMove openingMove1336 = new OpeningMove();
      openingMove1336.StartingFEN = "r2qk2r/2p1bppp/p1n1b3/1pn1P3/3p4/2P2N2/PPBN1PPP/R1BQ1RK1 w kq -";
      string str1336 = "c3d4{5}";
      char[] chArray1336 = new char[1]{ ' ' };
      foreach (string move in str1336.Split(chArray1336))
        openingMove1336.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1336);
      OpeningMove openingMove1337 = new OpeningMove();
      openingMove1337.StartingFEN = "rnbqk2r/ppp2ppp/4pb2/8/3PN3/8/PPP2PPP/R2QKBNR w KQkq -";
      string str1337 = "g1f3{26}";
      char[] chArray1337 = new char[1]{ ' ' };
      foreach (string move in str1337.Split(chArray1337))
        openingMove1337.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1337);
      OpeningMove openingMove1338 = new OpeningMove();
      openingMove1338.StartingFEN = "rnbqkb1r/ppp1pp1p/6p1/3n4/3P4/2N5/PP1BPPPP/R2QKBNR b KQkq -";
      string str1338 = "f8g7{6}";
      char[] chArray1338 = new char[1]{ ' ' };
      foreach (string move in str1338.Split(chArray1338))
        openingMove1338.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1338);
      OpeningMove openingMove1339 = new OpeningMove();
      openingMove1339.StartingFEN = "r1b1kbnr/pp1ppppp/1qn5/8/4P3/1N6/PPP2PPP/RNBQKB1R b KQkq -";
      string str1339 = "g8f6{10}";
      char[] chArray1339 = new char[1]{ ' ' };
      foreach (string move in str1339.Split(chArray1339))
        openingMove1339.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1339);
      OpeningMove openingMove1340 = new OpeningMove();
      openingMove1340.StartingFEN = "rnbq1rk1/pp2bppp/4pn2/2pp4/2PP1B2/2N1PN2/PP3PPP/R2QKB1R w KQ c6";
      string str1340 = "d4c5{15}";
      char[] chArray1340 = new char[1]{ ' ' };
      foreach (string move in str1340.Split(chArray1340))
        openingMove1340.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1340);
      OpeningMove openingMove1341 = new OpeningMove();
      openingMove1341.StartingFEN = "r1bq1rk1/ppp1bppp/8/3p4/1nPPn3/2N2N2/PP2BPPP/R1BQ1RK1 b - -";
      string str1341 = "c8e6{10} c8f5{15}";
      char[] chArray1341 = new char[1]{ ' ' };
      foreach (string move in str1341.Split(chArray1341))
        openingMove1341.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1341);
      OpeningMove openingMove1342 = new OpeningMove();
      openingMove1342.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/6B1/3PN3/8/PPP2PPP/R2QKBNR b KQkq -";
      string str1342 = "f8e7{20} b8d7{5}";
      char[] chArray1342 = new char[1]{ ' ' };
      foreach (string move in str1342.Split(chArray1342))
        openingMove1342.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1342);
      OpeningMove openingMove1343 = new OpeningMove();
      openingMove1343.StartingFEN = "rnbqkb1r/pp2pppp/3p1n2/2p5/4P3/2P2N2/PP1P1PPP/RNBQKB1R w KQkq -";
      string str1343 = "f1e2{5}";
      char[] chArray1343 = new char[1]{ ' ' };
      foreach (string move in str1343.Split(chArray1343))
        openingMove1343.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1343);
      OpeningMove openingMove1344 = new OpeningMove();
      openingMove1344.StartingFEN = "r3kb1r/ppqnpppp/2p2n2/5b2/P1NP4/2N5/1P2PPPP/R1BQKB1R w KQkq -";
      string str1344 = "g2g3{6}";
      char[] chArray1344 = new char[1]{ ' ' };
      foreach (string move in str1344.Split(chArray1344))
        openingMove1344.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1344);
      OpeningMove openingMove1345 = new OpeningMove();
      openingMove1345.StartingFEN = "rnbq1rk1/p1pp1ppp/1p2pn2/8/1PP5/P1Q2N2/3PPPPP/R1B1KB1R b KQ b3";
      string str1345 = "a7a5{5}";
      char[] chArray1345 = new char[1]{ ' ' };
      foreach (string move in str1345.Split(chArray1345))
        openingMove1345.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1345);
      OpeningMove openingMove1346 = new OpeningMove();
      openingMove1346.StartingFEN = "rnbqkb1r/5pp1/p2ppn1p/1p6/3NP1P1/2N1BP2/PPP4P/R2QKB1R w KQkq -";
      string str1346 = "d1d2{21}";
      char[] chArray1346 = new char[1]{ ' ' };
      foreach (string move in str1346.Split(chArray1346))
        openingMove1346.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1346);
      OpeningMove openingMove1347 = new OpeningMove();
      openingMove1347.StartingFEN = "rnbqk2r/ppp1ppbp/5np1/3p4/2PP4/5NP1/PP2PPBP/RNBQK2R b KQkq -";
      string str1347 = "d5c4{5}";
      char[] chArray1347 = new char[1]{ ' ' };
      foreach (string move in str1347.Split(chArray1347))
        openingMove1347.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1347);
      OpeningMove openingMove1348 = new OpeningMove();
      openingMove1348.StartingFEN = "rnbqk2r/pp1p1ppp/4pn2/8/1bPN4/2N3P1/PP2PP1P/R1BQKB1R b KQkq -";
      string str1348 = "e8g8{5}";
      char[] chArray1348 = new char[1]{ ' ' };
      foreach (string move in str1348.Split(chArray1348))
        openingMove1348.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1348);
      OpeningMove openingMove1349 = new OpeningMove();
      openingMove1349.StartingFEN = "rnbqk2r/ppp2ppp/3b4/3p4/2PPn3/3B1N2/PP3PPP/RNBQK2R b KQkq c3";
      string str1349 = "d6b4{5}";
      char[] chArray1349 = new char[1]{ ' ' };
      foreach (string move in str1349.Split(chArray1349))
        openingMove1349.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1349);
      OpeningMove openingMove1350 = new OpeningMove();
      openingMove1350.StartingFEN = "rnbqkb1r/pppp1ppp/5n2/4p3/2B1P3/3P4/PPP2PPP/RNBQK1NR b KQkq -";
      string str1350 = "b8c6{5}";
      char[] chArray1350 = new char[1]{ ' ' };
      foreach (string move in str1350.Split(chArray1350))
        openingMove1350.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1350);
      OpeningMove openingMove1351 = new OpeningMove();
      openingMove1351.StartingFEN = "r1b1kb1r/p1ppqppp/1np5/4P3/2P5/8/PP2QPPP/RNB1KB1R w KQkq -";
      string str1351 = "b1c3{12}";
      char[] chArray1351 = new char[1]{ ' ' };
      foreach (string move in str1351.Split(chArray1351))
        openingMove1351.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1351);
      OpeningMove openingMove1352 = new OpeningMove();
      openingMove1352.StartingFEN = "r1bqkb1r/pppn1ppp/4pn2/6B1/3PN3/8/PPP2PPP/R2QKBNR w KQkq -";
      string str1352 = "e4f6{5} g1f3{6}";
      char[] chArray1352 = new char[1]{ ' ' };
      foreach (string move in str1352.Split(chArray1352))
        openingMove1352.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1352);
      OpeningMove openingMove1353 = new OpeningMove();
      openingMove1353.StartingFEN = "rnbqk2r/ppp1ppbp/6p1/3n4/3P4/5NP1/PP2PPBP/RNBQK2R b KQkq -";
      string str1353 = "d5b6{6}";
      char[] chArray1353 = new char[1]{ ' ' };
      foreach (string move in str1353.Split(chArray1353))
        openingMove1353.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1353);
      OpeningMove openingMove1354 = new OpeningMove();
      openingMove1354.StartingFEN = "r2q1rk1/ppp1bppp/4b3/3p4/1nPPn3/2N2N2/PP2BPPP/R1BQ1RK1 w - -";
      string str1354 = "f3e5{10}";
      char[] chArray1354 = new char[1]{ ' ' };
      foreach (string move in str1354.Split(chArray1354))
        openingMove1354.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1354);
      OpeningMove openingMove1355 = new OpeningMove();
      openingMove1355.StartingFEN = "r1bqkb1r/5p1p/p1np4/1p1Npp2/4P3/N7/PPP2PPP/R2QKB1R w KQkq -";
      string str1355 = "c2c3{10}";
      char[] chArray1355 = new char[1]{ ' ' };
      foreach (string move in str1355.Split(chArray1355))
        openingMove1355.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1355);
      OpeningMove openingMove1356 = new OpeningMove();
      openingMove1356.StartingFEN = "rnbqk1nr/pp3ppp/4p3/b2pP3/1P1p4/P1N5/2P2PPP/R1BQKBNR w KQkq -";
      string str1356 = "c3b5{5} d1g4{10}";
      char[] chArray1356 = new char[1]{ ' ' };
      foreach (string move in str1356.Split(chArray1356))
        openingMove1356.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1356);
      OpeningMove openingMove1357 = new OpeningMove();
      openingMove1357.StartingFEN = "rnbqk2r/1p2ppb1/p2p1n1p/6p1/3NP3/2N3BP/PPP2PP1/R2QKB1R w KQkq -";
      string str1357 = "f1c4{11} d1f3{5}";
      char[] chArray1357 = new char[1]{ ' ' };
      foreach (string move in str1357.Split(chArray1357))
        openingMove1357.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1357);
      OpeningMove openingMove1358 = new OpeningMove();
      openingMove1358.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/8/4p3/3P4/PPP1QPPP/RNB1KBNR w KQkq -";
      string str1358 = "d3e4{5}";
      char[] chArray1358 = new char[1]{ ' ' };
      foreach (string move in str1358.Split(chArray1358))
        openingMove1358.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1358);
      OpeningMove openingMove1359 = new OpeningMove();
      openingMove1359.StartingFEN = "r1bqk1nr/ppp1bppp/2n1p3/3p4/3PP3/3B4/PPPN1PPP/R1BQK1NR w KQkq -";
      string str1359 = "g1f3{5}";
      char[] chArray1359 = new char[1]{ ' ' };
      foreach (string move in str1359.Split(chArray1359))
        openingMove1359.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1359);
      OpeningMove openingMove1360 = new OpeningMove();
      openingMove1360.StartingFEN = "r1b1kb1r/pp1ppppp/1qn2n2/8/4P3/1N1B4/PPP2PPP/RNBQK2R b KQkq -";
      string str1360 = "e7e6{5}";
      char[] chArray1360 = new char[1]{ ' ' };
      foreach (string move in str1360.Split(chArray1360))
        openingMove1360.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1360);
      OpeningMove openingMove1361 = new OpeningMove();
      openingMove1361.StartingFEN = "r1bqkb1r/pp3pp1/2np1n1p/4p3/4P3/1NN2P2/PPP3PP/R1BQKB1R w KQkq -";
      string str1361 = "c1e3{5}";
      char[] chArray1361 = new char[1]{ ' ' };
      foreach (string move in str1361.Split(chArray1361))
        openingMove1361.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1361);
      OpeningMove openingMove1362 = new OpeningMove();
      openingMove1362.StartingFEN = "r1bq1rk1/1p1n1ppp/p1pbpn2/8/P1BP4/2N1PN2/1PQ2PPP/R1B2RK1 b - a3";
      string str1362 = "c6c5{6}";
      char[] chArray1362 = new char[1]{ ' ' };
      foreach (string move in str1362.Split(chArray1362))
        openingMove1362.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1362);
      OpeningMove openingMove1363 = new OpeningMove();
      openingMove1363.StartingFEN = "r1b1kb1r/p1pp1ppp/1np1q3/4P3/2P5/2N5/PP2QPPP/R1B1KB1R w KQkq -";
      string str1363 = "e2e4{6}";
      char[] chArray1363 = new char[1]{ ' ' };
      foreach (string move in str1363.Split(chArray1363))
        openingMove1363.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1363);
      OpeningMove openingMove1364 = new OpeningMove();
      openingMove1364.StartingFEN = "r2qkb1r/1p1n1ppp/p2pbn2/4p3/4P3/1NN1BP2/PPPQ2PP/R3KB1R b KQkq -";
      string str1364 = "b7b5{5}";
      char[] chArray1364 = new char[1]{ ' ' };
      foreach (string move in str1364.Split(chArray1364))
        openingMove1364.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1364);
      OpeningMove openingMove1365 = new OpeningMove();
      openingMove1365.StartingFEN = "r2qrbk1/1bp2ppp/p2p1n2/np2p3/P2PP3/1BP2N1P/1P1N1PP1/R1BQR1K1 w - -";
      string str1365 = "b3a2{5}";
      char[] chArray1365 = new char[1]{ ' ' };
      foreach (string move in str1365.Split(chArray1365))
        openingMove1365.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1365);
      OpeningMove openingMove1366 = new OpeningMove();
      openingMove1366.StartingFEN = "r1bqkbnr/pp1ppppp/2n5/8/2PN4/8/PP2PPPP/RNBQKB1R b KQkq -";
      string str1366 = "g8f6{5}";
      char[] chArray1366 = new char[1]{ ' ' };
      foreach (string move in str1366.Split(chArray1366))
        openingMove1366.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1366);
      OpeningMove openingMove1367 = new OpeningMove();
      openingMove1367.StartingFEN = "rnbqkbnr/1p3ppp/p7/2pp4/3P4/5N2/PPPN1PPP/R1BQKB1R w KQkq -";
      string str1367 = "f1e2{5}";
      char[] chArray1367 = new char[1]{ ' ' };
      foreach (string move in str1367.Split(chArray1367))
        openingMove1367.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1367);
      OpeningMove openingMove1368 = new OpeningMove();
      openingMove1368.StartingFEN = "rnbq1rk1/ppp2ppp/3b4/3p4/2PPn3/3B1N2/PP3PPP/RNBQ1RK1 b - c3";
      string str1368 = "c7c6{5}";
      char[] chArray1368 = new char[1]{ ' ' };
      foreach (string move in str1368.Split(chArray1368))
        openingMove1368.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1368);
      OpeningMove openingMove1369 = new OpeningMove();
      openingMove1369.StartingFEN = "rnbqkbnr/pp1ppppp/8/2p5/4P3/1P6/P1PP1PPP/RNBQKBNR b KQkq -";
      string str1369 = "b8c6{5}";
      char[] chArray1369 = new char[1]{ ' ' };
      foreach (string move in str1369.Split(chArray1369))
        openingMove1369.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1369);
      OpeningMove openingMove1370 = new OpeningMove();
      openingMove1370.StartingFEN = "rnb1kb1r/1pq2ppp/p2ppn2/8/3NP3/2N1B3/PPP1BPPP/R2QK2R w KQkq -";
      string str1370 = "a2a4{5} a2a3{10}";
      char[] chArray1370 = new char[1]{ ' ' };
      foreach (string move in str1370.Split(chArray1370))
        openingMove1370.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1370);
      OpeningMove openingMove1371 = new OpeningMove();
      openingMove1371.StartingFEN = "rnbqk2r/ppp1bp1p/4pp2/8/3PN3/8/PPP2PPP/R2QKBNR w KQkq -";
      string str1371 = "g1f3{11}";
      char[] chArray1371 = new char[1]{ ' ' };
      foreach (string move in str1371.Split(chArray1371))
        openingMove1371.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1371);
      OpeningMove openingMove1372 = new OpeningMove();
      openingMove1372.StartingFEN = "rnbqk2r/1pp1bp1p/p3pp2/8/3PN3/5N2/PPP2PPP/R2QKB1R w KQkq -";
      string str1372 = "c2c4{5}";
      char[] chArray1372 = new char[1]{ ' ' };
      foreach (string move in str1372.Split(chArray1372))
        openingMove1372.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1372);
      OpeningMove openingMove1373 = new OpeningMove();
      openingMove1373.StartingFEN = "rnbqkbnr/pp2pppp/2p5/3p4/3PP3/2N5/PPP2PPP/R1BQKBNR b KQkq d3";
      string str1373 = "d5e4{5}";
      char[] chArray1373 = new char[1]{ ' ' };
      foreach (string move in str1373.Split(chArray1373))
        openingMove1373.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1373);
      OpeningMove openingMove1374 = new OpeningMove();
      openingMove1374.StartingFEN = "r2q1rk1/ppp1bppp/8/3p1b2/1nPPn3/2N2N2/PP2BPPP/R1BQ1RK1 w - -";
      string str1374 = "a2a3{16}";
      char[] chArray1374 = new char[1]{ ' ' };
      foreach (string move in str1374.Split(chArray1374))
        openingMove1374.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1374);
      OpeningMove openingMove1375 = new OpeningMove();
      openingMove1375.StartingFEN = "rn1qkbnr/pp3ppp/2p1p3/3pPb2/3P4/2N5/PPP2PPP/R1BQKBNR w KQkq -";
      string str1375 = "g2g4{21}";
      char[] chArray1375 = new char[1]{ ' ' };
      foreach (string move in str1375.Split(chArray1375))
        openingMove1375.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1375);
      OpeningMove openingMove1376 = new OpeningMove();
      openingMove1376.StartingFEN = "rnb1k1nr/ppq2ppp/4p3/2ppP3/3P4/P1P5/2P2PPP/R1BQKBNR w KQkq -";
      string str1376 = "d1g4{5}";
      char[] chArray1376 = new char[1]{ ' ' };
      foreach (string move in str1376.Split(chArray1376))
        openingMove1376.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1376);
      OpeningMove openingMove1377 = new OpeningMove();
      openingMove1377.StartingFEN = "rnbqkbnr/pp1p1ppp/4p3/2p5/4P3/3P4/PPP2PPP/RNBQKBNR w KQkq c6";
      string str1377 = "g1f3{5}";
      char[] chArray1377 = new char[1]{ ' ' };
      foreach (string move in str1377.Split(chArray1377))
        openingMove1377.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1377);
      OpeningMove openingMove1378 = new OpeningMove();
      openingMove1378.StartingFEN = "rnbqkbnr/pppp1ppp/4p3/8/3P4/5N2/PPP1PPPP/RNBQKB1R b KQkq -";
      string str1378 = "g8f6{5}";
      char[] chArray1378 = new char[1]{ ' ' };
      foreach (string move in str1378.Split(chArray1378))
        openingMove1378.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1378);
      OpeningMove openingMove1379 = new OpeningMove();
      openingMove1379.StartingFEN = "rnbqk2r/1p2ppb1/p2p3p/6p1/3NP1n1/2N3BP/PPP2PP1/R2QKB1R b KQkq -";
      string str1379 = "g4f6{10}";
      char[] chArray1379 = new char[1]{ ' ' };
      foreach (string move in str1379.Split(chArray1379))
        openingMove1379.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1379);
      OpeningMove openingMove1380 = new OpeningMove();
      openingMove1380.StartingFEN = "r1bq1rk1/2p1bppp/p1n5/1p1nN3/8/1BP5/PP1P1PPP/RNBQR1K1 b - -";
      string str1380 = "c6e5{10}";
      char[] chArray1380 = new char[1]{ ' ' };
      foreach (string move in str1380.Split(chArray1380))
        openingMove1380.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1380);
      OpeningMove openingMove1381 = new OpeningMove();
      openingMove1381.StartingFEN = "r2qkb1r/2p2ppp/p1n5/1pnpP3/6b1/1BP2N2/PP1N1PPP/R1BQ1RK1 w kq -";
      string str1381 = "b3c2{5}";
      char[] chArray1381 = new char[1]{ ' ' };
      foreach (string move in str1381.Split(chArray1381))
        openingMove1381.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1381);
      OpeningMove openingMove1382 = new OpeningMove();
      openingMove1382.StartingFEN = "rn1qkb1r/pp3ppp/2p1pn2/4Nb2/P1pP4/2N2P2/1P2P1PP/R1BQKB1R b KQkq -";
      string str1382 = "f8b4{10}";
      char[] chArray1382 = new char[1]{ ' ' };
      foreach (string move in str1382.Split(chArray1382))
        openingMove1382.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1382);
      OpeningMove openingMove1383 = new OpeningMove();
      openingMove1383.StartingFEN = "r1bqk2r/pppn1ppp/4pb2/8/3PN3/5N2/PPP2PPP/R2QKB1R w KQkq -";
      string str1383 = "d1d2{16}";
      char[] chArray1383 = new char[1]{ ' ' };
      foreach (string move in str1383.Split(chArray1383))
        openingMove1383.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1383);
      OpeningMove openingMove1384 = new OpeningMove();
      openingMove1384.StartingFEN = "r1bqkb1r/1p1npppp/p2p1n2/8/3NP3/2N1B3/PPP2PPP/R2QKB1R w KQkq -";
      string str1384 = "f2f3{6}";
      char[] chArray1384 = new char[1]{ ' ' };
      foreach (string move in str1384.Split(chArray1384))
        openingMove1384.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1384);
      OpeningMove openingMove1385 = new OpeningMove();
      openingMove1385.StartingFEN = "rnbqk1nr/pp2bppp/4p3/2pp4/3PP3/3B4/PPPN1PPP/R1BQK1NR w KQkq c6";
      string str1385 = "d4c5{5}";
      char[] chArray1385 = new char[1]{ ' ' };
      foreach (string move in str1385.Split(chArray1385))
        openingMove1385.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1385);
      OpeningMove openingMove1386 = new OpeningMove();
      openingMove1386.StartingFEN = "r1bq1rk1/1p1n1ppp/p1pbpn2/8/2BP4/2N1PN2/PPQ2PPP/R1BR2K1 b - -";
      string str1386 = "b7b5{5}";
      char[] chArray1386 = new char[1]{ ' ' };
      foreach (string move in str1386.Split(chArray1386))
        openingMove1386.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1386);
      OpeningMove openingMove1387 = new OpeningMove();
      openingMove1387.StartingFEN = "rnbqkb1r/5ppp/p2ppn2/1p6/3NP3/2N1BP2/PPPQ2PP/R3KB1R b KQkq -";
      string str1387 = "b8d7{6}";
      char[] chArray1387 = new char[1]{ ' ' };
      foreach (string move in str1387.Split(chArray1387))
        openingMove1387.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1387);
      OpeningMove openingMove1388 = new OpeningMove();
      openingMove1388.StartingFEN = "rnbqkb1r/ppp2ppp/3p4/8/4n3/3B1N2/PPPP1PPP/RNBQK2R b KQkq -";
      string str1388 = "e4f6{5}";
      char[] chArray1388 = new char[1]{ ' ' };
      foreach (string move in str1388.Split(chArray1388))
        openingMove1388.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1388);
      OpeningMove openingMove1389 = new OpeningMove();
      openingMove1389.StartingFEN = "rnb1kbnr/1pqp1ppp/p3p3/8/4P3/1N1B4/PPP2PPP/RNBQK2R w KQkq -";
      string str1389 = "f2f4{5}";
      char[] chArray1389 = new char[1]{ ' ' };
      foreach (string move in str1389.Split(chArray1389))
        openingMove1389.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1389);
      OpeningMove openingMove1390 = new OpeningMove();
      openingMove1390.StartingFEN = "rnb1kbnr/pp3ppp/4p3/2pq4/3P4/5N2/PPPN1PPP/R1BQKB1R b KQkq -";
      string str1390 = "c5d4{5}";
      char[] chArray1390 = new char[1]{ ' ' };
      foreach (string move in str1390.Split(chArray1390))
        openingMove1390.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1390);
      OpeningMove openingMove1391 = new OpeningMove();
      openingMove1391.StartingFEN = "rnbqkb1r/pp2pppp/5n2/2pp4/2P5/5NP1/PP1PPP1P/RNBQKB1R w KQkq d6";
      string str1391 = "d2d4{5} c4d5{5}";
      char[] chArray1391 = new char[1]{ ' ' };
      foreach (string move in str1391.Split(chArray1391))
        openingMove1391.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1391);
      OpeningMove openingMove1392 = new OpeningMove();
      openingMove1392.StartingFEN = "rn1qkbnr/pp1Bpppp/3p4/2p5/4P3/5N2/PPPP1PPP/RNBQK2R b KQkq -";
      string str1392 = "d8d7{6}";
      char[] chArray1392 = new char[1]{ ' ' };
      foreach (string move in str1392.Split(chArray1392))
        openingMove1392.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1392);
      OpeningMove openingMove1393 = new OpeningMove();
      openingMove1393.StartingFEN = "r1bqk1nr/pp1pppbp/2n3p1/1Bp5/4P3/2P2N2/PP1P1PPP/RNBQ1RK1 b kq -";
      string str1393 = "g8f6{5}";
      char[] chArray1393 = new char[1]{ ' ' };
      foreach (string move in str1393.Split(chArray1393))
        openingMove1393.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1393);
      OpeningMove openingMove1394 = new OpeningMove();
      openingMove1394.StartingFEN = "r1bq1rk1/pppp1ppp/2n2n2/1Bb1p3/4P3/2P2N2/PP1P1PPP/RNBQ1RK1 w - -";
      string str1394 = "d2d4{5}";
      char[] chArray1394 = new char[1]{ ' ' };
      foreach (string move in str1394.Split(chArray1394))
        openingMove1394.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1394);
      OpeningMove openingMove1395 = new OpeningMove();
      openingMove1395.StartingFEN = "rnbqkbnr/pppp1ppp/8/4p3/4PP2/8/PPPP2PP/RNBQKBNR b KQkq f3";
      string str1395 = "e5f4{5}";
      char[] chArray1395 = new char[1]{ ' ' };
      foreach (string move in str1395.Split(chArray1395))
        openingMove1395.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1395);
      OpeningMove openingMove1396 = new OpeningMove();
      openingMove1396.StartingFEN = "r1b1kbnr/ppqppppp/2n5/8/3NP3/2N5/PPP2PPP/R1BQKB1R b KQkq -";
      string str1396 = "e7e6{10}";
      char[] chArray1396 = new char[1]{ ' ' };
      foreach (string move in str1396.Split(chArray1396))
        openingMove1396.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1396);
      OpeningMove openingMove1397 = new OpeningMove();
      openingMove1397.StartingFEN = "rnbqk2r/ppp1bppp/4pB2/8/3PN3/8/PPP2PPP/R2QKBNR b KQkq -";
      string str1397 = "e7f6{15}";
      char[] chArray1397 = new char[1]{ ' ' };
      foreach (string move in str1397.Split(chArray1397))
        openingMove1397.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1397);
      OpeningMove openingMove1398 = new OpeningMove();
      openingMove1398.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/8/P2NP3/2N1B3/1PP2PPP/R2QKB1R b KQkq a3";
      string str1398 = "b8c6{5}";
      char[] chArray1398 = new char[1]{ ' ' };
      foreach (string move in str1398.Split(chArray1398))
        openingMove1398.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1398);
      OpeningMove openingMove1399 = new OpeningMove();
      openingMove1399.StartingFEN = "rnbq1rk1/1pp1ppbp/p4np1/8/3PP3/1QN2N2/PP3PPP/R1B1KB1R b KQ -";
      string str1399 = "c7c5{5}";
      char[] chArray1399 = new char[1]{ ' ' };
      foreach (string move in str1399.Split(chArray1399))
        openingMove1399.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1399);
      OpeningMove openingMove1400 = new OpeningMove();
      openingMove1400.StartingFEN = "rnbqkbnr/pp2pppp/2p5/3p4/2PP4/5N2/PP2PPPP/RNBQKB1R b KQkq c3";
      string str1400 = "g8f6{5}";
      char[] chArray1400 = new char[1]{ ' ' };
      foreach (string move in str1400.Split(chArray1400))
        openingMove1400.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1400);
      OpeningMove openingMove1401 = new OpeningMove();
      openingMove1401.StartingFEN = "r1bqkbnr/pp2pp1p/2p3p1/2p5/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str1401 = "d2d3{10}";
      char[] chArray1401 = new char[1]{ ' ' };
      foreach (string move in str1401.Split(chArray1401))
        openingMove1401.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1401);
      OpeningMove openingMove1402 = new OpeningMove();
      openingMove1402.StartingFEN = "rnbqkb1r/pp1n1ppp/4p3/2ppP3/3P4/8/PPP1NPPP/R1BQKBNR w KQkq c6";
      string str1402 = "c2c3{10} f2f4{5}";
      char[] chArray1402 = new char[1]{ ' ' };
      foreach (string move in str1402.Split(chArray1402))
        openingMove1402.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1402);
      OpeningMove openingMove1403 = new OpeningMove();
      openingMove1403.StartingFEN = "r1bqk2r/4bppp/p1np1B2/1p1Np3/4P3/N7/PPP2PPP/R2QKB1R b KQkq -";
      string str1403 = "e7f6{5}";
      char[] chArray1403 = new char[1]{ ' ' };
      foreach (string move in str1403.Split(chArray1403))
        openingMove1403.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1403);
      OpeningMove openingMove1404 = new OpeningMove();
      openingMove1404.StartingFEN = "rnbqkbnr/pppppppp/8/8/8/2N5/PPPPPPPP/R1BQKBNR b KQkq -";
      string str1404 = "c7c5{6}";
      char[] chArray1404 = new char[1]{ ' ' };
      foreach (string move in str1404.Split(chArray1404))
        openingMove1404.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1404);
      OpeningMove openingMove1405 = new OpeningMove();
      openingMove1405.StartingFEN = "r1bqk2r/ppp1bppp/2n2n2/3p4/2PP4/3B1N2/PP3PPP/RNBQ1RK1 w kq -";
      string str1405 = "h2h3{5}";
      char[] chArray1405 = new char[1]{ ' ' };
      foreach (string move in str1405.Split(chArray1405))
        openingMove1405.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1405);
      OpeningMove openingMove1406 = new OpeningMove();
      openingMove1406.StartingFEN = "rnbqkb1r/ppp1p1pp/3p1n2/5p2/3P4/5NP1/PPP1PPBP/RNBQK2R b KQkq -";
      string str1406 = "g7g6{5}";
      char[] chArray1406 = new char[1]{ ' ' };
      foreach (string move in str1406.Split(chArray1406))
        openingMove1406.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1406);
      OpeningMove openingMove1407 = new OpeningMove();
      openingMove1407.StartingFEN = "r1bqk2r/pppnbppp/5n2/3p2B1/3P4/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
      string str1407 = "e2e3{5}";
      char[] chArray1407 = new char[1]{ ' ' };
      foreach (string move in str1407.Split(chArray1407))
        openingMove1407.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1407);
      OpeningMove openingMove1408 = new OpeningMove();
      openingMove1408.StartingFEN = "r1bqkb1r/ppp2ppp/1nn5/4p3/8/2N2NP1/PP1PPPBP/R1BQK2R w KQkq -";
      string str1408 = "e1g1{11}";
      char[] chArray1408 = new char[1]{ ' ' };
      foreach (string move in str1408.Split(chArray1408))
        openingMove1408.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1408);
      OpeningMove openingMove1409 = new OpeningMove();
      openingMove1409.StartingFEN = "rn1qk2r/pbpp1ppp/1p2pn2/8/1bPP4/1P3NP1/P2BPPBP/RN1QK2R b KQkq -";
      string str1409 = "a7a5{10}";
      char[] chArray1409 = new char[1]{ ' ' };
      foreach (string move in str1409.Split(chArray1409))
        openingMove1409.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1409);
      OpeningMove openingMove1410 = new OpeningMove();
      openingMove1410.StartingFEN = "r1bqkb1r/pp1npppp/3p1n2/1Bp5/3PP3/5N2/PPP2PPP/RNBQ1RK1 b kq -";
      string str1410 = "c5d4{5}";
      char[] chArray1410 = new char[1]{ ' ' };
      foreach (string move in str1410.Split(chArray1410))
        openingMove1410.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1410);
      OpeningMove openingMove1411 = new OpeningMove();
      openingMove1411.StartingFEN = "rnbqkbnr/pppp1ppp/4p3/8/4P3/3P4/PPP2PPP/RNBQKBNR b KQkq -";
      string str1411 = "d7d5{5}";
      char[] chArray1411 = new char[1]{ ' ' };
      foreach (string move in str1411.Split(chArray1411))
        openingMove1411.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1411);
      OpeningMove openingMove1412 = new OpeningMove();
      openingMove1412.StartingFEN = "rnbq1rk1/ppp1ppbp/5np1/3p4/2PP1B2/2N2N2/PP2PPPP/R2QKB1R w KQ -";
      string str1412 = "a1c1{5}";
      char[] chArray1412 = new char[1]{ ' ' };
      foreach (string move in str1412.Split(chArray1412))
        openingMove1412.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1412);
      OpeningMove openingMove1413 = new OpeningMove();
      openingMove1413.StartingFEN = "r1bqkb1r/p1pp1ppp/2p2n2/4P3/8/8/PPP2PPP/RNBQKB1R b KQkq -";
      string str1413 = "d8e7{5}";
      char[] chArray1413 = new char[1]{ ' ' };
      foreach (string move in str1413.Split(chArray1413))
        openingMove1413.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1413);
      OpeningMove openingMove1414 = new OpeningMove();
      openingMove1414.StartingFEN = "rnbqkb1r/pp3pp1/2p1pn1p/8/2pP3B/2N2N2/PP2PPPP/R2QKB1R w KQkq -";
      string str1414 = "e2e4{15}";
      char[] chArray1414 = new char[1]{ ' ' };
      foreach (string move in str1414.Split(chArray1414))
        openingMove1414.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1414);
      OpeningMove openingMove1415 = new OpeningMove();
      openingMove1415.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/3p4/4P3/3P4/PPPN1PPP/R1BQKBNR w KQkq -";
      string str1415 = "g1f3{5}";
      char[] chArray1415 = new char[1]{ ' ' };
      foreach (string move in str1415.Split(chArray1415))
        openingMove1415.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1415);
      OpeningMove openingMove1416 = new OpeningMove();
      openingMove1416.StartingFEN = "r1bqkbnr/pp2pppp/2np4/1Bp5/4P3/5N2/PPPP1PPP/RNBQK2R w KQkq -";
      string str1416 = "e1g1{5}";
      char[] chArray1416 = new char[1]{ ' ' };
      foreach (string move in str1416.Split(chArray1416))
        openingMove1416.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1416);
      OpeningMove openingMove1417 = new OpeningMove();
      openingMove1417.StartingFEN = "r1bq1rk1/pppnbppp/5n2/3p2B1/3P4/2NBP3/PP3PPP/R2QK1NR w KQ -";
      string str1417 = "g1e2{5}";
      char[] chArray1417 = new char[1]{ ' ' };
      foreach (string move in str1417.Split(chArray1417))
        openingMove1417.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1417);
      OpeningMove openingMove1418 = new OpeningMove();
      openingMove1418.StartingFEN = "rn1qkb1r/pp2pppb/2p2n1p/4N3/3P3P/6N1/PPP2PP1/R1BQKB1R w KQkq -";
      string str1418 = "f1d3{5}";
      char[] chArray1418 = new char[1]{ ' ' };
      foreach (string move in str1418.Split(chArray1418))
        openingMove1418.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1418);
      OpeningMove openingMove1419 = new OpeningMove();
      openingMove1419.StartingFEN = "rnbqkb1r/ppp2ppp/8/3np3/8/6P1/PP1PPPBP/RNBQK1NR w KQkq -";
      string str1419 = "g1f3{5}";
      char[] chArray1419 = new char[1]{ ' ' };
      foreach (string move in str1419.Split(chArray1419))
        openingMove1419.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1419);
      OpeningMove openingMove1420 = new OpeningMove();
      openingMove1420.StartingFEN = "r2q1rk1/ppp1bppp/4b3/3pN3/1nPPn3/2N5/PP2BPPP/R1BQ1RK1 b - -";
      string str1420 = "f7f6{5}";
      char[] chArray1420 = new char[1]{ ' ' };
      foreach (string move in str1420.Split(chArray1420))
        openingMove1420.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1420);
      OpeningMove openingMove1421 = new OpeningMove();
      openingMove1421.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/3p4/2PP4/5NP1/PP2PP1P/RNBQKB1R b KQkq -";
      string str1421 = "c7c6{5} f8e7{5}";
      char[] chArray1421 = new char[1]{ ' ' };
      foreach (string move in str1421.Split(chArray1421))
        openingMove1421.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1421);
      OpeningMove openingMove1422 = new OpeningMove();
      openingMove1422.StartingFEN = "r2qkb1r/ppp2ppp/2n5/3p4/3Pn1b1/3B1N2/PPP2PPP/RNBQ1RK1 w kq -";
      string str1422 = "c2c4{5}";
      char[] chArray1422 = new char[1]{ ' ' };
      foreach (string move in str1422.Split(chArray1422))
        openingMove1422.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1422);
      OpeningMove openingMove1423 = new OpeningMove();
      openingMove1423.StartingFEN = "rnbqk2r/pp2nppp/4p3/b2pP3/1P1p2Q1/P1N5/2P2PPP/R1B1KBNR w KQkq -";
      string str1423 = "b4a5{5}";
      char[] chArray1423 = new char[1]{ ' ' };
      foreach (string move in str1423.Split(chArray1423))
        openingMove1423.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1423);
      OpeningMove openingMove1424 = new OpeningMove();
      openingMove1424.StartingFEN = "rnbqkb1r/pp3p2/2p1pn1p/6p1/2pPP2B/2N2N2/PP3PPP/R2QKB1R w KQkq g6";
      string str1424 = "h4g3{10}";
      char[] chArray1424 = new char[1]{ ' ' };
      foreach (string move in str1424.Split(chArray1424))
        openingMove1424.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1424);
      OpeningMove openingMove1425 = new OpeningMove();
      openingMove1425.StartingFEN = "rnbqk2r/ppp2pp1/4pn1p/3pP1B1/1b1P4/2N5/PPP2PPP/R2QKBNR w KQkq -";
      string str1425 = "g5d2{5}";
      char[] chArray1425 = new char[1]{ ' ' };
      foreach (string move in str1425.Split(chArray1425))
        openingMove1425.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1425);
      OpeningMove openingMove1426 = new OpeningMove();
      openingMove1426.StartingFEN = "r1bqk1nr/pp2ppbp/2p3p1/2p5/4P3/3P1N2/PPP2PPP/RNBQK2R w KQkq -";
      string str1426 = "h2h3{5}";
      char[] chArray1426 = new char[1]{ ' ' };
      foreach (string move in str1426.Split(chArray1426))
        openingMove1426.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1426);
      OpeningMove openingMove1427 = new OpeningMove();
      openingMove1427.StartingFEN = "r1bqk2r/pp1n1ppp/2pbpn2/3p4/2PP4/2NBPN2/PP3PPP/R1BQK2R w KQkq -";
      string str1427 = "e3e4{5}";
      char[] chArray1427 = new char[1]{ ' ' };
      foreach (string move in str1427.Split(chArray1427))
        openingMove1427.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1427);
      OpeningMove openingMove1428 = new OpeningMove();
      openingMove1428.StartingFEN = "rn1qk2r/pp3ppp/2p1pn2/4Nb2/PbpPP3/2N2P2/1P4PP/R1BQKB1R b KQkq e3";
      string str1428 = "f5e4{5}";
      char[] chArray1428 = new char[1]{ ' ' };
      foreach (string move in str1428.Split(chArray1428))
        openingMove1428.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1428);
      OpeningMove openingMove1429 = new OpeningMove();
      openingMove1429.StartingFEN = "rnbqkb1r/pp3ppp/2p1pn2/3p4/2PP4/4PN2/PP3PPP/RNBQKB1R w KQkq -";
      string str1429 = "f1d3{5}";
      char[] chArray1429 = new char[1]{ ' ' };
      foreach (string move in str1429.Split(chArray1429))
        openingMove1429.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1429);
      OpeningMove openingMove1430 = new OpeningMove();
      openingMove1430.StartingFEN = "rn1qkb1r/p1pp1ppp/bp2pn2/8/Q1PP4/5NP1/PP2PP1P/RNB1KB1R b KQkq -";
      string str1430 = "f8e7{5}";
      char[] chArray1430 = new char[1]{ ' ' };
      foreach (string move in str1430.Split(chArray1430))
        openingMove1430.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1430);
      OpeningMove openingMove1431 = new OpeningMove();
      openingMove1431.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/8/3NP3/3B4/PPP2PPP/RNBQ1RK1 w kq -";
      string str1431 = "c2c4{5}";
      char[] chArray1431 = new char[1]{ ' ' };
      foreach (string move in str1431.Split(chArray1431))
        openingMove1431.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1431);
      OpeningMove openingMove1432 = new OpeningMove();
      openingMove1432.StartingFEN = "rn1qkbnr/pp3ppp/2p1p1b1/3pP3/3P2P1/2N5/PPP2P1P/R1BQKBNR w KQkq -";
      string str1432 = "g1e2{16}";
      char[] chArray1432 = new char[1]{ ' ' };
      foreach (string move in str1432.Split(chArray1432))
        openingMove1432.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1432);
      OpeningMove openingMove1433 = new OpeningMove();
      openingMove1433.StartingFEN = "r1bqkbnr/pppp1ppp/2n5/4p3/2P5/6P1/PP1PPP1P/RNBQKBNR w KQkq -";
      string str1433 = "f1g2{5}";
      char[] chArray1433 = new char[1]{ ' ' };
      foreach (string move in str1433.Split(chArray1433))
        openingMove1433.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1433);
      OpeningMove openingMove1434 = new OpeningMove();
      openingMove1434.StartingFEN = "rnbqk1nr/ppp1ppbp/3p2p1/8/2PPP3/8/PP3PPP/RNBQKBNR w KQkq -";
      string str1434 = "b1c3{5}";
      char[] chArray1434 = new char[1]{ ' ' };
      foreach (string move in str1434.Split(chArray1434))
        openingMove1434.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1434);
      OpeningMove openingMove1435 = new OpeningMove();
      openingMove1435.StartingFEN = "r1bq1rk1/ppp1ppbp/n2p1np1/6B1/2PPP3/2N5/PP2BPPP/R2QK1NR w KQ -";
      string str1435 = "f2f4{5}";
      char[] chArray1435 = new char[1]{ ' ' };
      foreach (string move in str1435.Split(chArray1435))
        openingMove1435.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1435);
      OpeningMove openingMove1436 = new OpeningMove();
      openingMove1436.StartingFEN = "r1bqkb1r/3n1pp1/p2ppn1p/1p6/3NP1P1/2N1BP2/PPPQ3P/R3KB1R w KQkq -";
      string str1436 = "e1c1{16}";
      char[] chArray1436 = new char[1]{ ' ' };
      foreach (string move in str1436.Split(chArray1436))
        openingMove1436.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1436);
      OpeningMove openingMove1437 = new OpeningMove();
      openingMove1437.StartingFEN = "rnbqk2r/1p2bppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQ1RK1 b kq -";
      string str1437 = "e8g8{5}";
      char[] chArray1437 = new char[1]{ ' ' };
      foreach (string move in str1437.Split(chArray1437))
        openingMove1437.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1437);
      OpeningMove openingMove1438 = new OpeningMove();
      openingMove1438.StartingFEN = "r1b1kb1r/pp1n1p2/2p1pqpp/8/2BP4/2N1PN2/PP3PPP/R2Q1RK1 b kq -";
      string str1438 = "f8g7{5}";
      char[] chArray1438 = new char[1]{ ' ' };
      foreach (string move in str1438.Split(chArray1438))
        openingMove1438.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1438);
      OpeningMove openingMove1439 = new OpeningMove();
      openingMove1439.StartingFEN = "rnbqk2r/1p2bppp/p2ppn2/8/3NPP2/2N5/PPP1B1PP/R1BQ1RK1 b kq f3";
      string str1439 = "e8g8{10}";
      char[] chArray1439 = new char[1]{ ' ' };
      foreach (string move in str1439.Split(chArray1439))
        openingMove1439.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1439);
      OpeningMove openingMove1440 = new OpeningMove();
      openingMove1440.StartingFEN = "rnbqkbnr/pp1p1ppp/4p3/2p5/4P3/2P2N2/PP1P1PPP/RNBQKB1R b KQkq -";
      string str1440 = "d7d5{5}";
      char[] chArray1440 = new char[1]{ ' ' };
      foreach (string move in str1440.Split(chArray1440))
        openingMove1440.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1440);
      OpeningMove openingMove1441 = new OpeningMove();
      openingMove1441.StartingFEN = "rnbqkb1r/pp1ppppp/5n2/2p5/3P4/2P2N2/PP2PPPP/RNBQKB1R b KQkq -";
      string str1441 = "e7e6{5}";
      char[] chArray1441 = new char[1]{ ' ' };
      foreach (string move in str1441.Split(chArray1441))
        openingMove1441.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1441);
      OpeningMove openingMove1442 = new OpeningMove();
      openingMove1442.StartingFEN = "rnbqk2r/ppp2ppp/4pb2/8/3PN3/5N2/PPP2PPP/R2QKB1R b KQkq -";
      string str1442 = "b8d7{5} e8g8{5}";
      char[] chArray1442 = new char[1]{ ' ' };
      foreach (string move in str1442.Split(chArray1442))
        openingMove1442.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1442);
      OpeningMove openingMove1443 = new OpeningMove();
      openingMove1443.StartingFEN = "rn1qk2r/pbppbppp/1p2pn2/8/2PP4/1PN2NP1/P2BPP1P/R2QKB1R w KQkq -";
      string str1443 = "f1g2{5}";
      char[] chArray1443 = new char[1]{ ' ' };
      foreach (string move in str1443.Split(chArray1443))
        openingMove1443.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1443);
      OpeningMove openingMove1444 = new OpeningMove();
      openingMove1444.StartingFEN = "rnbqkb1r/pp1n1ppp/4p3/3pP3/3p4/2P5/PP2NPPP/R1BQKBNR w KQkq -";
      string str1444 = "c3d4{5}";
      char[] chArray1444 = new char[1]{ ' ' };
      foreach (string move in str1444.Split(chArray1444))
        openingMove1444.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1444);
      OpeningMove openingMove1445 = new OpeningMove();
      openingMove1445.StartingFEN = "r1bq1rk1/pp2ppbp/2n2np1/3p4/3NP3/2N1BP2/PPPQ2PP/2KR1B1R w - -";
      string str1445 = "e4d5{5}";
      char[] chArray1445 = new char[1]{ ' ' };
      foreach (string move in str1445.Split(chArray1445))
        openingMove1445.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1445);
      OpeningMove openingMove1446 = new OpeningMove();
      openingMove1446.StartingFEN = "r2k1b1r/pppb1ppp/2p5/4Pn2/8/2N2N2/PPP2PPP/R1B2RK1 w - -";
      string str1446 = "b2b3{5} f1d1{5}";
      char[] chArray1446 = new char[1]{ ' ' };
      foreach (string move in str1446.Split(chArray1446))
        openingMove1446.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1446);
      OpeningMove openingMove1447 = new OpeningMove();
      openingMove1447.StartingFEN = "rnbqkbnr/pp2pppp/2p5/3p4/2P5/5N2/PP1PPPPP/RNBQKB1R w KQkq -";
      string str1447 = "e2e3{5}";
      char[] chArray1447 = new char[1]{ ' ' };
      foreach (string move in str1447.Split(chArray1447))
        openingMove1447.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1447);
      OpeningMove openingMove1448 = new OpeningMove();
      openingMove1448.StartingFEN = "rnbq1rk1/pp2ppbp/6p1/8/3pP3/2P2N2/P3BPPP/1RBQK2R w K -";
      string str1448 = "c3d4{5}";
      char[] chArray1448 = new char[1]{ ' ' };
      foreach (string move in str1448.Split(chArray1448))
        openingMove1448.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1448);
      OpeningMove openingMove1449 = new OpeningMove();
      openingMove1449.StartingFEN = "r1bqkbnr/pp1p1ppp/2n1p3/1N6/4P3/8/PPP2PPP/RNBQKB1R b KQkq -";
      string str1449 = "d7d6{5}";
      char[] chArray1449 = new char[1]{ ' ' };
      foreach (string move in str1449.Split(chArray1449))
        openingMove1449.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1449);
      OpeningMove openingMove1450 = new OpeningMove();
      openingMove1450.StartingFEN = "rnbqkb1r/1p3ppp/p2p1n2/4p3/3NP1P1/2N1B3/PPP2P1P/R2QKB1R w KQkq -";
      string str1450 = "d4f5{5}";
      char[] chArray1450 = new char[1]{ ' ' };
      foreach (string move in str1450.Split(chArray1450))
        openingMove1450.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1450);
      OpeningMove openingMove1451 = new OpeningMove();
      openingMove1451.StartingFEN = "r1bqkb1r/3n1pp1/p2ppn1p/1p6/3NP1P1/2N1BP2/PPPQ3P/2KR1B1R b kq -";
      string str1451 = "c8b7{5}";
      char[] chArray1451 = new char[1]{ ' ' };
      foreach (string move in str1451.Split(chArray1451))
        openingMove1451.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1451);
      OpeningMove openingMove1452 = new OpeningMove();
      openingMove1452.StartingFEN = "rn1qk2r/1p2bppp/p2pbn2/4p3/4P3/1NN5/PPP1BPPP/R1BQ1RK1 w kq -";
      string str1452 = "f2f4{5}";
      char[] chArray1452 = new char[1]{ ' ' };
      foreach (string move in str1452.Split(chArray1452))
        openingMove1452.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1452);
      OpeningMove openingMove1453 = new OpeningMove();
      openingMove1453.StartingFEN = "r1bqkb1r/pppp1ppp/2n5/1B2p3/3Pn3/5N2/PPP2PPP/RNBQ1RK1 b kq d3";
      string str1453 = "e4d6{30}";
      char[] chArray1453 = new char[1]{ ' ' };
      foreach (string move in str1453.Split(chArray1453))
        openingMove1453.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1453);
      OpeningMove openingMove1454 = new OpeningMove();
      openingMove1454.StartingFEN = "r1bqkb1r/pppp1ppp/2Bn4/4p3/3P4/5N2/PPP2PPP/RNBQ1RK1 b kq -";
      string str1454 = "d7c6{25}";
      char[] chArray1454 = new char[1]{ ' ' };
      foreach (string move in str1454.Split(chArray1454))
        openingMove1454.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1454);
      OpeningMove openingMove1455 = new OpeningMove();
      openingMove1455.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/8/2pP4/4PN2/PP3PPP/RNBQKB1R b KQkq -";
      string str1455 = "c7c5{5}";
      char[] chArray1455 = new char[1]{ ' ' };
      foreach (string move in str1455.Split(chArray1455))
        openingMove1455.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1455);
      OpeningMove openingMove1456 = new OpeningMove();
      openingMove1456.StartingFEN = "rn1q1rk1/pbpp1pp1/1p2pn1p/8/2PP3B/P1Q2P2/1P2P1PP/R3KBNR b KQ -";
      string str1456 = "d7d5{5}";
      char[] chArray1456 = new char[1]{ ' ' };
      foreach (string move in str1456.Split(chArray1456))
        openingMove1456.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1456);
      OpeningMove openingMove1457 = new OpeningMove();
      openingMove1457.StartingFEN = "r1bqkb1r/ppp2ppp/2pn4/4P3/8/5N2/PPP2PPP/RNBQ1RK1 b kq -";
      string str1457 = "d6f5{20}";
      char[] chArray1457 = new char[1]{ ' ' };
      foreach (string move in str1457.Split(chArray1457))
        openingMove1457.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1457);
      OpeningMove openingMove1458 = new OpeningMove();
      openingMove1458.StartingFEN = "r2qk2r/1bpp1ppp/p1n2n2/1pb1p3/P3P3/1B3N2/1PPP1PPP/RNBQ1RK1 w kq -";
      string str1458 = "d2d3{5}";
      char[] chArray1458 = new char[1]{ ' ' };
      foreach (string move in str1458.Split(chArray1458))
        openingMove1458.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1458);
      OpeningMove openingMove1459 = new OpeningMove();
      openingMove1459.StartingFEN = "rnbq1rk1/ppp2ppp/4pn2/3p4/1bPP4/2NBPN2/PP3PPP/R1BQK2R b KQ -";
      string str1459 = "c7c5{10}";
      char[] chArray1459 = new char[1]{ ' ' };
      foreach (string move in str1459.Split(chArray1459))
        openingMove1459.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1459);
      OpeningMove openingMove1460 = new OpeningMove();
      openingMove1460.StartingFEN = "rnbqkb1r/p2ppppp/1p3n2/2p5/2P5/5NP1/PP1PPPBP/RNBQK2R b KQkq -";
      string str1460 = "c8b7{5}";
      char[] chArray1460 = new char[1]{ ' ' };
      foreach (string move in str1460.Split(chArray1460))
        openingMove1460.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1460);
      OpeningMove openingMove1461 = new OpeningMove();
      openingMove1461.StartingFEN = "rnbqk2r/ppp1bppp/4pn2/3p4/2PP4/5NP1/PP2PPBP/RNBQK2R b KQkq -";
      string str1461 = "e8g8{5}";
      char[] chArray1461 = new char[1]{ ' ' };
      foreach (string move in str1461.Split(chArray1461))
        openingMove1461.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1461);
      OpeningMove openingMove1462 = new OpeningMove();
      openingMove1462.StartingFEN = "rnbqkb1r/1p3ppp/p2ppn2/6B1/3NP3/2NQ4/PPP2PPP/R3KB1R b KQkq -";
      string str1462 = "b8c6{5}";
      char[] chArray1462 = new char[1]{ ' ' };
      foreach (string move in str1462.Split(chArray1462))
        openingMove1462.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1462);
      OpeningMove openingMove1463 = new OpeningMove();
      openingMove1463.StartingFEN = "rnbqkb1r/pp2pp1p/5np1/3p4/3P4/6P1/PP2PPBP/RNBQK1NR w KQkq -";
      string str1463 = "g1f3{5}";
      char[] chArray1463 = new char[1]{ ' ' };
      foreach (string move in str1463.Split(chArray1463))
        openingMove1463.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1463);
      OpeningMove openingMove1464 = new OpeningMove();
      openingMove1464.StartingFEN = "rn1qk2r/1bpp1ppp/1p2pn2/p7/1bPP4/1P3NP1/P2BPPBP/RN1Q1RK1 b kq -";
      string str1464 = "e8g8{5}";
      char[] chArray1464 = new char[1]{ ' ' };
      foreach (string move in str1464.Split(chArray1464))
        openingMove1464.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1464);
      OpeningMove openingMove1465 = new OpeningMove();
      openingMove1465.StartingFEN = "rnbqkb1r/p2ppppp/5n2/1ppP2B1/8/5N2/PPP1PPPP/RN1QKB1R b KQkq -";
      string str1465 = "f6e4{5}";
      char[] chArray1465 = new char[1]{ ' ' };
      foreach (string move in str1465.Split(chArray1465))
        openingMove1465.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1465);
      OpeningMove openingMove1466 = new OpeningMove();
      openingMove1466.StartingFEN = "rn2k2r/pp3ppp/2p1p3/4N3/Pbp1q3/8/1P1B2PP/R2QKB1R w KQkq -";
      string str1466 = "d1e2{5}";
      char[] chArray1466 = new char[1]{ ' ' };
      foreach (string move in str1466.Split(chArray1466))
        openingMove1466.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1466);
      OpeningMove openingMove1467 = new OpeningMove();
      openingMove1467.StartingFEN = "rn1qkbnr/pppb1ppp/4p3/8/3PN3/8/PPP2PPP/R1BQKBNR w KQkq -";
      string str1467 = "g1f3{5}";
      char[] chArray1467 = new char[1]{ ' ' };
      foreach (string move in str1467.Split(chArray1467))
        openingMove1467.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1467);
      OpeningMove openingMove1468 = new OpeningMove();
      openingMove1468.StartingFEN = "r1bqkb1r/5p1p/p1np4/1p1Npp2/4P3/N1P5/PP3PPP/R2QKB1R b KQkq -";
      string str1468 = "f8g7{5}";
      char[] chArray1468 = new char[1]{ ' ' };
      foreach (string move in str1468.Split(chArray1468))
        openingMove1468.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1468);
      OpeningMove openingMove1469 = new OpeningMove();
      openingMove1469.StartingFEN = "r1bqkb1r/pp3ppp/2n1pn2/2pp4/2P5/2N2NP1/PP1PPPBP/R1BQK2R w KQkq d6";
      string str1469 = "c4d5{5}";
      char[] chArray1469 = new char[1]{ ' ' };
      foreach (string move in str1469.Split(chArray1469))
        openingMove1469.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1469);
      OpeningMove openingMove1470 = new OpeningMove();
      openingMove1470.StartingFEN = "r1bq1rk1/2pnbppp/p2p1n2/1p2p3/3PP3/1BP2N1P/PP3PP1/RNBQR1K1 w - -";
      string str1470 = "b1d2{5}";
      char[] chArray1470 = new char[1]{ ' ' };
      foreach (string move in str1470.Split(chArray1470))
        openingMove1470.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1470);
      OpeningMove openingMove1471 = new OpeningMove();
      openingMove1471.StartingFEN = "r1bqkb1r/pp3ppp/2n1pn2/8/2Bp4/4PN2/PP2QPPP/RNB2RK1 w kq -";
      string str1471 = "f1d1{5}";
      char[] chArray1471 = new char[1]{ ' ' };
      foreach (string move in str1471.Split(chArray1471))
        openingMove1471.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1471);
      OpeningMove openingMove1472 = new OpeningMove();
      openingMove1472.StartingFEN = "r4rk1/1bpqbppp/p1np1n2/1p2p3/4P3/PB1P1N1P/1PP2PP1/RNBQR1K1 w - -";
      string str1472 = "b1c3{5}";
      char[] chArray1472 = new char[1]{ ' ' };
      foreach (string move in str1472.Split(chArray1472))
        openingMove1472.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1472);
      OpeningMove openingMove1473 = new OpeningMove();
      openingMove1473.StartingFEN = "r1bq1rk1/pppn1ppp/4pb2/8/3PN3/5N2/PPPQ1PPP/R3KB1R w KQ -";
      string str1473 = "e1c1{10}";
      char[] chArray1473 = new char[1]{ ' ' };
      foreach (string move in str1473.Split(chArray1473))
        openingMove1473.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1473);
      OpeningMove openingMove1474 = new OpeningMove();
      openingMove1474.StartingFEN = "rnbqk2r/ppp1bppp/4pn2/3p2B1/3PP3/2N5/PPP2PPP/R2QKBNR w KQkq -";
      string str1474 = "e4e5{5}";
      char[] chArray1474 = new char[1]{ ' ' };
      foreach (string move in str1474.Split(chArray1474))
        openingMove1474.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1474);
      OpeningMove openingMove1475 = new OpeningMove();
      openingMove1475.StartingFEN = "rnbqkb1r/p4p2/2p1pn1p/1p4p1/2pPP3/2N2NB1/PP3PPP/R2QKB1R w KQkq b6";
      string str1475 = "f1e2{5}";
      char[] chArray1475 = new char[1]{ ' ' };
      foreach (string move in str1475.Split(chArray1475))
        openingMove1475.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1475);
      OpeningMove openingMove1476 = new OpeningMove();
      openingMove1476.StartingFEN = "r2qk2r/1p1nbppp/p2pbn2/4p3/4P3/1NN1BP2/PPPQ2PP/R3KB1R w KQkq -";
      string str1476 = "g2g4{5}";
      char[] chArray1476 = new char[1]{ ' ' };
      foreach (string move in str1476.Split(chArray1476))
        openingMove1476.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1476);
      OpeningMove openingMove1477 = new OpeningMove();
      openingMove1477.StartingFEN = "rn1qkbnr/pp3ppb/2p1p2p/4N3/3P3P/6N1/PPP2PP1/R1BQKB1R w KQkq -";
      string str1477 = "f1d3{10}";
      char[] chArray1477 = new char[1]{ ' ' };
      foreach (string move in str1477.Split(chArray1477))
        openingMove1477.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1477);
      OpeningMove openingMove1478 = new OpeningMove();
      openingMove1478.StartingFEN = "r1bqk2r/pppp1ppp/2n1pn2/8/1bPP4/2N5/PPQ1PPPP/R1B1KBNR w KQkq -";
      string str1478 = "g1f3{5}";
      char[] chArray1478 = new char[1]{ ' ' };
      foreach (string move in str1478.Split(chArray1478))
        openingMove1478.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1478);
      OpeningMove openingMove1479 = new OpeningMove();
      openingMove1479.StartingFEN = "rn1qkbnr/pp3pp1/2p1p2p/4N3/3P3P/3b2N1/PPP2PP1/R1BQK2R w KQkq -";
      string str1479 = "d1d3{5}";
      char[] chArray1479 = new char[1]{ ' ' };
      foreach (string move in str1479.Split(chArray1479))
        openingMove1479.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1479);
      OpeningMove openingMove1480 = new OpeningMove();
      openingMove1480.StartingFEN = "rnbq1rk1/ppp1ppbp/3p1np1/8/2PPP3/2N2P2/PP2N1PP/R1BQKB1R b KQ -";
      string str1480 = "c7c5{5}";
      char[] chArray1480 = new char[1]{ ' ' };
      foreach (string move in str1480.Split(chArray1480))
        openingMove1480.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1480);
      OpeningMove openingMove1481 = new OpeningMove();
      openingMove1481.StartingFEN = "rnb1kb1r/2q2ppp/p2ppn2/1p6/3NP3/P1N1B3/1PP1BPPP/R2QK2R w KQkq b6";
      string str1481 = "d1d2{5}";
      char[] chArray1481 = new char[1]{ ' ' };
      foreach (string move in str1481.Split(chArray1481))
        openingMove1481.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1481);
      OpeningMove openingMove1482 = new OpeningMove();
      openingMove1482.StartingFEN = "rnb1kb1r/1p3ppp/p3pn2/2P5/2B5/4PN2/PP3PPP/RNBq1RK1 w kq -";
      string str1482 = "f1d1{5}";
      char[] chArray1482 = new char[1]{ ' ' };
      foreach (string move in str1482.Split(chArray1482))
        openingMove1482.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1482);
      OpeningMove openingMove1483 = new OpeningMove();
      openingMove1483.StartingFEN = "r1bq1rk1/pppnbppp/4p3/8/3PN3/5N2/PPPQ1PPP/2KR1B1R w - -";
      string str1483 = "f1c4{5}";
      char[] chArray1483 = new char[1]{ ' ' };
      foreach (string move in str1483.Split(chArray1483))
        openingMove1483.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1483);
      OpeningMove openingMove1484 = new OpeningMove();
      openingMove1484.StartingFEN = "rn1qkb1r/pp2nppp/2p1p1b1/3pP3/3P2P1/2N5/PPP1NP1P/R1BQKB1R w KQkq -";
      string str1484 = "e2f4{11}";
      char[] chArray1484 = new char[1]{ ' ' };
      foreach (string move in str1484.Split(chArray1484))
        openingMove1484.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1484);
      OpeningMove openingMove1485 = new OpeningMove();
      openingMove1485.StartingFEN = "rnbqkb1r/pp2pppp/2p2n2/3p4/2P5/2N2N2/PP1PPPPP/R1BQKB1R w KQkq d6";
      string str1485 = "d2d4{5}";
      char[] chArray1485 = new char[1]{ ' ' };
      foreach (string move in str1485.Split(chArray1485))
        openingMove1485.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1485);
      OpeningMove openingMove1486 = new OpeningMove();
      openingMove1486.StartingFEN = "r2q1rk1/ppp1bppp/8/3p1b2/1nPPn3/P1N2N2/1P2BPPP/R1BQ1RK1 b - -";
      string str1486 = "e4c3{10}";
      char[] chArray1486 = new char[1]{ ' ' };
      foreach (string move in str1486.Split(chArray1486))
        openingMove1486.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1486);
      OpeningMove openingMove1487 = new OpeningMove();
      openingMove1487.StartingFEN = "r1bqk2r/2p2ppp/p1np1n2/1pb1p3/4P3/2P2N2/PPBP1PPP/RNBQ1RK1 w kq -";
      string str1487 = "a2a4{5}";
      char[] chArray1487 = new char[1]{ ' ' };
      foreach (string move in str1487.Split(chArray1487))
        openingMove1487.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1487);
      OpeningMove openingMove1488 = new OpeningMove();
      openingMove1488.StartingFEN = "r2q1rk1/ppp1bppp/8/3p1b2/1nPP4/P1n2N2/1P2BPPP/R1BQ1RK1 w - -";
      string str1488 = "b2c3{5}";
      char[] chArray1488 = new char[1]{ ' ' };
      foreach (string move in str1488.Split(chArray1488))
        openingMove1488.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1488);
      OpeningMove openingMove1489 = new OpeningMove();
      openingMove1489.StartingFEN = "r2q1rk1/1b2bppp/p2p1n2/npp1p3/3PP3/2P2N1P/PPB2PP1/RNBQR1K1 w - -";
      string str1489 = "d4d5{5}";
      char[] chArray1489 = new char[1]{ ' ' };
      foreach (string move in str1489.Split(chArray1489))
        openingMove1489.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1489);
      OpeningMove openingMove1490 = new OpeningMove();
      openingMove1490.StartingFEN = "rnbqkbnr/pp3ppp/4p3/2ppP3/3P4/2P5/PP3PPP/RNBQKBNR b KQkq -";
      string str1490 = "b8c6{5}";
      char[] chArray1490 = new char[1]{ ' ' };
      foreach (string move in str1490.Split(chArray1490))
        openingMove1490.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1490);
      OpeningMove openingMove1491 = new OpeningMove();
      openingMove1491.StartingFEN = "r1bqk2r/2p2ppp/p1n2n2/1pbpp3/4P3/2P2N2/PPBP1PPP/RNBQ1RK1 w kq d6";
      string str1491 = "a2a4{5}";
      char[] chArray1491 = new char[1]{ ' ' };
      foreach (string move in str1491.Split(chArray1491))
        openingMove1491.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1491);
      OpeningMove openingMove1492 = new OpeningMove();
      openingMove1492.StartingFEN = "r1b1kb1r/1pqp1ppp/p1n1pn2/8/3NP3/2N1B3/PPP1BPPP/R2Q1RK1 b kq -";
      string str1492 = "f8b4{5}";
      char[] chArray1492 = new char[1]{ ' ' };
      foreach (string move in str1492.Split(chArray1492))
        openingMove1492.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1492);
      OpeningMove openingMove1493 = new OpeningMove();
      openingMove1493.StartingFEN = "rnb1k2r/pp2ppbp/6p1/q1p5/3PP3/2P1BN2/P4PPP/R2QKB1R w KQkq -";
      string str1493 = "d1d2{10}";
      char[] chArray1493 = new char[1]{ ' ' };
      foreach (string move in str1493.Split(chArray1493))
        openingMove1493.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1493);
      OpeningMove openingMove1494 = new OpeningMove();
      openingMove1494.StartingFEN = "r1bQkb1r/ppp2ppp/2p5/4Pn2/8/5N2/PPP2PPP/RNB2RK1 b kq -";
      string str1494 = "e8d8{15}";
      char[] chArray1494 = new char[1]{ ' ' };
      foreach (string move in str1494.Split(chArray1494))
        openingMove1494.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1494);
      OpeningMove openingMove1495 = new OpeningMove();
      openingMove1495.StartingFEN = "rn1qk2r/p2pbppp/bpp1pn2/8/2PP4/1P3NP1/P2BPPBP/RN1Q1RK1 b kq -";
      string str1495 = "d7d5{15}";
      char[] chArray1495 = new char[1]{ ' ' };
      foreach (string move in str1495.Split(chArray1495))
        openingMove1495.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1495);
      OpeningMove openingMove1496 = new OpeningMove();
      openingMove1496.StartingFEN = "r1bk1b1r/ppp2ppp/2p5/4Pn2/8/2N2N2/PPP2PPP/R1B2RK1 b - -";
      string str1496 = "c8d7{5} d8e8{5}";
      char[] chArray1496 = new char[1]{ ' ' };
      foreach (string move in str1496.Split(chArray1496))
        openingMove1496.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1496);
      OpeningMove openingMove1497 = new OpeningMove();
      openingMove1497.StartingFEN = "rn1qk2r/p3bppp/bpp1pn2/3p4/2PP4/1P3NP1/P2BPPBP/RN1Q1RK1 w kq d6";
      string str1497 = "d1c2{5}";
      char[] chArray1497 = new char[1]{ ' ' };
      foreach (string move in str1497.Split(chArray1497))
        openingMove1497.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1497);
      OpeningMove openingMove1498 = new OpeningMove();
      openingMove1498.StartingFEN = "rnbq1rk1/pp1p1ppp/4pn2/8/1bPP4/2N5/PP2NPPP/R1BQKB1R w KQ -";
      string str1498 = "a2a3{5}";
      char[] chArray1498 = new char[1]{ ' ' };
      foreach (string move in str1498.Split(chArray1498))
        openingMove1498.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1498);
      OpeningMove openingMove1499 = new OpeningMove();
      openingMove1499.StartingFEN = "r1bqkb1r/pp1p1ppp/2n1pn2/1N6/4P3/2N5/PPP2PPP/R1BQKB1R b KQkq -";
      string str1499 = "f8b4{10} d7d6{5}";
      char[] chArray1499 = new char[1]{ ' ' };
      foreach (string move in str1499.Split(chArray1499))
        openingMove1499.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1499);
      OpeningMove openingMove1500 = new OpeningMove();
      openingMove1500.StartingFEN = "r1bqk2r/pp1p1ppp/2n1pn2/1N6/1b2P3/2N5/PPP2PPP/R1BQKB1R w KQkq -";
      string str1500 = "a2a3{10}";
      char[] chArray1500 = new char[1]{ ' ' };
      foreach (string move in str1500.Split(chArray1500))
        openingMove1500.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1500);
      OpeningMove openingMove1501 = new OpeningMove();
      openingMove1501.StartingFEN = "r1b1kbnr/ppqp1ppp/2n1p3/8/3NP3/2N3P1/PPP2P1P/R1BQKB1R b KQkq -";
      string str1501 = "a7a6{5}";
      char[] chArray1501 = new char[1]{ ' ' };
      foreach (string move in str1501.Split(chArray1501))
        openingMove1501.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1501);
      OpeningMove openingMove1502 = new OpeningMove();
      openingMove1502.StartingFEN = "r1bqkbnr/ppp1pppp/2n5/3P4/3P4/8/PP2PPPP/RNBQKBNR b KQkq -";
      string str1502 = "d8d5{5}";
      char[] chArray1502 = new char[1]{ ' ' };
      foreach (string move in str1502.Split(chArray1502))
        openingMove1502.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1502);
      OpeningMove openingMove1503 = new OpeningMove();
      openingMove1503.StartingFEN = "rnbqkb1r/1p3p1p/p2p1np1/2pP4/8/2N2N1P/PP2PPP1/R1BQKB1R w KQkq -";
      string str1503 = "a2a4{5}";
      char[] chArray1503 = new char[1]{ ' ' };
      foreach (string move in str1503.Split(chArray1503))
        openingMove1503.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1503);
      OpeningMove openingMove1504 = new OpeningMove();
      openingMove1504.StartingFEN = "rnb1k2r/ppp2ppp/4pn2/3q4/1b1P4/2N5/PPQ1PPPP/R1B1KBNR w KQkq -";
      string str1504 = "e2e3{5}";
      char[] chArray1504 = new char[1]{ ' ' };
      foreach (string move in str1504.Split(chArray1504))
        openingMove1504.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1504);
      OpeningMove openingMove1505 = new OpeningMove();
      openingMove1505.StartingFEN = "r1b1k2r/pp2ppbp/2n3p1/q1p5/3PP3/2P1BN2/P2Q1PPP/R3KB1R w KQkq -";
      string str1505 = "a1c1{5}";
      char[] chArray1505 = new char[1]{ ' ' };
      foreach (string move in str1505.Split(chArray1505))
        openingMove1505.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1505);
      OpeningMove openingMove1506 = new OpeningMove();
      openingMove1506.StartingFEN = "rnb1kb1r/1p3ppp/pq1ppn2/6B1/3NPP2/P1N5/1PP3PP/R2QKB1R b KQkq -";
      string str1506 = "b8c6{5}";
      char[] chArray1506 = new char[1]{ ' ' };
      foreach (string move in str1506.Split(chArray1506))
        openingMove1506.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1506);
      OpeningMove openingMove1507 = new OpeningMove();
      openingMove1507.StartingFEN = "r1bqk2r/5pbp/p1np1p2/1p1Np3/4P3/N2B4/PPP2PPP/R2QK2R b KQkq -";
      string str1507 = "c6e7{5}";
      char[] chArray1507 = new char[1]{ ' ' };
      foreach (string move in str1507.Split(chArray1507))
        openingMove1507.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1507);
      OpeningMove openingMove1508 = new OpeningMove();
      openingMove1508.StartingFEN = "rnbq1rk1/pp3ppp/2pb4/3p4/2PPn3/3B1N2/PP3PPP/RNBQ1RK1 w - -";
      string str1508 = "f1e1{5} d1c2{6}";
      char[] chArray1508 = new char[1]{ ' ' };
      foreach (string move in str1508.Split(chArray1508))
        openingMove1508.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1508);
      OpeningMove openingMove1509 = new OpeningMove();
      openingMove1509.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/8/2pPP3/2N2N2/PP3PPP/R1BQKB1R b KQkq e3";
      string str1509 = "f8b4{5}";
      char[] chArray1509 = new char[1]{ ' ' };
      foreach (string move in str1509.Split(chArray1509))
        openingMove1509.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1509);
      OpeningMove openingMove1510 = new OpeningMove();
      openingMove1510.StartingFEN = "rnbqkb1r/ppp1pppp/5n2/3p2B1/3P4/5N2/PPP1PPPP/RN1QKB1R b KQkq -";
      string str1510 = "f6e4{5}";
      char[] chArray1510 = new char[1]{ ' ' };
      foreach (string move in str1510.Split(chArray1510))
        openingMove1510.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1510);
      OpeningMove openingMove1511 = new OpeningMove();
      openingMove1511.StartingFEN = "rnbqk2r/ppp1ppbp/5np1/3p4/2PP4/5NP1/PP2PP1P/RNBQKB1R w KQkq d6";
      string str1511 = "c4d5{5}";
      char[] chArray1511 = new char[1]{ ' ' };
      foreach (string move in str1511.Split(chArray1511))
        openingMove1511.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1511);
      OpeningMove openingMove1512 = new OpeningMove();
      openingMove1512.StartingFEN = "rnbq1rk1/pp3ppp/4pn2/2pp4/1bPP4/2NBPN2/PP3PPP/R1BQK2R w KQ c6";
      string str1512 = "e1g1{5}";
      char[] chArray1512 = new char[1]{ ' ' };
      foreach (string move in str1512.Split(chArray1512))
        openingMove1512.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1512);
      OpeningMove openingMove1513 = new OpeningMove();
      openingMove1513.StartingFEN = "r1bq1rk1/2p1bppp/p7/1p1nR3/8/1BP5/PP1P1PPP/RNBQ2K1 b - -";
      string str1513 = "c7c6{5}";
      char[] chArray1513 = new char[1]{ ' ' };
      foreach (string move in str1513.Split(chArray1513))
        openingMove1513.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1513);
      OpeningMove openingMove1514 = new OpeningMove();
      openingMove1514.StartingFEN = "r1bqkbnr/pp3ppp/2n1p3/2ppP3/3P4/2P5/PP3PPP/RNBQKBNR w KQkq -";
      string str1514 = "g1f3{5}";
      char[] chArray1514 = new char[1]{ ' ' };
      foreach (string move in str1514.Split(chArray1514))
        openingMove1514.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1514);
      OpeningMove openingMove1515 = new OpeningMove();
      openingMove1515.StartingFEN = "r1bqkbnr/ppp1pppp/2n5/3p4/2PP4/2N5/PP2PPPP/R1BQKBNR b KQkq -";
      string str1515 = "d5c4{5}";
      char[] chArray1515 = new char[1]{ ' ' };
      foreach (string move in str1515.Split(chArray1515))
        openingMove1515.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1515);
      OpeningMove openingMove1516 = new OpeningMove();
      openingMove1516.StartingFEN = "r1bqkb1r/pppp1ppp/2n2n2/1B2p3/4P3/3P1N2/PPP2PPP/RNBQK2R b KQkq -";
      string str1516 = "f8c5{5}";
      char[] chArray1516 = new char[1]{ ' ' };
      foreach (string move in str1516.Split(chArray1516))
        openingMove1516.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1516);
      OpeningMove openingMove1517 = new OpeningMove();
      openingMove1517.StartingFEN = "r2qkb1r/1b1n1pp1/p2ppn1p/1p6/3NP1P1/2N1BP2/PPPQ3P/2KR1B1R w kq -";
      string str1517 = "h2h4{6}";
      char[] chArray1517 = new char[1]{ ' ' };
      foreach (string move in str1517.Split(chArray1517))
        openingMove1517.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1517);
      OpeningMove openingMove1518 = new OpeningMove();
      openingMove1518.StartingFEN = "rnbqk2r/1ppp1ppp/4pn2/p7/1bPP4/5N2/PP1BPPPP/RN1QKB1R w KQkq a6";
      string str1518 = "g2g3{5}";
      char[] chArray1518 = new char[1]{ ' ' };
      foreach (string move in str1518.Split(chArray1518))
        openingMove1518.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1518);
      OpeningMove openingMove1519 = new OpeningMove();
      openingMove1519.StartingFEN = "rnbqkbnr/pppp1ppp/8/4p3/4P3/2N5/PPPP1PPP/R1BQKBNR b KQkq -";
      string str1519 = "g8f6{5}";
      char[] chArray1519 = new char[1]{ ' ' };
      foreach (string move in str1519.Split(chArray1519))
        openingMove1519.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1519);
      OpeningMove openingMove1520 = new OpeningMove();
      openingMove1520.StartingFEN = "r2qkb1r/pp1npppp/2p2n2/5b2/P1NP4/2N5/1P2PPPP/R1BQKB1R b KQkq -";
      string str1520 = "f6d5{5}";
      char[] chArray1520 = new char[1]{ ' ' };
      foreach (string move in str1520.Split(chArray1520))
        openingMove1520.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1520);
      OpeningMove openingMove1521 = new OpeningMove();
      openingMove1521.StartingFEN = "rnbqkbnr/ppp2ppp/4p3/8/3PN3/8/PPP2PPP/R1BQKBNR b KQkq -";
      string str1521 = "b8d7{5}";
      char[] chArray1521 = new char[1]{ ' ' };
      foreach (string move in str1521.Split(chArray1521))
        openingMove1521.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1521);
      OpeningMove openingMove1522 = new OpeningMove();
      openingMove1522.StartingFEN = "rnbq1rk1/pp3ppp/4pn2/2bp4/2P2B2/2N1PN2/PP3PPP/R2QKB1R w KQ -";
      string str1522 = "a2a3{5} c4d5{5}";
      char[] chArray1522 = new char[1]{ ' ' };
      foreach (string move in str1522.Split(chArray1522))
        openingMove1522.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1522);
      OpeningMove openingMove1523 = new OpeningMove();
      openingMove1523.StartingFEN = "rn1qk2r/p3bppp/bpp1pn2/3p4/2PP4/1P3NP1/P1QBPPBP/RN3RK1 b kq -";
      string str1523 = "b8d7{5}";
      char[] chArray1523 = new char[1]{ ' ' };
      foreach (string move in str1523.Split(chArray1523))
        openingMove1523.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1523);
      OpeningMove openingMove1524 = new OpeningMove();
      openingMove1524.StartingFEN = "rnb1k2r/1p2ppb1/pq1p1n1p/6p1/2BNP3/2N3BP/PPP2PP1/R2QK2R w KQkq -";
      string str1524 = "e1g1{5}";
      char[] chArray1524 = new char[1]{ ' ' };
      foreach (string move in str1524.Split(chArray1524))
        openingMove1524.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1524);
      OpeningMove openingMove1525 = new OpeningMove();
      openingMove1525.StartingFEN = "r1bqk2r/ppp1bppp/1nn5/4p3/8/2N2NP1/PP1PPPBP/R1BQ1RK1 w kq -";
      string str1525 = "a1b1{6}";
      char[] chArray1525 = new char[1]{ ' ' };
      foreach (string move in str1525.Split(chArray1525))
        openingMove1525.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1525);
      OpeningMove openingMove1526 = new OpeningMove();
      openingMove1526.StartingFEN = "r1bqkb1r/pp1ppp1p/2n2np1/8/2PNP3/8/PP3PPP/RNBQKB1R w KQkq -";
      string str1526 = "b1c3{5}";
      char[] chArray1526 = new char[1]{ ' ' };
      foreach (string move in str1526.Split(chArray1526))
        openingMove1526.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1526);
      OpeningMove openingMove1527 = new OpeningMove();
      openingMove1527.StartingFEN = "rnbqk2r/1p2bppp/p2ppn2/6B1/3NPP2/2N5/PPP3PP/R2QKB1R w KQkq -";
      string str1527 = "d1f3{5}";
      char[] chArray1527 = new char[1]{ ' ' };
      foreach (string move in str1527.Split(chArray1527))
        openingMove1527.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1527);
      OpeningMove openingMove1528 = new OpeningMove();
      openingMove1528.StartingFEN = "r2qk2r/p2nbppp/bpp1p3/3p4/2PP4/1PB3P1/P2NPPBP/R2QK2R b KQkq -";
      string str1528 = "e8g8{5}";
      char[] chArray1528 = new char[1]{ ' ' };
      foreach (string move in str1528.Split(chArray1528))
        openingMove1528.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1528);
      OpeningMove openingMove1529 = new OpeningMove();
      openingMove1529.StartingFEN = "rn1qk2r/1p2bppp/p2pbn2/4p3/4P3/1NN1B3/PPPQ1PPP/R3KB1R w KQkq -";
      string str1529 = "f2f3{5}";
      char[] chArray1529 = new char[1]{ ' ' };
      foreach (string move in str1529.Split(chArray1529))
        openingMove1529.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1529);
      OpeningMove openingMove1530 = new OpeningMove();
      openingMove1530.StartingFEN = "rnbqkb1r/ppp2ppp/4pn2/8/2pP4/6P1/PP2PPBP/RNBQK1NR w KQkq -";
      string str1530 = "g1f3{5}";
      char[] chArray1530 = new char[1]{ ' ' };
      foreach (string move in str1530.Split(chArray1530))
        openingMove1530.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1530);
      OpeningMove openingMove1531 = new OpeningMove();
      openingMove1531.StartingFEN = "rnbq1rk1/1pp1ppbp/p4np1/4P3/2QP4/2N2N2/PP3PPP/R1B1KB1R b KQ -";
      string str1531 = "b7b5{5}";
      char[] chArray1531 = new char[1]{ ' ' };
      foreach (string move in str1531.Split(chArray1531))
        openingMove1531.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1531);
      OpeningMove openingMove1532 = new OpeningMove();
      openingMove1532.StartingFEN = "rnb1k2r/1p2bppp/pq1ppn2/6B1/4PP2/1NN5/PPP3PP/R2QKB1R w KQkq -";
      string str1532 = "d1f3{5}";
      char[] chArray1532 = new char[1]{ ' ' };
      foreach (string move in str1532.Split(chArray1532))
        openingMove1532.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1532);
      OpeningMove openingMove1533 = new OpeningMove();
      openingMove1533.StartingFEN = "rnb1kb1r/1p2pppp/pq1p1n2/8/4P3/1NN2P2/PPP3PP/R1BQKB1R b KQkq -";
      string str1533 = "e7e6{6}";
      char[] chArray1533 = new char[1]{ ' ' };
      foreach (string move in str1533.Split(chArray1533))
        openingMove1533.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1533);
      OpeningMove openingMove1534 = new OpeningMove();
      openingMove1534.StartingFEN = "rn1qkb1r/pp2nppp/4p1b1/2ppP3/3P1NP1/2N5/PPP2P1P/R1BQKB1R w KQkq -";
      string str1534 = "d4c5{6}";
      char[] chArray1534 = new char[1]{ ' ' };
      foreach (string move in str1534.Split(chArray1534))
        openingMove1534.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1534);
      OpeningMove openingMove1535 = new OpeningMove();
      openingMove1535.StartingFEN = "r1bqk2r/pp1p1ppp/2n1pn2/1N6/4P3/P1b5/1PP2PPP/R1BQKB1R w KQkq -";
      string str1535 = "b5c3{5}";
      char[] chArray1535 = new char[1]{ ' ' };
      foreach (string move in str1535.Split(chArray1535))
        openingMove1535.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1535);
      OpeningMove openingMove1536 = new OpeningMove();
      openingMove1536.StartingFEN = "r2q1rk1/1bp1bppp/p1np1n2/1p2p3/P3P3/1B1P1N2/1PP2PPP/RNBQR1K1 w - -";
      string str1536 = "b1d2{6}";
      char[] chArray1536 = new char[1]{ ' ' };
      foreach (string move in str1536.Split(chArray1536))
        openingMove1536.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1536);
      OpeningMove openingMove1537 = new OpeningMove();
      openingMove1537.StartingFEN = "r2q1rk1/1bppbpp1/p1n2n1p/1p2p3/4P3/1B1P1N1P/PPP2PP1/RNBQR1K1 w - -";
      string str1537 = "b1c3{5}";
      string str1538 = str1537;
      char[] chArray1537 = new char[1]{ ' ' };
      foreach (string move in str1538.Split(chArray1537))
        openingMove1537.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1537);
      string str1539 = str1537;
      char[] chArray1538 = new char[1]{ ' ' };
      foreach (string move in str1539.Split(chArray1538))
        openingMove1537.Moves.Add(new MoveContent(move));
      openingMoveList.Add(openingMove1537);
      return openingMoveList;
    }

    internal static int ValidateOpeningBook(List<OpeningMove> openingBook)
    {
      int num = 0;
      foreach (OpeningMove openingMove in openingBook)
      {
        foreach (MoveContent move in openingMove.Moves)
        {
          if (!Book.IsValidMove(move.MovingPiecePrimary.SrcPosition, move.MovingPiecePrimary.DstPosition, openingMove.StartingFEN))
            ++num;
        }
      }
      return num;
    }

    private static bool IsValidMove(byte srcPos, byte dstPos, string fen)
    {
      Board board = new Board(fen);
      PieceValidMoves.GenerateValidMoves(board);
      if (board.Squares == null || board.Squares[(int) srcPos].Piece == null)
        return false;
      foreach (int validMove in board.Squares[(int) srcPos].Piece.ValidMoves)
      {
        if (validMove == (int) dstPos)
          return true;
      }
      return (int) dstPos == (int) board.EnPassantPosition;
    }
  }
}
