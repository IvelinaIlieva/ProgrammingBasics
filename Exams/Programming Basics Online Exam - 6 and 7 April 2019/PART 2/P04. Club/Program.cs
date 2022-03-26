using System;

namespace P04._Club
{
    class Program
    {
        static void Main()
        {
            double profit = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            double totalIncome = 0;

            while (input != "Party!")
            {
                //if (input == "Party!")
                //{
                //    break;
                //}
                string nameOfCocktail = input;
                int countOfCocktails = int.Parse(Console.ReadLine());

                int cocktailPrice = nameOfCocktail.Length;

                double moneyForCocktail = cocktailPrice * countOfCocktails;

                if (moneyForCocktail % 2 != 0)
                {
                    moneyForCocktail *= 0.75;
                }

                totalIncome += moneyForCocktail;

                if (totalIncome >= profit)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }

                input = Console.ReadLine();
            }
            if (input == "Party!")
            {
                Console.WriteLine($"We need {profit - totalIncome:f2} leva more.");
            }
            Console.WriteLine($"Club income - {totalIncome:f2} leva.");
        }
    }
}
