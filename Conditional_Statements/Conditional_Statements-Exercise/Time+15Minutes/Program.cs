using System;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            minute += 15;

            if (minute>=60)
            {
                hour += minute / 60;
                minute %= 60;
            }
            if (hour>23)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{minute:d2}");
        }
    }
}
