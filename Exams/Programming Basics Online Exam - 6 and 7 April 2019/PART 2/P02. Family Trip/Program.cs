using System;

namespace P02._Family_Trip
{
    class Program
    {
        static void Main()
        {
            //input:
            double budget = double.Parse(Console.ReadLine());
            int countOfNights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int additionalExpencePercent = int.Parse(Console.ReadLine());

            //calculations:
            if (countOfNights > 7)
            {
                pricePerNight *= 0.95;
            }

            double totalExpences = countOfNights * pricePerNight + budget * additionalExpencePercent / 100;
            double diff = Math.Abs(totalExpences - budget);

            //print:
            Console.WriteLine(budget >= totalExpences ? $"Ivanovi will be left with {diff:f2} leva after vacation." : $"{diff:f2} leva needed.");
        }
    }
}
