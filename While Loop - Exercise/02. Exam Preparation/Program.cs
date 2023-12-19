using System;

namespace _02.Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badMarks = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();



            double allMarks = 0;
            int problemCount = 0;
            int badMarksCounter = 0;
            string lastProblem = "";
            while (name != "Enough")
            {
                int mark = int.Parse(Console.ReadLine());

                if (mark <= 4)
                {
                    badMarksCounter++;
                }

                if (badMarksCounter == badMarks)
                {
                    Console.WriteLine($"You need a break, {badMarksCounter} poor grades.");
                    break;
                }

                lastProblem = name;
                problemCount++;
                allMarks += mark;
                name = Console.ReadLine();

            }

            if (name == "Enough")
            {
                Console.WriteLine($"Average score: {allMarks / problemCount:f2}");
                Console.WriteLine($"Number of problems: {problemCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
