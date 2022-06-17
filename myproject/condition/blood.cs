using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.condition
{
    class blood
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the weight");
            int weight = int.Parse(Console.ReadLine());
            if (age>18)
            {
                if (weight >= 50)
                {
                    Console.WriteLine("person is eligible for blood donation");
                }
                else
                {
                    Console.WriteLine("person is not eligible for blood donation due to less weight");

                }
            }
            else
            {
                Console.WriteLine("person not eligible for blood donation");
            }
        }
    }


    class blood2
    {
        static void Main(string[] args)        // using && logical operator
        {
            Console.WriteLine("enter the age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the weight");
            int weight = int.Parse(Console.ReadLine());
            if (age>18 && weight>=50)
            {
                Console.WriteLine("person is eligible for blood donation");
            }
            else
            {
                Console.WriteLine("person is not eligible for blood donation");
            }
        }
    }



}
