using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_P1.Other;

namespace Console_P1.Other
{
    public delegate int UpdateNo(int n);

    public class Test
    {
        private int no;

        public Test(int no)
        {
            this.no = no;
        }

        public int AddNumber(int n)
        {
            no += n;
            return no;
        }

        public int MulNumber(int n)
        {
            no *= n;
            return no;
        }

        public int GetNumber()
        {
            return no;
        }
    }

    internal class DelegateDemo
    {
        static void Main(string[] args)
        {
            Test t = new Test(10);
            Console.WriteLine("Actual number : " + t.GetNumber());

            UpdateNo add = new UpdateNo(t.AddNumber);
            UpdateNo mul = new UpdateNo(t.MulNumber);
            
            //add(20);
            //Console.WriteLine("After addition : " + t.GetNumber());

            //mul(5);
            //Console.WriteLine("After multiplication : " + t.GetNumber());

            UpdateNo comb = add + mul;
            comb(5);
            Console.WriteLine("Final number : " + t.GetNumber());
        }
    }
}
