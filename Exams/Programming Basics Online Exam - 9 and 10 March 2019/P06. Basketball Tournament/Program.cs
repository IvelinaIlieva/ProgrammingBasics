using System;

namespace P06._Basketball_Tournament
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int wins = 0;
            int loses = 0;

            while (input != "End of tournaments")
            {
                string nameOfTournament = input;
                int countOfGames = int.Parse(Console.ReadLine());

                for (int i = 1; i <= countOfGames; i++)
                {
                    int pointsOfTeam = int.Parse(Console.ReadLine());
                    int pointsOfTheOtherTeam = int.Parse(Console.ReadLine());

                    if (pointsOfTeam > pointsOfTheOtherTeam)
                    {
                        wins++;
                        Console.WriteLine($"Game {i} of tournament {nameOfTournament}: win with {pointsOfTeam - pointsOfTheOtherTeam} points.");
                    }
                    else
                    {
                        loses++;
                        Console.WriteLine($"Game {i} of tournament {nameOfTournament}: lost with {pointsOfTheOtherTeam-pointsOfTeam} points.");
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{(double)wins / (wins + loses) * 100:f2}% matches win");
            Console.WriteLine($"{(double)loses / (wins + loses) * 100:f2}% matches lost");
        }
    }
}
