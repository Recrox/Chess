
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

        public int DeltaX(Position pos)
        {
            return Math.Abs(pos.X - this.pos.X);
        }

        public int DeltaY(Position pos)
        {
            return Math.Abs(pos.Y - this.pos.Y);
        }
    }


}