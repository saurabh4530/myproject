using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.inheritance
{
    class Human
    {
        public string name = "saurabh";

    }

    class Man : Human
    {
        public int age = 24;

    }

    class Employee : Man
    {
        public int eid = 87;
        public int esalary = 767878;



        public void show()
        {

            Console.WriteLine("Emp Name:    " + name);
            Console.WriteLine("Emp Age:     " + age);
            Console.WriteLine("Emp ID:      " + eid);
            Console.WriteLine("Emp Salary:  " + esalary);

        }
    }
    class MultilevelDemo
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.show();
        }
    }


    class Education
    {
        public string name = "education ";

    }

    class Engineering : Education
    {
        public string choice = "stream";

    }

    class Branch : Engineering
    {

        public string branch = "chemical";



        public void show()
        {

            Console.WriteLine(name + " " + choice + " " + branch);


        }
    }
    class MultilevelDemo1
    {
        static void Main(string[] args)
        {
            Branch b = new Branch();
            b.show();
        }

    }
}