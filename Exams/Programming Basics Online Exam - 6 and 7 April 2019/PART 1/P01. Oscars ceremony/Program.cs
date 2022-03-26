using System;

namespace P01._Oscars_ceremony
{
    class Program
    {
        static void Main()
        {
            //input:
            int rentPrice = int.Parse(Console.ReadLine());

            //calculations:
            double statuePrice = rentPrice * 0.7;
            double cateringPrice = statuePrice * 0.85;
            double soundPrice = cateringPrice * 0.5;

            double totalPrice = rentPrice + statuePrice + cateringPrice + soundPrice;

            //print:
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
