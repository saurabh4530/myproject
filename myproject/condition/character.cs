using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.condition
{
    class character
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'e')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'i')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'o')
            {
                Console.WriteLine("vowel");
            }
            else if (ch =='u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonent");
            }
        }
    }
    class character2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the character");        //using  || operator
            char cha = Convert.ToChar(Console.ReadLine());
            if (cha=='a'||cha=='i'||cha=='e'||cha=='o'||cha=='u')
            {
                Console.WriteLine(cha+"   "+"is vowel");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(cha + "   " + "is consonent");
            }
        }
    }
    


    class character3
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

                                               // Alphabet checking condition using && , || operator
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch +  "     "+  "is an Alphabet. ");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch +"     "+"is  Digit. ");
            }
            else
            {
                Console.WriteLine(ch + "       "+"is symbol ");
            }

            Console.ReadLine();
        }
    }
}
    
    
    
 








