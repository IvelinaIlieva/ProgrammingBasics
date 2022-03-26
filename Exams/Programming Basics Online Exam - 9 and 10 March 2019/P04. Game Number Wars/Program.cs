using System;

namespace P04._Game_Number_Wars
{
    class Program
    {
        static void Main()
        {
            //input:
            string firstPlayerName = Console.ReadLine();
            string secondPlayerName = Console.ReadLine();

            string input = Console.ReadLine();

            int pointsFirstPlayer = 0;
            int pointsSecondPlayer = 0;

            while (input != "End of game")
            {
                int firstPlayerCard = int.Parse(input);
                int secondPlayerCard = int.Parse(Console.ReadLine());

                if (firstPlayerCard > secondPlayerCard)
                {
                    pointsFirstPlayer += firstPlayerCard - secondPlayerCard;
                }
                else if (secondPlayerCard > firstPlayerCard)
                {
                    pointsSecondPlayer += secondPlayerCard - firstPlayerCard;
                }
                else
                {
                    firstPlayerCard = int.Parse(Console.ReadLine());
                    secondPlayerCard = int.Parse(Console.ReadLine());

                    Console.WriteLine("Number wars!");

                    if (firstPlayerCard > secondPlayerCard)
                    {
                        Console.WriteLine($"{firstPlayerName} is winner with {pointsFirstPlayer} points");
                        break;
                    }
                    else if (secondPlayerCard > firstPlayerCard)
                    {
                        Console.WriteLine($"{secondPlayerName} is winner with {pointsSecondPlayer} points");
                        break;
                    }
                }

                input = Console.ReadLine();
                if (input == "End of game")
                {
                    Console.WriteLine($"{firstPlayerName} has {pointsFirstPlayer} points");
                    Console.WriteLine($"{secondPlayerName} has {pointsSecondPlayer} points");
                    break;
                }
            }
        }
    }
}
