using System;

namespace T02._Exam_Preparation
{
    class Program
    {
        static void Main()
        {
            int countOfBadGrades = int.Parse(Console.ReadLine());

            string nameOfProblem = "";
            int sumOfGrades = 0;
            int countOfGrades = 0;
            string nameOfLastProblem = "";
            int counter = 0;

            while (nameOfProblem != "Enough")
            {
                nameOfProblem = Console.ReadLine();

                if (nameOfProblem == "Enough")
                {
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                sumOfGrades += grade;
                countOfGrades++;

                if (grade <= 4)
                {
                    counter++;
                    if (counter == countOfBadGrades)
                    {
                        Console.WriteLine($"You need a break, {countOfBadGrades} poor grades.");
                        break;
                    }
                }
                nameOfLastProblem = nameOfProblem;
            }
            if (nameOfProblem == "Enough")
            {
                double averageGrade = 1.0 * sumOfGrades / countOfGrades;
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {countOfGrades}");
                Console.WriteLine($"Last problem: {nameOfLastProblem}");
            }
        }
    }
}
