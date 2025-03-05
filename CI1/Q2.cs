using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.CI1
{
    internal class Q2
    {
        static void Main()
        {
            int[] ary = { 12, 3, 5, 7, 19, 1 };
            int max = ary[0];
            int min = ary[0];

            Console.WriteLine("array elements are : ");
            foreach (int num in ary)
            {
                Console.Write(num + " ");
            }

            foreach (int num in ary)
            {
                if (num > max)
                    max = num;
                if (num < min)
                    min = num;
            }

            Console.WriteLine();
            Console.WriteLine("Maximum is: " + max);
            Console.WriteLine("Minimum is: " + min);

            Console.WriteLine();
            Console.WriteLine("En : 23FOTACA11030");
            Console.WriteLine("Name : Vishal Mer");
        }

    }
}
