using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            double pieceCount = width * lenght;
            string piesesTaken = Console.ReadLine();

            while (piesesTaken != "STOP")
            {
                int piecesNumber = int.Parse(piesesTaken);
                pieceCount -= piecesNumber;
                if (pieceCount < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(pieceCount)} pieces more.");
                    return;
                }
                piesesTaken = Console.ReadLine();
            }
            Console.WriteLine($"{pieceCount} pieces are left.");
        }
    }
}
