using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class King : Piece
    {
        public King(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            List<Square> availableMoves = new List<Square>();
            
            int[] row = new int[] { 1, 1, 1, 0, 0, -1, -1, -1};
            int[] col = new int[] { -1, 0, 1, -1, 1, -1, 0, 1};
            
            for (int i = 0; i < 8; i++)
            {
                if(board.FindPiece(this).Row + row[i] >= 0 && board.FindPiece(this).Row + row[i] < 8 
                                                           && board.FindPiece(this).Col + col[i] >= 0
                                                           && board.FindPiece(this).Col + col[i] < 8)
                availableMoves.Add(new Square(board.FindPiece(this).Row + row[i], 
                    board.FindPiece(this).Col + col[i]));
            }
            
            return availableMoves;
        }
    }
}