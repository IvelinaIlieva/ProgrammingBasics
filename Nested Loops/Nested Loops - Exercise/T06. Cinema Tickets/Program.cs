using System;

namespace T06._Cinema_Tickets
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int totalKidsTicket = 0;
            int totalStudentTicket = 0;
            int totalStandardTicket = 0;

            while (input != "Finish")
            {
                int countOfStudentTicket = 0;
                int countOfStandardTicket = 0;
                int countOfKidsTicket = 0;

                int freeSpaces = int.Parse(Console.ReadLine());
                int countOfTickets = 0;

                while (countOfTickets < freeSpaces)
                {
                    string kindOfTicket = Console.ReadLine();
                    if (kindOfTicket == "End")
                    {
                        break;
                    }

                    countOfTickets++;

                    switch (kindOfTicket)
                    {
                        case "student":
                            countOfStudentTicket++;
                            break;
                        case "standard":
                            countOfStandardTicket++;
                            break;
                        case "kid":
                            countOfKidsTicket++;
                            break;
                    }
                }

                Console.WriteLine($"{input} - {((double)countOfTickets / freeSpaces * 100):f2}% full.");
                totalKidsTicket += countOfKidsTicket;
                totalStandardTicket += countOfStandardTicket;
                totalStudentTicket += countOfStudentTicket;

                freeSpaces = 0;
                countOfKidsTicket = 0;
                countOfStandardTicket = 0;
                countOfStudentTicket = 0;

                input = Console.ReadLine();
            }
            int totalTickets = totalKidsTicket + totalStandardTicket + totalStudentTicket;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)totalStudentTicket / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)totalStandardTicket / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{(double)totalKidsTicket / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
