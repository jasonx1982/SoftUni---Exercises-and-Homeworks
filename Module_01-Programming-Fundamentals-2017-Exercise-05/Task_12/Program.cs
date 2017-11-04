using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                Console.Write("It is a number.\n");
            }
            
            catch (System.FormatException exception)
            {
                Console.Write("Invalid input!\n");
            }
        }
    }
}
