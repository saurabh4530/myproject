using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.exam
{
    class List1
    {
        //  WAP to create a new List, add some colors(string) and print the collection.
        static void Main(string[] args)
        {
            List<string> ll = new List<string>();
            ll.Add("Red");
            ll.Add("greeen");
            ll.Add("blue");
            ll.Add("Pink");
            foreach (string d in ll)
                Console.WriteLine(d);
            Console.ReadLine();

        }
    }
    class  List2
    {//WAP to create List of Students and iterate over it. 

        static void Main(string[] args)
        {
            List<string> ll = new List<string>();
            ll.Add("saurabh");
            ll.Add("ram");
            ll.Add("Raj");
            ll.Add("raju");
            ll.Add("harsh");
            foreach (string s in ll)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
    class List3
    {
        //WAP to print list in reverse order 
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                lst.Add(i);
            }
            foreach (int i in lst)
                Console.WriteLine(i);
            Console.ReadLine();
            Console.WriteLine("After reverse order :");
            lst.Reverse();
            foreach (int d in lst)
                Console.WriteLine(d);
        }
    }
    class List4
    {

        //WAP to get only the Values from a Dictionary. 
        static void Main(string[] args)
        {
            Dictionary<int, string> dd = new Dictionary<int, string>();
            dd.Add(1, "Ram");
            dd.Add(2, "raju");
            dd.Add(3, "raj");
            dd.Add(4, "Rahul");
            dd.Add(5, "Samir");
            dd.Add(6, "May");
            dd.Add(7, "raja");
            List<string> v1 = new List<string>();

            foreach (string s in v1)
                Console.WriteLine(s);
        }
    }
    class List5
    {
        //WAP to get only the Values from a Dictionary. 
        static void Main(string[] args)
        {
            Dictionary<int, string> dd = new Dictionary<int, string>();
            dd.Add(1, "Ram");
            dd.Add(2, "saurabh");
            dd.Add(3, "john");
            dd.Add(4, "Rahul");
            dd.Add(5, "Samir");
            dd.Add(6, "shubham");
            dd.Add(7, "om");
            List<int> v1 = new List<int>();

            foreach(int i in v1) 
                Console.WriteLine(i);
        }
    }
    class List6
    {
        //11.	WAP to add elements to a Dictionary and print content of it. Use int as Key and String as Value. In second Dictionary add elements of String type as Key and Int as Value.
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Raj");
            d.Add(2, "saurabh");
            d.Add(3, "Rahul");
            d.Add(4, "Shubham");
            d.Add(5, "Harshal");
            foreach (KeyValuePair<int, string> kv in d)
                Console.WriteLine(kv.Key + "==>" + kv.Value);

        }
    }
    class List7
    {// WAP to create a Dictionary using Custom class as key and any other object as value
        static void Main(string[] args)
        {
            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("Nilesh", 11);
            dd.Add("Raj", 12);
            dd.Add("mayur", 13);
            dd.Add("raju", 14);
            dd.Add("saurabh", 15);
            dd.Add("prasad", 16);
            foreach (KeyValuePair<string, int> kv in dd)
                Console.WriteLine(kv.Key + "==> " + kv.Value);
            Console.ReadLine();
        }


    }
    class List8
    {
        // WAP to create a Stack to store some objects and iterate over it.Also show use of push,pop,peek.
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(100);
            st.Push(200);
            st.Push(300);
            st.Push(400);
            st.Push(500);
            st.Pop();
            int datapeek = st.Peek();
            Console.WriteLine("Peek :" + datapeek);
            foreach (int i in st)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    } 
    class List9
    {
        // WAP to create a Queue to add 5 objects and also remove first two and iterate over it.

        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(100);
            q.Enqueue(200);
            q.Enqueue(300);
            q.Enqueue(400);
            q.Enqueue(500);
            int remove = q.Dequeue();
            int removeat = q.Dequeue();
            foreach (int i in q)
                Console.WriteLine(i);
            Console.ReadLine();

        }
    }
    class List10
    {
        //	WAP to print list in reverse order .
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                lst.Add(i);
            }
            foreach (int i in lst)
                Console.WriteLine(i);
            Console.ReadLine();
            Console.WriteLine("After reverse order :");
            lst.Reverse();
            foreach (int d in lst)
                Console.WriteLine(d);
        }
    }
    class List11
    {
        static void Main(string[] args)
        {

        }
    }

}
