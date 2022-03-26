using System;

namespace P01._Movie_Profit
{
    class Program
    {
        static void Main()
        {
            //input:
            string nameOfMovie = Console.ReadLine();
            int countOfDays = int.Parse(Console.ReadLine());
            int countOfTickets = int.Parse(Console.ReadLine());
            double pricePerTicket = double.Parse(Console.ReadLine());
            int percentForCinema = int.Parse(Console.ReadLine());

            //calculations:
            double totalIncomes = countOfTickets * pricePerTicket * countOfDays;
            double sumForCinema = totalIncomes * percentForCinema / 100;
            totalIncomes -= sumForCinema;

            //print:
            Console.WriteLine($"The profit from the movie {nameOfMovie} is {totalIncomes:f2} lv.");
        }
    }
}
