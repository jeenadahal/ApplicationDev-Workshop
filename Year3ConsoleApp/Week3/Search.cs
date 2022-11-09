using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Week3
{
    internal class Search
    {
        public static void CheckElement()
        {
            bool found = false;
            Console.WriteLine("Enter any number:");
            var num = Convert.ToInt32(Console.ReadLine());

            var numbers = new[]{ 1, 2, 3, 4, 5};

            for (int i = 0; i < numbers.Length; i++) 
            {
                if (num == numbers[i])
                {
                    found = true;
                    Console.WriteLine($"Number {num} found in the array.");
                    break;
                    
                }

            }
            if (found == false)
            {
               
                Console.WriteLine($"Number {num} not found in the array.");
                

            }


        }
    }
}
