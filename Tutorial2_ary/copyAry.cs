using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Tutorial2_ary
{
    internal class copyAry
    {
        public static void Main(string[] args)
        {
            int[] Array1 = new int[5];
            int[] Array2 = new int[5];

            Console.WriteLine("Enter 5 integer values:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                Array1[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Array2[i] = Array1[i];
            }

            Console.WriteLine("Elements in the new array:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Array2[i]);
            }
        }
    }
}

