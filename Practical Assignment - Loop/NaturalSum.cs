using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Practical_Assignment___Loop
{
    internal class NaturalSum
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("The first 10 natural number is :");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }
            Console.WriteLine("\nThe Sum is : " + sum);
        }
    }
}
