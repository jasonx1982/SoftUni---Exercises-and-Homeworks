using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int product = 0;

            if (number >= 1 && number <= 100)
            {
                product = number;
                for (int i = 1; i <= 10; i++)
                {
                    product *= i;
                    Console.Write("{0} X {1} = {2}\n", number, i, product);
                    product = number;
                }
            }
        }
    }
}
