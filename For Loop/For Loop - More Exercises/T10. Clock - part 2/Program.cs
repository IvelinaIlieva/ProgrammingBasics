using System;

namespace T10._Clock___part_2
{
    class Program
    {
        static void Main()
        {
            for (int hour = 0; hour < 24; hour++)
            {
                for (int min = 0; min < 60; min++)
                {
                    for (int sec = 0; sec < 60; sec++)
                    {
                        Console.WriteLine($"{hour} : {min} : {sec}");
                    }
                }
            }
        }
    }
}
