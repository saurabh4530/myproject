using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.oops
{
    class CalculateMethodOverloading
    {
        public void Area(double radius)
        {
            double pi = 3.14;
            double result = pi * radius * radius;
            Console.WriteLine("Area of a circle = " + result);

        }
         
         public void Area(int Side)
        {
          
            int result = Side * Side;
            Console.WriteLine("Area of a square = " + result);
        }
        public void Area(int length, int breath)
        {
            int result = length * breath;
            Console.WriteLine("area of reactangle= "+result);
        }
        public void Area(double basee , double height)
        {
            double result = (basee * height) / 2;
            Console.WriteLine("area of triangle =  "+result);
        }
        static void Main(string[] args)
        {
            CalculateMethodOverloading t = new CalculateMethodOverloading();
           t.Area(1.5);
            t.Area(5);
            t.Area(6, 7);
            t.Area(2.5, 6);
            
        }
    }
    class Arthmatic
    {                         // overloading
       public void Calculate()
        {
            int x = 3;
            int y = 7;
            Console.WriteLine("addn "+x+y);
        }
        public void Calculate(int x, int y)
        {
            Console.WriteLine("subn is "+ (x-y));
        }
        public void Calculate(double x, double y)
        {
            Console.WriteLine("multi is " +( x*y));
        }
        public void Calculate(float x, float y)
        {
            Console.WriteLine("div is " + (x / y));
        }
        static void Main(string[] args)
        {
            Arthmatic t = new Arthmatic();
                t.Calculate(3, 7);
            t.Calculate(5, 7);
            t.Calculate(3.5, 2);
            t.Calculate(55, 5);

        }
    }
    class Swapping
    {
        public void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            Swapping s = new Swapping();
            Console.WriteLine(("enter the 1st num"));
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(("enter the 2nd num"));
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1+"  "+num2);
            s.swap(ref num1, ref num2);
            Console.WriteLine("..........................");



            Console.WriteLine(num1+"  "+num2);

        }
    }

    class StaticDemo
    {
        int count = 0;
        public StaticDemo()
        {
            count++;
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            StaticDemo d = new StaticDemo();
            StaticDemo d2 = new StaticDemo();
            StaticDemo d3 = new StaticDemo();
        }
    }
    class StaticDemo1
    {
       static int count = 0;
        int x = 10;
        public StaticDemo1()
        {
            count++;
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {


           // Console.WriteLine(x); ; Non static not access

            Console.WriteLine(count);
            StaticDemo d = new StaticDemo();
            StaticDemo d2 = new StaticDemo();
            StaticDemo d3 = new StaticDemo();
        }
    }
    static class staticclasscontainstaticconstructor
    {     // create static class and contained static constructor and call it 
        static staticclasscontainstaticconstructor()
        {
            Console.WriteLine("hi...........");
        }
        static void Main(string[] args)
        {

        }
    }
    class Staticvariablemethod
    {
        int x = 10;
        static int y = 30;
        void add()
        {
            Console.WriteLine("addn= "+(x+y));
            y = 1;
            Console.WriteLine("addin = "+(x+y));

        }
        static void sum()
        {
            Staticvariablemethod m = new Staticvariablemethod();
            Console.WriteLine("sum=" +(m.x+y));
        }
        static void Main(string[] args)
        {
            Staticvariablemethod s= new Staticvariablemethod();
            s.add();
            //  Staticvariablemethod.sum();
            sum();
        }
    }
    
} 
