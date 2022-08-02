namespace Chess
{
    public class Rook:Piece
    {
        public Rook(Position pos, Color c) : base(pos, c)
        {
        }

        public override bool isMovable(Position to)
        {
            if(to.X - this.pos.X == 0 
            || to.Y - this.pos.Y == 0) { return true; }
            return false;
        }

        public override string? ToString()
        {
            if (this.C == Color.WHITE)
            {
                return "R";//https://fr.wikipedia.org/wiki/Symboles_d%27%C3%A9checs_en_Unicode
            }
            else
            {
                return "R";
            }
        }
    }
}