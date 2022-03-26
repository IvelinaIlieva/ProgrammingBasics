using System;

namespace T08._Equal_Pairs
{
    class Program
    {
        static void Main()
        {
            //input data:
            int countOfPairs = int.Parse(Console.ReadLine());

            //add data:
            int maxDiff = int.MinValue;
            int sum = 0;
            int diff = 0;

            //calculations:
            for (int i = 0; i < countOfPairs; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int midSum = num1 + num2;

                if (i == 0)
                {
                    sum = midSum;
                }
                else
                {
                    diff = Math.Abs(sum - midSum);
                    sum = midSum;
                }
                if (diff >= maxDiff)
                {
                    maxDiff = diff;
                }
            }

            //print:
            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
