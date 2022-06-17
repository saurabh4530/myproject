using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.condition
{
    class greater2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if(num1>num2)
            {
                Console.WriteLine(num1 +  "is greater number");
            }
            else
            {
                Console.WriteLine(num2    +  "is greater number");
            }
        }
    }
}
