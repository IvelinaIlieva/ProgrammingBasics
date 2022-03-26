using System;

namespace T07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            string month = Console.ReadLine();
            int countOfNights = int.Parse(Console.ReadLine());

            //add data:
            const double STUDIO_PRICE_MAY_OCTOBER = 50;
            const double STUDIO_PRICE_JUNE_SEPTEMBER = 75.2;
            const double STUDIO_PRICE_JULY_AUGUST = 76;
            const double APARTMENT_PRICE_MAY_OCTOBER = 65;
            const double APARTMENT_PRICE_JUNE_SEPTEMBER = 68.7;
            const double APARTMENT_PRICE_JULY_AUGUST = 77;

            //calculations:
            double totalPriceStudio = 0;
            double totalPriceApartment = 0;

            switch (month)
            {
                case "May":
                case "October":
                    totalPriceStudio = countOfNights * STUDIO_PRICE_MAY_OCTOBER;
                    totalPriceApartment = countOfNights * APARTMENT_PRICE_MAY_OCTOBER;
                    if (countOfNights > 7 && countOfNights <= 14)
                    {
                        totalPriceStudio *= 0.95;
                    }
                    else if (countOfNights > 14)
                    {
                        totalPriceStudio *= 0.7;
                        totalPriceApartment *= 0.9;
                    }
                    break;
                case "June":
                case "September":
                    totalPriceStudio = countOfNights * STUDIO_PRICE_JUNE_SEPTEMBER;
                    totalPriceApartment = countOfNights * APARTMENT_PRICE_JUNE_SEPTEMBER;
                    if (countOfNights > 14)
                    {
                        totalPriceStudio *= 0.8;
                        totalPriceApartment *= 0.9;
                    }
                    break;
                case "July":
                case "August":
                    totalPriceApartment = countOfNights * APARTMENT_PRICE_JULY_AUGUST;
                    totalPriceStudio = countOfNights * STUDIO_PRICE_JULY_AUGUST;
                    if (countOfNights > 14)
                    {
                        totalPriceApartment *= 0.9;
                    }
                    break;
            }
            //print:
            Console.WriteLine($"Apartment: {totalPriceApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
        }
    }
}
