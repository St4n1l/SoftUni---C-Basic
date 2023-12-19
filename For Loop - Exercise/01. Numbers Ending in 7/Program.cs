using System;

namespace _01.Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 1001; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}