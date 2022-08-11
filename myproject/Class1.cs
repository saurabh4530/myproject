using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    abstract class Animal
    {
         public abstract void makeSound();
    }

    class Dog : Animal
    {
           
        public override void makeSound()
        {

            Console.WriteLine("Bark ");

        }
    }
    class Cat : Animal
    {

        public override void makeSound()
        {

            Console.WriteLine("meow ");

        }
    }
    class Class1
    {
        static void Main(string[] args)
        {


            Dog obj = new Dog();
            obj.makeSound();
            Cat obj1 = new Cat();
            obj.makeSound();



        }
    }
    class C2
    {
        public static float Areacircle(float r)
        {
            float pie = 3.14f;
            float a = pie * r*r;
            
            return r;
        }
        static void Main(string[] args)
        {
           float result = C2.Areacircle(3);
         
        }
       

    }
    class c3
    {
        public static int fact(int x)
        {
            int fact = 1;
            for (int i = 1; i <= x; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            return x;
        }
        static void Main(string[] args)
        {
         ///  int result= c3.fact(5);
            Console.WriteLine(c3.fact(5));
        }
    }
    class c4
    {
        public static bool isprime(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        static void Main(string[] args)
        {
            bool result = c4.isprime(4);
            Console.WriteLine(result);
            if (result==true)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
    class c5
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(s[i]);
                }
               
            }
           

        }
    }
    class c6
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            string word = Console.ReadLine();
            string[] temp = s.Split();
            int count = 0;
            for (int i = 0; i < temp.Length; i++)
            {

                if (word == (temp[i]))
                {
                    count++; 
                   
                }
                
            }
            Console.WriteLine(word + "  " + count);



        }
    }
    class C7
    {
        public static void Main()
        {
             string str = Console.ReadLine();
             string word = Console.ReadLine();
           
            Console.Write(countOccurrences(str, word));
        }
         public static int countOccurrences(string str,string word)
         {
           
            string[] a = str.Split();

         
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {

              
                if (word==(a[i]))
                    count++;
            }

            return count;
        }

      
        
    }
    class c8
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string newstr= " ";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                
                    if (char.IsUpper(ch))
                    {
                        ch = (char)(ch + 32);
                    }
                    else if (char.IsLower(ch))
                    {
                        ch = (char)(ch - 32);
                    }
                    newstr = newstr + ch;
                

            }
            Console.WriteLine(newstr);
        }
    }
    class maxdiff
    {
        static void maxDiff(int[] arr, int arrsize)
        {
            int maxdiff = arr[1] - arr[0];
            int i, j;
            for (i = 4; i <= arrsize; i++)
            {
                for (j = i + 1; j <= arrsize; j++)
                {
                    if (arr[j] - arr[i] > maxdiff)
                        maxdiff = arr[j] - arr[i];
                }
            }
            Console.WriteLine(maxdiff);
        }

        
        public static void Main()
        {

            int[] arr = { 2, 5, 7, 10, 25, 120 };
             maxDiff(arr, 5);

        }
    }
    class address
    {
        string cityname;
        public string Cityname
        {
            get { return cityname; }
            set { cityname = value; }
        }
    }
  class Order
    {
        int orderid;
        address city;
        string custname;
        bool isdelivered;
        public int Orderid
        {
            get { return orderid; }
            set { orderid = value; }

        }
        public string Custname
        {
            get { return custname; }
            set { custname = value; }
        }
        public bool Isdelivered
        {
            get { return isdelivered; }
            set { isdelivered = value; }
        }
        public address City
        {
            set;
            get;
        }

    
        static void Main(string[] args)
        {
            Order o = new Order();
            o.Orderid = 123656;
            o.Custname = "akshay";
            o.Isdelivered = true;


            o.City = new address();
            o.City.Cityname = "pune";


            Console.WriteLine("order id="+o.Orderid+"     customer name=  "+o.Custname+"      is order placed= "+o.Isdelivered+"     town=  "+o.City.Cityname);

        }
    }
    public class Isprime
    {
        public static void Main(string[] args)
        {
            int n, i = 2; 
            bool check = true;

            Console.Write("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());

            while (i < n)
            {
                if (n % i == 0)
                {
                    check = false;
                    break;
                }
                i++;
            }

            if (check ==true)
            {
                Console.WriteLine("Number is prime:" + n);
            }
            else
            {
                Console.WriteLine("Number is not prime:" + n);
            }
        }
    }


}



