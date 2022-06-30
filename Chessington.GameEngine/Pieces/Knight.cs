﻿using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            List<Square> availableMoves = new List<Square>();
            
            int[] row = new int[] { 2, 1, -1, -2, -2, -1, 1, 2};
            int[] col = new int[] { 1, 2, 2, 1, -1, -2, -2, -1};

            for (int i = 0; i < 8; i++)
            {
                if (board.FindPiece(this).Row + row[i] >= 0
                    && board.FindPiece(this).Row + row[i] < 8
                    && board.FindPiece(this).Col + col[i] >= 0
                    && board.FindPiece(this).Col + col[i] < 8 
                    && (board.GetPiece(new Square(board.FindPiece(this).Row + row[i],
                        board.FindPiece(this).Col + col[i])) == null 
                        || board.GetPiece(new Square(board.FindPiece(this).Row + row[i], 
                            board.FindPiece(this).Col + col[i])).Player != this.Player))
                {
                    availableMoves.Add(new Square(board.FindPiece(this).Row + row[i],
                        board.FindPiece(this).Col + col[i]));
                }
            }
            return availableMoves;
        }
    }
}