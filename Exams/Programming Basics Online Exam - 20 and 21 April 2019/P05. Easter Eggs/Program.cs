using System;

namespace P05._Easter_Eggs
{
    class Program
    {
        static void Main()
        {
            int countOfPaintedEggs = int.Parse(Console.ReadLine());

            int redCounter = 0;
            int orangeCounter = 0;
            int blueCounter = 0;
            int greenCounter = 0;
            int maxCounter = int.MinValue;
            string maxColour = "";

            for (int i = 1; i <= countOfPaintedEggs; i++)
            {
                string colour = Console.ReadLine();

                switch (colour)
                {
                    case "red":
                        redCounter++;
                        if (redCounter >= maxCounter)
                        {
                            maxCounter = redCounter;
                            maxColour = "red";
                        }
                        break;
                    case "orange":
                        orangeCounter++;
                        if (orangeCounter >= maxCounter)
                        {
                            maxCounter = orangeCounter;
                            maxColour = "orange";
                        }
                        break;
                    case "blue":
                        blueCounter++;
                        if (blueCounter >= maxCounter)
                        {
                            maxCounter = blueCounter;
                            maxColour = "blue";
                        }
                        break;
                    case "green":
                        greenCounter++;
                        if (greenCounter >= maxCounter)
                        {
                            maxCounter = greenCounter;
                            maxColour = "green";
                        }
                        break;
                }
            }
            Console.WriteLine($"Red eggs: {redCounter}");
            Console.WriteLine($"Orange eggs: {orangeCounter}");
            Console.WriteLine($"Blue eggs: {blueCounter}");
            Console.WriteLine($"Green eggs: {greenCounter}");
            Console.WriteLine($"Max eggs: {maxCounter} -> {maxColour}");
        }
    }
}
