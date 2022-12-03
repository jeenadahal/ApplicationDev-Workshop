using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Week4
{
    internal class AccessModifiers
    {
        //types of access modifiers: private, protected, internal,public,protected-internal and private-protected.
        //The protected internal keyword combination is a member access modifier. A protected internal member is
        //accessible from the current assembly or from types that are derived from the containing class.
        public class MainClassAccessModifiers
        {
            private static void privateMethod()
            {
                Console.WriteLine("This is private method.");
            }

            protected virtual void protectedMethod()
            {
                Console.WriteLine("This is protected method.");
            }

            internal static void internalMethod()
            {
                Console.WriteLine("This is internal method.");
            }

            public static void publicMethod()
            {
                Console.WriteLine("This is private method.");
            }

            public class Greet
            {
                protected internal string msg = "Hello";
            }

            class Program
            {
                static void Main(string[] args)
                {
                    Greet greet = new Greet();
                    Console.WriteLine(greet.msg);
                    Console.ReadLine();
                }
            }


        }
    }
}
