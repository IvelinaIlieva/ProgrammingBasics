using System;

namespace P02._Skeleton
{
    class Program
    {
        static void Main()
        {
            //input:
            int controlMinutes = int.Parse(Console.ReadLine());
            int controlSeconds = int.Parse(Console.ReadLine());
            double spoutLenghtMeters = double.Parse(Console.ReadLine());
            int secondsPer100Meters = int.Parse(Console.ReadLine());

            //calculations:
            int totalControlSeconds = controlMinutes * 60 + controlSeconds;

            double totalTime = spoutLenghtMeters / 100 * secondsPer100Meters - spoutLenghtMeters / 120 * 2.5;

            //print:
            if (totalControlSeconds >= totalTime)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {totalTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {totalTime - totalControlSeconds:f3} second slower.");
            }
        }
    }
}
