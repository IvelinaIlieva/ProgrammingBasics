using System;

namespace T02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                int number = i; 
                int units = number % 10; 
                int currentNum = number / 10;
                int decimals = currentNum % 10;
                currentNum /= 10;
                int hundreds = currentNum % 10;
                currentNum /= 10;
                int thousands = currentNum % 10;
                currentNum /= 10;
                int tenthousands = currentNum % 10;
                currentNum /= 10;
                int hundredthousands = currentNum % 10;

                int sumOfOddDigit = units + hundreds + tenthousands;
                int sumOfEvenDigit = decimals + thousands + hundredthousands;

                if (sumOfEvenDigit == sumOfOddDigit)
                {
                    Console.Write($"{number} ");
                }
                sumOfOddDigit = 0;
                sumOfEvenDigit = 0;
            }
        }
    }
}
