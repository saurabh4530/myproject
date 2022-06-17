using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.condition
{
    class evenodd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("enter number is even");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("enter number is odd");
                Console.ReadLine();
            }
        }
    }
}
 