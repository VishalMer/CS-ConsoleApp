using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCAA.Assignment_1
{
    internal class result
    {
        static void Main(string[] args)
        {
            int s1, s2, s3, total;
            double avg;

            Console.Write("Enter First Subject Marks : ");
            s1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter Second Subject Marks : ");
            s2 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter Third Subject Marks : ");
            s3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            total = s1 + s2 + s3;
            avg = total / 3;
            Console.WriteLine("Your First Subject Marks : " + s1);
            Console.WriteLine("Your Second Subject Marks : " + s2);
            Console.WriteLine("Your Third Subject Marks : " + s3);
            Console.WriteLine();

            Console.WriteLine("Your total of marks is : " + total);
            Console.WriteLine("Your average is : " + avg);
            Console.WriteLine("Your percentage is : " + avg);
        }
    }
}
