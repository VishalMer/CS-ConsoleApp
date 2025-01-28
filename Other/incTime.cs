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
            int sec;
            int min;
            int hr;
            string t = "";

            public Time()
            {

                Console.Write("Enter the hour : ");
                hr = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the minute : ");
                min = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second : ");
                sec = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                Console.WriteLine("Current time is : " + hr + ":" + min + ":" + sec);

                Console.WriteLine();


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
                    }
                }

                return t = hr + ":" + min + ":" + sec;

                //Console.WriteLine("Time is : " + t);

            }


            static void Main(string[] args)
            {

                Time t1 = new Time();

                string incTime = t1.increment();

                Console.WriteLine("New time is : " + incTime);

                Console.ReadLine();

            }

        }
    }
}


