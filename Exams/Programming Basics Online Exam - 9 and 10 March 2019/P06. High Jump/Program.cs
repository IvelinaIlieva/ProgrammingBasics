using System;

namespace P06._High_Jump
{
    class Program
    {
        static void Main()
        {
            int targetHeight = int.Parse(Console.ReadLine());

            int startTestHeight = targetHeight - 30;
            int totalCounter = 0;
            int badCounter = 0;

            while (true)
            {
                int testHeight = int.Parse(Console.ReadLine());
                totalCounter++;

                if (testHeight > startTestHeight)
                {
                    if (startTestHeight >= targetHeight)
                    {
                        Console.WriteLine($"Tihomir succeeded, he jumped over {startTestHeight}cm after {totalCounter} jumps.");
                        break;
                    }
                    startTestHeight += 5;
                    badCounter = 0;
                }
                else
                {
                    badCounter++;
                    if (badCounter == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {startTestHeight}cm after {totalCounter} jumps.");
                        break;
                    }
                }
            }
        }
    }
}
