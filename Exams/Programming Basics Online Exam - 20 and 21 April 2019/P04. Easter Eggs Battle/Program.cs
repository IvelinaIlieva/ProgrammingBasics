using System;

namespace P04._Easter_Eggs_Battle
{
    class Program
    {
        static void Main()
        {
            int countOfFirstPlayerEggs = int.Parse(Console.ReadLine());
            int countOfSecondPlayerEggs = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "End of battle")
            {
                switch (input)
                {
                    case "one":
                        countOfSecondPlayerEggs--;
                        if (countOfSecondPlayerEggs == 0)
                        {
                            Console.WriteLine($"Player two is out of eggs. Player one has {countOfFirstPlayerEggs} eggs left.");
                            return;
                        }
                        break;
                    case "two":
                        countOfFirstPlayerEggs--;
                        if (countOfFirstPlayerEggs == 0)
                        {
                            Console.WriteLine($"Player one is out of eggs. Player two has {countOfSecondPlayerEggs} eggs left.");
                            return;
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            if (input == "End of battle")
            {
                Console.WriteLine($"Player one has {countOfFirstPlayerEggs} eggs left.");
                Console.WriteLine($"Player two has {countOfSecondPlayerEggs} eggs left.");
            }
        }
    }
}
