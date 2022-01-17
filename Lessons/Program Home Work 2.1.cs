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

            const double usdc = 27.96;

            const double eurc = 31.95;

            const double rubc = 0.37;

          Console.WriteLine("Hello this is Currency Program");
            
           
            Console.WriteLine("UAH to USD / EUR / RUB");

            string str = Console.ReadLine();

            double uah = Convert.ToDouble(str);

            double usd = uah / usdc;

            double eur = uah / eurc;

            double rub = uah / rubc;

            Console.WriteLine(" USD = " + usd);
            Console.WriteLine(" EUR = " + eur);
            Console.WriteLine(" RUB = " + rub);



        }
    }
}
