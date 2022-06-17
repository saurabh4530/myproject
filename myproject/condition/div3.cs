using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.condition
{
    class div3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num%3==0)
            {
                Console.WriteLine("num is divisible by 3");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("num is not divisible by 3");
                Console.ReadLine();
            }
            
        }
    }
}
