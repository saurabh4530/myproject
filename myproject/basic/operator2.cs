using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.basic
{
    class operator2
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            int x = ++a + ++b;

            int y = a++ + b++;
            Console.WriteLine(x + "   " + a + "    " + b);// 13,7,8
            Console.WriteLine(y + "   " + a + "    " + b);//15, 7,8

            int z = --a + --b;
            Console.WriteLine(z + "  " + a + "   " + b);//13,6,7

            int m = a-- - b--;
            Console.WriteLine(m + "  " + a + "   " + b);//-1, 5,6

        }
    }
    class operator3
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5;// arthmatic  operator
           
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }
        
        
    }
    class operator4
    {
        static void Main(string[] args)
        {
            int a = 50, b = 10;//relatiom operator
            Console.WriteLine(a == b);//F
            Console.WriteLine(a != b);//T
            Console.WriteLine(a >= b);//T
            Console.WriteLine(a <= b);//F
            Console.WriteLine(a > b);//T
            Console.WriteLine(a < b);//F
        }
    }
    class operator5
    {
        static void Main(string[] args)
        {
            Console.WriteLine(4+2-1*8/2);//2
            Console.WriteLine(6*2/4-5*3*2);//-27
            Console.WriteLine(51%9-2-1+3);//6
            Console.WriteLine((4+5)*2/2+1);//10
            Console.WriteLine(6*7-4*(8+2/2));//6
        }
    }
    
}
