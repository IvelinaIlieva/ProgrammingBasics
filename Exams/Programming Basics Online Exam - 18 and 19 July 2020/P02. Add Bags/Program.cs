using System;

namespace P02._Add_Bags
{
    class Program
    {
        static void Main()
        {
            //input:
            double baggagePriceOver20Kg = double.Parse(Console.ReadLine());
            double baggageKg = double.Parse(Console.ReadLine());
            int daysToTravel = int.Parse(Console.ReadLine());
            int countOfBaggage = int.Parse(Console.ReadLine());

            //calculations:
            double baggagePrice = baggagePriceOver20Kg;

            if (baggageKg < 10)
            {
                baggagePrice *= 0.2;
            }
            else if (baggageKg >= 10 && baggageKg <= 20)
            {
                baggagePrice *= 0.5;
            }

            if (daysToTravel > 30)
            {
                baggagePrice *= 1.1;
            }
            else if (daysToTravel >= 7)
            {
                baggagePrice *= 1.15;
            }
            else
            {
                baggagePrice *= 1.4;
            }

            //print:
            Console.WriteLine($"The total price of bags is: {countOfBaggage*baggagePrice:f2} lv.");
        }
    }
}
