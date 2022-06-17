using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.switchdemo
{
    class days
    {
        static void Main(string[] args)
        {
            

            
            Console.WriteLine("Enter days from 1to 7: ");
            int days = Convert.ToInt32(Console.ReadLine());

            switch (days)
            {
                case 1:Console.WriteLine("Monday");
                    break;
                case 2:   Console.WriteLine("Tuesday");
                    break;
                case 3: Console.WriteLine("Wednesday");
                    break;
                case 4:Console.WriteLine("Thursday");
                    break;
                case 5: Console.WriteLine("Friday");
                    break;
                case 6: Console.WriteLine("Saturday");
                    break;
                case 7: Console.WriteLine("Sunday");
                    break;
                default: Console.WriteLine("Invalid input! Please enter week no. between 1-7.");
                    break;

            }
           

        }
    }
    }

