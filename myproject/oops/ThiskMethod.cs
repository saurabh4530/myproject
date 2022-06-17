using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.oops
{
    class ThisMethod
    {
        int x;
        public ThisMethod(int x)
        {
            this.show();
        }
        public ThisMethod() : this(73)
        {
            Console.WriteLine("Default");
        }
        public void show()
        {
            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            ThisMethod t = new ThisMethod();
        }


    }
    class Shopping
    {
        string item;
        int price;
        int qty;
        public void Accept(string tv, int tprice , int tqty)
        {
            item = tv;
            price = tprice;
            qty = tqty;

        }
        public void GetBill()
        {
            int bill = qty * price;
            if (qty>0)
            {
                Console.WriteLine("total bill is  "+bill);
                
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        void show()
        {
            Console.WriteLine("item \t price \t qty");
            Console.WriteLine(item+ "      " +price+"      "+qty);
           
        }
        static void Main(string[] args)
        {
            Shopping s = new Shopping();
            s.Accept("LG", 20000, 0);
            s.GetBill();
            s.show();


        }
    }
    class Employee
    {
        int id;
        string name;
        int salary;
        public Employee(int eid, string ename,int esalary)
        {
            id = eid;
            name = ename;
            salary = esalary;
        }
        void Display()
        {
            Console.WriteLine(id+" "+name+" "+salary);
        }
        static void Main(string[] args)
        {
            Employee e = new Employee(101, "amit",50000);
            e.Display();
        }
    }
    class ThisConstructor
    {                           //constructor chaining
        public ThisConstructor():this(55)
        {
            Console.WriteLine("default");
        }
        public ThisConstructor(int x)
        {
            Console.WriteLine("x= "+ x);
        }
        public ThisConstructor(string city):this()
        {
            Console.WriteLine(city);
        }
        static void Main(string[] args)
        {
            ThisConstructor t = new ThisConstructor("pune");
        }
    }
    class ThisVariable
    {
        int x;
        public ThisVariable(int x)
        {
            this.x = x;
        }
        public void show()
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            ThisVariable t = new ThisVariable(4);
            t.show();
        }
    }

}
