using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.loop
{
   class nested
    {
        static void Main(string[] args)     //table
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + "x" + j + "=" + j * i);
                }
                Console.WriteLine();
            }
        }
    }
    class nested2
    {
        static void Main(string[] args)
        {


            for (int i = 1; i <= 4; i++)
            {
                for (int k = 4; k >= i; k--)
                {
                    Console.WriteLine(" ");
                }

                for (int j = 4; j >= i; j--)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
    class nested3
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j <= 4; j++)

                    Console.Write(" ");
                {
                    for (int j = 1; j <= i; j++)

                        Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
    class nested4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class nested5
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j <= 4; j++)
                    Console.Write(j + " ");
                Console.WriteLine();
            }
        }
    }
    class nested6
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >= 1; i--)
            {

                for (int j = 1; j <= i; j++)

                    Console.Write(j + " ");
                Console.WriteLine();
            }
        }
    }
    class nested7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {

                for (int j = 4; j >= i; j--)

                    Console.Write(j + " ");
                Console.WriteLine();
            }
        }
    }
    class nested8
    {
        static void Main(string[] args)
         {

             for (int i = 1; i <=6; i++)
             {
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write(" ");
                 }
                 for (int  k = 1; k<=i ; k++)
                 {
                     Console.Write(k++);
                 }

             }
         }
    }
    class nested9
    {
        static void Main(string[] args)
        {
            for (char ch = 'a'; ch <= 'e'; ch++)
            {
                for (char ch2 = 'a'; ch2 <= 'e'; ch2++)
                {
                    Console.Write(ch2);

                }
                Console.WriteLine();
            }
            Console.WriteLine("****************************************");



        }
    }
    class nested10
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(0);
                    }
                    else
                    {
                        Console.Write(1);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    class automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int temp = num;
            while (num > 0)
            {
                count++;
                num = num / 10;

            }
           Console.WriteLine(count);
            num = temp;
            int sq = num * num;
            int power = 1;
            for (int i = 1; i <= count; i++)
            {
                power = power * 10;
            }
           Console.WriteLine(sq + " " + power);


            int end = sq % power;
            Console.WriteLine(sq + "  " + "end= " + end);
            if (end == num)
            {
                Console.WriteLine("automorphic");
            }
            else
            {
                Console.WriteLine("not");
            }



        }


    }
    class pattern1
    {
        static void Main(string[] args)
        {
            int c = 64;
            for (int i = 1;  i<= 5; i++)               
             { 
                for (int j = 1; j <=i; j++)
                {
                    if (i%2==0)
                    {
                        Console.Write((char)(c+j));
                    }
                    else
                    {
                        Console.Write(j);
                    }
                   
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    class pattern2
    {
        static void Main(string[] args)
        {
            for (char ch = 'a'; ch <='d'; ch++)
            {
                for (char ch2 = 'd'; ch2 >=ch; ch2--)
                {
                    Console.Write(ch2);
                }
                Console.WriteLine();
            }
            Console.WriteLine( );
        }
    }
    class pattern3
    {
        static void Main(string[] args)
        {
            for (char ch = 'd'; ch>='a'; ch--)
            {
                for (char  i = 'a'; i <=ch; i++)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    class prime
    {
        static void Main(string[] args)
        {
            
         

            Console.WriteLine("enter num");
            int num = int.Parse(Console.ReadLine());
           
            int i;
            int factor;
            bool isprime=true;


           
            for (num = 2; num <=10; num++)
            {
                isprime = true;
                factor = 0;

                //  num is evenly divisible 
                for (i = 2; i <= num / 2; i++)
                {
                    if ((num % i) == 0)
                    {
                        // num is evenly divisible -- not prime 
                        isprime = false;
                        factor = i;
                    }
                }

                if (isprime)
                    Console.WriteLine(num + " is prime.");
                else
                    Console.WriteLine(num+"odd");
            }
        }
    }
    class kaprekar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int num = int.Parse(Console.ReadLine());
            

            int temp = num;
            int count = 1;
            int sq = num * num;
            while (num>0)
            {
                count++;
                num = num / 10;

            }
            int power = 1;
            for (int i = 1; i < count; i++)
            {
                power = power * 10;

            }
            int division = sq / power;
            int rem = sq % power;
           int sum = division + rem;
            if (sum == temp)
            {
                Console.WriteLine("kaprekar");
            }
            else
            {
                Console.WriteLine("not");
            }
        }
    }
}

