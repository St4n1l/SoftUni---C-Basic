using System;

namespace _02.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (max < num)
                {
                    max = num;

                }


            }

            int sumwith = sum - max;

            if (sumwith != max)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumwith - max)}");
            }
            else
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }

        }
    }
}