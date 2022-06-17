using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.inheritance
{
    class Fruit
    {
        public int qty = 0;
        public void Display()
        {
            Console.WriteLine("fruit");
        }
    }
    class Apple:Fruit
    {
        public void show()
        {
            qty = 5;
            Console.WriteLine(qty);
        }
    }
    class SingleInheritanceDemo
    {
        static void Main(string[] args)
        {
            Apple a = new Apple();
            a.Display();
            a.show();

        }
    }




    class Bike
    {
        public int tyre = 0;
        public void Display()
        {
            Console.WriteLine("bike");
        }

    }
    class splender:Bike
    {
      public void Show()
        {
            tyre = 2;
            Console.WriteLine(tyre);
        }
    }
    class SingleDemo
    {
        static void Main(string[] args)
        {
            splender s = new splender();
            s.Display();
            s.Show();
        }
    }




}
