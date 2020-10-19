using System;

namespace LOGITpe20
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayLOGIT("LOGITpe20");
        }

        public static void DisplayLOGIT(string logit)
        {
            string newString = logit.Substring(0, 5);
            Console.WriteLine(newString);
            string pe = logit.Substring(5, 2);
            Console.WriteLine(pe);
            string l20 = logit.Substring(7, 2);
            Console.WriteLine(l20);
        }
    }
}
