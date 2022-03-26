using System;

namespace P01._Easter_Bakery
{
    class Program
    {
        static void Main()
        {
            //input:
            double priceOfFlourPerKg = double.Parse(Console.ReadLine());
            double kgOfFlour = double.Parse(Console.ReadLine());
            double kgOfSugar = double.Parse(Console.ReadLine());
            int countOfEggsBoxes = int.Parse(Console.ReadLine());
            int countOfLeaven = int.Parse(Console.ReadLine());

            double priceOfSugarPerKg = 0.75 * priceOfFlourPerKg;
            double priceOfEggBox = 1.1 * priceOfFlourPerKg;
            double priceOfLeaven = 0.2 * priceOfSugarPerKg;

            double totalPriceOfFlour = priceOfFlourPerKg * kgOfFlour;
            double totalPriceOfSugar = priceOfSugarPerKg * kgOfSugar;
            double totalPriceForEggs = countOfEggsBoxes * priceOfEggBox;
            double totalPriceForLeaven = countOfLeaven * priceOfLeaven;

            double totalPrice = totalPriceForEggs + totalPriceForLeaven + totalPriceOfFlour + totalPriceOfSugar;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
