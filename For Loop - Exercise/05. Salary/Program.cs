using System;

namespace _05.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());


            int penalty = 0;


            for (int i = 0; i < openTabs; i++)
            {
                string tab = Console.ReadLine();

                if (tab == "Facebook")
                {
                    penalty += 150;
                }
                else if (tab == "Instagram")
                {
                    penalty += 100;
                }
                else if (tab == "Reddit")
                {
                    penalty += 50;
                }

                if (salary - penalty <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }


            }



            if (salary - penalty > 0)
            {

                Console.WriteLine($"{salary - penalty}");
            }


        }
    }
}
