using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCAA.Others
{
    internal class @switch
    {
        static void Main(string[] args)
        {
            int java, iot, esl, cs, os, total, choice;
            double avg;

            void grade(int a)
            {
                if (a >= 90)
                {
                    Console.WriteLine("Grade : A ");
                }
                else if (a >= 80 && 90 > a)
                {
                    Console.WriteLine("Grade : B");
                }
                else if (a >= 70 && 80 > a)
                {
                    Console.WriteLine("Grade : C");
                }
                else if (a >= 40 && 70 > a)
                {
                    Console.WriteLine("Grade : D");
                }
                else if (a > 40)
                {
                    Console.WriteLine("FAIL!");
                }
            }

            Console.Write("Enter Marks Of JAVA: ");
            java = Int32.Parse(Console.ReadLine());

            Console.Write("Enter Marks Of IOT : ");
            iot = Int32.Parse(Console.ReadLine());

            Console.Write("Enter Marks Of ESL : ");
            esl = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Marks Of C# : ");
            cs = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Marks Of OS : ");
            os = Convert.ToInt16(Console.ReadLine());

            total = java + iot + esl + cs + os;
            avg = total / 5;



            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("0.Exit, 1.Java, 2.IOT, 3.C#, 4.ESL and 5.OS");
                Console.Write("Enter your choice(1-5), which Subject's grade you want to check : ");
                choice = Convert.ToInt16(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        grade(java);
                        break;
                    case 2:
                        grade(iot);
                        break;
                    case 3:
                        grade(cs);
                        break;
                    case 4:
                        grade(esl);
                        break;
                    case 5:
                        grade(os);
                        break;
                    case 0:
                        Console.WriteLine("Exiting the program...");
                        return; 
                    default:
                        Console.WriteLine("WRONG INPUT!!!");
                        break;
                }
            }
        }
    }
}
