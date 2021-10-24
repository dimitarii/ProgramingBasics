using System;

namespace softuni2
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());

            double chickenPrice = 10.35;
            double fishPrice = 12.40;
            double veganPrice = 8.15;
            double delivery = 2.50;

            double total = 0;
            total = chicken * chickenPrice;
            total += fish * fishPrice;
            total += vegan * veganPrice;
            total = total * 1.2;
            total += delivery;

            Console.WriteLine(total);
        }
    }
}
