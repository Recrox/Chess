namespace Chess
{
    public class Queen:Piece
    {
        public Queen(Position pos, Color c) : base(pos, c)
        {
        }

        public override bool isMovable(Position to)
        {
            if (DeltaX(to) == DeltaY(to)//diagonales like bishop
             || DeltaX(to) == 0 //line like rook
             || DeltaY(to) == 0) return true;
            return false;
        }
        public override string? ToString()
        {
            if (this.C == Color.WHITE)
            {
                return "Q";//https://fr.wikipedia.org/wiki/Symboles_d%27%C3%A9checs_en_Unicode
            }
            else
            {
                return "Q";
            }
        }
    }
}