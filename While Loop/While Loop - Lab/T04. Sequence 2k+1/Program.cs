using System;

namespace T04._Sequence_2k_1
{
    class Program
    {
        static void Main()
        {
            int primaryNumber = int.Parse(Console.ReadLine());

            int startNumber = 1;

            while (primaryNumber >= startNumber)
            {
                Console.WriteLine(startNumber);
                startNumber = 2 * startNumber + 1;
            }
        }
    }
}
