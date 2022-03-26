using System;

namespace T03._Sum_Numbers
{
    class Program
    {
        static void Main()
        {
            int primaryNum = int.Parse(Console.ReadLine());

            int numToSum = int.Parse(Console.ReadLine());
            int sum = numToSum;

            while (primaryNum > sum)
            {
                numToSum = int.Parse(Console.ReadLine());
                sum += numToSum;                
            }
            Console.WriteLine(sum);
        }
    }
}
