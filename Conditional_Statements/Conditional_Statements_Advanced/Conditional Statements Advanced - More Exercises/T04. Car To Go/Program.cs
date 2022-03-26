using System;

namespace T04._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            //calculations:
            double finalPrice = 0;
            if (budget <= 100)
            {
                Console.WriteLine("Economy class");
                switch (season)
                {
                    case "Summer":
                        finalPrice = budget * 0.35;
                        Console.WriteLine($"Cabrio - {finalPrice:f2}");
                        break;
                    case "Winter":
                        finalPrice = budget * 0.65;
                        Console.WriteLine($"Jeep - {finalPrice:f2}");
                        break;
                }
            }
            else if (budget > 500)
            {
                finalPrice = budget * 0.9;
                Console.WriteLine("Luxury class");
                Console.WriteLine($"Jeep - {finalPrice:f2}");
            }
            else
            {
                Console.WriteLine("Compact class");
                switch (season)
                {
                    case "Summer":
                        finalPrice = budget * 0.45;
                        Console.WriteLine($"Cabrio - {finalPrice:f2}");
                        break;
                    case "Winter":
                        finalPrice = budget * 0.8;
                        Console.WriteLine($"Jeep - {finalPrice:f2}");
                        break;
                }
            }
        }
    }
}
