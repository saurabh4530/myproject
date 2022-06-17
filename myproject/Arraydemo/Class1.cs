

using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Arraydemo
{
    class Class1
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'b', 'c', 'd' };
            char[] ch1 = new char[4];
            for (int i = 0; i < ch1.Length; i++)
            {
                ch1[i] = Convert.ToChar(Console.ReadLine());
                Console.WriteLine(ch1[i] + "  ");

            }
           

        }
    }
    class Sumeven
    {                                               //Create int type array and display sum of even elements from array
        static void Main(string[] args)
        {
            int[] a = new int[6];
            Console.WriteLine("enter elements of array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("array conatain follwing element= " + string.Join(" ", a));
            Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(string.Join(" ", a[i]));
                    sum = sum + a[i];
                }

            }
            Console.WriteLine("sum=" + sum);
            Console.ReadLine();


        }

    }
    class Oddposition
    {                                                   //Create int type of array and display odd position element.
        static void Main(string[] args)
        {
            int[] s = { 0, 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("length=" + s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(s[i]);
                }
            }
            Console.ReadLine();
        }
    }
    class Sumarray
    {                          //Write code to display sum of array 
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", arr));
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("sum of array= " + sum);
            Console.ReadLine();
        }
    }
}
