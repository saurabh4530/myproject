using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.ternary

{
    class oddeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int num = int.Parse(Console.ReadLine());
            string result = (num % 2 == 0) ? "num is even" : "num is odd";
            Console.WriteLine(result);
        }
    }
}
