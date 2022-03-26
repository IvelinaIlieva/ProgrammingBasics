using System;

namespace T04._Clever_Lily
{
    class Program
    {
        static void Main()
        {
            //input data:
            int ageOfLily = int.Parse(Console.ReadLine());
            double priceOfWashingMachine = double.Parse(Console.ReadLine());
            int priceOfToy = int.Parse(Console.ReadLine());

            int toys = 0;
            double money = 0;

            for (int i = 1; i <= ageOfLily; i++)
            {
                if (i % 2 == 1)
                {
                    toys++;
                }
                else if (i % 2 == 0)
                {
                    money += i * 5 - 1;
                }
            }
            double totalPriceForToys = priceOfToy * toys;
            double totalMoney = totalPriceForToys + money;
            double diff = Math.Abs(totalMoney - priceOfWashingMachine);

            //print:
            Console.WriteLine(totalMoney>=priceOfWashingMachine? $"Yes! {diff:f2}" : $"No! {diff:f2}");
        }
    }
}
