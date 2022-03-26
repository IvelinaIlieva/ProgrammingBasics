using System;

namespace Weekend_or_Working_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();

            if (dayOfWeek== "Monday" || dayOfWeek== "Tuesday" || dayOfWeek== "Wednesday" || dayOfWeek== "Thursday" || dayOfWeek== "Friday")
            {
                Console.WriteLine("Working day");
            }
            else if (dayOfWeek== "Saturday" || dayOfWeek== "Sunday")
            {
                Console.WriteLine("Weekend");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
