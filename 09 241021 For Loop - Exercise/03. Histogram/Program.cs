using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1Number = 0, p2Number = 0, p3Number = 0, p4Number = 0, p5Number = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1Number++;
                }
                else if (number < 400)
                {
                    p2Number++;
                }
                else if (number < 600)
                {
                    p3Number++;
                }
                else if (number < 800)
                {
                    p4Number++;
                }
                else
                {
                    p5Number++;
                }
            }
            double p1Percentage, p2Percentage, p3Percentage, p4Percentage, p5Percentage;

            p1Percentage = p1Number / n * 100;
            p2Percentage = p2Number / n * 100;
            p3Percentage = p3Number / n * 100;
            p4Percentage = p4Number / n * 100;
            p5Percentage = p5Number / n * 100;

            Console.WriteLine($"{p1Percentage:F2}%");
            Console.WriteLine($"{p2Percentage:F2}%");
            Console.WriteLine($"{p3Percentage:F2}%");
            Console.WriteLine($"{p4Percentage:F2}%");
            Console.WriteLine($"{p5Percentage:F2}%");
        }
    }
}