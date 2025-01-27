using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1
{
    internal class factorial
    {
        static void Main(string[] args)
        {
            int num, fact=1;
            Console.Write("Enter a number to find factorial : ");
            num = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of " + num + " is :" + fact);
        }
    }
}
