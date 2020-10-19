using System;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;

namespace ValidateYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth: ");
            string userInput = Console.ReadLine();
            if(Validate(userInput))
            {
                CalculateAge(userInput);
            }else
            {
                Console.WriteLine("Wrong format, try again.");
            }
        }

        public static bool Validate(string yearofbirth)
        {
            if (yearofbirth.Length == 4)
            {
                try
                {
                    long.Parse(yearofbirth);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format: {e}");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static void CalculateAge(string yearofbirth)
        {
            int year = Int32.Parse(yearofbirth);

            DateTime now = DateTime.Now;
            string currentYear = now.Year.ToString();
            int yearNow = Int32.Parse(currentYear);
            int age = yearNow - year;

            Console.WriteLine($"You are {age} years old.");
        }
    }
}

