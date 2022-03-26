using System;

namespace P05._Movie_Ratings
{
    class Program
    {
        static void Main()
        {
            int countOfMovies = int.Parse(Console.ReadLine());

            double sumOfRating = 0;
            double minRating = double.MaxValue;
            double maxRating = double.MinValue;
            string bestMovie = "";
            string worstMovie = "";

            for (int i = 1; i <= countOfMovies; i++)
            {
                string nameOfMovie = Console.ReadLine();
                double ratingOfMovie = double.Parse(Console.ReadLine());

                if (ratingOfMovie>maxRating)
                {
                    maxRating = ratingOfMovie;
                    bestMovie = nameOfMovie;
                }
                if (ratingOfMovie<minRating)
                {
                    minRating = ratingOfMovie;
                    worstMovie = nameOfMovie;
                }

                sumOfRating += ratingOfMovie;
            }
            Console.WriteLine($"{bestMovie} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{worstMovie} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {sumOfRating/countOfMovies:f1}");
        }
    }
}
