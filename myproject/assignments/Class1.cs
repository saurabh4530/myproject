using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.assignments
{
    class Class1                                      //leap year
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the year");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine(year + "is leap year");
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine(year + "is leap year");

            }
            else if (year % 100 == 0)
            {
                Console.WriteLine(year + " is not leap year");
            }
            else
            {
                Console.WriteLine(year + "is not leap year");
            }
            Console.ReadLine();
        }

    }

    class class2                                       //zero ,+, -
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine(num + "is zero");
            }
            else if (num > 0)
            {
                Console.WriteLine(num + "is positive");

            }
            else
            {
                Console.WriteLine(num + "num is negative");
            }
            Console.ReadLine();
        }
    }

    class class3
    {
        static void Main(string[] args)                  // alphabet, digit , symbol
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            // Alphabet checking condition using && , || operator
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + "     " + "is an Alphabet. ");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + "     " + "is  Digit. ");
            }
            else
            {
                Console.WriteLine(ch + "       " + "is symbol ");
            }

            Console.ReadLine();
        }
    }

    class class4
    {                                           // even and odd
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("enter number is even");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("enter number is odd");
                Console.ReadLine();
            }




        }
    }


    class class5
    {
        static void Main(string[] args)     // div by 5, 11 or not
        {
            Console.WriteLine("enter the number ");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine(num + "   is div by 5 and 11");
            }
            else
            {
                Console.WriteLine(num + " is not div by 5 and 11");
            }
            Console.ReadLine();
        }

    }

    class class6
    {
        static void Main(string[] args)             // maximum betn 3 num
        {
            Console.WriteLine("enter first number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third number");
            int n3 = int.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine(n1 + "  is maximum");

            }
            else if (n2 > n3 && n2 > n1)
            {
                Console.WriteLine(n2 + "  is maximum");

            }
            else if (n3>n1 && n3>n2)
            {
                Console.WriteLine(n3 + "   is maximum");
            }
            else
            {
                Console.WriteLine(" all are equal");
            }
            Console.ReadLine();

        }
    }


    class class7
    {                                                               // vowel and consonent
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
            else if (ch == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonent");
            }
            Console.ReadLine();
        }
    }
    class class8
    {                                                           // 3 digit num 
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());

            if (n > 99 && n < 1000)
            {
                Console.WriteLine(n + "  is three digit number");

            }
            else
            {
                Console.WriteLine(n + "    is not three digit number");
            }
            Console.ReadLine();


        }
    }
    class class9
    {
        static void Main(string[] args)
        {                                                                       // calculator
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
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    answer = 0;
                    break;

            }
            Console.ReadLine();
        }
    }
   class class10                       //salary
    {
        static void Main(string[] args)
        {
            double BasicSalary, DA, HRA, Gross_Salary;

            Console.Write("Enter Basic Salary : ");
            double Basicsalary = double.Parse(Console.ReadLine());

            if (Basicsalary < 10000)
            {
                DA = (Basicsalary * 80) / 100;
                HRA = (Basicsalary * 20) / 100;
                Gross_Salary = Basicsalary + DA + HRA;
                Console.WriteLine("Dearness Allowance 80 % of Basic Salary : " + DA);
                Console.WriteLine("House Rent 20 % of Basic Salary : " + HRA);
                Console.WriteLine("Gross Salary : " + Gross_Salary);
            }
            else if (Basicsalary <= 20000)
            {
                DA = (Basicsalary * 90) / 100;
                HRA = (Basicsalary * 25) / 100;
                Gross_Salary = Basicsalary + DA + HRA;
                Console.WriteLine("Dearness Allowance 90 % of Basic Salary : " + DA);
                Console.WriteLine("House Rent 25 % of Basic Salary : " + HRA);
                Console.WriteLine("Gross Salary : " + Gross_Salary);
            }
            else if (Basicsalary > 20000)
            {
                DA = (Basicsalary * 95) / 100;
                HRA = (Basicsalary * 30) / 100;
                Gross_Salary = Basicsalary + DA + HRA;
                Console.WriteLine("Dearness Allowance 95 % of Basic Salary : " + DA);
                Console.WriteLine("House Rent 30 % of Basic Salary : " + HRA);
                Console.WriteLine("Gross Salary : " + Gross_Salary);
            }
            else
            {
                Console.WriteLine("you have no salary");
            }
            Console.ReadLine();
        }


    }

    class class11
    {
        static void Main(string[] args)                     //days betn 1to7
        {
            Console.WriteLine("Enter days from 1to 7: ");
            int days = Convert.ToInt32(Console.ReadLine());

            switch (days)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid input! Please enter week no. between 1-7.");
                    break;
            }
            Console.ReadLine();
        }
    }

    class class12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter days from 8to 14: ");
            int days = Convert.ToInt32(Console.ReadLine());

            switch (days)
            {
                case 8:
                    Console.WriteLine("Monday");
                    break;
                case 9:
                    Console.WriteLine("Tuesday");
                    break;
                case 10:
                    Console.WriteLine("Wednesday");
                    break;
                case 11:
                    Console.WriteLine("Thursday");
                    break;
                case 12:
                    Console.WriteLine("Friday");
                    break;
                case 13:
                    Console.WriteLine("Saturday");
                    break;
                case 14:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("error, day does not exist");
                    break;
            }
            Console.ReadLine();
        }
    }
    class class13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number between 1 to 5");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2: Console.WriteLine("two");
                    break;
                case 3: Console.WriteLine("three");
                    break;
                case 4: Console.WriteLine("four");
                    break;
                case 5: Console.WriteLine("five");
                    break;
                default: Console.WriteLine("num is not betn 1 to 5");
                    break;
            }
            Console.ReadLine();
        }
    }
    class class14
    {
        static void Main(string[] args)
        {

        }
    }

}




