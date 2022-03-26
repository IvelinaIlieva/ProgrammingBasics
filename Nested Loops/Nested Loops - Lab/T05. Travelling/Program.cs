using System;

namespace T05._Travelling
{
    class Program
    {
        static void Main()
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double savedMoney = 0;
                double savedSum = 0;

                while (savedSum < budget)
                {
                    savedMoney = double.Parse(Console.ReadLine());
                    savedSum += savedMoney;
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
