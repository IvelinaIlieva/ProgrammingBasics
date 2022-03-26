using System;

namespace T08._Tennis_Ranklist
{
    class Program
    {
        static void Main()
        {
            //input data:
            int countOfTournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int pointsWinner = 2000;
            int pointsFinalist = 1200;
            int pointsSemiFinalist = 720;

            //calculations:
            int allPoints = startPoints;
            int wins = 0;

            for (int i = 0; i < countOfTournaments; i++)
            {
                string stageOfTournament = Console.ReadLine();

                switch (stageOfTournament)
                {
                    case "W":
                        allPoints += pointsWinner;
                        wins++;
                        break;
                    case "F":
                        allPoints += pointsFinalist;
                        break;
                    case "SF":
                        allPoints += pointsSemiFinalist;
                        break;
                }
            }

            //print:
            Console.WriteLine($"Final points: {allPoints}");

            double averagePoints = 1.0 * (allPoints - startPoints)/ countOfTournaments;

            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");

            double percentWinTournament = 1.0 * wins / countOfTournaments * 100;

            Console.WriteLine($"{percentWinTournament:f2}%");
        }
    }
}
