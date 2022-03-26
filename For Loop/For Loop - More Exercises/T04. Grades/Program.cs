using System;

namespace T04._Grades
{
    class Program
    {
        static void Main()
        {
            //input data:
            int countOfStudents = int.Parse(Console.ReadLine());

            //calculations:
            int excellent = 0;
            int good = 0;
            int medium = 0;
            int failed = 0;
            double averageGrade = 0;
            double sumGrade = 0;

            for (int i = 1; i <= countOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 3)
                {
                    failed++;
                    sumGrade += grade;
                }
                else if (grade < 4)
                {
                    medium++;
                    sumGrade += grade;
                }
                else if (grade < 5)
                {
                    good++;
                    sumGrade += grade;
                }
                else
                {
                    excellent++;
                    sumGrade += grade;
                }
                averageGrade = sumGrade / countOfStudents;
            }
            double percentExcellent = 1.0 * excellent / countOfStudents * 100;
            double percentGood = 1.0 * good / countOfStudents * 100;
            double percentMedium = 1.0 * medium / countOfStudents * 100;
            double persentFailed = 1.0 * failed / countOfStudents * 100;

            //print:
            Console.WriteLine($"Top students: {percentExcellent:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentGood:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentMedium:f2}%");
            Console.WriteLine($"Fail: {persentFailed:f2}%");
            Console.WriteLine($"Average: {averageGrade:f2}");           
        }
    }
}
