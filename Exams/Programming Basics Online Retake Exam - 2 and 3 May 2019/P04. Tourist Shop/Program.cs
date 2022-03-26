using System;

namespace P04._Tourist_Shop
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int countOfProducts = 0;
            double totalPrice = 0;

            while (input != "Stop")
            {
                string nameOfProduct = input;
                double priceOfProduct = double.Parse(Console.ReadLine());
                countOfProducts++;

                if (countOfProducts % 3 == 0)
                {
                    priceOfProduct /= 2;
                }
                if (priceOfProduct > budget)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {priceOfProduct - budget:f2} leva!");
                    return;
                }
                totalPrice += priceOfProduct;
                budget -= priceOfProduct;

                input = Console.ReadLine();
            }
            Console.WriteLine($"You bought {countOfProducts} products for {totalPrice:f2} leva.");
        }
    }
}
