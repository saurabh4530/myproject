

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
    {                                   //Create int type array and display sum of even elements from array
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
    class PrintPrime
    {


        public static void Main(string[] args)
        {

            
            Console.WriteLine("enter size of array");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            int s = 0;
            Console.Write("Enter array elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
             
                int count = 1;
                int j = 2;
                while (j < arr[i])
                {
                    if (arr[i] % j == 0)
                    {
                        count = 0;
                        break;
                    }
                    j++;

                }

                if (count == 1)
                {
                    s = s + arr[i];
                }
            }
            Console.Write("Sum of prime numbers:" + s);
        }
    }
    class sumnum
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter the array element");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(string.Join(" ", a));

            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine(sum);
        }
    }
    class Max
    { 
    public static void Main(string[] args)
    {
        int i, max = 0, min = 0;
        int[] arr = new int[5];

        Console.Write("Enter five numbers:");
        for (i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        max = min = arr[0];
        for (i = 0; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
               max = arr[i];
            }

            if (min > arr[i])
            {
                min = arr[i];
            }
        }
        Console.WriteLine("Largest element is:" + max);
        Console.WriteLine("Smallest element is:" + min);
    } }
    class merge1
    {
        static void Main()
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] array3 = new int[array1.Length + array2.Length];
            Console.WriteLine("Enter Any 5 Elements for the First Array :");
            for (int i = 0; i < 5; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Any 5 Elements for the Second Array :");
            for (int i = 0; i < 5; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());

            }
            int j = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                array3[j] = array1[i];
                j++;
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array3[j] = array2[i];
                j++;
            }
            Console.WriteLine("//////////////////////////");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);

                
            }
        }
        
    }
    class maxdiff
    {
        static void printresult(int[] arr, int arrsize)
        {
           

            int printresult = arr[1] - arr[0];
            int m, j;
            for (m = 4; m < arr.Length; m++)
            {
                for (j = m + 1; j < arr.Length; j++)
                {
                    if (arr[j] - arr[m] > printresult)
                        printresult = arr[j] - arr[m];

                }
            }
            Console.WriteLine(printresult);
        }
        public static void Main()
        {

            int[] arr = { 2, 5, 7, 10, 25, 120};
            printresult(arr, 5);

        }
    }

    class Maxdiff
    {

        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 7, 10, 25, 120 };

            int printresult = arr[1] - arr[0];
            int m, j;
            for (m = 4; m < arr.Length; m++)
            {
                for (j = m + 1; j <arr.Length; j++)
                {
                    if (arr[j] - arr[m] > printresult)
                       printresult = arr[j] - arr[m];
                   
                }
            }
            Console.WriteLine(printresult);

        }
    }
}
   
    

