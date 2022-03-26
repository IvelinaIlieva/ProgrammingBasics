using System;

namespace T01._Back_To_The_Past
{
    class Program
    {
        static void Main()
        {
            //input data:
            double inheritedMoney = double.Parse(Console.ReadLine());
            int yearsToLive = int.Parse(Console.ReadLine());
            int startYear = 1800;

            for (int i = startYear; i <= yearsToLive; i++)
            {
                int startAge = 18;
                double moneyEvenYear = 12000;

                if (i % 2 == 0)
                {
                    inheritedMoney -= moneyEvenYear;
                }
                else
                {
                    double moneyOddYear = moneyEvenYear + 50 * (startAge + (i - startYear));
                    inheritedMoney -= moneyOddYear;
                }
            }

            //print:
            Console.WriteLine(inheritedMoney >= 0 ? $"Yes! He will live a carefree life and will have {inheritedMoney:f2} dollars left." : $"He will need {Math.Abs(inheritedMoney):f2} dollars to survive.");
        }
    }
}
