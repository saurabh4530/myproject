using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.assignments
{
    class absolute
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            num = num >= 0 ? num : (-(num));
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }





}
