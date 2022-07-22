using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Stringdemo
{
    class Basic
    {
        static void Main(string[] args)
        {
            string s = "Saurabh kakade";
            Console.WriteLine(s);
            Console.WriteLine(s.Length);
            Console.WriteLine(s[3]);
            Console.WriteLine(s.IndexOf('k'));
            Console.WriteLine(s.LastIndexOf('h'));
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.StartsWith("Saurabh"));
            Console.WriteLine(s.EndsWith("kakade"));
            Console.WriteLine("/////////////////////////////////////");
            string s2 = "    my name is saurabh     ";
            Console.WriteLine(s2.Trim());
            string s3 = s2.Replace('a', 'm');
            Console.WriteLine(s3);
            string s4 = s.Substring(4);
            Console.WriteLine(s4);
            Console.WriteLine(s.Substring(5, 8));
            Console.WriteLine("//////////////////////////");




        }
    }
    class Countword
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter String  : ");
            string s = Console.ReadLine();

            string[] words = s.Split(" ");
            
            Console.WriteLine("Count of words :"+ words.Length);

        }



    }
    class Reverse
    {


        static void Main(string[] args)
        {
            Console.WriteLine("enter the string ");
            string s = Console.ReadLine();
            char[] ch = s.ToCharArray();
            string reverse = "";
            for (int i = ch.Length; i >= 0; i--)
            {
                reverse = reverse + ch[i];

            }
            Console.WriteLine(reverse);



        }
    }
    class Reverse1
    {

        public static string Reverseeachword(string str)
        {
            string[] s = str.Split(" ");
            string reverse = "";
            for (int i = 0; i < s.Length; i++)
            {
                string word = s[i];
                string reversword = "";
                for (int j = word.Length; j >= 0; j--)
                {
                     reversword = reversword + word[j];

                }
                reverse = reverse + " " + reversword;


            }
            return reverse;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            string reversenew = Reverseeachword(s);
            Console.WriteLine(reversenew);


        }
    }
    class Digitsum
    {
        public static int Checksum(string s)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    int x = (int)char.GetNumericValue(s[i]);
                    sum = sum + x;
                    count++;

                }
            }
            Console.WriteLine(count);
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            int digitsum = Digitsum.Checksum(str);
            Console.WriteLine(digitsum);

            Console.ReadKey();

        }
    }
    class ReverseWordExcept
    {
        public static string ReverseShow(string str)
        {
            string[] s = str.Split(" ");
            string reverse = "";
            for (int i = 0; i < str.Length; i++)
            {//for(int=str.Length-1;i>=0;i--),,,for reverse string
                String word = s[i];
                string reverseword = " ";
                for (int j = word.Length - 2; j >= 1; j--)//for reverse for(int j=word.Length-1;j>=0;j--)
                {
                    reverseword = reverse + word[j];
                }
                reverse = reverse + " " + reverseword;
            }
            return reverse;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            string reversenew = ReverseShow(s);
            Console.WriteLine(reversenew);
            Console.ReadLine();
        }
    }
    class Patternsentence
    {
        public void show(string str)
        {
            string[] p = str.Split(" ");
            for (int i = 0; i <= p.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(p[i]);
                }
                Console.WriteLine();
            }



        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            Patternsentence st = new Patternsentence();
            Console.WriteLine(st);
        }
    }
    class ToggleCase
    {
        
        public static string Show(string str)
        {
            string toggle = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    toggle = toggle + ((char)(str[i] - 32));
                }
                else if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    toggle = toggle + ((char)(str[i] + 32));
                }
                else
                {
                    toggle = toggle + str[i];
                }
            }
            return toggle;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter strig");
            string s = Console.ReadLine();
            Console.WriteLine(Show(s));
           
            
        }
    }



    class stringPalindrone
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter the string");
            string s = Console.ReadLine();
            string revers = "";
            for (int i = s.Length; i >=0; i--)
            {
                revers = revers + s[i].ToString();
            }
            if(revers==s)
            {
                Console.WriteLine(" palindrone");
            }
            else
                Console.WriteLine("not");

        }
    }
    class longestword
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string str = Console.ReadLine();
            string[] s = str.Split();
            int maxlength = 0;
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length>maxlength)
                {
                    maxlength = s[i].Length;

                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (maxlength==s[i].Length)
                {
                    Console.WriteLine(s[i]);
                }
            }
             
        }

    }
    class sorting
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 4, 8, 5, 3, 9, };
            Console.WriteLine(string.Join(" ",a));
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i]<a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;


                    }
                }
            }

            Console.WriteLine(string.Join(" ",a)); 
        }
    }
    class togglecase2

    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string newstr = " ";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsUpper(ch))
                {
                    ch = (char)(ch + 32);
                }
                else if (char.IsLower(ch))
                {
                    ch = (char)(ch - 32);
                }
               
                newstr = newstr + ch;

            }
            Console.WriteLine(newstr);
        }
    }
   
     class Wordocc
    {

        static void Main(string[] args)
        {
            
           
            string s = Console.ReadLine();
            string word = Console.ReadLine(); 
            string[] temp = s.Split();
            int count = 0;
            for (int i = 0; i < temp.Length; i++)
            {
             
                if (word==(temp[i]))
                {
                    count++;
                    
                }

            }
            Console.WriteLine(word+ count);




        }
    }
    class StringarrayDigit
    {//A+1,B+4,V+1 take character input from user if that char presnt in this array display it integer value
        public void show(string s)
        {
            char[] ch = s.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (char.IsDigit(ch[i]))
                {
                    Console.WriteLine(ch[i]);
                }
            }

        }
        static void Main(string[] args)
        {
            string[] s = { "A+3", "B+6", "c+9", "z+8" };
            Console.WriteLine("Enter char");
            char c = char.Parse(Console.ReadLine());
            for (int i = 0; i < s.Length; i++)
            {
                char[] word = s[i].ToCharArray();
                for (int j = 0; j < s[i].Length; j++)
                {
                    if (c == word[j])
                    {

                    }
                }

            }
            Console.ReadLine();

        }


    }
    class FindLongestword
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string str = Console.ReadLine();
            string[] s = str.Split(' ');
            int Maxlength = 0;
            string Longestword = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > Maxlength)
                {
                    Maxlength = s[i].Length;
                    //Longestword=s[i]
                }

            }
            for (int i = 0; i < s.Length; i++)
            {
                if (Maxlength == s[i].Length)
                {
                    Console.WriteLine(s[i]);
                }
            }
            Console.ReadLine();
        }
    }
    class StringSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string str = Console.ReadLine();
            String[] s = str.Split();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i].CompareTo(s[j]) == 1)
                    {
                        string temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }

                }
            }
            Console.WriteLine(string.Join(" ", s));
            Console.ReadLine();
        }
    }
    

      class Abc
    {
        static void Main(string[] args)
        {
            //Accept Size
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            //Accept data
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            int j;
            int max = 0;
            int zero, ones;

            //Find Largest subarray length have equal zero and one 

            for (int i = 0; i < arr.Length; i++)
            {
                zero = 0;
                ones = 0;
                for (j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                        zero++;
                    else
                        ones++;

                    if (zero == ones)
                    {
                        max = max > (j - i + 1) ? max : j - i + 1;
                    }
                }

            }
            Console.WriteLine(max);
        }
    }
    class Cuckoo
    {
        int coo(int s)
        {
            if (s == 1)
            {
                s = 0;
            }
            if (s == 2)
            {
                s = 1;
            }

            return s;
        }
        static void Main(string[] args)
        {


            Cuckoo ck = new Cuckoo();
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
          //  int cu1 = 0;
            //int cu2 = 1;

            if (n == 1)
            {
                Console.WriteLine("0");
            }
            else if (n == 2)
            {
                Console.WriteLine("1");

            }
            else if (n > 2)
            {
                c = 1 * ck.coo(n - 1) + 2 * ck.coo(n - 2) + 3 * 1;

                Console.WriteLine(c);
            }
        }
    }
    class CoPrime
    {
        //find the number of coPrime of given number
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int gcd = 0;
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0 && n % j == 0)
                    {
                        gcd = j;
                    }
                }
                if (gcd == 1)
                {
                    c++;
                }

            }
            Console.WriteLine("Number of CoPrime number" + c);

        }
    }
}






