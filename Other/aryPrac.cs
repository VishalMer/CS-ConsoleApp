using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Other
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            int [,]ary = new int[2,3];

            for (int i = 0; i<2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter ary element " + [i,j]+" : ");
                    ary[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Element " + [i, j] + " is : " + ary[i,j]);
                }
            }
        }


    }
}
