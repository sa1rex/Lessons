using System;
using System.Globalization;



namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {

            double USDtoRUB = 70.5;
            double USDtoUAH = 27.9;
            double USD;

            Console.WriteLine("Type USD Value");

            USD = double.Parse(Console.ReadLine());

            Console.WriteLine("USD = " + USD * USDtoRUB + " RUB");
            Console.WriteLine("USD = " + USD * USDtoUAH + " UAH");
        }
    }
}
