
namespace Chess
{
    public class ChessBoard
    {
        private const int COLUMN = 8;
        private const int LINE = 8;
        private Piece[,] board = new Piece[COLUMN, LINE];

        public ChessBoard() {
            FillChessBoard();
        }

        public void FillChessBoard() {
            //PAWN
            for (int i = 0; i < COLUMN; i++)
            {
                this.board[1, i] = new Pawn(new Position(1, i), Color.WHITE);
                this.board[6, i] = new Pawn(new Position(6, i), Color.BLACK);
            }
            //Knight
            this.board[0, 1] = new Knight(new Position(0, 1), Color.WHITE);
            this.board[0, 6] = new Knight(new Position(0, 6), Color.WHITE);

            this.board[7, 1] = new Knight(new Position(7, 1), Color.BLACK);
            this.board[7, 6] = new Knight(new Position(7, 6), Color.BLACK);
            //Bishop
            this.board[0, 2] = new Bishop(new Position(0, 2), Color.WHITE);
            this.board[0, 5] = new Bishop(new Position(0, 5), Color.WHITE);

            this.board[7, 2] = new Bishop(new Position(7, 2), Color.BLACK);
            this.board[7, 5] = new Bishop(new Position(7, 5), Color.BLACK);

            //Rook
            this.board[0, 0] = new Rook(new Position(0, 0), Color.WHITE);
            this.board[0, 7] = new Rook(new Position(0, 7), Color.WHITE);

            this.board[7, 0] = new Rook(new Position(7, 0), Color.BLACK);
            this.board[7, 7] = new Rook(new Position(7, 7), Color.BLACK);

            //Queen
            this.board[0, 3] = new Queen(new Position(0, 3), Color.WHITE);

            this.board[7, 3] = new Queen(new Position(7, 3), Color.BLACK);
            //King
            this.board[0, 4] = new King(new Position(0, 4), Color.WHITE);

            this.board[7, 4] = new King(new Position(7, 4), Color.BLACK);

        }

        public void Show() {
            for (int i = COLUMN-1; i > -1; i--)
            {
                Console.WriteLine();
                Console.Write((i + 1) + "   ");
                for (int j = 0; j < LINE; j++)
                {
                    if (board[i, j] == null) {
                        Console.Write("- ");//if the cell is empty
                    }
                    else {
                        Console.Write(board[i, j].ToString() + " ");
                    }
                }
            }

            Console.WriteLine("\n");
            Console.Write("    ");
            for (int i = 0; i < LINE; i++)
            {
                
                Console.Write(toAlphabet(i)+" ");
            }     
            Console.WriteLine("\n_________________________________________________________________________________________________________");
        }

        private string toAlphabet(int v)
        {
            switch (v)
            {
                case 0: return "A";
                case 1: return "B";
                case 2: return "C";
                case 3: return "D";
                case 4: return "E";
                case 5: return "F";
                case 6: return "G";
                case 7: return "H";
                default: return v.ToString();
            }
        }

        public void MovePiece(Position from, Position to)
        {
            if (ExistInBoard(from) && ExistInBoard(to))
            {
                if (!isEmpty(from) && getPiece(from).isMovable(to))
                {
                    board[from.X, from.Y].Pos = to;
                    board[to.X, to.Y] = board[from.X, from.Y];
                    board[from.X, from.Y] = null;
                }
            }
        }

        private Piece getPiece(Position pos)
        {
            return this.board[pos.X, pos.Y];
        }

        private bool ExistInBoard(Position pos)
        {
            return pos.X < LINE
                && pos.Y < COLUMN
                && pos.X > -1
                && pos.Y > -1;
        }

        private bool isEmpty(Position pos)
        {
            return getPiece(pos) == null;
        }
    }
}
