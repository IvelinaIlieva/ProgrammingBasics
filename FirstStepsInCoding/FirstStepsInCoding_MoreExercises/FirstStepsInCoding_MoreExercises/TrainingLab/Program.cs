using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine()) * 100;
            double h = double.Parse(Console.ReadLine()) * 100;

            int workplaceH = ((int)h - 100) / 70;
            int workplaceW = (int)w / 120;

            int workplace = (workplaceH * workplaceW) - 3;

            Console.WriteLine(workplace);
        }
    }
}
