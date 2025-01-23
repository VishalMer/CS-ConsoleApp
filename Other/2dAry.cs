using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCA
{
    internal class _2dAry
    {
        public static void Main(string[] args)
        {
            //Declaration and initialization of array
            //int[,] ary = { { 1, 2 }, { 3, 4 } };

            // OR

            //int[,] ary = new int[2, 2];
            //ary[0,0] = 1;
            //ary[0,1] = 2;
            //ary[1,0] = 3;
            //ary[1,1] = 4;

            // OR

            int[,] ary = new int[2, 2];

            Console.WriteLine("Enter elements for 2X2 array : ");
            for (int i = 0; i < ary.GetLength(0); i++)
            {
                for (int j = 0; j < ary.GetLength(1); j++)
                {
                    ary[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            //Display of the elements
            Console.WriteLine("Elements for 2X2 array : ");
            for (int i = 0; i < ary.GetLength(0); i++)
            {
                for (int j = 0; j < ary.GetLength(1); j++)
                {
                    Console.WriteLine(+ary[i,j]);
                }
            }
        }
    }
}
