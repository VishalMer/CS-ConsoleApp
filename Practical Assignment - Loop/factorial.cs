using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Practical_Assignment___Loop
{
    internal class factorial
    {
        public static void Main(string[] args)
        {
            int number, factorial = 1;

            Console.Write("Input the number: ");
            number = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("The Factorial of {0} is: {1}", number, factorial);
        }
    }
}
