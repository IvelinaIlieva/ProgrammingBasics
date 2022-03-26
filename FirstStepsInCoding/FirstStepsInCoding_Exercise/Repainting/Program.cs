using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNylon = int.Parse(Console.ReadLine());
            int quantityPaint = int.Parse(Console.ReadLine());
            int quantityDiluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nylonPrice = 1.50;
            double paintPrice = 14.50;
            int diluentPrice = 5;
            double bags = 0.40;

            double nylonSum = (quantityNylon + 2) * nylonPrice;
            double paintSum = (1.1 * quantityPaint) * paintPrice;
            int diluentSum = quantityDiluent * diluentPrice;

            double sum = nylonSum + paintSum + diluentSum + bags;

            double mastersSum = (0.3 * sum)*hours;

            double endSum = sum + mastersSum;

            Console.WriteLine(endSum);
        }
    }
}
