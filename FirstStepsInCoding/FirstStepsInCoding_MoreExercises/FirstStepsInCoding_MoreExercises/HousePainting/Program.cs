using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double areaFrontDoor = 1.2 * 2;
            double areaWindow = 1.5 * 1.5;

            double areaHouse = 2 * (x * x) - areaFrontDoor + 2 * x * y - 2 * areaWindow;
            double areaCover = 2 * x * y + 2 * x * h / 2;

            Console.WriteLine("{0:F2}", areaHouse / 3.4);
            Console.WriteLine("{0:F2}", areaCover / 4.3);
        }
    }
}
