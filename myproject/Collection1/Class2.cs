using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Collection1
{
    class Class2
    {
        static void Main(string[] args)
        {
            List<string> l2 = new List<string>() { "deepa","medha","kirti"};
            List<string> lst = new List<string>(20);
            Console.WriteLine(lst.Count);
            Console.WriteLine(lst.Capacity);
            lst.Add("A");
            lst.Add("B");
            lst.Add("A");
            lst.Add("D");
            lst.Add("A"); 
            lst.Add("E"); 
            lst.Add("H");

            lst.AddRange(l2);
            lst.InsertRange(0, l2);
            lst.Remove("A");
            lst.RemoveAt(0);
            lst.Add("chitra");
            lst.Insert(3, "CHITRA");

            string[] str = lst.ToArray();

            int idx1 = lst.IndexOf("H");

            int idx2 = lst.LastIndexOf("A");
            Console.WriteLine(lst.Contains("kavita"));
            //  lst.Clear();


           






        }
    }
    class Student:IComparable<Student>
    {
        string name;
        int percent;
        string qualification;
       
        public Student (string name, int percent, string qualification)
        {
            this.name = name;
            this.percent = percent;
            this.qualification = qualification;

        }
        public override string ToString()
        {
            return "Name=" + name + "percentage=" + percent + "Qualification=" + qualification;

        }
        public int CompareTo(Student other)
        {
            return this.percent.CompareTo(other.percent);
        }
        public string Name { get=>name; set=>name=value; }
        public int Percent { get=>percent; set=>percent=value; }
        public string Qualification { get => qualification; set => qualification = value; }

    }
    class Stud
    {
        static void Main(string[] args)
        {
            List<Student> slist = new List<Student>();
            slist.Add(new Student("ajinkya", 90, "B.E"));
            slist.Add(new Student("sujay", 93, "B.E"));
            slist.Add(new Student("kunal", 93, "B.E"));
            slist.Add(new Student("ajit", 92, "B.E"));
            slist.Add(new Student("eshan", 89, "B.E"));
            slist.Sort();
            slist.ForEach(s1 => Console.WriteLine(s1)) ;

            List<Student> ss = slist.FindAll(sobj => sobj.Percent > 90);
            foreach (Student s in slist)
            {
                if (s.Percent>90)
                {
                    Console.WriteLine(s.Name+" "+s.Percent+" "+s.Qualification);
                }
            }
        }
    }
    class A
    {
        static bool isodd(int n)
        {
            Console.WriteLine("in odd" + n);
            return n % 2 == 1;

        }
        static void Main(string[] args)
        {
            List<string> lst = new List<string>() { "Deepa", "Medha", "kirti", "Amit" };
            lst.Sort();
            lst.Reverse();
            foreach(string s in lst)
            Console.Write(s + " ");


            List<int> l2 = new List<int>() { 23, 44, 56,77,89,35};
            List<int> oddlist = l2.FindAll(isodd);
            foreach (int s in oddlist)
            {
                Console.WriteLine(s+"  ");
            }
        }
    }
    class AA
    {
        static void Main(string[] args)
        {
            Tuple<int, string, string> tuple1 = new Tuple<int, string, string>(1, "saurabh", "B.E");
            Console.WriteLine(tuple1);

        }
    }  
    class Demolinklist
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(100);
            ll.AddLast(200);
            ll.AddFirst(300);
            ll.AddFirst(50);
           LinkedListNode<int> n1 = ll.Find(100);

            ll.AddAfter(n1, 150);// ll.AddAfter(ll.Find(100), 150);
            ll.AddBefore(n1, 90);
            ll.Remove(150);

            foreach (int data in ll)
            {
                Console.WriteLine(data);
            }
        }
    }
    class Demodictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("ajinkya", 90);
            dd.Add("rupesh", 90);
            dd.Add("jyoti", 91);
            dd.Add("om", 99);
            dd["ajinkya"] = 95;
            dd.Remove("rupesh");
            Console.WriteLine(dd.Count);
            // dd.Clear();
            Console.WriteLine(dd.ContainsKey("om"));
            Console.WriteLine(dd.ContainsValue(90));


           // List<string>keys = dd.Keys.ToList();
            Console.WriteLine(dd["jyoti"]);

        }
    }
    
}
