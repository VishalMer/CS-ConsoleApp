using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCA
{
    internal class maximum
    {
        static void Main(string[] args)
        {
            int no1, no2, no3;

            Console.Write("Enter First Number : ");
            no1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            no2 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter Third Number : ");
            no3 = Convert.ToInt16(Console.ReadLine());


            if (no1 > no2 && no1>no3)
            {
                Console.WriteLine("The number " + no1 + " is largest.");
            }
            else if (no2 > no3 && no2 > no1)
            {
                Console.WriteLine("The number " + no2 + " is largest.");
            }
            else
            {
                Console.WriteLine("The number " + no3 + " is largest.");
            }

        }
    }
}
