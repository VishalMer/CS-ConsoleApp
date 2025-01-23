using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCAA.Assignment_1
{
    internal class secToMinHr
    {
        static void Main()
        {
            int seconds;
            double minutes, hours;

            Console.WriteLine("Seconds Converter");
            Console.Write("Enter seconds to convert in minutes & hrs : ");

            seconds = Convert.ToInt32(Console.ReadLine());

            if (seconds < 0)
            {
                Console.WriteLine("Invalid input, please enter number which is greater than 0.");
            }
            else
            {
                minutes = seconds / 60;
                hours = minutes / 60;

                Console.WriteLine(seconds + " seconds in minutes is : " + minutes);
                Console.WriteLine(seconds + " seconds or " + minutes + " minutes in hours is : " + hours);
            }
        }

    }
}
