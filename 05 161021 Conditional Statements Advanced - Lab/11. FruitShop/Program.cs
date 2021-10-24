using System;

namespace Checks
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            double price = 0.0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    price = amount * 2.50;
                }
                else if (fruit == "apple")
                {
                    price = amount * 1.20;
                }
                else if (fruit == "orange")
                {
                    price = amount * 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    price = amount * 1.45;
                }
                else if (fruit == "kiwi")
                {
                    price = amount * 2.70;
                }
                else if (fruit == "pineapple")
                {
                    price = amount * 5.50;
                }
                else if (fruit == "grapes")
                {
                    price = amount * 3.85;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    price = amount * 2.70;
                }
                else if (fruit == "apple")
                {
                    price = amount * 1.25;
                }
                else if (fruit == "orange")
                {
                    price = amount * 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    price = amount * 1.60;
                }
                else if (fruit == "kiwi")
                {
                    price = amount * 3.00;
                }
                else if (fruit == "pineapple")
                {
                    price = amount * 5.60;
                }
                else if (fruit == "grapes")
                {
                    price = amount * 4.20;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else
            {
                Console.WriteLine("error");
                return;
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}