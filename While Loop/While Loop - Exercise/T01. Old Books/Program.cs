using System;

namespace T01._Old_Books
{
    class Program
    {
        static void Main()
        {
            string bookToFind = Console.ReadLine();

            string currentBook = Console.ReadLine(); 
            int checkedBookCounter = 0;

            while (currentBook != bookToFind)
            {
                currentBook = Console.ReadLine();
                checkedBookCounter++;

                if (currentBook == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {checkedBookCounter} books.");
                    return;
                }
            }
            Console.WriteLine($"You checked {checkedBookCounter} books and found it.");
        }
    }
}
