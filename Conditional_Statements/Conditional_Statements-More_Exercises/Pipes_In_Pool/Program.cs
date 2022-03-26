using System;

namespace Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            //input:
            int volumePool = int.Parse(Console.ReadLine());
            int debitPipe1 = int.Parse(Console.ReadLine());
            int debitPipe2 = int.Parse(Console.ReadLine());
            double timeAbsent = double.Parse(Console.ReadLine());

            //calculations:
            double fillPipe1 = debitPipe1 * timeAbsent;
            double fillPipe2 = debitPipe2 * timeAbsent;
            double fullfill = fillPipe1 + fillPipe2;

            double realFill = 0;

            if (fullfill>volumePool)
            {
                realFill = fullfill - volumePool;
                Console.WriteLine($"For {timeAbsent:f2} hours the pool overflows with {realFill} liters.");
            }
            else
            {
                realFill = fullfill / volumePool * 100;
                double pipe1Percent = fillPipe1 / fullfill * 100;
                double pipe2Percent = fillPipe2 / fullfill * 100;
                Console.WriteLine($"The pool is {realFill}% full. Pipe 1: {pipe1Percent:f2}%. Pipe 2: {pipe2Percent:f2}%.");
            }
            
        }
    }
}
