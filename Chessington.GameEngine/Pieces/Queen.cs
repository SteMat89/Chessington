using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        { 
            List<Square> availableMoves = new List<Square>();
            
            for (int i = board.FindPiece(this).Row + 1, j = board.FindPiece(this).Col + 1; i < 8 && j < 8; i++, j++)
            {
                availableMoves.Add(new Square(i, j));
            }
            
            for (int i = board.FindPiece(this).Row + 1, j = board.FindPiece(this).Col - 1; i < 8 && j >= 0; i++, j--)
            {
                availableMoves.Add(new Square(i, j));
            }
            
            for (int i = board.FindPiece(this).Row - 1, j = board.FindPiece(this).Col + 1; i >= 0 && j < 8; i--, j++)
            {
                availableMoves.Add(new Square(i, j));
            }
            
            for (int i = board.FindPiece(this).Row - 1, j = board.FindPiece(this).Col - 1; i >= 0 && j >= 0; i--, j--)
            {
                availableMoves.Add(new Square(i, j));
            }
            
            for (int i = board.FindPiece(this).Col + 1; i < 8; i++)
            {
                availableMoves.Add(new Square(board.FindPiece(this).Row, i));
            }
            
            for (int i = board.FindPiece(this).Col - 1; i >= 0; i--)
            {
                availableMoves.Add(new Square(board.FindPiece(this).Row, i));
            }
            
            for (int i = board.FindPiece(this).Row + 1; i < 8; i++)
            {
                availableMoves.Add(new Square(i, board.FindPiece(this).Col));
            }
            
            for (int i = board.FindPiece(this).Row - 1; i >= 0; i--)
            {
                availableMoves.Add(new Square(i, board.FindPiece(this).Col));
            }
            return availableMoves;
        }
    }
}