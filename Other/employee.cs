using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _4BCAA.Others
{
    public class employee
    {
        int id, age;
        double salary;
        string name;

        public void getData()
        {
            Console.Write("Enter employee id : ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter employee name : ");
            name = Console.ReadLine();

            Console.Write("Enter employee age : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter employee salary : ");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public void showData()
        {
            Console.WriteLine("id of the employee is : " + id);
            Console.WriteLine("name of the employee is : " + name);
            Console.WriteLine("age of the employee is : " + age);
            Console.WriteLine("salary of the employee is : " + salary);

        }

        public int getAge()
        {
            return age;
        }

        public string getName()
        {
            return name;
        }
    }

    class employee2
    {
        public static void Main(string[] args)
        {
            employee e1 = new employee();
            employee e2 = new employee();
            Console.WriteLine("Enter employee 1 details : ");
            e1.getData();
            Console.WriteLine();

            Console.WriteLine("Enter employee 2 details : ");
            e2.getData();
            Console.WriteLine();

            Console.WriteLine("Employee 1 details : ");
            e1.showData();
            Console.WriteLine();

            Console.WriteLine("Employee 2 details : ");
            e2.showData();
            Console.WriteLine();


            if (e1.getAge() > e2.getAge())
            {
                Console.WriteLine(e1.getName() + " is older.");
            }
            else
            {
                Console.WriteLine(e2.getName() + " is older.");
            }
        }
    }
}
