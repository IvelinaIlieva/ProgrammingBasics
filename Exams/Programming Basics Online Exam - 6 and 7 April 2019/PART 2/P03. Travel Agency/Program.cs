using System;

namespace P03._Travel_Agency
{
    class Program
    {
        static void Main()
        {
            //input:
            string town = Console.ReadLine();
            string kindOfPack = Console.ReadLine();
            string cardVIP = Console.ReadLine();
            int daysForRest = int.Parse(Console.ReadLine());

            //calculations:
            double pricePerDay = 0;

            if (daysForRest < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }

            switch (town)
            {
                case "Bansko":
                case "Borovets":
                    switch (kindOfPack)
                    {
                        case "withEquipment":
                            pricePerDay = 100;

                            if (cardVIP == "yes")
                            {
                                pricePerDay *= 0.9;
                            }
                            break;
                        case "noEquipment":
                            pricePerDay = 80;

                            if (cardVIP == "yes")
                            {
                                pricePerDay *= 0.95;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            return;
                    }
                    break;
                case "Varna":
                case "Burgas":
                    switch (kindOfPack)
                    {
                        case "withBreakfast":
                            pricePerDay = 130;

                            if (cardVIP == "yes")
                            {
                                pricePerDay *= 0.88;
                            }
                            break;
                        case "noBreakfast":
                            pricePerDay = 100;

                            if (cardVIP == "yes")
                            {
                                pricePerDay *= 0.93;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            return;

                    }
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    return;

            }
            if (daysForRest > 7)
            {
                daysForRest -= 1;
            }

            //print:
            Console.WriteLine($"The price is {daysForRest * pricePerDay:f2}lv! Have a nice time!");
        }
    }
}
