using System;

namespace P04._Balls
{
    class Program
    {
        static void Main()
        {
            int countOfBalls = int.Parse(Console.ReadLine());

            double points = 0;
            int countOfRedBalls = 0;
            int countOfOrangeBalls = 0;
            int countOfYellowBalls = 0;
            int countOfWhiteBalls = 0;
            int countOfBlackBalls = 0;
            int countOfOtherColorBalls = 0;

            for (int i = 1; i <= countOfBalls; i++)
            {
                string colorOfBall = Console.ReadLine();

                switch (colorOfBall)
                {
                    case "red":
                        points += 5;
                        countOfRedBalls++;
                        break;
                    case "orange":
                        points += 10;
                        countOfOrangeBalls++;
                        break;
                    case "yellow":
                        points += 15;
                        countOfYellowBalls++;
                        break;
                    case "white":
                        points += 20;
                        countOfWhiteBalls++;
                        break;
                    case "black":
                        points=Math.Floor(points /= 2);
                        countOfBlackBalls++;
                        break;
                    default:
                        countOfOtherColorBalls++;
                        break;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {countOfRedBalls}");
            Console.WriteLine($"Orange balls: {countOfOrangeBalls}");
            Console.WriteLine($"Yellow balls: {countOfYellowBalls}");
            Console.WriteLine($"White balls: {countOfWhiteBalls}");
            Console.WriteLine($"Other colors picked: {countOfOtherColorBalls}");
            Console.WriteLine($"Divides from black balls: {countOfBlackBalls}");
        }
    }
}
