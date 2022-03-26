using System;

namespace T05._Salary
{
    class Program
    {
        static void Main()
        {
            const double FACEBOOK_FORFEIT = 150;
            const double INSTAGRAM_FORFEIT = 100;
            const double REDDIT_FORFEIT = 50;

            //input data:
            int openedTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            //calculations:
            for (int i = 0; i <= openedTabs; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                string tabname = Console.ReadLine();
                switch (tabname)
                {
                    case "Facebook":
                        salary -= FACEBOOK_FORFEIT;
                        break;
                    case "Instagram":
                        salary -= INSTAGRAM_FORFEIT;
                        break;
                    case "Reddit":
                        salary -= REDDIT_FORFEIT;
                        break;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
