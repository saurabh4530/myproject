using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.exam
{
    class Class1
    {

        // print num betn 1 t0 100 except num is div by 5 and 10
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {

                if (i % 5 == 0 && i % 10 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


        }
    }
    class Class2
    {          //Q3 output is k=720 i=7
        static void Main(string[] args)
        {
            int i = 1; int k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k = " + k + "i =" + i);

        }
    }
    class Class3
    {             //spy number
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int product = 0;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r;
                product = product * r;
                num = num / 10;
            }
            if (sum == product)
            {
                Console.WriteLine("num is spy");
            }
            else
            {
                Console.WriteLine("num is not spy");
            }
        }
    }
    
    class Class5
    {
        static void Main(string[] args)          // star pattern mirror type
        {
            int i, j, k;
            for (i = 5; i >= 1; i--)
            {
                for (j = i; j < 5; j++)
                    Console.Write(" ");
                for (k = i * 2; k > 1; k--)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
    class Class6
    {
        static void Main(string[] args)
        {
            int i, j, k = 4, m;             // number

            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= k; j++)
                {
                    Console.Write(" ");
                }
                for (m = 1; m <= i; m++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine("\n");
                k = k - 1;
            }
        }
    }
    class Class7

    {                         //Q9 mystery int      95 96 97 98  99
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }

        }


    }

    class Class8
    {//2,12,36,80.........10 terms
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 10)                                             ///series
            {
                Console.WriteLine((i * i) + (i * i * i));
                i++;

            }
        }
    }
    class Class9
    {// print num from 1 to 50 if num even print as it is and if not then print neg num with square
        static void Main(string[] args)
        {
            int i = 0;

            while (i <= 50)
            {

                i++;
                if (i % 2 == 0)
                {
                    Console.WriteLine(i );
                }
                else
                {
                    Console.WriteLine(-i+" "+(i*i));
                }

            }
        }
    }
    class Class10
    {// output is infinite time 1
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
                Console.WriteLine(i);
            }

        }
    }
    class Class11
    {// fibbo series 20 terms
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int n1 = 0;
                int n2 = 1;
                int n = 20;
                
                for (int i = 1; i <= 20; i++)
                {
                    int sum = n1 + n2;
                    Console.WriteLine(n1);
                    n1 = n2;
                    n2 = sum;
                    Console.ReadLine();

                }
            }

        }
    }
    class Class12
    {// sum of factorial

        static void Main(string[] args)
        {
            int i, fact = 1, number, sum=0;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
                sum = sum + fact;
            }
            Console.Write("sum =  " + sum);

        }
    }
    class Class13
    {//output = 2 2 2
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            } while (b!=3);
        }
    }
 




}

