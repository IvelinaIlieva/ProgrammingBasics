using System;

namespace P01._Unique_PIN_Codes
{
    class Program
    {
        static void Main()
        {
            int heightFirstNum = int.Parse(Console.ReadLine());
            int heightSecondNum = int.Parse(Console.ReadLine());
            int heightThirdNum = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1; i <= heightFirstNum; i++)
            {
                if (i % 2 == 0)
                {
                    int number1 = i;

                    for (int j = 2; j <= heightSecondNum; j++)
                    {
                        for (int k = 1; k <= j; k++)
                        {
                            if (j % k == 0)
                            {
                                counter++;
                            }
                        }
                        if (counter > 2)
                        {
                            counter = 0;
                            continue;
                        }
                        else if (counter == 2)
                        {
                            int number2 = j;
                            counter = 0;

                            for (int l = 1; l <= heightThirdNum; l++)
                            {
                                if (l % 2 == 0)
                                {
                                    int number3 = l;

                                    Console.Write($"{number1} {number2} {number3}");
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
