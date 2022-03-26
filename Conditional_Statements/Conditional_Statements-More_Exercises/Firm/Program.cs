using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            //input information:
            int neededHours = int.Parse(Console.ReadLine());
            int daysToFinish = int.Parse(Console.ReadLine());
            int workersOutOfTime = int.Parse(Console.ReadLine());

            //additional information:
            double workingDays = 0.9 * daysToFinish;

            //calculations:
            double totalHoursForWorking = Math.Floor(workingDays * 8);
            double totalAdditionalHours = workersOutOfTime * 2 * daysToFinish;
            double totalWorkedHours = totalHoursForWorking + totalAdditionalHours;
            double difference = Math.Floor(Math.Abs(totalWorkedHours - neededHours));

            //print:
            Console.WriteLine(totalWorkedHours >= neededHours? $"Yes!{difference} hours left.": $"Not enough time!{difference} hours needed.");
        }
    }
}
