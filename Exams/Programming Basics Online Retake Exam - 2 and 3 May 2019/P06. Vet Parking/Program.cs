using System;

namespace P06._Vet_Parking
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            
            double totalPrice = 0;

            for (int i = 1; i <= days; i++)
            {
                double totalPricePerDay = 0;

                for (int j = 1; j <= hours; j++)
                {
                    double price = 0;
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        price = 2.5;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        price = 1.25;
                    }
                    else
                    {
                        price = 1;
                    }
                    totalPricePerDay += price;
                }
                totalPrice += totalPricePerDay;
                Console.WriteLine($"Day: {i} - {totalPricePerDay:f2} leva");
            }
            Console.WriteLine($"Total: {totalPrice:f2} leva");
        }
    }
}
