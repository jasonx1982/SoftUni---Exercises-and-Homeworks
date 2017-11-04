using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            if (n >= 1 && n <= 100)
            {
                int odd = 1;
                for (int i = 0; i < n; i ++)
                {
                    Console.Write("{0}\n", odd);
                    sum += odd;
                    odd += 2;
                }

                Console.Write("Sum: {0}\n", sum);
            }
        }
    }
}
