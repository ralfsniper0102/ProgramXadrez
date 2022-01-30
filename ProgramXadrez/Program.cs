using System;
using board;

namespace ProgramXadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Position p;

            p = new Position(3, 4);

            Console.WriteLine("Posição " + p);

            Board board = new Board(10, 3);

        }
    }
}
