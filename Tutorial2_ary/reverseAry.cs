using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Tutorial2_ary
{
    internal class reverseAry
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of values you want to store in the array: ");
            int n = Int32.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter {0} integer values:", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                array[i] = Int32.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("The values in reverse order are:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]); 
            }
        }
    }
}
