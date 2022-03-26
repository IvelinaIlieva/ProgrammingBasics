using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int termDeposit = int.Parse(Console.ReadLine());
            double interestPercent = double.Parse(Console.ReadLine());
            
            double sum = depositSum + termDeposit * ((depositSum * (interestPercent / 100)) / 12);

            Console.WriteLine(sum);
        }
    }
}
