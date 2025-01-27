using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1
{
    internal class ary
    {
        public static void Main(string[] args)
        {
            int[] ary = new int[10];
            Console.WriteLine("Enter 10 elements to store in array :");

            for(int i = 0; i < 10; i++)
            {
                Console.Write("Enter element {0} : ",(i+1));
                ary[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter element are : ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(ary[i]+" ");
            }
        }
    }
}
