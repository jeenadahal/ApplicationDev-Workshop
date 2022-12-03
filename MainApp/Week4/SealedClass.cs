using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Week4
{
    sealed class SealedClass
    {
        // A sealed class, in C#, is a class that cannot be inherited by any class but can be instantiated.

        // Calling Function
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    class Program
    {

        // Main Method
        static void Main(string[] args)
        {

            // Creating an object of Sealed Class
            SealedClass slc = new SealedClass();

            // Performing Addition operation
            int total = slc.Add(6, 4);
            Console.WriteLine("Total = " + total.ToString());
        }
    }

}

