namespace Chess
{
    public class Knight:Piece
    {
        public Knight(Position pos, Color c) : base(pos, c)
        {
        }

        public override bool isMovable(Position to)
        {
            if(DeltaX(to) == 2 && DeltaY(to) == 1
            || DeltaX(to) == 1 && DeltaY(to) == 2) return true;
            return false;

        }
        public override string? ToString()
        {
            if (this.C == Color.WHITE)
            {
                return "H";//https://fr.wikipedia.org/wiki/Symboles_d%27%C3%A9checs_en_Unicode
            }
            else
            {
                return "H";
            }
        }
    }
}