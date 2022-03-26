using System;

namespace Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());

            string temp = "0";

            if (speed <= 10)
            {
                temp = "slow";
            }
            else if (speed > 10 && speed <= 50)
            {
                temp = "average";
            }
            else if (speed > 50 && speed <= 150)
            {
                temp = "fast";
            }
            else if (speed > 150 && speed <= 1000)
            {
                temp = "ultra fast";
            }
            else
            {
                temp = "extremely fast";
            }
                Console.WriteLine(temp);
        }
    }
}
