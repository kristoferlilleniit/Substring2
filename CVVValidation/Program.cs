using System;

namespace CVVValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your CVV number: ");
            string userInput = Console.ReadLine();
            if (Validate(userInput))
            {
                Console.WriteLine("Yes.");
            }
            else
            {
                Console.WriteLine("Wrong format, try again.");
            }
        }

        public static bool Validate(string cvvnumber)
        {
            if (cvvnumber.Length == 3)
            {
                try
                {
                    Int32.Parse(cvvnumber);
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
    }
}
