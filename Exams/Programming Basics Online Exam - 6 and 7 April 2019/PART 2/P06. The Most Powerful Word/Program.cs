using System;

namespace P06._The_Most_Powerful_Word
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int totalChar = 0;
            int strongestWordPoints = int.MinValue;
            string winnerWord = "";

            while (input != "End of words")
            {
                string word = input;

                for (int i = 1; i <= word.Length; i++)
                {
                    int currChar = word[i - 1];
                    totalChar += currChar;
                }

                if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u' || word[0] == 'y' || word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O' || word[0] == 'U' || word[0] == 'Y')
                {
                    totalChar *= word.Length;
                }
                else
                {
                    totalChar = (int)Math.Floor((double)totalChar / word.Length);
                }

                if (strongestWordPoints < totalChar)
                {
                    strongestWordPoints = totalChar;
                    winnerWord = word;
                }

                totalChar = 0;
                input = Console.ReadLine();
            }
            Console.WriteLine($"The most powerful word is {winnerWord} - {strongestWordPoints}");
        }
    }
}
