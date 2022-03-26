using System;

namespace P04._Movie_Stars
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());

            double leftBudget = budget;

            string input = Console.ReadLine();

            while (input != "ACTION")
            {
                string actorName = input;

                if (actorName.Length <= 15)
                {
                    double salary = double.Parse(Console.ReadLine());
                    leftBudget -= salary;
                }
                else
                {
                    leftBudget *= 0.8;
                }
                if (leftBudget < 0)
                {
                    Console.WriteLine($"We need {Math.Abs(leftBudget):f2} leva for our actors.");
                    return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"We are left with {leftBudget:f2} leva.");
        }
    }
}
