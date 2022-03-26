using System;

namespace P05._Football_Tournament
{
    class Program
    {
        static void Main()
        {
            string nameOfTeam = Console.ReadLine();
            int countOfGames = int.Parse(Console.ReadLine());

            int countOfW = 0;
            int countOfD = 0;
            int countOfL = 0;
            int totalPoints = 0;

            for (int i = 1; i <= countOfGames; i++)
            {
                char result = char.Parse(Console.ReadLine());

                switch (result)
                {
                    case 'W':
                        countOfW++;
                        break;
                    case 'D':
                        countOfD++;
                        break;
                    case 'L':
                        countOfL++;
                        break;
                }
                totalPoints = countOfW * 3 + countOfD * 1;
            }
            if (countOfGames == 0)
            {
                Console.WriteLine($"{nameOfTeam} hasn't played any games during this season.");
            }
            else
            {
                Console.WriteLine($"{nameOfTeam} has won {totalPoints} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {countOfW}");
                Console.WriteLine($"## D: {countOfD}");
                Console.WriteLine($"## L: {countOfL}");
                Console.WriteLine($"Win rate: {(double)countOfW/countOfGames*100:f2}%");
            }
        }
    }
}
