using System;

namespace P05._Everest
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int days = 1;
            int totalClimbedMeters = 5364;

            while (input != "END")
            {
                int climbedMeters = int.Parse(Console.ReadLine());

                if (input == "Yes")
                {
                    days++;

                    if (days > 5)
                    {
                        break;
                    }
                }
                totalClimbedMeters += climbedMeters;

                if (totalClimbedMeters >= 8848)
                {
                    Console.WriteLine($"Goal reached for {days} days!");
                    return;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Failed!");
            Console.WriteLine($"{totalClimbedMeters}");
        }
    }
}
