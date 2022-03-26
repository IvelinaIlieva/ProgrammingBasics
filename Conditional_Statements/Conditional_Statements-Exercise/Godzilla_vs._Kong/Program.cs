using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //input:
            double budget = double.Parse(Console.ReadLine());
            int stunt = int.Parse(Console.ReadLine());
            double suitPrice = double.Parse(Console.ReadLine());

            double decorPrice = 0.1 * budget;
            if (stunt > 150)
            {
                suitPrice *= .90;
            }

            double expences = decorPrice + stunt * suitPrice;
            double defference = Math.Abs(expences - budget);

            //print:
            if (expences - budget>0)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {defference:f2} leva more.");
                            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {defference:f2} leva left.");
            }
            
        }
    }
}
