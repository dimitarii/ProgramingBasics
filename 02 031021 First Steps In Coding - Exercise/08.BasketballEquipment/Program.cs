using System;

namespace softuni2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());


            double total1 = tax * 0.6;
            double total2 = total1 * 0.80;
            double total3 = total2 / 4;
            double total4 = total3 / 5;

            double sum = tax + total1 + total2 + total3 + total4;

            Console.WriteLine(sum);
        }
    }
}
