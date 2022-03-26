using System;

namespace T03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            string kindOfFlower = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            //"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"

            //add data:
            const double PRICE_FOR_ROSES = 5;
            const double PRICE_FOR_DAHLIAS = 3.8;
            const double PRICE_FOR_TULIPS = 2.8;
            const double PRICE_FOR_NARCISSUS = 3;
            const double PRICE_FOR_GLADIOLUS = 2.5;
            
            //calculations:
            double totalPrice = 0;

            switch (kindOfFlower)
            {
                case "Roses":
                    if (countOfFlowers >80)
                    {
                        totalPrice = countOfFlowers * PRICE_FOR_ROSES * 0.9;
                    }
                    else
                    {
                        totalPrice = countOfFlowers * PRICE_FOR_ROSES;
                    }
                    break;
                case "Dahlias":
                    if (countOfFlowers >90)
                    {
                        totalPrice = countOfFlowers * PRICE_FOR_DAHLIAS * 0.85;
                    }
                    else
                    {
                        totalPrice = countOfFlowers * PRICE_FOR_DAHLIAS;
                    }
                    break;
                case "Tulips":
                    if (countOfFlowers > 80)
                    {
                        totalPrice = countOfFlowers * PRICE_FOR_TULIPS * 0.85;
                    }
                    else
                    {
                        totalPrice = countOfFlowers * PRICE_FOR_TULIPS;
                    }
                    break;
                case "Narcissus":
                    if (countOfFlowers < 120)
                    {
                        totalPrice = countOfFlowers * PRICE_FOR_NARCISSUS * 1.15;
                    }
                    else
                    {
                        totalPrice = countOfFlowers * PRICE_FOR_NARCISSUS;
                    }
                    break;
                case "Gladiolus":
                    if (countOfFlowers < 80)
                    {
                        totalPrice = countOfFlowers * PRICE_FOR_GLADIOLUS * 1.20;
                    }
                    else
                    {
                        totalPrice = countOfFlowers * PRICE_FOR_GLADIOLUS;
                    }
                    break;
            }
            double difference = Math.Abs(budget - totalPrice);
            //print:
            Console.WriteLine(budget>=totalPrice? $"Hey, you have a great garden with {countOfFlowers} {kindOfFlower} and {difference:f2} leva left." : $"Not enough money, you need {difference:f2} leva more.");
        }
    }
}
