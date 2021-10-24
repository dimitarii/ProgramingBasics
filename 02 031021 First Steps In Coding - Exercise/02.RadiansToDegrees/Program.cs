using System;

namespace softuni2
{
    class Program
    {
        static void Main(string[] args)
        {
            double rasdians = double.Parse(Console.ReadLine());
            double degrees = rasdians * 180 / Math.PI;
            Console.WriteLine(degrees);
        }
    }
}
