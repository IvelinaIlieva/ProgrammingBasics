using System;

namespace T03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int sumOfPrimeNumbers = 0;
            int sumOfNonPrimeNumbers = 0;

            while (input != "stop")
            {
                input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                int currentNumber = int.Parse(input);
                int counter = 0;

                if (currentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                for (int i = 1; i <= currentNumber; i++)
                {
                    if (currentNumber % i == 0)
                    {
                        counter++;
                    }
                }

                if (counter > 2)
                {
                    sumOfNonPrimeNumbers += currentNumber;
                }
                else if (counter == 2)
                {
                    sumOfPrimeNumbers += currentNumber;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrimeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonPrimeNumbers}");
        }
    }
}
