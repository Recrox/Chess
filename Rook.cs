namespace Chess
{
    public class Rook:Piece
    {
        public Rook(Position pos, Color c) : base(pos, c)
        {
        }

        public override bool isMovable(Position to)
        {
            if(DeltaX(to) == 0 
            || DeltaY(to) == 0) return true; 
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