using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCA
{
    internal class prime
    {
        static void Main(string[] args)
        {
            int no;
            bool prime=true;

            Console.Write("Enter number to check : ");
            no = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= no / 2; i++)
            {
                if (no % i == 0)
                {
                    prime = false;
                }

            }
            if (prime)
            {
                Console.WriteLine("The number " + no + " is PRIME.");
            }
            else
            {
                Console.WriteLine("The number " + no + " is not PRIME.");
            }
        }
    }
}
