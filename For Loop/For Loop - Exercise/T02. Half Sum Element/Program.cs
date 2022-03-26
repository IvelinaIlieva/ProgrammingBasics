using System;

namespace T02._Half_Sum_Element
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                int numForCheck = int.Parse(Console.ReadLine());
                sum += numForCheck;

                if (numForCheck>maxNum)
                {
                    maxNum = numForCheck;
                }
            }
            sum -= maxNum;
            if (sum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                int diff = Math.Abs(sum - maxNum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
