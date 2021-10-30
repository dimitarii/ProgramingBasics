using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNumber = int.MaxValue;


            while (input != "Stop")
            {
                int num = int.Parse(input);
                input = Console.ReadLine();
                if (num < minNumber)
                {
                    minNumber = num;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
