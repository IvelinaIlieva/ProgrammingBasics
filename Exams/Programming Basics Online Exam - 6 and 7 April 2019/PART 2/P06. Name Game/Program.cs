using System;

namespace P06._Name_Game
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int totalPointsOfPlayer = 0;
            int winnerPoints = int.MinValue;
            string winner = "";

            while (input != "Stop")
            {
                string nameOfPlayer = input;

                int num = nameOfPlayer.Length;

                for (int i = 1; i <= num; i++)
                {
                    int valueOfLetter = int.Parse(Console.ReadLine());

                    char value = (char)valueOfLetter;

                    if (value == nameOfPlayer[i-1])
                    {
                        totalPointsOfPlayer += 10;
                    }
                    else
                    {
                        totalPointsOfPlayer += 2;
                    }
                }

                if (winnerPoints <= totalPointsOfPlayer)
                {
                    winnerPoints = totalPointsOfPlayer;
                    winner = nameOfPlayer;
                }
                totalPointsOfPlayer = 0;
                input = Console.ReadLine();
            }
            Console.WriteLine($"The winner is {winner} with {winnerPoints} points!");
        }
    }
}
