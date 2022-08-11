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
    }class Patternn
    {

        static void Main(string[] args)
        {
            for (int i = 5; i >=1; i--)
            {
                for (int j = i; j >=i; j--)
                {
                    if (j%2==0)
                    {
                        Console.Write("1");
                    }
                    else
                        Console.Write("0");
                }
                Console.WriteLine();
            }
        }
    }
}
    

