using System;

namespace _04.Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double priceOfWash = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());


            double money = 0;


            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    money += i * 5 - 1;
                }
                else
                {
                    money += toyPrice;
                }

            }



            if (money >= priceOfWash)
            {
                Console.WriteLine($"Yes! {money - priceOfWash:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceOfWash - money:f2}");
            }
        }
    }
}