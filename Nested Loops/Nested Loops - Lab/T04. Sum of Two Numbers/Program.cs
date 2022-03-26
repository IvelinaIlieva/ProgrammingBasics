using System;

namespace T04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int num1 = startNum; num1 <= endNum; num1++)
            {
                for (int num2 = startNum; num2 <= endNum; num2++)
                {
                    counter++;
                    int sum = num1 + num2;
                    
                    if (sum == magicNum)
                    {                        
                        Console.WriteLine($"Combination N:{counter} ({num1} + {num2} = {magicNum})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
        }
    }
}
