using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCA
{
    internal class ary2
    {
        public static void Main(string[] args)
        {
            int[] ary = new int[5];

            //Input of elements
            Console.WriteLine("Enter 5 elements : ");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int16.Parse(Console.ReadLine());
            }

            //display elements
            Console.WriteLine("Elements are : ");
            for (int i = 0; i < ary.Length; i++)
            {
                Console.WriteLine(ary[i]);
            }


            //Sum of elements
            double sum, avg;
            sum = ary.Sum();
            avg = ary.Average();

            // OR

            //for (int i = 0; i < ary.Length; i++)
            //{
            //    sum += ary[i];
            //}

            //avg = sum/ary.Length;


            //Check for minimum
            int min = ary[0];
            int max = ary[0];

            min = ary.Min();
            max = ary.Max();

            // OR

            //for (int i = 0;i < ary.Length; i++)
            //{
            //    if (min > ary[i])
            //    {
            //        min = ary[i];
            //    }

            //}

            Console.WriteLine(" Sum is : " + sum);
            Console.WriteLine(" Average is : " + avg);
            Console.WriteLine(" Minimum is : " + min);
            Console.WriteLine(" Maximum is : " + max);
            Console.WriteLine(" Number of elements are : " + ary.Count());

        }
    }
}
