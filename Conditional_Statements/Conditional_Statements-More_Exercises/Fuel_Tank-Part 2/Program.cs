using System;

namespace Fuel_Tank_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //input information:
            string fuel = Console.ReadLine();
            double fuelQuantity = double.Parse(Console.ReadLine());
            string clubcard = Console.ReadLine();

            //additional information:
            double gasolinePrice = 2.22;
            double dieselPrice = 2.33;
            double gasPrice = 0.93;

            double finalPrice = 0;

            //calculations:
            if (clubcard == "Yes")
            {
                gasolinePrice -= 0.18;
                dieselPrice -= 0.12;
                gasPrice -= 0.08;
            }
           
            if (fuel== "Gas")
            {
                finalPrice = fuelQuantity * gasPrice;
            }
            else if (fuel == "Gasoline")
            {
                finalPrice = fuelQuantity * gasolinePrice;
            }
            else if (fuel== "Diesel")
            {
                finalPrice = fuelQuantity * dieselPrice;
            }
                        
            if (fuelQuantity>25)
            {
                finalPrice *= 0.9;
            }
            else if (fuelQuantity<=25 && fuelQuantity>20)
            {
                finalPrice *= 0.92;
            }

            //print:
            Console.WriteLine($"{finalPrice:f2} lv.");
            

        }
    }
}
