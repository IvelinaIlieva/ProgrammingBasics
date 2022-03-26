using System;

namespace T07._Football_League
{
    class Program
    {
        static void Main()
        {
            //input data:
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int countOfFans = int.Parse(Console.ReadLine());

            //add data:
            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;

            //calculations:
            for (int i = 0; i < countOfFans; i++)
            {
                string sector = Console.ReadLine();

                switch (sector)
                {
                    case "A":
                        sectorA++;
                        break;
                    case "B":
                        sectorB++;
                        break;
                    case "V":
                        sectorV++;
                        break;
                    case "G":
                        sectorG++;
                        break;
                }
            }
            double percentageSectorA = (double)sectorA / countOfFans * 100;
            double percentageSectorB = (double)sectorB / countOfFans * 100;
            double percentageSectorV = (double)sectorV / countOfFans * 100;
            double percentageSectorG = (double)sectorG / countOfFans * 100;

            double percentageFull = (double)countOfFans / stadiumCapacity * 100;

            //print:
            Console.WriteLine($"{percentageSectorA:f2}%");
            Console.WriteLine($"{percentageSectorB:f2}%");
            Console.WriteLine($"{percentageSectorV:f2}%");
            Console.WriteLine($"{percentageSectorG:f2}%");
            Console.WriteLine($"{percentageFull:f2}%");
        }
    }
}
