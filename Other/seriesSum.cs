using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCA
{
    internal class seriesSum
    {
        public static void Main(string[] args)
        {
            int num,sum=0;

            //Input of element
            Console.Write("Enter the number : ");
            num = Int16.Parse(Console.ReadLine());

            for (int i = 0; i <=num; i++)
            {
                sum += i;
            }

            Console.WriteLine(" Sum of "+ num +" numbers is : " + sum);

        }
    }
}
