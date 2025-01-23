using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCA
{
    internal class result
    {
        static void Main(string[] args)
        {
            int s1, s2, s3,s4,s5,total;
            double avg;

            Console.Write("Enter First Subject Marks : ");
            s1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter Second Subject Marks : ");
            s2 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter Third Subject Marks : ");
            s3 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter fourth Subject Marks : ");
            s4 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter fifth Subject Marks : ");
            s5 = Convert.ToInt16(Console.ReadLine());

            total = s1+s2+s3 + s4 + s5;
            avg = total/5;

            if (avg>=95)
            {
                Console.WriteLine("your grade is 'A+', Average is : " + avg);
            }
            else if (avg>=90)
            {
                Console.WriteLine("your grade is 'A', Average is : " + avg);
            }
            else if(avg>=80)
            {
                Console.WriteLine("your grade is 'B', Average is : " + avg);
            }
            else if (avg >= 60)
            {
                Console.WriteLine("your grade is 'C', Average is : " + avg);
            }
            else if (avg >= 40)
            {
                Console.WriteLine("your grade is 'D', Average is : " + avg);
            }
            else if (avg < 40)
            {
                Console.WriteLine("your are 'FAILED', Average is : " + avg);
            }

        }
    }
}
