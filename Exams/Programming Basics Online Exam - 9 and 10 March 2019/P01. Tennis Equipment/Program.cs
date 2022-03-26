using System;

namespace P01._Tennis_Equipment
{
    class Program
    {
        static void Main()
        {
            //input:
            double rocketPrice = double.Parse(Console.ReadLine());
            int countOfRockets = int.Parse(Console.ReadLine());
            int countOfSneakers = int.Parse(Console.ReadLine());

            //calculations:
            //double totalPriceOFEquipment = 1.2 * (rocketPrice * countOfRockets + rocketPrice / 6 * countOfSneakers);
            double price = rocketPrice * countOfRockets + rocketPrice / 6 * countOfSneakers + 0.2 * (rocketPrice * countOfRockets + rocketPrice / 6 * countOfSneakers);

            //print:
            //Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(totalPriceOFEquipment/8)}");
            //Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(totalPriceOFEquipment*7/8)}");

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(price / 8)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(price * 7/8)}");
        }
    }
}
