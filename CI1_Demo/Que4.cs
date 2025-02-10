using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.CI1_Demo
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[2, 3, 4];
            Console.WriteLine("The value at array[0,0,0]: " + array[0, 0, 0]);
            Console.ReadKey();
        }
    }
}
