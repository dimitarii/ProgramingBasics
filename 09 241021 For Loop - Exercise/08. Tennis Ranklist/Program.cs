using System;

namespace tenisGrigor8
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentCount = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int pointsWon = 0;
            int tournamentsWon = 0;
            for (int i = 0; i < tournamentCount; i++)
            {
                string result = Console.ReadLine();
                if (result == "W")
                {
                    pointsWon += 2000;
                    tournamentsWon++;
                }
                else if (result == "F")
                {
                    pointsWon += 1200;
                }
                else if (result == "SF")
                {
                    pointsWon += 720;
                }
            }
            Console.WriteLine($"Final points: {startPoints + pointsWon}");
            int averagePoints = pointsWon / tournamentCount;
            Console.WriteLine($"Average points: {averagePoints}");
            double percentigeTousWon = (double)tournamentsWon / tournamentCount * 100;
            Console.WriteLine($"{percentigeTousWon:f2}%");
        }
    }
}
