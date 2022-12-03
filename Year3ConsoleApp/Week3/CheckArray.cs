using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Week3
{
    internal class CheckArray
    {
        public static void searchArrayElement()
        {
            bool found = false;
            Console.WriteLine("Enter a number to search:");
            var num = Convert.ToInt32(Console.ReadLine());

            var nums = new[] { 1, 10, 5, 3 };

            for (int i = 0; i < nums.Length; i++)
            {
                if (num == nums[i])
                {
                    found = true;
                    Console.WriteLine($"Num {num} found in an array.");
                    break;
                }
            }

            if (found == false)
            {
                Console.WriteLine($"Num {num} not found in array.");
            }

        }
    }
}

