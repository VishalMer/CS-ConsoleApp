using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Other
{
    public interface A
    {
        void myMethod();
    }

    public class Test : A
    {
        public void myMethod()
        {
            Console.WriteLine("This is interface - A Method");
        }
    }
    internal class interfaceDemo
    {
        static void Main()
        {
            A ob = new Test();
            ob.myMethod();
        }
    }
}
