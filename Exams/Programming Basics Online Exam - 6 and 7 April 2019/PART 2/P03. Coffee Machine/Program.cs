using System;

namespace P03._Coffee_Machine
{
    class Program
    {
        static void Main()
        {
            //input:
            string kindOfDrink = Console.ReadLine();
            string sugarQuantity = Console.ReadLine();
            int countOfDrinks = int.Parse(Console.ReadLine());

            //calculations:
            double priceOfDrink = 0;
            double totalMoney = 0;

            switch (kindOfDrink)
            {
                case "Espresso":
                    switch (sugarQuantity)
                    {
                        case "Without":
                            priceOfDrink = 0.9;
                            totalMoney = priceOfDrink * countOfDrinks *0.65;
                            break;
                        case "Normal":
                            priceOfDrink = 1;
                            totalMoney = priceOfDrink * countOfDrinks;
                            break;
                        case "Extra":
                            priceOfDrink = 1.2;
                            totalMoney = priceOfDrink * countOfDrinks;
                            break;
                    }
                    if (countOfDrinks >= 5)
                    {
                        totalMoney *= 0.75;
                    }
                    break;
                case "Cappuccino":
                    switch (sugarQuantity)
                    {
                        case "Without":
                            priceOfDrink = 1;
                            totalMoney = priceOfDrink * countOfDrinks * 0.65;
                            break;
                        case "Normal":
                            priceOfDrink = 1.2;
                            totalMoney = priceOfDrink * countOfDrinks;
                            break;
                        case "Extra":
                            priceOfDrink = 1.6;
                            totalMoney = priceOfDrink * countOfDrinks;
                            break;
                    }
                    break;
                case "Tea":
                    switch (sugarQuantity)
                    {
                        case "Without":
                            priceOfDrink = 0.5;
                            totalMoney = priceOfDrink * countOfDrinks * 0.65;
                            break;
                        case "Normal":
                            priceOfDrink = 0.6;
                            totalMoney = priceOfDrink * countOfDrinks;
                            break;
                        case "Extra":
                            priceOfDrink = 0.7;
                            totalMoney = priceOfDrink * countOfDrinks;
                            break;
                    }
                    break;
            }
            if (totalMoney > 15)
            {
                totalMoney *= 0.8;
            }

            //print:
            Console.WriteLine($"You bought {countOfDrinks} cups of {kindOfDrink} for {totalMoney:f2} lv.");
        }
    }
}
