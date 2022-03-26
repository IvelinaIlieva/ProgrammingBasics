using System;

namespace T03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            int countOfChrysanthemums = int.Parse(Console.ReadLine());
            int countOfRoses = int.Parse(Console.ReadLine());
            int countOfTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine(); 
            string isHoliday = Console.ReadLine(); 

            //add data:
            const double PRICE_FOR_CHRYSANT_SPRING_SUMMER = 2;
            const double PRICE_FOR_ROSES_SPRING_SUMMER = 4.1;
            const double PRICE_FOR_TULIPS_SPRING_SUMMER = 2.5;
            const double PRICE_FOR_CHRYSANT_AUTUMN_WINTER = 3.75;
            const double PRICE_FOR_ROSES_AUTUMN_WINTER = 4.5;
            const double PRICE_FOR_TULIPS_AUTUMN_WINTER = 4.15;

            //calculations:
            double totalPriceSpringSummer = countOfChrysanthemums * PRICE_FOR_CHRYSANT_SPRING_SUMMER + countOfRoses * PRICE_FOR_ROSES_SPRING_SUMMER + countOfTulips * PRICE_FOR_TULIPS_SPRING_SUMMER;
            double totalPriceAutumnWinter = countOfChrysanthemums * PRICE_FOR_CHRYSANT_AUTUMN_WINTER + countOfRoses * PRICE_FOR_ROSES_AUTUMN_WINTER + countOfTulips * PRICE_FOR_TULIPS_AUTUMN_WINTER;

            if (isHoliday == "Y")
            {
                totalPriceAutumnWinter *= 1.15;
                totalPriceSpringSummer *= 1.15;
            }

            if (season == "Spring" && countOfTulips > 7)
            {
                totalPriceSpringSummer *= 0.95;
            }
            if (season == "Winter" && countOfRoses >= 10)
            {
                totalPriceAutumnWinter *= 0.9;
            }
            if ((countOfChrysanthemums + countOfRoses + countOfTulips) > 20)
            {
                totalPriceAutumnWinter *= 0.8;
                totalPriceSpringSummer *= 0.8;
            }
            totalPriceSpringSummer += 2;
            totalPriceAutumnWinter += 2;

            //print:
            Console.WriteLine((season == "Spring" || season == "Summer")? $"{totalPriceSpringSummer:f2}" : $"{totalPriceAutumnWinter:f2}"); 
        }
    }
}
