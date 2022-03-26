using System;

namespace T03._Logistics
{
    class Program
    {
        static void Main()
        {
            //input data:
            int countOfCargo = int.Parse(Console.ReadLine());
            int minibusTransport = 0;
            int truckTransport = 0;
            int trainTransport = 0;
            const double MINIBUS_PRICE = 200;
            const double TRUCK_PRICE = 175;
            const double TRAIN_PRICE = 120;

            //calculations:
            for (int i = 0; i < countOfCargo; i++)
            {
                int weightOfCargo = int.Parse(Console.ReadLine());

                if (weightOfCargo < 4)
                {
                    minibusTransport += weightOfCargo;
                }
                else if (weightOfCargo < 12)
                {
                    truckTransport += weightOfCargo;
                }
                else
                {
                    trainTransport += weightOfCargo;
                }
            }
            int totalCourses = minibusTransport + truckTransport + trainTransport;
            double totalPrice = minibusTransport * MINIBUS_PRICE + truckTransport * TRUCK_PRICE + trainTransport * TRAIN_PRICE;
            double averagePrice = totalPrice / totalCourses;
            double percentageOfMinibusTransport = 1.0 * minibusTransport / totalCourses * 100;
            double percentageOfTruckTransport = 1.0 * truckTransport / totalCourses * 100;
            double percentageOfTrainTransport = 1.0 * trainTransport / totalCourses * 100;

            //print:
            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{percentageOfMinibusTransport:f2}%");
            Console.WriteLine($"{percentageOfTruckTransport:f2}%");
            Console.WriteLine($"{percentageOfTrainTransport:f2}%");
        }
    }
}
