using System;

namespace P06._Easter_Competition
{
    class Program
    {
        static void Main()
        {
            int countOfEasterBread = int.Parse(Console.ReadLine());

            int totalPoints = 0;
            int maxPoints = int.MinValue;
            string winner = "";
            
            for (int i = 1; i <= countOfEasterBread; i++)
            {
                string nameOfCooker = Console.ReadLine();
                string input = Console.ReadLine();

                while (input != "Stop")
                {
                    int points = int.Parse(input);
                    totalPoints += points;
                    input = Console.ReadLine();
                }
                int pointsPerCooker = totalPoints;
                totalPoints = 0;

                if (input == "Stop")
                {
                    Console.WriteLine($"{nameOfCooker} has {pointsPerCooker} points.");

                    if (pointsPerCooker > maxPoints)
                    {
                        maxPoints = pointsPerCooker;
                        winner = nameOfCooker;
                        Console.WriteLine($"{winner} is the new number 1!");
                    }
                }
            }
            Console.WriteLine($"{winner} won competition with {maxPoints} points!");
        }
    }
}
