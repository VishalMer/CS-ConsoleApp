using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCA
{
    internal class ary
    {
        public static void Main(string[] args)
        {
            //Array declaration
            int[] age = {10,20,13,24,51};

            // OR

            //int []age = new int[5];
            //age[0] = 10;
            //age[1] = 20;
            //age[2] = 13;
            //age[3] = 24;
            //age[4] = 51;

            age[0] = 05; //Updation of array element

            //Printing Array
            foreach (int i in age)
            {
                Console.WriteLine(i);
            }

            //OR 

            //for (int i = 0; i < age.Length; i++)
            //{
            //    Console.WriteLine("Age of " + (i+1) +" person is : " + age[i]);
            //}

            // OR   

            //Console.WriteLine("Age of first person is : " + age[0]);
            //Console.WriteLine("Age of second person is : " + age[1]);
            //Console.WriteLine("Age of third person is : " + age[2]);
            //Console.WriteLine("Age of fourth person is : " + age[3]);
            //Console.WriteLine("Age of fifth person is : " + age[4]);
        }
    }
}
