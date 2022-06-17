using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.condition
{
    class greaterno3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1>num2)
            {
                if (num1>num3)
                {
                    Console.WriteLine("num1 is greater");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("num3 is  greater");
                }
            }
            else if (num2>num3)
            {
                Console.WriteLine("num2 is greater");

            }
            else
            {
                Console.WriteLine("num3 is greater");
            }
           




        }
    }

    class greaternoin3                                      // using && operator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1>num2 && num1> num3)
            {
                Console.WriteLine("num1 is greatest among three nos");
            }
            else if (num2>num3 && num2>num1)
            {
                Console.WriteLine("num2 is greatest among three nos");
            }
            else
            {
                Console.WriteLine("num3 is greatest among three nos");
            }
        }
    }


}
