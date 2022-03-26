using System;

namespace P03._Painting_Eggs
{
    class Program
    {
        static void Main()
        {
            const double LARGE_RED = 16;
            const double LARGE_GREEN = 12;
            const double LARGE_YELLOW = 9;
            const double MEDIUM_RED = 13;
            const double MEDIUM_GREEN = 9;
            const double MEDIUM_YELLOW = 7;
            const double SMALL_RED = 9;
            const double SMALL_GREEN = 8;
            const double SMALL_YELLOW = 5;

            //input:
            string eggSize = Console.ReadLine();
            string eggColour = Console.ReadLine();
            int countOfBatch = int.Parse(Console.ReadLine());

            //calculations:
            double totalPrice = 0;

            switch (eggSize)
            {
                case "Large":
                    switch (eggColour)
                    {
                        case "Red":
                            totalPrice = countOfBatch * LARGE_RED;
                            break;
                        case "Green":
                            totalPrice = countOfBatch * LARGE_GREEN;
                            break;
                        case "Yellow":
                            totalPrice = countOfBatch * LARGE_YELLOW;
                            break;
                    }
                    break;
                case "Medium":
                    switch (eggColour)
                    {
                        case "Red":
                            totalPrice = countOfBatch * MEDIUM_RED;
                            break;
                        case "Green":
                            totalPrice = countOfBatch * MEDIUM_GREEN;
                            break;
                        case "Yellow":
                            totalPrice = countOfBatch * MEDIUM_YELLOW;
                            break;
                    }
                    break;
                case "Small":
                    switch (eggColour)
                    {
                        case "Red":
                            totalPrice = countOfBatch * SMALL_RED;
                            break;
                        case "Green":
                            totalPrice = countOfBatch * SMALL_GREEN;
                            break;
                        case "Yellow":
                            totalPrice = countOfBatch * SMALL_YELLOW;
                            break;
                    }
                    break;
            }
            totalPrice *= 0.65;

            //print:
            Console.WriteLine($"{totalPrice:f2} leva.");
        }
    }
}
