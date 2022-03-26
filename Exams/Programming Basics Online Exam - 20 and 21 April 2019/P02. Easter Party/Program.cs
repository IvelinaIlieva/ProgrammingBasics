using System;

namespace P02._Easter_Party
{
    class Program
    {
        static void Main()
        {
            //input:
            int countOfGuests = int.Parse(Console.ReadLine());
            double couvertFor1Person = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            //add data:
            double cakePrice = 0.1 * budget;

            //calculations:
            double totalCouvert = countOfGuests * couvertFor1Person;

            if (countOfGuests > 20)
            {
                totalCouvert *= 0.75;
            }
            else if (countOfGuests > 15)
            {
                totalCouvert *= 0.8;
            }
            else if (countOfGuests >= 10)
            {
                totalCouvert *= 0.85;
            }

            totalCouvert += cakePrice;

            double difference = Math.Abs(budget - totalCouvert);

            //print:
            Console.WriteLine(budget >= totalCouvert ? $"It is party time! {difference:f2} leva left." : $"No party! {difference:f2} leva needed.");
        }
    }
}
