using System;

namespace T09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < countOfNumbers; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sumLeft += numbers;
            }
            for (int i = countOfNumbers; i < (2 * countOfNumbers); i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sumRight += numbers;
            }
            if (sumLeft == sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumLeft-sumRight)}");
            }
        }
    }
}
