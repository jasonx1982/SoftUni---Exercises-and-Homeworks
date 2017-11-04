using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = {"January", "February", "March", "April", "May", "June", 
                               "July", "August", "September", "October", "November", "December"};

            int monthNumber = int.Parse(Console.ReadLine());

            if (monthNumber > 0 && monthNumber < 13)
            {
                Console.Write("{0}\n", months[monthNumber - 1]);
            }
            else
            {
                Console.Write("Error!\n");
            }
        }
    }
}
