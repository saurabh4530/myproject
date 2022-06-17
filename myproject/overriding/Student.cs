using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.overriding
{
    class Student
    {
        public int mark = 55;
    }
    class Teacher:Student
    {
        public int mark = 66;
        public void show()
        {
            Console.WriteLine(mark+" "+base.mark);
        }
    }
    class Basekeyword

    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            t.show();
        }
    }



    class Mobile
    {
        string memory = "64gb";
        public Mobile(int x)//(int x, int y)
        {
            Console.WriteLine(" mobile memory ="+memory+" "+x);
        }
    }
    class Apple:Mobile
    {  
        public Apple(int y ):base(y)//(23, y)
        {
            Console.WriteLine("apple");
        }
    }
    class Baseconstructor
    {
        static void Main(string[] args)
        {
            Apple a = new Apple(234);


        }
    }
}
