using System;

namespace T01._Dishwasher
{
    class Program
    {
        static void Main()
        {
            const int BOTTLE_VALUE = 750;
            const int DETERGENT_DISH = 5;
            const int DETERGENT_POT = 15;

            int countOfBottle = int.Parse(Console.ReadLine());

            string input = "";
            int counter = 0;
            int countOfDishes = 0;
            int countOfCookers = 0;
            int leftDetergent = countOfBottle * BOTTLE_VALUE;

            while (input != "End")
            {
                input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                int countOfPots = int.Parse(input);
                counter++;

                if (counter % 3 == 0)
                {
                    leftDetergent -= countOfPots * DETERGENT_POT;
                    countOfCookers += countOfPots;
                }
                else
                {
                    leftDetergent -= countOfPots * DETERGENT_DISH;
                    countOfDishes += countOfPots;
                }
                if (leftDetergent < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(leftDetergent)} ml. more necessary!");
                    break;
                }
            }
            if (leftDetergent >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{countOfDishes} dishes and {countOfCookers} pots were washed.");
                Console.WriteLine($"Leftover detergent {leftDetergent} ml.");
            }
        }
    }
}

