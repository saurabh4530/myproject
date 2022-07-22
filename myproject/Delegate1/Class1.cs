using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Delegate1
{
    class Class1
    {//declare delegate
        public delegate void mydelegate(int x);
        public void square(int a)
        {
            Console.WriteLine("square= " + a * a);
        }
        public static void square1(int a)
        {
            Console.WriteLine("square1= " + a * a);
        }
        public static void cube(int a)
        {
            Console.WriteLine("cube= " + a * a * a);
        }
        static void Main(string[] args)
        {//set target to delegate
            Class1 c = new Class1();
            mydelegate d = c.square;
            d(5);


            mydelegate d1 = square1;
            d1 = d1 + cube;
            d1(7);
        }
    }
    class Class2

    {
        public delegate int mydelegate(int x);
        public static int factorial(int a)
        {
            int f = 1;
            for (int i = 1; i <= a; i++)
            {
                f = f * i;
            }
            return f;

        }
        static void Main(string[] args)
        {
            mydelegate d = factorial;
            Console.WriteLine(d(5));
        }
    }
    class Class3
    {
        public delegate void mydelegate(int x);

        public static void square1(int a)
        {
            Console.WriteLine("square1= " + a * a);
        }
        public static void cube(int a)
        {
            Console.WriteLine("cube= " + a * a * a);
        }
        static void Main(string[] args)
        {//set target to delegate


            mydelegate d1 = square1;
            d1 = d1 + cube;
            d1(7);
        }
    }
    class Class4 // multicast delegate
    {
        public delegate void mydelegate(int x);
        public void square(int a)
        {
            Console.WriteLine("square= " + a * a);
        }

        public void cube(int a)
        {
            Console.WriteLine("cube= " + a * a * a);
        }
        public static void doubleup(int a)
        {
            Console.WriteLine("double =" + 2 * a);
        }
        static void Main(string[] args)
        {//set target to delegate
            //multicast delegates
            Class4 c = new Class4();
            mydelegate d = c.square;
            d = d + c.cube;
            d = d + Class4.doubleup;
            d(5);



        }
    }
    public delegate void mydel3(int x, int y);
    class Class5
    {
        static void Main(string[] args)
        {
            mydel3 d1 = delegate (int x, int y)
            {
                Console.WriteLine("add=" + (x + y));
            };
            d1(10, 20);



            ///lamda expression
            mydel3 d2 = (x, y) =>
              {
                  Console.WriteLine("addn=" + (x + y));
              };
            d2(20, 30);
        }

    }
    class Class6
    {
        static string greet()
        {
            return "good morning";
        }
        static int product(int a, int b, int c)
        {
            return a * b * c;

        }
        static bool iseven(int x)
        {
            return x % 2 == 0;
        }

        static void Main(string[] args)
        {
            Func<string> d1 = greet;
            Func<int, int, int, int> d2 = product;
            int prod = d2(2, 4, 5);
            Console.WriteLine("multiplication=" + prod);

            Action<int, int> d3 = (a, b) => Console.WriteLine("addn=" + (a + b));
            d3(5, 4);



            Func<int, bool> d4 = iseven;
            bool b = d4(67);



            Predicate<int> d5 = iseven;
            bool bb = d5(78);

            // func use when function compulsory return a value back, take 0 to 16 parameter
            //Action if function return type is void and may 0 or more parameter
            //predicate if function return compulsory boolean value back and may 0 or more parameter
        }
    } class Class7  //callback
    {
        public static void display()
        {
            Console.WriteLine("good morning");
        }
        public static void square(int a, Action d1)
        {
            Console.WriteLine("square=" + (a * a));
            d1();
        }
        static void Main(string[] args)
        {
            square(9, display);
        }
    }
    class Class8
    {
        public static void Passbyref(ref int a)
        {
            a = a + 10;
            Console.WriteLine("value is=" + a);
        }
        static void Main(string[] args)
        {
            int value = 5;
            Class8.Passbyref(ref value);
            Console.WriteLine(value);
        }
    }
    class Class9
    {
        public static void Passbyout(out int a)
        {
            a = 10;
            Console.WriteLine("value is=" + a);
        }
        static void Main(string[] args)
        {
            int value;
            Class9.Passbyout(out value);
            Console.WriteLine(value);


        }
    }
    class Class10
    {
        public const double pi = 3.14;
        public readonly int value1;
        Class10(int value)
        {
            value1 = value;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(pi);




            Class10 c = new Class10(5);
            Console.WriteLine(c.value1);
        }
    }
    class Class11
    {
        public static int add(params int[] nums)
        {
            int sum = 0;
            foreach (int i  in nums)
            {
                sum = sum + i;

            }return sum;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Class11.add(10,20,30,40));
        }
    }
}


