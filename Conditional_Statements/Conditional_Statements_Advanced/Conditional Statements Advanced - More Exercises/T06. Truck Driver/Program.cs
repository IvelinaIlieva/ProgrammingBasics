using System;

namespace T06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            string season = Console.ReadLine();
            double kmPerMounth = double.Parse(Console.ReadLine());

            //calculations:
            const int MOUNTH_PER_SEASON = 4;
            double salary = MOUNTH_PER_SEASON * kmPerMounth;

            if (kmPerMounth <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        salary *= 0.75;
                        break;
                    case "Summer":
                        salary *= 0.9;
                        break;
                    case "Winter":
                        salary *= 1.05;
                        break;
                }
            }
            else if (kmPerMounth <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        salary *= 0.95;
                        break;
                    case "Summer":
                        salary *= 1.1;
                        break;
                    case "Winter":
                        salary *= 1.25;
                        break;
                }
            }
            else if (kmPerMounth <= 20000)
            {
                salary *= 1.45;
            }

            salary *= 0.9;

            //print:
            Console.WriteLine($"{salary:f2}");
        }
    }
}
