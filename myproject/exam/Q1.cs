using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.exam
{
    class EvenOddCount
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];
            Console.WriteLine("enter elements of array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(string.Join(" ", a));
            int countEven = 0;
            int countOdd = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }
            Console.WriteLine( countEven + "  "  + countOdd);
            Console.ReadLine();
        }
    }
    class Q2
    {//Predict the output:101,102
        static int mcCartyCounter = 100;
        public static int mcCarthy(int n)
        {
            mcCartyCounter++;
            if (n > 100)
                return n - 10;
            else
                return mcCarthy(n + 11);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(mcCarthy(100) + "  " + mcCartyCounter);
            Console.ReadLine();
            
        }


    }
    class Nib
    {
        string materialtype;
        int width;
        public string Materialtype
        {
            get { return materialtype; }
            set { materialtype = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public void shownib()
        {
            Console.WriteLine(Materialtype + " " + Width);
        }
    }
    class Refill
    {
        string inkColour;
        int Length;
        Nib nib;
        public string InkColour
        {
            get { return inkColour; }
            set { inkColour = value; }
        }
        public int length
        {
            get { return Length; }
            set { Length = value; }
        }
        public Nib Nibtype
        {
            get { return nib; }
            set { nib = value; }
        }
        public void showRefill()
        {
            Console.WriteLine(InkColour + " " + Length);
            Nibtype.shownib();
        }

    }
    class Pen
    {
        Refill refill;
        string brand;
        int caplength;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int Caplength
        {
            get { return caplength; }
            set { caplength = value; }
        }
        public Refill Refills
        {
            get { return refill; }
            set { refill = value; }
        }
        public void showPen()
        {
            Refills.showRefill();
            Console.WriteLine(Brand + " " + Caplength);

        }
        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.Brand = "reynolds";
            p.caplength = 7;
              p.Refills.InkColour = "red";
            p.Refills.length = 10;
            p.Refills.Nibtype.Materialtype = "stainless steel";
            p.Refills.Nibtype.Width =2;
            p.showPen();
            Console.ReadLine();
        }
    }

    class Separatezeros
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];

            Console.WriteLine("enter elements of array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine(string.Join(" ", a));

            int pos = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    a[i] = a[pos];
                    pos++;
                }



            }
            while (pos < a.Length)
            {
                a[pos] = 0;
                pos++;
            }
            Console.WriteLine(string.Join(" ", a));
            Console.ReadLine();
        }

    }
    
  
   
    class Subengine
    {
        string subenginetype;
        public Subengine(string subenginetype)
        {
            this.subenginetype = subenginetype;
        }
        public void showsub()
        {
            Console.WriteLine(subenginetype);
        }
    }
    class Engine
    {
        int engineid;
        string lastenginecleandate;
        Subengine sub;
        public Engine(int engineid, string lastenginecleandate, Subengine sub)
        {
            this.engineid = engineid;
            this.lastenginecleandate = lastenginecleandate;
            this.sub = sub;
        }
        public void showengine()
        {
            Console.WriteLine(engineid + " " + lastenginecleandate);
            sub.showsub();
        }

    }
    class Gear
    {
        string type;
        public Gear(string type)
        {
            this.type = type;
        }
        public void showgear()
        {
            Console.WriteLine(type);
        }
    }
    class Car
    {
        int carId;
        string carcolour;
        Engine engine;
        Gear gear;

        public Car(int carId, string carcolour, Engine engine, Gear gear)
        {
            this.carId = carId;
            this.carcolour = carcolour;
            this.engine = engine;
            this.gear = gear;
        }
        public void showcar()
        {
            Console.WriteLine(carId + " " + carcolour);
            engine.showengine();
            gear.showgear();
        }

    }
    class Car1
    {
        static void Main(string[] args)
        {
            Car c = new Car(123, "white", new Engine(111, "06/26/2022", new Subengine("petrol")), new Gear("auto"));
            c.showcar();
            Console.ReadLine();
        }

    }
    class Q9
    {
        //0,2,4,6,8
        static void Main(string[] args)
        {
            int[] var = new int[10];
            for (int i = 0; i < 10; ++i)
            {
                var[i] = i;
                Console.WriteLine(var[i] + " ");
                i++;
            }
            
            Console.ReadLine();

        }
    }
    
    class Q11
    {
        static void Main(string[] args)
        {
            // o/p=1 2 3
            int[] a1 = { 1, 2, 3 };

            int[] a2 = new int[a1.Length];
            for (int i = 0; i < a1.Length; i++)
            {
                a2[i] = a1[i];
            }
            for (int i = 0; i < a2.Length; i++)
            {

                Console.WriteLine(a2[i]);
            }
            Console.ReadLine();

        }










    }
    class Replace
    {
       // replace all the 0’s with 1’s in your array.
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            int[] a1 = new int[a.Length];
            for (int i = 0; i < a1.Length; i++)
            {
                if (a[i] == 0)
                {
                    a1[i] = 1;
                }
                else
                {
                    a1[i] = a[i];
                }

            }
            Console.WriteLine(string.Join(" ", a1));
            Console.ReadLine();
        }


    }
    class Printnumber
    {//*Write a  program that prints the numbersfrom 1 to 50.
      
          
        static void Main(string[] args)
        {
            int countbuzz = 0;
            int countfizz = 0;
            int countbuzzfizz = 0;

            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("buzzfizz");
                    countbuzzfizz++;

                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("buzz");
                    countbuzz++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("fizz");
                    countfizz++;

                }
                else
                {
                    Console.WriteLine(i);
                }



            }
            Console.WriteLine( countbuzzfizz + "  "+ countbuzz + "    " + countfizz);
            Console.ReadLine();

        }

    }


}

