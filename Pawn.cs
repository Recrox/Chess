namespace Chess
{
    public class Pawn:Piece
    {
        bool hasMoved = false;
        private int Direction;// 1 is for white , -1 is for black

        public Pawn(Position pos, Color c) : base(pos, c)
        {
            if (c == Color.WHITE) { Direction = 1;}
            else if(c == Color.BLACK){ Direction = -1;}
        }

        public override string? ToString()
        {
            if (this.C == Color.WHITE)
            {
                return "P";//https://fr.wikipedia.org/wiki/Symboles_d%27%C3%A9checs_en_Unicode
            }
            else
            {
                return "P";
            }
        }

        public override bool isMovable(Position to)
        {
            if (!this.hasMoved && (to.X - this.pos.X == 2*Direction || to.X - this.pos.X == 1*Direction && to.Y == this.pos.Y))
            {
                this.hasMoved = true;
                return true;
            }
            else if (to.X - this.pos.X == 1*Direction && to.Y == this.pos.Y)
            {
                return true;
            }
            return false;
        }
    }
}