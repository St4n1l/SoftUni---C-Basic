using System;

namespace _07.Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            int all = 0;
            for (int i = 0; i < groups; i++)
            {
                int numberOfPeople = int.Parse(Console.ReadLine());
                all += numberOfPeople;
                if (numberOfPeople <= 5)
                {
                    p1 += numberOfPeople;
                }
                else if (numberOfPeople >= 6 && numberOfPeople <= 12)
                {
                    p2 += numberOfPeople;
                }
                else if (numberOfPeople >= 13 && numberOfPeople <= 25)
                {
                    p3 += numberOfPeople;
                }
                else if (numberOfPeople >= 26 && numberOfPeople <= 40)
                {
                    p4 += numberOfPeople;
                }
                else
                {
                    p5 += numberOfPeople;
                }
            }

            Console.WriteLine($"{p1 / all * 100:f2}%");
            Console.WriteLine($"{p2 / all * 100:f2}%");
            Console.WriteLine($"{p3 / all * 100:f2}%");
            Console.WriteLine($"{p4 / all * 100:f2}%");
            Console.WriteLine($"{p5 / all * 100:f2}%");

        }
    }
}
