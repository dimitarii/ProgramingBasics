using System;

namespace softuni2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double episodLenth = double.Parse(Console.ReadLine());
            double timeForLunch = double.Parse(Console.ReadLine());

            double totalTime = episodLenth;
            totalTime += timeForLunch / 8;
            totalTime += timeForLunch / 4;

            if (timeForLunch >= totalTime)
            {
                double leftTime = Math.Ceiling(timeForLunch - totalTime);
                Console.WriteLine($"You have enough time to watch {name} and left with {leftTime} minutes free time. ");
            }
            else
            {
                double leftTime = Math.Ceiling(totalTime - timeForLunch);
                Console.WriteLine($"You don't have enough time to watch {name}, you need {leftTime} more minutes.");
            }
        }
    }
}
