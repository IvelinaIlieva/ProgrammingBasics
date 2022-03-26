using System;

namespace P05._Series
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfSeries = int.Parse(Console.ReadLine());
            double totalSum = 0;

            for (int i = 0; i < countOfSeries; i++)
            {
                string nameOfSeries = Console.ReadLine();
                double priceOfSeries = double.Parse(Console.ReadLine());

                switch (nameOfSeries)
                {
                    case "Thrones":
                        priceOfSeries *= 0.5;
                        break;
                    case "Lucifer":
                        priceOfSeries *= 0.6;
                        break;
                    case "Protector":
                        priceOfSeries *= 0.7;
                        break;
                    case "TotalDrama":
                        priceOfSeries *= 0.8;
                        break;
                    case "Area":
                        priceOfSeries *= 0.9;
                        break;
                }
                totalSum += priceOfSeries;
            }
            Console.WriteLine(budget >= totalSum ? $"You bought all the series and left with {budget - totalSum:f2} lv." : $"You need {totalSum - budget:f2} lv. more to buy the series!");
        }
    }
}
