using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0}\n", i);
                }
            }
        }
    }
}
