using System;

namespace P04._Cinema
{
    class Program
    {
        static void Main()
        {
            int totalSeats = int.Parse(Console.ReadLine());
            const int TICKET_PRICE = 5;
            int leftSeats = totalSeats;
            int totalIncome = 0;

            string input = Console.ReadLine();

            while (input != "Movie time!")
            {
                int countOfPeopleEntering = int.Parse(input);
                
                leftSeats -= countOfPeopleEntering;
                if (leftSeats < 0)
                {
                    Console.WriteLine("The cinema is full.");
                    break;
                }
                int sum = countOfPeopleEntering * TICKET_PRICE;

                if (countOfPeopleEntering % 3 == 0)
                {
                    sum -= 5;
                }
                totalIncome += sum;
                input = Console.ReadLine();
            }
            if (input == "Movie time!")
            {
                Console.WriteLine($"There are {leftSeats} seats left in the cinema.");

            }

            Console.WriteLine($"Cinema income - {totalIncome} lv.");
        }
    }
}
