namespace Chess
{
    public class Pawn:Piece
    {
        bool hasMoved = false;
        private int direction;// -1 is for white , 1 is for black

        public Pawn(Position pos, Color c) : base(pos, c)
        {
            if (c == Color.WHITE) { direction = 1;}
            else if(c == Color.BLACK){ direction = -1;}
        }

        public override String toString(){
            if(this.c == Color.WHITE){
                return "P";//https://fr.wikipedia.org/wiki/Symboles_d%27%C3%A9checs_en_Unicode
            }
            else{
                return "P";//https://fr.wikipedia.org/wiki/Symboles_d%27%C3%A9checs_en_Unicode
            }
            
        }

        public override bool isMovable(Position to)
        {
            if (!this.hasMoved && (to.X - this.pos.X == 2*direction || to.X - this.pos.X == 1*direction && to.Y == this.pos.Y))
            {
                this.hasMoved = true;
                return true;
            }
            else if (to.X - this.pos.X == 1*direction && to.Y == this.pos.Y)
            {
                return true;
            }
            return false;
        }
    }
}