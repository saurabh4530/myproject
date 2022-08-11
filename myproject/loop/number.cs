using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.loop
{
  class number
    {
        static void Main(string[] args)
        {
            for (int i = 25; i >= 15; i--)
            {
                Console.WriteLine("number is  " + i);
            }
        }
    }
    class num2
    {
        static void Main(string[] args)
        {
            for (int i = 350; i <= 400; i++)
            {
                Console.WriteLine("number is  " + i);
            }
        }
    }
    class odd
    {
        static void Main(string[] args)
        {


            for (int i = 15; i <= 30; i++)
            {
                if (i % 2 != 0)   //i%2==1
                {
                    Console.WriteLine("odd numbers are   " + i);

                }
            }

        }
    }
    class table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the any number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + "x" + i + "=" + num * i);
            }
        }
    }
    class evensum
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            for (i = 2; i <= 10; i += 2)
            {

                sum += i;

            }
            Console.WriteLine("Sum of all even number between 1 to 20" + " = " + sum);
            Console.ReadLine();
        }
    }
    class oddtotal
    {
        static void Main(string[] args)
        {
            int num = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)   //i%2==1
                {
                    Console.WriteLine(i);
                    num++;
                }
            }
            Console.WriteLine("total odd num from 1 to 20  =   " + num);
        }
    }
    class fab
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int sum;
           
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the num");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {




                 sum = n1 + n2;
                Console.WriteLine(n1);
                if (x == n1)
                {
                    Console.WriteLine(true);
                }
                else
                    Console.WriteLine(false);


                n1 = n2;
                n2 = sum;



            }
           
           
        }
    }
    class power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the base");
            int base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the expo");
            int expo = int.Parse(Console.ReadLine());
           int power = 1;
            for (int i = 1; i <=expo; i++)
            {
                power = power * base1;
            }
            Console.WriteLine("output is  = "+ power);


        }
    }
class prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i= 2; i < num; i++)
            {
                if (num % i==0)
                {
                    count++;
                }
            }

            if (count==0)
            {
                Console.WriteLine("num is prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
            Console.ReadLine();
        }
    }
    class magic
    {
        static void Main(string[] args)
        {
            int magicnum = 55;
            for (; ; )
            {
                Console.WriteLine("enter the number");
                int num = int.Parse(Console.ReadLine());

                if(num<magicnum)
                {
                    Console.WriteLine("enter number is less than magic num please try again...");
                }
                else if (num>magicnum)
                {
                    Console.WriteLine("enter number is greater than magic num please try again...");
                }
                else
                {
                    Console.WriteLine("congratalutions!...enter number  match with magicnum");
                    break;
                }
            }
        }
    }
    class armstrong
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            for (int i=1;i<=n;i++)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
               
            }
            if (temp == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
        }
    }
}

