using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Other
{
    internal class incTime
    {
        public class Time
        {
            int sec, min, hr;
            string t = "";
            bool display = true;

            public Time()
            {
                Console.Write("Enter the hour : ");
                hr = Convert.ToInt32(Console.ReadLine());
                if (hr < 0 || hr > 23)
                {
                    message("hour! Enter in (0-23).");
                    return;
                }

                Console.Write("Enter the minute : ");
                min = Convert.ToInt32(Console.ReadLine());
                if (min < 0 || min > 59)
                {
                    message("minute! Enter in (0-59).");
                    return;
                }

                Console.Write("Enter the second : ");
                sec = Convert.ToInt32(Console.ReadLine());
                if (sec < 0 || sec > 59)
                {
                    message("seconds! Enter in (0-59).");
                    return;
                }

                Console.WriteLine("");

                if (display)
                {
                    Console.WriteLine("Entered time is : " + hr + ":" + min + ":" + sec);
                }

                Console.WriteLine();

            }

            public void message(string variable)
            {
                display = false;
                Console.WriteLine("Invalid format of " + variable);
            }

            string increment()
            {
                sec = sec + 1;

                if (sec >= 60)
                {
                    sec = 0;
                    min = min + 1;

                    if (min >= 60)
                    {
                        hr = hr + 1;
                        min = 0;
                        if (hr > 24)
                        {
                            hr = 0;
                        }
                    }
                }

                return t = hr + ":" + min + ":" + sec;
            }

            static void Main(string[] args)
            {

                Time t1 = new Time();

                string incTime = t1.increment();

                if (t1.display)
                {
                    Console.WriteLine("New time is : " + incTime);
                }

            }

        }
    }
}


