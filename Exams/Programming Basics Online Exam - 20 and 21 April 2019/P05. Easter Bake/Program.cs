using System;

namespace P05._Easter_Bake
{
    class Program
    {
        static void Main()
        {
            const double SUGAR_PACKAGE_WEIGHT = 950;
            const double FLOUR_PACKAGE_WEIGHT = 750;

            int countOfEasterBreads = int.Parse(Console.ReadLine());

            int totalSugarQuantity = 0;
            int totalFlourQuantity = 0;
            int maxSugarQuantity = int.MinValue;
            int maxFlourQuantity = int.MinValue;

            for (int i = 1; i <= countOfEasterBreads; i++)
            {
                int sugarQuantity = int.Parse(Console.ReadLine());
                if (sugarQuantity >= maxSugarQuantity)
                {
                    maxSugarQuantity = sugarQuantity;
                }

                int flourQuantity = int.Parse(Console.ReadLine());
                if (flourQuantity >= maxFlourQuantity)
                {
                    maxFlourQuantity = flourQuantity;
                }

                totalFlourQuantity += flourQuantity;
                totalSugarQuantity += sugarQuantity;
            }
            double sugarPackage = Math.Ceiling(totalSugarQuantity / SUGAR_PACKAGE_WEIGHT);
            double flourPackage = Math.Ceiling(totalFlourQuantity / FLOUR_PACKAGE_WEIGHT);

            Console.WriteLine($"Sugar: {sugarPackage}");
            Console.WriteLine($"Flour: {flourPackage}");
            Console.WriteLine($"Max used flour is {maxFlourQuantity} grams, max used sugar is {maxSugarQuantity} grams.");
        }
    }
}
