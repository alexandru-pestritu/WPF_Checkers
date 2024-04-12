using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_Checkers.Models;

namespace Wpf_Checkers.Utils
{
    public class GameLogic
    {
        private GameInfo gameInfo;

        private int HighlightMove(Cell cell, int possibleMoves = 0, bool multiple = false)
        {
            if (cell.Piece == Piece.BlackPiece || cell.Piece == Piece.BlackKingPiece || cell.Piece == Piece.RedKingPiece)
            {

                if (cell.X != 7 && cell.Y != 7)
                {
                    if (gameInfo.Board[cell.X + 1][cell.Y + 1].Piece == null && !multiple)
                        gameInfo.Board[cell.X + 1][cell.Y + 1].Highlight = true;

                    else if (cell.Piece != Piece.RedKingPiece && (gameInfo.Board[cell.X + 1][cell.Y + 1].Piece == Piece.RedPiece || gameInfo.Board[cell.X + 1][cell.Y + 1].Piece == Piece.RedKingPiece) && cell.X < 6 && cell.Y < 6)
                    {
                        if (gameInfo.Board[cell.X + 2][cell.Y + 2].Piece == null)
                        {
                            gameInfo.Board[cell.X + 2][cell.Y + 2].Highlight = true;
                            ++possibleMoves;
                        }
                    }
                    else if (cell.Piece == Piece.RedKingPiece && (gameInfo.Board[cell.X + 1][cell.Y + 1].Piece == Piece.BlackPiece || gameInfo.Board[cell.X + 1][cell.Y + 1].Piece == Piece.BlackKingPiece) && cell.X < 6 && cell.Y < 6)
                        if (gameInfo.Board[cell.X + 2][cell.Y + 2].Piece == null)
                        {
                            gameInfo.Board[cell.X + 2][cell.Y + 2].Highlight = true;
                            ++possibleMoves;
                        }
                }
                if (cell.X != 7 && cell.Y != 0)
                {
                    if (gameInfo.Board[cell.X + 1][cell.Y - 1].Piece == null && !multiple)
                        gameInfo.Board[cell.X + 1][cell.Y - 1].Highlight = true;
                    else if (cell.Piece != Piece.RedKingPiece && (gameInfo.Board[cell.X + 1][cell.Y - 1].Piece == Piece.RedPiece || gameInfo.Board[cell.X + 1][cell.Y - 1].Piece == Piece.RedKingPiece) && cell.X < 6 && cell.Y > 1)
                    {
                        if (gameInfo.Board[cell.X + 2][cell.Y - 2].Piece == null)
                        {
                            gameInfo.Board[cell.X + 2][cell.Y - 2].Highlight = true;
                            ++possibleMoves;
                        }
                    }
                    else if (cell.Piece == Piece.RedKingPiece && (gameInfo.Board[cell.X + 1][cell.Y - 1].Piece == Piece.BlackPiece || gameInfo.Board[cell.X + 1][cell.Y - 1].Piece == Piece.BlackKingPiece) && cell.X < 6 && cell.Y > 1)
                        if (gameInfo.Board[cell.X + 2][cell.Y - 2].Piece == null)
                        {
                            gameInfo.Board[cell.X + 2][cell.Y - 2].Highlight = true;
                            ++possibleMoves;
                        }
                }
            }
            if (cell.Piece == Piece.RedPiece || cell.Piece == Piece.BlackKingPiece || cell.Piece == Piece.RedKingPiece)
            {
                if (cell.X != 0 && cell.Y != 7)
                {
                    if (gameInfo.Board[cell.X - 1][cell.Y + 1].Piece == null && !multiple)
                        gameInfo.Board[cell.X - 1][cell.Y + 1].Highlight = true;
                    else if (cell.Piece != Piece.BlackKingPiece && (gameInfo.Board[cell.X - 1][cell.Y + 1].Piece == Piece.BlackPiece || gameInfo.Board[cell.X - 1][cell.Y + 1].Piece == Piece.BlackKingPiece) && cell.X > 1 && cell.Y < 6)
                    {
                        if (gameInfo.Board[cell.X - 2][cell.Y + 2].Piece == null)
                        {
                            gameInfo.Board[cell.X - 2][cell.Y + 2].Highlight = true;
                            ++possibleMoves;
                        }
                    }
                    else if (cell.Piece == Piece.BlackKingPiece && (gameInfo.Board[cell.X - 1][cell.Y + 1].Piece == Piece.RedPiece || gameInfo.Board[cell.X - 1][cell.Y + 1].Piece == Piece.RedKingPiece) && cell.X > 1 && cell.Y < 6)
                        if (gameInfo.Board[cell.X - 2][cell.Y + 2].Piece == null)
                        {
                            gameInfo.Board[cell.X - 2][cell.Y + 2].Highlight = true;
                            ++possibleMoves;
                        }
                }
                if (cell.X != 0 && cell.Y != 0)
                {
                    if (gameInfo.Board[cell.X - 1][cell.Y - 1].Piece == null && !multiple)
                        gameInfo.Board[cell.X - 1][cell.Y - 1].Highlight = true;
                    else if (cell.Piece != Piece.BlackKingPiece && (gameInfo.Board[cell.X - 1][cell.Y - 1].Piece == Piece.BlackPiece || gameInfo.Board[cell.X - 1][cell.Y - 1].Piece == Piece.BlackKingPiece) && cell.X > 1 && cell.Y > 1)
                    {
                        if (gameInfo.Board[cell.X - 2][cell.Y - 2].Piece == null)
                        {
                            gameInfo.Board[cell.X - 2][cell.Y - 2].Highlight = true;
                            ++possibleMoves;
                        }
                    }
                    else if (cell.Piece == Piece.BlackKingPiece && (gameInfo.Board[cell.X - 1][cell.Y - 1].Piece == Piece.RedPiece || gameInfo.Board[cell.X - 1][cell.Y - 1].Piece == Piece.RedKingPiece) && cell.X > 1 && cell.Y > 1)
                    {
                        if (gameInfo.Board[cell.X - 2][cell.Y - 2].Piece == null)
                        {
                            gameInfo.Board[cell.X - 2][cell.Y - 2].Highlight = true;
                            ++possibleMoves;
                        }
                    }
                }
            }
            return possibleMoves;
        }
    }
}
