using System;
using ChessKnightProblem.business;

namespace ChessKnightProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var horse = new Horse();
            var moves  = horse.Answer(0,1);
            Console.WriteLine(moves);
        }
    }
}
