using System;

namespace T04._Walking
{
    class Program
    {
        static void Main()
        {
            const int GOAL_STEPS = 10000;

            string currentSteps = "";
            int sumSteps = 0;
            int currSteps = 0;

            while (sumSteps < GOAL_STEPS)
            {
                currentSteps = Console.ReadLine();                

                if (currentSteps == "Going home")
                {
                    currentSteps = Console.ReadLine();
                    currSteps = int.Parse(currentSteps);
                    sumSteps += currSteps;
                    break;
                }
                currSteps = int.Parse(currentSteps);
                sumSteps += currSteps;
            }
            if (sumSteps >= GOAL_STEPS)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{sumSteps - GOAL_STEPS} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(sumSteps - GOAL_STEPS)} more steps to reach goal.");
            }
        }
    }
}
