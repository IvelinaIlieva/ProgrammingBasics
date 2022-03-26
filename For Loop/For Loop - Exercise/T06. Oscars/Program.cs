using System;

namespace T06._Oscars
{
    class Program
    {
        static void Main()
        {
            //input data:
            string nameOfActor = Console.ReadLine();
            double pointsOfAcademy = double.Parse(Console.ReadLine());
            int countOfJury = int.Parse(Console.ReadLine());

            double totalPoints = pointsOfAcademy;
            const double POINTS_FOR_NOMINATION = 1250.5;

            for (int i = 1; i <= countOfJury; i++)
            {
                string nameOfJury = Console.ReadLine();
                double pointsOfJury = double.Parse(Console.ReadLine());

                double totalPointsOfJury = nameOfJury.Length * pointsOfJury / 2;
                totalPoints += totalPointsOfJury;
                if (totalPoints >= POINTS_FOR_NOMINATION)
                {
                    Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {totalPoints:f1}!");
                    break;
                }
            }
            if (totalPoints < POINTS_FOR_NOMINATION)
            {
                Console.WriteLine($"Sorry, {nameOfActor} you need {Math.Abs(totalPoints - POINTS_FOR_NOMINATION):f1} more!");
            }
        }
    }
}
