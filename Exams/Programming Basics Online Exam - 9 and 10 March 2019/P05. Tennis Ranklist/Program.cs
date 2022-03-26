using System;

namespace P05._Tennis_Ranklist
{
    class Program
    {
        static void Main()
        {
            int countOfTournaments = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());

            int winPoints = 0;
            int wins = 0;

            for (int i = 1; i <= countOfTournaments; i++)
            {
                string stage = Console.ReadLine();

                switch (stage)
                {
                    case "W":
                        points += 2000;
                        winPoints += 2000;
                        wins++;
                        break;
                    case "F":
                        points += 1200;
                        winPoints += 1200;
                        break;
                    case "SF":
                        points += 720;
                        winPoints += 720;
                        break;
                }
            }
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor((double)winPoints / countOfTournaments)}");
            Console.WriteLine($"{(double)wins / countOfTournaments * 100:f2}%");
        }
    }
}
