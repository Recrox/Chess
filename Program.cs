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
                PlayersPlay(p1, p2);
                CB.Show();


                //CB.MovePiece(new Position(7,0), new Position(3,3));

            }
            
        }

        private static void PlayersPlay(Player p1, Player p2)
        {
            Console.ReadKey();
        }

        private static bool gameIsOver()
        {

            return false;
        }
    }
}





