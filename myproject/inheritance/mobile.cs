using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.inheritance
{
    class Mobile
    {
        public string storage = "64gb";
    }
    class Redmi:Mobile
    {
        public string battery = "4500mAph";

    }
    class Samsung:Mobile
    {
        public string RAM = "8 gb";

    }
    class Vivo : Mobile
    {
        public string camera = "48mp";

    }
    class hierachydemo
    {
        static void Main(string[] args)
        {
            Redmi r = new Redmi();
            Console.WriteLine("redmi   "+r.battery+" "+r.storage);
            Samsung s = new Samsung();
            Console.WriteLine("samsung "+" "+s.RAM+" "+s.storage);
            Vivo v = new Vivo();
            Console.WriteLine("vivo  "+v.camera+" "+v.storage);
        }
    }











    class Teacher
    {
        public string name = "subject teacher";

    }
    class Physics : Teacher
    {
        public string physics = "physic teacher";

        class Chemistry : Teacher
        {
            public string chemistry = "chemistry teacher";

        }
        class Math : Teacher
        {
            public string math = "math teacher";
        }
        class hierachydemo1
        {
            static void Main(string[] args)
            {
                Physics p = new Physics();
                Console.WriteLine("physics  " + p.name + " " + p.physics);
                Chemistry c = new Chemistry();
                Console.WriteLine("chemistry "+c.name+" "+c.chemistry);
                Math m = new Math();
                Console.WriteLine("math "+m.name+" "+m.math);
            }
        }      }
    }
