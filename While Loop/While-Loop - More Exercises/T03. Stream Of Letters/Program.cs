using System;

namespace T03._Stream_Of_Letters
{
    class Program
    {
        static void Main()
        {
            string symbol = Console.ReadLine();

            int counterC = 0;
            int counterO = 0;
            int counterN = 0;
            string words = "";
            string password = "";

            while (symbol != "End")

            {
                char letter = char.Parse(symbol);

                if ((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z'))
                {
                    if (letter == 'c' && counterC == 0)
                    {
                        counterC++;
                    }
                    else if (letter == 'o' && counterO == 0)
                    {
                        counterO++;
                    }
                    else if (letter == 'n' && counterN == 0)
                    {
                        counterN++;
                    }
                    else
                    {
                        words += letter;
                    }

                    if (counterN == 1 && counterC == 1 && counterO == 1)
                    {
                        password += words + ' ';
                        counterO = counterN = counterC = 0;
                        words = "";
                    }
                }
                symbol = Console.ReadLine();
            }
            Console.WriteLine(password);
        }
    }
}
