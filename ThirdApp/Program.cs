using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Please Enter a Number: ");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number % 5 == 0)
                {
                    Console.WriteLine("The number is divisible on 5.");
                }
                else
                {
                    Console.WriteLine("The number is not divisible on 5.");

                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}
