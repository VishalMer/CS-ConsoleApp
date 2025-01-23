using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCAA.Assignment_1
{
    internal class evenOdd
    {
        static void Main(string[] args)
        {
            int no;

            Console.Write("Enter no to check : ");
            no = Convert.ToInt32(Console.ReadLine());

            if (no % 2 == 0)
            {
                Console.WriteLine("The number " + no + " is EVEN.");
            }
            else
            {
                Console.WriteLine("The number " + no + " is ODD.");
            }
        }
    }
}
