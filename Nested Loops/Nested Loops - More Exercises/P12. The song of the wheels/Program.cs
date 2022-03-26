using System;

namespace P12._The_song_of_the_wheels
{
    class Program
    {
        static void Main()
        {
            int controlNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            int numA = 0;
            int numB = 0;
            int numC = 0;
            int numD = 0;
            bool toPrint = false;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a < b && c > d && (a * b + c * d == controlNumber))
                            {
                                counter++;
                                
                                Console.Write($"{a}{b}{c}{d} ");

                                if (counter == 4)
                                {
                                    numA = a;
                                    numB = b;
                                    numC = c;
                                    numD = d;
                                    toPrint = true;
                                }
                                else if (counter == 0)
                                {
                                    Console.WriteLine("No!");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            if (toPrint)
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {numA}{numB}{numC}{numD}");
            }
            else if (counter < 4)
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }
        }
    }
}
