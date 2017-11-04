using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int countInputs = 0;

            if (number >= -1000 && number <= 1000)
            {
                if (number % 2 != 0)
                {
                    if (number < 0)
                    {
                        number *= -1;
                    }
                    Console.Write("The number is: {0}\n", number);
                }
                else
                {
                    while ((number % 2 == 0) && (countInputs < 10))
                    {
                        Console.Write("Please write an odd number.\n");
                        number = int.Parse(Console.ReadLine());
                        countInputs++;
                    }

                    if (number % 2 != 0)
                    {
                        if (number < 0)
                        {
                            number *= -1;
                        }
                        Console.Write("The number is: {0}\n", number);
                    }
                }
            }
        }
    }
}
