using System;

namespace Even_Odd__sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i <= num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum = evenSum + currentNum;

                }
                else if (i % 2 == 1)
                {

                    oddSum = oddSum + currentNum;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
            }
        }
    }
}