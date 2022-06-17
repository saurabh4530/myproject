using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.switchdemo
{
    class switchdemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value");
            string input = Console.ReadLine();

            switch (input)
            {
                case "happy":
                    Console.WriteLine("I am happy");
                    break;
                case "sad": Console.WriteLine(" I am sad");
                    break;
                default: Console.WriteLine("not happy");
                    break;
            }
        }
    }


    class character
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the char");
            char ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case'a': Console.WriteLine("vowel");
                    break;
                case 'i': Console.WriteLine("vowel");
                    break;
                case 'e': Console.WriteLine("vowel");
                    break;
                case 'o': Console.WriteLine("vowel");
                    break;
                case 'u': Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("is consonent");
                    break;
            }

        }
    }
}
