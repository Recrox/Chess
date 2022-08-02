
namespace Chess
{
    public abstract class Piece
    {
        protected Position pos;
        protected Color C { get; set; }
        public Position Pos { get => pos; set => pos = value; }

        protected Piece(Position pos, Color c)
        {
            this.pos = pos;
            this.C = c;
        }

        public virtual bool isMovable(Position to)
        {
            return false; 
        }
    }


}