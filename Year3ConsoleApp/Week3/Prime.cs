using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Week3
{
    internal class Prime
    {
        public static void CheckPrime()
        {
            var primeCheck = 0;
            Console.WriteLine("Enter any number:");
            var num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    primeCheck++;
                }
            }

                if (primeCheck==2)
            {
                Console.WriteLine($"{num} is a prime number.");
            }
                else
                {
                    Console.WriteLine($"{num} is not prime number.");
                }
            
        }
    }
}
