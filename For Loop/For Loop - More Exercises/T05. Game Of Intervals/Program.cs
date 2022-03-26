using System;

namespace T05._Game_Of_Intervals
{
    class Program
    {
        static void Main()
        {
            //input data:
            int turns = int.Parse(Console.ReadLine());

            //add data:
            double result = 0;
            int countOfNum09 = 0;
            int countOfNum1019 = 0;
            int countOfNum2029 = 0;
            int countOfNum3039 = 0;
            int countOfNum4050 = 0;
            int countOfNumInvalid = 0;

            //calculations:
            for (int i = 0; i < turns; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers >= 0 && numbers <= 9)
                {
                    result += numbers * 0.2;
                    countOfNum09++;
                }
                else if (numbers >= 10 && numbers <= 19)
                {
                    result += numbers * 0.3;
                    countOfNum1019++;
                }
                else if (numbers >= 20 && numbers <= 29)
                {
                    result += numbers * 0.4;
                    countOfNum2029++;
                }
                else if (numbers >= 30 && numbers <= 39)
                {
                    result += 50;
                    countOfNum3039++;
                }
                else if (numbers >= 40 && numbers <= 50)
                {
                    result += 100;
                    countOfNum4050++;
                }
                else
                {
                    result /= 2;
                    countOfNumInvalid++;
                }
            }
            double percentage09 = (double)countOfNum09 / turns * 100;
            double percentage1019 = (double)countOfNum1019 / turns * 100;
            double percentage2029 = (double)countOfNum2029 / turns * 100;
            double percentage3039 = (double)countOfNum3039 / turns * 100;
            double percentage4050 = (double)countOfNum4050 / turns * 100;
            double percentageInvalid = (double)countOfNumInvalid / turns * 100;

            //print:
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {percentage09:f2}%");
            Console.WriteLine($"From 10 to 19: {percentage1019:f2}%");
            Console.WriteLine($"From 20 to 29: {percentage2029:f2}%");
            Console.WriteLine($"From 30 to 39: {percentage3039:f2}%");
            Console.WriteLine($"From 40 to 50: {percentage4050:f2}%");
            Console.WriteLine($"Invalid numbers: {percentageInvalid:f2}%");
        }
    }
}
