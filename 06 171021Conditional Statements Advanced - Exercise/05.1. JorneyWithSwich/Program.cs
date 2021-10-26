using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            //budget = destination
            //season = определя колко от бюджета, ще се изхарчи

            double total = 0;
            string vacation = string.Empty;
            string vacatiooType = string.Empty;

            switch (season)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        total = budget * 0.30;
                        vacation = "Bulgaria";
                        vacatiooType = "Camp";
                    }
                    else if (budget <= 1000 && budget > 101)
                    {
                        total = budget * 0.40;
                        vacation = "Balkans";
                        vacatiooType = "Camp";
                    }
                    else
                    {
                        total = budget * 0.90;
                        vacation = "Europe";
                        vacatiooType = "Hotel";
                    }
                    break;

                case "winter":
                    if (budget <= 100)
                    {
                        total = budget * 0.70;
                        vacation = "Bulgaria";
                        vacatiooType = "Hotel";
                    }
                    else if (budget <= 1000 && budget > 101)
                    {
                        total = budget * 0.80;
                        vacation = "Balkans";
                        vacatiooType = "Hotel";
                    }
                    else
                    {
                        total = budget * 0.90;
                        vacation = "Europe";
                        vacatiooType = "Hotel";
                    }
                    break;
            }
            Console.WriteLine($"Somewhere in {vacation}");
            Console.WriteLine($"{vacatiooType} - {total:f2}");
        }
    }
}

