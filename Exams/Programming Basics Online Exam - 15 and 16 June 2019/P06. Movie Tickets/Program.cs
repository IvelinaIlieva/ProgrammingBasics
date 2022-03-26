using System;

namespace P06._Movie_Tickets
{
    class Program
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            for (char symbol1 = (char)number1; symbol1 <= (char)number2 - 1; symbol1++)
            {
                for (int symbol2 = 1; symbol2 <= number3 - 1; symbol2++)
                {
                    for (int symbol3 = 1; symbol3 <= number3 / 2 - 1; symbol3++)
                    {
                        int symbol4 = symbol1;
                        if (symbol4 % 2 != 0 && (symbol1 + symbol2 + symbol3) % 2 != 0)
                        {
                            Console.WriteLine($"{symbol1}-{symbol2}{symbol3}{symbol4}");
                        }
                    }
                }
            }
        }
    }
}
