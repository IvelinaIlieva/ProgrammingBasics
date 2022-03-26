using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int sheetsInBook = int.Parse(Console.ReadLine());
            int sheetsPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int hoursPerEndingTheBook = sheetsInBook / sheetsPerHour;
            int hoursForReadingDaily = hoursPerEndingTheBook / days;

            Console.WriteLine(hoursForReadingDaily);
        }
    }
}
