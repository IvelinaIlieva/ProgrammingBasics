using System;

namespace T03._Vacation
{
    class Program
    {
        static void Main()
        {
            double neededMoneyForVacation = double.Parse(Console.ReadLine());
            double startMoney = double.Parse(Console.ReadLine());

            double sum = startMoney;
            int spendCounter = 0;
            int days = 0;

            while (neededMoneyForVacation > sum)
            {
                string action = Console.ReadLine();
                days++;

                double incomeSum = double.Parse(Console.ReadLine());

                if (neededMoneyForVacation <= sum)
                {
                    break;
                }

                if (action == "save")
                {
                    sum += incomeSum;
                    spendCounter = 0;
                }
                else if (action == "spend")
                {
                    spendCounter++;

                    if (incomeSum >= sum)
                    {
                        sum = 0;
                    }
                    else if (incomeSum<sum)
                    {
                        sum -= incomeSum;
                    }

                    if (spendCounter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }
                }
            }
            if (neededMoneyForVacation <= sum)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
