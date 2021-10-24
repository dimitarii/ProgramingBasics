using System;

namespace SumGlasni
{
    class Program
    {
        static void Main(string[] args)
        {
            // a e  o u
            //1  2  3  4
            string text = Console.ReadLine();
            int voweIsSum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                switch (letter)
                {
                    case 'a':
                        voweIsSum += 1;
                        break;
                    case 'e':
                        voweIsSum += 2;
                        break;
                    case 'i':
                        voweIsSum += 3;
                        break;
                    case 'o':
                        voweIsSum += 4;
                        break;
                    case 'u':
                        voweIsSum += 5;
                        break;
                }

            }
            Console.WriteLine(voweIsSum);
        }
    }
}