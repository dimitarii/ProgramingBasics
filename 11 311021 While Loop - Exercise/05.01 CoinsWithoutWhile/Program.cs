using System;

namespace _05._01_CoinsWithoutWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundreds = (int)(double.Parse(Console.ReadLine()) * 100);
            int count = 0;
            count += hundreds / 200;
            hundreds %= 200;

            count += hundreds / 100;
            hundreds %= 100;

            count += hundreds / 50;
            hundreds %= 50;

            count += hundreds / 20;
            hundreds %= 20;

            count += hundreds / 10;
            hundreds %= 10;

            count += hundreds / 5;
            hundreds %= 5;

            count += hundreds / 2;
            hundreds %= 2;

            count += hundreds;
            Console.WriteLine(count);
        }
    }
}
