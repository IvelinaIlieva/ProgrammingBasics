using System;

namespace Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            //input:
            int daysForRest = int.Parse(Console.ReadLine());

            //additional info:
            int limit = 30000;
            int playInWorkDays = 63;
            int playInRestDays = 127;

            //calculations:
            int playInYear = daysForRest * playInRestDays + (365 - daysForRest) * playInWorkDays;

            int difference = Math.Abs(playInYear - limit);

            int hours = difference / 60;
            int minutes = difference % 60;

            if (playInYear > limit)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            
        }
    }
}
