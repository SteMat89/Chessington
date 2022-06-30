using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            List<Square> availableMoves = new List<Square>();
            
            if (this.Player == Player.White && 
                board.GetPiece(new Square(board.FindPiece(this).Row - 1, board.FindPiece(this).Col)) == null)
            {
                if (board.FindPiece(this).Row == 7 && 
                    board.GetPiece(new Square(board.FindPiece(this).Row - 2, board.FindPiece(this).Col)) == null)
                { 
                    availableMoves.Add(new Square(board.FindPiece(this).Row - 2, board.FindPiece(this).Col));
                }
               
                
                availableMoves.Add(new Square(board.FindPiece(this).Row - 1, board.FindPiece(this).Col));
                
            }
            else if (this.Player == Player.Black 
                     && board.GetPiece(new Square(board.FindPiece(this).Row + 1, board.FindPiece(this).Col)) == null)
            {
                if (board.FindPiece(this).Row == 1 &&
                    board.GetPiece(new Square(board.FindPiece(this).Row + 2, board.FindPiece(this).Col)) == null)
                {
                    availableMoves.Add(new Square(board.FindPiece(this).Row + 2, board.FindPiece(this).Col));
                }

                availableMoves.Add( new Square(board.FindPiece(this).Row + 1, board.FindPiece(this).Col));
                
            }
            return availableMoves;
        }
    }
}