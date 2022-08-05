namespace Chess
{
    public class Bishop:Piece
    {
        public Bishop(Position pos, Color c) : base(pos, c)
        {

        }

        public override string? ToString()
        {
            if (this.C == Color.WHITE)
            {
                return "B";//https://fr.wikipedia.org/wiki/Symboles_d%27%C3%A9checs_en_Unicode
            }
            else
            {
                return "B";
            }
        }

        public override bool isMovable(Position to)
        {
            if (DeltaX(to) == DeltaY(to)) return true;
            return false;
        }
    }
}