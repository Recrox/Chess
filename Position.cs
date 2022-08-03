using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Position
    {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Position(String y, int x)//other format in the rule of chess for move a piece like : "B5 C6"
        {
            this.X = x-1;
            this.Y = AssociateToNumber(y);
        }

        public int AssociateToNumber(String s)
        {
            switch (s)
            {
                case "A": return 0;
                case "B": return 1;
                case "C": return 2;
                case "D": return 3;
                case "E": return 4;
                case "F": return 5;
                case "H": return 6;
                case "I": return 7;
                default : return -1;//bugged
            }
        }
    }
}
