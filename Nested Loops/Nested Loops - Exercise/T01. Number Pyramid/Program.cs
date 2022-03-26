using System;

namespace T01._Number_Pyramid
{
    class Program
    {
        static void Main()
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int number = 1;

            for (int rows = 1; rows <= countOfNumbers; rows++)
            {
                for (int col = 1; col <= rows; col++)
                {
                    if (number > countOfNumbers)
                    {
                        break;
                    }
                    Console.Write(number + " ");
                    number++;
                }
                if (number > countOfNumbers)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
