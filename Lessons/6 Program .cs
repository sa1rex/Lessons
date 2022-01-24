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

            }
                ;

            string str;

            str = Console.ReadLine();

            double a = Convert.ToDouble(str, numberFormatInfo);

            Console.WriteLine(a);

        }
    }
}
