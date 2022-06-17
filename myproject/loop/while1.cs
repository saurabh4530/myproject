using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.loop
{
    class while1
    {
        static void Main(string[] args)
        {                                       // armstrong num
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("it is Armstrong Number.");
            else
                Console.Write("it is Not Armstrong Number.");
        }


    }
    class while2
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i <= 10)
            {

                i++;
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "   num is even");
                }
                else
                {
                    Console.WriteLine(i * i);
                }

            }

        }
    }
    class while3
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine((i * i) + 1);
                i++;
            }

        }
    }
    class while4
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine((i * i) + (i * i * i));
                i++;

            }
        }
    }
    class while5
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine((i * i) - 1);
                i++;
            }
        }
    }
    class while6              //reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (n > 0)
            {
                int r = n % 10;
                reverse = reverse * 10 + r;
                n = n / 10;
            }
            Console.WriteLine(reverse);
        }
    }

    class while7
    {                                               // binary to decimal
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int p = 0;
            int sum = 0;
            while (n > 0)
            {
                int r = n % 10;
                int power = (int)(Math.Pow(2, p));
                sum = sum + (power * r);
                n = n / 10;
                p++;
            }
            Console.WriteLine(sum);
        }

    }

    class while8
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");
        }
    }

    class while9
    {
        static void Main(string[] args)
        {
            int magicnum = 55;
            while (true)
            {
                Console.WriteLine("enter the number");
                int num = int.Parse(Console.ReadLine());

                if (num < magicnum)
                {
                    Console.WriteLine("enter number is less than magic num please try again...");
                }
                else if (num > magicnum)
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
    class while10               // sun of digits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r;
                count++;
                num = num / 10;


            }
            Console.WriteLine("sum of digit is   " + sum + "    number of digits   " + count);
        }
    }
    class while11
    {                                               //spy num
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
    class while12
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number : ");
            int num = int.Parse(Console.ReadLine());
            int result=0;
            while (num>1)
            {
                int r = num % 2;
                 result=r+ result;
                num = num / 2;
              
            }
            Console.WriteLine(result);

        }
    }
    class class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n");
            int n = int.Parse(Console.ReadLine());
            if (n%2!=0)
            {
                Console.WriteLine("Weird");
            }
            else if (n%2==0 &&(n<=5 && n>=2))
            {
                Console.WriteLine("Not Weird");

            }
            else if (n%2==0&& (n>=6&&n>=20))
            {
                Console.WriteLine("Weird");
            }
            else if (n%2==0 &&n>20)
            {
                Console.WriteLine("Not Weird");
            }

        }
    }
}

