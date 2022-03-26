using System;

namespace T08._Graduation
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();

            int classes = 1;
            double sumOfGrades = 0;
            int failCounter = 0;

            while (classes <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4)
                {
                    classes++;
                    sumOfGrades += grade;
                }
                else
                {
                    failCounter++;
                    if (failCounter ==2)
                    {
                        Console.WriteLine($"{name} has been excluded at {classes} grade");
                        return;
                    }
                }

            }
            double averageGrade = sumOfGrades / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}
