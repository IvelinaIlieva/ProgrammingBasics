using System;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            //input:
            int distance = int.Parse(Console.ReadLine());
            string tariff = Console.ReadLine();

            //additional information:
            double dailyPrice = 0;
            double nightPrice = 0;
            double price = 0;

            //calculations:
            if (distance>=100)
            {
                dailyPrice = nightPrice = 0.06;
                price = distance * dailyPrice;
            }
            else if (distance>=20)
            {
                dailyPrice = nightPrice = 0.09;
                price = distance * dailyPrice;
            }
            else
            {
                dailyPrice = 0.79;
                nightPrice = 0.90;
                if (tariff=="day")
                {
                    price = distance * dailyPrice + 0.70;
                }
                else if (tariff == "night")
                {
                    price = distance * nightPrice + 0.70;
                }
                           
            }
            Console.WriteLine($"{ price:f2}");
        }
    }
}
