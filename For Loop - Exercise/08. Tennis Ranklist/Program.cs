using System;

namespace _08.Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int points = 0;
            double won = 0;
            for (int i = 0; i < n; i++)
            {
                string f = Console.ReadLine();

                if (f == "W")
                {
                    points += 2000;
                    won++;
                }
                else if (f == "F")
                {
                    points += 1200;
                }
                else if (f == "SF")
                {
                    points += 720;
                }
            }
            Console.WriteLine($"Final points: {points + startingPoints}");
            Console.WriteLine($"Average points: {points / n}");
            Console.WriteLine($"{(won / n) * 100:f2}%");
        }

    }
}
