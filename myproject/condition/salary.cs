using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.condition
{
    class salary
    {
        static void Main(string[] args)
        {
            Double Basic_Salary, DA, HRA, Gross_Salary;

            Console.Write("Enter Basic Salary : ");
            Basic_Salary = Convert.ToInt32(Console.ReadLine());

            DA = (Basic_Salary * 95) / 100;
            HRA = (Basic_Salary * 20) / 100;
            Gross_Salary = Basic_Salary + DA + HRA;

            Console.WriteLine("Dearness Allowance 80 % of Basic Salary : " + DA);
            Console.WriteLine("House Rent 20 % of Basic Salary : " + HRA);
            Console.WriteLine("Gross Salary : " + Gross_Salary);
        }


    }

    class salary2
    {
        static void Main(string[] args)
        {
            Double Basic_Salary, DA, HRA, Gross_Salary;

            Console.Write("Enter Basic Salary : ");
            Basic_Salary = Convert.ToInt32(Console.ReadLine());

            DA = (Basic_Salary * 90) / 100;
            HRA = (Basic_Salary * 25) / 100;
            Gross_Salary = Basic_Salary + DA + HRA;

            Console.WriteLine("Dearness Allowance 90 % of Basic Salary : " + DA);
            Console.WriteLine("House Rent 25 % of Basic Salary : " + HRA);
            Console.WriteLine("Gross Salary : " + Gross_Salary);
        }
    }


    class salary3
    {
        static void Main(string[] args)
        {
            Double Basic_Salary, DA, HRA, Gross_Salary;

            Console.Write("Enter Basic Salary : ");
            Basic_Salary = Convert.ToInt32(Console.ReadLine());

            DA = (Basic_Salary * 95) / 100;
            HRA = (Basic_Salary * 30) / 100;
            Gross_Salary = Basic_Salary + DA + HRA;

            Console.WriteLine("Dearness Allowance 95 % of Basic Salary : " + DA);
            Console.WriteLine("House Rent 30 % of Basic Salary : " + HRA);
            Console.WriteLine("Gross Salary : " + Gross_Salary);
        }
    }
}
    