using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Tutorial2_ary
{
    internal class countDuplicate
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

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Number of duplicate elements: " + count);
        }
    }
}
