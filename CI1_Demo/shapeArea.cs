using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.CI1_Demo
{
    internal class shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
    }

    class Circle : shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle : shape
    {
        private double width;
        private double height;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public override double CalculateArea()
        {
            return width * height;
        }
    }

    class Triangle : shape
    {
        private double baseLength;
        private double height;

        public Triangle(double b, double h)
        {
            baseLength = b;
            height = h;
        }

        public override double CalculateArea()
        {
            return 0.5 * baseLength * height;
        }
    }

    class shapeArea
    {
        static void Main(string[] args)
        {
            shape circle = new Circle(5);
            shape rectangle = new Rectangle(4, 6);
            shape triangle = new Triangle(3, 4);

            Console.WriteLine("Circle Area: " + circle.CalculateArea());
            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
            Console.WriteLine("Triangle Area: " + triangle.CalculateArea());

            Console.ReadKey();
        }
    }
}



