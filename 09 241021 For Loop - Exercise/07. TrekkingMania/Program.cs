using System;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleMusala = 0, peopleMonblan = 0, peopleKilimandjaro = 0, peopleK2 = 0, peopleEverest = 0;

            int groupCount = int.Parse(Console.ReadLine());

            int totalPeopleCount = 0;

            for (int i = 0; i < groupCount; i++)
            {
                int peopleCount = int.Parse(Console.ReadLine());
                totalPeopleCount += peopleCount;

                if (peopleCount <= 5)
                {
                    peopleMusala += peopleCount;
                }
                else if (peopleCount <= 12)
                {
                    peopleMonblan += peopleCount;
                }
                else if (peopleCount <= 25)
                {
                    peopleKilimandjaro += peopleCount;
                }
                else if (peopleCount <= 40)
                {
                    peopleK2 += peopleCount;
                }
                else
                {
                    peopleEverest += peopleCount;
                }
            }
            double musalaPercentage, monblanProcentage, kilimandjaroPercentage, k2Percenrage, everestPercentage;

            musalaPercentage = (double)peopleMusala / totalPeopleCount * 100;
            kilimandjaroPercentage = (double)peopleKilimandjaro / totalPeopleCount * 100;
            k2Percenrage = (double)peopleK2 / totalPeopleCount * 100;
            monblanProcentage = (double)peopleMonblan / totalPeopleCount * 100;
            everestPercentage = (double)peopleEverest / totalPeopleCount * 100;

            Console.WriteLine($"{musalaPercentage:f2}%");
            Console.WriteLine($"{monblanProcentage:f2}%");
            Console.WriteLine($"{kilimandjaroPercentage:f2}%");
            Console.WriteLine($"{k2Percenrage:f2}%");
            Console.WriteLine($"{everestPercentage:f2}%");
        }
    }
}