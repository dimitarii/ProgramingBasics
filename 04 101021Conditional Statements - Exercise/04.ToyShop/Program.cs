using System;

namespace toys
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            double puzzleCount = double.Parse(Console.ReadLine());
            double dollCount = double.Parse(Console.ReadLine());
            double bearCount = double.Parse(Console.ReadLine());
            double minionsCount = double.Parse(Console.ReadLine());
            double truckCount = double.Parse(Console.ReadLine());

            double puzzlePrice = puzzleCount * 2.60;
            double dollPrice = dollCount * 3;
            double bearPrice = bearCount * 4.10;
            double minionsPrice = minionsCount * 8.20;
            double truckPrice = truckCount * 2;

            double toysPrice = puzzlePrice + dollPrice + bearPrice + minionsPrice + truckPrice;
            double toysCount = puzzleCount + dollCount + bearCount + minionsCount + truckCount;

            double discount = 0;

            if (toysCount >= 50)
            {
                discount = toysPrice * 0.25;
            }
            double endPrice = toysPrice - discount;
            double rentDiscount = endPrice * 0.1;
            double moneyMade = endPrice - rentDiscount;

            if (vacationPrice > moneyMade)
            {
                double moneyNeeded = vacationPrice - moneyMade;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }
            else
            {
                double moneyRemaining = moneyMade - vacationPrice;
                Console.WriteLine($"Yes! {moneyRemaining:f2} lv left.");
            }
        }
    }
}