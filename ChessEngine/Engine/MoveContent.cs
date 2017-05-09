// Decompiled with JetBrains decompiler
// Type: ChessEngine.Engine.MoveContent
// Assembly: ChessEngine, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AD2B565-9B75-423F-BD9A-4B0A934C5249
// Assembly location: C:\Users\Ahmad Elsayed\1\ChessBinNoSetup\ChessBinNoSetup\ChessEngine.dll

namespace ChessEngine.Engine
{
  public sealed class MoveContent
  {
    public bool EnPassantOccured;
    public PieceMoving MovingPiecePrimary;
    public PieceMoving MovingPieceSecondary;
    public ChessPieceType PawnPromotedTo;
    public PieceTaken TakenPiece;
    public bool DoubleRowQueen;
    public bool DoubleColQueen;
    public bool DoubleRowRook;
    public bool DoubleColRook;
    public bool DoubleRowKnight;
    public bool DoubleColKnight;
    public string PgnMove;

    public MoveContent()
    {
      this.MovingPiecePrimary = new PieceMoving(ChessPieceType.None);
      this.MovingPieceSecondary = new PieceMoving(ChessPieceType.None);
      this.TakenPiece = new PieceTaken(ChessPieceType.None);
    }

    public MoveContent(MoveContent moveContent)
    {
      this.MovingPiecePrimary = new PieceMoving(moveContent.MovingPiecePrimary);
      this.MovingPieceSecondary = new PieceMoving(moveContent.MovingPieceSecondary);
      this.TakenPiece = new PieceTaken(moveContent.TakenPiece.PieceColor, moveContent.TakenPiece.PieceType, moveContent.TakenPiece.Moved, moveContent.TakenPiece.Position);
      this.EnPassantOccured = moveContent.EnPassantOccured;
      this.PawnPromotedTo = moveContent.PawnPromotedTo;
    }

    public MoveContent(string move)
      : this()
    {
      int col = -1;
      bool flag1 = false;
      bool flag2 = false;
      if (move.Contains("=Q"))
        this.PawnPromotedTo = ChessPieceType.Queen;
      else if (move.Contains("=N"))
        this.PawnPromotedTo = ChessPieceType.Knight;
      else if (move.Contains("=R"))
        this.PawnPromotedTo = ChessPieceType.Rook;
      else if (move.Contains("=B"))
        this.PawnPromotedTo = ChessPieceType.Bishop;
      foreach (char ch in move)
      {
        switch (ch)
        {
          case '{':
            flag1 = true;
            break;
          case '}':
            flag1 = false;
            break;
          default:
            if (!flag1)
            {
              if (this.MovingPiecePrimary.PieceType == ChessPieceType.None)
              {
                this.MovingPiecePrimary.PieceType = MoveContent.GetPieceType(ch);
                if (this.MovingPiecePrimary.PieceType == ChessPieceType.None)
                {
                  this.MovingPiecePrimary.PieceType = ChessPieceType.Pawn;
                  col = MoveContent.GetIntFromColumn(ch);
                  break;
                }
                break;
              }
              if (col < 0)
              {
                col = MoveContent.GetIntFromColumn(ch);
                break;
              }
              if (col >= 0)
              {
                int num = int.Parse(ch.ToString());
                if (!flag2)
                {
                  this.MovingPiecePrimary.SrcPosition = MoveContent.GetBoardIndex(col, 8 - num);
                  flag2 = true;
                }
                else
                  this.MovingPiecePrimary.DstPosition = MoveContent.GetBoardIndex(col, 8 - num);
                col = -1;
                break;
              }
              break;
            }
            break;
        }
      }
    }

    public new string ToString()
    {
      if (!string.IsNullOrEmpty(this.PgnMove))
        return this.PgnMove;
      byte num1 = (byte) ((uint) this.MovingPiecePrimary.SrcPosition % 8U);
      byte num2 = (byte) (8 - (int) this.MovingPiecePrimary.SrcPosition / 8);
      byte num3 = (byte) ((uint) this.MovingPiecePrimary.DstPosition % 8U);
      byte num4 = (byte) (8 - (int) this.MovingPiecePrimary.DstPosition / 8);
      if (this.MovingPieceSecondary.PieceType == ChessPieceType.Rook)
      {
        if (this.MovingPieceSecondary.PieceColor == ChessPieceColor.Black)
        {
          if ((int) this.MovingPieceSecondary.SrcPosition == 7)
            this.PgnMove = this.PgnMove + "O-O";
          else if ((int) this.MovingPieceSecondary.SrcPosition == 0)
            this.PgnMove = this.PgnMove + "O-O-O";
        }
        else if (this.MovingPieceSecondary.PieceColor == ChessPieceColor.White)
        {
          if ((int) this.MovingPieceSecondary.SrcPosition == 63)
            this.PgnMove = this.PgnMove + "O-O";
          else if ((int) this.MovingPieceSecondary.SrcPosition == 56)
            this.PgnMove = this.PgnMove + "O-O-O";
        }
      }
      else
      {
        this.PgnMove = this.PgnMove + MoveContent.GetPgnMove(this.MovingPiecePrimary.PieceType);
        switch (this.MovingPiecePrimary.PieceType)
        {
          case ChessPieceType.Rook:
            this.PgnMove = this.PgnMove + MoveContent.GetColumnFromInt((int) num1);
            this.PgnMove = this.PgnMove + (object) num2;
            break;
          case ChessPieceType.Knight:
            this.PgnMove = this.PgnMove + MoveContent.GetColumnFromInt((int) num1);
            this.PgnMove = this.PgnMove + (object) num2;
            break;
          case ChessPieceType.Pawn:
            if ((int) num1 != (int) num3)
            {
              this.PgnMove = this.PgnMove + MoveContent.GetColumnFromInt((int) num1);
              break;
            }
            break;
        }
        if (this.TakenPiece.PieceType != ChessPieceType.None)
          this.PgnMove = this.PgnMove + "x";
        this.PgnMove = this.PgnMove + MoveContent.GetColumnFromInt((int) num3);
        this.PgnMove = this.PgnMove + (object) num4;
        if (this.PawnPromotedTo == ChessPieceType.Queen)
          this.PgnMove = this.PgnMove + "=Q";
        else if (this.PawnPromotedTo == ChessPieceType.Rook)
          this.PgnMove = this.PgnMove + "=R";
        else if (this.PawnPromotedTo == ChessPieceType.Bishop)
          this.PgnMove = this.PgnMove + "=B";
        else if (this.PawnPromotedTo == ChessPieceType.Knight)
          this.PgnMove = this.PgnMove + "=N";
      }
      return this.PgnMove;
    }

    internal string GeneratePGNString(Board board)
    {
      if (!string.IsNullOrEmpty(this.PgnMove))
        return this.PgnMove;
      bool flag1 = false;
      bool flag2 = false;
      bool flag3 = false;
      byte num1 = (byte) ((uint) this.MovingPiecePrimary.SrcPosition % 8U);
      byte num2 = (byte) (8 - (int) this.MovingPiecePrimary.SrcPosition / 8);
      byte num3 = (byte) ((uint) this.MovingPiecePrimary.DstPosition % 8U);
      byte num4 = (byte) (8 - (int) this.MovingPiecePrimary.DstPosition / 8);
      this.PgnMove = "";
      for (byte index = 0; (int) index < 64; ++index)
      {
        if ((int) index != (int) this.MovingPiecePrimary.DstPosition)
        {
          Square square = board.Squares[(int) index];
          if (square.Piece != null && square.Piece.PieceType == this.MovingPiecePrimary.PieceType && square.Piece.PieceColor == this.MovingPiecePrimary.PieceColor)
          {
            foreach (int validMove in square.Piece.ValidMoves)
            {
              if (validMove == (int) this.MovingPiecePrimary.DstPosition)
              {
                flag3 = true;
                int num5 = (int) (byte) ((uint) index % 8U);
                byte num6 = (byte) (8 - (int) index / 8);
                int num7 = (int) num1;
                if (num5 == num7)
                  flag1 = true;
                if ((int) num6 == (int) num2)
                {
                  flag2 = true;
                  break;
                }
                break;
              }
            }
          }
        }
      }
      if (this.MovingPieceSecondary.PieceType == ChessPieceType.Rook)
      {
        if (this.MovingPieceSecondary.PieceColor == ChessPieceColor.Black)
        {
          if ((int) this.MovingPieceSecondary.SrcPosition == 7)
            this.PgnMove = this.PgnMove + "O-O";
          else if ((int) this.MovingPieceSecondary.SrcPosition == 0)
            this.PgnMove = this.PgnMove + "O-O-O";
        }
        else if (this.MovingPieceSecondary.PieceColor == ChessPieceColor.White)
        {
          if ((int) this.MovingPieceSecondary.SrcPosition == 63)
            this.PgnMove = this.PgnMove + "O-O";
          else if ((int) this.MovingPieceSecondary.SrcPosition == 56)
            this.PgnMove = this.PgnMove + "O-O-O";
        }
      }
      else
      {
        this.PgnMove = this.PgnMove + MoveContent.GetPgnMove(this.MovingPiecePrimary.PieceType);
        switch (this.MovingPiecePrimary.PieceType)
        {
          case ChessPieceType.Queen:
            if (flag3)
            {
              if (!flag1)
              {
                this.PgnMove = this.PgnMove + MoveContent.GetColumnFromInt((int) num1);
                break;
              }
              if (flag2)
                this.PgnMove = this.PgnMove + MoveContent.GetColumnFromInt((int) num1);
              this.PgnMove = this.PgnMove + (object) num2;
              break;
            }
            break;
          case ChessPieceType.Rook:
            if (flag3)
            {
              if (!flag1)
              {
                this.PgnMove = this.PgnMove + MoveContent.GetColumnFromInt((int) num1);
                break;
              }
              if (flag2)
                this.PgnMove = this.PgnMove + MoveContent.GetColumnFromInt((int) num1);
              this.PgnMove = this.PgnMove + (object) num2;
              break;
            }
            break;
          case ChessPieceType.Bishop:
            if (flag3)
            {
              if (!flag1)
              {
                this.PgnMove = this.PgnMove + MoveContent.GetColumnFromInt((int) num1);
                break;
              }
              if (flag2)
                this.PgnMove = this.PgnMove + MoveContent.GetColumnFromInt((int) num1);
              this.PgnMove = this.PgnMove + (object) num2;
              break;
            }
            break;
          case ChessPieceType.Knight:
            if (flag3)
            {
              if (!flag1)
              {
                this.PgnMove = this.PgnMove + MoveContent.GetColumnFromInt((int) num1);
                break;
              }
              if (flag2)
                this.PgnMove = this.PgnMove + MoveContent.GetColumnFromInt((int) num1);
              this.PgnMove = this.PgnMove + (object) num2;
              break;
            }
            break;
          case ChessPieceType.Pawn:
            if (flag3 && (int) num1 != (int) num3)
            {
              this.PgnMove = this.PgnMove + MoveContent.GetColumnFromInt((int) num1);
              break;
            }
            if (this.TakenPiece.PieceType != ChessPieceType.None)
            {
              this.PgnMove = this.PgnMove + MoveContent.GetColumnFromInt((int) num1);
              break;
            }
            break;
        }
        if (this.TakenPiece.PieceType != ChessPieceType.None)
          this.PgnMove = this.PgnMove + "x";
        this.PgnMove = this.PgnMove + MoveContent.GetColumnFromInt((int) num3);
        this.PgnMove = this.PgnMove + (object) num4;
        if (this.PawnPromotedTo == ChessPieceType.Queen)
          this.PgnMove = this.PgnMove + "=Q";
        else if (this.PawnPromotedTo == ChessPieceType.Rook)
          this.PgnMove = this.PgnMove + "=R";
        else if (this.PawnPromotedTo == ChessPieceType.Bishop)
          this.PgnMove = this.PgnMove + "=B";
        else if (this.PawnPromotedTo == ChessPieceType.Knight)
          this.PgnMove = this.PgnMove + "=N";
      }
      return this.PgnMove;
    }

    private static byte GetBoardIndex(int col, int row)
    {
      return (byte) (col + row * 8);
    }

    private static string GetColumnFromInt(int column)
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
          return "Unknown";
      }
    }

    private static int GetIntFromColumn(char column)
    {
      switch (column)
      {
        case 'a':
          return 0;
        case 'b':
          return 1;
        case 'c':
          return 2;
        case 'd':
          return 3;
        case 'e':
          return 4;
        case 'f':
          return 5;
        case 'g':
          return 6;
        case 'h':
          return 7;
        default:
          return -1;
      }
    }

    private static ChessPieceType GetPieceType(char c)
    {
      switch (c)
      {
        case 'B':
          return ChessPieceType.Bishop;
        case 'K':
          return ChessPieceType.King;
        case 'N':
          return ChessPieceType.Knight;
        case 'Q':
          return ChessPieceType.Queen;
        case 'R':
          return ChessPieceType.Rook;
        default:
          return ChessPieceType.None;
      }
    }

    private static string GetPgnMove(ChessPieceType pieceType)
    {
      switch (pieceType)
      {
        case ChessPieceType.King:
          return "K";
        case ChessPieceType.Queen:
          return "Q";
        case ChessPieceType.Rook:
          return "R";
        case ChessPieceType.Bishop:
          return "B";
        case ChessPieceType.Knight:
          return "N";
        default:
          return "";
      }
    }
  }
}
