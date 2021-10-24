using System;

namespace softuni2
{
    class Program
    {
        static void Main(string[] args)
        {
            int squerMeters = int.Parse(Console.ReadLine());

            double totalSquereMeter = squerMeters * 7.61;
            double discount = 0.18 * totalSquereMeter;
            double total = totalSquereMeter - discount;

            Console.WriteLine($"The final price is: {total} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}