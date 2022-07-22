using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Arraydemo
{
    class Arr2d
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            for (int r = 0; r <= a.GetUpperBound(0); r++)
            {
                for (int c = 0; c <= a.GetUpperBound(1); c++)
                {
                    a[r, c] = int.Parse(Console.ReadLine());
                }
            }
            for (int r = 0; r <= a.GetUpperBound(0); r++)
            {
                int sum = 0;
                int avg = 0;
                for (int c = 0; c <= a.GetUpperBound(1); c++)
                {
                    sum = sum + a[r, c];
                    avg = sum / a.GetLength(0);

                    Console.Write(a[r, c] + " ");
                }
                Console.WriteLine(a.GetLength(0));
                Console.WriteLine("sum=" + sum+ " "+ "avg=" + avg);
               

            }
            Console.ReadLine();


        }
    }
    //2.Write code to find out column wise sum
    class Column_wise_sum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            int sum = 0;
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {

                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    sum = sum + a[j, i];
                    Console.Write(a[j, i] + " ");


                }
                Console.WriteLine("sum=" + sum);




            }
            Console.ReadLine();



        }

    }
    //3.write code to perform addition of 2 matrices
    class Two_matrices
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            int[,] b = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            int[,] c = new int[3, 3];

            int sum = 0;
            for (int i = 0; i <= c.GetUpperBound(0); i++)
            {

                for (int j = 0; j <= c.GetUpperBound(1); j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    sum = sum + c[i, j];

                }

            }
            /*int sum = 0;
            for (int i = 0; i <= c.GetUpperBound(0); i++)
            {
                
                for (int j = 0; j <= c.GetUpperBound(1); j++)
                {
                    sum = sum + c[i, j];
                    Console.Write(c[i, j]+" ");

                }
                Console.WriteLine();

            }*/
            Console.WriteLine("sum" + sum);



            Console.ReadLine();
        }
    }
    //4.create 2d array and display following pattern
    //1234    1   4
    //5678    56  8
    //7689    7 8 9
    //1230    1   0
    class Pattern1
    {
        static void Main(string[] args)
        {
            int[,] p = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 7, 6, 7, 8 }, { 1, 2, 3, 0 } };
            for (int i = 0; i <= p.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= p.GetUpperBound(1); j++)
                {
                    if (j == 0 || (j == p.GetUpperBound(1)) || j == i)
                    {
                        Console.Write(p[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
    class pattern2
    {
        static void Main(string[] args)
        {
            string[,] a = new string[10, 10];
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    a[i, j] = "*";
                }

            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j || j == 0 || j == a.GetLength(1) - 1)
                    {
                        Console.Write(a[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
