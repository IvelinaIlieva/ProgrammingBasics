using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
               
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine("{0:F2}", fahrenheit);
        }
    }
}
