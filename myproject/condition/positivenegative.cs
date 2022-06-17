using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.condition
{
    class positivenegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num>0)
            {
                Console.WriteLine("num is positive");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("num is negative");
                Console.ReadLine();
              
            }
        }

    }

   
}
