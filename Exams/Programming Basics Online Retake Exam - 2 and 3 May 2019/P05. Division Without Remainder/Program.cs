using System;

namespace P05._Division_Without_Remainder
{
    class Program
    {
        static void Main()
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int countDivideBy2 = 0;
            int countDivideBy3 = 0;
            int countDivideBy4 = 0;

            for (int i = 1; i <= countOfNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    countDivideBy2++;
                }
                if (number % 3 == 0)
                {
                    countDivideBy3++;
                }
                if (number % 4 == 0)
                {
                    countDivideBy4++;
                }
            }

            Console.WriteLine($"{(double)countDivideBy2 / countOfNumbers * 100:f2}%");
            Console.WriteLine($"{(double)countDivideBy3 / countOfNumbers * 100:f2}%");
            Console.WriteLine($"{(double)countDivideBy4 / countOfNumbers * 100:f2}%");
        }
    }
}
