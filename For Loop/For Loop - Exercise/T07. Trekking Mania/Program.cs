using System;

namespace T07._Trekking_Mania
{
    class Program
    {
        static void Main()
        {
            //input data:
            int countOfGroups = int.Parse(Console.ReadLine());

            int climbersOfMontblan = 0;
            int climbersOfKilimandzaro = 0;
            int climbersOfMusala = 0;
            int climbersOfK2 = 0;
            int climbersOfEverest = 0;

            //calculations:
            for (int i = 0; i < countOfGroups; i++)
            {
                int countOfClimbersInGroups = int.Parse(Console.ReadLine());

                if (countOfClimbersInGroups < 6)
                {
                    climbersOfMusala += countOfClimbersInGroups;
                }
                else if (countOfClimbersInGroups < 13)
                {
                    climbersOfMontblan += countOfClimbersInGroups;
                }
                else if (countOfClimbersInGroups < 26)
                {
                    climbersOfKilimandzaro += countOfClimbersInGroups;
                }
                else if (countOfClimbersInGroups < 41)
                {
                    climbersOfK2 += countOfClimbersInGroups;
                }
                else 
                {
                    climbersOfEverest += countOfClimbersInGroups;
                }
            }
            
            int allClimbers = climbersOfEverest + climbersOfK2 + climbersOfKilimandzaro + climbersOfMontblan + climbersOfMusala;

            double percentMusala = 1.0 * climbersOfMusala / allClimbers * 100;
            double percentMontblan = 1.0 * climbersOfMontblan / allClimbers * 100;
            double percentKilimandzaro = 1.0 * climbersOfKilimandzaro / allClimbers * 100;
            double percentK2 = 1.0 * climbersOfK2 / allClimbers * 100;
            double percentEverest = 1.0 * climbersOfEverest / allClimbers * 100;

            Console.WriteLine($"{percentMusala:f2}%");
            Console.WriteLine($"{percentMontblan:f2}%");
            Console.WriteLine($"{percentKilimandzaro:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:f2}%");
        }
    }
}
