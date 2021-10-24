using System;

namespace softuni2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pens = double.Parse(Console.ReadLine());
            double markers = double.Parse(Console.ReadLine());
            double prepart = double.Parse(Console.ReadLine());
            double discountPercent = double.Parse(Console.ReadLine());

            double total = 0;
            total = total + (pens * 5.80);
            total = total + (markers * 7.20);
            total = total + (prepart * 1.20);
            total = total - (total * (discountPercent / 100));
            Console.WriteLine(total);
        }
    }
}