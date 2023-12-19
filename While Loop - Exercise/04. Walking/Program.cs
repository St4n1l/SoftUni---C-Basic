using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededSteps = 10000;
            double actualSteps = 0;
            while (actualSteps < neededSteps)
            {
                string steps = Console.ReadLine();

                if (steps != "Going home")
                {
                    actualSteps += Convert.ToDouble(steps);
                }
                else if (steps == "Going home")
                {
                    steps = Console.ReadLine();
                    actualSteps += Convert.ToDouble(steps);
                    if (actualSteps < neededSteps)
                    {
                        Console.WriteLine($"{neededSteps - actualSteps} more steps to reach goal.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{actualSteps - neededSteps} steps over the goal!");
                        return;
                    }
                }

                if (actualSteps >= neededSteps)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{actualSteps - neededSteps} steps over the goal!");
                    return;
                }
            }
        }
    }
}
