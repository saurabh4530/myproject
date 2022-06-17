using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.switchdemo
{
    class evenodd
    {
        static void Main(string[] args)
        {
          
            Console.Write("Enter any number to check even or odd: ");
             int  num = Convert.ToInt32(Console.ReadLine());

            switch (num % 2)
            {
                                                                                         //If n%2 == 0
                case 0:
                    Console.WriteLine(num + " is even number");
                    break;

                                                                                         //Else if n%2 == 1
                case 1:
                    Console.WriteLine(num + " is odd number");
                    break;
            }

                      Console.ReadLine();

        }


    }
}
