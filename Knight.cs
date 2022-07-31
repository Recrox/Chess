namespace Chess
{
    public class Knight:Piece
    {
        public Knight(Position pos, Color c) : base(pos, c)
        {
        }

        public override string toString()
        {
            if(this.c == Color.WHITE){
                return "H";//https://fr.wikipedia.org/wiki/Symboles_d%27%C3%A9checs_en_Unicode
            }
            else
            {
                return "H";
            }
            
        }
    }
}