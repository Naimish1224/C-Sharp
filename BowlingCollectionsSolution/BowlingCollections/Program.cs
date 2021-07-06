using System;

namespace BowlingCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Bowling();
            Console.WriteLine($"Game score is {game.Bowl()}");
        }
    }
}
