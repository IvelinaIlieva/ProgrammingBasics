using System;

namespace T08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data:
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            //calculations:
            int totalExamTime = examHour * 60 + examMinutes;
            int totalArriveTime = arriveHour * 60 + arriveMinutes;
            int difference = 0;
            int diffHours = 0;
            int diffMinutes = 0;

            if (totalArriveTime==totalExamTime)
            {
                Console.WriteLine("On time");
            }
            else if (totalArriveTime > totalExamTime)
            {
                Console.WriteLine("Late");
                difference = totalArriveTime - totalExamTime;
                if (difference<60)
                {
                    diffMinutes = difference;
                    Console.WriteLine($"{diffMinutes} minutes after the start");
                }
                else
                {
                    diffHours = difference / 60;
                    diffMinutes = difference % 60;
                    Console.WriteLine($"{diffHours}:{diffMinutes:d2} hours after the start");
                }
            }
            else
            {
                difference = totalExamTime - totalArriveTime;
                if (difference <= 30)
                {
                    Console.WriteLine("On time");
                    diffMinutes = difference;
                    Console.WriteLine($"{diffMinutes} minutes before the start");
                }

                else if (difference<60)
                {
                    Console.WriteLine("Early");
                    diffMinutes = difference;
                    Console.WriteLine($"{diffMinutes} minutes before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    diffHours = difference / 60;
                    diffMinutes = difference % 60;
                    Console.WriteLine($"{diffHours}:{diffMinutes:d2} hours before the start");
                }
            }
        }
    }
}
