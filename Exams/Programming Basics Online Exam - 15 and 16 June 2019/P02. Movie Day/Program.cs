using System;

namespace P02._Movie_Day
{
    class Program
    {
        static void Main()
        {
            //input:
            int timeForShooting = int.Parse(Console.ReadLine());
            int countOfScenes = int.Parse(Console.ReadLine());
            int timeForScene = int.Parse(Console.ReadLine());

            //calculations:
            double totalShootingTime = timeForShooting * 0.15 + countOfScenes * timeForScene;

            //print:
            Console.WriteLine(totalShootingTime > timeForShooting ? $"Time is up! To complete the movie you need {Math.Round(totalShootingTime - timeForShooting)} minutes." : $"You managed to finish the movie on time! You have {Math.Round(timeForShooting - totalShootingTime)} minutes left!");
        }
    }
}
