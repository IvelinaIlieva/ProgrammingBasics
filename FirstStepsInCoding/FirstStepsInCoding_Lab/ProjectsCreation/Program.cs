using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameArchitect = Console.ReadLine();
            int countProjects = int.Parse(Console.ReadLine());
            int timeForCreateProjects = countProjects * 3;
                       
               
            Console.WriteLine($"The architect {nameArchitect} will need {timeForCreateProjects} hours to complete {countProjects} project/s.");
        }
    }
}
