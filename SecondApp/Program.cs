using System;

namespace SecondApp
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
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is EVEN.");
                }
                else { Console.WriteLine("The number is ODD.");
                    
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
