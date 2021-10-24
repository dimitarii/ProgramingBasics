using System;

namespace softuni2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());

            double area = a * 2.54;
            Console.WriteLine(area);
        }
    }
}