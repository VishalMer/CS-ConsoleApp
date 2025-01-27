using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Tutorial2_ary
{
    internal class maxMinAry
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter {0} integer values:", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                array[i] = Int32.Parse(Console.ReadLine());
            }
            int max = array[0];
            int min = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
            Console.WriteLine("Maximum element: " + max);
            Console.WriteLine("Minimum element: " + min);
        }
    }
}
