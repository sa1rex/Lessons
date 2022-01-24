using System;
using System.Globalization;



namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "9";

            int a;

            bool result = int.TryParse(str, out a );

            if (result)
            {
                Console.WriteLine("Successful is " + a);
            }
            else
            {
                Console.WriteLine(" Fail ");
            };
            
               

        }
    }
}
