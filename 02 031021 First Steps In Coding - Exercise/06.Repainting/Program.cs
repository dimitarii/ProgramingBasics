using System;

namespace softuni2
{
    class Program
    {
        static void Main(string[] args)
        {
            int naylon = int.Parse(Console.ReadLine());
            int paintLiters = int.Parse(Console.ReadLine());
            int supervisur = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());

            double total = 0;
            total = total + (naylon + 2) * 1.5;
            total = total + (1.1 * paintLiters) * 14.50;
            total = total + supervisur * 5.00;
            total += 0.40;

            total = total + (total * 0.30) * workingHours;
            Console.WriteLine(total);
        }
    }
}