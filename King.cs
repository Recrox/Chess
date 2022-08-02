namespace Chess
{
    public class King:Piece
    {
        public King(Position pos, Color c) : base(pos, c)
        {
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