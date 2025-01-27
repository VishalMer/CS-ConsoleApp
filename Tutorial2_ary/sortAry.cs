using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Tutorial2_ary
{
    internal class sortAry
    {
        public static void Main(string[] args)
        {
            int[] array = new int[5];

            Console.WriteLine("Enter 5 integer values:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                array[i] = Int32.Parse(Console.ReadLine()); 
            }

            for (int i = 0; i < 5 - 1; i++) 
            {
                for (int j = 0; j < 5 - 1 - i; j++) 
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("The sorted array in ascending order is:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(array[i]); 
            }
        }
    }
}

