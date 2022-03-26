using System;

namespace T06._Cake
{
    class Program
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int allPieces = lenght * width;

            string pieces = "";
            int takenPieces = 0;
            
            int leftPieces = allPieces - takenPieces;

            while (pieces != "STOP")
            {
                pieces = Console.ReadLine();

                if (pieces == "STOP")
                {
                    Console.WriteLine($"{Math.Abs(leftPieces)} pieces are left.");
                    break;
                }
                takenPieces = int.Parse(pieces);
                leftPieces -= takenPieces;

                if (leftPieces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(leftPieces)} pieces more.");
                    break;
                }
            }
        }
    }
}
