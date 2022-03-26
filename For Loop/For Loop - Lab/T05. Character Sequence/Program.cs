using System;

namespace T05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            for (int i = 0; i < inputText.Length; i++)
            {
                char letter = inputText[i];
                Console.WriteLine(letter);
            }
        }
    }
}
