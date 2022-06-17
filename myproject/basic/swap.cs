using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.basic
{
    class swap
    {
        static void Main(string[] args)
        {
            int a = 10, b = 2, swap = 0;
            swap = a;
            a = b;
            b = swap;
            Console.WriteLine(a + "         " + b);

        }
    }
}
