// See https://aka.ms/new-console-template for more information
using System;
namespace Chess
{
    
    class Program{
        public static void Main(string [] args){
            //Console.OutputEncoding = System.Text.Encoding.UTF8;//For accept Unicode char
            ChessBoard CB = new ChessBoard();
            Player p1 = new Player("Joueur 1");
            Player p2 = new Player("Joueur 2");

            CB.Show();
            while (!gameIsOver())
            {
                Console.WriteLine();
                PlayersPlay(p1, p2, CB);
                CB.Show();
                Console.ReadKey();
            }
            
        }

        private static void PlayersPlay(Player p1, Player p2, ChessBoard CB)
        {
            CB.MovePiece(new Position(1, 1), new Position(3, 1));
            CB.MovePiece(new Position(6, 1), new Position(4, 1));
        }

        private static bool gameIsOver()
        {

            return false;
        }
    }
}





