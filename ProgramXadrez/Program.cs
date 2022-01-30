using System;
using board;

namespace ProgramXadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            board.PutPiece()

            Screen.PrintBoard(board);
        }
    }
}
