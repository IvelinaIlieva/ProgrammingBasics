using System;

namespace T08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            for (int i = 0; i < countOfNumbers; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers > maxNumber)
                {
                    maxNumber = numbers;
                }
                if (numbers < minNumber)
                {
                    minNumber = numbers;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
