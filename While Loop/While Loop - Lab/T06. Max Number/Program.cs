using System;

namespace T06._Max_Number
{
    class Program
    {
        static void Main()
        {
            string numbers = Console.ReadLine();

            int maxNumber = int.MinValue;

            while (numbers != "Stop")
            {
                int convertedNumber = int.Parse(numbers);

                if (convertedNumber >= maxNumber)
                {
                    maxNumber = convertedNumber;
                }
                numbers = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
