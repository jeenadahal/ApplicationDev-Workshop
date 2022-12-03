using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Week3
{
    internal class Swap
    {
        public static void CheckSwap()
        {
            Console.Write("Enter num1 : ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num2 : ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Number before swapping: num1 = {num1} , num2 = {num2}");


            var temp = 0;

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"Number before swapping: num1 = {num1} , num2 = {num2}");
        }
    }
}
