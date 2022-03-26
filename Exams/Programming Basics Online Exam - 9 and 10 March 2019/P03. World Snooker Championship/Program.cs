using System;

namespace P03._World_Snooker_Championship
{
    class Program
    {
        static void Main()
        {
            //const:
            int PRICE_OF_PICTURE = 40;

            //input:
            string stage = Console.ReadLine();
            string kindOfTicket = Console.ReadLine();
            int countOfTickets = int.Parse(Console.ReadLine());
            string pictureWithTrophy = Console.ReadLine();

            //calculations:
            double totalPriceOfTickets = 0;

            switch (stage)
            {
                case "Quarter final":
                    switch (kindOfTicket)
                    {
                        case "Standard":
                            totalPriceOfTickets = 55.5 * countOfTickets;
                            break;
                        case "Premium":
                            totalPriceOfTickets = 105.2 * countOfTickets;
                            break;
                        case "VIP":
                            totalPriceOfTickets = 118.9 * countOfTickets;
                            break;
                    }
                    break;
                case "Semi final":
                    switch (kindOfTicket)
                    {
                        case "Standard":
                            totalPriceOfTickets = 75.88 * countOfTickets;
                            break;
                        case "Premium":
                            totalPriceOfTickets = 125.22 * countOfTickets;
                            break;
                        case "VIP":
                            totalPriceOfTickets = 300.4 * countOfTickets;
                            break;
                    }
                    break;
                case "Final":
                    switch (kindOfTicket)
                    {
                        case "Standard":
                            totalPriceOfTickets = 110.1 * countOfTickets;
                            break;
                        case "Premium":
                            totalPriceOfTickets = 160.66 * countOfTickets;
                            break;
                        case "VIP":
                            totalPriceOfTickets = 400 * countOfTickets;
                            break;
                    }
                    break;
            }
            if (totalPriceOfTickets > 4000)
            {
                totalPriceOfTickets *= 0.75;

                if (pictureWithTrophy == "Y")
                {
                    PRICE_OF_PICTURE = 0;
                }
            }
            else if (totalPriceOfTickets > 2500)
            {
                totalPriceOfTickets *= 0.9;
            }

            if (pictureWithTrophy == "Y")
            {
                totalPriceOfTickets += countOfTickets * PRICE_OF_PICTURE;
            }

            //print:
            Console.WriteLine($"{totalPriceOfTickets:f2}");
        }
    }
}
