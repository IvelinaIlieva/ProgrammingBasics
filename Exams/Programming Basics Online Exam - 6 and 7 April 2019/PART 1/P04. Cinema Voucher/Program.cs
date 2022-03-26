using System;

namespace P04._Cinema_Voucher
{
    class Program
    {
        static void Main()
        {
            int voucher = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int countOfTickets = 0;
            int countOfPurchase = 0;
            int spentSum = 0;
            int leftSum = voucher;

            while (input != "End")
            {
                int lenghtInput = input.Length;

                if (lenghtInput > 8)
                {
                    spentSum = input[0] + input[1];
                    leftSum -= spentSum;
                    if (leftSum < 0)
                    {
                        break;
                    }
                    countOfTickets++;
                }
                else
                {
                    spentSum = input[0];
                    leftSum -= spentSum;
                    if (leftSum < 0)
                    {
                        break;
                    }
                    countOfPurchase++;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(countOfTickets);
            Console.WriteLine(countOfPurchase);
        }
    }
}
