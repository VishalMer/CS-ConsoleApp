using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Other
{
    public delegate void ShowDateTime(); // Delegate declaration

    public class Test // Class names should be capitalized by convention.
    {
        public void ShowDate() // Method to show date.
        {
            Console.WriteLine("Current Date is: " + DateTime.Now.ToShortDateString());
        }

        public void ShowTime() // Method to show time.
        {
            Console.WriteLine("Current Time is: " + DateTime.Now.ToShortTimeString());
        }
    }

    class DelDateTime // Main class should also be declared.
    {
        public static void Main(string[] args) // Main method.
        {
            Test t = new Test(); // Instance of Test class.
            ShowDateTime showDateTime;

            showDateTime = new ShowDateTime(t.ShowDate); // Assign the method to the delegate.
            showDateTime(); // Invoke the delegate.

            showDateTime = new ShowDateTime(t.ShowTime); // Assign another method to the delegate.
            showDateTime(); // Invoke the delegate.
        }
    }
}


