using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1.Other
{
    public class Time
    {
        int hour, minute, second;
        string time;

        public Time(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }

        void increment()
        {
            second++;
            if (second >= 60)
            {
                second = 0;
                minute++;
                if (minute >= 60)
                {
                    minute = 0;
                    hour++;
                    if (hour >= 24)
                    {
                        hour = 0;
                    }
                }
            }
        }

        public void DisplayTime()
        {
            time = (hour + ":" + minute + ":" + second);
            Console.WriteLine("Time :" + time);
        }

        public static void Main(string[] args)
        {
            Time t = new Time(11, 50, 59);
            t.DisplayTime();
            t.increment();
            t.DisplayTime();
        }
    }
}
