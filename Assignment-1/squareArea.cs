using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCAA.Assignment_1
{
    internal class squareArea
    {
        static void Main(string[] args)
        {
            double a, area;

            Console.Write("Enter length to check area of square : ");
            a = Convert.ToDouble(Console.ReadLine());

            area = a * a;

            Console.WriteLine("Area of square is : " + area);
            Console.ReadKey();
        }
    }
}
