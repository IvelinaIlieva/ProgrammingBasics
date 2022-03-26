using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double v = a * b * h;
            double vL = v / 1000;

            double percentXArea = percent / 100;
            double endV = (1 - percentXArea) * vL;
            Console.WriteLine(endV);
        }
    }
}
