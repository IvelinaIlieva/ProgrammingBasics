using System;

namespace P01._Pool_Day
{
    class Program
    {
        static void Main()
        {
            //input:
            int countOfEmployee = int.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            double sunbedPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            //calculations:
            double totalPrice = countOfEmployee * tax + Math.Ceiling(countOfEmployee * 0.75) * sunbedPrice + Math.Ceiling(countOfEmployee * 0.5) * umbrellaPrice;

            //print:
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
