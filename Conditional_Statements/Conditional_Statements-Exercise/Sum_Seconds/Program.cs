using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            int time = time1 + time2 + time3;

            int minutes = time / 60;
            int seconds = time % 60;
            
            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}
