using System;

namespace P06._Cinema_Tickets
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int totalTickets = 0;
            int totalStudentsTicket = 0;
            int totalStandardsTicket = 0;
            int totalKidsTicket = 0;

            while (input != "Finish")
            {

                string nameOfMovie = input;
                int freePlaces = int.Parse(Console.ReadLine());

                int studentsTicket = 0;
                int standardsTicket = 0;
                int kidsTicket = 0;
                int sumOfTickets = 0;

                while (freePlaces > sumOfTickets)
                {
                    string kindOfTicket = Console.ReadLine();

                    if (kindOfTicket == "End")
                    {
                        break;
                    }

                    switch (kindOfTicket)
                    {
                        case "student":
                            studentsTicket++;
                            sumOfTickets++;
                            break;
                        case "standard":
                            standardsTicket++;
                            sumOfTickets++;
                            break;
                        case "kid":
                            kidsTicket++;
                            sumOfTickets++;
                            break;
                    }
                }
                Console.WriteLine($"{nameOfMovie} - {(double)sumOfTickets / freePlaces * 100:f2}% full.");

                totalTickets += sumOfTickets;
                totalStudentsTicket += studentsTicket;
                totalStandardsTicket += standardsTicket;
                totalKidsTicket += kidsTicket;

                freePlaces = 0;

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)totalStudentsTicket / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)totalStandardsTicket / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{(double)totalKidsTicket / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
