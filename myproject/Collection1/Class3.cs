using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Collection1
{
    class Class3//hashset
    {
        static void Main(string[] args)
        {
            HashSet<string> hs1 = new HashSet<string>() { "a", "bb", "cc", "zz" };
            HashSet<string> hs2 = new HashSet<string>() { "dd", "bb", "cc", "ee", "ff" };
            hs1.IntersectWith(hs2);
            
            Console.WriteLine(hs2.IsSubsetOf(hs1));
            foreach (string s in hs1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("////////////////////");
            foreach (string s in hs2)
            {
                Console.WriteLine(s);


              





            }
        }

    }
    class hashset2
    {
        
    }
}
