using System;

namespace T06._Building
{
    class Program
    {
        static void Main()
        {
            int countOfFloor = int.Parse(Console.ReadLine());
            int countOfRooms = int.Parse(Console.ReadLine());

            for (int floors = countOfFloor; floors >= 1; floors--)
            {
                for (int rooms = 0; rooms < countOfRooms; rooms++)
                {
                    if (floors == countOfFloor)
                    {
                        Console.Write($"L{floors}{rooms} ");
                    }
                    else if (floors % 2 == 0)
                    {
                        Console.Write($"O{floors}{rooms} ");
                    }
                    else
                    {
                        Console.Write($"A{floors}{rooms} ");
                    }
                    
                }
                Console.WriteLine();
            }            
        }
    }
}
