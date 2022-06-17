using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.condition
{
    class subjects
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the marks of 5 subject");
            float s1 = float.Parse(Console.ReadLine());
            float s2 = float.Parse(Console.ReadLine());
            float s3 = float.Parse(Console.ReadLine());
            float s4 = float.Parse(Console.ReadLine());
            float s5 = float.Parse(Console.ReadLine());


           float total = s1 + s2 + s3 + s4 + s5;
            float avg = total / 5;
            float percentage = (total / 500) * 100;

                Console.WriteLine("total is" +"   "  +  total);
            Console.WriteLine("avg is"+"    "+ avg );
            Console.WriteLine("percentage is" +" "   + percentage);




        }
    }
}
