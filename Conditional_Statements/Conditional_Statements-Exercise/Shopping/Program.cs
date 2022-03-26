using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //prep info:
            const int videocardPrice = 250;

            //input:
            double budget = double.Parse(Console.ReadLine());
            int videocardCount = int.Parse(Console.ReadLine());
            int processorCount = int.Parse(Console.ReadLine());
            int ramMemoryCount = int.Parse(Console.ReadLine());

            double processorPrice = videocardCount * videocardPrice * 0.35;
            double ramMemoryPrice = videocardCount * videocardPrice * 0.10;

            double totalPrice = videocardCount * videocardPrice + processorCount * processorPrice + ramMemoryCount * ramMemoryPrice;

            if (videocardCount>processorCount)
            {
                totalPrice *= 0.85;
            }

            double defference = Math.Abs(budget - totalPrice);

            //print:
            Console.WriteLine(budget>=totalPrice? $"You have {defference:f2} leva left!":$"Not enough money! You need {defference:f2} leva more!");

        }
    }
}
