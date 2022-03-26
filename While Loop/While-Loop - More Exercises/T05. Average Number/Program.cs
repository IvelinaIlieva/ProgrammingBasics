using System;

namespace T05._Average_Number
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum += numbers;
            }
            double averageNum = 1.0 * sum / n;
            Console.WriteLine($"{averageNum:f2}");
        }
    }
}
