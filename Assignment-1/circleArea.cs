using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCAA.Assignment_1
{
    internal class circleArea
    {
        static void Main(string[] args)
        {
            double r,area;

            Console.Write("Enter radious to check area of circle : ");
            r = Convert.ToDouble(Console.ReadLine());

            area = 3.14 * r * r;

            Console.WriteLine("Area of circle is : "+ area );
            Console.ReadKey();
        }
    }
}
