using System;

namespace P04._Exam
{
    class Program
    {
        static void Main()
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            int topStudentsCounter = 0;
            int goodStudentsCounter = 0;
            int middleStudentsCounter = 0;
            int failStudentsCounter = 0;
            double totalGradeSum = 0;

            for (int i = 1; i <= countOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 5)
                {
                    topStudentsCounter++;
                    totalGradeSum += grade;
                }
                else if (grade >= 4)
                {
                    goodStudentsCounter++;
                    totalGradeSum += grade;
                }
                else if (grade >= 3)
                {
                    middleStudentsCounter++;
                    totalGradeSum += grade;
                }
                else
                {
                    failStudentsCounter++;
                    totalGradeSum += grade;
                }
            }
            Console.WriteLine($"Top students: {(double)topStudentsCounter/countOfStudents*100 :f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(double)goodStudentsCounter/countOfStudents*100.0:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(double)middleStudentsCounter/countOfStudents*100.0:f2}%");
            Console.WriteLine($"Fail: {(double)failStudentsCounter/countOfStudents*100.0:f2}%");
            Console.WriteLine($"Average: {totalGradeSum / countOfStudents:f2}");
        }
    }
}
