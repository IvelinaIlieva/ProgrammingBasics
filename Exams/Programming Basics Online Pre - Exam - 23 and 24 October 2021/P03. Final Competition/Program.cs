using System;

namespace P03._Final_Competition
{
    class Program
    {
        static void Main()
        {
            //input:
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); 
            string place = Console.ReadLine(); 

            //calculations:
            double prise = 0;

            switch (place)
            {
                case "Bulgaria":
                    prise = dancers * points;
                    break;
                case "Abroad":
                    prise = 1.5 * dancers * points;
                    break;
            }

            if (place == "Bulgaria" && season == "summer")
            {
                prise *= 0.95;
            }
            else if (place == "Bulgaria" && season == "winter")
            {
                prise *= 0.92;
            }
            else if (place == "Abroad" && season == "summer")
            {
                prise *= 0.9;
            }
            else
            {
                prise *= 0.85;
            }

            double charity = prise * 0.75;
            prise -= charity;

            double prisePerDancer = prise / dancers;

            //print:
            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {prisePerDancer:f2}");
        }
    }
}
