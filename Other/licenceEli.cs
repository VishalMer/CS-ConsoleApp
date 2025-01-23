using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCA
{
    internal class licenceEli
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("Enter age to check : ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Your age is " + age + ", so you're eligible for license.");
            }
            else
            {
                Console.WriteLine("Your age is " + age + ", so you're not eligible for license.");
            }
        }
    }
}
