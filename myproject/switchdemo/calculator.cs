using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.switchdemo
{
    class calculator
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string oprand;
            float answer;
            Console.WriteLine("enter 1st number");
             num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("enter the oprand");
            oprand = Console.ReadLine();
            Console.WriteLine("enter 2nd number");

            num2 = int.Parse(Console.ReadLine());
            
            switch (oprand)
            {
                case "+":
                    Console.WriteLine(num1+num2);
                    break;
                case "-": Console.WriteLine(num1-num2);
                    break;
                case "*": Console.WriteLine(num1*num2);
                    break;
                case "/": Console.WriteLine(num1/num2);
                    break;
                default: answer = 0;
                    break;

            }










        }
    }
}
