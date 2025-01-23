using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCA
{
    internal class additonAry
    {
        public static void Main(string[] args)
        {
            //Declaration and of array
            int[,] ary1 = new int[2, 2];
            int[,] ary2 = new int[2, 2];
            int[,] ary3 = new int[2, 2];


            Console.WriteLine("Enter elements for first 2X2 array : ");
            for (int i = 0; i < ary1.GetLength(0); i++)
            {
                for (int j = 0; j < ary1.GetLength(1); j++)
                {
                    ary1[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements for second 2X2 array : ");
            for (int i = 0; i < ary2.GetLength(0); i++)
            {
                for (int j = 0; j < ary2.GetLength(1); j++)
                {
                    ary2[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < ary3.GetLength(0); i++)
            {
                for (int j = 0; j < ary3.GetLength(1); j++)
                {
                    ary3[i, j] = ary1[i, j] + ary2[i, j];
                }
            }

            //Display of the elements
            Console.WriteLine("Elements for 2X2 array : ");
            for (int i = 0; i < ary3.GetLength(0); i++)
            {
                for (int j = 0; j < ary3.GetLength(1); j++)
                {
                    Console.WriteLine(+ary3[i, j]);
                }
            }
        }
    }
}
