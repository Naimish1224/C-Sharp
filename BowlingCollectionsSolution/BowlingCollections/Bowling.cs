using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingCollections
{
    class Bowling
    {
        List<int> game = new List<int>();

        public int Bowl()
        {
            for (var idx = 1; idx <= 10; idx++)
            {
                Console.Write($"Enter score for frame {idx};");
                var scoreStr = Console.ReadLine();
                var score = Convert.ToInt32(scoreStr);
                game.Add(score);
            }
            var total = 0;
            foreach(var score in game)
            {
                total += score;
            }
            return total;
        }
    }
}
