using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.oops
{

    class Address
    {
        public int pincode;
        public string city;
        public int Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
    class Person
    {
        int id;
        string name;
        Address adr;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Address Adr
        {
            get { return adr; }
            set { adr = value; }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Id = 1;
            p.Name = "saurabh";
            p.Adr = new Address();

            p.Adr.Pincode = 412412;
            p.Adr.City = "pune";
            Console.WriteLine(p.Id + " " + p.Name + " " + p.Adr.Pincode + " " + p.Adr.City);
        }
    }
    class Engine
    {
        string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

    }
    class Carf
    {
        int modelno;
        string name;
        int price;
        Engine eng;
        public int Modelno
        {
            get{ return modelno; }
            set {modelno = value; }
    
        }
        public string Name
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
        public Engine Eng
        {
            get { return eng; }
            set { eng = value; }

        }
        static void Main(string[] args)
        {
            Carf c = new Carf();
            c.Modelno = 655;
            c.Name = "Nano";
            c.Price = 150000;
            c.Eng = new Engine();

            c.Eng.Type = "ic engine";
            Console.WriteLine(c.Modelno+" "+c.Name+"  "+c.Price+"  "+c.Eng.Type );
        }
    }
   class Employeeget
    {

        int id;
         string name;
         double salary;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    
    
    
        static void Main(string[] args)
        {
            Employeeget emp = new Employeeget();
            emp.Id = 150696;
            emp.Name = "saurabh";
            emp.Salary = 19000;
            Console.WriteLine(emp.Id + " " + emp.Name + " " + emp.Salary);
        }
   }
 
}



















   




      