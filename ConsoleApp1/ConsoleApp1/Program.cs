using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "Plamen";
            string lastname = "Simeonov";
            int age = 35;
            string town = "Gorna Oryahovitsa";
            Console.WriteLine($"I love {firstname} {lastname}, a {age}-years old man from { town}!");
        }
    }
}
