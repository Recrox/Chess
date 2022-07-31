namespace Chess
{
    public class Rook:Piece
    {
        public Rook(Position pos, Color c) : base(pos, c)
        {
        }

        public override string toString()
        {
            if(this.c == Color.WHITE){
                return "R";//https://fr.wikipedia.org/wiki/Symboles_d%27%C3%A9checs_en_Unicode
            }
            else
            {
                return "R";
            }
        }
    }
}