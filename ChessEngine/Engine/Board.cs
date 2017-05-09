// Decompiled with JetBrains decompiler
// Type: ChessEngine.Engine.Board
// Assembly: ChessEngine, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AD2B565-9B75-423F-BD9A-4B0A934C5249
// Assembly location: C:\Users\Ahmad Elsayed\1\ChessBinNoSetup\ChessBinNoSetup\ChessEngine.dll

namespace ChessEngine.Engine
{
  internal sealed class Board
  {
    internal Square[] Squares;
    internal bool InsufficientMaterial;
    internal int Score;
    internal ulong ZobristHash;
    internal bool BlackCheck;
    internal bool BlackMate;
    internal bool WhiteCheck;
    internal bool WhiteMate;
    internal bool StaleMate;
    internal byte FiftyMove;
    internal byte RepeatedMove;
    internal bool BlackCastled;
    internal bool WhiteCastled;
    internal bool BlackCanCastle;
    internal bool WhiteCanCastle;
    internal bool EndGamePhase;
    internal MoveContent LastMove;
    internal byte WhiteKingPosition;
    internal byte BlackKingPosition;
    internal bool[] BlackAttackBoard;
    internal bool[] WhiteAttackBoard;
    internal ChessPieceColor EnPassantColor;
    internal byte EnPassantPosition;
    internal ChessPieceColor WhoseMove;
    internal int MoveCount;

    internal Board(string fen)
      : this()
    {
      byte num1 = 0;
      byte num2 = 0;
      this.WhiteCastled = true;
      this.BlackCastled = true;
      byte num3 = 0;
      this.WhoseMove = ChessPieceColor.White;
      if (fen.Contains("a3"))
      {
        this.EnPassantColor = ChessPieceColor.White;
        this.EnPassantPosition = (byte) 40;
      }
      else if (fen.Contains("b3"))
      {
        this.EnPassantColor = ChessPieceColor.White;
        this.EnPassantPosition = (byte) 41;
      }
      else if (fen.Contains("c3"))
      {
        this.EnPassantColor = ChessPieceColor.White;
        this.EnPassantPosition = (byte) 42;
      }
      else if (fen.Contains("d3"))
      {
        this.EnPassantColor = ChessPieceColor.White;
        this.EnPassantPosition = (byte) 43;
      }
      else if (fen.Contains("e3"))
      {
        this.EnPassantColor = ChessPieceColor.White;
        this.EnPassantPosition = (byte) 44;
      }
      else if (fen.Contains("f3"))
      {
        this.EnPassantColor = ChessPieceColor.White;
        this.EnPassantPosition = (byte) 45;
      }
      else if (fen.Contains("g3"))
      {
        this.EnPassantColor = ChessPieceColor.White;
        this.EnPassantPosition = (byte) 46;
      }
      else if (fen.Contains("h3"))
      {
        this.EnPassantColor = ChessPieceColor.White;
        this.EnPassantPosition = (byte) 47;
      }
      if (fen.Contains("a6"))
      {
        this.EnPassantColor = ChessPieceColor.Black;
        this.EnPassantPosition = (byte) 16;
      }
      else if (fen.Contains("b6"))
      {
        this.EnPassantColor = ChessPieceColor.Black;
        this.EnPassantPosition = (byte) 17;
      }
      else if (fen.Contains("c6"))
      {
        this.EnPassantColor = ChessPieceColor.Black;
        this.EnPassantPosition = (byte) 18;
      }
      else if (fen.Contains("d6"))
      {
        this.EnPassantColor = ChessPieceColor.Black;
        this.EnPassantPosition = (byte) 19;
      }
      else if (fen.Contains("e6"))
      {
        this.EnPassantColor = ChessPieceColor.Black;
        this.EnPassantPosition = (byte) 20;
      }
      else if (fen.Contains("f6"))
      {
        this.EnPassantColor = ChessPieceColor.Black;
        this.EnPassantPosition = (byte) 21;
      }
      else if (fen.Contains("g6"))
      {
        this.EnPassantColor = ChessPieceColor.Black;
        this.EnPassantPosition = (byte) 22;
      }
      else if (fen.Contains("h6"))
      {
        this.EnPassantColor = ChessPieceColor.Black;
        this.EnPassantPosition = (byte) 23;
      }
      if (fen.Contains(" w "))
        this.WhoseMove = ChessPieceColor.White;
      if (fen.Contains(" b "))
        this.WhoseMove = ChessPieceColor.Black;
      foreach (char ch in fen)
      {
        if ((int) num1 < 64 && (int) num2 == 0)
        {
          if ((int) ch == 49 && (int) num1 < 63)
            ++num1;
          else if ((int) ch == 50 && (int) num1 < 62)
            num1 += (byte) 2;
          else if ((int) ch == 51 && (int) num1 < 61)
            num1 += (byte) 3;
          else if ((int) ch == 52 && (int) num1 < 60)
            num1 += (byte) 4;
          else if ((int) ch == 53 && (int) num1 < 59)
            num1 += (byte) 5;
          else if ((int) ch == 54 && (int) num1 < 58)
            num1 += (byte) 6;
          else if ((int) ch == 55 && (int) num1 < 57)
            num1 += (byte) 7;
          else if ((int) ch == 56 && (int) num1 < 56)
            num1 += (byte) 8;
          else if ((int) ch == 80)
          {
            this.Squares[(int) num1].Piece = new Piece(ChessPieceType.Pawn, ChessPieceColor.White);
            this.Squares[(int) num1].Piece.Moved = true;
            ++num1;
          }
          else if ((int) ch == 78)
          {
            this.Squares[(int) num1].Piece = new Piece(ChessPieceType.Knight, ChessPieceColor.White);
            this.Squares[(int) num1].Piece.Moved = true;
            ++num1;
          }
          else if ((int) ch == 66)
          {
            this.Squares[(int) num1].Piece = new Piece(ChessPieceType.Bishop, ChessPieceColor.White);
            this.Squares[(int) num1].Piece.Moved = true;
            ++num1;
          }
          else if ((int) ch == 82)
          {
            this.Squares[(int) num1].Piece = new Piece(ChessPieceType.Rook, ChessPieceColor.White);
            this.Squares[(int) num1].Piece.Moved = true;
            ++num1;
          }
          else if ((int) ch == 81)
          {
            this.Squares[(int) num1].Piece = new Piece(ChessPieceType.Queen, ChessPieceColor.White);
            this.Squares[(int) num1].Piece.Moved = true;
            ++num1;
          }
          else if ((int) ch == 75)
          {
            this.Squares[(int) num1].Piece = new Piece(ChessPieceType.King, ChessPieceColor.White);
            this.Squares[(int) num1].Piece.Moved = true;
            ++num1;
          }
          else if ((int) ch == 112)
          {
            this.Squares[(int) num1].Piece = new Piece(ChessPieceType.Pawn, ChessPieceColor.Black);
            this.Squares[(int) num1].Piece.Moved = true;
            ++num1;
          }
          else if ((int) ch == 110)
          {
            this.Squares[(int) num1].Piece = new Piece(ChessPieceType.Knight, ChessPieceColor.Black);
            this.Squares[(int) num1].Piece.Moved = true;
            ++num1;
          }
          else if ((int) ch == 98)
          {
            this.Squares[(int) num1].Piece = new Piece(ChessPieceType.Bishop, ChessPieceColor.Black);
            this.Squares[(int) num1].Piece.Moved = true;
            ++num1;
          }
          else if ((int) ch == 114)
          {
            this.Squares[(int) num1].Piece = new Piece(ChessPieceType.Rook, ChessPieceColor.Black);
            this.Squares[(int) num1].Piece.Moved = true;
            ++num1;
          }
          else if ((int) ch == 113)
          {
            this.Squares[(int) num1].Piece = new Piece(ChessPieceType.Queen, ChessPieceColor.Black);
            this.Squares[(int) num1].Piece.Moved = true;
            ++num1;
          }
          else if ((int) ch == 107)
          {
            this.Squares[(int) num1].Piece = new Piece(ChessPieceType.King, ChessPieceColor.Black);
            this.Squares[(int) num1].Piece.Moved = true;
            ++num1;
          }
          else if ((int) ch != 47 && (int) ch == 32)
            ++num2;
        }
        else if ((int) ch == 75)
        {
          if (this.Squares[60].Piece != null && this.Squares[60].Piece.PieceType == ChessPieceType.King)
            this.Squares[60].Piece.Moved = false;
          if (this.Squares[63].Piece != null && this.Squares[63].Piece.PieceType == ChessPieceType.Rook)
            this.Squares[63].Piece.Moved = false;
          this.WhiteCastled = false;
        }
        else if ((int) ch == 81)
        {
          if (this.Squares[60].Piece != null && this.Squares[60].Piece.PieceType == ChessPieceType.King)
            this.Squares[60].Piece.Moved = false;
          if (this.Squares[56].Piece != null && this.Squares[56].Piece.PieceType == ChessPieceType.Rook)
            this.Squares[56].Piece.Moved = false;
          this.WhiteCastled = false;
        }
        else if ((int) ch == 107)
        {
          if (this.Squares[4].Piece != null && this.Squares[4].Piece.PieceType == ChessPieceType.King)
            this.Squares[4].Piece.Moved = false;
          if (this.Squares[7].Piece != null && this.Squares[7].Piece.PieceType == ChessPieceType.Rook)
            this.Squares[7].Piece.Moved = false;
          this.BlackCastled = false;
        }
        else if ((int) ch == 113)
        {
          if (this.Squares[4].Piece != null && this.Squares[4].Piece.PieceType == ChessPieceType.King)
            this.Squares[4].Piece.Moved = false;
          if (this.Squares[0].Piece != null && this.Squares[0].Piece.PieceType == ChessPieceType.Rook)
            this.Squares[0].Piece.Moved = false;
          this.BlackCastled = false;
        }
        else if ((int) ch == 32)
          ++num3;
        else if ((int) ch == 49 && (int) num3 == 4)
          this.FiftyMove = (byte) ((int) this.FiftyMove * 10 + 1);
        else if ((int) ch == 50 && (int) num3 == 4)
          this.FiftyMove = (byte) ((int) this.FiftyMove * 10 + 2);
        else if ((int) ch == 51 && (int) num3 == 4)
          this.FiftyMove = (byte) ((int) this.FiftyMove * 10 + 3);
        else if ((int) ch == 52 && (int) num3 == 4)
          this.FiftyMove = (byte) ((int) this.FiftyMove * 10 + 4);
        else if ((int) ch == 53 && (int) num3 == 4)
          this.FiftyMove = (byte) ((int) this.FiftyMove * 10 + 5);
        else if ((int) ch == 54 && (int) num3 == 4)
          this.FiftyMove = (byte) ((int) this.FiftyMove * 10 + 6);
        else if ((int) ch == 55 && (int) num3 == 4)
          this.FiftyMove = (byte) ((int) this.FiftyMove * 10 + 7);
        else if ((int) ch == 56 && (int) num3 == 4)
          this.FiftyMove = (byte) ((int) this.FiftyMove * 10 + 8);
        else if ((int) ch == 57 && (int) num3 == 4)
          this.FiftyMove = (byte) ((int) this.FiftyMove * 10 + 9);
        else if ((int) ch == 48 && (int) num3 == 4)
          this.MoveCount = (int) (byte) (this.MoveCount * 10 + 0);
        else if ((int) ch == 49 && (int) num3 == 5)
          this.MoveCount = (int) (byte) (this.MoveCount * 10 + 1);
        else if ((int) ch == 50 && (int) num3 == 5)
          this.MoveCount = (int) (byte) (this.MoveCount * 10 + 2);
        else if ((int) ch == 51 && (int) num3 == 5)
          this.MoveCount = (int) (byte) (this.MoveCount * 10 + 3);
        else if ((int) ch == 52 && (int) num3 == 5)
          this.MoveCount = (int) (byte) (this.MoveCount * 10 + 4);
        else if ((int) ch == 53 && (int) num3 == 5)
          this.MoveCount = (int) (byte) (this.MoveCount * 10 + 5);
        else if ((int) ch == 54 && (int) num3 == 5)
          this.MoveCount = (int) (byte) (this.MoveCount * 10 + 6);
        else if ((int) ch == 55 && (int) num3 == 5)
          this.MoveCount = (int) (byte) (this.MoveCount * 10 + 7);
        else if ((int) ch == 56 && (int) num3 == 5)
          this.MoveCount = (int) (byte) (this.MoveCount * 10 + 8);
        else if ((int) ch == 57 && (int) num3 == 5)
          this.MoveCount = (int) (byte) (this.MoveCount * 10 + 9);
        else if ((int) ch == 48 && (int) num3 == 5)
          this.MoveCount = (int) (byte) (this.MoveCount * 10 + 0);
      }
      Zobrist.InitiateZobristTable();
      this.ZobristHash = Zobrist.CalculateZobristHash(this);
    }

    internal Board()
    {
      this.Squares = new Square[64];
      for (byte index = 0; (int) index < 64; ++index)
        this.Squares[(int) index] = new Square();
      this.LastMove = new MoveContent();
      this.BlackCanCastle = true;
      this.WhiteCanCastle = true;
      this.WhiteAttackBoard = new bool[64];
      this.BlackAttackBoard = new bool[64];
    }

    private Board(Square[] squares)
    {
      this.Squares = new Square[64];
      for (byte index = 0; (int) index < 64; ++index)
      {
        if (squares[(int) index].Piece != null)
          this.Squares[(int) index].Piece = new Piece(squares[(int) index].Piece);
      }
      this.WhiteAttackBoard = new bool[64];
      this.BlackAttackBoard = new bool[64];
    }

    internal Board(int score)
      : this()
    {
      this.Score = score;
      this.WhiteAttackBoard = new bool[64];
      this.BlackAttackBoard = new bool[64];
    }

    internal Board(Board board)
    {
      this.Squares = new Square[64];
      for (byte index = 0; (int) index < 64; ++index)
      {
        if (board.Squares[(int) index].Piece != null)
          this.Squares[(int) index] = new Square(board.Squares[(int) index].Piece);
      }
      this.WhiteAttackBoard = new bool[64];
      this.BlackAttackBoard = new bool[64];
      for (byte index = 0; (int) index < 64; ++index)
      {
        this.WhiteAttackBoard[(int) index] = board.WhiteAttackBoard[(int) index];
        this.BlackAttackBoard[(int) index] = board.BlackAttackBoard[(int) index];
      }
      this.EndGamePhase = board.EndGamePhase;
      this.FiftyMove = board.FiftyMove;
      this.RepeatedMove = board.RepeatedMove;
      this.WhiteCastled = board.WhiteCastled;
      this.BlackCastled = board.BlackCastled;
      this.WhiteCanCastle = board.WhiteCanCastle;
      this.BlackCanCastle = board.BlackCanCastle;
      this.WhiteKingPosition = board.WhiteKingPosition;
      this.BlackKingPosition = board.BlackKingPosition;
      this.BlackCheck = board.BlackCheck;
      this.WhiteCheck = board.WhiteCheck;
      this.StaleMate = board.StaleMate;
      this.WhiteMate = board.WhiteMate;
      this.BlackMate = board.BlackMate;
      this.WhoseMove = board.WhoseMove;
      this.EnPassantPosition = board.EnPassantPosition;
      this.EnPassantColor = board.EnPassantColor;
      this.ZobristHash = board.ZobristHash;
      this.Score = board.Score;
      this.LastMove = new MoveContent(board.LastMove);
      this.MoveCount = board.MoveCount;
    }

    private static bool PromotePawns(Board board, Piece piece, byte dstPosition, ChessPieceType promoteToPiece)
    {
      if (piece.PieceType == ChessPieceType.Pawn)
      {
        if ((int) dstPosition < 8)
        {
          board.Squares[(int) dstPosition].Piece.PieceType = promoteToPiece;
          board.Squares[(int) dstPosition].Piece.PieceValue = Piece.CalculatePieceValue(promoteToPiece);
          board.Squares[(int) dstPosition].Piece.PieceActionValue = Piece.CalculatePieceActionValue(promoteToPiece);
          return true;
        }
        if ((int) dstPosition > 55)
        {
          board.Squares[(int) dstPosition].Piece.PieceType = promoteToPiece;
          board.Squares[(int) dstPosition].Piece.PieceValue = Piece.CalculatePieceValue(promoteToPiece);
          board.Squares[(int) dstPosition].Piece.PieceActionValue = Piece.CalculatePieceActionValue(promoteToPiece);
          return true;
        }
      }
      return false;
    }

    private static void RecordEnPassant(ChessPieceColor pcColor, ChessPieceType pcType, Board board, byte srcPosition, byte dstPosition)
    {
      if (pcType != ChessPieceType.Pawn)
        return;
      board.FiftyMove = (byte) 0;
      int num = (int) srcPosition - (int) dstPosition;
      switch (num)
      {
        case 16:
        case -16:
          board.EnPassantPosition = (byte) ((uint) dstPosition + (uint) (num / 2));
          board.EnPassantColor = pcColor;
          break;
      }
    }

    private static bool SetEnpassantMove(Board board, byte srcPosition, byte dstPosition, ChessPieceColor pcColor)
    {
      if ((int) board.EnPassantPosition != (int) dstPosition || pcColor == board.EnPassantColor || board.Squares[(int) srcPosition].Piece.PieceType != ChessPieceType.Pawn)
        return false;
      int num = 8;
      if (board.EnPassantColor == ChessPieceColor.White)
        num = -8;
      dstPosition += (byte) num;
      Square square = board.Squares[(int) dstPosition];
      board.LastMove.TakenPiece = new PieceTaken(square.Piece.PieceColor, square.Piece.PieceType, square.Piece.Moved, dstPosition);
      board.Squares[(int) dstPosition].Piece = (Piece) null;
      board.FiftyMove = (byte) 0;
      return true;
    }

    private static void KingCastle(Board board, Piece piece, byte srcPosition, byte dstPosition)
    {
      if (piece.PieceType != ChessPieceType.King)
        return;
      if (piece.PieceColor == ChessPieceColor.White && (int) srcPosition == 60)
      {
        if ((int) dstPosition == 62)
        {
          if (board.Squares[63].Piece == null)
            return;
          board.Squares[61].Piece = board.Squares[63].Piece;
          board.Squares[63].Piece = (Piece) null;
          board.WhiteCastled = true;
          board.LastMove.MovingPieceSecondary = new PieceMoving(board.Squares[61].Piece.PieceColor, board.Squares[61].Piece.PieceType, board.Squares[61].Piece.Moved, (byte) 63, (byte) 61);
          board.Squares[61].Piece.Moved = true;
        }
        else
        {
          if ((int) dstPosition != 58 || board.Squares[56].Piece == null)
            return;
          board.Squares[59].Piece = board.Squares[56].Piece;
          board.Squares[56].Piece = (Piece) null;
          board.WhiteCastled = true;
          board.LastMove.MovingPieceSecondary = new PieceMoving(board.Squares[59].Piece.PieceColor, board.Squares[59].Piece.PieceType, board.Squares[59].Piece.Moved, (byte) 56, (byte) 59);
          board.Squares[59].Piece.Moved = true;
        }
      }
      else
      {
        if (piece.PieceColor != ChessPieceColor.Black || (int) srcPosition != 4)
          return;
        if ((int) dstPosition == 6)
        {
          if (board.Squares[7].Piece == null)
            return;
          board.Squares[5].Piece = board.Squares[7].Piece;
          board.Squares[7].Piece = (Piece) null;
          board.BlackCastled = true;
          board.LastMove.MovingPieceSecondary = new PieceMoving(board.Squares[5].Piece.PieceColor, board.Squares[5].Piece.PieceType, board.Squares[5].Piece.Moved, (byte) 7, (byte) 5);
          board.Squares[5].Piece.Moved = true;
        }
        else
        {
          if ((int) dstPosition != 2 || board.Squares[0].Piece == null)
            return;
          board.Squares[3].Piece = board.Squares[0].Piece;
          board.Squares[0].Piece = (Piece) null;
          board.BlackCastled = true;
          board.LastMove.MovingPieceSecondary = new PieceMoving(board.Squares[3].Piece.PieceColor, board.Squares[3].Piece.PieceType, board.Squares[3].Piece.Moved, (byte) 0, (byte) 3);
          board.Squares[3].Piece.Moved = true;
        }
      }
    }

    internal Board FastCopy()
    {
      Board board = new Board(this.Squares);
      int num1 = this.EndGamePhase ? 1 : 0;
      board.EndGamePhase = num1 != 0;
      int whoseMove = (int) this.WhoseMove;
      board.WhoseMove = (ChessPieceColor) whoseMove;
      int moveCount = this.MoveCount;
      board.MoveCount = moveCount;
      int fiftyMove = (int) this.FiftyMove;
      board.FiftyMove = (byte) fiftyMove;
      long zobristHash = (long) this.ZobristHash;
      board.ZobristHash = (ulong) zobristHash;
      int num2 = this.BlackCastled ? 1 : 0;
      board.BlackCastled = num2 != 0;
      int num3 = this.WhiteCastled ? 1 : 0;
      board.WhiteCastled = num3 != 0;
      int num4 = this.WhiteCanCastle ? 1 : 0;
      board.WhiteCanCastle = num4 != 0;
      int num5 = this.BlackCanCastle ? 1 : 0;
      board.BlackCanCastle = num5 != 0;
      this.WhiteAttackBoard = new bool[64];
      this.BlackAttackBoard = new bool[64];
      return board;
    }

    internal static MoveContent MovePiece(Board board, byte srcPosition, byte dstPosition, ChessPieceType promoteToPiece)
    {
      Piece piece = board.Squares[(int) srcPosition].Piece;
      board.LastMove = new MoveContent();
      if (piece.PieceColor == ChessPieceColor.Black)
      {
        ++board.MoveCount;
        ++board.FiftyMove;
      }
      if ((int) board.EnPassantPosition > 0)
        board.LastMove.EnPassantOccured = Board.SetEnpassantMove(board, srcPosition, dstPosition, piece.PieceColor);
      if (!board.LastMove.EnPassantOccured)
      {
        Square square = board.Squares[(int) dstPosition];
        if (square.Piece != null)
        {
          board.LastMove.TakenPiece = new PieceTaken(square.Piece.PieceColor, square.Piece.PieceType, square.Piece.Moved, dstPosition);
          board.FiftyMove = (byte) 0;
        }
        else
          board.LastMove.TakenPiece = new PieceTaken(ChessPieceColor.White, ChessPieceType.None, false, dstPosition);
      }
      board.LastMove.MovingPiecePrimary = new PieceMoving(piece.PieceColor, piece.PieceType, piece.Moved, srcPosition, dstPosition);
      board.Squares[(int) srcPosition].Piece = (Piece) null;
      piece.Moved = true;
      piece.Selected = false;
      board.Squares[(int) dstPosition].Piece = piece;
      board.EnPassantPosition = (byte) 0;
      if (piece.PieceType == ChessPieceType.Pawn)
      {
        board.FiftyMove = (byte) 0;
        Board.RecordEnPassant(piece.PieceColor, piece.PieceType, board, srcPosition, dstPosition);
      }
      board.WhoseMove = board.WhoseMove == ChessPieceColor.White ? ChessPieceColor.Black : ChessPieceColor.White;
      Board.KingCastle(board, piece, srcPosition, dstPosition);
      if (Board.PromotePawns(board, piece, dstPosition, promoteToPiece))
      {
        board.ZobristHash = Zobrist.UpdateZobristHash(board.ZobristHash, board.LastMove, board.WhoseMove, true);
        board.LastMove.PawnPromotedTo = promoteToPiece;
      }
      else
      {
        board.ZobristHash = Zobrist.UpdateZobristHash(board.ZobristHash, board.LastMove, board.WhoseMove, false);
        board.LastMove.PawnPromotedTo = ChessPieceType.None;
      }
      if ((int) board.FiftyMove >= 50)
        board.StaleMate = true;
      return board.LastMove;
    }

    private static string GetColumnFromByte(byte column)
    {
      switch (column)
      {
        case 0:
          return "a";
        case 1:
          return "b";
        case 2:
          return "c";
        case 3:
          return "d";
        case 4:
          return "e";
        case 5:
          return "f";
        case 6:
          return "g";
        case 7:
          return "h";
        default:
          return "a";
      }
    }

    public new string ToString()
    {
      return Board.Fen(false, this);
    }

    internal static string Fen(bool boardOnly, Board board)
    {
      string str1 = string.Empty;
      byte num1 = 0;
      for (byte index = 0; (int) index < 64; ++index)
      {
        byte num2 = index;
        if (board.Squares[(int) num2].Piece != null)
        {
          if ((int) num1 > 0)
          {
            str1 += num1.ToString();
            num1 = (byte) 0;
          }
          str1 = board.Squares[(int) num2].Piece.PieceColor != ChessPieceColor.Black ? str1 + Piece.GetPieceTypeShort(board.Squares[(int) num2].Piece.PieceType) : str1 + Piece.GetPieceTypeShort(board.Squares[(int) num2].Piece.PieceType).ToLower();
        }
        else
          ++num1;
        if ((int) index % 8 == 7)
        {
          if ((int) num1 > 0)
          {
            str1 = str1 + num1.ToString() + "/";
            num1 = (byte) 0;
          }
          else if ((int) index > 0 && (int) index != 63)
            str1 += "/";
        }
      }
      string str2 = board.WhoseMove != ChessPieceColor.White ? str1 + " b " : str1 + " w ";
      string str3 = "";
      if (!board.WhiteCastled && board.Squares[60].Piece != null && !board.Squares[60].Piece.Moved)
      {
        if (board.Squares[63].Piece != null && !board.Squares[63].Piece.Moved)
        {
          str2 += "K";
          str3 = " ";
        }
        if (board.Squares[56].Piece != null && !board.Squares[56].Piece.Moved)
        {
          str2 += "Q";
          str3 = " ";
        }
      }
      if (!board.BlackCastled && board.Squares[4].Piece != null && !board.Squares[4].Piece.Moved)
      {
        if (board.Squares[7].Piece != null && !board.Squares[7].Piece.Moved)
        {
          str2 += "k";
          str3 = " ";
        }
        if (board.Squares[0].Piece != null && !board.Squares[0].Piece.Moved)
        {
          str2 += "q";
          str3 = " ";
        }
      }
      if (str2.EndsWith("/"))
        str2.TrimEnd('/');
      string str4;
      if ((int) board.EnPassantPosition != 0)
        str4 = str2 + (str3 + Board.GetColumnFromByte((byte) ((uint) board.EnPassantPosition % 8U))) + (object) (byte) (8U - (uint) (byte) ((uint) board.EnPassantPosition / 8U)) + " ";
      else
        str4 = str2 + str3 + "- ";
      if (!boardOnly)
        str4 = str4 + (object) board.FiftyMove + " " + (object) (board.MoveCount + 1);
      return str4.Trim();
    }
  }
}
