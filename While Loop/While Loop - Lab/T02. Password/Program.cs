using System;

namespace T02._Password
{
    class Program
    {
        static void Main()
        {
            //input data:
            string name = Console.ReadLine();
            string password = Console.ReadLine();

            string currentPassword = Console.ReadLine();

            while (password !=currentPassword)
            {
                currentPassword = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
