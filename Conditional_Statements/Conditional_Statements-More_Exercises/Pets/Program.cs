using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            //input information:
            int days = int.Parse(Console.ReadLine());
            int totalFoodKg = int.Parse(Console.ReadLine());
            double dogFoodKg = double.Parse(Console.ReadLine());
            double catFoodKg = double.Parse(Console.ReadLine());
            double turtleFoodG = double.Parse(Console.ReadLine());

            //calculations:
            double eatFood = days * (dogFoodKg + catFoodKg + turtleFoodG / 1000);

            //print:
            Console.WriteLine(totalFoodKg>=eatFood? $"{Math.Floor(totalFoodKg-eatFood)} kilos of food left." : $"{Math.Ceiling(eatFood-totalFoodKg)} more kilos of food are needed.");
            
        }
    }
}
