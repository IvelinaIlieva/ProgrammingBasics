using System;

namespace P03._Film_Premiere
{
    class Program
    {
        static void Main()
        {
            //input:
            string nameOfMovie = Console.ReadLine();
            string package = Console.ReadLine();
            int countOfTickets = int.Parse(Console.ReadLine());

            //calculations:
            double totalPrice = countOfTickets;

            switch (nameOfMovie)
            {
                case "John Wick":
                    switch (package)
                    {
                        case "Drink":
                            totalPrice *= 12;
                            break;
                        case "Popcorn":
                            totalPrice *= 15;
                            break;
                        case "Menu":
                            totalPrice *= 19;
                            break;
                    }
                    break;
                case "Star Wars":
                    switch (package)
                    {
                        case "Drink":
                            totalPrice *= 18;
                            break;
                        case "Popcorn":
                            totalPrice *= 25;
                            break;
                        case "Menu":
                            totalPrice *= 30;
                            break;
                    }
                    if (countOfTickets >= 4)
                    {
                        totalPrice *= 0.7;
                    }
                    break;
                case "Jumanji":
                    switch (package)
                    {
                        case "Drink":
                            totalPrice *= 9;
                            break;
                        case "Popcorn":
                            totalPrice *= 11;
                            break;
                        case "Menu":
                            totalPrice *= 14;
                            break;
                    }
                    if (countOfTickets==2)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
            }

            //print:
            Console.WriteLine($"Your bill is {totalPrice:f2} leva.");
        }
    }
}
