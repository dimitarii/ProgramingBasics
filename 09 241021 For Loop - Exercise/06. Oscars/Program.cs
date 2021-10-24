using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameActor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int numberEvaluate = int.Parse(Console.ReadLine());
            double x = points;
            double y = 0;
            for (int i = 1; i <= numberEvaluate; i++)
            {
                string nameEvaluate = Console.ReadLine();
                double pointsEvaluate = double.Parse(Console.ReadLine());
                x = x + (nameEvaluate.Length * pointsEvaluate) / 2;
                if (x > 1250.5)
                {
                    y = x;
                    Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {y:F1}!");
                    break;
                }
            }
            if (x < 1250.5)
            {
                Console.WriteLine($"Sorry, {nameActor} you need {(1250.5 - x):F1} more!");
            }
        }
    }
}