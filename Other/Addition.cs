using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _4BCA
{
    internal class Addition
    {
        static void Main(string[] args)
        {
            int no1,no2,Addition, subtraction, multiplication, division;

            Console.Write("Enter First Number : ");
            no1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            no2 = Int32.Parse(Console.ReadLine());

            Addition = no1+no2;
            subtraction = no1 - no2;
            multiplication = no1 * no2;
            division = no1 / no2;


            Console.WriteLine("Addition is : " + Addition);
            Console.WriteLine("Subtraction is : " + subtraction);
            Console.WriteLine("Multiplication is : " + multiplication);
            Console.WriteLine("Division is : " + division);
        }
    }
}
