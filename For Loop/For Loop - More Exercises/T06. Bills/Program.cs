using System;

namespace T06._Bills
{
    class Program
    {
        static void Main()
        {
            //input data:
            int mounths = int.Parse(Console.ReadLine());

            //add data:
            const double WATER_PRICE = 20;
            const double INTERNET_PRICE = 15;
            double electricityExpense = 0;
            double otherExpense = mounths * (WATER_PRICE + INTERNET_PRICE);
            
            //calculations:
            for (int i = 0; i < mounths; i++)
            {
                double electricityPrice = double.Parse(Console.ReadLine());
                electricityExpense += electricityPrice;                
            }
            otherExpense = (otherExpense + electricityExpense) * 1.2;

            //print:
            Console.WriteLine($"Electricity: {electricityExpense:f2} lv");
            Console.WriteLine($"Water: {(WATER_PRICE * mounths):f2} lv");
            Console.WriteLine($"Internet: {(INTERNET_PRICE * mounths):f2} lv");
            Console.WriteLine($"Other: {otherExpense:f2} lv");

            double averageExpense = (mounths * (INTERNET_PRICE + WATER_PRICE) + electricityExpense + otherExpense) / mounths;
            Console.WriteLine($"Average: {averageExpense:f2} lv");
        }
    }
}
