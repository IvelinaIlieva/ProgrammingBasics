using System;

namespace T07._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfInputNumbers = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < countOfInputNumbers; i++)
            {
                int numbersToSum = int.Parse(Console.ReadLine());
                sum += numbersToSum;
            }
            Console.WriteLine(sum);
        }
    }
}
