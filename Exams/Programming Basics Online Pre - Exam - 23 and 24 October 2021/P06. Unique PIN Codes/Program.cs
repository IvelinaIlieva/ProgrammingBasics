using System;

namespace P06._Unique_PIN_Codes
{
    class Program
    {
        static void Main()
        {
            int heighFirst = int.Parse(Console.ReadLine());
            int heighSecond = int.Parse(Console.ReadLine());
            int heighThird = int.Parse(Console.ReadLine());

            for (int i = 1; i <= heighFirst; i++)
            {
                if (i % 2 == 0)
                {
                    int num1 = i;

                    for (int j = 2; j <= heighSecond; j++)
                    {
                        int counter = 0;

                        for (int l = 1; l <= j; l++)
                        {
                            if (j % l == 0)
                            {
                                counter++;
                            }
                        }
                        if (counter>2)
                        {
                            counter = 0;
                            continue;
                        }
                        else if (counter == 2)
                        {
                            int num2 = j;

                            for (int k = 1; k <= heighThird; k++)
                            {
                                if (k % 2 == 0)
                                {
                                    int num3 = k;
                                    Console.WriteLine($"{num1} {num2} {num3}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
