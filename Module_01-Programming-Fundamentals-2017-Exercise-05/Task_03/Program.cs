using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hoursNew = hours;
            int minutesNew = minutes;
            const int timeAfter = 30;

            if (minutes + timeAfter > 59)
            {
                hoursNew++;
                minutesNew += timeAfter - 60;
            }
            else
            {
                minutesNew += timeAfter;
            }

            if (hoursNew == 24)
            {
                hoursNew = 0;
            }

            if (minutesNew < 10)
            {
                Console.Write("{0}:0{1}\n", hoursNew, minutesNew);
            }
            else
            {
                Console.Write("{0}:{1}\n", hoursNew, minutesNew);
            }
        }
    }
}
