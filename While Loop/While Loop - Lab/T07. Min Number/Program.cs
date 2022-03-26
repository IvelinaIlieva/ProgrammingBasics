using System;

namespace T07._Min_Number
{
    class Program
    {
        static void Main()
        {
            string numbers = Console.ReadLine();

            int minNumber = int.MaxValue;

            while (numbers != "Stop")
            {
                int convertedNumber = int.Parse(numbers);

                if (convertedNumber <= minNumber)
                {
                    minNumber = convertedNumber;
                }
                numbers = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
