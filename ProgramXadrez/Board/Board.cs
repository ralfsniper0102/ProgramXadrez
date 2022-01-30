 



namespace board
{
    class Board
    {
        public int Columns { get; set; }
        public int Lines { get; set; }
        private Piece[,] Pieces;

        public Board(int columns, int lines)
        {
            Columns = columns;
            Lines = lines;
            Pieces = new Piece[lines, columns];
        }

        public Piece piece (int line, int column)
        {
            return Pieces[line, column];
             
        }

        public void PutPiece(Piece piece, Position position)
        {
            Pieces[position.Line, position.Column] = piece;
            piece.Position = position;

        }


    }
}
