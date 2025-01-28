using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Console_P1.Other
{

    public class student
    {
        string name;
        int rollno;
        int cgpa;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Rollno
        {
            get { return rollno; }
            set { rollno = value; }
        }
        public int Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public void display()
        {
            Console.WriteLine(rollno + "\t" + name + "\t" + cgpa);
        }
    }

    class propertyDemo
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            student s2 = new student();
            student s3 = new student();

            s1.Rollno = 1;
            s1.Name = "ABC";
            s1.Cgpa = 9;
            s2.Rollno = 2;
            s2.Name = "BCD";
            s2.Cgpa = 8;
            s3.Rollno = 3;
            s3.Name = "CDE";
            s3.Cgpa = 6;
            Console.WriteLine("Roll No" + "\t" + "Name" + "\t" + "Cgpa");
            s1.display();
            s2.display();
            s3.display();

        }
    }
}
