using System;

namespace WeatherForecast_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            if (26.00 <= degrees && degrees <= 35.00)
                Console.WriteLine("Hot");
            else if (20.1 <= degrees && degrees <= 25.9)
                Console.WriteLine("Warm");
            else if (15.00 <= degrees && degrees <= 20.00)
                Console.WriteLine("Mild");
            else if (12.00 <= degrees && degrees <= 14.9)
                Console.WriteLine("Cool");
            else if (5.00 <= degrees && degrees <= 11.9)
                Console.WriteLine("Cold");
            else
                Console.WriteLine("unknown");
            Console.ReadLine();
        }
    }
}
