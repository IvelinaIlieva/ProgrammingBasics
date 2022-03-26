using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double puzzelPrice = 2.6;
            const double dollPrice = 3;
            const double teddybearPrice = 4.1;
            const double minionPrice = 8.2;
            const double truckPrice = 2;

            //input:

            double tripPrice = double.Parse(Console.ReadLine());
            int puzzelCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int teddybearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            double totalPrice = puzzelCount * puzzelPrice + dollCount * dollPrice + teddybearCount * teddybearPrice + minionCount * minionPrice + truckCount * truckPrice;

            if ((puzzelCount+dollCount+teddybearCount+minionCount+truckCount)>=50)
            {
                totalPrice *= 0.75;
            }

            double rent = 0.1 * totalPrice;
            double finalPrice = totalPrice - rent;
            double defference = Math.Abs(finalPrice - tripPrice);

            //print:
            Console.WriteLine(finalPrice >= tripPrice ? $"Yes! {defference:f2} lv left." : $"Not enough money! {defference:f2} lv needed.");
            
        }
    }
}
