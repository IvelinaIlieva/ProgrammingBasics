using System;

namespace T09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            int dayOfRest = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();//"room for one person", "apartment" или "president apartment"
            string rating = Console.ReadLine();//"positive"  или "negative"

            //add data:
            const double PRICE_ROOM_FOR_ONE_PERSON = 18;
            const double PRICE_APARTMENT = 25;
            const double PRICE_PRESIDENT_APARTMENT = 35;

            int nights = dayOfRest - 1;

            //calculations:
            double totalPrice = 0;
            switch (room)
            {
                case "room for one person":
                    totalPrice = PRICE_ROOM_FOR_ONE_PERSON * nights;
                    break;
                case "apartment":
                    totalPrice = PRICE_APARTMENT * nights;
                    if (dayOfRest>15)
                    {
                        totalPrice *= 0.5;
                    }
                    else if (dayOfRest >=10)
                    {
                        totalPrice *= 0.65;
                    }
                    else
                    {
                        totalPrice *= 0.7;
                    }
                    break;
                case "president apartment":
                    totalPrice = PRICE_PRESIDENT_APARTMENT * nights;
                    if (dayOfRest > 15)
                    {
                        totalPrice *= 0.8;
                    }
                    else if (dayOfRest >= 10)
                    {
                        totalPrice *= 0.85;
                    }
                    else
                    {
                        totalPrice *= 0.9;
                    }
                    break;
            }
            switch (rating)
            {
                case "positive":
                    totalPrice *= 1.25;
                    break;
                case "negative":
                    totalPrice *= 0.9;
                    break;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
