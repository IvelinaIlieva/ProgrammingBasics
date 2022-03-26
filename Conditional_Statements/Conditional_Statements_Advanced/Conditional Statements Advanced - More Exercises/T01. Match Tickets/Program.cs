using System;

namespace T01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int countOfFans = int.Parse(Console.ReadLine());

            //add data:
            const double PRICE_VIP = 499.99;
            const double PRICE_NORMAL = 249.99;

            //calculations:
            double transport = 0;
            double sumForTicket = 0;
            double totalExp = 0;
            double difference = 0;

            if (countOfFans>=50)
            {
                transport = budget * 0.25;
            }
            else if (countOfFans>=25)
            {
                transport = budget * 0.4;
            }
            else if (countOfFans >= 10)
            {
                transport = budget * 0.5;
            }
            else if (countOfFans >= 5)
            {
                transport = budget * 0.6;
            }
            else
            {
                transport = budget * 0.75;
            }
            switch (category)
            {
                case "VIP":
                    sumForTicket = PRICE_VIP * countOfFans;
                    break;
                case "Normal":
                    sumForTicket = PRICE_NORMAL * countOfFans;
                    break;
            }
            totalExp = transport + sumForTicket;
            difference = Math.Abs(totalExp - budget);
            //print:
            Console.WriteLine(budget>=totalExp? $"Yes! You have {difference:f2} leva left." : $"Not enough money! You need {difference:f2} leva.");
        }
    }
}
