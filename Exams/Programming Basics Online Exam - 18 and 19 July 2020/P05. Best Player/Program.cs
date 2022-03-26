using System;

namespace P05._Best_Player
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int maxGoals = int.MinValue;
            string bestPlayer = "";

            while (input != "END")
            {
                string nameOfPlayer = input;
                int goals = int.Parse(Console.ReadLine());

                if (goals > maxGoals)
                {
                    maxGoals = goals;
                    bestPlayer = nameOfPlayer;
                }

                if (goals >= 10)
                {
                    break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            Console.WriteLine(maxGoals >= 3 ? $"He has scored {maxGoals} goals and made a hat-trick !!!" : $"He has scored {maxGoals} goals.");
        }
    }
}
