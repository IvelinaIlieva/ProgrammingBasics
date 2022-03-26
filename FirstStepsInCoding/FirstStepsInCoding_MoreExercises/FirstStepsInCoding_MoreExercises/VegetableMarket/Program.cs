using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerKgVegie = double.Parse(Console.ReadLine());
            double pricePerKgFruit = double.Parse(Console.ReadLine());
            int kgVegie = int.Parse(Console.ReadLine());
            int kgFruit = int.Parse(Console.ReadLine());

            double priceVegie = pricePerKgVegie * kgVegie;
            double priceFruits = pricePerKgFruit * kgFruit;
            double sumEuro = (priceVegie + priceFruits) / 1.94;
            Console.WriteLine("{0:F2}",sumEuro);
        }
    }
}
