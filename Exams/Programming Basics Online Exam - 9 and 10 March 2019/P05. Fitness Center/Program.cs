using System;

namespace P05._Fitness_Center
{
    class Program
    {
        static void Main()
        {
            int countOfVisitors = int.Parse(Console.ReadLine());

            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinShake = 0;
            int proteinBar = 0;

            for (int i = 1; i <= countOfVisitors; i++)
            {
                string acting = Console.ReadLine();

                switch (acting)
                {
                    case "Back":
                        back++;
                        break;
                    case "Chest":
                        chest++;
                        break;
                    case "Legs":
                        legs++;
                        break;
                    case "Abs":
                        abs++;
                        break;
                    case "Protein shake":
                        proteinShake++;
                        break;
                    case "Protein bar":
                        proteinBar++;
                        break;
                }
            }
            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{(back + chest + legs + abs) / (double)countOfVisitors * 100:f2}% - work out");
            Console.WriteLine($"{(proteinBar + proteinShake) / (double)countOfVisitors * 100:f2}% - protein");
        }
    }
}
