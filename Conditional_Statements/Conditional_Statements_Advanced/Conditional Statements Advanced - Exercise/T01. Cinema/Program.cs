using System;

namespace T01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            //add data:
            const double PREMIERE_PRICE = 12;
            const double NORMAL_PRICE = 7.50;
            const double DISCOUNT_PRICE = 5;

            //calculations:
            double income = 0;
            switch (projection)
            {
                case "Premiere":
                    income = rows * columns * PREMIERE_PRICE;
                    break;
                case "Normal":
                    income = rows * columns * NORMAL_PRICE;
                    break;
                case "Discount":
                    income = rows * columns * DISCOUNT_PRICE;
                    break;
            }
            //print:
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
