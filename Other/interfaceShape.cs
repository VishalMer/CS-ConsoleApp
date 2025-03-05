using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Other
{
    interface sahpe
    {
        double getAera(double l, double h);
    }
    interface colour
    {
        double getColour(String c);
    }

    class rectangle : shape,colour
    {
        public double getArea(double l, double h)
        {
            return l * h;
        }
        public string getcoulor(string color)
        {
            return color;
        }
    }

    internal class interfaceShape
    {
        static void Main(string[] args)
        {
            rectangle r1 = new rectangle();
        }
    }
}
