using System;

namespace P02._Safari
{
    class Program
    {
        static void Main()
        {
            //const:
            const double GASOLINE_PRICE_PER_LITTER = 2.1;
            const int PRICE_FOR_GUIDE = 100;

            //input:
            double budget = double.Parse(Console.ReadLine());
            double gasolineQuantity = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            //calculations:
            double totalPrice = PRICE_FOR_GUIDE + GASOLINE_PRICE_PER_LITTER * gasolineQuantity;
            switch (dayOfWeek)
            {
                case "Saturday":
                    totalPrice *= 0.9;
                    break;
                case "Sunday":
                    totalPrice *= 0.8;
                    break;
            }
            double diff = Math.Abs(totalPrice - budget);

            //print:
            Console.WriteLine(totalPrice <= budget ? $"Safari time! Money left: {diff:f2} lv. " : $"Not enough money! Money needed: {diff:f2} lv.");
        }
    }
}
