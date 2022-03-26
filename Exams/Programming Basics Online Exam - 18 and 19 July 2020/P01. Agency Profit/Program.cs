using System;

namespace P01._Agency_Profit
{
    class Program
    {
        static void Main()
        {
            //input:
            string nameOfCompany = Console.ReadLine();
            int countOfAdultsTicket = int.Parse(Console.ReadLine());
            int countOfKidsTicket = int.Parse(Console.ReadLine());
            double netPriceAdultTicket = double.Parse(Console.ReadLine());
            double taxPriceForService = double.Parse(Console.ReadLine());

            //calculations:
            double netPriceKidsTicket = 0.3 * netPriceAdultTicket;

            double totalPrice = (netPriceAdultTicket + taxPriceForService) * countOfAdultsTicket + (netPriceKidsTicket + taxPriceForService) * countOfKidsTicket;

            double profit = totalPrice * 0.2;

            //print:
            Console.WriteLine($"The profit of your agency from {nameOfCompany} tickets is {profit:f2} lv.");
        }
    }
}
