using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.CI1
{
    internal class Q3
    {
        static void Main()
        {
            int term, a = 0, b = 1;

            Console.Write("Enter Number for terms :");
            term = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci Series:");
            for (int i = 0; i < term; i++)
            {
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("En : 23FOTACA11030");
            Console.WriteLine("Name : Vishal Mer");
        }
    }
}
