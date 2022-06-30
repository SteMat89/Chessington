using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            List<Square> availableMoves = new List<Square>();

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