using System;

namespace Console_P1.CI1_Demo
{
    internal class Student
    {
        string name = "Vishal";
        string city = "Amreli";
        int age = 20;

        public void PrintData()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Age: " + age);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.PrintData();
        }
    }
}