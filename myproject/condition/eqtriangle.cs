using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.condition
{
    class eqtriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of side equilateral triangle");
            int side = int.Parse(Console.ReadLine());
            double area = (Math.Sqrt(3) / 4) * side * side;
            Console.WriteLine("area of equilateral triangle is:"+"  "+area);
        }

    }
}
