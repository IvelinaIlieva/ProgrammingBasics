using System;

namespace T04._Train_The_Trainers
{
    class Program
    {
        static void Main()
        {
            int countOfJury = int.Parse(Console.ReadLine());

            string input = Console.ReadLine(); ;
            double sumOfGradesOfOnePresentations = 0;
            double sumOfGrades = 0;
            int countOfGrades = 0;

            while (input != "Finish")
            {                
                for (int i = 1; i <= countOfJury; i++)
                {
                    double grades = double.Parse(Console.ReadLine());
                    sumOfGradesOfOnePresentations += grades;
                    sumOfGrades += grades;
                    countOfGrades++;
                }
                double averageGradesForPresentation = sumOfGradesOfOnePresentations / countOfJury;
                Console.WriteLine($"{input} - {averageGradesForPresentation:f2}.");
                sumOfGradesOfOnePresentations = 0;

                input = Console.ReadLine();
            }
            double averageAllGrades = sumOfGrades / countOfGrades;
            Console.WriteLine($"Student's final assessment is {averageAllGrades:f2}.");
        }
    }
}
