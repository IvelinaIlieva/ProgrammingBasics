using System;

namespace P06._Barcode_Generator
{
    class Program
    {
        static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            int startN4 = startNumber % 10; //4
            startNumber /= 10;
            int startN3 = startNumber % 10; //3
            startNumber /= 10;
            int startN2 = startNumber % 10;//2;
            startNumber /= 10;
            int startN1 = startNumber;

            int endN4 = endNumber % 10; //4
            endNumber /= 10;
            int endN3 = endNumber % 10; //3
            endNumber /= 10;
            int endN2 = endNumber % 10;//2;
            endNumber /= 10;
            int endN1 = endNumber;

            for (int i = startN1; i <= endN1; i++)
            {
                if (i % 2 != 0)
                {

                    for (int j = startN2; j <= endN2; j++)
                    {
                        if (j % 2 != 0)
                        {

                            for (int k = startN3; k <= endN3; k++)
                            {
                                if (k % 2 != 0)
                                {

                                    for (int l = startN4; l <= endN4; l++)
                                    {
                                        if (l % 2 != 0)
                                        {
                                            Console.Write($"{i}{j}{k}{l} ");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
