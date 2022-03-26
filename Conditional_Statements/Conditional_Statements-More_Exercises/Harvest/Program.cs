using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            //input:
            int vineyardArea = int.Parse(Console.ReadLine());
            double grapePerM2 = double.Parse(Console.ReadLine());
            int wineForSale = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            //calculations:
            double totalGrape = vineyardArea * grapePerM2;
            double grapeForWine = totalGrape * 0.4;
            double wineProduced = grapeForWine / 2.5;
            double difference = Math.Abs(wineProduced - wineForSale);

            if (wineProduced < wineForSale)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(difference)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProduced)} liters.");
                Console.WriteLine($"{Math.Ceiling(difference)} liters left -> {Math.Ceiling(difference / workers)} liters per person.");
            }
        }
    }
}
