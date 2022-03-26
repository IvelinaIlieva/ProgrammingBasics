using System;

namespace P03._Movie_Destination
{
    class Program
    {
        static void Main()
        {
            //input:
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();//"Dubai", "Sofia" и "London"
            string season = Console.ReadLine();//"Summer" и "Winter"
            int countOfDays = int.Parse(Console.ReadLine());

            //calculations:
            double totalSum = countOfDays;
            switch (destination)
            {
                case "Dubai":
                    switch (season)
                    {
                        case "Summer":
                            totalSum *= 40000;
                            break;
                        case "Winter":
                            totalSum *= 45000;
                            break;
                    }
                    totalSum *= 0.7;
                    break;
                case "Sofia":
                    switch (season)
                    {
                        case "Summer":
                            totalSum *= 12500;
                            break;
                        case "Winter":
                            totalSum *= 17000;
                            break;
                    }
                    totalSum *= 1.25;
                    break;
                case "London":
                    switch (season)
                    {
                        case "Summer":
                            totalSum *= 20250;
                            break;
                        case "Winter":
                            totalSum *= 24000;
                            break;
                    }
                    break;
            }
            double diff = Math.Abs(budget - totalSum);

            //print:
            Console.WriteLine(budget >= totalSum ? $"The budget for the movie is enough! We have {diff:f2} leva left!" : $"The director needs {diff:f2} leva more!"); 
        }
    }
}
