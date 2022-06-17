using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.ternary
{
    class zeroposineg

    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any num");
            int num = int.Parse(Console.ReadLine());
            
            string max=(num < 0 )  ?   "negative" : "positive";
            string temp = (num == 0) ? "zero" : max;
            Console.WriteLine(temp);

        } 
    }
}
