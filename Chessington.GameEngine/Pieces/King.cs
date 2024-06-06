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
            Square piece = board.FindPiece(this);
            
            int[] row = new int[] { 1, 1, 1, 0, 0, -1, -1, -1};
            int[] col = new int[] { -1, 0, 1, -1, 1, -1, 0, 1};
            
            for (int i = 0; i < 8; i++)
            {
                Square move = new Square(piece.Row + row[i], piece.Col + col[i]);

                if (board.isSquareInBounds(move) && (board.IsSquareEmpty(move)
                                                     || board.IsSquareEnemy(move, this)))
                {
                    availableMoves.Add(move);
                }
            }
            return availableMoves;
        }
    }
}