using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Practical_Assignment___Loop
{
    internal class table
    {
        public static void Main(string[] args)
        {
            int number;
            Console.Write("Input the number for Table : ");
            number = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", number, i, number * i);
            }
        }
    }
}
