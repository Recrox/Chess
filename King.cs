namespace Chess
{
    public class King:Piece
    {
        public King(Position pos, Color c) : base(pos, c)
        {
        }

        public override bool isMovable(Position to)
        {
            if (Math.Abs(to.X - this.pos.X) == Math.Abs(to.Y - this.pos.Y ) && Math.Abs(to.X - this.pos.X ) == 1//diagonales like bishop but 1 cell range
            || to.X - this.pos.X == 0 && Math.Abs(to.Y - this.pos.Y) == 1   //line like rook but 1 cell range
            || to.Y - this.pos.Y == 0 && Math.Abs(to.X - this.pos.X) == 1) return true; 
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