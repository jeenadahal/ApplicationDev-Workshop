using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Week4
{
    internal class PolymorphismClass
    {

        public void overloading1(string x, string y)
        {
            Console.WriteLine($"The result is: {x + y}");
        }

        public void overloading2(int x, int y)
        {
            Console.WriteLine($"The result is: {x + y}");
        }

        public virtual void methodOverride()
        {
            Console.WriteLine("This is base/parent class.");
        }


        public class ChildClass : PolymorphismClass
        {
            // Overrding method overrideMethod()
            public override void methodOverride()
            {
                Console.WriteLine("This is derived/child class.");
            }
        }

        public class MainClass
        {
            public static void mainMethod()
            {
                ChildClass child1 = new ChildClass();

                child1.overloading1("5", "7");

                child1.overloading2(5,7);

                child1.methodOverride();
            }
        }
    }
}
