using System;

namespace _01._Christmas_Preparation
{
    class Program
    {
        static void Main()
        {
            const double PAPER_PRICE = 5.8;
            const double CLOTH_PRICE = 7.2;
            const double GLUE_PRICE = 1.2;

            //input:
            int countOfPaperRolls = int.Parse(Console.ReadLine());
            int countOfClothRolls = int.Parse(Console.ReadLine());
            double countOfGlueLitters = double.Parse(Console.ReadLine());
            int discountPersent = int.Parse(Console.ReadLine());

            //calculations:

            double totalSum = countOfPaperRolls * PAPER_PRICE + countOfClothRolls * CLOTH_PRICE + countOfGlueLitters * GLUE_PRICE;
            double finalSum = totalSum * (100 - discountPersent) / 100;

            //print:
            Console.WriteLine($"{finalSum:f3}");
        }
    }
}
