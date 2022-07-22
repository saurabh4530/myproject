using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.oops
{
    class Car
    {

       public string model;
        public string name;
        public    string color;
        public int price;

        

        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.name = "ford";
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.price = 25000;

            Car Opel = new Car();
            Opel.name = "opel";
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.price = 200000;
            Console.WriteLine("model  name  color  price");
            Console.WriteLine(Ford.model+"  "+Ford.name+"  "+Ford.color+"  "+Ford.price);
            Console.WriteLine(Opel.model+"  "+Opel.name+"  "+Opel.color+"  "+Opel.price);
        }
    }
    class Student
    {
        public int id;
        public string name;
        public int m1, m2, m3;
        public int per;
        public void Details(int sid, string sname, int sub1, int sub2,int  sub3 )          
        {
            id = sid;
            name = sname;
            m1 = sub1;
            m2 = sub2;
            m3 = sub3;

        }
        public void Calculate()
        {
            per = (m1 + m2 + m3) / 3;

        }
        void Disply()
        {
            Console.WriteLine("id \t name \t m1 \t m2 \t m3 \t per");
            Console.WriteLine(id+"      "+name+"    "+m1+"    "+m2+"     "+m3+"       "+per);
        }
        static void Main(string[] args)
        {
            Student nikhil;
            nikhil = new Student();
            nikhil.Details(1, "saurabh", 55, 66, 77);
            nikhil.Calculate();
            nikhil.Disply();
        }
    }

   
}

