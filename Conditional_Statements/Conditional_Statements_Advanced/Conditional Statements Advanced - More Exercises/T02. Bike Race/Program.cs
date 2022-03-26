using System;

namespace T02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            int countOfJuniorRacer = int.Parse(Console.ReadLine());
            int countOfSeniorRacer = int.Parse(Console.ReadLine());
            string route = Console.ReadLine();

            //add data:
            const double PRICE_FOR_JUNIORS_TRAIL = 5.5;
            const double PRICE_FOR_JUNIORS_CROSSCOUNTRY = 8;
            const double PRICE_FOR_JUNIORS_DOWNHILL = 12.25;
            const double PRICE_FOR_JUNIORS_ROAD = 20;
            const double PRICE_FOR_SENIORS_TRAIL = 7;
            const double PRICE_FOR_SENIORS_CROSSCOUNTRY = 9.5;
            const double PRICE_FOR_SENIORS_DOWNHILL = 13.75;
            const double PRICE_FOR_SENIORS_ROAD = 21.5;
            
            //calculations:
            double totalTax = 0;

            switch (route)
            {
                case "trail":
                    totalTax = countOfJuniorRacer * PRICE_FOR_JUNIORS_TRAIL + countOfSeniorRacer * PRICE_FOR_SENIORS_TRAIL;
                    break;
                case "cross-country":
                    totalTax = countOfJuniorRacer * PRICE_FOR_JUNIORS_CROSSCOUNTRY + countOfSeniorRacer * PRICE_FOR_SENIORS_CROSSCOUNTRY;
                    if ((countOfSeniorRacer+countOfJuniorRacer) >=50)
                    {
                        totalTax *= 0.75;
                    }
                    break;
                case "downhill":
                    totalTax = countOfJuniorRacer * PRICE_FOR_JUNIORS_DOWNHILL + countOfSeniorRacer * PRICE_FOR_SENIORS_DOWNHILL;
                    break;
                case "road":
                    totalTax = countOfJuniorRacer * PRICE_FOR_JUNIORS_ROAD + countOfSeniorRacer * PRICE_FOR_SENIORS_ROAD;
                    break;
            }
            totalTax *= 0.95;
            
            //print:
            Console.WriteLine($"{totalTax:f2}");
        }
    }
}
