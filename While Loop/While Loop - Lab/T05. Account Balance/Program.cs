using System;

namespace T05._Account_Balance
{
    class Program
    {
        static void Main()
        {
            string inputMoney = Console.ReadLine();

            double sum = 0;

            while (inputMoney != "NoMoreMoney")
            {
                double inputConvertedMoney = double.Parse(inputMoney);

                if (inputConvertedMoney <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {inputConvertedMoney:f2}");
                sum += inputConvertedMoney;
                inputMoney = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
