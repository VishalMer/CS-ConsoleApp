using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _4BCAA.Others
{
    public  class employee
    {
        int id,age;
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
    }

    class book1
    {
        public static void Main(string[] args)
        {          
            employee e1 = new employee();
            employee e2 = new employee();
            Console.WriteLine("Enter book 1 details : ");
            e1.getData();
            Console.WriteLine();

            Console.WriteLine("Enter book 2 details : ");
            e2.getData();
            Console.WriteLine();

            Console.WriteLine("Book 1 details : ");
            e1.showData();
            Console.WriteLine();

            Console.WriteLine("Book 2 details : ");
            e2.showData();
        }
    }
}
