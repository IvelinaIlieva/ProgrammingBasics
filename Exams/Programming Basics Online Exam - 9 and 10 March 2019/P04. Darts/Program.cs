using System;

namespace P04._Darts
{
    class Program
    {
        static void Main()
        {
            int leftPoints = 301;

            string nameOfPlayer = Console.ReadLine();

            string input = Console.ReadLine();
            int winShots = 0;
            int badShots = 0;

            while (input != "Retire")
            {
                string sector = input;
                int points = int.Parse(Console.ReadLine());

                switch (sector)
                {
                    case "Double":
                        points *= 2;
                        break;
                    case "Triple":
                        points *= 3;
                        break;
                }

                if (leftPoints >= points)
                {
                    winShots++;
                    leftPoints -= points;

                    if (leftPoints == 0)
                    {
                        Console.WriteLine($"{nameOfPlayer} won the leg with {winShots} shots.");
                        break;
                    }
                }
                else if (leftPoints < points)
                {
                    badShots++;
                }

                input = Console.ReadLine();
                if (input == "Retire")
                {
                    Console.WriteLine($"{nameOfPlayer} retired after {badShots} unsuccessful shots.");
                }
            }
        }
    }
}
