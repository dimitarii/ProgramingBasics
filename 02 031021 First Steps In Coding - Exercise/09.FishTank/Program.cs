using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace зад_9.Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            int V = length * width * heigth;
            double Vlitres = V * 0.001;
            double percentage = percent * 0.01;
            Console.WriteLine(Vlitres * (1 - percentage));
        }
    }
}