using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Other
{
    public abstract class shape
    {
        double length;
        double height;

        public shape (double length, double height)
        {
            this.length = length;
            this.height = height;
        }
        public double getLength() { return length;}
        public double getHeight() { return height;}
        public abstract double getArea();
    }
    public class Rectangle : shape
    {
        public Rectangle(double length, double height) : base(length, height) { }
        public override double getArea()
        {
            return (getLength() * getHeight());
        }
    }
    internal class Abstraction
    {
        static void Main(string[] args)
            {
                shape s1 = new Rectangle(3.2,5.4);
                Console.WriteLine("Area of rectangle is : " + s1.getArea());
            }
    }
}
