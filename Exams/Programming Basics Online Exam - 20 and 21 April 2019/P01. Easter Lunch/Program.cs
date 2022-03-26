using System;

namespace P01._Easter_Lunch
{
    class Program
    {
        static void Main()
        {
            const double PRICE_FOR_EASTER_BREAD = 3.2;
            const double PRICE_FOR_EGGS = 4.35; //12 eggs
            const double PRICE_FOR_COOCKIES = 5.4; //1 kg
            const double PRICE_FOR_EGGS_PAINT = 0.15; //1 egg
            const int COUNT_OF_EGGS_IN_BOX = 12;

            int countOfEasterBread = int.Parse(Console.ReadLine());
            int countOfEggBoxes = int.Parse(Console.ReadLine());
            int countOfCoockiesKg = int.Parse(Console.ReadLine());

            double totalPriceOfEasterBread = countOfEasterBread * PRICE_FOR_EASTER_BREAD;
            double totalPriceOfEggs = countOfEggBoxes * PRICE_FOR_EGGS + countOfEggBoxes * COUNT_OF_EGGS_IN_BOX * PRICE_FOR_EGGS_PAINT;
            double totalPriceOfCoockies = countOfCoockiesKg * PRICE_FOR_COOCKIES;

            double totalPrice = totalPriceOfCoockies + totalPriceOfEasterBread + totalPriceOfEggs;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
