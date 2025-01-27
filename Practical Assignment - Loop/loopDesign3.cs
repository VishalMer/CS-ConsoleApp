using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Practical_Assignment___Loop
{
    internal class loopDesign3
    {
        static void Main()
        {
            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
