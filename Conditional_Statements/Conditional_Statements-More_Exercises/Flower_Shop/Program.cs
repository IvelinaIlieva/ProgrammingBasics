using System;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //input information:
            int magnoliasCount = int.Parse(Console.ReadLine());
            int hyacinthsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int cactusesCount = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            //additional information:
            double magnoliasPrice = 3.25;
            double hyacinthsPrice = 4;
            double rosesPrice = 3.50;
            double cactusesPrice = 8;
            //от общата сума, Мария трябва да плати 5% данъци.

            //calculations:
            double totalSumFromSelling = magnoliasPrice * magnoliasCount + hyacinthsPrice * hyacinthsCount + rosesPrice * rosesCount + cactusesPrice * cactusesCount;
            totalSumFromSelling *= 0.95;

            //print:
            Console.WriteLine(totalSumFromSelling>=giftPrice
                ?$"She is left with {Math.Floor(totalSumFromSelling-giftPrice)} leva."
                :$"She will have to borrow {Math.Ceiling(giftPrice-totalSumFromSelling)} leva.");

        }
    }
}
