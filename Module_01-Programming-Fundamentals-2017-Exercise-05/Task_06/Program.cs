using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {            
            string dayString = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            dayString = dayString.ToLower();

            int dayType = 0;            
            switch (dayString)
            {
                case "weekday":
                    dayType = 1;
                    break;
                case "weekend":
                    dayType = 2;
                    break;
                case "holiday":
                    dayType = 3;
                    break;
                default:
                    break;
            }

            int ageType = -1;
            if (age >= 0 && age <= 18)
            {
                ageType = 1;
            }
            else if (age > 18 && age <= 64)
            {
                ageType = 2;
            }
            else if (age > 64 && age <= 122)
            {
                ageType = 3;
            }

            int price = 0;
            if (age >= -1000 && age <= 1000 && dayType > 0)
            {
                switch (dayType)
                {
                    case 1:
                        switch (ageType)
                        {
                            case 1:
                                price = 12;
                                break;
                            case 2:
                                price = 18;
                                break;
                            case 3:
                                price = 12;
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        switch (ageType)
                        {
                            case 1:
                                price = 15;
                                break;
                            case 2:
                                price = 20;
                                break;
                            case 3:
                                price = 15;
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        switch (ageType)
                        {
                            case 1:
                                price = 5;
                                break;
                            case 2:
                                price = 12;
                                break;
                            case 3:
                                price = 10;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }

                if (ageType >= 0)
                {
                    Console.Write("{0}$\n", price);
                }
                else
                {
                    Console.Write("Error!\n");
                }
            }
        }
    }
}
