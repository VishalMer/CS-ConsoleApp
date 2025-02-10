using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.CI1_Demo
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Enter Number 1 Value :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2 Value :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Before Swapping :");
            Console.WriteLine("Number 1 : " + num1);
            Console.WriteLine("Number 2 : " + num2);

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("");
            Console.WriteLine("After Swapping :");
            Console.WriteLine("Number 1 : " + num1);
            Console.WriteLine("Number 2 : " + num2);

        }
    }
}
