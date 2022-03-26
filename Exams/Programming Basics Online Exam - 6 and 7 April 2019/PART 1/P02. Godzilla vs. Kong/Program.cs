using System;

namespace P02._Godzilla_vs._Kong
{
    class Program
    {
        static void Main()
        {
            //input:
            double budget = double.Parse(Console.ReadLine());
            int countOfStunts = int.Parse(Console.ReadLine());
            double clothPricePerStunt = double.Parse(Console.ReadLine());

            //calculations:
            double decorPrice = budget * 0.1;

            if (countOfStunts > 150)
            {
                clothPricePerStunt *= 0.9;
            }

            double totalMoney = decorPrice + countOfStunts * clothPricePerStunt;
            double diff = Math.Abs(totalMoney - budget);

            //print:
            if (totalMoney>budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {diff:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {diff:f2} leva left.");
            }
        }
    }
}
