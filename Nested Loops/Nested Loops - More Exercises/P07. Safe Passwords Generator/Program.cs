using System;

namespace P07._Safe_Passwords_Generator
{
    class Program
    {
        static void Main()
        {
            int maxX = int.Parse(Console.ReadLine());
            int maxY = int.Parse(Console.ReadLine());
            int maxCountOfPasswords = int.Parse(Console.ReadLine());

            int countOfCombinations = 0;

            for (char a = '#'; a <= 55; a++)
            {
                for (char b = '@'; b <= 96; b++)
                {
                    for (int x = 1; x <= maxX; x++)
                    {
                        for (int y = 1; y <= maxY; y++)
                        {
                            countOfCombinations++;
                            if (countOfCombinations < maxCountOfPasswords && x == maxX && y == maxY)
                            {
                                Console.Write($"{a}{b}{x}{y}{b}{a}|");
                                a++;
                                b++;
                                return;
                            }
                            else if (countOfCombinations == maxCountOfPasswords)
                            {
                                Console.Write($"{a}{b}{x}{y}{b}{a}|");
                                a++;
                                b++;
                                if (a > 55)
                                {
                                    a = '#';
                                }
                                if (b > 96)
                                {
                                    b = '@';
                                }
                                return;
                            }
                            else
                            {
                                Console.Write($"{a}{b}{x}{y}{b}{a}|");
                                a++;
                                b++;
                                if (a > 55)
                                {
                                    a = '#';
                                }
                                if (b > 96)
                                {
                                    b = '@';
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}