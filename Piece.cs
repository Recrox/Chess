
namespace Chess
{
    public abstract class Piece
    {
        protected Position pos;
        protected Color c { get; set; }

        protected Piece(Position pos, Color c)
        {
            this.pos = pos;
            this.c = c;
        }

        public virtual bool isMovable(Position to)
        {
            return false; 
        }

        public virtual String toString()
        {
            return "X";
        }
    }


}