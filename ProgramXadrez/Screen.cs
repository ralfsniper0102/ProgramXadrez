using System;
using board;

namespace ProgramXadrez
{
    class Screen
    {
        public static void PrintBoard(Board board)
        {
            for (int line = 0; line < board.Lines; line++ )
            {
                for(int column = 0; column < board.Columns; column++)
                {
                    if (board.piece(line,column) != null)
                    {
                        Console.Write(board.piece(line, column) + " ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                    

                }
                Console.WriteLine();
            }
        }
    }
}
