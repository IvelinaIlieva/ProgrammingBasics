using System;

namespace P13._Prime_Pairs
{
    class Program
    {
        static void Main()
        {
            int startFirstCouple = int.Parse(Console.ReadLine());
            int startSecondCouple = int.Parse(Console.ReadLine());
            int diffFirstCouple = int.Parse(Console.ReadLine());
            int diffSecondCouple = int.Parse(Console.ReadLine());

            int endFirstCouple = startFirstCouple + diffFirstCouple;
            int endSecondCouple = startSecondCouple + diffSecondCouple;

            int counterFirstCouple = 0;
            int counterSecondCouple = 0;

            for (int firstCoupleTest = startFirstCouple; firstCoupleTest <= endFirstCouple; firstCoupleTest++)
            {
                for (int i = 1; i <= firstCoupleTest; i++)
                {
                    if (firstCoupleTest % i == 0)
                    {
                        counterFirstCouple++;
                    }
                }
                if (counterFirstCouple > 2)
                {
                    counterFirstCouple = 0;
                    continue;
                }
                else if (counterFirstCouple == 2)
                {
                    counterFirstCouple = 0;
                    int firstCouple = firstCoupleTest;

                    for (int secondCoupleTest = startSecondCouple; secondCoupleTest <= endSecondCouple; secondCoupleTest++)
                    {
                        for (int j = 1; j <= secondCoupleTest; j++)
                        {
                            if (secondCoupleTest % j == 0)
                            {
                                counterSecondCouple++;
                            }
                        }
                        if (counterSecondCouple > 2)
                        {
                            counterSecondCouple = 0;
                            continue;
                        }
                        else if (counterSecondCouple == 2)
                        {
                            counterSecondCouple = 0;
                            int secondCouple = secondCoupleTest;

                            Console.WriteLine($"{firstCouple}{secondCouple}");
                        }
                    }
                }
            }
        }
    }
}
