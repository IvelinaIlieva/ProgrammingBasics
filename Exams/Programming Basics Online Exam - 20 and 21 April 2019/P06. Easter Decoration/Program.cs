using System;

namespace P06._Easter_Decoration
{
    class Program
    {
        static void Main()
        {
            const double BASKET_PRICE = 1.5;
            const double WREATH_PRICE = 3.8;
            const double CHOCOLATE_BUNNY_PRICE = 7;

            int countOfClients = int.Parse(Console.ReadLine());
            int countOfBaskets = 0;
            int countOfWreaths = 0;
            int countOfChocolateBunny = 0;
            double totalPrice = 0;

            for (int i = 1; i <= countOfClients; i++)
            {
                string input = Console.ReadLine();

                while (input != "Finish")
                {
                    string decoration = input;

                    switch (decoration)
                    {
                        case "basket":
                            countOfBaskets++;
                            break;
                        case "wreath":
                            countOfWreaths++;
                            break;
                        case "chocolate bunny":
                            countOfChocolateBunny++;
                            break;
                    }
                    input = Console.ReadLine();

                    if (input == "Finish")
                    {
                        int countOfDecorations = countOfBaskets + countOfWreaths + countOfChocolateBunny;
                        double totalPricePerClient = countOfBaskets * BASKET_PRICE + countOfWreaths * WREATH_PRICE + countOfChocolateBunny * CHOCOLATE_BUNNY_PRICE;
                        if (countOfDecorations % 2 == 0)
                        {
                            totalPricePerClient *= 0.8;
                        }
                        Console.WriteLine($"You purchased {countOfDecorations} items for {totalPricePerClient:f2} leva.");
                        totalPrice += totalPricePerClient;
                        countOfBaskets = 0;
                        countOfWreaths = 0;
                        countOfChocolateBunny = 0;
                    }
                }
            }
            Console.WriteLine($"Average bill per client is: {totalPrice / countOfClients:f2} leva.");
        }
    }
}
