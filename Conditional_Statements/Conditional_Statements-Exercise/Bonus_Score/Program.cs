using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            double bonus = 0;
            if (a <= 100)
            {
                bonus = 5;
            }
            else if (a > 1000)
            {
                bonus = 0.1 * a;
            }
            else
            {
                bonus = 0.2 * a;
            }
            
            if (a % 2 == 0)
            {
                bonus++;
            }
            else if (a % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(a + bonus);
        }
    }
}
