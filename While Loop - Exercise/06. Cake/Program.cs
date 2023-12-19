using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int fullCake = lenght * width;

            while (input != "STOP")
            {
                fullCake -= int.Parse(input);

                if (fullCake <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(fullCake)} pieces more.");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{Math.Abs(fullCake)} pieces are left.");

        }
    }
}
