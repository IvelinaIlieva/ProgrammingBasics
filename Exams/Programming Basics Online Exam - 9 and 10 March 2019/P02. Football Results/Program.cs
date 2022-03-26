using System;

namespace P02._Football_Results
{
    class Program
    {
        static void Main()
        {
            int wins = 0;
            int loses = 0;
            int drawns = 0;

            for (int i = 1; i <= 3; i++)
            {
                string result = Console.ReadLine();

                char hostGoals = result[0];
                char guestGoals = result[2];

                if (hostGoals > guestGoals)
                {
                    wins++;
                }
                else if (hostGoals<guestGoals)
                {
                    loses++;
                }
                else
                {
                    drawns++;
                }
            }

            //print:
            Console.WriteLine($"Team won {wins} games.");
            Console.WriteLine($"Team lost {loses} games.");
            Console.WriteLine($"Drawn games: {drawns}"); 
        }
    }
}
