using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPricePerKg = double.Parse(Console.ReadLine());
            double spratPricePerKg = double.Parse(Console.ReadLine());
            double kgBonito = double.Parse(Console.ReadLine());
            double kgHorseMackerel = double.Parse(Console.ReadLine());
            int kgShell = int.Parse(Console.ReadLine());

            double bonitoPricePerKg = 1.6 * mackerelPricePerKg;
            double horseMackerelPricePerKg = 1.8 * spratPricePerKg;
            double shellPricePerKg = 7.5;

            double finalPrice = bonitoPricePerKg * kgBonito + horseMackerelPricePerKg * kgHorseMackerel + shellPricePerKg * kgShell;

            Console.WriteLine("{0:F2}", finalPrice);
        }
    }
}
