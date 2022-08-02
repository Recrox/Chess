namespace Chess
{
    public class Queen:Piece
    {
        public Queen(Position pos, Color c) : base(pos, c)
        {
        }

        public override bool isMovable(Position to)
        {
            if (Math.Abs(to.X - this.pos.X) == Math.Abs(to.Y - this.pos.Y)//diagonales like bishop
            || to.X - this.pos.X == 0 //line like rook
            || to.Y - this.pos.Y == 0) { return true; }
            return false;
        }
        public override string? ToString()
        {
            if (this.C == Color.WHITE)
            {
                return "Q";//https://fr.wikipedia.org/wiki/Symboles_d%27%C3%A9checs_en_Unicode
            }
            else
            {
                return "Q";
            }
        }
    }
}