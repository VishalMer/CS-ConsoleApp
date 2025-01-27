using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1
{
    internal class forloop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers between 1 to 50 is :");
            for (int i=1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
