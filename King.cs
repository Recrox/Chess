namespace Chess
{
    public class King:Piece
    {
        public King(Position pos, Color c) : base(pos, c)
        {
        }

        public override bool isMovable(Position to)
        {
            if (DeltaX(to) == DeltaY(to) && DeltaX(to) == 1//diagonales like bishop but 1 cell range
            || DeltaX(to) == 0 && DeltaY(to) == 1   //line like rook but 1 cell range
            || DeltaY(to) == 0 && DeltaX(to) == 1) return true; 
            return false;
        }
        public override string? ToString()
        {
            if (this.C == Color.WHITE)
            {
                return "K";//https://fr.wikipedia.org/wiki/Symboles_d%27%C3%A9checs_en_Unicode
            }
            else
            {
                return "K";
            }
        }
    }
}