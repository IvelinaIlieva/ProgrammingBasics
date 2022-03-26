using System;

namespace P04._Easter_Shop
{
    class Program
    {
        static void Main()
        {
            int startQualityOfEggsInTheMarket = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int currentEggs = startQualityOfEggsInTheMarket;
            int buyedEggs = 0;

            while (input != "Close")
            {
                int countOfEggsUpDown = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case "Fill":
                        currentEggs += countOfEggsUpDown;
                        break;
                    case "Buy":
                        buyedEggs += countOfEggsUpDown;

                        if (countOfEggsUpDown > currentEggs)
                        {
                            Console.WriteLine("Not enough eggs in store!");
                            Console.WriteLine($"You can buy only {currentEggs}.");
                            return;
                        }
                        currentEggs -= countOfEggsUpDown;
                        break;
                }
                input = Console.ReadLine();
            }
            if (input == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{buyedEggs} eggs sold.");
            }
        }
    }
}
