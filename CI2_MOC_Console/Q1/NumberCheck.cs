using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23FOTCA11030_Vishal.Q1
{
    internal class NumberCheck
    {
        static void Main()
        {
            Console.Write("Enter a number to chrck: ");
            int num = Convert.ToInt32(Console.ReadLine()); 

            if (num % 2 == 0) 
            {
                Console.WriteLine("The number is Even.");
            }
            else
            {
                Console.WriteLine("The number is Odd.");
            }
        }
    }
}
