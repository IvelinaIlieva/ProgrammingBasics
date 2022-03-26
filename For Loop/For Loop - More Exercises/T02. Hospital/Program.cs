using System;

namespace T02._Hospital
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int countOfDoctors = 7;

            for (int i = 1; i <= days; i++)
            {
                int countOfPatients = int.Parse(Console.ReadLine());
                
                if (i% 3 == 0 && treatedPatients < untreatedPatients)
                {
                    countOfDoctors++;                    
                }
                if (countOfPatients <= countOfDoctors)
                {
                    treatedPatients += countOfPatients;
                }
                else
                {
                    treatedPatients += countOfDoctors;
                    untreatedPatients += countOfPatients - countOfDoctors;
                }
                
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
