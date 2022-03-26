using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            //input:
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double temp = double.Parse(Console.ReadLine());

            double timeWithoutLate = distance*temp;
            double time = Math.Floor(distance / 15) * 12.5 + timeWithoutLate;
            double defference = Math.Abs(time - worldRecord);

            //print:
            Console.WriteLine(time<worldRecord ? $"Yes, he succeeded! The new world record is {time:f2} seconds.": $"No, he failed! He was {defference:f2} seconds slower.");

        }
    }
}
