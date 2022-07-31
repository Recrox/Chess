
namespace Chess
{
    public abstract class Piece
    {
        protected Position pos { get; set; }
        protected Color c { get; set; }

        protected Piece(Position pos, Color c)
        {
            this.pos = pos;
            this.c = c;
        }

        public virtual String toString(){
            return "X";
        }
    }

    
}