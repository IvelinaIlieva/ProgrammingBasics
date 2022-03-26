using System;

namespace P03._Gymnastics
{
    class Program
    {
        static void Main()
        {
            //input:
            string country = Console.ReadLine();
            string instrument = Console.ReadLine();

            //calculations:
            double totalPoints = 0;

            switch (country)
            {
                case "Russia":
                    switch (instrument)
                    {
                        case "ribbon":
                            totalPoints = 9.1 + 9.4;
                            break;
                        case "hoop":
                            totalPoints = 9.3 + 9.8;
                            break;
                        case "rope":
                            totalPoints = 9.6 + 9;
                            break;
                    }
                    break;
                case "Bulgaria":
                    switch (instrument)
                    {
                        case "ribbon":
                            totalPoints = 9.6 + 9.4;
                            break;
                        case "hoop":
                            totalPoints = 9.55 + 9.75;
                            break;
                        case "rope":
                            totalPoints = 9.5 + 9.4;
                            break;
                    }
                    break;
                case "Italy":
                    switch (instrument)
                    {
                        case "ribbon":
                            totalPoints = 9.2 + 9.5;
                            break;
                        case "hoop":
                            totalPoints = 9.45 + 9.35;
                            break;
                        case "rope":
                            totalPoints = 9.7 + 9.15;
                            break;
                    }
                    break;
            }

            //print:
            Console.WriteLine($"The team of {country} get {totalPoints:f3} on {instrument}.");
            Console.WriteLine($"{((20-totalPoints)/20*100):f2}%");
        }
    }
}
