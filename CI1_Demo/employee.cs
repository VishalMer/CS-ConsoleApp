using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.CI1_Demo
{
    internal class employee
    {
        public string Name;
        public int EmployeeId;
        public decimal Salary;

        public decimal CalculateAnnualSalary()
        {
            return Salary * 12;
        }

        public void GiveRaise()
        {
            Salary += Salary * 0.10m;
        }
    }

    class emp1
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.Name = "VIshal";
            emp.EmployeeId = 21;
            emp.Salary = 10000;

            Console.WriteLine("Salary: " + emp.Salary);
            Console.WriteLine("Annual Salary: " + emp.CalculateAnnualSalary());
            emp.GiveRaise();
            Console.WriteLine("New Salary after raise: " + emp.Salary);

            Console.ReadKey();
        }
    }
}



