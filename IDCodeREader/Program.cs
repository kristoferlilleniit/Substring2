using System;
using System.Security.Cryptography.X509Certificates;

namespace IDCodeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your ID code: ");
            string usersID = Console.ReadLine();

            if(Validate(usersID))
            {
                Console.WriteLine("Welcome!");
            }else
            {
                Console.WriteLine("Wrong format, try again.");
            }
            HelloUser(usersID);
            GetYear(usersID);
        }

        public static bool Validate(string idCode)
        {
            if(idCode.Length == 11)
            {
                try
                {
                    long.Parse(idCode);
                    return true;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Wrong format: {e}");
                    return false;
                }
            }else
            {
                return false;
            }
           }
            public static void HelloUser(string idCode)
            {
                int firstNum = Int32.Parse(idCode[0].ToString());

                if(firstNum == 1 || firstNum == 3 || firstNum == 5)
                {
                    Console.WriteLine("Hello, Sir!");
                }else if(firstNum == 2 || firstNum == 4 || firstNum == 6)
                {
                    Console.WriteLine("Hello, Madam!");
                }
             }
            public static void GetYear(string idCode)
            {


                string yearfromcode = idCode.Substring(1, 2);
                string year;
                if(int.Parse(idCode[0].ToString()) > 4)
                {
                year = "20" + yearfromcode;
                }else
                {
                year = "19" + yearfromcode;
                }

            Console.WriteLine($"You were born in {year}");
            }
    }
}
