using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.CI1_Demo
{
    internal class arithmatic
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add two numbers");
                Console.WriteLine("2. Subtract two numbers");
                Console.WriteLine("3. Multiply two numbers");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                if (choice == 4)
                    break;

                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("");
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Result: " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Result: " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Result: " + (num1 * num2));
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}


