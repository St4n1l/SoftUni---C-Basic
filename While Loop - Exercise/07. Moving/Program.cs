using System;

namespace _07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string input = "";
            int roomSpace = width * lenght * height;
            int all = 0;

            while (input != "Done")
            {
                input = Console.ReadLine();


                if (input != "Done")
                {
                    all += int.Parse(input);
                }


                if (roomSpace < all)
                {
                    Console.WriteLine($"No more free space! You need {all - roomSpace} Cubic meters more.");
                    return;
                }
            }
            Console.WriteLine($"{roomSpace - all} Cubic meters left.");
        }
    }
}
