using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Other
{
    public delegate void ShowDateTime();

    public class test
    {
        public void showDate()
        {
            Console.WriteLine("Current Date is : " + DateTime.Now.ToShortDateString());
        }

        public void showTime()
        {
            Console.WriteLine("Current Time is : " + DateTime.Now.ToShortTimeString());
        }
}
    public static void Main(string[] args)
        {
            test t = new test();
            ShowDateTime showDateTime = new ShowDateTime(t.showDate);
            showDateTime();


            showDateTime = new ShowDateTime(t.showTime);
            showDateTime();

        }
    }



