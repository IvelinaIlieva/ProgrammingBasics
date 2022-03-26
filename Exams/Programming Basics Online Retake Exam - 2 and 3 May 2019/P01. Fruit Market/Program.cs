using System;

namespace P01._Fruit_Market
{
    class Program
    {
        static void Main()
        {
            //input:
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananaQuantity = double.Parse(Console.ReadLine());
            double orangeQuantity = double.Parse(Console.ReadLine());
            double raspberryQuantity = double.Parse(Console.ReadLine());
            double strawberryQuantity = double.Parse(Console.ReadLine());

            //calculations:
            double raspberryPrice = strawberryPrice / 2;
            double orangePrice = raspberryPrice * 0.6;
            double bananaPrice = raspberryPrice * 0.2;

            double totalPrice = strawberryPrice * strawberryQuantity + bananaPrice * bananaQuantity + orangePrice * orangeQuantity + raspberryPrice * raspberryQuantity;

            //print:
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
