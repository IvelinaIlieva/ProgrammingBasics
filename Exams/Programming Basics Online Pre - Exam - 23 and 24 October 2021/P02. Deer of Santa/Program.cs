using System;

namespace P02._Deer_of_Santa
{
    class Program
    {
        static void Main()
        {
            //input:
            int countOfDaysLeft = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double foodPerDayFirstDeer = double.Parse(Console.ReadLine());
            double foodPerDaySecondDeer = double.Parse(Console.ReadLine());
            double foodPerDayThirdDeer = double.Parse(Console.ReadLine());

            //calculations:

            double totalEatedFood = countOfDaysLeft * (foodPerDayFirstDeer + foodPerDaySecondDeer + foodPerDayThirdDeer);

            //print:
            if (totalEatedFood <= foodLeft)
            {
                Console.WriteLine($"{Math.Floor(foodLeft - totalEatedFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalEatedFood - foodLeft)} more kilos of food are needed.");
            }
        }
    }
}
