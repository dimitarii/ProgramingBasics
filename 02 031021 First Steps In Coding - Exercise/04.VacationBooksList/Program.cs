using System;

namespace softuni2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());


            int sum = pages / hours;
            int totalHours = sum / days;


            Console.WriteLine(totalHours);

        }
    }
}
