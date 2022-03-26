using System;

namespace Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            //input:
            string seriesName = Console.ReadLine();
            int seriesTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            //additional info:
            double lunchTime = breakTime / 8.0;
            double restTime = breakTime / 4.0;

            //calculations:
            double freeTime = breakTime - (restTime + lunchTime);
            double defference = Math.Abs(freeTime - seriesTime);

            //print:
            Console.WriteLine(freeTime>=seriesTime? $"You have enough time to watch {seriesName} and left with {Math.Ceiling(defference)} minutes free time.": $"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(defference)} more minutes.");

        }
    }
}
