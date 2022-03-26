using System;

namespace BasketballEquipment
    {
    class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());
            double shoes = yearTax - 0.4 * yearTax;
            double equip = shoes - 0.2 * shoes;
            double ball = 0.25 * equip;
            double accesories = 0.2 * ball;
            double price = yearTax + shoes + equip + ball + accesories;
            Console.WriteLine(price);
        }
    }
}
