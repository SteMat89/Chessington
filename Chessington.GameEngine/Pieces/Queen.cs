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
                if (board.GetPiece(new Square(i, j)) == null)
                {
                    availableMoves.Add(new Square(i, j));   
                }
                else if (board.GetPiece(new Square(i, j)).Player != this.Player)
                {
                    availableMoves.Add(new Square(i, j));
                    break;
                }
                else
                {
                    break;
                }
            }
            
            for (int i = board.FindPiece(this).Row + 1, j = board.FindPiece(this).Col - 1; i < 8 && j >= 0; i++, j--)
            {
                if (board.GetPiece(new Square(i, j)) == null)
                {
                    availableMoves.Add(new Square(i, j));   
                }
                else if (board.GetPiece(new Square(i, j)).Player != this.Player)
                {
                    availableMoves.Add(new Square(i, j));
                    break;
                }
                else
                {
                    break;
                }
            }
            
            for (int i = board.FindPiece(this).Row - 1, j = board.FindPiece(this).Col + 1; i >= 0 && j < 8; i--, j++)
            {
                if (board.GetPiece(new Square(i, j)) == null)
                {
                    availableMoves.Add(new Square(i, j));   
                }
                else if (board.GetPiece(new Square(i, j)).Player != this.Player)
                {
                    availableMoves.Add(new Square(i, j));
                    break;
                }
                else
                {
                    break;
                }
            }
            
            for (int i = board.FindPiece(this).Row - 1, j = board.FindPiece(this).Col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (board.GetPiece(new Square(i, j)) == null)
                {
                    availableMoves.Add(new Square(i, j));   
                }
                else if (board.GetPiece(new Square(i, j)).Player != this.Player)
                {
                    availableMoves.Add(new Square(i, j));
                    break;
                }
                else
                {
                    break;
                }
            }
            
            for (int i = board.FindPiece(this).Col + 1; i < 8; i++)
            {
                if (board.GetPiece(new Square(board.FindPiece(this).Row, i)) == null)
                {
                    availableMoves.Add(new Square(board.FindPiece(this).Row, i));    
                }
                else if (board.GetPiece(new Square(board.FindPiece(this).Row, i)).Player != this.Player)
                {
                    availableMoves.Add(new Square(board.FindPiece(this).Row, i));
                    break;
                }
                else
                {
                    break;
                }
            }
            
            for (int i = board.FindPiece(this).Col - 1; i >= 0; i--)
            {
                if (board.GetPiece(new Square(board.FindPiece(this).Row, i)) == null)
                {
                    availableMoves.Add(new Square(board.FindPiece(this).Row, i));    
                }
                else if (board.GetPiece(new Square(board.FindPiece(this).Row, i)).Player != this.Player)
                {
                    availableMoves.Add(new Square(board.FindPiece(this).Row, i));
                    break;
                }
                else
                {
                    break;
                }
            }
            
            for (int i = board.FindPiece(this).Row + 1; i < 8; i++)
            {
                if (board.GetPiece(new Square(i, board.FindPiece(this).Col)) == null)
                {
                    availableMoves.Add(new Square(i, board.FindPiece(this).Col));    
                }
                else if (board.GetPiece(new Square(i, board.FindPiece(this).Col)).Player != this.Player)
                {
                    availableMoves.Add(new Square(i, board.FindPiece(this).Col));
                    break;
                }
                else
                {
                    break;
                }
            }
            
            for (int i = board.FindPiece(this).Row - 1; i >= 0; i--)
            {
                if (board.GetPiece(new Square(i, board.FindPiece(this).Col)) == null)
                {
                    availableMoves.Add(new Square(i, board.FindPiece(this).Col));    
                }
                else if (board.GetPiece(new Square(i, board.FindPiece(this).Col)).Player != this.Player)
                {
                    availableMoves.Add(new Square(i, board.FindPiece(this).Col));
                    break;
                }
                else
                {
                    break;
                }
            }
            return availableMoves;
        }
    }
}