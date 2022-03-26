using System;

namespace T02._Report_System
{
    class Program
    {
        static void Main()
        {
            int sumToCollect = int.Parse(Console.ReadLine());

            string input = "";
            int counter = 0;
            int sumCash = 0;
            int cashCounter = 0;
            int sumCard = 0;
            int cardCounter = 0;
            int totalSum = 0;

            while (input != "End")
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;
                }

                counter++;
                int itemPrice = int.Parse(input);

                if (counter % 2 == 0)
                {
                    if(itemPrice >= 10)
                    {
                        sumCard += itemPrice;
                        cardCounter++;
                        totalSum += itemPrice;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                else
                {
                    if (itemPrice <= 100)
                    {
                        sumCash += itemPrice;
                        cashCounter++;
                        totalSum += itemPrice;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                                
                if (totalSum >= sumToCollect)
                {
                    Console.WriteLine($"Average CS: {((double)sumCash/cashCounter):f2}");
                    Console.WriteLine($"Average CC: {((double)sumCard /cardCounter):f2}");
                    break;
                }
            }
        }
    }
}
