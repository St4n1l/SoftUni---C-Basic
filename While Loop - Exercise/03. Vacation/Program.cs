using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());

            string saveOrSpend = "";
            double actualMoney = money;
            int dayCount = 0;
            int spendCount = 0;
            while (needMoney >= actualMoney)
            {
                saveOrSpend = Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                dayCount++;

                if (saveOrSpend == "save")
                {
                    spendCount = 0;
                    actualMoney += money;
                }
                else
                {
                    spendCount++;
                    actualMoney -= money;
                }

                if (spendCount == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{dayCount}");
                    break;
                }

                if (actualMoney < 0)
                {
                    actualMoney = 0;
                }

                if (actualMoney >= needMoney)
                {
                    Console.WriteLine($"You saved the money for {dayCount} days.");
                    return;
                }

            }

        }
    }
}
