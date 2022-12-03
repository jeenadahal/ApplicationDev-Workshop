using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Week4
{
    public abstract class AbstractionClass
    {
        public abstract int printAge(int age);
    }

    public class Age : AbstractionClass
    {
        // Overriding the method inside abstract class
        public override int printAge(int age)
        {
            Console.Write("Hello! My name is ");
            return age;
        }

    }

    public class CallingAge
    {
        public static void mainMethod()
        {
            Age myage = new Age();
            int result = myage.printAge(20);
            Console.WriteLine(result);
        }
    }
}
