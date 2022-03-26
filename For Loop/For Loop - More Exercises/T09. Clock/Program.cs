using System;

namespace T09._Clock
{
    class Program
    {
        static void Main()
        {
            for (int hour = 0; hour < 24; hour++)
            {
                for (int min = 0; min < 60; min++)
                {
                    Console.WriteLine($"{hour} : {min}");
                }
            }
        }
    }
}
