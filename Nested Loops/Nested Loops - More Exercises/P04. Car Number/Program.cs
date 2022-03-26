using System;

namespace P04._Car_Number
{
    class Program
    {
        static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int finishNumber = int.Parse(Console.ReadLine());

            for (int i = startNumber; i <= finishNumber; i++)
            {
                for (int j = startNumber; j <= finishNumber; j++)
                {
                    for (int k = startNumber; k <= finishNumber; k++)
                    {
                        for (int l = startNumber; l <= finishNumber; l++)
                        {
                            if ((i % 2 == 0 && l % 2 != 0 || i % 2 != 0 && l % 2 == 0) && i > l && (j + k) % 2 == 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
