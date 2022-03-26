using System;

namespace T05._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            //calculation and printing:
            if (budget >3000)
            {
                switch (season)
                {
                    case "Summer":
                        Console.WriteLine($"Alaska - Hotel - {(budget*0.9):f2}");
                        break;
                    case "Winter":
                        Console.WriteLine($"Morocco - Hotel - {(budget * 0.9):f2}");
                        break;
                }
            }
            else if (budget<=1000)
            {
                switch (season)
                {
                    case "Summer":
                        Console.WriteLine($"Alaska - Camp - {(budget * 0.65):f2}");
                        break;
                    case "Winter":
                        Console.WriteLine($"Morocco - Camp - {(budget * 0.45):f2}");
                        break;
                }
            }
            else
            {
                switch (season)
                {
                    case "Summer":
                        Console.WriteLine($"Alaska - Hut - {(budget * 0.8):f2}");
                        break;
                    case "Winter":
                        Console.WriteLine($"Morocco - Hut - {(budget * 0.6):f2}");
                        break;
                }
            }	
        }
    }
}
