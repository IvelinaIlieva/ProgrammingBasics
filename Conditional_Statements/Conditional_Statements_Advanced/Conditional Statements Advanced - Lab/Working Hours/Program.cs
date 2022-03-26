using System;

namespace Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            int hour = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            //calculations:
            if (hour >= 10 && hour <= 18 && dayOfWeek != "Sunday")
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
