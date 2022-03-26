using System;

namespace P03._Mobile_operator
{
    class Program
    {
        static void Main()
        {
            //input:
            string contractTerm = Console.ReadLine();//"one", или "two"
            string contractType = Console.ReadLine();//"Small",  "Middle", "Large" или "ExtraLarge"
            string internetAdd = Console.ReadLine();//"yes" или "no"
            int countOfMonthForPay = int.Parse(Console.ReadLine());

            //calculations:
            double pricePerMonth = 0;
            switch (contractTerm)
            {
                case "one":
                    switch (contractType)
                    {
                        case "Small":
                            pricePerMonth = 9.98;
                            break;
                        case "Middle":
                            pricePerMonth = 18.99;
                            break;
                        case "Large":
                            pricePerMonth = 25.98;
                            break;
                        case "ExtraLarge":
                            pricePerMonth = 35.99;
                            break;
                    }
                    break;
                case "two":
                    switch (contractType)
                    {
                        case "Small":
                            pricePerMonth = 8.58;
                            break;
                        case "Middle":
                            pricePerMonth = 17.09;
                            break;
                        case "Large":
                            pricePerMonth = 23.59;
                            break;
                        case "ExtraLarge":
                            pricePerMonth = 31.79;
                            break;
                    }
                    break;
            }

            if (internetAdd == "yes")
            {
                if (pricePerMonth > 30)
                {
                    pricePerMonth += 3.85;
                }
                else if (pricePerMonth>10)
                {
                    pricePerMonth += 4.35;
                }
                else
                {
                    pricePerMonth += 5.5;
                }
            }

            double totalPrice = pricePerMonth * countOfMonthForPay;

            if (contractTerm == "two")
            {
                totalPrice *= 0.9625;
            }

            //print:
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
