using System;

namespace myproject
{
    public class P
    {
        public virtual void p()
        {
            Console.WriteLine("Parent ");
        }
    }
    public class T : P
    {
        public override void p()
        {
            Console.WriteLine("child");
        }
        class Program
        {
            static void Main(string[] args)
            {
                T t = new T();
                t.p();
            }
        }
    }  }
    

