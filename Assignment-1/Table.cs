using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCAA.Assignment_1
{
    internal class Table
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter a number to print table : ");
            num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            if (num < 0)
            {
                Console.WriteLine("Number should be greater than 0.");
            }
            else
            {
                Console.WriteLine("Table of " + num + " is :");

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(num + " X " + i + " = " + num * i);
                }
            }
        }
    }
}
