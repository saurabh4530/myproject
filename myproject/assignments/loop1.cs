using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.assignments
{
   class loop1
    {
        static void Main(string[] args)
        {
            double num1 = 229;
            for (double i =121; i <= 229; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("the Even number are"+i);
                }
              
            }
            Console.ReadLine();
        }
    }

    class loop2

    {
        static void Main(string[] args)
        {
            double num1 = 229;
            for (double i = 521; i >=num1; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("the odd numbers are"+ i);
                }

            }
            Console.ReadLine();
        }
    }
    class loop3
    {
        static void Main(string[] args)         //break
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 7)
                {
                    break;
                }
            }
        }
    }

   

    class loop5
    {                               // alphabets atoz
        static void Main(string[] args)
        {
            char ch;
            for (ch = 'a'; ch <= 'z'; ch++)
            {
                Console.WriteLine(ch );
            }
            Console.ReadLine();
        }
    }

    class loop6
    {
        static void Main(string[] args)
        {
            int i, num, sum = 0;

            
            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= num; i += 2)
            {
               
                sum += i;
                Console.WriteLine("Sum of all even number between 1 to " + num + " = " + sum);
            }
            Console.ReadLine();
        }
    }
    class loop7
    {
        static void Main(string[] args)
        {
            int i, num, sumOdd = 0;
            Console.WriteLine("Enter the number:");

            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    sumOdd += i;
                    Console.WriteLine("Total sum: " + sumOdd);
                }
            }

            Console.ReadLine();
        }
    }
    


    class loop9
    {

       static void Main(string[] args)
        {

            int num, product = 1;

            
            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <num; i++)        
             {
                product = product * (num % 10);

               
                num = num / 10;
            }

            Console.WriteLine("Product of digits = " + product);

            Console.ReadLine();
        }
    }

    class loop10
    {                                         //  table
         static void Main(string[] args)
        {
            int n, i, t = 0;
            Console.Write("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());

            
            for (i = 1; i <= 10; i++)
            {
                t = n * i;
                Console.WriteLine(n+"x"+i+"="+t);
            }

        }
    }

    class loop11
    {
                                        // square
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());

            int square=1;


            for (int i = 1; i <=n; i++)
           
            {
                square =i * i;
              

            }
            Console.WriteLine("the square is: " + square);


        }
    }
    class reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
         
            for (int i = 1; i <=num; i++)
            { } 

                
            
        }
    }
}
