using System;

namespace T03._Histogram
{
    class Program
    {
        static void Main()
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 0; i < countOfNumbers; i++)
            {
                int inputNumbers = int.Parse(Console.ReadLine());

                if (inputNumbers < 200)
                {
                    p1++;
                }
                else if (inputNumbers < 400)
                {
                    p2++;
                }
                else if (inputNumbers < 600)
                {
                    p3++;
                }
                else if (inputNumbers < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            int totalCountOfNumbers = p1 + p2 + p3 + p4 + p5;
            double percentageP1 = 1.0 * p1 / totalCountOfNumbers * 100;
            double percentageP2 = 1.0 * p2 / totalCountOfNumbers * 100;
            double percentageP3 = 1.0 * p3 / totalCountOfNumbers * 100;
            double percentageP4 = 1.0 * p4 / totalCountOfNumbers * 100;
            double percentageP5 = 1.0 * p5 / totalCountOfNumbers * 100;
            Console.WriteLine($"{percentageP1:f2}%");
            Console.WriteLine($"{percentageP2:f2}%");
            Console.WriteLine($"{percentageP3:f2}%");
            Console.WriteLine($"{percentageP4:f2}%");
            Console.WriteLine($"{percentageP5:f2}%");
        }
    }
}
