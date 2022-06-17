using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.oops
{
   class Nib
    {
        string nibtype;
        public string NibType
        {
            get { return nibtype; }
            set { nibtype = value; }
        }
    }
    class Pen
    {
        string penname;
        string pencolor;
        Nib n;
        public string PenName
        {
            get { return penname; }
            set { penname = value; }
        }
        public string PenColor
        {
            get { return pencolor; }
            set { pencolor = value; }
        }
        public Nib N
        {
            get;
            set;
        }

    }



    class Bag
    {
        string color;
        string brandname;
        int price;
        Pen p;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string BrandName
        {
            get { return brandname; }
            set { brandname = value; }

        }
        public int Price
        {
            get;
            set;

        }
        public Pen P
        {
            get { return p; }
            set { p = value; }
        }
        static void Main(string[] args)
        {
            Bag b = new Bag();
            b.Color = "red";
            b.BrandName = "cello";
            b.Price = 5;
            b.P = new Pen();
            b.P.PenName = "jel pen";
            b.p.PenColor = "blue";
            b.p.N = new Nib();
            b.p.N.NibType = "metal";
            
            Console.WriteLine(b.Color+" "+b.BrandName+" "+b.Price+" "+b.p.PenName+" "+b.p.PenColor+" "+b.p.N.NibType);

        }

    }



    class Order_date
    {
        public int mm;
        public int dd;
        public int yy;

        public Order_date(int mm, int dd, int yy)
        {
            this.mm = mm;
            this.dd = dd;
            this.yy = yy;
        }
        public void show()
        {
            Console.WriteLine(mm + " " + dd + " " + yy + " ");
        }
    }
    class Order
    {
        int id;
        string name;
        string city;

        public Order(int id, string name, string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
        public void show()
        {
            Console.WriteLine(id + " " + name + " " + city + " ");
        }
    }
    class Shipment
    {
        int shipmentid;
        Order odr;
        Order_date od;


        public Shipment(int shipmentid, Order odr, Order_date od)
        {
            this.shipmentid = shipmentid;
            this.odr = odr;
            this.od = od;
        }
        public void display()
        {
            Console.WriteLine(shipmentid);
            odr.show();
            od.show();
        }

        static void Main(string[] args)
        {

            Shipment s = new Shipment(4454, new Order(101, "mobile", "Pune"), new Order_date(13, 23, 22));
            s.display();
        }
    }


}
