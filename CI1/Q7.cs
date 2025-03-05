using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.CI1
{
    internal class Q7
    {
        class Employee
        {
            public string Name { get; set; }
            public double BasicPay { get; set; }
            public int Experience { get; set; }

            public double calcbonus()
            {
                if (Experience < 3)
                    return BasicPay * 0.05;
                else if (Experience >= 3 && Experience < 7)
                    return BasicPay * 0.10;
                else
                    return BasicPay * 0.15;
            }

            public void DisplaySalary()
            {
                double bonus = calcbonus();
                double totalEarnings = BasicPay + bonus;
                Console.WriteLine("Name : "+Name+", Exp :"+ Experience + ", Bonus : "+bonus+", Total Salary : " +totalEarnings);
            }
        }

        internal class Q7
        {
            static void Main()
            {
                Employee emp1 = new Employee() { Name = "Vishal", BasicPay = 50000, Experience = 2 };
                Employee emp2 = new Employee() { Name = "rahul", BasicPay = 60000, Experience = 5 };

                emp1.DisplaySalary();
                emp2.DisplaySalary();

                Console.WriteLine();
                Console.WriteLine("En : 23FOTACA11030");
                Console.WriteLine("Name : Vishal Mer");
            }

        }
    }
}
