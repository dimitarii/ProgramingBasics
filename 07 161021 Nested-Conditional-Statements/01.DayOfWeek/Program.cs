using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {           
            Week(int.Parse(Console.ReadLine()));
        }

        private static void Week(int numberOfWeek)
        {
            if (numberOfWeek == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (numberOfWeek == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (numberOfWeek == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (numberOfWeek == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (numberOfWeek == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (numberOfWeek == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (numberOfWeek == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
