using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.ternary
{
    class greaterno3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st num");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd num");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 3rd num");
            int num3 = int.Parse(Console.ReadLine());
            // 1
            /* int temp = num1 > num2 ? num1 : num2;
             int max = num3 > temp ? num3 : temp;
             Console.WriteLine(max);*/

            //2
            /* int max = ((num1 > num2) && (num1 > num3)) ? num1 : ((num2 > num1) && (num2 > num3)) ? num2 : num3;
             Console.WriteLine(max);*/

            //3
            int max =num1 > num2 ? (num1 > num3) ? num1 : num3 : (num2 > num3) ? num2 : num3;
            Console.WriteLine(max);


        }
    }
}
