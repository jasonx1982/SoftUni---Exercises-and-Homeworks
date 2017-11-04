using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3.00)
            {
                Console.Write("Passed!\n");
            }
            else
            {
                Console.Write("Failed!\n");
            }
        }
    }
}
