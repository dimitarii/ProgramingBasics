using System;

namespace softuni2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());

            int total = hours * 3;

            Console.WriteLine($"The architect {name} will need {total} hours to complete {hours} project/s.");
        }
    }
}