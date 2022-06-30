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
            
            if (this.Player == Player.White)
            {
                if (board.FindPiece(this).Row == 6 
                    && board.GetPiece(new Square(board.FindPiece(this).Row - 2, board.FindPiece(this).Col)) == null 
                    && board.GetPiece(new Square(board.FindPiece(this).Row - 1, board.FindPiece(this).Col)) == null)
                { 
                    availableMoves.Add(new Square(board.FindPiece(this).Row - 2, board.FindPiece(this).Col));
                }
                if (board.FindPiece(this).Row > 0)
                {
                    if (board.GetPiece(new Square(board.FindPiece(this).Row - 1, board.FindPiece(this).Col)) == null)
                    {
                        availableMoves.Add(new Square(board.FindPiece(this).Row - 1, board.FindPiece(this).Col));
                    }
 
                    if (board.FindPiece(this).Col + 1 < 7 && 
                        board.GetPiece(new Square(board.FindPiece(this).Row - 1, board.FindPiece(this).Col + 1)) != null 
                        &&  board.GetPiece(new Square(board.FindPiece(this).Row - 1, 
                            board.FindPiece(this).Col + 1)).Player != this.Player)
                    {
                        availableMoves.Add(new Square(board.FindPiece(this).Row - 1, board.FindPiece(this).Col + 1));
                    }
                    if (board.FindPiece(this).Col - 1 > 0 &&
                        board.GetPiece(new Square(board.FindPiece(this).Row - 1, board.FindPiece(this).Col - 1)) != null 
                        &&  board.GetPiece(new Square(board.FindPiece(this).Row - 1, 
                            board.FindPiece(this).Col - 1)).Player != this.Player)
                    {
                        availableMoves.Add(new Square(board.FindPiece(this).Row - 1, board.FindPiece(this).Col - 1));
                    }
                }
            }
            else if (this.Player == Player.Black )
            {
                if (board.FindPiece(this).Row == 1 
                    && board.GetPiece(new Square(board.FindPiece(this).Row + 2, board.FindPiece(this).Col)) == null
                    && board.GetPiece(new Square(board.FindPiece(this).Row + 1, board.FindPiece(this).Col)) == null)
                {
                    availableMoves.Add(new Square(board.FindPiece(this).Row + 2, board.FindPiece(this).Col));
                }

                if (board.FindPiece(this).Row < 7)
                {
                    if(board.GetPiece(new Square(board.FindPiece(this).Row + 1, board.FindPiece(this).Col)) == null)
                    {
                        availableMoves.Add(new Square(board.FindPiece(this).Row + 1, board.FindPiece(this).Col));
                    }
                    if (board.FindPiece(this).Col + 1 < 7 && 
                        board.GetPiece(new Square(board.FindPiece(this).Row + 1, board.FindPiece(this).Col + 1)) != null 
                        &&  board.GetPiece(new Square(board.FindPiece(this).Row + 1, 
                            board.FindPiece(this).Col + 1)).Player != this.Player)
                    {
                        availableMoves.Add(new Square(board.FindPiece(this).Row + 1, board.FindPiece(this).Col + 1));
                    }
                    if (board.FindPiece(this).Col - 1 > 0 &&
                        board.GetPiece(new Square(board.FindPiece(this).Row + 1, board.FindPiece(this).Col - 1)) != null 
                        &&  board.GetPiece(new Square(board.FindPiece(this).Row + 1, 
                            board.FindPiece(this).Col - 1)).Player != this.Player)
                    {
                        availableMoves.Add(new Square(board.FindPiece(this).Row + 1, board.FindPiece(this).Col - 1));
                    }
                    
                }
            }
            return availableMoves;
        }
    }
}