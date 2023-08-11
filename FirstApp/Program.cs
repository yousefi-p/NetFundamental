using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, familyName, dateOfBirth;
            int input;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetBufferSize(120, 100);
            Console.SetCursorPosition(50, 2);
            Console.SetWindowSize(100, 30);
            Console.WriteLine("WELCOME ");
            Console.SetCursorPosition(0, 5);
            bool condition = true;
            do
            {

                do
                {
                    Console.WriteLine("Please, Enter your name: ");
                    name = Console.ReadLine().Trim();
                } while (CheckAlph(name) != true);


                do
                {
                    Console.WriteLine("Please, Enter your family name: ");
                    familyName = Console.ReadLine().Trim();
                } while (CheckAlph(familyName) != true);

                do
                {
                    Console.WriteLine("Please, Enter your Date of your Birth(YYYY): ");
                    dateOfBirth = Console.ReadLine().Trim();
                } while (CheckDigit(dateOfBirth) != true || dateOfBirth.Length != 4);

                do
                {
                    Console.Clear();
                    Console.WriteLine("For Summery Enter 1 and for Details Enter 2 :");
                    try
                    {
                        input = int.Parse(Console.ReadLine());
                    }
                    catch { input = 0; }
                    
                } while (input < 1 || input > 2);
                
                if (input == 1)
                {
                    Console.WriteLine("You are {0} and Your age is {1}.", name.ToUpper(), BirthCalculator(dateOfBirth));
                }
                else if (input == 2)
                {
                    Console.WriteLine("Name: {0}\nLast Name: {1}\nDate of Birth: {2}\nAge: {3}", name.ToUpper(), familyName.ToUpper(), dateOfBirth, BirthCalculator(dateOfBirth));
                }

                condition = false;
                
            }while(condition);
            Console.ReadLine();
        }



        static bool CheckAlph(string str)
        {
            foreach (char c in str)
            {
                if (!Char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckDigit(string str)
        {
            foreach(char c in str)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        static int BirthCalculator(string str)
        {
            return DateTime.Today.Year - int.Parse(str);
        }
    }
}
