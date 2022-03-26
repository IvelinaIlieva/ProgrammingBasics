using System;

namespace T11._Odd_or_Even_Position
{
    class Program
    {
        static void Main()
        {
            //input data:
            int countOfNum = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            //calculations:
            for (int i = 1; i <= countOfNum; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += currentNum;

                    if (currentNum > evenMax)
                    {
                        evenMax = currentNum;
                    }
                    if (currentNum < evenMin)
                    {
                        evenMin = currentNum;
                    }
                }
                else
                {
                    oddSum += currentNum;

                    if (currentNum > oddMax)
                    {
                        oddMax = currentNum;
                    }
                    if (currentNum < oddMin)
                    {
                        oddMin = currentNum;
                    }
                }
            }
            //print:
            Console.WriteLine($"OddSum={oddSum:f2},");
            Console.WriteLine(oddMin != double.MaxValue ? $"OddMin={oddMin:f2}," : "OddMin=No,");
            Console.WriteLine(oddMax != double.MinValue ? $"OddMax={oddMax:f2}," : "OddMax=No,");
            Console.WriteLine($"EvenSum={evenSum:f2},");
            Console.WriteLine(evenMin != double.MaxValue ? $"EvenMin={evenMin:f2}," : "EvenMin=No,");
            Console.WriteLine(evenMax != double.MinValue ? $"EvenMax={evenMax:f2}" : "EvenMax=No");
        }
    }
}
