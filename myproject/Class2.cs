using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class Class2
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
           char[] s1 = s.ToCharArray();
            int i;
            int count = 0;
            
            for (i = 0; i < s1.Length; i++)
            {
                if (((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] >= 'Z')))
                {

                    count++;

                }                       
                          
            }
            if (count==s1.Length)
                 Console.WriteLine("string is valid");
            
            else
              Console.WriteLine("string is  not valid");
            
        }

        
    }
}
