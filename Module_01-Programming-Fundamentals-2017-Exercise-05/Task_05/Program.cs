using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();

            switch (countryName)
            {
                case "England":
                case "USA":
                    Console.Write("English\n");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.Write("Spanish\n");
                    break;
                default:
                    Console.Write("unknown\n");
                    break;
            }
        }
    }
}
