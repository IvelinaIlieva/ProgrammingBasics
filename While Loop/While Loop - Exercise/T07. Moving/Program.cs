using System;

namespace T07._Moving
{
    class Program
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int allPlace = width * lenght * height;

            int freeArea = allPlace;

            while (freeArea > 0)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    Console.WriteLine($"{freeArea} Cubic meters left.");
                    break;
                }

                int takenPlace = int.Parse(input);
                freeArea -= takenPlace;
            }
            if (freeArea <= 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeArea)} Cubic meters more.");
            }
        }
    }
}
