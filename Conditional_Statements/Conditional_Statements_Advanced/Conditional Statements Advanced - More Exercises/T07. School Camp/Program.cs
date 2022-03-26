using System;

namespace T07._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            string season = Console.ReadLine(); //“Winter”, “Spring” или “Summer”;
            string group = Console.ReadLine(); //“boys”, “girls” или “mixed”;
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfNights = int.Parse(Console.ReadLine());

            //add data:
            const double BOYS_GIRLS_WINTER = 9.6;
            const double BOYS_GIRLS_SPRING = 7.2;
            const double BOYS_GIRLS_SUMMER = 15;
            const double MIXED_WINTER = 10;
            const double MIXED_SPRING = 9.5;
            const double MIXED_SUMMER = 20;

            //calsulations:
            double totalPrice = countOfNights * countOfStudents;
            string sport = null;

            switch (season)
            {
                case "Winter":
                    switch (group)
                    {
                        case "boys":
                            sport = "Judo";
                            totalPrice *= BOYS_GIRLS_WINTER;
                            break;
                        case "girls":
                            sport = "Gymnastics";
                            totalPrice *= BOYS_GIRLS_WINTER;
                            break;
                        case "mixed":
                            sport = "Ski";
                            totalPrice *= MIXED_WINTER;
                            break;
                    }
                    break;
                case "Spring":
                    switch (group)
                    {
                        case "boys":
                            sport = "Tennis";
                            totalPrice *= BOYS_GIRLS_SPRING;
                            break;
                        case "girls":
                            sport = "Athletics";
                            totalPrice *= BOYS_GIRLS_SPRING;
                            break;
                        case "mixed":
                            sport = "Cycling";
                            totalPrice *= MIXED_SPRING;
                            break;
                    }
                    break;
                case "Summer":
                    switch (group)
                    {
                        case "boys":
                            sport = "Football";
                            totalPrice *= BOYS_GIRLS_SUMMER;
                            break;
                        case "girls":
                            sport = "Volleyball";
                            totalPrice *= BOYS_GIRLS_SUMMER;
                            break;
                        case "mixed":
                            sport = "Swimming";
                            totalPrice *= MIXED_SUMMER;
                            break;
                    }
                    break;
            }
            if (countOfStudents >= 50)
            {
                totalPrice *= 0.5;
            }
            else if (countOfStudents >= 20)
            {
                totalPrice *= 0.85;
            }
            else if (countOfStudents >= 10)
            {
                totalPrice *= 0.95;
            }

            //print:
            Console.WriteLine($"{sport} {totalPrice:f2} lv.");
        }
    }
}
