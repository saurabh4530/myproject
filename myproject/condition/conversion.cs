using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.condition
{
    class conversion
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("enter the value");
             string input = Console.ReadLine();*/
            int num;
            Console.WriteLine("enter the number");
            // num = int.Parse(Console.ReadLine());
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);

            double d = Convert.ToDouble(Console.ReadLine());
            double d1 = double.Parse(Console.ReadLine());
            Console.WriteLine(d + d1);


            bool b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(b);

            char ch = Console.ReadLine()[0];
            Console.WriteLine(ch);

          //  char ch2 = Convert.ToChar(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            Console.WriteLine(ch2);

        }
    }
}
