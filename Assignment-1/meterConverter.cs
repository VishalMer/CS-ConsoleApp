using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCAA.Assignment_1
{
    internal class meterConverter
    {
        static void Main()
        {
            Console.WriteLine("Unit Converter");
            Console.WriteLine("1. Millimeter to Centimeter");
            Console.WriteLine("2. Meter to Kilometer");
            Console.Write("Select an option 1 or 2: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice != 1 && choice != 2)
            {
                Console.WriteLine("Invalid input, please select between 1-2");
            }

            if (choice == 1)
            {
                Console.Write("Enter length in millimeters: ");
                double millimeters = Convert.ToDouble(Console.ReadLine());
                if (millimeters < 0)
                {
                    Console.WriteLine("Invalid input, please enter number which is greater than 0.");
                }
                double centimeters = millimeters / 10;
                Console.WriteLine(millimeters + "mm is equal to " + centimeters + "cm");
            }
            else if (choice == 2)
            {
                Console.Write("Enter length in meters: ");
                double meters = Convert.ToDouble(Console.ReadLine());
                if (meters < 0)
                {
                    Console.WriteLine("Invalid input, please enter number which is greater than 0.");
                }
                double kilometers = meters / 1000;
                Console.WriteLine(meters + "m is equal to " + kilometers + "km");
            }
        }

    }
}
