using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int product = 0;

            if (number >= 1 && number <= 100)
            {
                product = number;
                if (multiplier <= 10)
                {
                    for (int i = multiplier; i <= 10; i++)
                    {
                        product *= i;
                        Console.Write("{0} X {1} = {2}\n", number, i, product);
                        product = number;
                    }
                }
                else
                {
                    product *= multiplier;
                    Console.Write("{0} X {1} = {2}\n", number, multiplier, product);
                }
            }
        }
    }
}
