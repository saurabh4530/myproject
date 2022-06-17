using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.assignments
{
    class odd
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=10; i++)
            {
                if (i%2!=0)   //i%2==1
                {
                    Console.WriteLine("odd numbers are   "+i);

                }
            }
        }
    }

    class class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the any number");
            int num = int.Parse(Console.ReadLine());
            for (int i =1 ; i <=10; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
