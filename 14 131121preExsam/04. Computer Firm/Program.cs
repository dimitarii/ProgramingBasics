using System;

namespace _04._Computer_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double actualSales = 0;
            double currentSales = 0;
            double averageRating = 0;

            for (int i = 0; i < n; i++)
            {
                int salesAndRating = int.Parse(Console.ReadLine());
                double currentRating = salesAndRating % 10;
                if (currentRating == 2)
                {
                    actualSales += 0;
                }
                else if (currentRating == 3)
                {
                    currentSales = salesAndRating / 10;
                    actualSales += (currentSales * 0.50);
                }
                else if (currentRating == 4)
                {
                    currentSales = salesAndRating / 10;
                    actualSales += (currentSales * 0.70);
                }
                else if (currentRating == 5)
                {
                    currentSales = salesAndRating / 10;
                    actualSales += (currentSales * 0.85);
                }
                else if (currentRating == 6)
                {
                    currentSales = salesAndRating / 10;
                    actualSales += currentSales;
                }
                averageRating += currentRating;
            }
            averageRating = averageRating / n;
            Console.WriteLine($"{actualSales:F2}");
            Console.WriteLine($"{averageRating:F2}");
        }
    }
}