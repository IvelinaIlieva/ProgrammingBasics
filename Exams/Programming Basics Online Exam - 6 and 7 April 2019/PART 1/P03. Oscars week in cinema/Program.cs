using System;

namespace P03._Oscars_week_in_cinema
{
    class Program
    {
        static void Main()
        {
            //input:
            string movie = Console.ReadLine();
            string hall = Console.ReadLine();
            int countOfTickets = int.Parse(Console.ReadLine());

            //calculations:
            double ticketPrice = 0;

            switch (movie)
            {
                case "A Star Is Born":
                    switch (hall)
                    {
                        case "normal":
                            ticketPrice = 7.5;
                            break;
                        case "luxury":
                            ticketPrice = 10.5;
                            break;
                        case "ultra luxury":
                            ticketPrice = 13.5;
                            break;
                    }
                    break;
                case "Bohemian Rhapsody":
                    switch (hall)
                    {
                        case "normal":
                            ticketPrice = 7.35;
                            break;
                        case "luxury":
                            ticketPrice = 9.45;
                            break;
                        case "ultra luxury":
                            ticketPrice = 12.75;
                            break;
                    }
                    break;
                case "Green Book":
                    switch (hall)
                    {
                        case "normal":
                            ticketPrice = 8.15;
                            break;
                        case "luxury":
                            ticketPrice = 10.25;
                            break;
                        case "ultra luxury":
                            ticketPrice = 13.25;
                            break;
                    }
                    break;
                case "The Favourite":
                    switch (hall)
                    {
                        case "normal":
                            ticketPrice = 8.75;
                            break;
                        case "luxury":
                            ticketPrice = 11.55;
                            break;
                        case "ultra luxury":
                            ticketPrice = 13.95;
                            break;
                    }
                    break;
            }
            double totalMoney = countOfTickets * ticketPrice;

            //print:
            Console.WriteLine($"{movie} -> {totalMoney:f2} lv.");
        }
    }
}
