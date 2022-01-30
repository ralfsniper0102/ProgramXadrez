using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
