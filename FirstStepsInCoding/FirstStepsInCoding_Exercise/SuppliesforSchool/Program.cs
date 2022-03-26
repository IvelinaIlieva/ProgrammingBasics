using System;

namespace SuppliesforSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int penPacket = int.Parse(Console.ReadLine());
            int markersPacket = int.Parse(Console.ReadLine());
            int litres = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double penPrice = 5.80;
            double markerPrice = 7.20;
            double cleanerPrice = 1.20;

            double pens = penPacket * penPrice;
            double markers = markerPrice * markersPacket;
            double cleaner = litres * cleanerPrice;

            double sum = pens + markers + cleaner;
            double discount = sum * percent / 100;

            double endSum = sum - discount;

            Console.WriteLine(endSum);
        }
    }
}
