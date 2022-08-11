using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.ExceptionHandle
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter two number");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine(n1 / n2);
                Console.WriteLine("try end");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("in 1 catch");
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("in 2 catch");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("in 3 catch");
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("enter name");
                string name = Console.ReadLine();

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("code executed");
            }

            for (int i = 0; i < 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("main end");
        }
    }
    class Class2
    {
        public static void m1(int a, int b)
        {
            Console.WriteLine("m1 start");
            Console.WriteLine("div" + a / b);
        }
        public static void m2(int x, int y)
        {
            Console.WriteLine("in m2 start");
            m1(x, y);
            Console.WriteLine("in m2 end");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("main start");
            try
            {
                m2(10, 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.WriteLine("main end");
        }
    }
    class Class3
    {//nested try, catch , finally
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter 2 number");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("division="+n1/n2);

                try
                {
                    Console.WriteLine("enter string");
                    string name = Console.ReadLine();
                    Console.WriteLine(name[5]);
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("code executed");
            }
        }
    }
    class InvalidPasswordexception : ApplicationException
    {
        public InvalidPasswordexception()
            {
            }
        public InvalidPasswordexception(string msg) : base(msg)
        {

        }
    }
    class stud
    {
        string username;
        string password;
        public string Username
        {
            set { this.username=value; }
            get { return username; }
        }
        public string Password
        {
            set
            {
                if (value.Length <= 5)
                {
                    throw new InvalidPasswordexception("password length greater than 5");
                }
                else
                {
                    this.password = value;
                }
            }
            get { return password; }
        } 
        static void Main(string[] args)
        {
            stud s = new stud();
            s.Username = "saurabh";
            try
            {
                s.Password = "abdc";
            }
            catch(InvalidPasswordexception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("main end");
        }
    }
}
