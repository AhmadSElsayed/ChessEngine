// Decompiled with JetBrains decompiler
// Type: ChessEngine.Engine.Engine
// Assembly: ChessEngine, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: 5AD2B565-9B75-423F-BD9A-4B0A934C5249
// Assembly location: C:\Users\Ahmad Elsayed\1\ChessBinNoSetup\ChessBinNoSetup\ChessEngine.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ChessEngine.Engine
{
  public sealed class Engine
  {
    public ChessPieceType PromoteToPieceType = ChessPieceType.Queen;
    public PiecesTaken PiecesTakenCount = new PiecesTaken();
    internal List<OpeningMove> CurrentGameBook;
    internal List<OpeningMove> UndoGameBook;
    private Board ChessBoard;
    private Board PreviousChessBoard;
    private Board UndoChessBoard;
    private Stack<MoveContent> MoveHistory;
    private List<OpeningMove> OpeningBook;
    private string pvLine;
    public ChessPieceColor HumanPlayer;
    public bool Thinking;
    public bool TrainingMode;
    public int NodesSearched;
    public int NodesQuiessence;
    public byte PlyDepthSearched;
    public byte PlyDepthReached;
    public byte RootMovesSearched;
    public ChessEngine.Engine.Engine.TimeSettings GameTimeSettings;

    public string FEN
    {
      get
      {
        return Board.Fen(false, this.ChessBoard);
      }
    }

    public string HashTableComposition
    {
      get
      {
        return Zobrist.ToString();
      }
    }

    public int HashTableNodesFound
    {
      get
      {
        return Zobrist.ZorbistNodesFound;
      }
    }

    public MoveContent LastMove
    {
      get
      {
        return this.ChessBoard.LastMove;
      }
    }

    public ChessEngine.Engine.Engine.Difficulty GameDifficulty
    {
      set
      {
        if (value == ChessEngine.Engine.Engine.Difficulty.Easy)
        {
          this.PlyDepthSearched = (byte) 4;
          this.GameTimeSettings = ChessEngine.Engine.Engine.TimeSettings.Moves40In10Minutes;
        }
        else if (value == ChessEngine.Engine.Engine.Difficulty.Medium)
        {
          this.PlyDepthSearched = (byte) 6;
          this.GameTimeSettings = ChessEngine.Engine.Engine.TimeSettings.Moves40In20Minutes;
        }
        else if (value == ChessEngine.Engine.Engine.Difficulty.Hard)
        {
          this.PlyDepthSearched = (byte) 7;
          this.GameTimeSettings = ChessEngine.Engine.Engine.TimeSettings.Moves40In60Minutes;
        }
        else
        {
          if (value != ChessEngine.Engine.Engine.Difficulty.VeryHard)
            return;
          this.PlyDepthSearched = (byte) 8;
          this.GameTimeSettings = ChessEngine.Engine.Engine.TimeSettings.Moves40In90Minutes;
        }
      }
    }

    public ChessPieceColor WhoseMove
    {
      get
      {
        return this.ChessBoard.WhoseMove;
      }
      set
      {
        this.ChessBoard.WhoseMove = value;
      }
    }

    public bool StaleMate
    {
      get
      {
        return this.ChessBoard.StaleMate;
      }
      set
      {
        this.ChessBoard.StaleMate = value;
      }
    }

    public bool RepeatedMove
    {
      get
      {
        return (int) this.ChessBoard.RepeatedMove >= 3;
      }
    }

    public string PvLine
    {
      get
      {
        return this.pvLine;
      }
    }

    public bool FiftyMove
    {
      get
      {
        return (int) this.ChessBoard.FiftyMove >= 50;
      }
    }

    public bool InsufficientMaterial
    {
      get
      {
        return this.ChessBoard.InsufficientMaterial;
      }
    }

    public Engine()
    {
      this.InitiateEngine();
      this.InitiateBoard("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1");
    }

    public Engine(string fen)
    {
      this.InitiateEngine();
      this.InitiateBoard(fen);
    }

    public void NewGame()
    {
      this.InitiateEngine();
      this.InitiateBoard("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1");
    }

    public void InitiateBoard(string fen)
    {
      this.ChessBoard = new Board(fen);
      if (string.IsNullOrEmpty(fen))
        return;
      PieceValidMoves.GenerateValidMoves(this.ChessBoard);
      Evaluation.EvaluateBoardScore(this.ChessBoard);
    }

    private void InitiateEngine()
    {
      this.GameDifficulty = ChessEngine.Engine.Engine.Difficulty.Medium;
      this.MoveHistory = new Stack<MoveContent>();
      this.HumanPlayer = ChessPieceColor.White;
      this.OpeningBook = new List<OpeningMove>();
      this.CurrentGameBook = new List<OpeningMove>();
      PieceMoves.InitiateChessPieceMotion();
      this.LoadOpeningBook();
    }

    public void SetChessPieceSelection(byte boardColumn, byte boardRow, bool selection)
    {
      byte boardIndex = ChessEngine.Engine.Engine.GetBoardIndex(boardColumn, boardRow);
      if (this.ChessBoard.Squares[(int) boardIndex].Piece == null || this.ChessBoard.Squares[(int) boardIndex].Piece.PieceColor != this.HumanPlayer || this.ChessBoard.Squares[(int) boardIndex].Piece.PieceColor != this.WhoseMove)
        return;
      this.ChessBoard.Squares[(int) boardIndex].Piece.Selected = selection;
    }

    public int ValidateOpeningBook()
    {
      return Book.ValidateOpeningBook(this.OpeningBook);
    }

    private static bool CheckForMate(ChessPieceColor whosTurn, ref Board chessBoard)
    {
      Search.SearchForMate(whosTurn, chessBoard, ref chessBoard.BlackMate, ref chessBoard.WhiteMate, ref chessBoard.StaleMate);
      return chessBoard.BlackMate || chessBoard.WhiteMate || chessBoard.StaleMate;
    }

    private static bool FindPlayBookMove(ref MoveContent bestMove, Board chessBoard, IEnumerable<OpeningMove> openingBook)
    {
      string str = Board.Fen(true, chessBoard);
      foreach (OpeningMove openingMove in openingBook)
      {
        if (openingMove.StartingFEN.Contains(str))
        {
          int index = 0;
          if (openingMove.Moves.Count > 1)
            index = new Random(DateTime.Now.Second).Next(openingMove.Moves.Count - 1);
          bestMove = openingMove.Moves[index];
          return true;
        }
      }
      return false;
    }

    public void Undo()
    {
      if (this.UndoChessBoard == null)
        return;
      this.PieceTakenRemove(this.ChessBoard.LastMove);
      this.PieceTakenRemove(this.PreviousChessBoard.LastMove);
      this.ChessBoard = new Board(this.UndoChessBoard);
      this.CurrentGameBook = new List<OpeningMove>((IEnumerable<OpeningMove>) this.UndoGameBook);
      PieceValidMoves.GenerateValidMoves(this.ChessBoard);
      Evaluation.EvaluateBoardScore(this.ChessBoard);
    }

    private static byte GetBoardIndex(byte boardColumn, byte boardRow)
    {
      return (byte) ((uint) boardColumn + (uint) boardRow * 8U);
    }

    public byte[] GetEnPassantMoves()
    {
      if (this.ChessBoard == null)
        return (byte[]) null;
      return new byte[2]
      {
        (byte) ((uint) this.ChessBoard.EnPassantPosition % 8U),
        (byte) ((uint) this.ChessBoard.EnPassantPosition / 8U)
      };
    }

    public bool GetBlackMate()
    {
      if (this.ChessBoard == null)
        return false;
      return this.ChessBoard.BlackMate;
    }

    public bool GetWhiteMate()
    {
      return this.ChessBoard.WhiteMate;
    }

    public bool GetBlackCheck()
    {
      return this.ChessBoard.BlackCheck;
    }

    public bool GetWhiteCheck()
    {
      return this.ChessBoard.WhiteCheck;
    }

    public byte GetRepeatedMove()
    {
      return this.ChessBoard.RepeatedMove;
    }

    public byte GetFiftyMoveCount()
    {
      return this.ChessBoard.FiftyMove;
    }

    public Stack<MoveContent> GetMoveHistory()
    {
      return this.MoveHistory;
    }

    public ChessPieceType GetPieceTypeAt(byte boardColumn, byte boardRow)
    {
      byte boardIndex = ChessEngine.Engine.Engine.GetBoardIndex(boardColumn, boardRow);
      if (this.ChessBoard.Squares[(int) boardIndex].Piece == null)
        return ChessPieceType.None;
      return this.ChessBoard.Squares[(int) boardIndex].Piece.PieceType;
    }

    public ChessPieceType GetPieceTypeAt(byte index)
    {
      if (this.ChessBoard.Squares[(int) index].Piece == null)
        return ChessPieceType.None;
      return this.ChessBoard.Squares[(int) index].Piece.PieceType;
    }

    public ChessPieceColor GetPieceColorAt(byte boardColumn, byte boardRow)
    {
      byte boardIndex = ChessEngine.Engine.Engine.GetBoardIndex(boardColumn, boardRow);
      if (this.ChessBoard.Squares[(int) boardIndex].Piece == null)
        return ChessPieceColor.White;
      return this.ChessBoard.Squares[(int) boardIndex].Piece.PieceColor;
    }

    public ChessPieceColor GetPieceColorAt(byte index)
    {
      if (this.ChessBoard.Squares[(int) index].Piece == null)
        return ChessPieceColor.White;
      return this.ChessBoard.Squares[(int) index].Piece.PieceColor;
    }

    public bool GetChessPieceSelected(byte boardColumn, byte boardRow)
    {
      byte boardIndex = ChessEngine.Engine.Engine.GetBoardIndex(boardColumn, boardRow);
      if (this.ChessBoard.Squares[(int) boardIndex].Piece == null)
        return false;
      return this.ChessBoard.Squares[(int) boardIndex].Piece.Selected;
    }

    public void GenerateValidMoves()
    {
      PieceValidMoves.GenerateValidMoves(this.ChessBoard);
    }

    public int EvaluateBoardScore()
    {
      Evaluation.EvaluateBoardScore(this.ChessBoard);
      return this.ChessBoard.Score;
    }

    public byte[][] GetValidMoves(byte boardColumn, byte boardRow)
    {
      byte boardIndex = ChessEngine.Engine.Engine.GetBoardIndex(boardColumn, boardRow);
      if (this.ChessBoard.Squares[(int) boardIndex].Piece == null)
        return (byte[][]) null;
      byte[][] numArray = new byte[this.ChessBoard.Squares[(int) boardIndex].Piece.ValidMoves.Count][];
      int index = 0;
      foreach (byte validMove in this.ChessBoard.Squares[(int) boardIndex].Piece.ValidMoves)
      {
        numArray[index] = new byte[2];
        numArray[index][0] = (byte) ((uint) validMove % 8U);
        numArray[index][1] = (byte) ((uint) validMove / 8U);
        ++index;
      }
      return numArray;
    }

    public int GetScore()
    {
      return this.ChessBoard.Score;
    }

    public byte FindSourcePositon(ChessPieceType chessPieceType, ChessPieceColor chessPieceColor, byte dstPosition, bool capture, int forceCol, int forceRow)
    {
      if ((int) dstPosition == (int) this.ChessBoard.EnPassantPosition && chessPieceType == ChessPieceType.Pawn)
      {
        if (chessPieceColor == ChessPieceColor.White)
        {
          Square square1 = this.ChessBoard.Squares[(int) dstPosition + 7];
          if (square1.Piece != null && square1.Piece.PieceType == ChessPieceType.Pawn && square1.Piece.PieceColor == chessPieceColor && (((int) dstPosition + 7) % 8 == forceCol || forceCol == -1))
            return (byte) ((uint) dstPosition + 7U);
          Square square2 = this.ChessBoard.Squares[(int) dstPosition + 9];
          if (square2.Piece != null && square2.Piece.PieceType == ChessPieceType.Pawn && square2.Piece.PieceColor == chessPieceColor && (((int) dstPosition + 9) % 8 == forceCol || forceCol == -1))
            return (byte) ((uint) dstPosition + 9U);
        }
        else
        {
          if ((int) dstPosition - 7 >= 0)
          {
            Square square = this.ChessBoard.Squares[(int) dstPosition - 7];
            if (square.Piece != null && square.Piece.PieceType == ChessPieceType.Pawn && square.Piece.PieceColor == chessPieceColor && (((int) dstPosition - 7) % 8 == forceCol || forceCol == -1))
              return (byte) ((uint) dstPosition - 7U);
          }
          if ((int) dstPosition - 9 >= 0)
          {
            Square square = this.ChessBoard.Squares[(int) dstPosition - 9];
            if (square.Piece != null && square.Piece.PieceType == ChessPieceType.Pawn && square.Piece.PieceColor == chessPieceColor && (((int) dstPosition - 9) % 8 == forceCol || forceCol == -1))
              return (byte) ((uint) dstPosition - 9U);
          }
        }
      }
      for (byte index = 0; (int) index < 64; ++index)
      {
        Square square = this.ChessBoard.Squares[(int) index];
        if (square.Piece != null && square.Piece.PieceType == chessPieceType && square.Piece.PieceColor == chessPieceColor)
        {
          foreach (int validMove in square.Piece.ValidMoves)
          {
            if (validMove == (int) dstPosition && (!capture && ((int) (byte) ((uint) index / 8U) == forceRow || forceRow == -1) && ((int) index % 8 == forceCol || forceCol == -1) || this.ChessBoard.Squares[(int) dstPosition].Piece != null && this.ChessBoard.Squares[(int) dstPosition].Piece.PieceColor != chessPieceColor && ((int) index % 8 == forceCol || forceCol == -1) && ((int) (byte) ((uint) index / 8U) == forceRow || forceRow == -1)))
              return index;
          }
        }
      }
      return 0;
    }

    public bool IsValidMove(byte srcPosition, byte dstPosition)
    {
      if (this.ChessBoard == null || this.ChessBoard.Squares == null || this.ChessBoard.Squares[(int) srcPosition].Piece == null)
        return false;
      foreach (int validMove in this.ChessBoard.Squares[(int) srcPosition].Piece.ValidMoves)
      {
        if (validMove == (int) dstPosition)
          return true;
      }
      return (int) dstPosition == (int) this.ChessBoard.EnPassantPosition;
    }

    public bool IsValidMove(byte sourceColumn, byte sourceRow, byte destinationColumn, byte destinationRow)
    {
      if (this.ChessBoard == null || this.ChessBoard.Squares == null)
        return false;
      byte boardIndex = ChessEngine.Engine.Engine.GetBoardIndex(sourceColumn, sourceRow);
      if (this.ChessBoard.Squares[(int) boardIndex].Piece == null)
        return false;
      foreach (byte validMove in this.ChessBoard.Squares[(int) boardIndex].Piece.ValidMoves)
      {
        if ((int) validMove % 8 == (int) destinationColumn && (int) (byte) ((uint) validMove / 8U) == (int) destinationRow)
          return true;
      }
      return (int) ChessEngine.Engine.Engine.GetBoardIndex(destinationColumn, destinationRow) == (int) this.ChessBoard.EnPassantPosition && (int) this.ChessBoard.EnPassantPosition > 0;
    }

    public bool IsGameOver()
    {
      return this.ChessBoard.StaleMate || this.ChessBoard.WhiteMate || (this.ChessBoard.BlackMate || (int) this.ChessBoard.FiftyMove >= 50) || ((int) this.ChessBoard.RepeatedMove >= 3 || this.ChessBoard.InsufficientMaterial);
    }

    public bool IsTie()
    {
      return this.ChessBoard.StaleMate || (int) this.ChessBoard.FiftyMove >= 50 || ((int) this.ChessBoard.RepeatedMove >= 3 || this.ChessBoard.InsufficientMaterial);
    }

    public bool MovePiece(byte srcPosition, byte dstPosition)
    {
      Piece piece = this.ChessBoard.Squares[(int) srcPosition].Piece;
      this.PreviousChessBoard = new Board(this.ChessBoard);
      this.UndoChessBoard = new Board(this.ChessBoard);
      this.UndoGameBook = new List<OpeningMove>((IEnumerable<OpeningMove>) this.CurrentGameBook);
      Board.MovePiece(this.ChessBoard, srcPosition, dstPosition, this.PromoteToPieceType);
      this.ChessBoard.LastMove.GeneratePGNString(this.ChessBoard);
      PieceValidMoves.GenerateValidMoves(this.ChessBoard);
      Evaluation.EvaluateBoardScore(this.ChessBoard);
      if (piece.PieceColor == ChessPieceColor.White)
      {
        if (this.ChessBoard.WhiteCheck)
        {
          this.ChessBoard = new Board(this.PreviousChessBoard);
          PieceValidMoves.GenerateValidMoves(this.ChessBoard);
          return false;
        }
      }
      else if (piece.PieceColor == ChessPieceColor.Black && this.ChessBoard.BlackCheck)
      {
        this.ChessBoard = new Board(this.PreviousChessBoard);
        PieceValidMoves.GenerateValidMoves(this.ChessBoard);
        return false;
      }
      this.MoveHistory.Push(this.ChessBoard.LastMove);
      ChessEngine.Engine.Engine.CheckForMate(this.WhoseMove, ref this.ChessBoard);
      this.PieceTakenAdd(this.ChessBoard.LastMove);
      if (this.ChessBoard.WhiteMate || this.ChessBoard.BlackMate)
        this.LastMove.PgnMove += "#";
      else if (this.ChessBoard.WhiteCheck || this.ChessBoard.BlackCheck)
        this.LastMove.PgnMove += "+";
      return true;
    }

    private void PieceTakenAdd(MoveContent lastMove)
    {
      if (lastMove.TakenPiece.PieceType == ChessPieceType.None)
        return;
      if (lastMove.TakenPiece.PieceColor == ChessPieceColor.White)
      {
        if (lastMove.TakenPiece.PieceType == ChessPieceType.Queen)
          ++this.PiecesTakenCount.WhiteQueen;
        else if (lastMove.TakenPiece.PieceType == ChessPieceType.Rook)
          ++this.PiecesTakenCount.WhiteRook;
        else if (lastMove.TakenPiece.PieceType == ChessPieceType.Bishop)
          ++this.PiecesTakenCount.WhiteBishop;
        else if (lastMove.TakenPiece.PieceType == ChessPieceType.Knight)
          ++this.PiecesTakenCount.WhiteKnight;
        else if (lastMove.TakenPiece.PieceType == ChessPieceType.Pawn)
          ++this.PiecesTakenCount.WhitePawn;
      }
      if (this.ChessBoard.LastMove.TakenPiece.PieceColor != ChessPieceColor.Black)
        return;
      if (lastMove.TakenPiece.PieceType == ChessPieceType.Queen)
        ++this.PiecesTakenCount.BlackQueen;
      else if (lastMove.TakenPiece.PieceType == ChessPieceType.Rook)
        ++this.PiecesTakenCount.BlackRook;
      else if (lastMove.TakenPiece.PieceType == ChessPieceType.Bishop)
        ++this.PiecesTakenCount.BlackBishop;
      else if (lastMove.TakenPiece.PieceType == ChessPieceType.Knight)
      {
        ++this.PiecesTakenCount.BlackKnight;
      }
      else
      {
        if (lastMove.TakenPiece.PieceType != ChessPieceType.Pawn)
          return;
        ++this.PiecesTakenCount.BlackPawn;
      }
    }

    private void PieceTakenRemove(MoveContent lastMove)
    {
      if (lastMove.TakenPiece.PieceType == ChessPieceType.None)
        return;
      if (lastMove.TakenPiece.PieceColor == ChessPieceColor.White)
      {
        if (lastMove.TakenPiece.PieceType == ChessPieceType.Queen)
          --this.PiecesTakenCount.WhiteQueen;
        else if (lastMove.TakenPiece.PieceType == ChessPieceType.Rook)
          --this.PiecesTakenCount.WhiteRook;
        else if (lastMove.TakenPiece.PieceType == ChessPieceType.Bishop)
          --this.PiecesTakenCount.WhiteBishop;
        else if (lastMove.TakenPiece.PieceType == ChessPieceType.Knight)
          --this.PiecesTakenCount.WhiteKnight;
        else if (lastMove.TakenPiece.PieceType == ChessPieceType.Pawn)
          --this.PiecesTakenCount.WhitePawn;
      }
      if (lastMove.TakenPiece.PieceColor != ChessPieceColor.Black)
        return;
      if (lastMove.TakenPiece.PieceType == ChessPieceType.Queen)
        --this.PiecesTakenCount.BlackQueen;
      else if (lastMove.TakenPiece.PieceType == ChessPieceType.Rook)
        --this.PiecesTakenCount.BlackRook;
      else if (lastMove.TakenPiece.PieceType == ChessPieceType.Bishop)
        --this.PiecesTakenCount.BlackBishop;
      else if (lastMove.TakenPiece.PieceType == ChessPieceType.Knight)
      {
        --this.PiecesTakenCount.BlackKnight;
      }
      else
      {
        if (lastMove.TakenPiece.PieceType != ChessPieceType.Pawn)
          return;
        --this.PiecesTakenCount.BlackPawn;
      }
    }

    public bool MovePiece(byte sourceColumn, byte sourceRow, byte destinationColumn, byte destinationRow)
    {
      return this.MovePiece((byte) ((uint) sourceColumn + (uint) sourceRow * 8U), (byte) ((uint) destinationColumn + (uint) destinationRow * 8U));
    }

    internal void SetChessPiece(Piece piece, byte index)
    {
      this.ChessBoard.Squares[(int) index].Piece = new Piece(piece);
    }

    public void AiPonderMove(BackgroundWorker worker)
    {
      this.Thinking = true;
      this.NodesSearched = 0;
      ResultBoards resultBoards = new ResultBoards();
      resultBoards.Positions = new List<Board>();
      if (ChessEngine.Engine.Engine.CheckForMate(this.WhoseMove, ref this.ChessBoard))
      {
        this.Thinking = false;
      }
      else
      {
        MoveContent bestMove = new MoveContent();
        if ((!ChessEngine.Engine.Engine.FindPlayBookMove(ref bestMove, this.ChessBoard, (IEnumerable<OpeningMove>) this.OpeningBook) || (int) this.ChessBoard.FiftyMove > 45 || (int) this.ChessBoard.RepeatedMove >= 2) && (!ChessEngine.Engine.Engine.FindPlayBookMove(ref bestMove, this.ChessBoard, (IEnumerable<OpeningMove>) this.CurrentGameBook) || (int) this.ChessBoard.FiftyMove > 45 || (int) this.ChessBoard.RepeatedMove >= 2))
          bestMove = Search.IterativeSearch(this.ChessBoard, this.PlyDepthSearched, ref this.NodesSearched, ref this.NodesQuiessence, ref this.pvLine, worker, ref this.PlyDepthReached, ref this.RootMovesSearched, this.CurrentGameBook);
        this.PreviousChessBoard = new Board(this.ChessBoard);
        this.RootMovesSearched = (byte) resultBoards.Positions.Count;
        Board.MovePiece(this.ChessBoard, bestMove.MovingPiecePrimary.SrcPosition, bestMove.MovingPiecePrimary.DstPosition, ChessPieceType.Queen);
        this.ChessBoard.LastMove.GeneratePGNString(this.ChessBoard);
        for (byte index = 0; (int) index < 64; ++index)
        {
          Square square = this.ChessBoard.Squares[(int) index];
          if (square.Piece != null)
          {
            square.Piece.DefendedValue = (short) 0;
            square.Piece.AttackedValue = (short) 0;
          }
        }
        PieceValidMoves.GenerateValidMoves(this.ChessBoard);
        Evaluation.EvaluateBoardScore(this.ChessBoard);
        this.PieceTakenAdd(this.ChessBoard.LastMove);
        this.MoveHistory.Push(this.ChessBoard.LastMove);
        if (ChessEngine.Engine.Engine.CheckForMate(this.WhoseMove, ref this.ChessBoard))
        {
          this.Thinking = false;
          if (!this.ChessBoard.WhiteMate && !this.ChessBoard.BlackMate)
            return;
          this.LastMove.PgnMove += "#";
        }
        else
        {
          if (this.ChessBoard.WhiteCheck || this.ChessBoard.BlackCheck)
            this.LastMove.PgnMove += "+";
          this.Thinking = false;
        }
      }
    }


   
    public bool LoadOpeningBook()
    {
            OpeningBook = Book.LoadOpeningBook().Result;
      return true;
    }

    public enum Difficulty
    {
      Easy,
      Medium,
      Hard,
      VeryHard,
    }

    public enum TimeSettings
    {
      Moves40In5Minutes,
      Moves40In10Minutes,
      Moves40In20Minutes,
      Moves40In30Minutes,
      Moves40In40Minutes,
      Moves40In60Minutes,
      Moves40In90Minutes,
    }
  }
}
