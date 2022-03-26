using System;

namespace T05._Coins
{
    class Program
    {
        static void Main()
        {
            double change = double.Parse(Console.ReadLine());

            double convertChange = change * 100;
            int coins = (int) convertChange;
            int countOfCoins = 0;
            

            while (coins > 0)
            {
                if (coins - 200 >= 0)
                {
                    countOfCoins++;
                    coins -= 200;
                }
                else if (coins - 100 >= 0)
                {
                    countOfCoins++;
                    coins -= 100;
                }
                else if (coins - 50 >= 0)
                {
                    countOfCoins++;
                    coins -= 50;
                }
                else if (coins - 20 >= 0)
                {
                    countOfCoins++;
                    coins -= 20;
                }
                else if (coins - 10 >= 0)
                {
                    countOfCoins++;
                    coins -= 10;
                }
                else if (coins - 5 >= 0)
                {
                    countOfCoins++;
                    coins -= 5;
                }
                else if (coins - 2 >= 0)
                {
                    countOfCoins++;
                    coins -= 2;
                }
                else if (coins - 1 >= 0)
                {
                    countOfCoins++;
                    coins -= 1;
                }
            }
            Console.WriteLine(countOfCoins);
        }
    }
}
