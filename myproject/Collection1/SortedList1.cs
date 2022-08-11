using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Collection1
{
    class SortedList1
    {
        static void Main(string[] args)
        {
            SortedList<Student, string> ss = new SortedList<Student, string>();
            ss.Add(new Student("adi", 90, "MCS"), "Java");
            ss.Add(new Student("darshan", 91, "MCS"), "c#");
            ss.Add(new Student("samir", 60, "Mcs"), "c#");

            ss.Add(new Student("harsh", 92, "MCS"), "Java");
            ss.Add(new Student("myraa", 93, "MCS"), "Java");
            foreach (KeyValuePair<Student, string> kv in ss)
            {
                Console.WriteLine(kv.Key + " --------" + kv.Value);
            }
        }
    }
    class SBSort//:IComparer<StringBuilder>
    {
        public int compare(StringBuilder x, StringBuilder y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }
    class SortedList2
    {
        static void Main(string[] args)
        {
            SortedList<StringBuilder, int> ss = new SortedList<StringBuilder, int>();
            ss.Add(new StringBuilder("amit"), 90);
            ss.Add(new StringBuilder("amita"), 90);
            ss.Add(new StringBuilder("adu"), 90);
            ss.Add(new StringBuilder("ciya"), 90);
            foreach (KeyValuePair<StringBuilder, int> kv in ss)
            {
                Console.WriteLine(kv.Value + " " + kv.Key);

            }


        }
    }
    class SortedList3
    {
        static void Main(string[] args)
        {
            SortedList<string, int> ss = new SortedList<string, int>();
            ss.Add("priya", 99);
            ss.Add("riya", 99);
            ss.Add("diya", 99);
            ss.Add("siya", 99);
            ss.Add("hiya", 99);
            ss.Add("tiya", 99);
            ss.Add("kiya", 99);
            ss.Add("ayuash", 99);

            ss.Remove("hiya");
            ss["kiya"] = 90;
            Console.WriteLine(ss.ContainsKey("aa"));
            Console.WriteLine(ss.Count);
            foreach (KeyValuePair<string, int> kv in ss)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

        }
    }
    class Hashsetdemo
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("amit");
            hs.Add("amita");
            hs.Add("amey");
            hs.Add("amit");
            bool x = hs.Add("amit");
            foreach (string s in hs)
                Console.WriteLine(s);

            /* HashSet<book> hs2 = new HashSet<book>();
             hs2.Add(new book(1, "java", "kantekar", 900));
             hs2.Add(new book(1, "java", "kantekar", 900));

             foreach (book b in hs2)
             {
                 Console.WriteLine(b); ;
             }*/


        }
    }
    class employee
    {
        public string Name { set; get; }
        public int  salary { set; get; }
    }

    class listemp
    {
        static void Main(string[] args)
        {
            List<employee> emp = new List<employee>()
            {
            new employee() {Name= "saurabh ", salary=20000 },
             new employee() {Name= "akshaay ", salary=20000 },
                new employee() {Name= "samir ", salary=20000 },




            };
           
            foreach (employee e in emp)
            {
                Console.WriteLine(e);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<User> listOfUsers = new List<User>()
        {
        new User() { Name = "John Doe", Age = 42 },
        new User() { Name = "Jane Doe", Age = 34 },
        new User() { Name = "Joe Doe", Age = 8 },
        };

            foreach (User u in listOfUsers)
            {
                Console.WriteLine(u);
            }
            
        }
    }

    class User
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
  

