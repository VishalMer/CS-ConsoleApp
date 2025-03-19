using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23FOTCA11030_Vishal.Q3
{
    internal class MathOperations
    {
        public static int Multiply(int a, int b)
        {
            int result = a * b; 
            return result;
        }

        static void Main()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int product = Multiply(num1, num2);
            Console.WriteLine("Product: " + product);
        }
    }
}


