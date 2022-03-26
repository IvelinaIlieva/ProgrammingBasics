using System;

namespace P01._Series_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //input:
            string nameOfSeries = Console.ReadLine();
            int countOfSeasons = int.Parse(Console.ReadLine());
            int countOfEpisodes = int.Parse(Console.ReadLine());
            double timeOfEpisode = double.Parse(Console.ReadLine());

            //calculations:
            double totalTime = timeOfEpisode * 1.2 * countOfEpisodes * countOfSeasons + countOfSeasons * 10;

            //print:
            Console.WriteLine($"Total time needed to watch the {nameOfSeries} series is {Math.Floor(totalTime)} minutes.");
        }
    }
}
