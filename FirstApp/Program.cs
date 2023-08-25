using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetBufferSize(120, 100);
            Console.SetCursorPosition(50, 2);
            Console.SetWindowSize(100, 30);
            Console.WriteLine("WELCOME ");
            Console.SetCursorPosition(0, 5);
            bool condition = true;
            int input;
            do
            {

                do
                {
                    Console.WriteLine("Please, Enter your name: ");
                    person.name = Console.ReadLine().Trim();
                } while (person.CheckAlph(person.name) != true);


                do
                {
                    Console.WriteLine("Please, Enter your family name: ");
                    person.familyName = Console.ReadLine().Trim();
                } while (person.CheckAlph(person.familyName) != true);

                do
                {
                    Console.WriteLine("Please, Enter your Date of your Birth(YYYY): ");
                    person.dateOfBirth = Console.ReadLine().Trim();
                } while (person.CheckDigit(person.dateOfBirth) != true || person.dateOfBirth.Length != 4);

                do
                {
                    Console.WriteLine("Please, Enter your Cell phone number: ");
                    person.cellPhone = person.CheckCellPhone(Console.ReadLine().Trim());
                    if (person.cellPhone.Equals('0'))
                    {
                        continue;
                    }
                } while (person.CheckDigit(person.cellPhone) != true && person.cellPhone.Length != 11);

                do
                {

                Console.WriteLine("Please Choose your gender from one of the following number: ");
                Console.WriteLine("\t1. MALE\n\t2. FEMALE\n\t3. Non-Binary\n");
                person.gender = person.CheckGender((Console.ReadLine().Trim().ToLower()).ToCharArray()[0]);
                } while (person.gender.Length != 1 || int.Parse(person.gender) > 3);

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
                    Console.WriteLine("You are {0} and Your age is {1}.", person.name.ToUpper(), person.BirthCalculator(person.dateOfBirth));
                }
                else if (input == 2)
                {
                    Console.WriteLine("Name: {0}\nLast Name: {1}\nDate of Birth: {2}\nAge: {3}\nGender: {4}\nPhone Number: {5}", person.name.ToUpper(), person.familyName.ToUpper(), person.dateOfBirth, person.BirthCalculator(person.dateOfBirth), person.gender, person.cellPhone);
                }

                condition = false;

            } while (condition);
            Console.ReadLine();
        }


        class Person
        {
            public string name, familyName, dateOfBirth, cellPhone;
            public string gender;
            public bool mustGoToMiliteryService;


            public bool CheckAlph(string str)
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

            public bool CheckDigit(string str)
            {
                foreach (char c in str)
                {
                    if (!Char.IsDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }

            public int BirthCalculator(string str)
            {
                return DateTime.Today.Year - int.Parse(str);
            }

            public string CheckCellPhone(string phone)
            {
                if (phone.StartsWith("+98"))
                {
                    phone = "0" + phone.Substring(3);
                }
                if (phone.StartsWith("09") || phone.Length == 11)
                {
                    return phone;
                }
                return "0";

            }

            public string CheckGender(char gender)
            {
                if (gender.Equals('1') || gender.Equals("m"))
                {
                    return "M";
                }
                else if (gender.Equals("2") || gender.Equals("f"))
                {
                    return "F";
                }
                else if(gender.Equals("3") || gender.Equals("non-binary"))
                {
                    return "Non-Binary";
                }
                else
                {
                    return "e";
                }
            }

        }
    }

}
