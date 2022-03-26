using System;

namespace T05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            //add data:
            string destination;
            double spentMoney = 0;
            string kindOfHoliday;

            if (budget<=100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        spentMoney = 0.3 * budget;
                        break;
                    case "winter":
                        spentMoney = 0.7 * budget;
                        break;
                }
            }
            else if (budget <=1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        spentMoney = 0.4 * budget;
                        break;
                    case "winter":
                        spentMoney = 0.8 * budget;
                        break;
                }
            }
            else
            {
                destination = "Europe";
                spentMoney = 0.9 * budget;
            }
            if ((season == "summer") && (destination != "Europe"))
            {
                kindOfHoliday = "Camp";
            }
            else
            {
                kindOfHoliday = "Hotel";
            }

            //print:
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{kindOfHoliday} - {spentMoney:f2}");
        }
    }
}
