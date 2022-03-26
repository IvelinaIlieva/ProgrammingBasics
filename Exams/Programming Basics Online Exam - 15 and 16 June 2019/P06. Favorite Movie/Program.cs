using System;

namespace P06._Favorite_Movie
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string winnerMovie = string.Empty;
            double maxPoints = double.MinValue;

            int counter = 0;

            while (input != "STOP")
            {
                string nameOfMovie = input;
                double totalPoints = 0;
                counter++;
                if (counter == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }

                for (int j = 0; j <= nameOfMovie.Length - 1; j++)
                {
                    char currentLetter = nameOfMovie[j];

                    if (currentLetter >= 65 && currentLetter <= 90)
                    {
                        totalPoints += currentLetter - nameOfMovie.Length;
                    }
                    else if (currentLetter >= 97 && currentLetter <= 122)
                                        {
                        totalPoints += currentLetter - 2 * nameOfMovie.Length;
                    }
                    else
                    {
                        totalPoints += currentLetter;
                    }
                }
                if (maxPoints < totalPoints)
                {
                    maxPoints = totalPoints;
                    winnerMovie = nameOfMovie;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"The best movie for you is {winnerMovie} with {maxPoints} ASCII sum.");
        }
    }
}
