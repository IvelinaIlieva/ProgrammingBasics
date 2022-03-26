using System;

namespace T04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countOfFisher = int.Parse(Console.ReadLine());
            
            //add data:
            const double SHIP_PRICE_IN_SPRING = 3000;
            const double SHIP_PRICE_IN_SUMMER_AND_AUTUMN = 4200;
            const double SHIP_PRICE_IN_WINTER = 2600;

            //calculations:
            double finalPrice = 0;
            switch (season)
            {
                case "Spring":
                    if (countOfFisher<=6)
                    {
                        finalPrice = SHIP_PRICE_IN_SPRING * 0.9;
                    }
                    else if (countOfFisher <=11)
                    {
                        finalPrice = SHIP_PRICE_IN_SPRING * 0.85;
                    }
                    else
                    {
                        finalPrice = SHIP_PRICE_IN_SPRING * 0.75;
                    }
                    break;
                case "Summer":
                case "Autumn":
                    if (countOfFisher <= 6)
                    {
                        finalPrice = SHIP_PRICE_IN_SUMMER_AND_AUTUMN * 0.9;
                    }
                    else if (countOfFisher <= 11)
                    {
                        finalPrice = SHIP_PRICE_IN_SUMMER_AND_AUTUMN * 0.85;
                    }
                    else
                    {
                        finalPrice = SHIP_PRICE_IN_SUMMER_AND_AUTUMN * 0.75;
                    }
                    break;
                case "Winter":
                    if (countOfFisher <= 6)
                    {
                        finalPrice = SHIP_PRICE_IN_WINTER * 0.9;
                    }
                    else if (countOfFisher <= 11)
                    {
                        finalPrice = SHIP_PRICE_IN_WINTER * 0.85;
                    }
                    else
                    {
                        finalPrice = SHIP_PRICE_IN_WINTER * 0.75;
                    }
                    break;
            }
            if ((countOfFisher % 2 == 0) && (season != "Autumn"))
            {
                finalPrice *= 0.95;
            }
            double difference = Math.Abs(budget - finalPrice);

            //print:
            Console.WriteLine(budget>=finalPrice? $"Yes! You have {difference:f2} leva left." : $"Not enough money! You need {difference:f2} leva.");
        }
    }
}
