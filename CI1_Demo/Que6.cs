using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.CI1_Demo
{
    internal class Que6
    {
        static void Main(string[] args)
        {
            int[] simpleArray = new int[] { 101, 201, 301, 401, 501 };

            for (int i = 0; i < simpleArray.Length; i++)
            {
                Console.WriteLine("The value is : " + simpleArray[i]);
            }

            Console.ReadKey();
        }
    }
}


