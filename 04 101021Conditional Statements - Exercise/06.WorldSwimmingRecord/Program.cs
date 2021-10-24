using System;

namespace softuni2
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());

            double result = distance * timeForMeter;
            double additionalTime = Math.Floor(distance / 15) * 12.5;
            result += additionalTime;

            if (result < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {result:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {result - record:F2} seconds slower.");
            }
        }
    }
}