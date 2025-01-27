using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Tutorial2_ary
{
    internal class deleteEle
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

            Console.Write("Enter the position to delete (1 to 5): ");
            int pos = Int32.Parse(Console.ReadLine());
            if (pos < 1 || pos > 5)
            {
                Console.WriteLine("Invalid position.");
            }

            for (int i = pos - 1; i < 4; i++)
            {
                array[i] = array[i + 1];
            }

            Array.Resize(ref array, 4);

            Console.WriteLine("Array after deleted element :");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
