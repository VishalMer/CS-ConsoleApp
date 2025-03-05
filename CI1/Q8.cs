using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.CI1
{

    abstract class Shape
    {
        public abstract double CalcArea();
    }

    class Triangle : Shape
    {
        private double baseLength;
        private double height;

        public Triangle(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public override double CalcArea()
        {
            return 0.5 * baseLength * height;
        }
    }

    class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double CalcArea()
        {
            return side * side;
        }
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double CalcArea()
        {
            return length * width;
        }
    }

    internal class Q8
    {
        static void Main()
        {
            Shape triangle = new Triangle(10, 3);
            Shape square = new Square(3);
            Shape rectangle = new Rectangle(5, 9);

            Console.WriteLine("Triangle Area: " + triangle.CalcArea());
            Console.WriteLine("Square Area: " + square.CalcArea());
            Console.WriteLine("Rectangle Area: " + rectangle.CalcArea());

            Console.WriteLine();
            Console.WriteLine("En : 23FOTACA11030");
            Console.WriteLine("Name : Vishal Mer");
        }
    }
}

