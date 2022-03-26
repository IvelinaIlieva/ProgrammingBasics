using System;

namespace P02._Easter_Guests
{
    class Program
    {
        static void Main()
        {
            const double PRICE_OF_EASTER_BREAD = 4;
            const double PRICE_OF_EGG = 0.45;

            //input:
            int countOfGuests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            //calculations:
            int countOfEggs = countOfGuests * 2;
            double countOfEasterBread = Math.Ceiling(countOfGuests / 3.0);

            double totalSum = countOfEggs * PRICE_OF_EGG + countOfEasterBread * PRICE_OF_EASTER_BREAD;
            double difference = Math.Abs(budget - totalSum);

            //print:
            if (budget >= totalSum)
            {
                Console.WriteLine($"Lyubo bought {countOfEasterBread} Easter bread and {countOfEggs} eggs.");
                Console.WriteLine($"He has {difference:f2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {difference:f2} lv. more.");
            }
        }
    }
}
