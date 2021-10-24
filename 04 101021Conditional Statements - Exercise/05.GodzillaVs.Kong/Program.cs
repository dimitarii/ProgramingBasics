using System;

namespace softuni2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statics = int.Parse(Console.ReadLine());
            double priceStatic = double.Parse(Console.ReadLine());
            double budgetNeed = budget * 0.1;

            if (statics > 150)
            {
                budgetNeed += statics * priceStatic * 0.9;
            }
            else
            {
                budgetNeed += statics * priceStatic;
            }
            double result = budget - budgetNeed;
            if (result < 0)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(result):F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {result:F2} leva left.");
            }
        }
    }
}