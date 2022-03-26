using System;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();

            //calculations:
            switch (sex)
            {
                case "m":
                    if (age < 16)
                    {
                        Console.WriteLine("Master");
                    }
                    else
                    {
                        Console.WriteLine("Mr.");
                    }
                    break;
                case "f":
                    if (age < 16)
                    {
                        Console.WriteLine("Miss");
                    }
                    else
                    {
                        Console.WriteLine("Ms.");
                    }
                    break;
            }
        }
    }
}
