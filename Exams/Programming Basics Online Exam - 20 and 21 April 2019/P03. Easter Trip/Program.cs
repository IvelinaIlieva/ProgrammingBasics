using System;

namespace P03._Easter_Trip
{
    class Program
    {
        static void Main()
        {
            const double FRANCE_21_23 = 30;
            const double FRANCE_24_27 = 35;
            const double FRANCE_28_31 = 40;
            const double ITALY_21_23 = 28;
            const double ITALY_24_27 = 32;
            const double ITALY_28_31 = 39;
            const double GERMANY_21_23 = 32;
            const double GERMANY_24_27 = 37;
            const double GERMANY_28_31 = 43;

            //input:
            string destination = Console.ReadLine();
            string date = Console.ReadLine();
            int countOfNights = int.Parse(Console.ReadLine());

            //calculations:
            double expences = 0;

            switch (destination)
            {
                case "France":
                    switch (date)
                    {
                        case "21-23":
                            expences = countOfNights * FRANCE_21_23;
                            break;
                        case "24-27":
                            expences = countOfNights * FRANCE_24_27;
                            break;
                        case "28-31":
                            expences = countOfNights * FRANCE_28_31;
                            break;
                    }
                    break;
                case "Italy":
                    switch (date)
                    {
                        case "21-23":
                            expences = countOfNights * ITALY_21_23;
                            break;
                        case "24-27":
                            expences = countOfNights * ITALY_24_27;
                            break;
                        case "28-31":
                            expences = countOfNights * ITALY_28_31;
                            break;
                    }
                    break;
                case "Germany":
                    switch (date)
                    {
                        case "21-23":
                            expences = countOfNights * GERMANY_21_23;
                            break;
                        case "24-27":
                            expences = countOfNights * GERMANY_24_27;
                            break;
                        case "28-31":
                            expences = countOfNights * GERMANY_28_31;
                            break;
                    }
                    break;
            }

            //print:
            Console.WriteLine($"Easter trip to {destination} : {expences:f2} leva.");
        }
    }
}
