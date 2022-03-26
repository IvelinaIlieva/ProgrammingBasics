using System;

namespace P01._Basketball_Equipment
{
    class Program
    {
        static void Main()
        {
            //input:
            int taxPerYear = int.Parse(Console.ReadLine());

            //calculations:
            double sneackersPrice = taxPerYear * 0.6;
            double suitPrice = sneackersPrice * 0.8;
            double ballPrice = suitPrice / 4;
            double accessoriesPrice = ballPrice / 5;

            //print:
            Console.WriteLine($"{(taxPerYear+ sneackersPrice+ suitPrice+ ballPrice+ accessoriesPrice):f2}");
        }
    }
}
