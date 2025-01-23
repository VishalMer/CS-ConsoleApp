using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCA
{
    internal class leapYear
    {
        static void Main(string[] args)
        {
            int year;

            Console.Write("Enter year to check : ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year%4 == 0 || year % 400 == 0)
            {
                Console.WriteLine("Year "+year+ " is leap year.");
            }
            else
            {
                Console.WriteLine("Year " + year + " is  leap year.");
            }
        }
    }
}
