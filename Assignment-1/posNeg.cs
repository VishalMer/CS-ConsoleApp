using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCAA.Assignment_1
{
    internal class posNeg
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter number to check : ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("The number is 0.");
            }
            else if (num < 0)
            {
                Console.WriteLine("The number " + num + " is NEGATIVE.");
            }
            else
            {
                Console.WriteLine("The number " + num + " is POSITIVE.");
            }
        }
    }
}
