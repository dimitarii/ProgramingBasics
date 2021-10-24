using System;

namespace softuni2
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double anual = double.Parse(Console.ReadLine()) / 100;

            double totalSum = depositSum + period * ((depositSum * anual) / 12);

            Console.WriteLine(totalSum);
        }
    }
}