using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            var videoGames = new List<string>();

            videoGames.Add("PacMan");
            videoGames.Add("SuperMarioBros");
            videoGames.Add("MorrowWind");
            videoGames.Add("Sonic");

            var result = videoGames.OrderByDescending(Sort => Sort.Length);
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }
    }
}
