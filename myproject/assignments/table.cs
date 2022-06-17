using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.assignments
{
    class table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the any number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num+"x"+i+"="+num*i);
            }
        }
    }

    class factorial
    {
        static void Main(string[] args)           
        {
            int fact = 1;
            Console.WriteLine("enter any number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <=num; i++)
            {
                fact = fact * i;
              

            }
            Console.WriteLine("the factorial of " + num + "    is    " + fact);


        }
    }



}
