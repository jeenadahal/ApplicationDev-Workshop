using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Week2
{
    public class SelectStatement
    {
        public static void IfElse(int num1 , int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than  {num2}");
                
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} is less than  {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} equals to  {num2}");
            }

           
        }

    }
}
