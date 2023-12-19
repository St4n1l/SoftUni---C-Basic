using System;

namespace _01.Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string fav = Console.ReadLine();
            string input = Console.ReadLine();
            int counter = 0;
            bool isFound = false;

            while (input != "No More Books")
            {
                if (input == fav)
                {
                    isFound = true;
                    break;
                }
                counter++;
                input = Console.ReadLine();
            }
            if (isFound == true)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
