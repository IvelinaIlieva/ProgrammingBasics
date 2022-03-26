using System;

namespace T10._Multiply_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            while (num >= 0)
            {
                num *= 2;
                Console.WriteLine($"Result: {num:f2}");
                num = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Negative number!");
        }
    }
}
