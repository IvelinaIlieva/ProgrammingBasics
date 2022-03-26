using System;

namespace P03._Aluminum_Joinery
{
    class Program
    {
        static void Main()
        {
            //const:
            const double DELIVERY_PRICE = 60;

            //input:
            int countOfJoinery = int.Parse(Console.ReadLine());
            string kindOfJoinery = Console.ReadLine();
            string delivery = Console.ReadLine();
            
            //calculations:
            double joineryPrice = 0;
            switch (kindOfJoinery)
            {
                case "90X130":
                    joineryPrice = 110;

                    if (countOfJoinery > 60)
                    {
                        joineryPrice *= 0.92;
                    }
                    else if (countOfJoinery > 30)
                    {
                        joineryPrice *= 0.95;
                    }
                    break;
                case "100X150":
                    joineryPrice = 140;

                    if (countOfJoinery > 80)
                    {
                        joineryPrice *= 0.9;
                    }
                    else if (countOfJoinery > 40)
                    {
                        joineryPrice *= 0.94;
                    }
                    break;
                case "130X180":
                    joineryPrice = 190;

                    if (countOfJoinery > 50)
                    {
                        joineryPrice *= 0.88;
                    }
                    else if (countOfJoinery > 20)
                    {
                        joineryPrice *= 0.93;
                    }
                    break;
                case "200X300":
                    joineryPrice = 250;

                    if (countOfJoinery > 50)
                    {
                        joineryPrice *= 0.86;
                    }
                    else if (countOfJoinery > 25)
                    {
                        joineryPrice *= 0.91;
                    }
                    break;
            }
            double totalPrice = countOfJoinery * joineryPrice;

            if (delivery == "With delivery")
            {
                totalPrice += DELIVERY_PRICE;
            }

            if (countOfJoinery > 99)
            {
                totalPrice *= 0.96;
            }

            //print:
            Console.WriteLine(countOfJoinery > 10 ? $"{totalPrice:f2} BGN" : "Invalid order");
        }
    }
}
