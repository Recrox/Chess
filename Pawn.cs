namespace Chess
{
    public class Pawn:Piece
    {
        public Pawn(Position pos, Color c) : base(pos, c)
        {

        }

        public override String toString(){
            if(this.c == Color.WHITE){
                return "P";//https://fr.wikipedia.org/wiki/Symboles_d%27%C3%A9checs_en_Unicode
            }
            else{
                return "P";//https://fr.wikipedia.org/wiki/Symboles_d%27%C3%A9checs_en_Unicode
            }
            
        }
    }
}