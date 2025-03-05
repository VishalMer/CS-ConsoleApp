using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.CI1
{
    internal class Q5
    {
        static void Main()
        {
            int Choose;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Personal Information");
                Console.WriteLine("2. Academic Information");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                Choose = int.Parse(Console.ReadLine());

                switch (Choose)
                {
                    case 1:
                        Console.WriteLine("Personal Information: Name : Vishal Mer, Age : 20");
                        break;
                    case 2:
                        Console.WriteLine("Academic Information: En : 23FOTCA11030, BCA-A, Roll - 21 ");
                        break;
                    case 3:
                        Console.WriteLine("Exited");
                        break;
                    default:
                        Console.WriteLine("Invalid option!!");
                        break;
                }

                Console.WriteLine("");

            } while (Choose != 3);
        }

    }
}
