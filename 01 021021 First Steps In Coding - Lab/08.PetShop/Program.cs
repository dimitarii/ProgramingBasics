using System;

namespace softuni2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsFood = int.Parse(Console.ReadLine());
            int catsFood = int.Parse(Console.ReadLine());
            //dog food 2.50
            //cat food 4

            double totalDogsFood = dogsFood * 2.50;
            int totalCatsFood = catsFood * 4;
            double allFood = totalDogsFood + totalCatsFood;

            Console.WriteLine($"{allFood} lv.");
        }
    }
}