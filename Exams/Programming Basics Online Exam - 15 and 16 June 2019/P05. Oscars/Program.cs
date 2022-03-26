using System;

namespace P05._Oscars
{
    class Program
    {
        static void Main()
        {
            string nameOfActor = Console.ReadLine();
            double pointsOfAcademy = double.Parse(Console.ReadLine());
            int countOfJury = int.Parse(Console.ReadLine());

            double totalPoints = pointsOfAcademy;

            for (int i = 0; i < countOfJury; i++)
            {
                string nameOfJury = Console.ReadLine();
                double pointsFromJury = double.Parse(Console.ReadLine());
                double currentPoints = nameOfJury.Length * pointsFromJury / 2;
                totalPoints += currentPoints;

                if (totalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {totalPoints:f1}!");
                    break;
                }
            }
            if (totalPoints <= 1250.5)
            {
                Console.WriteLine($"Sorry, {nameOfActor} you need {1250.5 - totalPoints:f1} more!");
            }
        }
    }
}
