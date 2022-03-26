using System;

namespace Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            //input information:
            string fuel = Console.ReadLine().ToLower();
            double fuelQuantity = double.Parse(Console.ReadLine());

            //print:
            if (fuel == "diesel" || fuel == "gasoline" || fuel == "gas")
            {
                if (fuelQuantity >= 25)
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
