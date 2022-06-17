using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.abs
{
    public interface IAddition
    {
        static int a = 1;
    }
    abstract class Addition
    {
       public static int b=3;
    }
    class Addn:Addition,IAddition
    {
      
        public void addn()
        {
            Console.WriteLine("addition     "+(IAddition.a+Addition.b));
        }
       


    }
    class Abstractdemo
    {
        static void Main(string[] args)
        {
            Addn a = new Addn();
            a.addn();

        }
    }





    abstract class Animal
    {
        public abstract void animal();


    }
    class Dog : Animal
    {
        public override void animal()
        {
            Console.WriteLine(" i am dog"); 
        }
        public void show()
        {
            Console.WriteLine("dog");
        }
    }
    class Cat : Animal
    {
        public override void animal()
        {
            Console.WriteLine(" i am cat");
        }
        public void show()
        {

            Console.WriteLine("cat");
         }
    }
    class HierarchycalAbstraction
    {
        static void Main(string[] args)
        {
            Dog d= new Dog();
            d.animal();
            d.show();
            Cat c = new Cat();
            c.animal();
            c.show();
            Console.ReadLine(); 


        }

    }

}
