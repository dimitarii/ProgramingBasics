using System;

namespace softuni2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processor = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double videocardsPrice = 250 * videocards;
            double processorPrice = (videocardsPrice * 0.35) * processor;
            double ramPrice = (videocardsPrice * 0.10) * ram;
            double totalBill = videocardsPrice + processorPrice + ramPrice;
            double needBudget = 0;

            if (videocards > processor)
            {
                totalBill = totalBill - (totalBill * 0.15);
                needBudget = budget - totalBill;
            }
            else
            {
                needBudget = budget - totalBill;
            }
            if (budget > totalBill)
            {
                Console.WriteLine($"You have {Math.Abs(needBudget):F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(needBudget):F2} leva more!");
            }
        }
    }
}

