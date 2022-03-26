using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countChickenMenu = int.Parse(Console.ReadLine());
            int countFishMenu = int.Parse(Console.ReadLine());
            int countVegieMenu = int.Parse(Console.ReadLine());

            double price = countChickenMenu * 10.35 + countFishMenu * 12.40 + countVegieMenu * 8.15;
            double dessert = price * 0.2;
            double totalPrice = price+dessert+2.50;

            Console.WriteLine(totalPrice);
        }
    }
}
