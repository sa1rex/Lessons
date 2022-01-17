using System;
using System.Globalization;



namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {

                NumberDecimalSeparator = ".",
            };

          Console.WriteLine("Hello this is Midlle Average Program");

           
            Console.WriteLine("Type please first number");

            string str = Console.ReadLine();

            double a = Convert.ToDouble(str);

            Console.WriteLine("Type please second number");

            string str2 = Console.ReadLine();

            double b = Convert.ToDouble(str2);

            Console.WriteLine("Type please third number");

            string str3 = Console.ReadLine();

            double c = Convert.ToDouble(str3);

            double summ = (double) (a + b + c);

            Console.WriteLine("Summ " + summ);

        }
    }
}
