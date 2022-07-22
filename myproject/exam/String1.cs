using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.exam
{
    class String1
    {// duplicate word and occurance
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            String str = Console.ReadLine();
            String[] words = str.Split();

            for (int i = 0; i < words.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i] == (words[j]))
                    {
                        count++;


                    }
                }


                if (count > 1)
                {
                    Console.WriteLine(words[i] + " " + count);
                }
            }

        }
    }
    class String2
    {// count word
        static void Main(string[] args)
        {
            Console.Write("Enter String  : ");
            string s = Console.ReadLine();

            string[] words = s.Split();

            Console.WriteLine("Count of words :" + words.Length);
        }
    }
    class String3
    {// anagram
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();


            if (s1.Length == s2.Length)
            {
                char[] a1 = s1.ToCharArray();
                foreach (char ch in a1)
                {

                    int idx = s2.IndexOf('z');
                    if (idx != -1)
                    {
                        s2 = s2.Substring(0, idx) + s2.Substring(idx + 1);

                    }
                }

                if (s2.Length == 0)
                {
                    Console.WriteLine("Anagram");
                }
                else
                {
                    Console.WriteLine("Not");
                }

            }
            else
                Console.WriteLine("Not anagaram");



        }
    }
    class String4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string str = Console.ReadLine();
            int alphabet, digit, specialchar;
            alphabet = digit = specialchar = 0;

            int i = 0;
            while (i < str.Length)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alphabet++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    specialchar++;
                }

                i++;
            }

            Console.Write("Number of Alphabets in the string is : " + alphabet);
            Console.Write("Number of Digits in the string is : " + digit);
            Console.Write("Number of Special characters in the string is : " + specialchar);

            Console.ReadLine();
        }
    }
    class string5
    {
        static void Main(string[] args)
        {
            //   program to convert uppercase string to lowercase

            Console.WriteLine("enter string");
            string str = Console.ReadLine();

            Console.WriteLine("Converted to LowerCase :" + str.ToLower());
            Console.ReadLine();

        }
    }
    class String6
    {// 2 array merge in 3
        static void Main(string[] args)
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
    class string7
    {// array sort
        static void Main(string[] args)
        {
            int[] a = new int[7];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;


                    }
                }
            }

            Console.WriteLine(string.Join(" ", a));
        }
    }
    class string8
    {
        // replace all the 0’s with 1’s in your array.
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            int[] a1 = new int[a.Length];
            for (int i = 0; i < a1.Length; i++)
            {
                if (a[i] == 0)
                {
                    a1[i] = 1;
                }
                else
                {
                    a1[i] = a[i];
                }

            }
            Console.WriteLine(string.Join(" ", a1));
            Console.ReadLine();
        }
    }
    class string9
    {
        static void Main(string[] args)
        {
            int[] items = new int[7];


            Console.WriteLine("Unique array elements: ");

            for (int i = 0; i < items.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (items[i] == items[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(items[i]);

                }
            }

            Console.ReadLine();
        }
    }
}
