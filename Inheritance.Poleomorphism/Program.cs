using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Poleomorphism
{
    class Program
    {
        public class Time
        {
            int h;
            int m;
            int s;

            public void Info()
            {
                Console.WriteLine($"{h}:{m}:{s}");
            }

            public int hour { get { return h; }
                set
                {
                    if (value > 23) { h = 0; }
                    else if (value < 0) { h = 0; }
                    else { h = value; }
                }
            }

            public int minute { get { return m; }
                set
                {
                    if (value > 60) { m = 0; }
                    else if (value < 0) { m = 0; }
                    else { m = value; }
                }
            }

            public int second { get { return s; }
                set
                {
                    if (value > 60) { s = 0; }
                    else if (value < 0) { s = 0; }
                    else { s = value; }
                }
            }

            public void getInfo()
            {
                Console.WriteLine($"{h}:{m}:{s}");
            }

        }

        static void Main(string[] args)
        {
            Time t = new Time();
            t.Info();

            t.hour = 14;
            t.minute = 70;
            t.second = 55;

            t.getInfo();

            Console.ReadLine();
        }
    }
}
