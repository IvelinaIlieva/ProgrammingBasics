using System;

namespace P14._Password_Generator
{
    class Program
    {
        static void Main()
        {
            int controlNum1 = int.Parse(Console.ReadLine());
            int controlNum2 = int.Parse(Console.ReadLine());

            for (int symbol1 = 1; symbol1 < controlNum1; symbol1++)
            {
                for (int symbol2 = 1; symbol2 < controlNum1; symbol2++)
                {
                    for (char symbol3 = 'a'; symbol3 <= 'a' + controlNum2 - 1; symbol3++)
                    {
                        for (char symbol4 = 'a'; symbol4 <= 'a' + controlNum2 - 1; symbol4++)
                        {
                            for (int symbol5Test = 2; symbol5Test <= controlNum1; symbol5Test++)
                            {
                                if (symbol5Test > symbol1 && symbol5Test > symbol2)
                                {
                                    int symbol5 = symbol5Test;

                                    Console.Write($"{symbol1}{symbol2}{symbol3}{symbol4}{symbol5} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
