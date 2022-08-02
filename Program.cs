// See https://aka.ms/new-console-template for more information
namespace Chess
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;//For accept Unicode char
            ChessBoard CB = new ChessBoard();
            Player p1 = new Player("Joueur 1");
            Player p2 = new Player("Joueur 2");

            CB.Show();
            while (!gameIsOver())
            {
                PlayersPlay(p1, p2, CB);
                CB.Show();
            }

        }

        private static void PlayersPlay(Player p1, Player p2, ChessBoard CB)
        {
            Console.ReadKey();
            //pawn
            CB.MovePiece(new Position(1, 1), new Position(2, 1));
            CB.MovePiece(new Position(2, 1), new Position(3, 1));

            //bishop
            CB.MovePiece(new Position(0, 2), new Position(3, 5));
            CB.MovePiece(new Position(3, 5), new Position(4, 4));
            CB.MovePiece(new Position(7, 2), new Position(5, 0));

            //knight
            CB.MovePiece(new Position(0, 1), new Position(2, 2));
            CB.MovePiece(new Position(2, 2), new Position(3, 4));
            CB.MovePiece(new Position(7, 1), new Position(5, 2));

            //rook
            CB.MovePiece(new Position(0, 0), new Position(3, 0));
            CB.MovePiece(new Position(7, 7), new Position(3, 7));

            //queen
            CB.MovePiece(new Position(0, 3), new Position(4, 3));
            CB.MovePiece(new Position(7, 3), new Position(4, 0));
        }

        private static bool gameIsOver()
        {
            return false;
        }
    }
}





