using System;

namespace P04._Renovation
{
    class Program
    {
        static void Main()
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int noPaintingPercent = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double totalAreaToPaint = height * width * 4;
            totalAreaToPaint -= Math.Ceiling(totalAreaToPaint * noPaintingPercent / 100);
            double leftToPaint = totalAreaToPaint;

            while (input != "Tired!")
            {
                int paintQuantity = int.Parse(input);

                leftToPaint -= paintQuantity;

                if (leftToPaint == 0)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    return;
                }
                else if (leftToPaint < 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(leftToPaint)} l paint left!");
                    return;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{leftToPaint} quadratic m left.");
        }
    }
}
