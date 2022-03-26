using System;

namespace P05._PC_Game_Shop
{
    class Program
    {
        static void Main()
        {
            int countOfSoldGames = int.Parse(Console.ReadLine());

            int countOfHearthstone = 0;
            int countOfFornite = 0;
            int countOfOverwatch = 0;
            int countOfOthers = 0;

            for (int i = 1; i <= countOfSoldGames; i++)
            {
                string nameOfGame = Console.ReadLine();

                switch (nameOfGame)
                {
                    case "Hearthstone":
                        countOfHearthstone++;
                        break;
                    case "Fornite":
                        countOfFornite++;
                        break;
                    case "Overwatch":
                        countOfOverwatch++;
                        break;
                    default:
                        countOfOthers++;
                        break;
                }
            }
            Console.WriteLine($"Hearthstone - {(double)countOfHearthstone / countOfSoldGames * 100:f2}%");
            Console.WriteLine($"Fornite - {(double)countOfFornite / countOfSoldGames * 100:f2}%");
            Console.WriteLine($"Overwatch - {(double)countOfOverwatch / countOfSoldGames * 100:f2}%");
            Console.WriteLine($"Others - {(double)countOfOthers / countOfSoldGames * 100:f2}%");
        }
    }
}
