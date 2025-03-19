using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23FOTCA11030_Vishal.Q3
{
    internal class PolymorphismDemo
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        static void Main()
        {
            PolymorphismDemo p1 = new PolymorphismDemo();
            Console.WriteLine("Addition of integer is : " + p1.Add(3, 4));
            Console.WriteLine("Addition of double is : " + p1.Add(3.5, 4.5));
        }
    }
}