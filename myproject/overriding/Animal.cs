using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.overriding
{
    class Animal
    {
        public virtual void eat()
        {                                      // parent
            Console.WriteLine("animal is eating");
        }
    }
    class Dog:Animal
    {
        public override void eat()       // child
        {
            Console.WriteLine("dog is eating");
        }
    }
    class Cat:Animal
    {
        public void eat()
        {
            Console.WriteLine("cat is eating");
        }
    }
    class Override1
    {
        static void Main(string[] args)
        {

            Animal a = new Dog();
            a.eat();
          
        }
    }
}
