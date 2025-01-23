using System;

namespace _4BCAA.Assignment_1
{
    internal class Fibonacci
    {
        static void Main()
        {
            int terms, first = 0, second = 1, next;

            Console.Write("Enter the number of terms for Fibonacci series: ");
            terms = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci Series:");

            for (int i = 0; i < terms; i++)
            {
                if (i == 0)
                {
                    next = first;
                }
                else if (i == 1)
                {
                    next = second;
                }
                else
                {
                    next = first + second;
                    first = second;
                    second = next;
                }
                Console.Write(next + " ");
            }

            Console.ReadLine();
        }
    }
}