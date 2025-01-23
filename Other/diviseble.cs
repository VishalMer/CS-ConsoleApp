using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCA
{
    internal class diviseble
    {
        static void Main(string[] args)
        {
            int no;

            Console.Write("Enter no to check : ");
            no = Convert.ToInt16(Console.ReadLine());

            if (no%3 == 0 && no % 5 != 0)
            {
                Console.WriteLine("The number " + no + " is divided by 3.");
            }
            else if (no%5 == 0 && no%3 != 0)
            {
                Console.WriteLine("The number " + no + " is divided by 5.");
            }
            else if (no % 3 == 0 && no % 5 == 0)
            {
                Console.WriteLine("The number " + no + " is divided by both 5 & 3.");
            }
            else
            {
                Console.WriteLine("The number " + no + " is not divided by both 5 & 3.");
            }
        }
    }
}
